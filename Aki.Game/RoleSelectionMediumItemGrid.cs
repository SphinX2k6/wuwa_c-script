using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x020028F4 RID: 10484
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleSelectionMediumItemGrid : LoopScrollMediumItemGrid<RoleDataBase>
{
	// Token: 0x06015A58 RID: 88664 RVA: 0x00576FC1 File Offset: 0x005751C1
	public void SetNeedShowTrial(bool state)
	{
		this.NeedShowTrial = state;
	}

	// Token: 0x06015A59 RID: 88665 RVA: 0x00576FCC File Offset: 0x005751CC
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

	// Token: 0x06015A5A RID: 88666 RVA: 0x005770BC File Offset: 0x005752BC
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

	// Token: 0x06015A5B RID: 88667 RVA: 0x005770F3 File Offset: 0x005752F3
	public override void OnDeselected(bool fireEvent)
	{
		this.SetSelected(false, true);
	}

	// Token: 0x0400A101 RID: 41217
	private bool NeedShowTrial;
}
