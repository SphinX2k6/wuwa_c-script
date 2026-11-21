using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020014AE RID: 5294
[NullableContext(1)]
[Nullable(0)]
public class PhantomManageConfigViewModel : ViewModelBase<EPhantomManageConfigViewData>
{
	// Token: 0x0600D3FA RID: 54266 RVA: 0x003F0598 File Offset: 0x003EE798
	public PhantomManageConfigViewModel()
	{
		this.DataMap.Add(EPhantomManageConfigViewData.SelectType, PhantomSettingType.AutoLock);
		this.DataMap.Add(EPhantomManageConfigViewData.SelectIndex, null);
		this.DataMap.Add(EPhantomManageConfigViewData.SelectConfig, null);
		this.DataMap.Add(EPhantomManageConfigViewData.EditState, false);
		this.DataMap.Add(EPhantomManageConfigViewData.EditData, null);
		this.DataMap.Add(EPhantomManageConfigViewData.EditSwitch, false);
	}

	// Token: 0x0600D3FB RID: 54267 RVA: 0x003F0608 File Offset: 0x003EE808
	public void SetSelectType(PhantomSettingType type, bool notNotify = false)
	{
		base.SetData(EPhantomManageConfigViewData.SelectType, type, new bool?(notNotify));
	}

	// Token: 0x0600D3FC RID: 54268 RVA: 0x003F061D File Offset: 0x003EE81D
	public PhantomSettingType GetSelectType()
	{
		return (PhantomSettingType)base.GetData(EPhantomManageConfigViewData.SelectType);
	}

	// Token: 0x0600D3FD RID: 54269 RVA: 0x003F062C File Offset: 0x003EE82C
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

	// Token: 0x0600D3FE RID: 54270 RVA: 0x003F0678 File Offset: 0x003EE878
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

	// Token: 0x0600D3FF RID: 54271 RVA: 0x003F06A5 File Offset: 0x003EE8A5
	public void SetSelectConfig(PhantomManageConfigData config, bool notNotify = false)
	{
		base.SetData(EPhantomManageConfigViewData.SelectConfig, config, new bool?(notNotify));
	}

	// Token: 0x0600D400 RID: 54272 RVA: 0x003F06B5 File Offset: 0x003EE8B5
	public PhantomManageConfigData GetSelectConfig()
	{
		return base.GetData(EPhantomManageConfigViewData.SelectConfig) as PhantomManageConfigData;
	}

	// Token: 0x0600D401 RID: 54273 RVA: 0x003F06C3 File Offset: 0x003EE8C3
	public bool GetEditState()
	{
		return (bool)base.GetData(EPhantomManageConfigViewData.EditState);
	}

	// Token: 0x0600D402 RID: 54274 RVA: 0x003F06D1 File Offset: 0x003EE8D1
	public void SetEditState(bool state, bool notNotify = false)
	{
		base.SetData(EPhantomManageConfigViewData.EditState, state, new bool?(notNotify));
	}

	// Token: 0x0600D403 RID: 54275 RVA: 0x003F06E6 File Offset: 0x003EE8E6
	public void InitEditDataSwitch(PhantomManageConfigData data, bool notNotify = false)
	{
		base.SetData(EPhantomManageConfigViewData.EditSwitch, data.GetIsOn(), new bool?(notNotify));
		base.SetData(EPhantomManageConfigViewData.EditData, data.GetRuleIdMapValueList(), new bool?(notNotify));
	}

	// Token: 0x0600D404 RID: 54276 RVA: 0x003F0713 File Offset: 0x003EE913
	public void SetEditSwitch(bool isOn, bool notNotify = false)
	{
		base.SetData(EPhantomManageConfigViewData.EditSwitch, isOn, new bool?(notNotify));
	}

	// Token: 0x0600D405 RID: 54277 RVA: 0x003F0728 File Offset: 0x003EE928
	public bool GetEditSwitch()
	{
		return (bool)base.GetData(EPhantomManageConfigViewData.EditSwitch);
	}

	// Token: 0x0600D406 RID: 54278 RVA: 0x003F0736 File Offset: 0x003EE936
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, int[]> GetEditData()
	{
		return base.GetData(EPhantomManageConfigViewData.EditData) as Dictionary<int, int[]>;
	}

	// Token: 0x0600D407 RID: 54279 RVA: 0x003F0744 File Offset: 0x003EE944
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

	// Token: 0x0600D408 RID: 54280 RVA: 0x003F07CC File Offset: 0x003EE9CC
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

	// Token: 0x0600D409 RID: 54281 RVA: 0x003F0878 File Offset: 0x003EEA78
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

	// Token: 0x0600D40A RID: 54282 RVA: 0x003F08F0 File Offset: 0x003EEAF0
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

	// Token: 0x0600D40B RID: 54283 RVA: 0x003F0928 File Offset: 0x003EEB28
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
