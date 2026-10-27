using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x020027F9 RID: 10233
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleDevMediumItemGrid : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x06015014 RID: 86036 RVA: 0x00551FA4 File Offset: 0x005501A4
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

	// Token: 0x06015015 RID: 86037 RVA: 0x00552147 File Offset: 0x00550347
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
	}

	// Token: 0x06015016 RID: 86038 RVA: 0x00552151 File Offset: 0x00550351
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x06015017 RID: 86039 RVA: 0x0055215B File Offset: 0x0055035B
	public object GetKey()
	{
		return this.RoleId;
	}

	// Token: 0x04009DF8 RID: 40440
	private int RoleId;
}
