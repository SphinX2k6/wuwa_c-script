using System;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x020018CC RID: 6348
public class PersonalRoleMediumItemGrid : LoopScrollMediumItemGrid<int>
{
	// Token: 0x0600FA93 RID: 64147 RVA: 0x00494358 File Offset: 0x00492558
	protected override void OnRefresh(int data, bool isSelected, int gridIndex)
	{
		this.RoleId = data;
		this.GirdIndex = gridIndex;
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
		{
			Data = data,
			ItemConfigId = new int?(data),
			SkinId = roleInstanceById.GetRoleSkinId(),
			BottomTextId = "Text_LevelShow_Text",
			BottomTextParameter = new object[]
			{
				roleInstanceById.GetLevelData().GetLevel()
			}
		};
		base.Apply<CharacterMediumItemGrid>(parameters);
	}

	// Token: 0x04008C40 RID: 35904
	private int RoleId;

	// Token: 0x04008C41 RID: 35905
	public int GirdIndex;
}
