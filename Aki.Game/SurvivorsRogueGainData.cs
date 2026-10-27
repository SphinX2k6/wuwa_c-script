using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002AF7 RID: 10999
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueGainData
{
	// Token: 0x17001E8D RID: 7821
	// (get) Token: 0x06016E0F RID: 93711 RVA: 0x005CDA30 File Offset: 0x005CBC30
	public int WeaponUiMaxShowCount
	{
		get
		{
			return ConfigCommonParamById.GetIntConfig("SurvivorsRogueWeaponUiMaxCount").GetValueOrDefault();
		}
	}

	// Token: 0x06016E10 RID: 93712 RVA: 0x005CDA4F File Offset: 0x005CBC4F
	public static SurvivorsRogueGainData Create()
	{
		return new SurvivorsRogueGainData();
	}

	// Token: 0x06016E11 RID: 93713 RVA: 0x005CDA58 File Offset: 0x005CBC58
	public void InitGain(IList<Aki.Protocol.SurvivorsGainData> dataList, int weaponMaxCount, IList<int> weaponUnlockWaves)
	{
		this.Clear();
		for (int i = 0; i < dataList.Count; i++)
		{
			this.AddGain(dataList[i]);
		}
		this.WeaponMaxCount = weaponMaxCount;
		this.WeaponUnlockWaves.Clear();
		for (int j = 0; j < weaponUnlockWaves.Count; j++)
		{
			this.WeaponUnlockWaves.Add(weaponUnlockWaves[j]);
		}
	}

	// Token: 0x06016E12 RID: 93714 RVA: 0x005CDABE File Offset: 0x005CBCBE
	public void Clear()
	{
		this.RoleGainMap.Clear();
		this.WeaponGainMap.Clear();
		this.ItemGainMap.Clear();
		this.GainMap.Clear();
		this.WeaponMaxCount = 0;
		this.WeaponUnlockWaves.Clear();
	}

	// Token: 0x06016E13 RID: 93715 RVA: 0x005CDB00 File Offset: 0x005CBD00
	public unsafe void AddGain(Aki.Protocol.SurvivorsGainData data)
	{
		switch (data.DataCase)
		{
		case Aki.Protocol.SurvivorsGainData.DataOneofCase.SurvivorsRole:
		{
			SurvivorsRoleGainData survivorsRoleGainData = new SurvivorsRoleGainData(data.IncId, data.ConfigId, data.SurvivorsRole, ESurvivorsRogueItemType.Character);
			this.RoleGainMap[data.IncId] = survivorsRoleGainData;
			this.GainMap[data.IncId] = survivorsRoleGainData;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SurvivorsRogue] 新增角色增益";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Type", (int)survivorsRoleGainData.Type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", survivorsRoleGainData.ConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IncId", survivorsRoleGainData.IncId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			EventSystem.Instance.Emit<int>(EEventName.SurvivorsRogueRoleGainUpdate, data.ConfigId);
			return;
		}
		case Aki.Protocol.SurvivorsGainData.DataOneofCase.SurvivorsWeapon:
		{
			SurvivorsWeaponGainData survivorsWeaponGainData = new SurvivorsWeaponGainData(data.IncId, data.ConfigId, data.SurvivorsWeapon, ESurvivorsRogueItemType.Weapon);
			this.WeaponGainMap[data.IncId] = survivorsWeaponGainData;
			this.GainMap[data.IncId] = survivorsWeaponGainData;
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SurvivorsRogue;
			ELogAuthor author2 = ELogAuthor.YYZ;
			string message2 = "[SurvivorsRogue] 新增武器增益";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Type", (int)survivorsWeaponGainData.Type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Id", survivorsWeaponGainData.ConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("IncId", survivorsWeaponGainData.IncId);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			EventSystem.Instance.Emit<int, bool>(EEventName.SurvivorsRogueWeaponGainUpdate, data.ConfigId, true);
			return;
		}
		case Aki.Protocol.SurvivorsGainData.DataOneofCase.SurvivorsToken:
		{
			SurvivorsItemGainData survivorsItemGainData = new SurvivorsItemGainData(data.IncId, data.ConfigId, data.SurvivorsToken, ESurvivorsRogueItemType.Normal);
			this.ItemGainMap[data.IncId] = survivorsItemGainData;
			this.GainMap[data.IncId] = survivorsItemGainData;
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.SurvivorsRogue;
			ELogAuthor author3 = ELogAuthor.YYZ;
			string message3 = "[SurvivorsRogue] 新增道具增益";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("Type", (int)survivorsItemGainData.Type);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("Id", survivorsItemGainData.ConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("IncId", survivorsItemGainData.IncId);
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 3));
			return;
		}
		default:
		{
			Log instance4 = Log.Instance;
			ELogModule module4 = ELogModule.SurvivorsRogue;
			ELogAuthor author4 = ELogAuthor.YYZ;
			string message4 = "[SurvivorsRogue] 增益信息类型未实现";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", data.DataCase.ToString());
			instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		}
	}

	// Token: 0x06016E14 RID: 93716 RVA: 0x005CDE0C File Offset: 0x005CC00C
	public void UpdateGain(Aki.Protocol.SurvivorsGainData data)
	{
		global::SurvivorsGainData survivorsGainData;
		if (!this.GainMap.TryGetValue(data.IncId, out survivorsGainData))
		{
			return;
		}
		switch (data.DataCase)
		{
		case Aki.Protocol.SurvivorsGainData.DataOneofCase.SurvivorsRole:
			this.RoleGainMap[data.IncId].Data = data.SurvivorsRole;
			EventSystem.Instance.Emit<int>(EEventName.SurvivorsRogueRoleGainUpdate, data.ConfigId);
			return;
		case Aki.Protocol.SurvivorsGainData.DataOneofCase.SurvivorsWeapon:
		{
			SurvivorsWeaponGainData survivorsWeaponGainData = this.WeaponGainMap[data.IncId];
			bool p = survivorsWeaponGainData.Data.Level < data.SurvivorsWeapon.Level;
			survivorsWeaponGainData.Data = data.SurvivorsWeapon;
			EventSystem.Instance.Emit<int, bool>(EEventName.SurvivorsRogueWeaponGainUpdate, data.ConfigId, p);
			return;
		}
		case Aki.Protocol.SurvivorsGainData.DataOneofCase.SurvivorsToken:
			this.ItemGainMap[data.IncId].Data = data.SurvivorsToken;
			return;
		default:
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SurvivorsRogue;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[SurvivorsRogue] 增益信息更新类型未实现";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Type", data.DataCase.ToString());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		}
	}

	// Token: 0x06016E15 RID: 93717 RVA: 0x005CDF2C File Offset: 0x005CC12C
	public void RemoveGain(int incId)
	{
		if (!this.GainMap.ContainsKey(incId))
		{
			return;
		}
		this.RoleGainMap.Remove(incId);
		this.WeaponGainMap.Remove(incId);
		this.ItemGainMap.Remove(incId);
		this.GainMap.Remove(incId);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.SurvivorsRogue;
		ELogAuthor author = ELogAuthor.YYZ;
		string message = "[SurvivorsRogue] 删除增益";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("IncId", incId);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06016E16 RID: 93718 RVA: 0x005CDFAC File Offset: 0x005CC1AC
	[NullableContext(2)]
	public SurvivorsRoleGainData GetRoleGainData()
	{
		using (Dictionary<int, SurvivorsRoleGainData>.ValueCollection.Enumerator enumerator = this.RoleGainMap.Values.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current;
			}
		}
		return null;
	}

	// Token: 0x06016E17 RID: 93719 RVA: 0x005CE004 File Offset: 0x005CC204
	public List<SurvivorsItemGainData> GetItemGainList()
	{
		List<SurvivorsItemGainData> list = new List<SurvivorsItemGainData>();
		foreach (SurvivorsItemGainData item in this.ItemGainMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06016E18 RID: 93720 RVA: 0x005CE064 File Offset: 0x005CC264
	public List<SurvivorsWeaponGainData> GetWeaponGainList()
	{
		List<SurvivorsWeaponGainData> list = new List<SurvivorsWeaponGainData>();
		foreach (SurvivorsWeaponGainData item in this.WeaponGainMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06016E19 RID: 93721 RVA: 0x005CE0C4 File Offset: 0x005CC2C4
	[NullableContext(2)]
	public SurvivorsWeaponGainData GetWeaponDataByWeaponId(int weaponId)
	{
		foreach (SurvivorsWeaponGainData survivorsWeaponGainData in this.WeaponGainMap.Values)
		{
			if (survivorsWeaponGainData.ConfigId == weaponId)
			{
				return survivorsWeaponGainData;
			}
		}
		return null;
	}

	// Token: 0x06016E1A RID: 93722 RVA: 0x005CE128 File Offset: 0x005CC328
	public int GetWeaponBondOwnedWeaponId(int previewWeaponId)
	{
		Aki.Config.SurvivorsWeapon? survivorsWeapon = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(previewWeaponId);
		if (survivorsWeapon == null)
		{
			return 0;
		}
		foreach (SurvivorsWeaponGainData survivorsWeaponGainData in this.WeaponGainMap.Values)
		{
			if (survivorsWeaponGainData.Data.WeaponBondId == 0)
			{
				if (SurvivorsRogueGainData.ContainsBindWeaponId(survivorsWeapon.Value, survivorsWeaponGainData.ConfigId))
				{
					return survivorsWeaponGainData.ConfigId;
				}
				Aki.Config.SurvivorsWeapon? survivorsWeapon2 = SurvivorsRogueConfig.Instance.GetSurvivorsWeapon(survivorsWeaponGainData.ConfigId);
				if (survivorsWeapon2 != null && SurvivorsRogueGainData.ContainsBindWeaponId(survivorsWeapon2.Value, previewWeaponId))
				{
					return survivorsWeaponGainData.ConfigId;
				}
			}
		}
		return 0;
	}

	// Token: 0x06016E1B RID: 93723 RVA: 0x005CE1F4 File Offset: 0x005CC3F4
	private static bool ContainsBindWeaponId(Aki.Config.SurvivorsWeapon config, int weaponId)
	{
		for (int i = 0; i < config.BindWeaponsIdLength; i++)
		{
			if (config.BindWeaponsId(i) == weaponId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06016E1C RID: 93724 RVA: 0x005CE224 File Offset: 0x005CC424
	public List<ISurvivorsWeaponWithBondInfo> GetWeaponGainListWithBondInfo([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<SurvivorsWeaponGainData> weaponList = null)
	{
		if (weaponList == null)
		{
			weaponList = this.GetWeaponGainList();
		}
		Dictionary<int, SurvivorsWeaponGainData> dictionary = new Dictionary<int, SurvivorsWeaponGainData>();
		for (int i = 0; i < weaponList.Count; i++)
		{
			dictionary[weaponList[i].ConfigId] = weaponList[i];
		}
		List<ISurvivorsWeaponWithBondInfo> list = new List<ISurvivorsWeaponWithBondInfo>();
		HashSet<int> hashSet = new HashSet<int>();
		for (int j = 0; j < weaponList.Count; j++)
		{
			SurvivorsWeaponGainData survivorsWeaponGainData = weaponList[j];
			if (!hashSet.Contains(survivorsWeaponGainData.IncId))
			{
				int weaponBondId = survivorsWeaponGainData.Data.WeaponBondId;
				SurvivorsWeaponGainData survivorsWeaponGainData3;
				SurvivorsWeaponGainData survivorsWeaponGainData2 = (weaponBondId > 0 && dictionary.TryGetValue(weaponBondId, out survivorsWeaponGainData3)) ? survivorsWeaponGainData3 : null;
				bool flag = survivorsWeaponGainData2 != null && !hashSet.Contains(survivorsWeaponGainData2.IncId);
				list.Add(new SurvivorsWeaponWithBondInfo
				{
					WeaponData = survivorsWeaponGainData,
					BondPosition = ((flag > false) ? 1 : 0)
				});
				hashSet.Add(survivorsWeaponGainData.IncId);
				if (flag && survivorsWeaponGainData2 != null)
				{
					list.Add(new SurvivorsWeaponWithBondInfo
					{
						WeaponData = survivorsWeaponGainData2,
						BondPosition = -1
					});
					hashSet.Add(survivorsWeaponGainData2.IncId);
				}
			}
		}
		return list;
	}

	// Token: 0x06016E1D RID: 93725 RVA: 0x005CE34C File Offset: 0x005CC54C
	public List<ISurvivorsWeaponGridData> GetWeaponGridDataList([Nullable(new byte[]
	{
		2,
		1
	})] IReadOnlyList<ISurvivorsWeaponWithBondInfo> weaponGridList = null, int? weaponMaxCount = null)
	{
		if (weaponGridList == null)
		{
			weaponGridList = this.GetWeaponGainListWithBondInfo(null);
		}
		if (weaponMaxCount == null)
		{
			weaponMaxCount = new int?(this.WeaponMaxCount);
		}
		List<ISurvivorsWeaponGridData> list = new List<ISurvivorsWeaponGridData>();
		int num = (this.WeaponUiMaxShowCount > weaponMaxCount.Value) ? this.WeaponUiMaxShowCount : weaponMaxCount.Value;
		for (int i = 0; i < num; i++)
		{
			if (weaponGridList.Count <= i)
			{
				if (weaponMaxCount.Value <= i)
				{
					list.Add(new SurvivorsWeaponGridData
					{
						IsLock = false,
						IsDisable = true
					});
				}
				else
				{
					int? unlockBatch = (i < this.WeaponUnlockWaves.Count) ? new int?(this.WeaponUnlockWaves[i]) : null;
					list.Add(new SurvivorsWeaponGridData
					{
						IsLock = true,
						IsDisable = false,
						UnlockBatch = unlockBatch
					});
				}
			}
			else
			{
				ISurvivorsWeaponWithBondInfo survivorsWeaponWithBondInfo = weaponGridList[i];
				list.Add(new SurvivorsWeaponGridData
				{
					WeaponData = survivorsWeaponWithBondInfo.WeaponData,
					IsLock = false,
					IsDisable = false,
					BondPosition = new int?(survivorsWeaponWithBondInfo.BondPosition)
				});
			}
		}
		return list;
	}

	// Token: 0x06016E1E RID: 93726 RVA: 0x005CE474 File Offset: 0x005CC674
	public float GetRoleSpecialPropertyValue(int propertyId)
	{
		SurvivorsRoleGainData roleGainData = this.GetRoleGainData();
		if (roleGainData == null)
		{
			return 0f;
		}
		float num = 0f;
		for (int i = 0; i < roleGainData.Data.Affixs.Count; i++)
		{
			int lvId = roleGainData.Data.Affixs[i];
			Aki.Config.SurvivorsRoleLv? survivorsRoleLv = SurvivorsRogueConfig.Instance.GetSurvivorsRoleLv(lvId);
			if (survivorsRoleLv != null && survivorsRoleLv.Value.PropertyId == propertyId && survivorsRoleLv.Value.BuffCategoryType == 1)
			{
				num += (float)survivorsRoleLv.Value.PropertyValue / 10000f;
			}
		}
		return num;
	}

	// Token: 0x0400A9D7 RID: 43479
	private const int PERMYRIAD_RATIO = 10000;

	// Token: 0x0400A9D8 RID: 43480
	private readonly Dictionary<int, global::SurvivorsGainData> GainMap = new Dictionary<int, global::SurvivorsGainData>();

	// Token: 0x0400A9D9 RID: 43481
	private readonly Dictionary<int, SurvivorsRoleGainData> RoleGainMap = new Dictionary<int, SurvivorsRoleGainData>();

	// Token: 0x0400A9DA RID: 43482
	public readonly Dictionary<int, SurvivorsWeaponGainData> WeaponGainMap = new Dictionary<int, SurvivorsWeaponGainData>();

	// Token: 0x0400A9DB RID: 43483
	private readonly Dictionary<int, SurvivorsItemGainData> ItemGainMap = new Dictionary<int, SurvivorsItemGainData>();

	// Token: 0x0400A9DC RID: 43484
	public int WeaponMaxCount;

	// Token: 0x0400A9DD RID: 43485
	public List<int> WeaponUnlockWaves = new List<int>();
}
