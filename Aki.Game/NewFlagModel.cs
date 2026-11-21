using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x020017B5 RID: 6069
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class NewFlagModel : ModelBase
{
	// Token: 0x0600EC97 RID: 60567 RVA: 0x004575A2 File Offset: 0x004557A2
	protected override bool OnInit()
	{
		this.OnAddEvents();
		return true;
	}

	// Token: 0x0600EC98 RID: 60568 RVA: 0x004575AB File Offset: 0x004557AB
	protected override bool OnClear()
	{
		this.OnRemoveEvents();
		return true;
	}

	// Token: 0x0600EC99 RID: 60569 RVA: 0x004575B4 File Offset: 0x004557B4
	protected void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnGetPlayerBasicInfo, new Action(this.LoadNewFlagConfig));
		EventSystem.Instance.Add(EEventName.LogOut, new Action(this.ClearNewFlag));
	}

	// Token: 0x0600EC9A RID: 60570 RVA: 0x004575EE File Offset: 0x004557EE
	protected void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnGetPlayerBasicInfo, new Action(this.LoadNewFlagConfig));
		EventSystem.Instance.Remove(EEventName.LogOut, new Action(this.ClearNewFlag));
	}

	// Token: 0x0600EC9B RID: 60571 RVA: 0x00457628 File Offset: 0x00455828
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

	// Token: 0x0600EC9C RID: 60572 RVA: 0x004576B8 File Offset: 0x004558B8
	public void ClearNewFlag()
	{
		this.NewFlagMap.Clear();
		this.TempArray.Clear();
		this.FlagDirtyMap.Clear();
	}

	// Token: 0x0600EC9D RID: 60573 RVA: 0x004576DC File Offset: 0x004558DC
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

	// Token: 0x0600EC9E RID: 60574 RVA: 0x00457754 File Offset: 0x00455954
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

	// Token: 0x0600EC9F RID: 60575 RVA: 0x004577B4 File Offset: 0x004559B4
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

	// Token: 0x0600ECA0 RID: 60576 RVA: 0x00457824 File Offset: 0x00455A24
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

	// Token: 0x0600ECA1 RID: 60577 RVA: 0x00457874 File Offset: 0x00455A74
	[NullableContext(2)]
	[Obsolete("该接口仅为条件检测使用，之后条件检测修改获取数据方式后，该接口废除，不让外部获取")]
	public HashSet<int> GetNewFlagSet(ELocalStoragePlayerKey key)
	{
		HashSet<int> result;
		this.NewFlagMap.TryGetValue(key, out result);
		return result;
	}

	// Token: 0x17001680 RID: 5760
	// (get) Token: 0x0600ECA2 RID: 60578 RVA: 0x00457891 File Offset: 0x00455A91
	public static NewFlagModel Instance
	{
		get
		{
			return NewFlagModel._Instance;
		}
	}

	// Token: 0x0600ECA3 RID: 60579 RVA: 0x00457898 File Offset: 0x00455A98
	public static NewFlagModel GetOrCreateInstance()
	{
		if (NewFlagModel._Instance == null)
		{
			NewFlagModel.CreateInstance();
		}
		return NewFlagModel._Instance;
	}

	// Token: 0x0600ECA4 RID: 60580 RVA: 0x004578AC File Offset: 0x00455AAC
	public static bool CreateInstance()
	{
		if (NewFlagModel._Instance != null)
		{
			return true;
		}
		NewFlagModel._Instance = new NewFlagModel();
		return true;
	}

	// Token: 0x0600ECA5 RID: 60581 RVA: 0x004578C2 File Offset: 0x00455AC2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600ECA6 RID: 60582 RVA: 0x004578C4 File Offset: 0x00455AC4
	public static void ResetStaticDefaultValue()
	{
		NewFlagModel._Instance = null;
	}

	// Token: 0x0600ECA7 RID: 60583 RVA: 0x004578CC File Offset: 0x00455ACC
	static NewFlagModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(NewFlagModel.CreateStaticDefaultValue), new Action(NewFlagModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008618 RID: 34328
	private readonly Dictionary<ELocalStoragePlayerKey, HashSet<int>> NewFlagMap = new Dictionary<ELocalStoragePlayerKey, HashSet<int>>();

	// Token: 0x04008619 RID: 34329
	private readonly List<int> TempArray = new List<int>();

	// Token: 0x0400861A RID: 34330
	private readonly Dictionary<ELocalStoragePlayerKey, bool> FlagDirtyMap = new Dictionary<ELocalStoragePlayerKey, bool>();

	// Token: 0x0400861B RID: 34331
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

	// Token: 0x0400861C RID: 34332
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

	// Token: 0x0400861D RID: 34333
	[Nullable(2)]
	private static NewFlagModel _Instance;
}
