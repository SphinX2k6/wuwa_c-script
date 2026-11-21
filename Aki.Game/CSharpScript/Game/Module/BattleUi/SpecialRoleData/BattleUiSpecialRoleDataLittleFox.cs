using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.BattleUi.SpecialRoleData
{
	// Token: 0x02004E34 RID: 20020
	public class BattleUiSpecialRoleDataLittleFox : BattleUiSpecialRoleDataBase
	{
		// Token: 0x060325FE RID: 206334 RVA: 0x00E21273 File Offset: 0x00E1F473
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

		// Token: 0x060325FF RID: 206335 RVA: 0x00E212B3 File Offset: 0x00E1F4B3
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

		// Token: 0x0401AB67 RID: 109415
		private readonly int BlackWhiteStateTagId = GameplayTagDefine.EGameplayTagId["幻象.声骸角色.小狐狸.功能开关.黑白狐狸材质"];

		// Token: 0x0401AB68 RID: 109416
		[Nullable(2)]
		private string BlackWhiteHeadIcon;
	}
}
