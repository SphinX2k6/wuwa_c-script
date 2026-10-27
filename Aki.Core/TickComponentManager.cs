using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000074 RID: 116
[NullableContext(1)]
[Nullable(0)]
public class TickComponentManager
{
	// Token: 0x06000327 RID: 807 RVA: 0x00013247 File Offset: 0x00011447
	public int GetCurrentTickIntervalCount()
	{
		return this.TickIntervalCount;
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x06000328 RID: 808 RVA: 0x0001324F File Offset: 0x0001144F
	public bool NeedTick
	{
		get
		{
			return this.NeedTickInternal;
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x06000329 RID: 809 RVA: 0x00013257 File Offset: 0x00011457
	public bool NeedAfterTick
	{
		get
		{
			return this.NeedAfterTickInternal;
		}
	}

	// Token: 0x0600032A RID: 810 RVA: 0x0001325F File Offset: 0x0001145F
	private static int Compare(TickComponentInfo a, TickComponentInfo b)
	{
		if (a.Priority == b.Priority)
		{
			return a.Index - b.Index;
		}
		return b.Priority - a.Priority;
	}

	// Token: 0x0600032B RID: 811 RVA: 0x0001328A File Offset: 0x0001148A
	public void Clear()
	{
		this.DeltaTotal = 0f;
		this.TickIntervalCount = 0;
		this.DeltaTotalAfter = 0f;
		this.TickIntervalCountAfter = 0;
	}

	// Token: 0x0600032C RID: 812 RVA: 0x000132B0 File Offset: 0x000114B0
	public void ClearDelta()
	{
		this.DeltaTotal = 0f;
	}

	// Token: 0x0600032D RID: 813 RVA: 0x000132C0 File Offset: 0x000114C0
	public void Add(EntityComponent entityComponent, int? priority)
	{
		if (!entityComponent.NeedTick && !entityComponent.NeedForceTick && !entityComponent.NeedAfterTick && !entityComponent.NeedForceAfterTick)
		{
			return;
		}
		TickComponentInfo item = new TickComponentInfo(entityComponent, this.ComponentCount, priority.GetValueOrDefault());
		if (entityComponent.NeedTick || entityComponent.NeedForceTick)
		{
			this.TickComponents.Add(item);
		}
		if (entityComponent.NeedForceTick)
		{
			this.ForceTickComponents.Add(item);
		}
		if (entityComponent.NeedAfterTick || entityComponent.NeedForceAfterTick)
		{
			this.AfterTickComponents.Add(item);
		}
		if (entityComponent.NeedForceAfterTick)
		{
			this.ForceAfterTickComponents.Add(item);
		}
		this.ComponentCount++;
	}

	// Token: 0x0600032E RID: 814 RVA: 0x00013370 File Offset: 0x00011570
	public void Sort()
	{
		this.NeedTickInternal = (this.TickComponents.Count > 0 || this.ForceTickComponents.Count > 0);
		this.NeedAfterTickInternal = (this.AfterTickComponents.Count > 0 || this.ForceAfterTickComponents.Count > 0);
		List<TickComponentInfo> tickComponents = this.TickComponents;
		Comparison<TickComponentInfo> comparison;
		if ((comparison = TickComponentManager.<>O.<0>__Compare) == null)
		{
			comparison = (TickComponentManager.<>O.<0>__Compare = new Comparison<TickComponentInfo>(TickComponentManager.Compare));
		}
		tickComponents.Sort(comparison);
		List<TickComponentInfo> forceTickComponents = this.ForceTickComponents;
		Comparison<TickComponentInfo> comparison2;
		if ((comparison2 = TickComponentManager.<>O.<0>__Compare) == null)
		{
			comparison2 = (TickComponentManager.<>O.<0>__Compare = new Comparison<TickComponentInfo>(TickComponentManager.Compare));
		}
		forceTickComponents.Sort(comparison2);
		List<TickComponentInfo> afterTickComponents = this.AfterTickComponents;
		Comparison<TickComponentInfo> comparison3;
		if ((comparison3 = TickComponentManager.<>O.<0>__Compare) == null)
		{
			comparison3 = (TickComponentManager.<>O.<0>__Compare = new Comparison<TickComponentInfo>(TickComponentManager.Compare));
		}
		afterTickComponents.Sort(comparison3);
		List<TickComponentInfo> forceAfterTickComponents = this.ForceAfterTickComponents;
		Comparison<TickComponentInfo> comparison4;
		if ((comparison4 = TickComponentManager.<>O.<0>__Compare) == null)
		{
			comparison4 = (TickComponentManager.<>O.<0>__Compare = new Comparison<TickComponentInfo>(TickComponentManager.Compare));
		}
		forceAfterTickComponents.Sort(comparison4);
	}

	// Token: 0x0600032F RID: 815 RVA: 0x00013460 File Offset: 0x00011660
	public void ForceTick(float delta)
	{
		foreach (TickComponentInfo tickComponentInfo in this.ForceTickComponents)
		{
			tickComponentInfo.Component.ForceTick(delta);
		}
	}

	// Token: 0x06000330 RID: 816 RVA: 0x000134B8 File Offset: 0x000116B8
	public void Tick(int intervalTime, float delta)
	{
		this.DeltaTotal += delta;
		this.TickIntervalCount++;
		if (!GameBudgetInterfaceController.IsOpen && this.TickIntervalCount < intervalTime)
		{
			return;
		}
		foreach (TickComponentInfo tickComponentInfo in this.TickComponents)
		{
			if (tickComponentInfo.Component.NeedTick)
			{
				tickComponentInfo.Component.Tick(this.DeltaTotal);
			}
		}
		this.DeltaTotal = 0f;
		this.TickIntervalCount = 0;
	}

	// Token: 0x06000331 RID: 817 RVA: 0x00013564 File Offset: 0x00011764
	public void ForceAfterTick(float delta)
	{
		foreach (TickComponentInfo tickComponentInfo in this.ForceAfterTickComponents)
		{
			tickComponentInfo.Component.ForceAfterTick(delta);
		}
	}

	// Token: 0x06000332 RID: 818 RVA: 0x000135BC File Offset: 0x000117BC
	public void AfterTick(int intervalTime, float delta)
	{
		this.DeltaTotalAfter += delta;
		this.TickIntervalCountAfter++;
		if (!GameBudgetInterfaceController.IsOpen && this.TickIntervalCountAfter < intervalTime)
		{
			return;
		}
		foreach (TickComponentInfo tickComponentInfo in this.AfterTickComponents)
		{
			if (tickComponentInfo.Component.NeedAfterTick)
			{
				tickComponentInfo.Component.AfterTick(this.DeltaTotalAfter);
			}
		}
		this.DeltaTotalAfter = 0f;
		this.TickIntervalCountAfter = 0;
	}

	// Token: 0x0400034A RID: 842
	private float DeltaTotal;

	// Token: 0x0400034B RID: 843
	private int TickIntervalCount;

	// Token: 0x0400034C RID: 844
	private float DeltaTotalAfter;

	// Token: 0x0400034D RID: 845
	private int TickIntervalCountAfter;

	// Token: 0x0400034E RID: 846
	private bool NeedTickInternal;

	// Token: 0x0400034F RID: 847
	private bool NeedAfterTickInternal;

	// Token: 0x04000350 RID: 848
	private readonly List<TickComponentInfo> TickComponents = new List<TickComponentInfo>();

	// Token: 0x04000351 RID: 849
	private readonly List<TickComponentInfo> ForceTickComponents = new List<TickComponentInfo>();

	// Token: 0x04000352 RID: 850
	private readonly List<TickComponentInfo> AfterTickComponents = new List<TickComponentInfo>();

	// Token: 0x04000353 RID: 851
	private readonly List<TickComponentInfo> ForceAfterTickComponents = new List<TickComponentInfo>();

	// Token: 0x04000354 RID: 852
	private int ComponentCount;

	// Token: 0x0200019D RID: 413
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040007D1 RID: 2001
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<TickComponentInfo> <0>__Compare;
	}
}
