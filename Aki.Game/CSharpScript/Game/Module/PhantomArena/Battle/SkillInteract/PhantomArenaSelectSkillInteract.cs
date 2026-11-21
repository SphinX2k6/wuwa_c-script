using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Battle.View;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.PhantomArena.Battle.SkillInteract
{
	// Token: 0x02004252 RID: 16978
	public class PhantomArenaSelectSkillInteract : PhantomArenaSkillInteractBase, ISkillInteractMainUiInteract
	{
		// Token: 0x0602AF41 RID: 175937 RVA: 0x00C15EE4 File Offset: 0x00C140E4
		private void TriggerCardActiveSkill()
		{
			PhantomCardData phantomCardData;
			if (this.Data.IsFight)
			{
				phantomCardData = PhantomArenaBattleModel.Instance.OwnData.GetBattleCardByCardId(this.Data.DataId.Value);
			}
			else
			{
				phantomCardData = PhantomArenaBattleModel.Instance.OwnData.GetHandCardDataByCardId(this.Data.DataId.Value);
			}
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(phantomCardData.ConfigId);
			this.BattleProxy.SkillTriggerMask.ShowTriggerMask(new int?(phantomBattleCardConfig.ActiveSkillId));
			this.BattleProxy.SkillTriggerMask.RefreshSkill(phantomBattleCardConfig.Name, phantomBattleCardConfig.CardEffectDescription, phantomBattleCardConfig.CardEffectDescriptionParams());
		}

		// Token: 0x0602AF42 RID: 175938 RVA: 0x00C15F9C File Offset: 0x00C1419C
		private void TriggerCardClickSkill()
		{
			PhantomCardData battleCardByCardId = PhantomArenaBattleModel.Instance.OwnData.GetBattleCardByCardId(this.Data.DataId.Value);
			PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(battleCardByCardId.ConfigId);
			this.BattleProxy.SkillTriggerMask.ShowTriggerMask(new int?(battleCardByCardId.ClickActiveSkillId));
			this.BattleProxy.SkillTriggerMask.RefreshSkill(phantomBattleCardConfig.Name, phantomBattleCardConfig.DurableSkillDescription, phantomBattleCardConfig.DurableSkillDescriptionParams());
		}

		// Token: 0x0602AF43 RID: 175939 RVA: 0x00C16020 File Offset: 0x00C14220
		private void TriggerPassiveSkill()
		{
			this.BattleProxy.SkillTriggerMask.ShowTriggerMask(this.Data.DataId);
			if (this.Data.DataId != null)
			{
				PhantomCardData battleCardByCardId = PhantomArenaBattleModel.Instance.OwnData.GetBattleCardByCardId(this.Data.DataId.Value);
				PhantomBattleCard phantomBattleCardConfig = PhantomArenaConfig.Instance.GetPhantomBattleCardConfig(battleCardByCardId.ConfigId);
				if (battleCardByCardId.IsField)
				{
					Span<int> passiveSkillIdBytes = phantomBattleCardConfig.GetPassiveSkillIdBytes();
					string skillDesc = (passiveSkillIdBytes.Length > 0) ? phantomBattleCardConfig.CardEffectDescription : phantomBattleCardConfig.CountSkillDescription;
					string[] paramsList = (passiveSkillIdBytes.Length > 0) ? phantomBattleCardConfig.CardEffectDescriptionParams() : phantomBattleCardConfig.CountSkillDescriptionParams();
					this.BattleProxy.SkillTriggerMask.RefreshSkill(phantomBattleCardConfig.Name, skillDesc, paramsList);
					return;
				}
				this.BattleProxy.SkillTriggerMask.RefreshSkill(phantomBattleCardConfig.Name, phantomBattleCardConfig.CardEffectDescription, phantomBattleCardConfig.CardEffectDescriptionParams());
			}
		}

		// Token: 0x0602AF44 RID: 175940 RVA: 0x00C16120 File Offset: 0x00C14320
		private void TriggerRoleSkill()
		{
			this.BattleProxy.SkillTriggerMask.ShowTriggerMask(this.Data.DataId);
			if (this.Data.DataId != null)
			{
				int roleId = PhantomArenaBattleModel.Instance.OwnData.RoleId;
				PhantomBattleCardRole phantomBattleCardRole = PhantomArenaConfig.Instance.GetPhantomBattleCardRole(roleId);
				int num = phantomBattleCardRole.GetActiveSkillIdBytes().IndexOf(this.Data.DataId.Value);
				string skillName = phantomBattleCardRole.SkillNameList()[num];
				string skillDesc = phantomBattleCardRole.SkillDescList()[num];
				string[] paramsList = (phantomBattleCardRole.SkillDescParamsList() != null && num < phantomBattleCardRole.SkillDescParamsList().Length) ? phantomBattleCardRole.SkillDescParamsList()[num].ArrayString() : new string[0];
				this.BattleProxy.SkillTriggerMask.RefreshSkill(skillName, skillDesc, paramsList);
			}
		}

		// Token: 0x0602AF45 RID: 175941 RVA: 0x00C161FC File Offset: 0x00C143FC
		private void TriggerSkill()
		{
			if (this.Data.IsRole)
			{
				this.TriggerRoleSkill();
				return;
			}
			if (this.Data.IsPassive)
			{
				this.TriggerPassiveSkill();
				return;
			}
			if (this.Data.DataId != null)
			{
				if (this.Data.IsClickInteract)
				{
					this.TriggerCardClickSkill();
					return;
				}
				this.TriggerCardActiveSkill();
			}
		}

		// Token: 0x0602AF46 RID: 175942 RVA: 0x00C16260 File Offset: 0x00C14460
		private void ShowSkillTriggerMask()
		{
			this.TriggerSkill();
			this.BattleProxy.SkillTriggerMask.RefreshTips(this.SelectedIdMap.Count, this.ConditionSize);
			this.BattleProxy.SkillTriggerMask.RefreshCancelBtnActive(this.Data.IsPassive);
		}

		// Token: 0x0602AF47 RID: 175943 RVA: 0x00C162B0 File Offset: 0x00C144B0
		private void SortOrderAreaCanvas()
		{
			List<EPhantomArenaInteractTag> list = new List<EPhantomArenaInteractTag>
			{
				EPhantomArenaInteractTag.OwnMonster,
				EPhantomArenaInteractTag.OpponentAreaMonster
			};
			if (this.Data.IsRole)
			{
				list.Add(EPhantomArenaInteractTag.OwnSkill);
			}
			this.BattleProxy.CanvasManager.SortOrderAreaCanvas(list, this.Data, this);
		}

		// Token: 0x0602AF48 RID: 175944 RVA: 0x00C16300 File Offset: 0x00C14500
		protected override UniTask<EPhantomArenaSkillInteractExecuteResult> OnExecute([Nullable(1)] PhantomArenaBattleProxy proxy)
		{
			PhantomArenaSelectSkillInteract.<OnExecute>d__10 <OnExecute>d__;
			<OnExecute>d__.<>t__builder = AsyncUniTaskMethodBuilder<EPhantomArenaSkillInteractExecuteResult>.Create();
			<OnExecute>d__.<>4__this = this;
			<OnExecute>d__.proxy = proxy;
			<OnExecute>d__.<>1__state = -1;
			<OnExecute>d__.<>t__builder.Start<PhantomArenaSelectSkillInteract.<OnExecute>d__10>(ref <OnExecute>d__);
			return <OnExecute>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF49 RID: 175945 RVA: 0x00C1634C File Offset: 0x00C1454C
		protected UniTask<bool> TryHandleFinish()
		{
			PhantomArenaSelectSkillInteract.<TryHandleFinish>d__11 <TryHandleFinish>d__;
			<TryHandleFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<TryHandleFinish>d__.<>4__this = this;
			<TryHandleFinish>d__.<>1__state = -1;
			<TryHandleFinish>d__.<>t__builder.Start<PhantomArenaSelectSkillInteract.<TryHandleFinish>d__11>(ref <TryHandleFinish>d__);
			return <TryHandleFinish>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF4A RID: 175946 RVA: 0x00C16390 File Offset: 0x00C14590
		private void Reset()
		{
			this.BattleProxy.HideLine();
			this.BattleProxy.SkillTriggerMask.HideTriggerMask();
			this.BattleProxy.CanvasManager.ResetAreaCanvas();
			foreach (int index in this.SelectedIdMap.Values)
			{
				this.BattleProxy.OwnArea.FunctionalArea.ResetCardSelectState(index);
			}
			this.BattleProxy.UnRegisterCantDragReason(EPhantomArenaCantDragReason.SelectSkillInteract);
		}

		// Token: 0x0602AF4B RID: 175947 RVA: 0x00C16430 File Offset: 0x00C14630
		protected unsafe bool OnReceiveClickData(int cardId, int index, bool isSelected)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.PhantomArena;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "Buff期间,接收到卡牌点击";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("卡牌Id", cardId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("是否选中", isSelected);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (isSelected && this.SelectedIdMap.Count >= this.ConditionSize)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "Buff期间,已经选择的卡牌数量达到上限,无法再选择", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			if (isSelected)
			{
				this.SelectedIdMap[cardId] = index;
				this.LastSelectedId = cardId;
			}
			else
			{
				this.SelectedIdMap.Remove(cardId);
			}
			this.BattleProxy.SkillTriggerMask.RefreshTips(this.SelectedIdMap.Count, this.ConditionSize);
			return true;
		}

		// Token: 0x0602AF4C RID: 175948 RVA: 0x00C1651C File Offset: 0x00C1471C
		protected bool OnCheckCondition()
		{
			return this.SelectedIdMap.Count >= this.ConditionSize;
		}

		// Token: 0x0602AF4D RID: 175949 RVA: 0x00C16534 File Offset: 0x00C14734
		protected UniTask<bool> OnHandleFinish()
		{
			PhantomArenaSelectSkillInteract.<OnHandleFinish>d__15 <OnHandleFinish>d__;
			<OnHandleFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<OnHandleFinish>d__.<>4__this = this;
			<OnHandleFinish>d__.<>1__state = -1;
			<OnHandleFinish>d__.<>t__builder.Start<PhantomArenaSelectSkillInteract.<OnHandleFinish>d__15>(ref <OnHandleFinish>d__);
			return <OnHandleFinish>d__.<>t__builder.Task;
		}

		// Token: 0x0602AF4E RID: 175950 RVA: 0x00C16578 File Offset: 0x00C14778
		[NullableContext(1)]
		public bool ReceiveClickData(ESkillInteractMainUiInteractType type, params object[] data)
		{
			if (type == ESkillInteractMainUiInteractType.CancelBtn)
			{
				Log.Instance.Info(ELogModule.PhantomArena, ELogAuthor.XXJ, "取消执行Buff交互操作", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.Reset();
				this.Info.CancelSkillInteract();
				return true;
			}
			if (type == ESkillInteractMainUiInteractType.ConfirmBtn)
			{
				this.TryHandleFinish().Forget<bool>();
				return true;
			}
			return this.OnReceiveClickData((int)data[0], (int)data[1], (bool)data[2]);
		}

		// Token: 0x040173D2 RID: 95186
		[Nullable(1)]
		private readonly Dictionary<int, int> SelectedIdMap = new Dictionary<int, int>();

		// Token: 0x040173D3 RID: 95187
		private int LastSelectedId = -1;

		// Token: 0x040173D4 RID: 95188
		private int ConditionSize;
	}
}
