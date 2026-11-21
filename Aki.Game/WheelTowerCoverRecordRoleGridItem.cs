using System;
using UnrealEngine;

// Token: 0x02000A38 RID: 2616
public class WheelTowerCoverRecordRoleGridItem : LoopScrollSmallItemGrid<int>
{
	// Token: 0x0600711F RID: 28959 RVA: 0x0022B1A7 File Offset: 0x002293A7
	protected override void OnStart()
	{
		base.BindOnCanExecuteChange((object _, bool _, EToggleState _) => false);
	}

	// Token: 0x06007120 RID: 28960 RVA: 0x0022B1D0 File Offset: 0x002293D0
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
