using System;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02004E33 RID: 20019
	public class BattleUiSpecialRoleDataFuLuoLuo : BattleUiSpecialRoleDataBase
	{
		// Token: 0x060325FB RID: 206331 RVA: 0x00E2121B File Offset: 0x00E1F41B
		protected override void OnInit()
		{
			if (this.RoleData != null)
			{
				this.RoleData.CheckEnergyTag = true;
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.大招解禁"], new BaseTagComponent.TTagSwitchedCallback(this.OnEnergyTagChanged), true);
			}
		}

		// Token: 0x060325FC RID: 206332 RVA: 0x00E21258 File Offset: 0x00E1F458
		private void OnEnergyTagChanged(int tagId, bool tagExist)
		{
			BattleUiRoleData roleData = this.RoleData;
			if (roleData == null)
			{
				return;
			}
			roleData.SetHasEnergyTag(tagExist);
		}
	}
}
