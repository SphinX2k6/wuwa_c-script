using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02005E4F RID: 24143
	public class BattleUiSpecialRoleDataLittleFox : BattleUiSpecialRoleDataBase
	{
		// Token: 0x0603D66E RID: 251502 RVA: 0x00ECFD03 File Offset: 0x00ECDF03
		[NullableContext(1)]
		public override void Init(BattleUiRoleData roleData)
		{
			base.Init(roleData);
			if (this.RoleData == null)
			{
				return;
			}
			this.BlackWhiteHeadIcon = ConfigCommonParamById.GetStringConfig("BlackWhiteFoxHeadIcon");
			this.RoleData.ListenForTagSignificantChanged(this.BlackWhiteStateTagId, new BaseTagComponent.TTagSwitchedCallback(this.OnBlackWhiteTagChanged), true);
		}

		// Token: 0x0603D66F RID: 251503 RVA: 0x00ECFD43 File Offset: 0x00ECDF43
		private void OnBlackWhiteTagChanged(int tagId, bool tagExist)
		{
			if (this.RoleData == null)
			{
				return;
			}
			if (tagExist)
			{
				this.RoleData.SetOverrideRoleHeadIcon(this.BlackWhiteHeadIcon);
				return;
			}
			this.RoleData.SetOverrideRoleHeadIcon(null);
		}

		// Token: 0x040200A0 RID: 131232
		private readonly int BlackWhiteStateTagId = GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.功能开关.黑白狐狸材质"];

		// Token: 0x040200A1 RID: 131233
		[Nullable(2)]
		private string BlackWhiteHeadIcon;
	}
}
