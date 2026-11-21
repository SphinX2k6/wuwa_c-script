using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200289A RID: 10394
[NullableContext(1)]
[Nullable(0)]
public class RedDotData : IStaticVariableResetter
{
	// Token: 0x0601A5B0 RID: 107952 RVA: 0x00827780 File Offset: 0x00825980
	static RedDotData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RedDotData.CreateStaticDefaultValue), new Action(RedDotData.ResetStaticDefaultValue));
	}

	// Token: 0x17002B38 RID: 11064
	// (get) Token: 0x0601A5B1 RID: 107953 RVA: 0x0082779F File Offset: 0x0082599F
	public bool State
	{
		get
		{
			return RedDotData.StateByGm && this.StateCountInternal > 0;
		}
	}

	// Token: 0x17002B39 RID: 11065
	// (get) Token: 0x0601A5B2 RID: 107954 RVA: 0x008277B3 File Offset: 0x008259B3
	// (set) Token: 0x0601A5B3 RID: 107955 RVA: 0x008277BB File Offset: 0x008259BB
	public int StateCount
	{
		get
		{
			return this.StateCountInternal;
		}
		set
		{
			this.StateCountInternal = ((value < 0) ? 0 : value);
		}
	}

	// Token: 0x0601A5B4 RID: 107956 RVA: 0x008277CB File Offset: 0x008259CB
	public static void CreateStaticDefaultValue()
	{
		RedDotData.StateByGm = true;
	}

	// Token: 0x0601A5B5 RID: 107957 RVA: 0x008277D3 File Offset: 0x008259D3
	public static void ResetStaticDefaultValue()
	{
		RedDotData.StateByGm = true;
	}

	// Token: 0x0601A5B6 RID: 107958 RVA: 0x008277DB File Offset: 0x008259DB
	public HashSet<UUIItem> GetUiItemSet()
	{
		return this.UiItemSet;
	}

	// Token: 0x0601A5B7 RID: 107959 RVA: 0x008277E3 File Offset: 0x008259E3
	public void ClearUiItem()
	{
		this.UiItemSet.Clear();
	}

	// Token: 0x0601A5B8 RID: 107960 RVA: 0x008277F0 File Offset: 0x008259F0
	public void SetUiItem(UUIItem uiItem)
	{
		this.UiItemSet.Add(uiItem);
	}

	// Token: 0x0601A5B9 RID: 107961 RVA: 0x008277FF File Offset: 0x008259FF
	public void DeleteUiItem(UUIItem uiItem)
	{
		this.UiItemSet.Remove(uiItem);
	}

	// Token: 0x0601A5BA RID: 107962 RVA: 0x00827810 File Offset: 0x00825A10
	public bool TryChangeState(bool toState)
	{
		if (toState == this.State)
		{
			return false;
		}
		int num = toState ? 1 : -1;
		this.StateCount += num;
		this.UpdateRedDotUIActive();
		return true;
	}

	// Token: 0x0601A5BB RID: 107963 RVA: 0x00827845 File Offset: 0x00825A45
	public void UpdateRedDotUIActive()
	{
		this.SetUIItemActive(this.State);
	}

	// Token: 0x0601A5BC RID: 107964 RVA: 0x00827854 File Offset: 0x00825A54
	public void SetUIItemActive(bool value)
	{
		foreach (UUIItem uuiitem in this.UiItemSet)
		{
			if (uuiitem.IsValid())
			{
				uuiitem.SetUIActive(value);
			}
		}
	}

	// Token: 0x0601A5BD RID: 107965 RVA: 0x008278B0 File Offset: 0x00825AB0
	public bool OnChildrenStateChange(bool toState)
	{
		int num = toState ? 1 : -1;
		bool state = this.State;
		this.StateCount += num;
		if (state == this.State)
		{
			return false;
		}
		this.UpdateRedDotUIActive();
		return true;
	}

	// Token: 0x0400E765 RID: 59237
	private int StateCountInternal;

	// Token: 0x0400E766 RID: 59238
	public static bool StateByGm;

	// Token: 0x0400E767 RID: 59239
	private readonly HashSet<UUIItem> UiItemSet = new HashSet<UUIItem>();
}
