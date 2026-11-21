using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02004E37 RID: 20023
	public class BattleUiSpecialRoleDataQingXiao : BattleUiSpecialRoleDataBase
	{
		// Token: 0x06032609 RID: 206345 RVA: 0x00E2145C File Offset: 0x00E1F65C
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
			BattleUiRoleData roleData2 = this.RoleData;
			if (roleData2 != null)
			{
				roleData2.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1QingxiaoMd10011.御剑飞行能量.显示"], new BaseTagComponent.TTagSwitchedCallback(this.OnFlyStrengthTagChanged), true);
			}
			if (!HudUnitManager.Instance.GetIsInitHud())
			{
				EventSystem.Instance.Add(EEventName.HudInited, new Action(this.OnHudInited));
			}
		}

		// Token: 0x0603260A RID: 206346 RVA: 0x00E21508 File Offset: 0x00E1F708
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
			this.HasFlyItemTag = false;
			this.RefreshFlyItem();
			this.IsAutonomousProxy = false;
		}

		// Token: 0x0603260B RID: 206347 RVA: 0x00E2156B File Offset: 0x00E1F76B
		private void OnHudInited()
		{
			this.RefreshFlyItem();
		}

		// Token: 0x0603260C RID: 206348 RVA: 0x00E21573 File Offset: 0x00E1F773
		public override void OnChangeRole(bool isCurEntity)
		{
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			this.RefreshFlyItem();
		}

		// Token: 0x0603260D RID: 206349 RVA: 0x00E21584 File Offset: 0x00E1F784
		private void OnFlyStrengthTagChanged(int tagId, bool tagExist)
		{
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			this.HasFlyItemTag = tagExist;
			this.RefreshFlyItem();
		}

		// Token: 0x0603260E RID: 206350 RVA: 0x00E2159C File Offset: 0x00E1F79C
		private void RefreshFlyItem()
		{
			if (!HudUnitManager.Instance.GetIsInitHud())
			{
				return;
			}
			BattleUiRoleData roleData = this.RoleData;
			if (roleData == null || !roleData.IsCurEntity || !this.HasFlyItemTag)
			{
				this.RemoveFlyItem();
				return;
			}
			this.AddFlyItem();
		}

		// Token: 0x0603260F RID: 206351 RVA: 0x00E215D7 File Offset: 0x00E1F7D7
		private void AddFlyItem()
		{
			if (this.HasFlyItem)
			{
				return;
			}
			this.HasFlyItem = true;
			EventSystem.Instance.Emit<EStrengthItemType>(EEventName.AddStrengthItem, EStrengthItemType.QingXiaoFly);
		}

		// Token: 0x06032610 RID: 206352 RVA: 0x00E215FA File Offset: 0x00E1F7FA
		private void RemoveFlyItem()
		{
			if (!this.HasFlyItem)
			{
				return;
			}
			this.HasFlyItem = false;
			EventSystem.Instance.Emit<EStrengthItemType>(EEventName.RemoveStrengthItem, EStrengthItemType.QingXiaoFly);
		}

		// Token: 0x0401AB6B RID: 109419
		private bool IsAutonomousProxy;

		// Token: 0x0401AB6C RID: 109420
		private bool HasFlyItem;

		// Token: 0x0401AB6D RID: 109421
		private bool HasFlyItemTag;
	}
}
