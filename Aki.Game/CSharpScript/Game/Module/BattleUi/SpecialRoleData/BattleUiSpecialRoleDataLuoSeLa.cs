using System;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02004E35 RID: 20021
	public class BattleUiSpecialRoleDataLuoSeLa : BattleUiSpecialRoleDataBase
	{
		// Token: 0x06032601 RID: 206337 RVA: 0x00E212FC File Offset: 0x00E1F4FC
		protected override void OnInit()
		{
			if (this.RoleData != null)
			{
				this.RoleData.CheckEnergyTag = true;
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LuoselaMd10011.状态.大招解锁"], new BaseTagComponent.TTagSwitchedCallback(this.OnUltimateTagChanged), true);
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1LuoselaMd10011.状态.强化状态"], new BaseTagComponent.TTagSwitchedCallback(this.OnStrongTagChanged), true);
			}
		}

		// Token: 0x06032602 RID: 206338 RVA: 0x00E2136B File Offset: 0x00E1F56B
		private void OnUltimateTagChanged(int tagId, bool tagExist)
		{
			this.HasUltimateTag = tagExist;
			this.RefreshHasEnergyTag();
		}

		// Token: 0x06032603 RID: 206339 RVA: 0x00E2137A File Offset: 0x00E1F57A
		private void OnStrongTagChanged(int tagId, bool tagExist)
		{
			this.HasStrongTag = tagExist;
			this.RefreshHasEnergyTag();
		}

		// Token: 0x06032604 RID: 206340 RVA: 0x00E21389 File Offset: 0x00E1F589
		private void RefreshHasEnergyTag()
		{
			this.RoleData.SetHasEnergyTag(this.HasUltimateTag && !this.HasStrongTag);
		}

		// Token: 0x0401AB69 RID: 109417
		private bool HasUltimateTag;

		// Token: 0x0401AB6A RID: 109418
		private bool HasStrongTag;
	}
}
