using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020014A8 RID: 5288
[NullableContext(1)]
[Nullable(0)]
public class PhantomManageConfigData
{
	// Token: 0x0600D3BC RID: 54204 RVA: 0x003EF260 File Offset: 0x003ED460
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

	// Token: 0x0600D3BD RID: 54205 RVA: 0x003EF318 File Offset: 0x003ED518
	public void SetDisplayIndex(int displayIndex)
	{
		this.DisplayIndex = displayIndex;
	}

	// Token: 0x0600D3BE RID: 54206 RVA: 0x003EF321 File Offset: 0x003ED521
	public int GetDisplayIndex()
	{
		return this.DisplayIndex;
	}

	// Token: 0x0600D3BF RID: 54207 RVA: 0x003EF329 File Offset: 0x003ED529
	public int GetIndex()
	{
		return this.Index;
	}

	// Token: 0x0600D3C0 RID: 54208 RVA: 0x003EF334 File Offset: 0x003ED534
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

	// Token: 0x0600D3C1 RID: 54209 RVA: 0x003EF37B File Offset: 0x003ED57B
	public bool GetIsOn()
	{
		return this.IsOn;
	}

	// Token: 0x0600D3C2 RID: 54210 RVA: 0x003EF383 File Offset: 0x003ED583
	public void SetIsOn(bool isOn)
	{
		this.IsOn = isOn;
	}

	// Token: 0x0600D3C3 RID: 54211 RVA: 0x003EF38C File Offset: 0x003ED58C
	public string GetName()
	{
		return this.Name;
	}

	// Token: 0x0600D3C4 RID: 54212 RVA: 0x003EF394 File Offset: 0x003ED594
	public void SetName(string name)
	{
		this.Name = name;
	}

	// Token: 0x0600D3C5 RID: 54213 RVA: 0x003EF39D File Offset: 0x003ED59D
	public new PhantomSettingType GetType()
	{
		return this.Type;
	}

	// Token: 0x0600D3C6 RID: 54214 RVA: 0x003EF3A8 File Offset: 0x003ED5A8
	public int[] GetValueListByRuleId(int ruleId)
	{
		int[] result;
		if (this.RuleIdMapValueList.TryGetValue(ruleId, out result))
		{
			return result;
		}
		return Array.Empty<int>();
	}

	// Token: 0x0600D3C7 RID: 54215 RVA: 0x003EF3CC File Offset: 0x003ED5CC
	public Dictionary<int, int[]> GetRuleIdMapValueList()
	{
		return new Dictionary<int, int[]>(this.RuleIdMapValueList);
	}

	// Token: 0x0600D3C8 RID: 54216 RVA: 0x003EF3DC File Offset: 0x003ED5DC
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

	// Token: 0x0600D3C9 RID: 54217 RVA: 0x003EF46D File Offset: 0x003ED66D
	public void SetType(PhantomSettingType type)
	{
		this.Type = type;
	}

	// Token: 0x0600D3CA RID: 54218 RVA: 0x003EF478 File Offset: 0x003ED678
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

	// Token: 0x0600D3CB RID: 54219 RVA: 0x003EF4E4 File Offset: 0x003ED6E4
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

	// Token: 0x0600D3CC RID: 54220 RVA: 0x003EF590 File Offset: 0x003ED790
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
				int[] array = new int[oneItemFilterRule.IdList.Count];
				oneItemFilterRule.IdList.CopyTo(array, 0);
				this.RuleIdMapValueList[oneItemFilterRule.FilterRuleId] = array;
			}
			else
			{
				int[] array2 = new int[oneItemFilterRule.IdList.Count];
				oneItemFilterRule.IdList.CopyTo(array2, 0);
				this.RuleIdMapValueList.Add(oneItemFilterRule.FilterRuleId, array2);
			}
		}
	}

	// Token: 0x0600D3CD RID: 54221 RVA: 0x003EF67C File Offset: 0x003ED87C
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

	// Token: 0x0600D3CE RID: 54222 RVA: 0x003EF730 File Offset: 0x003ED930
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

	// Token: 0x0600D3CF RID: 54223 RVA: 0x003EF7D8 File Offset: 0x003ED9D8
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

	// Token: 0x04007718 RID: 30488
	private PhantomSettingType Type;

	// Token: 0x04007719 RID: 30489
	private int Index = -1;

	// Token: 0x0400771A RID: 30490
	private bool IsOn;

	// Token: 0x0400771B RID: 30491
	private string Name;

	// Token: 0x0400771C RID: 30492
	private Dictionary<int, int[]> RuleIdMapValueList = new Dictionary<int, int[]>();

	// Token: 0x0400771D RID: 30493
	private int DisplayIndex = -1;
}
