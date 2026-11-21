using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02001D2C RID: 7468
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorData : RoleModuleDataBase
{
	// Token: 0x06012847 RID: 75847 RVA: 0x00579106 File Offset: 0x00577306
	public RoleFavorData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06012848 RID: 75848 RVA: 0x0057911A File Offset: 0x0057731A
	public int GetFavorLevel()
	{
		return this.Level;
	}

	// Token: 0x06012849 RID: 75849 RVA: 0x00579122 File Offset: 0x00577322
	public void SetFavorLevel(int level)
	{
		this.Level = level;
	}

	// Token: 0x0601284A RID: 75850 RVA: 0x0057912B File Offset: 0x0057732B
	public int GetFavorExp()
	{
		return this.Exp;
	}

	// Token: 0x0601284B RID: 75851 RVA: 0x00579133 File Offset: 0x00577333
	public void SetFavorExp(int exp)
	{
		this.Exp = exp;
		EventSystem.Instance.Emit(EEventName.RoleFavorExpChange);
	}

	// Token: 0x0601284C RID: 75852 RVA: 0x0057914C File Offset: 0x0057734C
	public void UpdateRoleFavorData(EFavorContentType favorContentType, FavorItem[] favorItemList)
	{
		this.FavorItemMap[favorContentType] = this.BuildFavorItemInfoList(favorItemList);
	}

	// Token: 0x0601284D RID: 75853 RVA: 0x00579164 File Offset: 0x00577364
	public void UpdateUnlockId(FavorItemType favorItemType, int roleId, int itemId)
	{
		EFavorContentType value = this.GetClientFavorTabType(favorItemType).Value;
		FavorItemInfo[] array = this.FavorItemMap[value];
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			FavorItemInfo favorItemInfo = array[i];
			if (favorItemInfo.Id == itemId)
			{
				favorItemInfo.Status = EFavorItemStatus.ItemUnLocked;
			}
		}
		EventSystem.Instance.Emit<int>(EEventName.UpdateRoleFavorData, this.RoleId);
		EventSystem.Instance.Emit<int, int>(EEventName.UnLockRoleFavorItem, roleId, itemId);
	}

	// Token: 0x0601284E RID: 75854 RVA: 0x005791E4 File Offset: 0x005773E4
	public void UpdateCanUnlockId(FavorItemType favorItemType, int itemId)
	{
		EFavorContentType value = this.GetClientFavorTabType(favorItemType).Value;
		FavorItemInfo[] array2;
		FavorItemInfo[] array = this.FavorItemMap.TryGetValue(value, out array2) ? array2 : null;
		if (array == null)
		{
			List<FavorItemInfo> list = new List<FavorItemInfo>();
			list.Add(new FavorItemInfo(itemId, EFavorItemStatus.ItemCanUnLock));
			this.FavorItemMap[value] = list.ToArray();
			return;
		}
		int num = array.Length;
		bool flag = false;
		for (int i = 0; i < num; i++)
		{
			FavorItemInfo favorItemInfo = array[i];
			if (favorItemInfo.Id == itemId)
			{
				flag = true;
				favorItemInfo.Status = EFavorItemStatus.ItemCanUnLock;
				break;
			}
		}
		if (!flag)
		{
			List<FavorItemInfo> list2 = new List<FavorItemInfo>(array);
			list2.Add(new FavorItemInfo(itemId, EFavorItemStatus.ItemCanUnLock));
			this.FavorItemMap[value] = list2.ToArray();
		}
		EventSystem.Instance.Emit<int>(EEventName.UpdateRoleFavorData, this.RoleId);
	}

	// Token: 0x0601284F RID: 75855 RVA: 0x005792BC File Offset: 0x005774BC
	private FavorItemInfo[] BuildFavorItemInfoList(FavorItem[] favorItem)
	{
		List<FavorItemInfo> list = new List<FavorItemInfo>();
		int num = favorItem.Length;
		for (int i = 0; i < num; i++)
		{
			FavorItem favorItem2 = favorItem[i];
			list.Add(this.BuildFavorItemInfo(favorItem2));
		}
		return list.ToArray();
	}

	// Token: 0x06012850 RID: 75856 RVA: 0x005792F8 File Offset: 0x005774F8
	private FavorItemInfo BuildFavorItemInfo(FavorItem favorItem)
	{
		EFavorItemStatus? clientFavorItemStatus = this.GetClientFavorItemStatus(favorItem.Status);
		return new FavorItemInfo(favorItem.Id, clientFavorItemStatus.Value);
	}

	// Token: 0x06012851 RID: 75857 RVA: 0x00579324 File Offset: 0x00577524
	public EFavorItemStatus GetFavorItemState(int id, EFavorContentType type)
	{
		FavorItemInfo[] array2;
		FavorItemInfo[] array = this.FavorItemMap.TryGetValue(type, out array2) ? array2 : null;
		if (array == null)
		{
			return EFavorItemStatus.ItemLocked;
		}
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			FavorItemInfo favorItemInfo = array[i];
			if (favorItemInfo.Id == id)
			{
				return favorItemInfo.Status;
			}
		}
		return EFavorItemStatus.ItemLocked;
	}

	// Token: 0x06012852 RID: 75858 RVA: 0x00579374 File Offset: 0x00577574
	public EFavorItemStatus? GetClientFavorItemStatus(FavorItemStatus favorItemStatus)
	{
		EFavorItemStatus? result = null;
		if (favorItemStatus == FavorItemStatus.ItemLocked)
		{
			result = new EFavorItemStatus?(EFavorItemStatus.ItemLocked);
		}
		else if (favorItemStatus == FavorItemStatus.ItemCanUnLock)
		{
			result = new EFavorItemStatus?(EFavorItemStatus.ItemCanUnLock);
		}
		else if (favorItemStatus == FavorItemStatus.ItemUnLocked)
		{
			result = new EFavorItemStatus?(EFavorItemStatus.ItemUnLocked);
		}
		return result;
	}

	// Token: 0x06012853 RID: 75859 RVA: 0x005793B4 File Offset: 0x005775B4
	public EFavorContentType? GetClientFavorTabType(FavorItemType favorItemType)
	{
		if (favorItemType == FavorItemType.Word)
		{
			return new EFavorContentType?(EFavorContentType.Voice);
		}
		if (favorItemType == FavorItemType.Story)
		{
			return new EFavorContentType?(EFavorContentType.ExperienceStory);
		}
		if (favorItemType == FavorItemType.Goods)
		{
			return new EFavorContentType?(EFavorContentType.PreciousItem);
		}
		return null;
	}

	// Token: 0x06012854 RID: 75860 RVA: 0x005793EC File Offset: 0x005775EC
	public bool IsExistCanUnlockFavorItem()
	{
		foreach (EFavorContentType favorContentType in this.FavorItemMap.Keys)
		{
			if (this.IsFavorItemCanUnlock(favorContentType))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06012855 RID: 75861 RVA: 0x00579450 File Offset: 0x00577650
	public bool IsFavorItemCanUnlock(EFavorContentType favorContentType)
	{
		if (favorContentType == EFavorContentType.Action)
		{
			return MotionModel.Instance.IfRoleMotionCanUnlock(this.RoleId);
		}
		FavorItemInfo[] array2;
		FavorItemInfo[] array = this.FavorItemMap.TryGetValue(favorContentType, out array2) ? array2 : null;
		if (array == null)
		{
			return false;
		}
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			if (array[i].Status == EFavorItemStatus.ItemCanUnLock)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06012856 RID: 75862 RVA: 0x005794AC File Offset: 0x005776AC
	public int[] GetUnlockActionIndexList()
	{
		List<int> list = new List<int>();
		FavorItemInfo[] array2;
		FavorItemInfo[] array = this.FavorItemMap.TryGetValue(EFavorContentType.Action, out array2) ? array2 : null;
		if (array == null)
		{
			return list.ToArray();
		}
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			FavorItemInfo favorItemInfo = array[i];
			if (favorItemInfo.Status == EFavorItemStatus.ItemUnLocked)
			{
				list.Add(MotionConfig.Instance.GetMotionConfig(favorItemInfo.Id).Value.Sort);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0400A0E2 RID: 41186
	protected int Level;

	// Token: 0x0400A0E3 RID: 41187
	protected int Exp;

	// Token: 0x0400A0E4 RID: 41188
	private readonly Dictionary<EFavorContentType, FavorItemInfo[]> FavorItemMap = new Dictionary<EFavorContentType, FavorItemInfo[]>();
}
