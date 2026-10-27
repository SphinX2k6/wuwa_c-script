using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02005E4C RID: 24140
	public class BattleUiSpecialRoleDataAiMiSi : BattleUiSpecialRoleDataBase
	{
		// Token: 0x0603D65B RID: 251483 RVA: 0x00ECFA54 File Offset: 0x00ECDC54
		protected override void OnInit()
		{
			BattleUiRoleData roleData = this.RoleData;
			bool? flag;
			if (roleData == null)
			{
				flag = null;
			}
			else
			{
				CharacterActorComponent actorComp = roleData.ActorComp;
				flag = ((actorComp != null) ? new bool?(actorComp.IsAutonomousProxy) : null);
			}
			bool? flag2 = flag;
			this.IsAutonomousProxy = flag2.GetValueOrDefault();
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			int count = BattleUiModel.Instance.GetCount(EBattleUiCountType.AimisiRoleCount) + 1;
			BattleUiModel.Instance.SetCount(EBattleUiCountType.AimisiRoleCount, count);
			HudUnitController.Instance.TryCreateHud(EHudUnitType.AiMiSiHud);
			BattleUiRoleData roleData2 = this.RoleData;
			if (roleData2 != null)
			{
				roleData2.ListenForTagSignificantChanged(BattleUiSpecialRoleDataAiMiSi.MechanicalTag, new BaseTagComponent.TTagSwitchedCallback(this.OnMechanicalTagChanged), true);
			}
			if (!HudUnitController.Instance.GetIsInitHud())
			{
				EventSystem.Instance.Add(EEventName.HudInited, new Action(this.OnHudInited));
			}
		}

		// Token: 0x0603D65C RID: 251484 RVA: 0x00ECFB1C File Offset: 0x00ECDD1C
		protected override void OnClear()
		{
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			if (EventSystem.Instance.Has(EEventName.HudInited, new Action(this.OnHudInited)))
			{
				EventSystem.Instance.Remove(EEventName.HudInited, new Action(this.OnHudInited));
			}
			this.HasMechanicalTag = false;
			this.RefreshStrengthItem();
			this.IsAutonomousProxy = false;
			int num = Math.Max(BattleUiModel.Instance.GetCount(EBattleUiCountType.AimisiRoleCount) - 1, 0);
			BattleUiModel.Instance.SetCount(EBattleUiCountType.AimisiRoleCount, num);
			if (num <= 0)
			{
				HudUnitController.Instance.TryDestroyHud(EHudUnitType.AiMiSiHud);
			}
		}

		// Token: 0x0603D65D RID: 251485 RVA: 0x00ECFBAF File Offset: 0x00ECDDAF
		private void OnHudInited()
		{
			this.RefreshStrengthItem();
		}

		// Token: 0x0603D65E RID: 251486 RVA: 0x00ECFBB7 File Offset: 0x00ECDDB7
		public override void OnChangeRole(bool isCurEntity)
		{
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			this.RefreshStrengthItem();
		}

		// Token: 0x0603D65F RID: 251487 RVA: 0x00ECFBC8 File Offset: 0x00ECDDC8
		private void OnMechanicalTagChanged(int tagId, bool tagExist)
		{
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			this.HasMechanicalTag = tagExist;
			this.RefreshStrengthItem();
		}

		// Token: 0x0603D660 RID: 251488 RVA: 0x00ECFBE0 File Offset: 0x00ECDDE0
		private void RefreshStrengthItem()
		{
			if (!HudUnitManager.Instance.GetIsInitHud())
			{
				return;
			}
			BattleUiRoleData roleData = this.RoleData;
			if (roleData == null || !roleData.IsCurEntity || !this.HasMechanicalTag)
			{
				this.RemoveStrengthItem();
				return;
			}
			this.AddStrengthItem();
		}

		// Token: 0x0603D661 RID: 251489 RVA: 0x00ECFC1B File Offset: 0x00ECDE1B
		private void AddStrengthItem()
		{
			if (this.HasStrengthItem)
			{
				return;
			}
			this.HasStrengthItem = true;
			EventSystem.Instance.Emit<EStrengthItemType>(EEventName.AddStrengthItem, EStrengthItemType.StrengthForAimisi);
		}

		// Token: 0x0603D662 RID: 251490 RVA: 0x00ECFC3E File Offset: 0x00ECDE3E
		private void RemoveStrengthItem()
		{
			if (!this.HasStrengthItem)
			{
				return;
			}
			this.HasStrengthItem = false;
			EventSystem.Instance.Emit<EStrengthItemType>(EEventName.RemoveStrengthItem, EStrengthItemType.StrengthForAimisi);
		}

		// Token: 0x0402009B RID: 131227
		private static readonly int MechanicalTag = GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.主控机甲"];

		// Token: 0x0402009C RID: 131228
		private bool IsAutonomousProxy;

		// Token: 0x0402009D RID: 131229
		private bool HasStrengthItem;

		// Token: 0x0402009E RID: 131230
		private bool HasMechanicalTag;
	}
}
