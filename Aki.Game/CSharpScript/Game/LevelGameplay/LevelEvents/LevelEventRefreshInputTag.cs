using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CD5 RID: 23765
	public class LevelEventRefreshInputTag : LevelEventBase
	{
		// Token: 0x0603A336 RID: 238390 RVA: 0x0106E494 File Offset: 0x0106C694
		public LevelEventRefreshInputTag(int id) : base(id)
		{
		}

		// Token: 0x0603A337 RID: 238391 RVA: 0x0106E4A0 File Offset: 0x0106C6A0
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			InputController.Instance.SetMoveControlEnabled(true, true, true, true);
			LevelEventLockInputState.Instance.Unlock();
			InputDistributeController.Instance.RefreshInputTag();
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity;
			if (baseCharacter == null)
			{
				entity = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
			}
			Entity entity2 = entity;
			int num = GameplayTagDefine.EGameplayTagId["战斗状态.行为限制.禁止冲刺"];
			if (entity2 != null && entity2.Valid)
			{
				BaseTagComponent component = entity2.GetComponent<BaseTagComponent>();
				if (component != null && component.HasTag(num))
				{
					component.RemoveTag(new int?(num));
				}
			}
		}

		// Token: 0x0603A338 RID: 238392 RVA: 0x0106E528 File Offset: 0x0106C728
		protected override void OnUpdateGuarantee()
		{
			GuaranteeActionInfo p = new GuaranteeActionInfo
			{
				Name = EGuaranteeAction.UnLimitPlayerOperation
			};
			EventSystem.Instance.Emit<string, GeneralContext, GuaranteeActionInfo, bool?>(EEventName.RemGuaranteeAction, this.Type, this.BaseContext, p, null);
		}
	}
}
