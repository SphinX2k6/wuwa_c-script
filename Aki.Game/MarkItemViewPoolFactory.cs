using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItemView;

// Token: 0x020021EA RID: 8682
[NullableContext(1)]
[Nullable(0)]
public class MarkItemViewPoolFactory
{
	// Token: 0x06010E58 RID: 69208 RVA: 0x0041CAD4 File Offset: 0x0041ACD4
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

	// Token: 0x06010E59 RID: 69209 RVA: 0x0041CB05 File Offset: 0x0041AD05
	[return: Nullable(2)]
	public static T Get<[Nullable(0)] T>(string poolName) where T : MarkPanelBase
	{
		return MarkItemViewPoolFactory.GetPool(poolName).Get<T>();
	}

	// Token: 0x06010E5A RID: 69210 RVA: 0x0041CB12 File Offset: 0x0041AD12
	public static void Recycle(string poolName, MarkPanelBase poolObj)
	{
		MarkItemViewPoolFactory.GetPool(poolName).Recycle(poolObj);
	}

	// Token: 0x06010E5B RID: 69211 RVA: 0x0041CB20 File Offset: 0x0041AD20
	public static void Tick()
	{
		foreach (MarkItemViewPoolBase markItemViewPoolBase in MarkItemViewPoolFactory.PoolMap.Values)
		{
			markItemViewPoolBase.Tick();
		}
	}

	// Token: 0x06010E5C RID: 69212 RVA: 0x0041CB74 File Offset: 0x0041AD74
	public static void Dispose()
	{
		foreach (MarkItemViewPoolBase markItemViewPoolBase in MarkItemViewPoolFactory.PoolMap.Values)
		{
			markItemViewPoolBase.Dispose();
		}
		MarkItemViewPoolFactory.PoolMap.Clear();
	}

	// Token: 0x04008072 RID: 32882
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<string, MarkItemViewPoolBase> PoolMap = new Dictionary<string, MarkItemViewPoolBase>();
}
