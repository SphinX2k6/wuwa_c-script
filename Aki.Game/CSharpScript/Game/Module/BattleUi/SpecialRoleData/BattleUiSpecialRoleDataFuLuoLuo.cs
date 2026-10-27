using System;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02005E4E RID: 24142
	public class BattleUiSpecialRoleDataFuLuoLuo : BattleUiSpecialRoleDataBase
	{
		// Token: 0x0603D66B RID: 251499 RVA: 0x00ECFCAB File Offset: 0x00ECDEAB
		protected override void OnInit()
		{
			if (this.RoleData != null)
			{
				this.RoleData.CheckEnergyTag = true;
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1FuluoluoMd10011.状态标识.大招解禁"], new BaseTagComponent.TTagSwitchedCallback(this.OnEnergyTagChanged), true);
			}
		}

		// Token: 0x0603D66C RID: 251500 RVA: 0x00ECFCE8 File Offset: 0x00ECDEE8
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
