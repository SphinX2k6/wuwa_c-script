using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;

// Token: 0x020016CE RID: 5838
[NullableContext(1)]
[Nullable(0)]
public class MarkItemViewPoolFactory
{
	// Token: 0x0600E2E9 RID: 58089 RVA: 0x004293B4 File Offset: 0x004275B4
	private static MarkItemViewPoolBase GetPool(string poolName)
	{
		MarkItemViewPoolBase markItemViewPoolBase;
		if (MarkItemViewPoolFactory.PoolMap.TryGetValue(poolName, out markItemViewPoolBase))
		{
			return markItemViewPoolBase;
		}
		markItemViewPoolBase = new MarkPanelPool();
		MarkItemViewPoolFactory.PoolMap[poolName] = markItemViewPoolBase;
		return markItemViewPoolBase;
	}

	// Token: 0x0600E2EA RID: 58090 RVA: 0x004293E5 File Offset: 0x004275E5
	[return: Nullable(2)]
	public static T Get<[Nullable(0)] T>(string poolName) where T : MarkPanelBase
	{
		return MarkItemViewPoolFactory.GetPool(poolName).Get<T>();
	}

	// Token: 0x0600E2EB RID: 58091 RVA: 0x004293F2 File Offset: 0x004275F2
	public static void Recycle(string poolName, MarkPanelBase poolObj)
	{
		MarkItemViewPoolFactory.GetPool(poolName).Recycle(poolObj);
	}

	// Token: 0x0600E2EC RID: 58092 RVA: 0x00429400 File Offset: 0x00427600
	public static void Tick()
	{
		foreach (MarkItemViewPoolBase markItemViewPoolBase in MarkItemViewPoolFactory.PoolMap.Values)
		{
			markItemViewPoolBase.Tick();
		}
	}

	// Token: 0x0600E2ED RID: 58093 RVA: 0x00429454 File Offset: 0x00427654
	public static void CollectViews(List<MarkPanelBase> result)
	{
		foreach (MarkItemViewPoolBase markItemViewPoolBase in MarkItemViewPoolFactory.PoolMap.Values)
		{
			markItemViewPoolBase.CollectViews(result);
		}
	}

	// Token: 0x0600E2EE RID: 58094 RVA: 0x004294AC File Offset: 0x004276AC
	public static void Dispose()
	{
		foreach (MarkItemViewPoolBase markItemViewPoolBase in MarkItemViewPoolFactory.PoolMap.Values)
		{
			markItemViewPoolBase.Dispose();
		}
		MarkItemViewPoolFactory.PoolMap.Clear();
	}

	// Token: 0x040081B0 RID: 33200
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<string, MarkItemViewPoolBase> PoolMap = new Dictionary<string, MarkItemViewPoolBase>();
}
