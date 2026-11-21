using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.LinkedItem;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x020017DE RID: 6110
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleOrnamentModel : ModelBase
{
	// Token: 0x0600EF23 RID: 61219 RVA: 0x00463360 File Offset: 0x00461560
	protected override bool OnInit()
	{
		foreach (Ornament ornament in RoleConfig.Instance.GetAllOrnamentConfig())
		{
			foreach (int num in ornament.RoleSkinIdsIter())
			{
				List<int> list;
				if (!this.Skin2OrnamentMap.TryGetValue(num, out list))
				{
					list = new List<int>();
					this.Skin2OrnamentMap[num] = list;
				}
				list.Add(ornament.Id);
				int roleId = SkinConfig.Instance.GetRoleSkinConfig(num).Value.RoleId;
				HashSet<int> hashSet;
				if (!this.Role2OrnamentMap.TryGetValue(roleId, out hashSet))
				{
					hashSet = new HashSet<int>();
					this.Role2OrnamentMap[roleId] = hashSet;
				}
				hashSet.Add(ornament.Id);
				if (ornament.DefaultOrnament)
				{
					HashSet<int> hashSet2;
					if (!this.Skin2DefaultOrnamentMap.TryGetValue(num, out hashSet2))
					{
						hashSet2 = new HashSet<int>();
						this.Skin2DefaultOrnamentMap[num] = hashSet2;
					}
					hashSet2.Add(ornament.Id);
					this.DefaultOrnamentSet.Add(ornament.Id);
				}
			}
		}
		return true;
	}

	// Token: 0x0600EF24 RID: 61220 RVA: 0x004634E0 File Offset: 0x004616E0
	protected override bool OnClear()
	{
		this.IsCommonItemFinished = false;
		this.PendingOrnamentIdsForInit = null;
		this.PendingOrnamentUnlockBatches.Clear();
		return true;
	}

	// Token: 0x0600EF25 RID: 61221 RVA: 0x004634FC File Offset: 0x004616FC
	public bool GetIsCommonItemFinished()
	{
		return this.IsCommonItemFinished;
	}

	// Token: 0x0600EF26 RID: 61222 RVA: 0x00463504 File Offset: 0x00461704
	public void SetCommonItemFinished()
	{
		this.IsCommonItemFinished = true;
	}

	// Token: 0x0600EF27 RID: 61223 RVA: 0x0046350D File Offset: 0x0046170D
	public void SetPendingOrnamentIdsForInit(int[] ornamentIds)
	{
		this.PendingOrnamentIdsForInit = ornamentIds;
	}

	// Token: 0x0600EF28 RID: 61224 RVA: 0x00463516 File Offset: 0x00461716
	[NullableContext(2)]
	public int[] TakePendingOrnamentIdsForInit()
	{
		int[] pendingOrnamentIdsForInit = this.PendingOrnamentIdsForInit;
		this.PendingOrnamentIdsForInit = null;
		return pendingOrnamentIdsForInit;
	}

	// Token: 0x0600EF29 RID: 61225 RVA: 0x00463525 File Offset: 0x00461725
	public void AddPendingOrnamentUnlockBatch(int[] ornamentIds)
	{
		this.PendingOrnamentUnlockBatches.Add(ornamentIds);
	}

	// Token: 0x0600EF2A RID: 61226 RVA: 0x00463533 File Offset: 0x00461733
	public List<int[]> TakeAllPendingOrnamentUnlockBatches()
	{
		List<int[]> result = new List<int[]>(this.PendingOrnamentUnlockBatches);
		this.PendingOrnamentUnlockBatches.Clear();
		return result;
	}

	// Token: 0x0600EF2B RID: 61227 RVA: 0x0046354C File Offset: 0x0046174C
	public void UpdateOwnOrnament(int[] ornamentIds)
	{
		foreach (int item in ornamentIds)
		{
			this.OwnOrnamentSet.Add(item);
		}
	}

	// Token: 0x0600EF2C RID: 61228 RVA: 0x0046357C File Offset: 0x0046177C
	public void UpdateWearOrnament(IEnumerable<OrnamentDressInfo> dressInfo)
	{
		foreach (OrnamentDressInfo ornamentDressInfo in dressInfo)
		{
			int roleSkinId = ornamentDressInfo.RoleSkinId;
			List<int> value = new List<int>(ornamentDressInfo.DressOrnamentIds);
			this.Skin2WearOrnamentMap[roleSkinId] = value;
		}
	}

	// Token: 0x0600EF2D RID: 61229 RVA: 0x004635DC File Offset: 0x004617DC
	public void UpdateNewlyAddedOrnament(int[] ornamentIds)
	{
		foreach (int item in ornamentIds)
		{
			this.NewlyAddedOrnamentSet.Add(item);
		}
	}

	// Token: 0x0600EF2E RID: 61230 RVA: 0x0046360C File Offset: 0x0046180C
	public int GetNormalizedOrnamentSkinId(int skinId)
	{
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(skinId);
		int num = roleSkinData.GetRoleId();
		if (!RoleModel.Instance.IsMainRole(num))
		{
			return skinId;
		}
		int groupId = roleSkinData.GetRoleSkinConfig().GroupId;
		int id;
		if (this.MainRoleNormalizedSkinIdMap.TryGetValue(groupId, out id))
		{
			return id;
		}
		MainRoleConfig value = RoleConfig.Instance.GetMainRoleById(num).Value;
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("LightMainRoleIdList");
		num = ((value.Gender == 1) ? intArrayConfig[0] : intArrayConfig[1]);
		id = SkinConfig.Instance.GetSkinConfigByRoleIdAndGroupId(num, groupId).Value.Id;
		this.MainRoleNormalizedSkinIdMap[groupId] = id;
		return id;
	}

	// Token: 0x0600EF2F RID: 61231 RVA: 0x004636CC File Offset: 0x004618CC
	[NullableContext(2)]
	public RoleOrnamentData GetRoleOrnamentData(int id)
	{
		if (InventoryConfig.Instance.GetItemDataTypeByConfigId(new int?(id)) != InventoryDefine.EItemDataType.OrnamentItem)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RoleOrnament;
			ELogAuthor author = ELogAuthor.LJS;
			string message = "无效的饰品道具id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		RoleOrnamentData roleOrnamentData;
		if (!this.RoleOrnamentMap.TryGetValue(id, out roleOrnamentData))
		{
			roleOrnamentData = new RoleOrnamentData(id);
			this.RoleOrnamentMap[id] = roleOrnamentData;
		}
		return roleOrnamentData;
	}

	// Token: 0x0600EF30 RID: 61232 RVA: 0x00463744 File Offset: 0x00461944
	public List<int> GetSkinAllOrnaments(int id, bool? ownedFirst = null)
	{
		List<int> list;
		if (!this.Skin2OrnamentMap.TryGetValue(id, out list))
		{
			list = new List<int>();
		}
		List<int> list2 = new List<int>();
		foreach (int num in list)
		{
			if (!this.DefaultOrnamentSet.Contains(num) && !LinkedItemConfig.Instance.ShouldHide(num, this.IsOwnOrnament(num)))
			{
				list2.Add(num);
			}
		}
		if (ownedFirst.GetValueOrDefault())
		{
			list2.Sort(new Comparison<int>(this.SortOwnedFirst));
		}
		else
		{
			list2.Sort(new Comparison<int>(this.SortBySortIndex));
		}
		return list2;
	}

	// Token: 0x0600EF31 RID: 61233 RVA: 0x00463800 File Offset: 0x00461A00
	public List<int> GetSkinAllWearingOrnaments(int id, bool includeDefault = true)
	{
		int normalizedOrnamentSkinId = this.GetNormalizedOrnamentSkinId(id);
		List<int> list;
		if (!this.Skin2WearOrnamentMap.TryGetValue(normalizedOrnamentSkinId, out list))
		{
			list = new List<int>();
		}
		if (!includeDefault)
		{
			return list;
		}
		return this.MergeDefaultOrnaments(list, id);
	}

	// Token: 0x0600EF32 RID: 61234 RVA: 0x00463838 File Offset: 0x00461A38
	public List<int> MergeDefaultOrnaments(List<int> serverWearList, int skinId)
	{
		HashSet<int> hashSet;
		if (!this.Skin2DefaultOrnamentMap.TryGetValue(skinId, out hashSet) || hashSet.Count == 0)
		{
			return serverWearList;
		}
		HashSet<int> hashSet2 = new HashSet<int>();
		foreach (int id in serverWearList)
		{
			Ornament? ornamentConfig = RoleConfig.Instance.GetOrnamentConfig(id);
			bool flag;
			if (ornamentConfig == null)
			{
				flag = false;
			}
			else
			{
				int orGroupId = ornamentConfig.GetValueOrDefault().OrGroupId;
				flag = true;
			}
			if (flag)
			{
				hashSet2.Add(ornamentConfig.Value.OrGroupId);
			}
		}
		List<int> list = new List<int>(serverWearList);
		foreach (int num in hashSet)
		{
			Ornament? ornamentConfig2 = RoleConfig.Instance.GetOrnamentConfig(num);
			bool flag2;
			if (ornamentConfig2 == null)
			{
				flag2 = true;
			}
			else
			{
				int orGroupId2 = ornamentConfig2.GetValueOrDefault().OrGroupId;
				flag2 = false;
			}
			if (flag2 || !hashSet2.Contains(ornamentConfig2.Value.OrGroupId))
			{
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x0600EF33 RID: 61235 RVA: 0x00463974 File Offset: 0x00461B74
	public List<int> GetRoleSkinAllWearingOrnaments(int roleId, int skinId)
	{
		if (!RoleUtils.IsTrialRole(roleId))
		{
			return this.GetSkinAllWearingOrnaments(skinId, true);
		}
		HashSet<int> collection;
		if (this.Skin2DefaultOrnamentMap.TryGetValue(skinId, out collection))
		{
			return new List<int>(collection);
		}
		return new List<int>();
	}

	// Token: 0x0600EF34 RID: 61236 RVA: 0x004639AE File Offset: 0x00461BAE
	public int GetOrnamentCountById(int ornamentId)
	{
		return (this.IsOwnOrnament(ornamentId) > false) ? 1 : 0;
	}

	// Token: 0x0600EF35 RID: 61237 RVA: 0x004639BA File Offset: 0x00461BBA
	public bool IsOwnOrnament(int ornamentId)
	{
		return this.OwnOrnamentSet.Contains(ornamentId) || this.DefaultOrnamentSet.Contains(ornamentId);
	}

	// Token: 0x0600EF36 RID: 61238 RVA: 0x004639D8 File Offset: 0x00461BD8
	public bool IsDefaultOrnament(int ornamentId)
	{
		return this.DefaultOrnamentSet.Contains(ornamentId);
	}

	// Token: 0x0600EF37 RID: 61239 RVA: 0x004639E8 File Offset: 0x00461BE8
	public bool IsOrnamentConflictOnSkin(int ornamentId, int skinId, bool includeDefault = true)
	{
		RoleOrnamentData roleOrnamentData = this.GetRoleOrnamentData(ornamentId);
		if (roleOrnamentData == null)
		{
			return false;
		}
		int groupId = roleOrnamentData.GetGroupId();
		if (groupId == 0)
		{
			return false;
		}
		foreach (int id in this.GetSkinAllWearingOrnaments(skinId, includeDefault))
		{
			RoleOrnamentData roleOrnamentData2 = this.GetRoleOrnamentData(id);
			if (roleOrnamentData2 != null && roleOrnamentData2.GetGroupId() == groupId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600EF38 RID: 61240 RVA: 0x00463A70 File Offset: 0x00461C70
	public List<int> GetConflictOrnamentsOnSkin(int ornamentId, int skinId, bool includeDefault = true)
	{
		RoleOrnamentData roleOrnamentData = this.GetRoleOrnamentData(ornamentId);
		if (roleOrnamentData == null)
		{
			return new List<int>();
		}
		int groupId = roleOrnamentData.GetGroupId();
		if (groupId == 0)
		{
			return new List<int>();
		}
		List<int> skinAllWearingOrnaments = this.GetSkinAllWearingOrnaments(skinId, includeDefault);
		List<int> list = new List<int>();
		foreach (int num in skinAllWearingOrnaments)
		{
			RoleOrnamentData roleOrnamentData2 = this.GetRoleOrnamentData(num);
			if (roleOrnamentData2 != null && roleOrnamentData2.GetGroupId() == groupId)
			{
				list.Add(num);
			}
		}
		return list;
	}

	// Token: 0x0600EF39 RID: 61241 RVA: 0x00463B08 File Offset: 0x00461D08
	public bool IsSkinWearingOrnament(int ornamentId, int skinId, bool includeDefault = true)
	{
		return this.GetSkinAllWearingOrnaments(skinId, includeDefault).Contains(ornamentId);
	}

	// Token: 0x0600EF3A RID: 61242 RVA: 0x00463B18 File Offset: 0x00461D18
	private int SortBySortIndex(int a, int b)
	{
		Ornament value = RoleConfig.Instance.GetOrnamentConfig(a).Value;
		Ornament value2 = RoleConfig.Instance.GetOrnamentConfig(b).Value;
		return value.SortIndex - value2.SortIndex;
	}

	// Token: 0x0600EF3B RID: 61243 RVA: 0x00463B5C File Offset: 0x00461D5C
	private int SortOwnedFirst(int a, int b)
	{
		bool flag = this.IsOwnOrnament(a);
		bool flag2 = this.IsOwnOrnament(b);
		if (flag == flag2)
		{
			Ornament value = RoleConfig.Instance.GetOrnamentConfig(a).Value;
			Ornament value2 = RoleConfig.Instance.GetOrnamentConfig(b).Value;
			return value.SortIndex - value2.SortIndex;
		}
		if (!flag)
		{
			return 1;
		}
		return -1;
	}

	// Token: 0x0600EF3C RID: 61244 RVA: 0x00463BC0 File Offset: 0x00461DC0
	public List<int> GetWearPreviewOrnamentResult(int ornamentId, int skinId)
	{
		List<int> skinAllWearingOrnaments = this.GetSkinAllWearingOrnaments(skinId, true);
		if (this.IsSkinWearingOrnament(ornamentId, skinId, true))
		{
			return skinAllWearingOrnaments;
		}
		HashSet<int> hashSet = new HashSet<int>(this.GetConflictOrnamentsOnSkin(ornamentId, skinId, true));
		List<int> list = new List<int>();
		foreach (int item in skinAllWearingOrnaments)
		{
			if (!hashSet.Contains(item))
			{
				list.Add(item);
			}
		}
		list.Add(ornamentId);
		return list;
	}

	// Token: 0x0600EF3D RID: 61245 RVA: 0x00463C50 File Offset: 0x00461E50
	private ServerStorageSet GetNewlyViewedOrnamentStorageData()
	{
		return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Ornament) as ServerStorageSet;
	}

	// Token: 0x0600EF3E RID: 61246 RVA: 0x00463C63 File Offset: 0x00461E63
	public bool IsOrnamentNewlyAdded(int ornamentId)
	{
		return this.NewlyAddedOrnamentSet.Contains(ornamentId) && !this.GetNewlyViewedOrnamentStorageData().Has(ornamentId);
	}

	// Token: 0x0600EF3F RID: 61247 RVA: 0x00463C84 File Offset: 0x00461E84
	public bool CheckNewlyAddedOrnamentHasRedDotByRoleId(int roleId)
	{
		if (!RoleModel.Instance.IsRoleOwned(roleId))
		{
			return false;
		}
		HashSet<int> hashSet;
		if (!this.Role2OrnamentMap.TryGetValue(roleId, out hashSet) || hashSet.Count == 0)
		{
			return false;
		}
		foreach (int ornamentId in hashSet)
		{
			if (this.IsOrnamentNewlyAdded(ornamentId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600EF40 RID: 61248 RVA: 0x00463D04 File Offset: 0x00461F04
	public void SetOrnamentNewlyViewed(int ornamentId)
	{
		ServerStorageSet newlyViewedOrnamentStorageData = this.GetNewlyViewedOrnamentStorageData();
		HashSet<int> hashSet = new HashSet<int>(newlyViewedOrnamentStorageData.GetContainer());
		hashSet.Add(ornamentId);
		List<int> list = new List<int>();
		foreach (int item in hashSet)
		{
			if (!this.NewlyAddedOrnamentSet.Contains(item))
			{
				list.Add(item);
			}
		}
		foreach (int item2 in list)
		{
			hashSet.Remove(item2);
		}
		HashSet<int> container = newlyViewedOrnamentStorageData.GetContainer();
		container.Clear();
		foreach (int item3 in hashSet)
		{
			container.Add(item3);
		}
		newlyViewedOrnamentStorageData.MarkDirty();
		this.NotifyRoleOrnamentRedDotRefresh(ornamentId);
	}

	// Token: 0x0600EF41 RID: 61249 RVA: 0x00463E24 File Offset: 0x00462024
	private ServerStorageSet GetNewlyAcquiredOrnamentStorageData()
	{
		return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.GetOrnament) as ServerStorageSet;
	}

	// Token: 0x0600EF42 RID: 61250 RVA: 0x00463E37 File Offset: 0x00462037
	public bool IsOrnamentNewlyAcquired(int ornamentId)
	{
		return this.GetNewlyAcquiredOrnamentStorageData().Has(ornamentId);
	}

	// Token: 0x0600EF43 RID: 61251 RVA: 0x00463E48 File Offset: 0x00462048
	public void SetOrnamentNewlyAcquired(int ornamentId, bool value)
	{
		ServerStorageSet newlyAcquiredOrnamentStorageData = this.GetNewlyAcquiredOrnamentStorageData();
		if (value)
		{
			newlyAcquiredOrnamentStorageData.Add(ornamentId);
		}
		else
		{
			newlyAcquiredOrnamentStorageData.Remove(ornamentId);
		}
		EventSystem.Instance.Emit(EEventName.MainViewRoleButtonRefreshByRoleOrnament);
		this.NotifyRoleOrnamentRedDotRefresh(ornamentId);
	}

	// Token: 0x0600EF44 RID: 61252 RVA: 0x00463E88 File Offset: 0x00462088
	public bool CheckNewlyAcquiredOrnamentHasRedDotByRoleId(int roleId)
	{
		if (!RoleModel.Instance.IsRoleOwned(roleId))
		{
			return false;
		}
		HashSet<int> hashSet;
		if (!this.Role2OrnamentMap.TryGetValue(roleId, out hashSet) || hashSet.Count == 0)
		{
			return false;
		}
		foreach (int ornamentId in hashSet)
		{
			if (this.IsOrnamentNewlyAcquired(ornamentId))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600EF45 RID: 61253 RVA: 0x00463F08 File Offset: 0x00462108
	public bool CheckNewlyAcquiredOrnamentInMainView()
	{
		ServerStorageSet newlyAcquiredOrnamentStorageData = this.GetNewlyAcquiredOrnamentStorageData();
		if (newlyAcquiredOrnamentStorageData.Size() == 0)
		{
			return false;
		}
		foreach (int id in newlyAcquiredOrnamentStorageData.GetContainer())
		{
			Ornament? ornamentConfig = RoleConfig.Instance.GetOrnamentConfig(id);
			if (ornamentConfig != null)
			{
				foreach (int itemId in ornamentConfig.Value.RoleSkinIdsIter())
				{
					RoleSkin? roleSkinConfig = SkinConfig.Instance.GetRoleSkinConfig(itemId);
					if (roleSkinConfig != null && RoleModel.Instance.IsRoleOwned(roleSkinConfig.Value.RoleId))
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	// Token: 0x0600EF46 RID: 61254 RVA: 0x00464004 File Offset: 0x00462204
	private void NotifyRoleOrnamentRedDotRefresh(int ornamentId)
	{
		EventSystem.Instance.Emit<int>(EEventName.OrnamentRedDotRefresh, ornamentId);
		HashSet<int> hashSet = new HashSet<int>();
		foreach (int itemId in RoleConfig.Instance.GetOrnamentConfig(ornamentId).Value.RoleSkinIdsIter())
		{
			hashSet.Add(SkinConfig.Instance.GetRoleSkinConfig(itemId).Value.RoleId);
		}
		foreach (int p in hashSet)
		{
			EventSystem.Instance.Emit<int>(EEventName.RoleOrnamentRedDotRefresh, p);
		}
	}

	// Token: 0x170016DF RID: 5855
	// (get) Token: 0x0600EF47 RID: 61255 RVA: 0x004640E8 File Offset: 0x004622E8
	public static RoleOrnamentModel Instance
	{
		get
		{
			return RoleOrnamentModel._Instance;
		}
	}

	// Token: 0x0600EF48 RID: 61256 RVA: 0x004640EF File Offset: 0x004622EF
	public static RoleOrnamentModel GetOrCreateInstance()
	{
		if (RoleOrnamentModel._Instance == null)
		{
			RoleOrnamentModel.CreateInstance();
		}
		return RoleOrnamentModel._Instance;
	}

	// Token: 0x0600EF49 RID: 61257 RVA: 0x00464103 File Offset: 0x00462303
	public static bool CreateInstance()
	{
		if (RoleOrnamentModel._Instance != null)
		{
			return true;
		}
		RoleOrnamentModel._Instance = new RoleOrnamentModel();
		return true;
	}

	// Token: 0x0600EF4A RID: 61258 RVA: 0x00464119 File Offset: 0x00462319
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600EF4B RID: 61259 RVA: 0x0046411B File Offset: 0x0046231B
	public static void ResetStaticDefaultValue()
	{
		RoleOrnamentModel._Instance = null;
	}

	// Token: 0x0600EF4C RID: 61260 RVA: 0x00464123 File Offset: 0x00462323
	static RoleOrnamentModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleOrnamentModel.CreateStaticDefaultValue), new Action(RoleOrnamentModel.ResetStaticDefaultValue));
	}

	// Token: 0x04008729 RID: 34601
	private readonly Dictionary<int, RoleOrnamentData> RoleOrnamentMap = new Dictionary<int, RoleOrnamentData>();

	// Token: 0x0400872A RID: 34602
	private readonly Dictionary<int, List<int>> Skin2WearOrnamentMap = new Dictionary<int, List<int>>();

	// Token: 0x0400872B RID: 34603
	private readonly Dictionary<int, List<int>> Skin2OrnamentMap = new Dictionary<int, List<int>>();

	// Token: 0x0400872C RID: 34604
	private readonly HashSet<int> OwnOrnamentSet = new HashSet<int>();

	// Token: 0x0400872D RID: 34605
	private readonly Dictionary<int, int> MainRoleNormalizedSkinIdMap = new Dictionary<int, int>();

	// Token: 0x0400872E RID: 34606
	private readonly Dictionary<int, HashSet<int>> Role2OrnamentMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x0400872F RID: 34607
	private readonly Dictionary<int, HashSet<int>> Skin2DefaultOrnamentMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x04008730 RID: 34608
	private readonly HashSet<int> DefaultOrnamentSet = new HashSet<int>();

	// Token: 0x04008731 RID: 34609
	private readonly HashSet<int> NewlyAddedOrnamentSet = new HashSet<int>();

	// Token: 0x04008732 RID: 34610
	private bool IsCommonItemFinished;

	// Token: 0x04008733 RID: 34611
	[Nullable(2)]
	private int[] PendingOrnamentIdsForInit;

	// Token: 0x04008734 RID: 34612
	private readonly List<int[]> PendingOrnamentUnlockBatches = new List<int[]>();

	// Token: 0x04008735 RID: 34613
	[Nullable(2)]
	private static RoleOrnamentModel _Instance;
}
