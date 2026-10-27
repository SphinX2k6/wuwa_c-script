using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.LevelGamePlay.Guarantee;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B5D RID: 27485
	public class LevelEventRefreshInputTag : LevelEventBase
	{
		// Token: 0x060441E4 RID: 279012 RVA: 0x010C48C4 File Offset: 0x010C2AC4
		public LevelEventRefreshInputTag(int id) : base(id)
		{
		}

		// Token: 0x060441E5 RID: 279013 RVA: 0x010C48D0 File Offset: 0x010C2AD0
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

		// Token: 0x060441E6 RID: 279014 RVA: 0x010C4958 File Offset: 0x010C2B58
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
