using System;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02005E54 RID: 24148
	public class BattleUiSpecialRoleDataXinYueHu : BattleUiSpecialRoleDataBase
	{
		// Token: 0x0603D688 RID: 251528 RVA: 0x00ED0268 File Offset: 0x00ECE468
		protected override void OnInit()
		{
			if (this.RoleData != null)
			{
				this.RoleData.CheckEnergyTag = true;
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.技能ID.二阶段.大招.满能量"], new BaseTagComponent.TTagSwitchedCallback(this.OnEnergyTagChanged1), true);
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.一阶段大招可用"], new BaseTagComponent.TTagSwitchedCallback(this.OnEnergyTagChanged2), true);
			}
		}

		// Token: 0x0603D689 RID: 251529 RVA: 0x00ED02D7 File Offset: 0x00ECE4D7
		private void OnEnergyTagChanged1(int tagId, bool tagExist)
		{
			this.HasTag1 = tagExist;
			this.RefreshHasEnergyTag();
		}

		// Token: 0x0603D68A RID: 251530 RVA: 0x00ED02E6 File Offset: 0x00ECE4E6
		private void OnEnergyTagChanged2(int tagId, bool tagExist)
		{
			this.HasTag2 = tagExist;
			this.RefreshHasEnergyTag();
		}

		// Token: 0x0603D68B RID: 251531 RVA: 0x00ED02F5 File Offset: 0x00ECE4F5
		private void RefreshHasEnergyTag()
		{
			BattleUiRoleData roleData = this.RoleData;
			if (roleData == null)
			{
				return;
			}
			roleData.SetHasEnergyTag(this.HasTag1 || this.HasTag2);
		}

		// Token: 0x040200A7 RID: 131239
		private bool HasTag1;

		// Token: 0x040200A8 RID: 131240
		private bool HasTag2;
	}
}
