using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;

// Token: 0x02001C6C RID: 7276
[NullableContext(1)]
[Nullable(0)]
public class RoleHandBookSelectionComponent
{
	// Token: 0x060120E2 RID: 73954 RVA: 0x0054F4B2 File Offset: 0x0054D6B2
	public void UpdateRoleHandBookItem(int id)
	{
	}

	// Token: 0x060120E3 RID: 73955 RVA: 0x0054F4B4 File Offset: 0x0054D6B4
	public int GetCurSelectRoleId()
	{
		return 0;
	}

	// Token: 0x060120E4 RID: 73956 RVA: 0x0054F4B7 File Offset: 0x0054D6B7
	public IReadOnlyDictionary<object, RoleHandBookSelectionItem> GetAllRoleItemMap()
	{
		return this.RoleScroll.GetScrollItemMap();
	}

	// Token: 0x060120E5 RID: 73957 RVA: 0x0054F4C4 File Offset: 0x0054D6C4
	public void UpdateComponent(RoleDataBase[] roleList)
	{
	}

	// Token: 0x060120E6 RID: 73958 RVA: 0x0054F4C6 File Offset: 0x0054D6C6
	protected void RefreshRoleItem(RoleDataBase[] roleList)
	{
	}

	// Token: 0x060120E7 RID: 73959 RVA: 0x0054F4C8 File Offset: 0x0054D6C8
	public void UpdateItemByRoleId(int roleId)
	{
		RoleHandBookSelectionItem roleHandBookSelectionItem;
		if (this.GetAllRoleItemMap().TryGetValue(roleId, out roleHandBookSelectionItem))
		{
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
			roleHandBookSelectionItem.UpdateItem(roleDataById);
		}
	}

	// Token: 0x060120E8 RID: 73960 RVA: 0x0054F4FE File Offset: 0x0054D6FE
	public void PlaySequence()
	{
		if (this.RoleHandBookItem == null)
		{
			return;
		}
		this.RoleHandBookItem.PlaySequence();
	}

	// Token: 0x060120E9 RID: 73961 RVA: 0x0054F514 File Offset: 0x0054D714
	protected void OnBeforeDestroy()
	{
	}

	// Token: 0x04009D61 RID: 40289
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected GenericScrollView<RoleHandBookSelectionItem> RoleScroll;

	// Token: 0x04009D62 RID: 40290
	[Nullable(2)]
	protected RoleHandBookItem RoleHandBookItem;
}
