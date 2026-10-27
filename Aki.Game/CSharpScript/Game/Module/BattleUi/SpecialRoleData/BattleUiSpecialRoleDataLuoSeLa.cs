using System;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02005E50 RID: 24144
	public class BattleUiSpecialRoleDataLuoSeLa : BattleUiSpecialRoleDataBase
	{
		// Token: 0x0603D671 RID: 251505 RVA: 0x00ECFD8C File Offset: 0x00ECDF8C
		protected override void OnInit()
		{
			if (this.RoleData != null)
			{
				this.RoleData.CheckEnergyTag = true;
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LuoselaMd10011.状态.大招解锁"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltimateTagChanged), true);
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LuoselaMd10011.状态.强化状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnStrongTagChanged), true);
			}
		}

		// Token: 0x0603D672 RID: 251506 RVA: 0x00ECFDFB File Offset: 0x00ECDFFB
		private void OnUltimateTagChanged(int tagId, bool tagExist)
		{
			this.HasUltimateTag = tagExist;
			this.RefreshHasEnergyTag();
		}

		// Token: 0x0603D673 RID: 251507 RVA: 0x00ECFE0A File Offset: 0x00ECE00A
		private void OnStrongTagChanged(int tagId, bool tagExist)
		{
			this.HasStrongTag = tagExist;
			this.RefreshHasEnergyTag();
		}

		// Token: 0x0603D674 RID: 251508 RVA: 0x00ECFE19 File Offset: 0x00ECE019
		private void RefreshHasEnergyTag()
		{
			this.RoleData.SetHasEnergyTag(this.HasUltimateTag && !this.HasStrongTag);
		}

		// Token: 0x040200A2 RID: 131234
		private bool HasUltimateTag;

		// Token: 0x040200A3 RID: 131235
		private bool HasStrongTag;
	}
}
