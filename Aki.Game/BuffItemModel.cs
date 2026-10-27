using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp;

// Token: 0x02001718 RID: 5912
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class BuffItemModel : ModelBase
{
	// Token: 0x0600AA60 RID: 43616 RVA: 0x00264750 File Offset: 0x00262950
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600AA61 RID: 43617 RVA: 0x00264753 File Offset: 0x00262953
	protected override bool OnClear()
	{
		this.ClearAllUseBuffItemRoleData();
		this.ClearAllBuffItemData();
		return true;
	}

	// Token: 0x0600AA62 RID: 43618 RVA: 0x00264762 File Offset: 0x00262962
	protected override bool OnLeaveLevel()
	{
		this.ClearAllUseBuffItemRoleData();
		return true;
	}

	// Token: 0x0600AA63 RID: 43619 RVA: 0x0026476C File Offset: 0x0026296C
	public void NewBuffItemData(int itemConfigId, long endCdTimeStamp, int totalCdTime)
	{
		BuffItemData value = new BuffItemData(itemConfigId, (double)endCdTimeStamp, (double)totalCdTime);
		this.BuffItemMap[itemConfigId] = value;
	}

	// Token: 0x0600AA64 RID: 43620 RVA: 0x00264791 File Offset: 0x00262991
	[NullableContext(2)]
	public BuffItemData GetBuffItemData(int itemConfigId)
	{
		if (!this.BuffItemMap.ContainsKey(itemConfigId))
		{
			return null;
		}
		return this.BuffItemMap[itemConfigId];
	}

	// Token: 0x0600AA65 RID: 43621 RVA: 0x002647AF File Offset: 0x002629AF
	public IReadOnlyDictionary<int, BuffItemData> GetBuffItemMap()
	{
		return this.BuffItemMap;
	}

	// Token: 0x0600AA66 RID: 43622 RVA: 0x002647B8 File Offset: 0x002629B8
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

	// Token: 0x0600AA67 RID: 43623 RVA: 0x0026482C File Offset: 0x00262A2C
	public void ClearAllBuffItemData()
	{
		this.UseBuffItemRoleMap.Clear();
		this.BuffItemMap.Clear();
	}

	// Token: 0x0600AA68 RID: 43624 RVA: 0x00264844 File Offset: 0x00262A44
	public void NewUseBuffItemRoleData(string roleName, int position, int roleConfigId, int roleLevel, int currentAttribute, int maxAttribute, int useItemConfigId, Entity entity)
	{
		UseBuffItemRoleData value = new UseBuffItemRoleData(roleName, position, roleConfigId, roleLevel, (float)currentAttribute, (float)maxAttribute, useItemConfigId, entity);
		this.UseBuffItemRoleMap[position] = value;
	}

	// Token: 0x0600AA69 RID: 43625 RVA: 0x00264873 File Offset: 0x00262A73
	public void SetCurrentUseBuffItemId(int itemConfigId)
	{
		this.CurrentUseBuffItemId = itemConfigId;
	}

	// Token: 0x0600AA6A RID: 43626 RVA: 0x0026487C File Offset: 0x00262A7C
	public int GetCurrentUseBuffItemId()
	{
		return this.CurrentUseBuffItemId;
	}

	// Token: 0x0600AA6B RID: 43627 RVA: 0x00264884 File Offset: 0x00262A84
	public IReadOnlyDictionary<int, UseBuffItemRoleData> GetAllUseBuffItemRole()
	{
		return this.UseBuffItemRoleMap;
	}

	// Token: 0x0600AA6C RID: 43628 RVA: 0x0026488C File Offset: 0x00262A8C
	[NullableContext(2)]
	public UseBuffItemRoleData GetUseBuffItemRole(int position)
	{
		if (!this.UseBuffItemRoleMap.ContainsKey(position))
		{
			return null;
		}
		return this.UseBuffItemRoleMap[position];
	}

	// Token: 0x0600AA6D RID: 43629 RVA: 0x002648AC File Offset: 0x00262AAC
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

	// Token: 0x0600AA6E RID: 43630 RVA: 0x00264910 File Offset: 0x00262B10
	public void ClearAllUseBuffItemRoleData()
	{
		this.UseBuffItemRoleMap.Clear();
	}

	// Token: 0x0600AA6F RID: 43631 RVA: 0x00264920 File Offset: 0x00262B20
	public double GetBuffItemRemainCdTime(int itemConfigId)
	{
		BuffItemData buffItemData = this.GetBuffItemData(itemConfigId);
		if (buffItemData == null)
		{
			return 0.0;
		}
		return buffItemData.GetBuffItemRemainCdTime();
	}

	// Token: 0x0600AA70 RID: 43632 RVA: 0x00264948 File Offset: 0x00262B48
	public double GetBuffItemTotalCdTime(int itemConfigId)
	{
		BuffItemData buffItemData = this.GetBuffItemData(itemConfigId);
		if (buffItemData == null)
		{
			return 0.0;
		}
		return buffItemData.GetBuffItemTotalCdTime();
	}

	// Token: 0x0600AA71 RID: 43633 RVA: 0x00264970 File Offset: 0x00262B70
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

	// Token: 0x0600AA72 RID: 43634 RVA: 0x002649A4 File Offset: 0x00262BA4
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

	// Token: 0x0600AA73 RID: 43635 RVA: 0x002649F8 File Offset: 0x00262BF8
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

	// Token: 0x0600AA74 RID: 43636 RVA: 0x00264A28 File Offset: 0x00262C28
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

	// Token: 0x0600AA75 RID: 43637 RVA: 0x00264A78 File Offset: 0x00262C78
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

	// Token: 0x0600AA76 RID: 43638 RVA: 0x00264AC0 File Offset: 0x00262CC0
	public bool IsEquippedBuffCategory(EBuffItemEquipCategory equipCategory)
	{
		return this.BuffEquipCategoryMap.ContainsKey(equipCategory);
	}

	// Token: 0x0600AA77 RID: 43639 RVA: 0x00264AD0 File Offset: 0x00262CD0
	public int? GetEquippedBuffItemId(EBuffItemEquipCategory equipCategory)
	{
		int value;
		if (this.BuffEquipCategoryMap.TryGetValue(equipCategory, out value))
		{
			return new int?(value);
		}
		return null;
	}

	// Token: 0x0600AA78 RID: 43640 RVA: 0x00264AFD File Offset: 0x00262CFD
	public bool IsEquippedBuffItem(int itemConfigId)
	{
		return this.BuffEquipItemMap.ContainsKey(itemConfigId) && this.BuffEquipItemMap[itemConfigId];
	}

	// Token: 0x0600AA79 RID: 43641 RVA: 0x00264B1C File Offset: 0x00262D1C
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

	// Token: 0x0600AA7A RID: 43642 RVA: 0x00264BB8 File Offset: 0x00262DB8
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

	// Token: 0x0600AA7B RID: 43643 RVA: 0x00264C28 File Offset: 0x00262E28
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

	// Token: 0x0600AA7C RID: 43644 RVA: 0x00264D34 File Offset: 0x00262F34
	public List<long> GetCurrentPreviewItemBuffList()
	{
		return this.PreviewBuffIdList;
	}

	// Token: 0x17000E08 RID: 3592
	// (get) Token: 0x0600AA7D RID: 43645 RVA: 0x00264D3C File Offset: 0x00262F3C
	public static BuffItemModel Instance
	{
		get
		{
			return BuffItemModel._Instance;
		}
	}

	// Token: 0x0600AA7E RID: 43646 RVA: 0x00264D43 File Offset: 0x00262F43
	public static BuffItemModel GetOrCreateInstance()
	{
		if (BuffItemModel._Instance == null)
		{
			BuffItemModel.CreateInstance();
		}
		return BuffItemModel._Instance;
	}

	// Token: 0x0600AA7F RID: 43647 RVA: 0x00264D57 File Offset: 0x00262F57
	public static bool CreateInstance()
	{
		if (BuffItemModel._Instance != null)
		{
			return true;
		}
		BuffItemModel._Instance = new BuffItemModel();
		return true;
	}

	// Token: 0x0600AA80 RID: 43648 RVA: 0x00264D6D File Offset: 0x00262F6D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AA81 RID: 43649 RVA: 0x00264D6F File Offset: 0x00262F6F
	public static void ResetStaticDefaultValue()
	{
		BuffItemModel._Instance = null;
	}

	// Token: 0x0600AA82 RID: 43650 RVA: 0x00264D77 File Offset: 0x00262F77
	static BuffItemModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BuffItemModel.CreateStaticDefaultValue), new Action(BuffItemModel.ResetStaticDefaultValue));
	}

	// Token: 0x04004D5C RID: 19804
	private readonly Dictionary<int, UseBuffItemRoleData> UseBuffItemRoleMap = new Dictionary<int, UseBuffItemRoleData>();

	// Token: 0x04004D5D RID: 19805
	private readonly Dictionary<int, BuffItemData> BuffItemMap = new Dictionary<int, BuffItemData>();

	// Token: 0x04004D5E RID: 19806
	private readonly Dictionary<int, bool> BuffEquipItemMap = new Dictionary<int, bool>();

	// Token: 0x04004D5F RID: 19807
	private readonly Dictionary<EBuffItemEquipCategory, int> BuffEquipCategoryMap = new Dictionary<EBuffItemEquipCategory, int>();

	// Token: 0x04004D60 RID: 19808
	private int CurrentUseBuffItemId;

	// Token: 0x04004D61 RID: 19809
	[Nullable(2)]
	private TimerHandle BuffCdRefreshTimerId;

	// Token: 0x04004D62 RID: 19810
	[Nullable(2)]
	private Action BuffCdRefreshEndCallback;

	// Token: 0x04004D63 RID: 19811
	private int BuffCdRefreshItemId;

	// Token: 0x04004D64 RID: 19812
	private List<long> PreviewBuffIdList = new List<long>();

	// Token: 0x04004D65 RID: 19813
	[Nullable(2)]
	private static BuffItemModel _Instance;
}
