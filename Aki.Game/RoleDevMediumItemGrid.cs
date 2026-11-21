using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02001D74 RID: 7540
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevMediumItemGrid : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x06012A14 RID: 76308 RVA: 0x0057CD18 File Offset: 0x0057AF18
	protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
	{
		int dataId = data.GetDataId();
		this.RoleId = dataId;
		bool value = SceneTeamModel.Instance.GetTeamItem((long)dataId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId,
			OnlyMyRole = new bool?(true)
		}) != null;
		bool value2 = RoleDevModel.Instance.DevTargetRoleId == dataId;
		CharacterMediumItemGrid parameters;
		if (RoleModel.Instance.IsRoleOwned(dataId))
		{
			parameters = new CharacterMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.GetRoleId()),
				SkinId = data.GetRoleSkinId(),
				BottomTextId = "Text_LevelShow_Text",
				BottomTextParameter = new object[]
				{
					data.GetLevelData().GetLevel()
				},
				IsInTeam = new bool?(value),
				IsRoleDevelopTagMark = new bool?(value2),
				ElementId = new int?(data.GetRoleConfig().ElementId),
				IsTrialRoleVisible = new bool?(false)
			};
		}
		else
		{
			RoleInfo roleConfig = data.GetRoleConfig();
			parameters = new CharacterMediumItemGrid
			{
				Data = data,
				ItemConfigId = new int?(data.GetRoleId()),
				SkinId = data.GetRoleSkinId(),
				BottomText = ConfigMultiTextLang.GetLocalTextNew(roleConfig.Name, null),
				IsInTeam = new bool?(value),
				ElementId = new int?(data.GetRoleConfig().ElementId),
				IsTrialRoleVisible = new bool?(false),
				IsShowLock = new bool?(true),
				IsDisable = new bool?(true)
			};
		}
		base.Apply<CharacterMediumItemGrid>(parameters);
		this.SetSelected(isSelected, false);
	}

	// Token: 0x06012A15 RID: 76309 RVA: 0x0057CEBB File Offset: 0x0057B0BB
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06012A16 RID: 76310 RVA: 0x0057CEC5 File Offset: 0x0057B0C5
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06012A17 RID: 76311 RVA: 0x0057CECF File Offset: 0x0057B0CF
	public object GetKey()
	{
		return this.RoleId;
	}

	// Token: 0x0400A1E1 RID: 41441
	private int RoleId;
}
