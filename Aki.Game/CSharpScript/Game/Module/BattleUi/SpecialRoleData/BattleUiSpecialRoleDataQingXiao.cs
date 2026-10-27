using System;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02005E52 RID: 24146
	public class BattleUiSpecialRoleDataQingXiao : BattleUiSpecialRoleDataBase
	{
		// Token: 0x0603D679 RID: 251513 RVA: 0x00ECFEEC File Offset: 0x00ECE0EC
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

		// Token: 0x0603D67A RID: 251514 RVA: 0x00ECFF98 File Offset: 0x00ECE198
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

		// Token: 0x0603D67B RID: 251515 RVA: 0x00ECFFFB File Offset: 0x00ECE1FB
		private void OnHudInited()
		{
			this.RefreshFlyItem();
		}

		// Token: 0x0603D67C RID: 251516 RVA: 0x00ED0003 File Offset: 0x00ECE203
		public override void OnChangeRole(bool isCurEntity)
		{
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			this.RefreshFlyItem();
		}

		// Token: 0x0603D67D RID: 251517 RVA: 0x00ED0014 File Offset: 0x00ECE214
		private void OnFlyStrengthTagChanged(int tagId, bool tagExist)
		{
			if (!this.IsAutonomousProxy)
			{
				return;
			}
			this.HasFlyItemTag = tagExist;
			this.RefreshFlyItem();
		}

		// Token: 0x0603D67E RID: 251518 RVA: 0x00ED002C File Offset: 0x00ECE22C
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

		// Token: 0x0603D67F RID: 251519 RVA: 0x00ED0067 File Offset: 0x00ECE267
		private void AddFlyItem()
		{
			if (this.HasFlyItem)
			{
				return;
			}
			this.HasFlyItem = true;
			EventSystem.Instance.Emit<EStrengthItemType>(EEventName.AddStrengthItem, EStrengthItemType.QingXiaoFly);
		}

		// Token: 0x0603D680 RID: 251520 RVA: 0x00ED008A File Offset: 0x00ECE28A
		private void RemoveFlyItem()
		{
			if (!this.HasFlyItem)
			{
				return;
			}
			this.HasFlyItem = false;
			EventSystem.Instance.Emit<EStrengthItemType>(EEventName.RemoveStrengthItem, EStrengthItemType.QingXiaoFly);
		}

		// Token: 0x040200A4 RID: 131236
		private bool IsAutonomousProxy;

		// Token: 0x040200A5 RID: 131237
		private bool HasFlyItem;

		// Token: 0x040200A6 RID: 131238
		private bool HasFlyItemTag;
	}
}
