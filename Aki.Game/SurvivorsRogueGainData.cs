using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;

// Token: 0x02002073 RID: 8307
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueGainData
{
	// Token: 0x17001EE5 RID: 7909
	// (get) Token: 0x06014840 RID: 84032 RVA: 0x005FA5B0 File Offset: 0x005F87B0
	public int WeaponUiMaxShowCount
	{
		get
		{
			return ConfigCommonParamById.GetIntConfig("SurvivorsRogueWeaponUiMaxCount").GetValueOrDefault();
		}
	}

	// Token: 0x06014841 RID: 84033 RVA: 0x005FA5CF File Offset: 0x005F87CF
	public static SurvivorsRogueGainData Create()
	{
		return new SurvivorsRogueGainData();
	}

	// Token: 0x06014842 RID: 84034 RVA: 0x005FA5D8 File Offset: 0x005F87D8
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

	// Token: 0x06014843 RID: 84035 RVA: 0x005FA63E File Offset: 0x005F883E
	public void Clear()
	{
		this.RoleGainMap.Clear();
		this.WeaponGainMap.Clear();
		this.ItemGainMap.Clear();
		this.GainMap.Clear();
		this.WeaponMaxCount = 0;
		this.WeaponUnlockWaves.Clear();
	}

	// Token: 0x06014844 RID: 84036 RVA: 0x005FA680 File Offset: 0x005F8880
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

	// Token: 0x06014845 RID: 84037 RVA: 0x005FA98C File Offset: 0x005F8B8C
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

	// Token: 0x06014846 RID: 84038 RVA: 0x005FAAAC File Offset: 0x005F8CAC
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

	// Token: 0x06014847 RID: 84039 RVA: 0x005FAB2C File Offset: 0x005F8D2C
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

	// Token: 0x06014848 RID: 84040 RVA: 0x005FAB84 File Offset: 0x005F8D84
	public List<SurvivorsItemGainData> GetItemGainList()
	{
		List<SurvivorsItemGainData> list = new List<SurvivorsItemGainData>();
		foreach (SurvivorsItemGainData item in this.ItemGainMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x06014849 RID: 84041 RVA: 0x005FABE4 File Offset: 0x005F8DE4
	public List<SurvivorsWeaponGainData> GetWeaponGainList()
	{
		List<SurvivorsWeaponGainData> list = new List<SurvivorsWeaponGainData>();
		foreach (SurvivorsWeaponGainData item in this.WeaponGainMap.Values)
		{
			list.Add(item);
		}
		return list;
	}

	// Token: 0x0601484A RID: 84042 RVA: 0x005FAC44 File Offset: 0x005F8E44
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

	// Token: 0x0601484B RID: 84043 RVA: 0x005FACA8 File Offset: 0x005F8EA8
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

	// Token: 0x0601484C RID: 84044 RVA: 0x005FAD74 File Offset: 0x005F8F74
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

	// Token: 0x0601484D RID: 84045 RVA: 0x005FADA4 File Offset: 0x005F8FA4
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

	// Token: 0x0601484E RID: 84046 RVA: 0x005FAECC File Offset: 0x005F90CC
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

	// Token: 0x0601484F RID: 84047 RVA: 0x005FAFF4 File Offset: 0x005F91F4
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

	// Token: 0x0400ADDD RID: 44509
	private const int PERMYRIAD_RATIO = 10000;

	// Token: 0x0400ADDE RID: 44510
	private readonly Dictionary<int, global::SurvivorsGainData> GainMap = new Dictionary<int, global::SurvivorsGainData>();

	// Token: 0x0400ADDF RID: 44511
	private readonly Dictionary<int, SurvivorsRoleGainData> RoleGainMap = new Dictionary<int, SurvivorsRoleGainData>();

	// Token: 0x0400ADE0 RID: 44512
	public readonly Dictionary<int, SurvivorsWeaponGainData> WeaponGainMap = new Dictionary<int, SurvivorsWeaponGainData>();

	// Token: 0x0400ADE1 RID: 44513
	private readonly Dictionary<int, SurvivorsItemGainData> ItemGainMap = new Dictionary<int, SurvivorsItemGainData>();

	// Token: 0x0400ADE2 RID: 44514
	public int WeaponMaxCount;

	// Token: 0x0400ADE3 RID: 44515
	public List<int> WeaponUnlockWaves = new List<int>();
}
