using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02001E6F RID: 7791
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleSelectionMediumItemGrid : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x0601345C RID: 78940 RVA: 0x005A1E89 File Offset: 0x005A0089
	public void SetNeedShowTrial(bool state)
	{
		this.NeedShowTrial = state;
	}

	// Token: 0x0601345D RID: 78941 RVA: 0x005A1E94 File Offset: 0x005A0094
	protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
	{
		int dataId = data.GetDataId();
		bool value = SceneTeamModel.Instance.GetTeamItem((long)dataId, new GetTeamItemOptions
		{
			ParamType = ETeamParamType.ConfigId
		}) != null;
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data.GetDataId()),
			SkinId = data.GetRoleSkinId(),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				data.GetLevelData().GetLevel()
			},
			IsInTeam = new bool?(value),
			ElementId = new int?(data.GetRoleConfig().ElementId),
			IsTrialRoleVisible = new bool?(data.IsTrialRole() && this.NeedShowTrial),
			IsNewVisible = new bool?(data.GetIsNew())
		};
		base.SetUseFixedAsync(true);
		base.Apply<CharacterMediumItemGrid>(parameters);
		this.SetSelected(isSelected, false);
	}

	// Token: 0x0601345E RID: 78942 RVA: 0x005A1F84 File Offset: 0x005A0184
	public override void OnSelected(bool fireEvent)
	{
		this.SetSelected(true, false);
		base.SetNewVisible(new bool?(false));
		RoleDataBase roleDataBase = this.Data as RoleDataBase;
		if (roleDataBase != null)
		{
			roleDataBase.TryRemoveNewFlag();
		}
	}

	// Token: 0x0601345F RID: 78943 RVA: 0x005A1FBB File Offset: 0x005A01BB
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0400A4EC RID: 42220
	private bool NeedShowTrial;
}
