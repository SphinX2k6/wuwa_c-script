using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x020022FA RID: 8954
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class RoleOrnamentModel : ModelBase
{
	// Token: 0x06011A8B RID: 72331 RVA: 0x00456694 File Offset: 0x00454894
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

	// Token: 0x06011A8C RID: 72332 RVA: 0x00456814 File Offset: 0x00454A14
	protected override bool OnClear()
	{
		this.IsCommonItemFinished = false;
		this.PendingOrnamentIdsForInit = null;
		this.PendingOrnamentUnlockBatches.Clear();
		return true;
	}

	// Token: 0x06011A8D RID: 72333 RVA: 0x00456830 File Offset: 0x00454A30
	public bool GetIsCommonItemFinished()
	{
		return this.IsCommonItemFinished;
	}

	// Token: 0x06011A8E RID: 72334 RVA: 0x00456838 File Offset: 0x00454A38
	public void SetCommonItemFinished()
	{
		this.IsCommonItemFinished = true;
	}

	// Token: 0x06011A8F RID: 72335 RVA: 0x00456841 File Offset: 0x00454A41
	public void SetPendingOrnamentIdsForInit(int[] ornamentIds)
	{
		this.PendingOrnamentIdsForInit = ornamentIds;
	}

	// Token: 0x06011A90 RID: 72336 RVA: 0x0045684A File Offset: 0x00454A4A
	[NullableContext(2)]
	public int[] TakePendingOrnamentIdsForInit()
	{
		int[] pendingOrnamentIdsForInit = this.PendingOrnamentIdsForInit;
		this.PendingOrnamentIdsForInit = null;
		return pendingOrnamentIdsForInit;
	}

	// Token: 0x06011A91 RID: 72337 RVA: 0x00456859 File Offset: 0x00454A59
	public void AddPendingOrnamentUnlockBatch(int[] ornamentIds)
	{
		this.PendingOrnamentUnlockBatches.Add(ornamentIds);
	}

	// Token: 0x06011A92 RID: 72338 RVA: 0x00456867 File Offset: 0x00454A67
	public List<int[]> TakeAllPendingOrnamentUnlockBatches()
	{
		List<int[]> result = new List<int[]>(this.PendingOrnamentUnlockBatches);
		this.PendingOrnamentUnlockBatches.Clear();
		return result;
	}

	// Token: 0x06011A93 RID: 72339 RVA: 0x00456880 File Offset: 0x00454A80
	public void UpdateOwnOrnament(int[] ornamentIds)
	{
		foreach (int item in ornamentIds)
		{
			this.OwnOrnamentSet.Add(item);
		}
	}

	// Token: 0x06011A94 RID: 72340 RVA: 0x004568B0 File Offset: 0x00454AB0
	public void UpdateWearOrnament(IEnumerable<OrnamentDressInfo> dressInfo)
	{
		foreach (OrnamentDressInfo ornamentDressInfo in dressInfo)
		{
			int roleSkinId = ornamentDressInfo.RoleSkinId;
			List<int> value = new List<int>(ornamentDressInfo.DressOrnamentIds);
			this.Skin2WearOrnamentMap[roleSkinId] = value;
		}
	}

	// Token: 0x06011A95 RID: 72341 RVA: 0x00456910 File Offset: 0x00454B10
	public void UpdateNewlyAddedOrnament(int[] ornamentIds)
	{
		foreach (int item in ornamentIds)
		{
			this.NewlyAddedOrnamentSet.Add(item);
		}
	}

	// Token: 0x06011A96 RID: 72342 RVA: 0x00456940 File Offset: 0x00454B40
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

	// Token: 0x06011A97 RID: 72343 RVA: 0x00456A00 File Offset: 0x00454C00
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

	// Token: 0x06011A98 RID: 72344 RVA: 0x00456A78 File Offset: 0x00454C78
	public List<int> GetSkinAllOrnaments(int id, bool? ownedFirst = null)
	{
		List<int> list;
		if (!this.Skin2OrnamentMap.TryGetValue(id, out list))
		{
			list = new List<int>();
		}
		List<int> list2 = new List<int>();
		foreach (int item in list)
		{
			if (!this.DefaultOrnamentSet.Contains(item))
			{
				list2.Add(item);
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

	// Token: 0x06011A99 RID: 72345 RVA: 0x00456B20 File Offset: 0x00454D20
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

	// Token: 0x06011A9A RID: 72346 RVA: 0x00456B58 File Offset: 0x00454D58
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

	// Token: 0x06011A9B RID: 72347 RVA: 0x00456C94 File Offset: 0x00454E94
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

	// Token: 0x06011A9C RID: 72348 RVA: 0x00456CCE File Offset: 0x00454ECE
	public int GetOrnamentCountById(int ornamentId)
	{
		return (this.IsOwnOrnament(ornamentId) > false) ? 1 : 0;
	}

	// Token: 0x06011A9D RID: 72349 RVA: 0x00456CDA File Offset: 0x00454EDA
	public bool IsOwnOrnament(int ornamentId)
	{
		return this.OwnOrnamentSet.Contains(ornamentId) || this.DefaultOrnamentSet.Contains(ornamentId);
	}

	// Token: 0x06011A9E RID: 72350 RVA: 0x00456CF8 File Offset: 0x00454EF8
	public bool IsDefaultOrnament(int ornamentId)
	{
		return this.DefaultOrnamentSet.Contains(ornamentId);
	}

	// Token: 0x06011A9F RID: 72351 RVA: 0x00456D08 File Offset: 0x00454F08
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

	// Token: 0x06011AA0 RID: 72352 RVA: 0x00456D90 File Offset: 0x00454F90
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

	// Token: 0x06011AA1 RID: 72353 RVA: 0x00456E28 File Offset: 0x00455028
	public bool IsSkinWearingOrnament(int ornamentId, int skinId, bool includeDefault = true)
	{
		return this.GetSkinAllWearingOrnaments(skinId, includeDefault).Contains(ornamentId);
	}

	// Token: 0x06011AA2 RID: 72354 RVA: 0x00456E38 File Offset: 0x00455038
	private int SortBySortIndex(int a, int b)
	{
		Ornament value = RoleConfig.Instance.GetOrnamentConfig(a).Value;
		Ornament value2 = RoleConfig.Instance.GetOrnamentConfig(b).Value;
		return value.SortIndex - value2.SortIndex;
	}

	// Token: 0x06011AA3 RID: 72355 RVA: 0x00456E7C File Offset: 0x0045507C
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

	// Token: 0x06011AA4 RID: 72356 RVA: 0x00456EE0 File Offset: 0x004550E0
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

	// Token: 0x06011AA5 RID: 72357 RVA: 0x00456F70 File Offset: 0x00455170
	private ServerStorageSet GetNewlyViewedOrnamentStorageData()
	{
		return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Ornament) as ServerStorageSet;
	}

	// Token: 0x06011AA6 RID: 72358 RVA: 0x00456F83 File Offset: 0x00455183
	public bool IsOrnamentNewlyAdded(int ornamentId)
	{
		return this.NewlyAddedOrnamentSet.Contains(ornamentId) && !this.GetNewlyViewedOrnamentStorageData().Has(ornamentId);
	}

	// Token: 0x06011AA7 RID: 72359 RVA: 0x00456FA4 File Offset: 0x004551A4
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

	// Token: 0x06011AA8 RID: 72360 RVA: 0x00457024 File Offset: 0x00455224
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

	// Token: 0x06011AA9 RID: 72361 RVA: 0x00457144 File Offset: 0x00455344
	private ServerStorageSet GetNewlyAcquiredOrnamentStorageData()
	{
		return ServerStorageModel.Instance.Get(EClientStorageSystemIdType.GetOrnament) as ServerStorageSet;
	}

	// Token: 0x06011AAA RID: 72362 RVA: 0x00457157 File Offset: 0x00455357
	public bool IsOrnamentNewlyAcquired(int ornamentId)
	{
		return this.GetNewlyAcquiredOrnamentStorageData().Has(ornamentId);
	}

	// Token: 0x06011AAB RID: 72363 RVA: 0x00457168 File Offset: 0x00455368
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

	// Token: 0x06011AAC RID: 72364 RVA: 0x004571A8 File Offset: 0x004553A8
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

	// Token: 0x06011AAD RID: 72365 RVA: 0x00457228 File Offset: 0x00455428
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

	// Token: 0x06011AAE RID: 72366 RVA: 0x00457324 File Offset: 0x00455524
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

	// Token: 0x170016A8 RID: 5800
	// (get) Token: 0x06011AAF RID: 72367 RVA: 0x00457408 File Offset: 0x00455608
	public static RoleOrnamentModel Instance
	{
		get
		{
			return RoleOrnamentModel._Instance;
		}
	}

	// Token: 0x06011AB0 RID: 72368 RVA: 0x0045740F File Offset: 0x0045560F
	public static RoleOrnamentModel GetOrCreateInstance()
	{
		if (RoleOrnamentModel._Instance == null)
		{
			RoleOrnamentModel.CreateInstance();
		}
		return RoleOrnamentModel._Instance;
	}

	// Token: 0x06011AB1 RID: 72369 RVA: 0x00457423 File Offset: 0x00455623
	public static bool CreateInstance()
	{
		if (RoleOrnamentModel._Instance != null)
		{
			return true;
		}
		RoleOrnamentModel._Instance = new RoleOrnamentModel();
		return true;
	}

	// Token: 0x06011AB2 RID: 72370 RVA: 0x00457439 File Offset: 0x00455639
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011AB3 RID: 72371 RVA: 0x0045743B File Offset: 0x0045563B
	public static void ResetStaticDefaultValue()
	{
		RoleOrnamentModel._Instance = null;
	}

	// Token: 0x06011AB4 RID: 72372 RVA: 0x00457443 File Offset: 0x00455643
	static RoleOrnamentModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RoleOrnamentModel.CreateStaticDefaultValue), new Action(RoleOrnamentModel.ResetStaticDefaultValue));
	}

	// Token: 0x040085EB RID: 34283
	private readonly Dictionary<int, RoleOrnamentData> RoleOrnamentMap = new Dictionary<int, RoleOrnamentData>();

	// Token: 0x040085EC RID: 34284
	private readonly Dictionary<int, List<int>> Skin2WearOrnamentMap = new Dictionary<int, List<int>>();

	// Token: 0x040085ED RID: 34285
	private readonly Dictionary<int, List<int>> Skin2OrnamentMap = new Dictionary<int, List<int>>();

	// Token: 0x040085EE RID: 34286
	private readonly HashSet<int> OwnOrnamentSet = new HashSet<int>();

	// Token: 0x040085EF RID: 34287
	private readonly Dictionary<int, int> MainRoleNormalizedSkinIdMap = new Dictionary<int, int>();

	// Token: 0x040085F0 RID: 34288
	private readonly Dictionary<int, HashSet<int>> Role2OrnamentMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x040085F1 RID: 34289
	private readonly Dictionary<int, HashSet<int>> Skin2DefaultOrnamentMap = new Dictionary<int, HashSet<int>>();

	// Token: 0x040085F2 RID: 34290
	private readonly HashSet<int> DefaultOrnamentSet = new HashSet<int>();

	// Token: 0x040085F3 RID: 34291
	private readonly HashSet<int> NewlyAddedOrnamentSet = new HashSet<int>();

	// Token: 0x040085F4 RID: 34292
	private bool IsCommonItemFinished;

	// Token: 0x040085F5 RID: 34293
	[Nullable(2)]
	private int[] PendingOrnamentIdsForInit;

	// Token: 0x040085F6 RID: 34294
	private readonly List<int[]> PendingOrnamentUnlockBatches = new List<int[]>();

	// Token: 0x040085F7 RID: 34295
	[Nullable(2)]
	private static RoleOrnamentModel _Instance;
}
