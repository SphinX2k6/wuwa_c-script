using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02004BA6 RID: 19366
	internal class CiacconaGalPlayerChoosingState : BaseCiacconaGalPlayerState
	{
		// Token: 0x060305A0 RID: 198048 RVA: 0x00D7AD63 File Offset: 0x00D78F63
		[NullableContext(1)]
		public CiacconaGalPlayerChoosingState(CiacconaGalPlayer owner, ECiacconaGalPlayerState state, [Nullable(new byte[]
		{
			2,
			1
		})] StateMachine<CiacconaGalPlayer, ECiacconaGalPlayerState> stateMachine) : base(owner, state, stateMachine)
		{
		}

		// Token: 0x060305A1 RID: 198049 RVA: 0x00D7AD6E File Offset: 0x00D78F6E
		protected override void OnEnter(ECiacconaGalPlayerState? lastState)
		{
			base.OnEnter(lastState);
			CiacconaGalModel.Instance.IsCurStepDataListDirty = true;
		}

		// Token: 0x060305A2 RID: 198050 RVA: 0x00D7AD84 File Offset: 0x00D78F84
		public override void OnClick(int? choiceId = null)
		{
			if (choiceId == null)
			{
				return;
			}
			CiacconaGalChoiceData choiceDataById = CiacconaGalModel.Instance.GetChoiceDataById(choiceId.Value);
			if (choiceDataById == null)
			{
				return;
			}
			CiacconaGalStepData stepDataById = CiacconaGalModel.Instance.GetStepDataById(this.Owner.CurHandlingStepId);
			int toStepId = (choiceDataById.ToStepId == 0) ? stepDataById.NextStepId : choiceDataById.ToStepId;
			int id = CiacconaGalModel.Instance.ActivityData.Id;
			int curHandlingChapterId = this.Owner.CurHandlingChapterId;
			int inspirationCount = CiacconaGalModel.Instance.ActivityData.InspirationCount;
			int requiredInspiration = choiceDataById.RequiredInspiration;
			switch (choiceDataById.State)
			{
			case ECiacconaGalStepState.Normal:
				stepDataById.ChosenId = choiceId.Value;
				this.Owner.TryContinue(toStepId);
				return;
			case ECiacconaGalStepState.LockingByInspiration:
				if (inspirationCount >= requiredInspiration)
				{
					CiacconaGalController.Instance.RequestUnlockChoice(id, curHandlingChapterId, choiceId.Value);
					return;
				}
				GenericPromptController.Instance.ShowPromptByCode("InspirationNotEnough", Array.Empty<object>());
				return;
			case ECiacconaGalStepState.LockingByCondition:
				GenericPromptController.Instance.ShowPromptByCode("RequireConditionToUnlock", Array.Empty<object>());
				return;
			case ECiacconaGalStepState.Chosen:
				EventSystem.Instance.Emit<CiacconaGalStepData, CiacconaGalChoiceData>(EEventName.OnCiacconaAvgReChoose, stepDataById, choiceDataById);
				return;
			default:
				return;
			}
		}
	}
}
