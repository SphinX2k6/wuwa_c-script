using System;
using UnrealEngine;

// Token: 0x02001580 RID: 5504
public class WheelTowerCoverRecordRoleGridItem : LoopScrollSmallItemGrid<int>
{
	// Token: 0x06009D41 RID: 40257 RVA: 0x002213F7 File Offset: 0x0021F5F7
	protected override void OnStart()
	{
		base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
	}

	// Token: 0x06009D42 RID: 40258 RVA: 0x00221420 File Offset: 0x0021F620
	protected override void OnRefresh(int roleId, bool isSelected, int gridIndex)
	{
		int num = WheelTowerModel.Instance.TryGetRealRoleId(roleId);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num, true);
		if (roleDataById == null)
		{
			return;
		}
		CharacterSmallItemGrid parameters = new CharacterSmallItemGrid
		{
			Data = roleDataById,
			ItemConfigId = new int?(num),
			SkinId = new int?(roleDataById.GetRoleConfig().SkinId),
			BottomText = roleDataById.GetName(null),
			ElementId = new int?(roleDataById.GetRoleConfig().ElementId)
		};
		base.SetUseFixedAsync(true);
		base.Apply<CharacterSmallItemGrid>(parameters);
	}
}
