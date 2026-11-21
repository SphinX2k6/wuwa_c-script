using System;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02004E39 RID: 20025
	public class BattleUiSpecialRoleDataXinYueHu : BattleUiSpecialRoleDataBase
	{
		// Token: 0x06032618 RID: 206360 RVA: 0x00E217D8 File Offset: 0x00E1F9D8
		protected override void OnInit()
		{
			if (this.RoleData != null)
			{
				this.RoleData.CheckEnergyTag = true;
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.技能ID.二阶段.大招.满能量"], new BaseTagComponent.TTagSwitchedCallback(this.OnEnergyTagChanged1), true);
				this.RoleData.ListenForTagSignificantChanged(GameplayTagDefine.EGameplayTagId["角色.R2T1XinMd10011.状态标记.一阶段大招可用"], new BaseTagComponent.TTagSwitchedCallback(this.OnEnergyTagChanged2), true);
			}
		}

		// Token: 0x06032619 RID: 206361 RVA: 0x00E21847 File Offset: 0x00E1FA47
		private void OnEnergyTagChanged1(int tagId, bool tagExist)
		{
			this.HasTag1 = tagExist;
			this.RefreshHasEnergyTag();
		}

		// Token: 0x0603261A RID: 206362 RVA: 0x00E21856 File Offset: 0x00E1FA56
		private void OnEnergyTagChanged2(int tagId, bool tagExist)
		{
			this.HasTag2 = tagExist;
			this.RefreshHasEnergyTag();
		}

		// Token: 0x0603261B RID: 206363 RVA: 0x00E21865 File Offset: 0x00E1FA65
		private void RefreshHasEnergyTag()
		{
			BattleUiRoleData roleData = this.RoleData;
			if (roleData == null)
			{
				return;
			}
			roleData.SetHasEnergyTag(this.HasTag1 || this.HasTag2);
		}

		// Token: 0x0401AB6E RID: 109422
		private bool HasTag1;

		// Token: 0x0401AB6F RID: 109423
		private bool HasTag2;
	}
}
