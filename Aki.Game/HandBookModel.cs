using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020012CB RID: 4811
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class HandBookModel : ModelBase
{
	// Token: 0x0600BDE8 RID: 48616 RVA: 0x00380AF2 File Offset: 0x0037ECF2
	public HandBookModel()
	{
		this.HandBookActiveStateMap = new Dictionary<EHandBookTabType, List<HandBookEntry>>();
		this.HandBookRedDotList = new List<EHandBookTabType>();
		this.AnimalConfigMap = new Dictionary<int, AnimalHandBook>();
		this.RoleOpenTimeLockMap = new Dictionary<int, bool>();
		this.WeaponOpenTimeLockMap = new Dictionary<int, bool>();
	}

	// Token: 0x0600BDE9 RID: 48617 RVA: 0x00380B34 File Offset: 0x0037ED34
	public void UpdateHandBookActiveStateMap(IllustratedType type, IllustratedEntry entry)
	{
		EHandBookTabType clientHandBookType = this.GetClientHandBookType(type, new PhotographSubType?(entry.PhotographSubType));
		int id = entry.Id;
		DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)((ulong)entry.CreateTime * (ulong)((long)TimeUtil.Instance.InverseMillisecond))).LocalDateTime;
		string createTime = TimeUtil.Instance.DateFormat4(localDateTime);
		bool isRead = entry.IsRead;
		int num = entry.Num;
		HandBookEntry handBookEntry = new HandBookEntry(id, createTime, num, isRead, entry.CreateTime);
		List<HandBookEntry> list;
		if (!this.HandBookActiveStateMap.TryGetValue(clientHandBookType, out list))
		{
			List<HandBookEntry> list2 = new List<HandBookEntry>();
			list2.Add(handBookEntry);
			this.HandBookActiveStateMap[clientHandBookType] = list2;
		}
		else
		{
			int count = list.Count;
			bool flag = false;
			for (int i = 0; i < count; i++)
			{
				HandBookEntry handBookEntry2 = list[i];
				if (handBookEntry2.Id == handBookEntry.Id)
				{
					handBookEntry2.CreateTime = handBookEntry.CreateTime;
					handBookEntry2.CreateTimeStampSecond = handBookEntry.CreateTimeStampSecond;
					handBookEntry2.IsRead = handBookEntry.IsRead;
					handBookEntry2.Num = handBookEntry.Num;
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				list.Add(handBookEntry);
			}
		}
		EventSystem.Instance.Emit<EHandBookTabType, int>(EEventName.OnHandBookDataUpdate, clientHandBookType, entry.Id);
	}

	// Token: 0x0600BDEA RID: 48618 RVA: 0x00380C74 File Offset: 0x0037EE74
	public void ClearHandBookActiveStateMap()
	{
		this.HandBookActiveStateMap.Clear();
	}

	// Token: 0x0600BDEB RID: 48619 RVA: 0x00380C84 File Offset: 0x0037EE84
	public void InitHandBookActiveStateMap(IllustratedType type, IllustratedEntry[] entryList)
	{
		List<HandBookEntry> clientHandBookEntryList = this.GetClientHandBookEntryList(entryList);
		List<HandBookEntry> list = new List<HandBookEntry>();
		int count = clientHandBookEntryList.Count;
		if (type != IllustratedType.Photograph)
		{
			EHandBookTabType clientHandBookType = this.GetClientHandBookType(type, null);
			for (int i = 0; i < count; i++)
			{
				HandBookEntry item = clientHandBookEntryList[i];
				list.Add(item);
			}
			this.HandBookActiveStateMap[clientHandBookType] = list;
		}
		else
		{
			this.InitHandBookActiveStateMapQuestType();
			for (int j = 0; j < count; j++)
			{
				HandBookEntry item2 = clientHandBookEntryList[j];
				EHandBookTabType clientHandBookType2 = this.GetClientHandBookType(type, new PhotographSubType?(entryList[j].PhotographSubType));
				this.HandBookActiveStateMap[clientHandBookType2].Add(item2);
			}
		}
		EventSystem.Instance.Emit(EEventName.OnHandBookDataInit);
	}

	// Token: 0x0600BDEC RID: 48620 RVA: 0x00380D48 File Offset: 0x0037EF48
	private void InitHandBookActiveStateMapQuestType()
	{
		this.HandBookActiveStateMap[EHandBookTabType.MainQuest] = new List<HandBookEntry>();
		this.HandBookActiveStateMap[EHandBookTabType.RoleQuest] = new List<HandBookEntry>();
		this.HandBookActiveStateMap[EHandBookTabType.Quest] = new List<HandBookEntry>();
	}

	// Token: 0x0600BDED RID: 48621 RVA: 0x00380D80 File Offset: 0x0037EF80
	public void InitHandBookRedDotList(IReadOnlyList<IllustratedType> typeList)
	{
		this.HandBookRedDotList = new List<EHandBookTabType>();
		int count = typeList.Count;
		for (int i = 0; i < count; i++)
		{
			EHandBookTabType clientHandBookType = this.GetClientHandBookType(typeList[i], null);
			if (clientHandBookType == EHandBookTabType.Item)
			{
				IReadOnlyList<ItemHandBookType> itemHandBookTypeConfigList = HandBookConfig.Instance.GetItemHandBookTypeConfigList();
				int count2 = itemHandBookTypeConfigList.Count;
				for (int j = 0; j < count2; j++)
				{
					ItemHandBookType itemHandBookType = itemHandBookTypeConfigList[j];
					EventSystem.Instance.Emit<int>(EEventName.OnItemReadRedDotUpdate, itemHandBookType.Id);
				}
			}
			this.HandBookRedDotList.Add(clientHandBookType);
		}
		EventSystem.Instance.Emit(EEventName.OnHandBookRedDotUpdate);
	}

	// Token: 0x0600BDEE RID: 48622 RVA: 0x00380E2C File Offset: 0x0037F02C
	public void UpdateRedDot(EHandBookTabType type, int id)
	{
		List<HandBookEntry> list;
		if (!this.HandBookActiveStateMap.TryGetValue(type, out list))
		{
			return;
		}
		int count = list.Count;
		int i = 0;
		while (i < count)
		{
			HandBookEntry handBookEntry = list[i];
			if (handBookEntry.Id == id)
			{
				handBookEntry.IsRead = true;
				EventSystem.Instance.Emit<EHandBookTabType, int>(EEventName.OnHandBookRead, type, handBookEntry.Id);
				EventSystem.Instance.Emit(EEventName.OnPhantomReadRedDotUpdate);
				if (type == EHandBookTabType.Item)
				{
					ItemHandBook? itemHandBookConfigById = HandBookConfig.Instance.GetItemHandBookConfigById(id);
					EventSystem.Instance.Emit<int>(EEventName.OnItemReadRedDotUpdate, itemHandBookConfigById.Value.Type);
					return;
				}
				break;
			}
			else
			{
				i++;
			}
		}
	}

	// Token: 0x0600BDEF RID: 48623 RVA: 0x00380ED0 File Offset: 0x0037F0D0
	public bool IsShowRedDot(EHandBookTabType type)
	{
		int count = this.HandBookRedDotList.Count;
		for (int i = 0; i < count; i++)
		{
			if (type == this.HandBookRedDotList[i])
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600BDF0 RID: 48624 RVA: 0x00380F08 File Offset: 0x0037F108
	public int GetCollectCount(EHandBookTabType type)
	{
		List<HandBookEntry> list;
		if (!this.HandBookActiveStateMap.TryGetValue(type, out list))
		{
			return 0;
		}
		return list.Count;
	}

	// Token: 0x0600BDF1 RID: 48625 RVA: 0x00380F30 File Offset: 0x0037F130
	public List<HandBookEntry> GetClientHandBookEntryList(IllustratedEntry[] entryList)
	{
		List<HandBookEntry> list = new List<HandBookEntry>();
		int num = entryList.Length;
		for (int i = 0; i < num; i++)
		{
			IllustratedEntry illustratedEntry = entryList[i];
			int id = illustratedEntry.Id;
			DateTime localDateTime = DateTimeOffset.FromUnixTimeMilliseconds((long)((ulong)illustratedEntry.CreateTime * (ulong)((long)TimeUtil.Instance.InverseMillisecond))).LocalDateTime;
			string createTime = TimeUtil.Instance.DateFormat4(localDateTime);
			bool isRead = illustratedEntry.IsRead;
			int num2 = illustratedEntry.Num;
			HandBookEntry item = new HandBookEntry(id, createTime, num2, isRead, illustratedEntry.CreateTime);
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0600BDF2 RID: 48626 RVA: 0x00380FBC File Offset: 0x0037F1BC
	[NullableContext(2)]
	public HandBookEntry GetHandBookInfo(EHandBookTabType type, int id)
	{
		List<HandBookEntry> list;
		if (!this.HandBookActiveStateMap.TryGetValue(type, out list))
		{
			return null;
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			HandBookEntry handBookEntry = list[i];
			if (handBookEntry.Id == id)
			{
				return handBookEntry;
			}
		}
		return null;
	}

	// Token: 0x0600BDF3 RID: 48627 RVA: 0x00381004 File Offset: 0x0037F204
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public List<HandBookEntry> GetHandBookInfoList(EHandBookTabType type)
	{
		List<HandBookEntry> result;
		if (!this.HandBookActiveStateMap.TryGetValue(type, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x0600BDF4 RID: 48628 RVA: 0x00381024 File Offset: 0x0037F224
	public EHandBookTabType GetClientHandBookType(IllustratedType type, PhotographSubType? subType = null)
	{
		EHandBookTabType result;
		switch (type)
		{
		case IllustratedType.Monster:
			result = EHandBookTabType.Monster;
			break;
		case IllustratedType.VocalCorpse:
			result = EHandBookTabType.Phantom;
			break;
		case IllustratedType.ViewPoint:
			result = EHandBookTabType.Geography;
			break;
		case IllustratedType.Weapon:
			result = EHandBookTabType.Weapon;
			break;
		case IllustratedType.Animal:
			result = EHandBookTabType.Animal;
			break;
		case IllustratedType.Item:
			result = EHandBookTabType.Item;
			break;
		case IllustratedType.Chip:
			result = EHandBookTabType.Chip;
			break;
		case IllustratedType.Photograph:
			if (subType == null)
			{
				result = EHandBookTabType.Quest;
			}
			else
			{
				switch (subType.Value)
				{
				case PhotographSubType.PhotographSub:
					result = EHandBookTabType.Quest;
					break;
				case PhotographSubType.Role:
					result = EHandBookTabType.RoleQuest;
					break;
				case PhotographSubType.Quest:
					result = EHandBookTabType.MainQuest;
					break;
				default:
					result = EHandBookTabType.Quest;
					break;
				}
			}
			break;
		case IllustratedType.Noun:
			result = EHandBookTabType.Noun;
			break;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.HandBook;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "GetClientHandBookType 错误，不在目标类型内";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			result = EHandBookTabType.Monster;
			break;
		}
		}
		return result;
	}

	// Token: 0x0600BDF5 RID: 48629 RVA: 0x003810F4 File Offset: 0x0037F2F4
	public IllustratedType GetServerHandBookType(EHandBookTabType type)
	{
		switch (type)
		{
		case EHandBookTabType.Monster:
			return IllustratedType.Monster;
		case EHandBookTabType.Phantom:
			return IllustratedType.VocalCorpse;
		case EHandBookTabType.Geography:
			return IllustratedType.ViewPoint;
		case EHandBookTabType.Weapon:
			return IllustratedType.Weapon;
		case EHandBookTabType.Animal:
			return IllustratedType.Animal;
		case EHandBookTabType.Item:
			return IllustratedType.Item;
		case EHandBookTabType.Chip:
			return IllustratedType.Chip;
		case EHandBookTabType.Quest:
			return IllustratedType.Photograph;
		case EHandBookTabType.RoleQuest:
			return IllustratedType.Photograph;
		case EHandBookTabType.MainQuest:
			return IllustratedType.Photograph;
		case EHandBookTabType.Noun:
			return IllustratedType.Noun;
		}
		return IllustratedType.Photograph;
	}

	// Token: 0x0600BDF6 RID: 48630 RVA: 0x00381168 File Offset: 0x0037F368
	public IllustratedType[] GetServerHandBookTypeList(List<EHandBookTabType> typeList)
	{
		int count = typeList.Count;
		IllustratedType[] array = new IllustratedType[count];
		for (int i = 0; i < count; i++)
		{
			IllustratedType serverHandBookType = this.GetServerHandBookType(typeList[i]);
			array[i] = serverHandBookType;
		}
		return array;
	}

	// Token: 0x0600BDF7 RID: 48631 RVA: 0x003811A4 File Offset: 0x0037F3A4
	public AnimalHandBook? GetAnimalConfigByMeshId(int meshId)
	{
		if (this.AnimalConfigMap.Count == 0)
		{
			IReadOnlyList<AnimalHandBook> animalHandBookConfigList = HandBookConfig.Instance.GetAnimalHandBookConfigList();
			int count = animalHandBookConfigList.Count;
			for (int i = 0; i < count; i++)
			{
				AnimalHandBook value = animalHandBookConfigList[i];
				this.AnimalConfigMap[value.MeshId] = value;
			}
		}
		AnimalHandBook value2;
		if (this.AnimalConfigMap.TryGetValue(meshId, out value2))
		{
			return new AnimalHandBook?(value2);
		}
		return null;
	}

	// Token: 0x0600BDF8 RID: 48632 RVA: 0x0038121C File Offset: 0x0037F41C
	public int[] GetRoleHandBookCount()
	{
		int num = 0;
		IEnumerable<RoleInfo> roleList = RoleConfig.Instance.GetRoleList();
		List<RoleInfo> list = new List<RoleInfo>();
		foreach (RoleInfo item in roleList)
		{
			if (item.RoleType == 1 && !RoleModel.Instance.IsMainRole(item.Id) && this.GetRoleCanShowInHandBook(item.Id))
			{
				list.Add(item);
			}
		}
		foreach (RoleInfo roleInfo in list)
		{
			if (RoleModel.Instance.GetRoleDataById(roleInfo.Id, true) != null)
			{
				num++;
			}
		}
		return new int[]
		{
			num + 1,
			list.Count + 1
		};
	}

	// Token: 0x0600BDF9 RID: 48633 RVA: 0x00381308 File Offset: 0x0037F508
	public int[] GetQuestCount()
	{
		int num = 0;
		IReadOnlyList<PhotographHandBook> allPlotHandBookConfig = HandBookConfig.Instance.GetAllPlotHandBookConfig();
		foreach (PhotographHandBook photographHandBook in allPlotHandBookConfig)
		{
			int type = HandBookConfig.Instance.GetPlotTypeConfig(photographHandBook.Type).Value.Type;
			if (HandBookModel.Instance.GetHandBookInfo((EHandBookTabType)type, photographHandBook.Id) != null)
			{
				num++;
			}
		}
		return new int[]
		{
			num,
			allPlotHandBookConfig.Count
		};
	}

	// Token: 0x0600BDFA RID: 48634 RVA: 0x003813A8 File Offset: 0x0037F5A8
	public int[] GetMonsterCount()
	{
		int num = 0;
		int num2 = 0;
		foreach (MonsterHandBook monsterHandBook in HandBookConfig.Instance.GetMonsterHandBookConfigList())
		{
			if (!monsterHandBook.IsSkin && monsterHandBook.OriginalFormInfoId <= 0)
			{
				if (monsterHandBook.DefaultUnlock)
				{
					num++;
					num2++;
				}
				else
				{
					if (this.GetHandBookInfo(EHandBookTabType.Monster, monsterHandBook.Id) != null)
					{
						num++;
					}
					num2++;
				}
			}
		}
		return new int[]
		{
			num,
			num2
		};
	}

	// Token: 0x0600BDFB RID: 48635 RVA: 0x00381444 File Offset: 0x0037F644
	public int[] GetAllHandBookMonsterIdList()
	{
		List<int> list = new List<int>();
		foreach (MonsterHandBook monsterHandBook in HandBookConfig.Instance.GetMonsterHandBookConfigList())
		{
			if (!monsterHandBook.IsSkin)
			{
				list.Add(monsterHandBook.Id);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600BDFC RID: 48636 RVA: 0x003814B0 File Offset: 0x0037F6B0
	public int[] GetAllHandBookWeaponIdList()
	{
		List<int> list = new List<int>();
		foreach (WeaponConf weaponConf in WeaponConfig.Instance.GetWeaponForHandBook())
		{
			bool flag;
			if (!this.WeaponOpenTimeLockMap.TryGetValue(weaponConf.ItemId, out flag) || !flag)
			{
				list.Add(weaponConf.ItemId);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600BDFD RID: 48637 RVA: 0x00381534 File Offset: 0x0037F734
	public int[] GetAllHandBookWeaponSkinIdList()
	{
		List<int> list = new List<int>();
		foreach (WeaponSkin weaponSkin in WeaponConfig.Instance.GetWeaponSkinForHandBook())
		{
			bool flag;
			if (!this.WeaponOpenTimeLockMap.TryGetValue(weaponSkin.Id, out flag) || !flag)
			{
				list.Add(weaponSkin.Id);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600BDFE RID: 48638 RVA: 0x003815B8 File Offset: 0x0037F7B8
	public void RefreshRoleHandBookOpenTime(RoleIllustratedInfo[] dataList)
	{
		foreach (RoleIllustratedInfo roleIllustratedInfo in dataList)
		{
			this.RoleOpenTimeLockMap[roleIllustratedInfo.RoleId] = ((double)MathUtils.Instance.LongToNumber(roleIllustratedInfo.UnlockTime) > TimeUtil.Instance.GetServerTime());
		}
	}

	// Token: 0x0600BDFF RID: 48639 RVA: 0x00381608 File Offset: 0x0037F808
	public bool GetRoleCanShowInHandBook(int roleId)
	{
		bool flag;
		return !this.RoleOpenTimeLockMap.TryGetValue(roleId, out flag) || !flag;
	}

	// Token: 0x0600BE00 RID: 48640 RVA: 0x0038162C File Offset: 0x0037F82C
	public void RefreshWeaponHandBookOpenTime(WeaponIllustratedInfo[] dataList)
	{
		foreach (WeaponIllustratedInfo weaponIllustratedInfo in dataList)
		{
			this.WeaponOpenTimeLockMap[weaponIllustratedInfo.WeaponId] = ((double)MathUtils.Instance.LongToNumber(weaponIllustratedInfo.UnlockTime) > TimeUtil.Instance.GetServerTime());
		}
	}

	// Token: 0x170012AE RID: 4782
	// (get) Token: 0x0600BE01 RID: 48641 RVA: 0x0038167B File Offset: 0x0037F87B
	public static HandBookModel Instance
	{
		get
		{
			return HandBookModel._Instance;
		}
	}

	// Token: 0x0600BE02 RID: 48642 RVA: 0x00381682 File Offset: 0x0037F882
	public static HandBookModel GetOrCreateInstance()
	{
		if (HandBookModel._Instance == null)
		{
			HandBookModel.CreateInstance();
		}
		return HandBookModel._Instance;
	}

	// Token: 0x0600BE03 RID: 48643 RVA: 0x00381696 File Offset: 0x0037F896
	public static bool CreateInstance()
	{
		if (HandBookModel._Instance != null)
		{
			return true;
		}
		HandBookModel._Instance = new HandBookModel();
		return true;
	}

	// Token: 0x0600BE04 RID: 48644 RVA: 0x003816AC File Offset: 0x0037F8AC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600BE05 RID: 48645 RVA: 0x003816AE File Offset: 0x0037F8AE
	public static void ResetStaticDefaultValue()
	{
		HandBookModel._Instance = null;
	}

	// Token: 0x0600BE06 RID: 48646 RVA: 0x003816B6 File Offset: 0x0037F8B6
	static HandBookModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HandBookModel.CreateStaticDefaultValue), new Action(HandBookModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006D5F RID: 27999
	private readonly Dictionary<EHandBookTabType, List<HandBookEntry>> HandBookActiveStateMap;

	// Token: 0x04006D60 RID: 28000
	private List<EHandBookTabType> HandBookRedDotList;

	// Token: 0x04006D61 RID: 28001
	private readonly Dictionary<int, AnimalHandBook> AnimalConfigMap;

	// Token: 0x04006D62 RID: 28002
	public int CurrentSelectMonsterHandBookId;

	// Token: 0x04006D63 RID: 28003
	public int CurrentSelectWeaponHandBookId;

	// Token: 0x04006D64 RID: 28004
	public Dictionary<int, bool> RoleOpenTimeLockMap;

	// Token: 0x04006D65 RID: 28005
	public Dictionary<int, bool> WeaponOpenTimeLockMap;

	// Token: 0x04006D66 RID: 28006
	[Nullable(2)]
	private static HandBookModel _Instance;
}
