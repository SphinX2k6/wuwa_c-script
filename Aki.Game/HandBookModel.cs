using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02001E09 RID: 7689
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class HandBookModel : ModelBase
{
	// Token: 0x0600E9C9 RID: 59849 RVA: 0x00374DEA File Offset: 0x00372FEA
	public HandBookModel()
	{
		this.HandBookActiveStateMap = new Dictionary<EHandBookTabType, List<HandBookEntry>>();
		this.HandBookRedDotList = new List<EHandBookTabType>();
		this.AnimalConfigMap = new Dictionary<int, AnimalHandBook>();
		this.RoleOpenTimeLockMap = new Dictionary<int, bool>();
		this.WeaponOpenTimeLockMap = new Dictionary<int, bool>();
	}

	// Token: 0x0600E9CA RID: 59850 RVA: 0x00374E2C File Offset: 0x0037302C
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

	// Token: 0x0600E9CB RID: 59851 RVA: 0x00374F6C File Offset: 0x0037316C
	public void ClearHandBookActiveStateMap()
	{
		this.HandBookActiveStateMap.Clear();
	}

	// Token: 0x0600E9CC RID: 59852 RVA: 0x00374F7C File Offset: 0x0037317C
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

	// Token: 0x0600E9CD RID: 59853 RVA: 0x00375040 File Offset: 0x00373240
	private void InitHandBookActiveStateMapQuestType()
	{
		this.HandBookActiveStateMap[EHandBookTabType.MainQuest] = new List<HandBookEntry>();
		this.HandBookActiveStateMap[EHandBookTabType.RoleQuest] = new List<HandBookEntry>();
		this.HandBookActiveStateMap[EHandBookTabType.Quest] = new List<HandBookEntry>();
	}

	// Token: 0x0600E9CE RID: 59854 RVA: 0x00375078 File Offset: 0x00373278
	public void InitHandBookRedDotList(List<IllustratedType> typeList)
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

	// Token: 0x0600E9CF RID: 59855 RVA: 0x00375124 File Offset: 0x00373324
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

	// Token: 0x0600E9D0 RID: 59856 RVA: 0x003751C8 File Offset: 0x003733C8
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

	// Token: 0x0600E9D1 RID: 59857 RVA: 0x00375200 File Offset: 0x00373400
	public int GetCollectCount(EHandBookTabType type)
	{
		List<HandBookEntry> list;
		if (!this.HandBookActiveStateMap.TryGetValue(type, out list))
		{
			return 0;
		}
		return list.Count;
	}

	// Token: 0x0600E9D2 RID: 59858 RVA: 0x00375228 File Offset: 0x00373428
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

	// Token: 0x0600E9D3 RID: 59859 RVA: 0x003752B4 File Offset: 0x003734B4
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

	// Token: 0x0600E9D4 RID: 59860 RVA: 0x003752FC File Offset: 0x003734FC
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

	// Token: 0x0600E9D5 RID: 59861 RVA: 0x0037531C File Offset: 0x0037351C
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

	// Token: 0x0600E9D6 RID: 59862 RVA: 0x003753EC File Offset: 0x003735EC
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

	// Token: 0x0600E9D7 RID: 59863 RVA: 0x00375460 File Offset: 0x00373660
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

	// Token: 0x0600E9D8 RID: 59864 RVA: 0x0037549C File Offset: 0x0037369C
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

	// Token: 0x0600E9D9 RID: 59865 RVA: 0x00375514 File Offset: 0x00373714
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

	// Token: 0x0600E9DA RID: 59866 RVA: 0x00375600 File Offset: 0x00373800
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

	// Token: 0x0600E9DB RID: 59867 RVA: 0x003756A0 File Offset: 0x003738A0
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

	// Token: 0x0600E9DC RID: 59868 RVA: 0x0037573C File Offset: 0x0037393C
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

	// Token: 0x0600E9DD RID: 59869 RVA: 0x003757A8 File Offset: 0x003739A8
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

	// Token: 0x0600E9DE RID: 59870 RVA: 0x0037582C File Offset: 0x00373A2C
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

	// Token: 0x0600E9DF RID: 59871 RVA: 0x003758B0 File Offset: 0x00373AB0
	public void RefreshRoleHandBookOpenTime(RoleIllustratedInfo[] dataList)
	{
		foreach (RoleIllustratedInfo roleIllustratedInfo in dataList)
		{
			this.RoleOpenTimeLockMap[roleIllustratedInfo.RoleId] = ((double)MathUtils.Instance.LongToNumber(roleIllustratedInfo.UnlockTime) > TimeUtil.Instance.GetServerTime());
		}
	}

	// Token: 0x0600E9E0 RID: 59872 RVA: 0x00375900 File Offset: 0x00373B00
	public bool GetRoleCanShowInHandBook(int roleId)
	{
		bool flag;
		return !this.RoleOpenTimeLockMap.TryGetValue(roleId, out flag) || !flag;
	}

	// Token: 0x0600E9E1 RID: 59873 RVA: 0x00375924 File Offset: 0x00373B24
	public void RefreshWeaponHandBookOpenTime(WeaponIllustratedInfo[] dataList)
	{
		foreach (WeaponIllustratedInfo weaponIllustratedInfo in dataList)
		{
			this.WeaponOpenTimeLockMap[weaponIllustratedInfo.WeaponId] = ((double)MathUtils.Instance.LongToNumber(weaponIllustratedInfo.UnlockTime) > TimeUtil.Instance.GetServerTime());
		}
	}

	// Token: 0x17001284 RID: 4740
	// (get) Token: 0x0600E9E2 RID: 59874 RVA: 0x00375973 File Offset: 0x00373B73
	public static HandBookModel Instance
	{
		get
		{
			return HandBookModel._Instance;
		}
	}

	// Token: 0x0600E9E3 RID: 59875 RVA: 0x0037597A File Offset: 0x00373B7A
	public static HandBookModel GetOrCreateInstance()
	{
		if (HandBookModel._Instance == null)
		{
			HandBookModel.CreateInstance();
		}
		return HandBookModel._Instance;
	}

	// Token: 0x0600E9E4 RID: 59876 RVA: 0x0037598E File Offset: 0x00373B8E
	public static bool CreateInstance()
	{
		if (HandBookModel._Instance != null)
		{
			return true;
		}
		HandBookModel._Instance = new HandBookModel();
		return true;
	}

	// Token: 0x0600E9E5 RID: 59877 RVA: 0x003759A4 File Offset: 0x00373BA4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E9E6 RID: 59878 RVA: 0x003759A6 File Offset: 0x00373BA6
	public static void ResetStaticDefaultValue()
	{
		HandBookModel._Instance = null;
	}

	// Token: 0x0600E9E7 RID: 59879 RVA: 0x003759AE File Offset: 0x00373BAE
	static HandBookModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(HandBookModel.CreateStaticDefaultValue), new Action(HandBookModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006C7E RID: 27774
	private readonly Dictionary<EHandBookTabType, List<HandBookEntry>> HandBookActiveStateMap;

	// Token: 0x04006C7F RID: 27775
	private List<EHandBookTabType> HandBookRedDotList;

	// Token: 0x04006C80 RID: 27776
	private readonly Dictionary<int, AnimalHandBook> AnimalConfigMap;

	// Token: 0x04006C81 RID: 27777
	public int CurrentSelectMonsterHandBookId;

	// Token: 0x04006C82 RID: 27778
	public int CurrentSelectWeaponHandBookId;

	// Token: 0x04006C83 RID: 27779
	public Dictionary<int, bool> RoleOpenTimeLockMap;

	// Token: 0x04006C84 RID: 27780
	public Dictionary<int, bool> WeaponOpenTimeLockMap;

	// Token: 0x04006C85 RID: 27781
	[Nullable(2)]
	private static HandBookModel _Instance;
}
