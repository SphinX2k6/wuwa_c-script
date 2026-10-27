using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000EC RID: 236
[NullableContext(1)]
[Nullable(0)]
public class DataTableCacheData : Singleton
{
	// Token: 0x06000739 RID: 1849 RVA: 0x00027C78 File Offset: 0x00025E78
	[return: Nullable(2)]
	public unsafe T GetOrCreate<[Nullable(0)] T>(UDataTable table, string rowName, [Nullable(new byte[]
	{
		1,
		2
	})] Func<T> factory) where T : UnrealProxyObject
	{
		DataTableCacheData.DataTableRowCache dataTableRowCache;
		if (!this.Cache.TryGetValue(table, out dataTableRowCache))
		{
			dataTableRowCache = new DataTableCacheData.DataTableRowCache();
			this.Cache.Set(table, dataTableRowCache);
		}
		WeakReference<UnrealProxyObject> weakReference;
		UnrealProxyObject unrealProxyObject;
		if (dataTableRowCache.Rows.TryGetValue(rowName, out weakReference) && weakReference.TryGetTarget(out unrealProxyObject))
		{
			T t = unrealProxyObject as T;
			if (t != null)
			{
				return t;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DataTableUtil;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "DataTable 行被不同类型查询，拒绝覆盖";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("RowName", rowName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CachedType", unrealProxyObject.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("RequestedType", typeof(T).Name);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return default(T);
		}
		else
		{
			T t2 = factory();
			if (t2 == null)
			{
				return default(T);
			}
			T t3 = t2;
			dataTableRowCache.Rows[rowName] = new WeakReference<UnrealProxyObject>(t3);
			return t3;
		}
	}

	// Token: 0x0600073A RID: 1850 RVA: 0x00027DA9 File Offset: 0x00025FA9
	protected override bool OnClear()
	{
		this.Cache.Clear();
		return base.OnClear();
	}

	// Token: 0x170000E4 RID: 228
	// (get) Token: 0x0600073B RID: 1851 RVA: 0x00027DBC File Offset: 0x00025FBC
	public static DataTableCacheData Instance
	{
		get
		{
			if (DataTableCacheData._instance == null)
			{
				DataTableCacheData._instance = new DataTableCacheData();
				DataTableCacheData._instance.OnInit();
			}
			return DataTableCacheData._instance;
		}
	}

	// Token: 0x0600073C RID: 1852 RVA: 0x00027DDF File Offset: 0x00025FDF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600073D RID: 1853 RVA: 0x00027DE1 File Offset: 0x00025FE1
	public static void ResetStaticDefaultValue()
	{
		DataTableCacheData instance = DataTableCacheData._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		DataTableCacheData._instance = null;
	}

	// Token: 0x0600073E RID: 1854 RVA: 0x00027DFA File Offset: 0x00025FFA
	static DataTableCacheData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DataTableCacheData.CreateStaticDefaultValue), new Action(DataTableCacheData.ResetStaticDefaultValue));
	}

	// Token: 0x040005C1 RID: 1473
	private readonly WeakMap<UDataTable, DataTableCacheData.DataTableRowCache> Cache = new WeakMap<UDataTable, DataTableCacheData.DataTableRowCache>();

	// Token: 0x040005C2 RID: 1474
	[Nullable(2)]
	private static DataTableCacheData _instance;

	// Token: 0x020001D2 RID: 466
	[NullableContext(0)]
	private sealed class DataTableRowCache
	{
		// Token: 0x04000883 RID: 2179
		[Nullable(1)]
		public readonly Dictionary<string, WeakReference<UnrealProxyObject>> Rows = new Dictionary<string, WeakReference<UnrealProxyObject>>(StringComparer.OrdinalIgnoreCase);
	}
}
