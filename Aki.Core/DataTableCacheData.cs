using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020000EE RID: 238
[NullableContext(1)]
[Nullable(0)]
public class DataTableCacheData : Singleton
{
	// Token: 0x0600077B RID: 1915 RVA: 0x00028278 File Offset: 0x00026478
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

	// Token: 0x0600077C RID: 1916 RVA: 0x000283A9 File Offset: 0x000265A9
	protected override bool OnClear()
	{
		this.Cache.Clear();
		return base.OnClear();
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x0600077D RID: 1917 RVA: 0x000283BC File Offset: 0x000265BC
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

	// Token: 0x0600077E RID: 1918 RVA: 0x000283DF File Offset: 0x000265DF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600077F RID: 1919 RVA: 0x000283E1 File Offset: 0x000265E1
	public static void ResetStaticDefaultValue()
	{
		DataTableCacheData instance = DataTableCacheData._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		DataTableCacheData._instance = null;
	}

	// Token: 0x06000780 RID: 1920 RVA: 0x000283FA File Offset: 0x000265FA
	static DataTableCacheData()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DataTableCacheData.CreateStaticDefaultValue), new Action(DataTableCacheData.ResetStaticDefaultValue));
	}

	// Token: 0x040005D0 RID: 1488
	private readonly WeakMap<UDataTable, DataTableCacheData.DataTableRowCache> Cache = new WeakMap<UDataTable, DataTableCacheData.DataTableRowCache>();

	// Token: 0x040005D1 RID: 1489
	[Nullable(2)]
	private static DataTableCacheData _instance;

	// Token: 0x020001D7 RID: 471
	[NullableContext(0)]
	private sealed class DataTableRowCache
	{
		// Token: 0x040008A5 RID: 2213
		[Nullable(1)]
		public readonly Dictionary<string, WeakReference<UnrealProxyObject>> Rows = new Dictionary<string, WeakReference<UnrealProxyObject>>(StringComparer.OrdinalIgnoreCase);
	}
}
