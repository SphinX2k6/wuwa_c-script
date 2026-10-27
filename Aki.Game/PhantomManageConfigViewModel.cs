using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001FDB RID: 8155
[NullableContext(1)]
[Nullable(0)]
public class PhantomManageConfigViewModel : ViewModelBase<EPhantomManageConfigViewData>
{
	// Token: 0x0600FF92 RID: 65426 RVA: 0x003E3F98 File Offset: 0x003E2198
	public PhantomManageConfigViewModel()
	{
		this.DataMap.Add(EPhantomManageConfigViewData.SelectType, PhantomSettingType.AutoLock);
		this.DataMap.Add(EPhantomManageConfigViewData.SelectIndex, null);
		this.DataMap.Add(EPhantomManageConfigViewData.SelectConfig, null);
		this.DataMap.Add(EPhantomManageConfigViewData.EditState, false);
		this.DataMap.Add(EPhantomManageConfigViewData.EditData, null);
		this.DataMap.Add(EPhantomManageConfigViewData.EditSwitch, false);
	}

	// Token: 0x0600FF93 RID: 65427 RVA: 0x003E4008 File Offset: 0x003E2208
	public void SetSelectType(PhantomSettingType type, bool notNotify = false)
	{
		base.SetData(EPhantomManageConfigViewData.SelectType, type, new bool?(notNotify));
	}

	// Token: 0x0600FF94 RID: 65428 RVA: 0x003E401D File Offset: 0x003E221D
	public PhantomSettingType GetSelectType()
	{
		return (PhantomSettingType)base.GetData(EPhantomManageConfigViewData.SelectType);
	}

	// Token: 0x0600FF95 RID: 65429 RVA: 0x003E402C File Offset: 0x003E222C
	public void SetSelectIndex(PhantomSettingType type, int index, bool notNotify = false)
	{
		Dictionary<PhantomSettingType, int> dictionary = base.GetData(EPhantomManageConfigViewData.SelectIndex) as Dictionary<PhantomSettingType, int>;
		if (dictionary == null)
		{
			dictionary = new Dictionary<PhantomSettingType, int>();
		}
		if (dictionary.ContainsKey(type))
		{
			dictionary[type] = index;
		}
		else
		{
			dictionary.Add(type, index);
		}
		base.SetData(EPhantomManageConfigViewData.SelectIndex, dictionary, new bool?(notNotify));
	}

	// Token: 0x0600FF96 RID: 65430 RVA: 0x003E4078 File Offset: 0x003E2278
	public int GetSelectIndex(PhantomSettingType type)
	{
		Dictionary<PhantomSettingType, int> dictionary = base.GetData(EPhantomManageConfigViewData.SelectIndex) as Dictionary<PhantomSettingType, int>;
		if (dictionary == null)
		{
			return 0;
		}
		int result;
		if (dictionary.TryGetValue(type, out result))
		{
			return result;
		}
		return 0;
	}

	// Token: 0x0600FF97 RID: 65431 RVA: 0x003E40A5 File Offset: 0x003E22A5
	public void SetSelectConfig(PhantomManageConfigData config, bool notNotify = false)
	{
		base.SetData(EPhantomManageConfigViewData.SelectConfig, config, new bool?(notNotify));
	}

	// Token: 0x0600FF98 RID: 65432 RVA: 0x003E40B5 File Offset: 0x003E22B5
	public PhantomManageConfigData GetSelectConfig()
	{
		return base.GetData(EPhantomManageConfigViewData.SelectConfig) as PhantomManageConfigData;
	}

	// Token: 0x0600FF99 RID: 65433 RVA: 0x003E40C3 File Offset: 0x003E22C3
	public bool GetEditState()
	{
		return (bool)base.GetData(EPhantomManageConfigViewData.EditState);
	}

	// Token: 0x0600FF9A RID: 65434 RVA: 0x003E40D1 File Offset: 0x003E22D1
	public void SetEditState(bool state, bool notNotify = false)
	{
		base.SetData(EPhantomManageConfigViewData.EditState, state, new bool?(notNotify));
	}

	// Token: 0x0600FF9B RID: 65435 RVA: 0x003E40E6 File Offset: 0x003E22E6
	public void InitEditDataSwitch(PhantomManageConfigData data, bool notNotify = false)
	{
		base.SetData(EPhantomManageConfigViewData.EditSwitch, data.GetIsOn(), new bool?(notNotify));
		base.SetData(EPhantomManageConfigViewData.EditData, data.GetRuleIdMapValueList(), new bool?(notNotify));
	}

	// Token: 0x0600FF9C RID: 65436 RVA: 0x003E4113 File Offset: 0x003E2313
	public void SetEditSwitch(bool isOn, bool notNotify = false)
	{
		base.SetData(EPhantomManageConfigViewData.EditSwitch, isOn, new bool?(notNotify));
	}

	// Token: 0x0600FF9D RID: 65437 RVA: 0x003E4128 File Offset: 0x003E2328
	public bool GetEditSwitch()
	{
		return (bool)base.GetData(EPhantomManageConfigViewData.EditSwitch);
	}

	// Token: 0x0600FF9E RID: 65438 RVA: 0x003E4136 File Offset: 0x003E2336
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, int[]> GetEditData()
	{
		return base.GetData(EPhantomManageConfigViewData.EditData) as Dictionary<int, int[]>;
	}

	// Token: 0x0600FF9F RID: 65439 RVA: 0x003E4144 File Offset: 0x003E2344
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, int[]> GetEditDataByRuleId(int ruleId)
	{
		Dictionary<int, int[]> dictionary = base.GetData(EPhantomManageConfigViewData.EditData) as Dictionary<int, int[]>;
		if (dictionary == null)
		{
			return null;
		}
		Dictionary<int, int[]> dictionary2 = new Dictionary<int, int[]>();
		foreach (KeyValuePair<int, int[]> keyValuePair in dictionary)
		{
			if (ruleId == keyValuePair.Key)
			{
				dictionary2.Add(keyValuePair.Key, keyValuePair.Value);
				return dictionary2;
			}
		}
		return null;
	}

	// Token: 0x0600FFA0 RID: 65440 RVA: 0x003E41CC File Offset: 0x003E23CC
	public void SetEditDataById(int ruleId, int value, bool isAdd, bool notNotify = false)
	{
		int[] array;
		int[] array2;
		if (this.GetEditDataByRuleId(ruleId).TryGetValue(ruleId, out array))
		{
			array2 = array;
		}
		else
		{
			array2 = Array.Empty<int>();
		}
		if (!isAdd)
		{
			array2 = this.RemoveNumber(array2, value);
		}
		else
		{
			array2 = this.AddNumber(array2, value);
		}
		Dictionary<int, int[]> dictionary = base.GetData(EPhantomManageConfigViewData.EditData) as Dictionary<int, int[]>;
		foreach (KeyValuePair<int, int[]> keyValuePair in dictionary)
		{
			if (ruleId == keyValuePair.Key)
			{
				dictionary[keyValuePair.Key] = array2;
			}
		}
		if (!notNotify)
		{
			base.Notify(EPhantomManageConfigViewData.EditData);
		}
	}

	// Token: 0x0600FFA1 RID: 65441 RVA: 0x003E4278 File Offset: 0x003E2478
	public void SetEditDataByIdList(int ruleId, int[] valueList, bool notNotify = false)
	{
		Dictionary<int, int[]> dictionary = base.GetData(EPhantomManageConfigViewData.EditData) as Dictionary<int, int[]>;
		foreach (KeyValuePair<int, int[]> keyValuePair in dictionary)
		{
			if (ruleId == keyValuePair.Key)
			{
				dictionary[keyValuePair.Key] = valueList;
			}
		}
		if (!notNotify)
		{
			base.Notify(EPhantomManageConfigViewData.EditData);
		}
	}

	// Token: 0x0600FFA2 RID: 65442 RVA: 0x003E42F0 File Offset: 0x003E24F0
	private int[] RemoveNumber(int[] arr, int value)
	{
		List<int> list = new List<int>();
		foreach (int num in arr)
		{
			if (num != value)
			{
				list.Add(num);
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600FFA3 RID: 65443 RVA: 0x003E4328 File Offset: 0x003E2528
	private int[] AddNumber(int[] arr, int value)
	{
		if (!new HashSet<int>(arr).Contains(value))
		{
			return new List<int>(arr)
			{
				value
			}.ToArray();
		}
		return arr;
	}
}
