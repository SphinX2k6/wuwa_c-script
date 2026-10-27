using System;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x020023E7 RID: 9191
public class PersonalRoleMediumItemGrid : LoopScrollMediumItemGrid<int>
{
	// Token: 0x060125E1 RID: 75233 RVA: 0x00486E4C File Offset: 0x0048504C
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

	// Token: 0x04008AF9 RID: 35577
	private int RoleId;

	// Token: 0x04008AFA RID: 35578
	public int GirdIndex;
}
