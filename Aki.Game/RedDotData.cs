using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02003328 RID: 13096
[NullableContext(1)]
[Nullable(0)]
public class RedDotData : IStaticVariableResetter
{
	// Token: 0x0601C8B8 RID: 116920 RVA: 0x008011DC File Offset: 0x007FF3DC
	static RedDotData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(RedDotData.CreateStaticDefaultValue), new Action(RedDotData.ResetStaticDefaultValue));
	}

	// Token: 0x1700279C RID: 10140
	// (get) Token: 0x0601C8B9 RID: 116921 RVA: 0x008011FB File Offset: 0x007FF3FB
	public bool State
	{
		get
		{
			return RedDotData.StateByGm && this.StateCountInternal > 0;
		}
	}

	// Token: 0x1700279D RID: 10141
	// (get) Token: 0x0601C8BA RID: 116922 RVA: 0x0080120F File Offset: 0x007FF40F
	// (set) Token: 0x0601C8BB RID: 116923 RVA: 0x00801217 File Offset: 0x007FF417
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

	// Token: 0x0601C8BC RID: 116924 RVA: 0x00801227 File Offset: 0x007FF427
	public static void CreateStaticDefaultValue()
	{
		RedDotData.StateByGm = true;
	}

	// Token: 0x0601C8BD RID: 116925 RVA: 0x0080122F File Offset: 0x007FF42F
	public static void ResetStaticDefaultValue()
	{
		RedDotData.StateByGm = true;
	}

	// Token: 0x0601C8BE RID: 116926 RVA: 0x00801237 File Offset: 0x007FF437
	public HashSet<UUIItem> GetUiItemSet()
	{
		return this.UiItemSet;
	}

	// Token: 0x0601C8BF RID: 116927 RVA: 0x0080123F File Offset: 0x007FF43F
	public void ClearUiItem()
	{
		this.UiItemSet.Clear();
	}

	// Token: 0x0601C8C0 RID: 116928 RVA: 0x0080124C File Offset: 0x007FF44C
	public void SetUiItem(UUIItem uiItem)
	{
		this.UiItemSet.Add(uiItem);
	}

	// Token: 0x0601C8C1 RID: 116929 RVA: 0x0080125B File Offset: 0x007FF45B
	public void DeleteUiItem(UUIItem uiItem)
	{
		this.UiItemSet.Remove(uiItem);
	}

	// Token: 0x0601C8C2 RID: 116930 RVA: 0x0080126C File Offset: 0x007FF46C
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

	// Token: 0x0601C8C3 RID: 116931 RVA: 0x008012A1 File Offset: 0x007FF4A1
	public void UpdateRedDotUIActive()
	{
		this.SetUIItemActive(this.State);
	}

	// Token: 0x0601C8C4 RID: 116932 RVA: 0x008012B0 File Offset: 0x007FF4B0
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

	// Token: 0x0601C8C5 RID: 116933 RVA: 0x0080130C File Offset: 0x007FF50C
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

	// Token: 0x0400E2B5 RID: 58037
	private int StateCountInternal;

	// Token: 0x0400E2B6 RID: 58038
	public static bool StateByGm;

	// Token: 0x0400E2B7 RID: 58039
	private readonly HashSet<UUIItem> UiItemSet = new HashSet<UUIItem>();
}
