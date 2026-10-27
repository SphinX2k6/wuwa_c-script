using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

// Token: 0x02002781 RID: 10113
[NullableContext(1)]
[Nullable(0)]
public class RoleHandBookSelectionComponent
{
	// Token: 0x06014BFF RID: 84991 RVA: 0x0054062E File Offset: 0x0053E82E
	public void UpdateRoleHandBookItem(int id)
	{
	}

	// Token: 0x06014C00 RID: 84992 RVA: 0x00540630 File Offset: 0x0053E830
	public int GetCurSelectRoleId()
	{
		return 0;
	}

	// Token: 0x06014C01 RID: 84993 RVA: 0x00540633 File Offset: 0x0053E833
	public IReadOnlyDictionary<object, RoleHandBookSelectionItem> GetAllRoleItemMap()
	{
		return this.RoleScroll.GetScrollItemMap();
	}

	// Token: 0x06014C02 RID: 84994 RVA: 0x00540640 File Offset: 0x0053E840
	public void UpdateComponent(RoleDataBase[] roleList)
	{
	}

	// Token: 0x06014C03 RID: 84995 RVA: 0x00540642 File Offset: 0x0053E842
	protected void RefreshRoleItem(RoleDataBase[] roleList)
	{
	}

	// Token: 0x06014C04 RID: 84996 RVA: 0x00540644 File Offset: 0x0053E844
	public void UpdateItemByRoleId(int roleId)
	{
		RoleHandBookSelectionItem roleHandBookSelectionItem;
		if (this.GetAllRoleItemMap().TryGetValue(roleId, out roleHandBookSelectionItem))
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			roleHandBookSelectionItem.UpdateItem(roleDataById);
		}
	}

	// Token: 0x06014C05 RID: 84997 RVA: 0x0054067A File Offset: 0x0053E87A
	public void PlaySequence()
	{
		if (this.RoleHandBookItem == null)
		{
			return;
		}
		this.RoleHandBookItem.PlaySequence();
	}

	// Token: 0x06014C06 RID: 84998 RVA: 0x00540690 File Offset: 0x0053E890
	protected void OnBeforeDestroy()
	{
	}

	// Token: 0x04009C09 RID: 39945
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<RoleHandBookSelectionItem> RoleScroll;

	// Token: 0x04009C0A RID: 39946
	[Nullable(2)]
	protected RoleHandBookItem RoleHandBookItem;
}
