using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001DB9 RID: 7609
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleFavorClassifyDataBase
{
	// Token: 0x06012DF4 RID: 77300 RVA: 0x00589A8C File Offset: 0x00587C8C
	public RoleFavorClassifyDataBase(string titleTableId, int roleId)
	{
		this.TitleTableId = titleTableId;
		this.RoleId = roleId;
	}

	// Token: 0x06012DF5 RID: 77301
	protected abstract void InitContentDataList();

	// Token: 0x06012DF6 RID: 77302 RVA: 0x00589AB8 File Offset: 0x00587CB8
	public List<RoleFavorContentDataBase> GetContentDataList()
	{
		if (this.ContentDataList.Count == 0)
		{
			this.InitContentDataList();
		}
		return this.ContentDataList;
	}

	// Token: 0x06012DF7 RID: 77303 RVA: 0x00589AD3 File Offset: 0x00587CD3
	[NullableContext(2)]
	public RoleFavorContentDataBase GetContentDataByIndex(int index)
	{
		if (index < 0 || index >= this.ContentDataList.Count)
		{
			return null;
		}
		return this.ContentDataList[index];
	}

	// Token: 0x06012DF8 RID: 77304 RVA: 0x00589AF5 File Offset: 0x00587CF5
	protected void SortContentDataList()
	{
		this.ContentDataList.Sort(delegate(RoleFavorContentDataBase a, RoleFavorContentDataBase b)
		{
			EFavorItemStatus itemStatus = this.GetItemStatus(a);
			EFavorItemStatus itemStatus2 = this.GetItemStatus(b);
			if (itemStatus != itemStatus2)
			{
				return itemStatus2 - itemStatus;
			}
			return a.ConfigId - b.ConfigId;
		});
	}

	// Token: 0x06012DF9 RID: 77305 RVA: 0x00589B10 File Offset: 0x00587D10
	protected EFavorItemStatus GetItemStatus(RoleFavorContentDataBase contentData)
	{
		RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RoleId);
		if (roleInstanceById == null)
		{
			return EFavorItemStatus.ItemLocked;
		}
		RoleFavorData favorData = roleInstanceById.GetFavorData();
		if (contentData.FavorContentType == EFavorContentType.Action)
		{
			return (EFavorItemStatus)MotionModel.Instance.GetRoleMotionState(roleInstanceById.GetRoleId(), contentData.ConfigId);
		}
		return favorData.GetFavorItemState(contentData.ConfigId, contentData.FavorContentType);
	}

	// Token: 0x06012DFA RID: 77306
	protected abstract EFavorTabType GetFavorTabType();

	// Token: 0x0400A2A6 RID: 41638
	protected int RoleId;

	// Token: 0x0400A2A7 RID: 41639
	public string TitleTableId = "";

	// Token: 0x0400A2A8 RID: 41640
	protected List<RoleFavorContentDataBase> ContentDataList = new List<RoleFavorContentDataBase>();
}
