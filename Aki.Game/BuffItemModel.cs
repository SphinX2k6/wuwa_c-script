using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;

// Token: 0x02000BD0 RID: 3024
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BuffItemModel : ModelBase
{
	// Token: 0x06007E43 RID: 32323 RVA: 0x0026ECA0 File Offset: 0x0026CEA0
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x06007E44 RID: 32324 RVA: 0x0026ECA3 File Offset: 0x0026CEA3
	protected override bool OnClear()
	{
		this.ClearAllUseBuffItemRoleData();
		this.ClearAllBuffItemData();
		return true;
	}

	// Token: 0x06007E45 RID: 32325 RVA: 0x0026ECB2 File Offset: 0x0026CEB2
	protected override bool OnLeaveLevel()
	{
		this.ClearAllUseBuffItemRoleData();
		return true;
	}

	// Token: 0x06007E46 RID: 32326 RVA: 0x0026ECBC File Offset: 0x0026CEBC
	public void NewBuffItemData(int itemConfigId, long endCdTimeStamp, int totalCdTime)
	{
		BuffItemData value = new BuffItemData(itemConfigId, (double)endCdTimeStamp, (double)totalCdTime);
		this.BuffItemMap[itemConfigId] = value;
	}

	// Token: 0x06007E47 RID: 32327 RVA: 0x0026ECE1 File Offset: 0x0026CEE1
	[NullableContext(2)]
	public BuffItemData GetBuffItemData(int itemConfigId)
	{
		if (!this.BuffItemMap.ContainsKey(itemConfigId))
		{
			return null;
		}
		return this.BuffItemMap[itemConfigId];
	}

	// Token: 0x06007E48 RID: 32328 RVA: 0x0026ECFF File Offset: 0x0026CEFF
	public IReadOnlyDictionary<int, BuffItemData> GetBuffItemMap()
	{
		return this.BuffItemMap;
	}

	// Token: 0x06007E49 RID: 32329 RVA: 0x0026ED08 File Offset: 0x0026CF08
	public void GetInCdBuffItemMap(Dictionary<int, BuffItemData> buffItemDataMap)
	{
		foreach (BuffItemData buffItemData in this.BuffItemMap.Values)
		{
			if (buffItemData.GetBuffItemRemainCdTime() > 0.0)
			{
				int itemConfigId = buffItemData.ItemConfigId;
				buffItemDataMap[itemConfigId] = buffItemData;
			}
		}
	}

	// Token: 0x06007E4A RID: 32330 RVA: 0x0026ED7C File Offset: 0x0026CF7C
	public void ClearAllBuffItemData()
	{
		this.UseBuffItemRoleMap.Clear();
		this.BuffItemMap.Clear();
	}

	// Token: 0x06007E4B RID: 32331 RVA: 0x0026ED94 File Offset: 0x0026CF94
	public void NewUseBuffItemRoleData(string roleName, int position, int roleConfigId, int roleLevel, int currentAttribute, int maxAttribute, int useItemConfigId, Entity entity)
	{
		UseBuffItemRoleData value = new UseBuffItemRoleData(roleName, position, roleConfigId, roleLevel, (float)currentAttribute, (float)maxAttribute, useItemConfigId, entity);
		this.UseBuffItemRoleMap[position] = value;
	}

	// Token: 0x06007E4C RID: 32332 RVA: 0x0026EDC3 File Offset: 0x0026CFC3
	public void SetCurrentUseBuffItemId(int itemConfigId)
	{
		this.CurrentUseBuffItemId = itemConfigId;
	}

	// Token: 0x06007E4D RID: 32333 RVA: 0x0026EDCC File Offset: 0x0026CFCC
	public int GetCurrentUseBuffItemId()
	{
		return this.CurrentUseBuffItemId;
	}

	// Token: 0x06007E4E RID: 32334 RVA: 0x0026EDD4 File Offset: 0x0026CFD4
	public IReadOnlyDictionary<int, UseBuffItemRoleData> GetAllUseBuffItemRole()
	{
		return this.UseBuffItemRoleMap;
	}

	// Token: 0x06007E4F RID: 32335 RVA: 0x0026EDDC File Offset: 0x0026CFDC
	[NullableContext(2)]
	public UseBuffItemRoleData GetUseBuffItemRole(int position)
	{
		if (!this.UseBuffItemRoleMap.ContainsKey(position))
		{
			return null;
		}
		return this.UseBuffItemRoleMap[position];
	}

	// Token: 0x06007E50 RID: 32336 RVA: 0x0026EDFC File Offset: 0x0026CFFC
	[NullableContext(2)]
	public UseBuffItemRoleData GetUseItemRoleByRoleConfigId(int roleConfigId)
	{
		foreach (UseBuffItemRoleData useBuffItemRoleData in this.UseBuffItemRoleMap.Values)
		{
			if (useBuffItemRoleData.RoleConfigId == roleConfigId)
			{
				return useBuffItemRoleData;
			}
		}
		return null;
	}

	// Token: 0x06007E51 RID: 32337 RVA: 0x0026EE60 File Offset: 0x0026D060
	public void ClearAllUseBuffItemRoleData()
	{
		this.UseBuffItemRoleMap.Clear();
	}

	// Token: 0x06007E52 RID: 32338 RVA: 0x0026EE70 File Offset: 0x0026D070
	public double GetBuffItemRemainCdTime(int itemConfigId)
	{
		BuffItemData buffItemData = this.GetBuffItemData(itemConfigId);
		if (buffItemData == null)
		{
			return 0.0;
		}
		return buffItemData.GetBuffItemRemainCdTime();
	}

	// Token: 0x06007E53 RID: 32339 RVA: 0x0026EE98 File Offset: 0x0026D098
	public double GetBuffItemTotalCdTime(int itemConfigId)
	{
		BuffItemData buffItemData = this.GetBuffItemData(itemConfigId);
		if (buffItemData == null)
		{
			return 0.0;
		}
		return buffItemData.GetBuffItemTotalCdTime();
	}

	// Token: 0x06007E54 RID: 32340 RVA: 0x0026EEC0 File Offset: 0x0026D0C0
	public void SetBuffItemCdTimeStamp(int itemConfigId, long endCdTimeStamp, int totalCdTime)
	{
		BuffItemData buffItemData = this.GetBuffItemData(itemConfigId);
		if (buffItemData != null)
		{
			buffItemData.SetEndCdTimeStamp((double)endCdTimeStamp);
			buffItemData.SetTotalCdTime((double)totalCdTime);
			return;
		}
		this.NewBuffItemData(itemConfigId, endCdTimeStamp, totalCdTime);
	}

	// Token: 0x06007E55 RID: 32341 RVA: 0x0026EEF4 File Offset: 0x0026D0F4
	public void SetBuffItemCdEndCallback(int itemConfigId, Action callback)
	{
		if (this.GetBuffItemData(itemConfigId) == null)
		{
			return;
		}
		this.BuffCdRefreshItemId = itemConfigId;
		this.BuffCdRefreshEndCallback = callback;
		this.BuffCdRefreshTimerId = TimerSystem.Instance.Forever(new TTimerAction(this.OnBuffCdRefresh), (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
	}

	// Token: 0x06007E56 RID: 32342 RVA: 0x0026EF48 File Offset: 0x0026D148
	private void OnBuffCdRefresh(float delta)
	{
		if (this.GetBuffItemRemainCdTime(this.BuffCdRefreshItemId) <= 0.0)
		{
			Action buffCdRefreshEndCallback = this.BuffCdRefreshEndCallback;
			if (buffCdRefreshEndCallback != null)
			{
				buffCdRefreshEndCallback();
			}
			this.ResetBuffCdTimer();
		}
	}

	// Token: 0x06007E57 RID: 32343 RVA: 0x0026EF78 File Offset: 0x0026D178
	private void ResetBuffCdTimer()
	{
		if (this.BuffCdRefreshTimerId != null && TimerSystem.Instance.Has(this.BuffCdRefreshTimerId))
		{
			TimerSystem.Instance.Remove(this.BuffCdRefreshTimerId);
		}
		this.BuffCdRefreshItemId = 0;
		this.BuffCdRefreshEndCallback = null;
		this.BuffCdRefreshTimerId = null;
	}

	// Token: 0x06007E58 RID: 32344 RVA: 0x0026EFC8 File Offset: 0x0026D1C8
	public void SetBuffEquipItem(int itemConfigId, bool isEquipped)
	{
		this.BuffEquipItemMap[itemConfigId] = isEquipped;
		int buffEquipItemCategory = BuffItemConfig.Instance.GetBuffEquipItemCategory(itemConfigId);
		if (buffEquipItemCategory != 0)
		{
			if (isEquipped)
			{
				this.BuffEquipCategoryMap.TryAdd((EBuffItemEquipCategory)buffEquipItemCategory, itemConfigId);
				return;
			}
			this.BuffEquipCategoryMap.Remove((EBuffItemEquipCategory)buffEquipItemCategory);
		}
	}

	// Token: 0x06007E59 RID: 32345 RVA: 0x0026F010 File Offset: 0x0026D210
	public bool IsEquippedBuffCategory(EBuffItemEquipCategory equipCategory)
	{
		return this.BuffEquipCategoryMap.ContainsKey(equipCategory);
	}

	// Token: 0x06007E5A RID: 32346 RVA: 0x0026F020 File Offset: 0x0026D220
	public int? GetEquippedBuffItemId(EBuffItemEquipCategory equipCategory)
	{
		int value;
		if (this.BuffEquipCategoryMap.TryGetValue(equipCategory, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x06007E5B RID: 32347 RVA: 0x0026F04D File Offset: 0x0026D24D
	public bool IsEquippedBuffItem(int itemConfigId)
	{
		return this.BuffEquipItemMap.ContainsKey(itemConfigId) && this.BuffEquipItemMap[itemConfigId];
	}

	// Token: 0x06007E5C RID: 32348 RVA: 0x0026F06C File Offset: 0x0026D26C
	public List<long> GetEquippedBuffsByRoleId(int roleId, bool checkEnableInUi = false)
	{
		List<long> list = new List<long>();
		foreach (BuffEquipItem buffEquipItem in BuffItemConfig.Instance.GetBuffEquipItemByRoleId(roleId))
		{
			if (this.IsEquippedBuffItem(buffEquipItem.ItemId) && (!checkEnableInUi || buffEquipItem.EnableInUI))
			{
				for (int i = 0; i < buffEquipItem.BuffsLength; i++)
				{
					List<long> list2 = list;
					long num = buffEquipItem.Buffs(i);
					list2.AddRange(new ReadOnlySpan<long>(ref num));
				}
			}
		}
		return list;
	}

	// Token: 0x06007E5D RID: 32349 RVA: 0x0026F108 File Offset: 0x0026D308
	public BuffEquipItem[] GetEquippedBuffItemConfigByRoleId(int roleId)
	{
		List<BuffEquipItem> list = new List<BuffEquipItem>();
		foreach (BuffEquipItem item in BuffItemConfig.Instance.GetBuffEquipItemByRoleId(roleId))
		{
			if (this.IsEquippedBuffItem(item.ItemId))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	// Token: 0x06007E5E RID: 32350 RVA: 0x0026F178 File Offset: 0x0026D378
	public unsafe void SetCurrentPreviewItemData(int itemId, int roleId)
	{
		this.PreviewBuffIdList = new List<long>();
		IReadOnlyList<BuffEquipItem> buffEquipItemByItemId = BuffItemConfig.Instance.GetBuffEquipItemByItemId(itemId);
		if (buffEquipItemByItemId == null || buffEquipItemByItemId.Count == 0)
		{
			return;
		}
		foreach (BuffEquipItem buffEquipItem in buffEquipItemByItemId)
		{
			if (buffEquipItem.RoleId == roleId)
			{
				string message = "填充Buff";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RoleId", buffEquipItem.RoleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Buffs", buffEquipItem.GetBuffsArray());
				TotalTopUpUtil.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.PreviewBuffIdList = new List<long>();
				for (int i = 0; i < buffEquipItem.BuffsLength; i++)
				{
					this.PreviewBuffIdList.Add(buffEquipItem.Buffs(i));
				}
				break;
			}
		}
	}

	// Token: 0x06007E5F RID: 32351 RVA: 0x0026F284 File Offset: 0x0026D484
	public List<long> GetCurrentPreviewItemBuffList()
	{
		return this.PreviewBuffIdList;
	}

	// Token: 0x17000E29 RID: 3625
	// (get) Token: 0x06007E60 RID: 32352 RVA: 0x0026F28C File Offset: 0x0026D48C
	public static BuffItemModel Instance
	{
		get
		{
			return BuffItemModel._Instance;
		}
	}

	// Token: 0x06007E61 RID: 32353 RVA: 0x0026F293 File Offset: 0x0026D493
	public static BuffItemModel GetOrCreateInstance()
	{
		if (BuffItemModel._Instance == null)
		{
			BuffItemModel.CreateInstance();
		}
		return BuffItemModel._Instance;
	}

	// Token: 0x06007E62 RID: 32354 RVA: 0x0026F2A7 File Offset: 0x0026D4A7
	public static bool CreateInstance()
	{
		if (BuffItemModel._Instance != null)
		{
			return true;
		}
		BuffItemModel._Instance = new BuffItemModel();
		return true;
	}

	// Token: 0x06007E63 RID: 32355 RVA: 0x0026F2BD File Offset: 0x0026D4BD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007E64 RID: 32356 RVA: 0x0026F2BF File Offset: 0x0026D4BF
	public static void ResetStaticDefaultValue()
	{
		BuffItemModel._Instance = null;
	}

	// Token: 0x06007E65 RID: 32357 RVA: 0x0026F2C7 File Offset: 0x0026D4C7
	static BuffItemModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuffItemModel.CreateStaticDefaultValue), new Action(BuffItemModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004E04 RID: 19972
	private readonly Dictionary<int, UseBuffItemRoleData> UseBuffItemRoleMap = new Dictionary<int, UseBuffItemRoleData>();

	// Token: 0x04004E05 RID: 19973
	private readonly Dictionary<int, BuffItemData> BuffItemMap = new Dictionary<int, BuffItemData>();

	// Token: 0x04004E06 RID: 19974
	private readonly Dictionary<int, bool> BuffEquipItemMap = new Dictionary<int, bool>();

	// Token: 0x04004E07 RID: 19975
	private readonly Dictionary<EBuffItemEquipCategory, int> BuffEquipCategoryMap = new Dictionary<EBuffItemEquipCategory, int>();

	// Token: 0x04004E08 RID: 19976
	private int CurrentUseBuffItemId;

	// Token: 0x04004E09 RID: 19977
	[Nullable(2)]
	private TimerHandle BuffCdRefreshTimerId;

	// Token: 0x04004E0A RID: 19978
	[Nullable(2)]
	private Action BuffCdRefreshEndCallback;

	// Token: 0x04004E0B RID: 19979
	private int BuffCdRefreshItemId;

	// Token: 0x04004E0C RID: 19980
	private List<long> PreviewBuffIdList = new List<long>();

	// Token: 0x04004E0D RID: 19981
	[Nullable(2)]
	private static BuffItemModel _Instance;
}
