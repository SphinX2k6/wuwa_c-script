using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x020027B1 RID: 10161
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorData : RoleModuleDataBase
{
	// Token: 0x06014E48 RID: 85576 RVA: 0x0054E3DE File Offset: 0x0054C5DE
	public RoleFavorData(int roleId) : base(roleId)
	{
	}

	// Token: 0x06014E49 RID: 85577 RVA: 0x0054E3F2 File Offset: 0x0054C5F2
	public int GetFavorLevel()
	{
		return this.Level;
	}

	// Token: 0x06014E4A RID: 85578 RVA: 0x0054E3FA File Offset: 0x0054C5FA
	public void SetFavorLevel(int level)
	{
		this.Level = level;
	}

	// Token: 0x06014E4B RID: 85579 RVA: 0x0054E403 File Offset: 0x0054C603
	public int GetFavorExp()
	{
		return this.Exp;
	}

	// Token: 0x06014E4C RID: 85580 RVA: 0x0054E40B File Offset: 0x0054C60B
	public void SetFavorExp(int exp)
	{
		this.Exp = exp;
		EventSystem.Instance.Emit(EEventName.RoleFavorExpChange);
	}

	// Token: 0x06014E4D RID: 85581 RVA: 0x0054E424 File Offset: 0x0054C624
	public void UpdateRoleFavorData(EFavorContentType favorContentType, FavorItem[] favorItemList)
	{
		this.FavorItemMap[favorContentType] = this.BuildFavorItemInfoList(favorItemList);
	}

	// Token: 0x06014E4E RID: 85582 RVA: 0x0054E43C File Offset: 0x0054C63C
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

	// Token: 0x06014E4F RID: 85583 RVA: 0x0054E4BC File Offset: 0x0054C6BC
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

	// Token: 0x06014E50 RID: 85584 RVA: 0x0054E594 File Offset: 0x0054C794
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

	// Token: 0x06014E51 RID: 85585 RVA: 0x0054E5D0 File Offset: 0x0054C7D0
	private FavorItemInfo BuildFavorItemInfo(FavorItem favorItem)
	{
		EFavorItemStatus? clientFavorItemStatus = this.GetClientFavorItemStatus(favorItem.Status);
		return new FavorItemInfo(favorItem.Id, clientFavorItemStatus.Value);
	}

	// Token: 0x06014E52 RID: 85586 RVA: 0x0054E5FC File Offset: 0x0054C7FC
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

	// Token: 0x06014E53 RID: 85587 RVA: 0x0054E64C File Offset: 0x0054C84C
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

	// Token: 0x06014E54 RID: 85588 RVA: 0x0054E68C File Offset: 0x0054C88C
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

	// Token: 0x06014E55 RID: 85589 RVA: 0x0054E6C4 File Offset: 0x0054C8C4
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

	// Token: 0x06014E56 RID: 85590 RVA: 0x0054E728 File Offset: 0x0054C928
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

	// Token: 0x06014E57 RID: 85591 RVA: 0x0054E784 File Offset: 0x0054C984
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

	// Token: 0x04009CFF RID: 40191
	protected int Level;

	// Token: 0x04009D00 RID: 40192
	protected int Exp;

	// Token: 0x04009D01 RID: 40193
	private readonly Dictionary<EFavorContentType, FavorItemInfo[]> FavorItemMap = new Dictionary<EFavorContentType, FavorItemInfo[]>();
}
