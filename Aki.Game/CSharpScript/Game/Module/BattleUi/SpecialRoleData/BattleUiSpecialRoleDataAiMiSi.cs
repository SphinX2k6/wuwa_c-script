using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02004E31 RID: 20017
	public class BattleUiSpecialRoleDataAiMiSi : BattleUiSpecialRoleDataBase
	{
		// Token: 0x060325EB RID: 206315 RVA: 0x00E20FC4 File Offset: 0x00E1F1C4
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

		// Token: 0x060325EC RID: 206316 RVA: 0x00E2108C File Offset: 0x00E1F28C
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

		// Token: 0x060325ED RID: 206317 RVA: 0x00E2111F File Offset: 0x00E1F31F
		private void OnHudInited()
		{
			this.RefreshStrengthItem();
		}

		// Token: 0x060325EE RID: 206318 RVA: 0x00E21127 File Offset: 0x00E1F327
		public override void OnChangeRole(bool isCurEntity)
		{
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			this.RefreshStrengthItem();
		}

		// Token: 0x060325EF RID: 206319 RVA: 0x00E21138 File Offset: 0x00E1F338
		private void OnMechanicalTagChanged(int tagId, bool tagExist)
		{
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			this.HasMechanicalTag = tagExist;
			this.RefreshStrengthItem();
		}

		// Token: 0x060325F0 RID: 206320 RVA: 0x00E21150 File Offset: 0x00E1F350
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

		// Token: 0x060325F1 RID: 206321 RVA: 0x00E2118B File Offset: 0x00E1F38B
		private void AddStrengthItem()
		{
			if (this.HasStrengthItem)
			{
				return;
			}
			this.HasStrengthItem = true;
			EventSystem.Instance.Emit<EStrengthItemType>(EEventName.AddStrengthItem, EStrengthItemType.StrengthForAimisi);
		}

		// Token: 0x060325F2 RID: 206322 RVA: 0x00E211AE File Offset: 0x00E1F3AE
		private void RemoveStrengthItem()
		{
			if (!this.HasStrengthItem)
			{
				return;
			}
			this.HasStrengthItem = false;
			EventSystem.Instance.Emit<EStrengthItemType>(EEventName.RemoveStrengthItem, EStrengthItemType.StrengthForAimisi);
		}

		// Token: 0x0401AB62 RID: 109410
		private static readonly int MechanicalTag = GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.主控机甲"];

		// Token: 0x0401AB63 RID: 109411
		private bool IsAutonomousProxy;

		// Token: 0x0401AB64 RID: 109412
		private bool HasStrengthItem;

		// Token: 0x0401AB65 RID: 109413
		private bool HasMechanicalTag;
	}
}
