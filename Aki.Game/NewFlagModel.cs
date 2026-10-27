using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x020022D1 RID: 8913
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class NewFlagModel : ModelBase
{
	// Token: 0x06011800 RID: 71680 RVA: 0x0044A897 File Offset: 0x00448A97
	protected override bool OnInit()
	{
		this.OnAddEvents();
		return true;
	}

	// Token: 0x06011801 RID: 71681 RVA: 0x0044A8A0 File Offset: 0x00448AA0
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x06011802 RID: 71682 RVA: 0x0044A8A9 File Offset: 0x00448AA9
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(this.LoadNewFlagConfig));
		EventSystem.Instance.Add(EEventName.LogOut, new Action(this.ClearNewFlag));
	}

	// Token: 0x06011803 RID: 71683 RVA: 0x0044A8E3 File Offset: 0x00448AE3
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnGetPlayerBasicInfo, new Action(this.LoadNewFlagConfig));
		EventSystem.Instance.Remove(EEventName.LogOut, new Action(this.ClearNewFlag));
	}

	// Token: 0x06011804 RID: 71684 RVA: 0x0044A920 File Offset: 0x00448B20
	public void LoadNewFlagConfig()
	{
		foreach (ELocalStoragePlayerKey key in this.NewFlagLocalStoragePlayerKeyList)
		{
			List<int> player = LocalStorage.GetPlayer<List<int>>(key, null);
			HashSet<int> value = (player != null) ? new HashSet<int>(player) : new HashSet<int>();
			this.NewFlagMap[key] = value;
			this.FlagDirtyMap[key] = false;
		}
		EventSystem.Instance.Emit(EEventName.OnLoadedNewFlagConfig);
	}

	// Token: 0x06011805 RID: 71685 RVA: 0x0044A9B0 File Offset: 0x00448BB0
	public void ClearNewFlag()
	{
		this.NewFlagMap.Clear();
		this.TempArray.Clear();
		this.FlagDirtyMap.Clear();
	}

	// Token: 0x06011806 RID: 71686 RVA: 0x0044A9D4 File Offset: 0x00448BD4
	public bool SaveNewFlagConfig(ELocalStoragePlayerKey key)
	{
		HashSet<int> collection;
		if (!this.NewFlagMap.TryGetValue(key, out collection))
		{
			return false;
		}
		EClientStorageSystemIdType eclientStorageSystemIdType;
		if (this.localToServerStorageKey.TryGetValue(key, out eclientStorageSystemIdType))
		{
			return true;
		}
		bool flag;
		if (!this.FlagDirtyMap.TryGetValue(key, out flag) || !flag)
		{
			return false;
		}
		this.TempArray.Clear();
		this.TempArray.AddRange(collection);
		this.FlagDirtyMap[key] = false;
		return LocalStorage.SetPlayer<List<int>>(key, this.TempArray);
	}

	// Token: 0x06011807 RID: 71687 RVA: 0x0044AA4C File Offset: 0x00448C4C
	public bool AddNewFlag(ELocalStoragePlayerKey key, int value)
	{
		HashSet<int> hashSet;
		if (!this.NewFlagMap.TryGetValue(key, out hashSet))
		{
			return false;
		}
		EClientStorageSystemIdType key2;
		if (this.localToServerStorageKey.TryGetValue(key, out key2))
		{
			(ServerStorageModel.Instance.Get(key2) as ServerStorageSet).Add(value);
		}
		else
		{
			hashSet.Add(value);
			this.FlagDirtyMap[key] = true;
		}
		return true;
	}

	// Token: 0x06011808 RID: 71688 RVA: 0x0044AAAC File Offset: 0x00448CAC
	public bool RemoveNewFlag(ELocalStoragePlayerKey key, int value)
	{
		HashSet<int> hashSet;
		if (!this.NewFlagMap.TryGetValue(key, out hashSet))
		{
			return false;
		}
		EClientStorageSystemIdType key2;
		if (this.localToServerStorageKey.TryGetValue(key, out key2))
		{
			(ServerStorageModel.Instance.Get(key2) as ServerStorageSet).Remove(value);
			return true;
		}
		bool flag = hashSet.Remove(value);
		bool flag2 = this.FlagDirtyMap[key];
		this.FlagDirtyMap[key] = (flag || flag2);
		return flag;
	}

	// Token: 0x06011809 RID: 71689 RVA: 0x0044AB1C File Offset: 0x00448D1C
	public bool HasNewFlag(ELocalStoragePlayerKey key, int value)
	{
		EClientStorageSystemIdType key2;
		if (this.localToServerStorageKey.TryGetValue(key, out key2))
		{
			return (ServerStorageModel.Instance.Get(key2) as ServerStorageSet).Has(value);
		}
		HashSet<int> hashSet;
		return this.NewFlagMap.TryGetValue(key, out hashSet) && hashSet.Contains(value);
	}

	// Token: 0x0601180A RID: 71690 RVA: 0x0044AB6C File Offset: 0x00448D6C
	[NullableContext(2)]
	[Obsolete("该接口仅为条件检测使用，之后条件检测修改获取数据方式后，该接口废除，不让外部获取")]
	public HashSet<int> GetNewFlagSet(ELocalStoragePlayerKey key)
	{
		HashSet<int> result;
		this.NewFlagMap.TryGetValue(key, out result);
		return result;
	}

	// Token: 0x17001649 RID: 5705
	// (get) Token: 0x0601180B RID: 71691 RVA: 0x0044AB89 File Offset: 0x00448D89
	public static NewFlagModel Instance
	{
		get
		{
			return NewFlagModel._Instance;
		}
	}

	// Token: 0x0601180C RID: 71692 RVA: 0x0044AB90 File Offset: 0x00448D90
	public static NewFlagModel GetOrCreateInstance()
	{
		if (NewFlagModel._Instance == null)
		{
			NewFlagModel.CreateInstance();
		}
		return NewFlagModel._Instance;
	}

	// Token: 0x0601180D RID: 71693 RVA: 0x0044ABA4 File Offset: 0x00448DA4
	public static bool CreateInstance()
	{
		if (NewFlagModel._Instance != null)
		{
			return true;
		}
		NewFlagModel._Instance = new NewFlagModel();
		return true;
	}

	// Token: 0x0601180E RID: 71694 RVA: 0x0044ABBA File Offset: 0x00448DBA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601180F RID: 71695 RVA: 0x0044ABBC File Offset: 0x00448DBC
	public static void ResetStaticDefaultValue()
	{
		NewFlagModel._Instance = null;
	}

	// Token: 0x06011810 RID: 71696 RVA: 0x0044ABC4 File Offset: 0x00448DC4
	static NewFlagModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NewFlagModel.CreateStaticDefaultValue), new Action(NewFlagModel.ResetStaticDefaultValue));
	}

	// Token: 0x040084DA RID: 34010
	private readonly Dictionary<ELocalStoragePlayerKey, HashSet<int>> NewFlagMap = new Dictionary<ELocalStoragePlayerKey, HashSet<int>>();

	// Token: 0x040084DB RID: 34011
	private readonly List<int> TempArray = new List<int>();

	// Token: 0x040084DC RID: 34012
	private readonly Dictionary<ELocalStoragePlayerKey, bool> FlagDirtyMap = new Dictionary<ELocalStoragePlayerKey, bool>();

	// Token: 0x040084DD RID: 34013
	private List<ELocalStoragePlayerKey> NewFlagLocalStoragePlayerKeyList = new List<ELocalStoragePlayerKey>
	{
		ELocalStoragePlayerKey.ComposeLevelKey,
		ELocalStoragePlayerKey.CookerLevelKey,
		ELocalStoragePlayerKey.ForgingLevelKey,
		ELocalStoragePlayerKey.FlySkinRedDot,
		ELocalStoragePlayerKey.InventoryAttributeItem,
		ELocalStoragePlayerKey.InventoryCommonItem,
		ELocalStoragePlayerKey.InventoryAttributeItemRedDot,
		ELocalStoragePlayerKey.InventoryCommonItemRedDot,
		ELocalStoragePlayerKey.MoonChasingShopItemUnlock,
		ELocalStoragePlayerKey.MoonChasingShopItemChecked,
		ELocalStoragePlayerKey.MoonChasingRoleUnlock,
		ELocalStoragePlayerKey.MoonChasingQuestUnlock,
		ELocalStoragePlayerKey.PersonalDataItem,
		ELocalStoragePlayerKey.RoleDataItem,
		ELocalStoragePlayerKey.RouletteAssemblyItemRedDot,
		ELocalStoragePlayerKey.VisionSkin,
		ELocalStoragePlayerKey.WeaponSkinRedDot,
		ELocalStoragePlayerKey.RoleSkinRedDot,
		ELocalStoragePlayerKey.DockyardListItemRead,
		ELocalStoragePlayerKey.PayShopTabItemChecked,
		ELocalStoragePlayerKey.RoguelikeShopItemChecked,
		ELocalStoragePlayerKey.FishingHandBookItemRecord,
		ELocalStoragePlayerKey.FishingShipSkinRecord,
		ELocalStoragePlayerKey.CalabashSkinRedDot
	};

	// Token: 0x040084DE RID: 34014
	private readonly Dictionary<ELocalStoragePlayerKey, EClientStorageSystemIdType> localToServerStorageKey = new Dictionary<ELocalStoragePlayerKey, EClientStorageSystemIdType>
	{
		{
			ELocalStoragePlayerKey.CalabashSkinRedDot,
			EClientStorageSystemIdType.CalabashSkinRedDot
		},
		{
			ELocalStoragePlayerKey.FlySkinRedDot,
			EClientStorageSystemIdType.FlySkinRedDot
		},
		{
			ELocalStoragePlayerKey.VisionSkin,
			EClientStorageSystemIdType.VisionSkin
		},
		{
			ELocalStoragePlayerKey.RoleSkinRedDot,
			EClientStorageSystemIdType.RoleSkinRedDot
		},
		{
			ELocalStoragePlayerKey.WeaponSkinRedDot,
			EClientStorageSystemIdType.WeaponSkinRedDot
		}
	};

	// Token: 0x040084DF RID: 34015
	[Nullable(2)]
	private static NewFlagModel _Instance;
}
