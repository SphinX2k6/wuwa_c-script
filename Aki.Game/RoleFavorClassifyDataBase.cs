using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200283E RID: 10302
[NullableContext(1)]
[Nullable(0)]
public abstract class RoleFavorClassifyDataBase
{
	// Token: 0x060153F6 RID: 87030 RVA: 0x0055ED30 File Offset: 0x0055CF30
	public RoleFavorClassifyDataBase(string titleTableId, int roleId)
	{
		this.TitleTableId = titleTableId;
		this.RoleId = roleId;
	}

	// Token: 0x060153F7 RID: 87031
	protected abstract void InitContentDataList();

	// Token: 0x060153F8 RID: 87032 RVA: 0x0055ED5C File Offset: 0x0055CF5C
	public List<RoleFavorContentDataBase> GetContentDataList()
	{
		if (this.ContentDataList.Count == 0)
		{
			this.InitContentDataList();
		}
		return this.ContentDataList;
	}

	// Token: 0x060153F9 RID: 87033 RVA: 0x0055ED77 File Offset: 0x0055CF77
	[NullableContext(2)]
	public RoleFavorContentDataBase GetContentDataByIndex(int index)
	{
		if (index < 0 || index >= this.ContentDataList.Count)
		{
			return null;
		}
		return this.ContentDataList[index];
	}

	// Token: 0x060153FA RID: 87034 RVA: 0x0055ED99 File Offset: 0x0055CF99
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

	// Token: 0x060153FB RID: 87035 RVA: 0x0055EDB4 File Offset: 0x0055CFB4
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

	// Token: 0x060153FC RID: 87036
	protected abstract EFavorTabType GetFavorTabType();

	// Token: 0x04009EBD RID: 40637
	protected int RoleId;

	// Token: 0x04009EBE RID: 40638
	public string TitleTableId = "";

	// Token: 0x04009EBF RID: 40639
	protected List<RoleFavorContentDataBase> ContentDataList = new List<RoleFavorContentDataBase>();
}
