using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02001FD5 RID: 8149
[NullableContext(1)]
[Nullable(0)]
public class PhantomManageConfigData
{
	// Token: 0x0600FF54 RID: 65364 RVA: 0x003E2C88 File Offset: 0x003E0E88
	public PhantomManageConfigData(int index)
	{
		this.Index = index;
		this.Name = TextConfig.Instance.GetMultiText("PhantomProject_EmptyProject", Array.Empty<string>());
		int filterIdConst = InventoryModel.Instance.GetFilterIdConst();
		foreach (int key in FilterConfig.Instance.GetFilterConfig(filterIdConst).Value.RuleList())
		{
			this.RuleIdMapValueList.Add(key, Array.Empty<int>());
		}
		this.Name = TextConfig.Instance.GetMultiText("PhantomProject_EmptyProject", Array.Empty<string>());
	}

	// Token: 0x0600FF55 RID: 65365 RVA: 0x003E2D40 File Offset: 0x003E0F40
	public void SetDisplayIndex(int displayIndex)
	{
		this.DisplayIndex = displayIndex;
	}

	// Token: 0x0600FF56 RID: 65366 RVA: 0x003E2D49 File Offset: 0x003E0F49
	public int GetDisplayIndex()
	{
		return this.DisplayIndex;
	}

	// Token: 0x0600FF57 RID: 65367 RVA: 0x003E2D51 File Offset: 0x003E0F51
	public int GetIndex()
	{
		return this.Index;
	}

	// Token: 0x0600FF58 RID: 65368 RVA: 0x003E2D5C File Offset: 0x003E0F5C
	public string GetIndexString()
	{
		int num = this.Index + 1;
		if (num >= 10)
		{
			return num.ToString();
		}
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendLiteral("0");
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x0600FF59 RID: 65369 RVA: 0x003E2DA3 File Offset: 0x003E0FA3
	public bool GetIsOn()
	{
		return this.IsOn;
	}

	// Token: 0x0600FF5A RID: 65370 RVA: 0x003E2DAB File Offset: 0x003E0FAB
	public void SetIsOn(bool isOn)
	{
		this.IsOn = isOn;
	}

	// Token: 0x0600FF5B RID: 65371 RVA: 0x003E2DB4 File Offset: 0x003E0FB4
	public string GetName()
	{
		return this.Name;
	}

	// Token: 0x0600FF5C RID: 65372 RVA: 0x003E2DBC File Offset: 0x003E0FBC
	public void SetName(string name)
	{
		this.Name = name;
	}

	// Token: 0x0600FF5D RID: 65373 RVA: 0x003E2DC5 File Offset: 0x003E0FC5
	public new PhantomSettingType GetType()
	{
		return this.Type;
	}

	// Token: 0x0600FF5E RID: 65374 RVA: 0x003E2DD0 File Offset: 0x003E0FD0
	public int[] GetValueListByRuleId(int ruleId)
	{
		int[] result;
		if (this.RuleIdMapValueList.TryGetValue(ruleId, out result))
		{
			return result;
		}
		return Array.Empty<int>();
	}

	// Token: 0x0600FF5F RID: 65375 RVA: 0x003E2DF4 File Offset: 0x003E0FF4
	public Dictionary<int, int[]> GetRuleIdMapValueList()
	{
		return new Dictionary<int, int[]>(this.RuleIdMapValueList);
	}

	// Token: 0x0600FF60 RID: 65376 RVA: 0x003E2E04 File Offset: 0x003E1004
	public void SetRuleIdMapValueList(Dictionary<int, int[]> map)
	{
		this.RuleIdMapValueList.Clear();
		this.RuleIdMapValueList.Clear();
		int filterIdConst = InventoryModel.Instance.GetFilterIdConst();
		foreach (int key in FilterConfig.Instance.GetFilterConfig(filterIdConst).Value.RuleList())
		{
			int[] value;
			if (map.TryGetValue(key, out value))
			{
				this.RuleIdMapValueList.Add(key, value);
			}
			else
			{
				this.RuleIdMapValueList.Add(key, Array.Empty<int>());
			}
		}
	}

	// Token: 0x0600FF61 RID: 65377 RVA: 0x003E2E95 File Offset: 0x003E1095
	public void SetType(PhantomSettingType type)
	{
		this.Type = type;
	}

	// Token: 0x0600FF62 RID: 65378 RVA: 0x003E2EA0 File Offset: 0x003E10A0
	public bool IsEmpty()
	{
		if (this.RuleIdMapValueList.Count == 0)
		{
			return true;
		}
		using (Dictionary<int, int[]>.ValueCollection.Enumerator enumerator = this.RuleIdMapValueList.Values.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				if (enumerator.Current.Length != 0)
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600FF63 RID: 65379 RVA: 0x003E2F0C File Offset: 0x003E110C
	public bool IsEqual(bool editSwitch, [Nullable(new byte[]
	{
		2,
		1
	})] Dictionary<int, int[]> editData)
	{
		if (editData == null || editSwitch != this.IsOn)
		{
			return false;
		}
		foreach (KeyValuePair<int, int[]> keyValuePair in this.RuleIdMapValueList)
		{
			int[] array;
			if (!editData.TryGetValue(keyValuePair.Key, out array))
			{
				return false;
			}
			if (array.Length != keyValuePair.Value.Length)
			{
				return false;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != keyValuePair.Value[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	// Token: 0x0600FF64 RID: 65380 RVA: 0x003E2FB8 File Offset: 0x003E11B8
	public void Parse(OnePhantomSetting setting)
	{
		this.Reset(true, true);
		this.IsOn = setting.On;
		this.Name = setting.Name;
		this.Index = setting.Index;
		foreach (OneItemFilterRule oneItemFilterRule in setting.RuleList)
		{
			if (this.RuleIdMapValueList.ContainsKey(oneItemFilterRule.FilterRuleId))
			{
				this.RuleIdMapValueList[oneItemFilterRule.FilterRuleId] = oneItemFilterRule.IdList.ToArray<int>();
			}
			else
			{
				this.RuleIdMapValueList.Add(oneItemFilterRule.FilterRuleId, oneItemFilterRule.IdList.ToArray<int>());
			}
		}
	}

	// Token: 0x0600FF65 RID: 65381 RVA: 0x003E3078 File Offset: 0x003E1278
	public OnePhantomSetting Integrate()
	{
		List<OneItemFilterRule> list = new List<OneItemFilterRule>();
		foreach (KeyValuePair<int, int[]> keyValuePair in this.RuleIdMapValueList)
		{
			OneItemFilterRule oneItemFilterRule = OneItemFilterRule.Create();
			oneItemFilterRule.FilterRuleId = keyValuePair.Key;
			oneItemFilterRule.IdList.AddRange(keyValuePair.Value);
			list.Add(oneItemFilterRule);
		}
		OnePhantomSetting onePhantomSetting = OnePhantomSetting.Create();
		onePhantomSetting.Index = this.Index;
		onePhantomSetting.On = this.IsOn;
		onePhantomSetting.Name = this.Name;
		onePhantomSetting.RuleList.AddRange(list);
		return onePhantomSetting;
	}

	// Token: 0x0600FF66 RID: 65382 RVA: 0x003E312C File Offset: 0x003E132C
	public void Reset(bool indexReset = false, bool nameReset = false)
	{
		this.Index = (indexReset ? -1 : this.Index);
		this.IsOn = false;
		this.Name = (nameReset ? TextConfig.Instance.GetMultiText("PhantomProject_EmptyProject", Array.Empty<string>()) : this.Name);
		this.RuleIdMapValueList.Clear();
		int filterIdConst = InventoryModel.Instance.GetFilterIdConst();
		foreach (int key in FilterConfig.Instance.GetFilterConfig(filterIdConst).Value.RuleList())
		{
			this.RuleIdMapValueList.Add(key, Array.Empty<int>());
		}
	}

	// Token: 0x0600FF67 RID: 65383 RVA: 0x003E31D4 File Offset: 0x003E13D4
	public PhantomManageConfigData Clone()
	{
		return new PhantomManageConfigData(this.Index)
		{
			IsOn = this.IsOn,
			Name = this.Name,
			Type = this.Type,
			RuleIdMapValueList = new Dictionary<int, int[]>(this.RuleIdMapValueList)
		};
	}

	// Token: 0x0400762F RID: 30255
	private PhantomSettingType Type;

	// Token: 0x04007630 RID: 30256
	private int Index = -1;

	// Token: 0x04007631 RID: 30257
	private bool IsOn;

	// Token: 0x04007632 RID: 30258
	private string Name;

	// Token: 0x04007633 RID: 30259
	private Dictionary<int, int[]> RuleIdMapValueList = new Dictionary<int, int[]>();

	// Token: 0x04007634 RID: 30260
	private int DisplayIndex = -1;
}
