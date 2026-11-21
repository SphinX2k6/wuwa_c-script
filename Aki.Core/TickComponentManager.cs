using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000075 RID: 117
[NullableContext(1)]
[Nullable(0)]
public class TickComponentManager
{
	// Token: 0x06000360 RID: 864 RVA: 0x00013FA3 File Offset: 0x000121A3
	public int GetCurrentTickIntervalCount()
	{
		return this.TickIntervalCount;
	}

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x06000361 RID: 865 RVA: 0x00013FAB File Offset: 0x000121AB
	public bool NeedTick
	{
		get
		{
			return this.NeedTickInternal;
		}
	}

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000362 RID: 866 RVA: 0x00013FB3 File Offset: 0x000121B3
	public bool NeedAfterTick
	{
		get
		{
			return this.NeedAfterTickInternal;
		}
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00013FBB File Offset: 0x000121BB
	private static int Compare(TickComponentInfo a, TickComponentInfo b)
	{
		if (a.Priority == b.Priority)
		{
			return a.Index - b.Index;
		}
		return b.Priority - a.Priority;
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00013FE6 File Offset: 0x000121E6
	public void Clear()
	{
		this.DeltaTotal = 0f;
		this.TickIntervalCount = 0;
		this.DeltaTotalAfter = 0f;
		this.TickIntervalCountAfter = 0;
	}

	// Token: 0x06000365 RID: 869 RVA: 0x0001400C File Offset: 0x0001220C
	public void ClearDelta()
	{
		this.DeltaTotal = 0f;
	}

	// Token: 0x06000366 RID: 870 RVA: 0x0001401C File Offset: 0x0001221C
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

	// Token: 0x06000367 RID: 871 RVA: 0x000140CC File Offset: 0x000122CC
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

	// Token: 0x06000368 RID: 872 RVA: 0x000141BC File Offset: 0x000123BC
	public void ForceTick(float delta)
	{
		foreach (TickComponentInfo tickComponentInfo in this.ForceTickComponents)
		{
			tickComponentInfo.Component.ForceTick(delta);
		}
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00014214 File Offset: 0x00012414
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

	// Token: 0x0600036A RID: 874 RVA: 0x000142C0 File Offset: 0x000124C0
	public void ForceAfterTick(float delta)
	{
		foreach (TickComponentInfo tickComponentInfo in this.ForceAfterTickComponents)
		{
			tickComponentInfo.Component.ForceAfterTick(delta);
		}
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00014318 File Offset: 0x00012518
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

	// Token: 0x04000362 RID: 866
	private float DeltaTotal;

	// Token: 0x04000363 RID: 867
	private int TickIntervalCount;

	// Token: 0x04000364 RID: 868
	private float DeltaTotalAfter;

	// Token: 0x04000365 RID: 869
	private int TickIntervalCountAfter;

	// Token: 0x04000366 RID: 870
	private bool NeedTickInternal;

	// Token: 0x04000367 RID: 871
	private bool NeedAfterTickInternal;

	// Token: 0x04000368 RID: 872
	private readonly List<TickComponentInfo> TickComponents = new List<TickComponentInfo>();

	// Token: 0x04000369 RID: 873
	private readonly List<TickComponentInfo> ForceTickComponents = new List<TickComponentInfo>();

	// Token: 0x0400036A RID: 874
	private readonly List<TickComponentInfo> AfterTickComponents = new List<TickComponentInfo>();

	// Token: 0x0400036B RID: 875
	private readonly List<TickComponentInfo> ForceAfterTickComponents = new List<TickComponentInfo>();

	// Token: 0x0400036C RID: 876
	private int ComponentCount;

	// Token: 0x020001A7 RID: 423
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x040007F1 RID: 2033
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<TickComponentInfo> <0>__Compare;
	}
}
