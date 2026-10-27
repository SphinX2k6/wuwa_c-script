using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x0200159C RID: 5532
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerRecommendRoleGridItem : LoopScrollMediumItemGrid<RoleDataWithBranch>
{
	// Token: 0x06009D86 RID: 40326 RVA: 0x00222CF8 File Offset: 0x00220EF8
	protected override void OnRefresh(RoleDataWithBranch data, bool isSelected, int gridIndex)
	{
		int num = data.RoleId;
		if (RoleModel.Instance.IsMainRole(data.RoleId))
		{
			num = RoleModel.Instance.GetCorrectMainRoleConfig(data.RoleId).Value.Id;
		}
		bool flag = RoleModel.Instance.IsHasRole(num);
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(num);
		if (roleConfig == null)
		{
			return;
		}
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			ItemConfigId = new int?(num),
			SkinId = roleConfig.Value.SkinId,
			BottomTextId = roleConfig.Value.Name,
			ElementId = new int?(roleConfig.Value.ElementId),
			IsDisable = new bool?(!flag),
			SkillBranchIndex = ((data.SkillBranchIndex > -1) ? new int?(data.SkillBranchIndex) : null)
		};
		base.SetUseFixedAsync(true);
		base.Apply<CharacterMediumItemGrid>(parameters);
	}

	// Token: 0x06009D87 RID: 40327 RVA: 0x00222DFF File Offset: 0x00220FFF
	protected override bool OnCanExecuteChange()
	{
		return false;
	}
}
