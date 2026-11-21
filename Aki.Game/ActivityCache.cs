using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;

// Token: 0x02000555 RID: 1365
[NullableContext(1)]
[Nullable(0)]
public class ActivityCache
{
	// Token: 0x06004260 RID: 16992 RVA: 0x00173A1E File Offset: 0x00171C1E
	public void InitData()
	{
		this.ActivityServerCache = (ServerStorageModel.Instance.Get(EClientStorageSystemIdType.Activity) as ServerStorageMapMap);
	}

	// Token: 0x06004261 RID: 16993 RVA: 0x00173A38 File Offset: 0x00171C38
	public void SaveCacheData(ActivityBaseData activityData, int key1, int key2, int key3, int value)
	{
		int cacheKey = this.GetCacheKey(key1, key2, key3);
		this.ActivityServerCache.Set(activityData.Id, cacheKey, value);
	}

	// Token: 0x06004262 RID: 16994 RVA: 0x00173A64 File Offset: 0x00171C64
	public void SaveCacheDataByKey(ActivityBaseData activityData, int key, int value)
	{
		this.ActivityServerCache.Set(activityData.Id, key, value);
	}

	// Token: 0x06004263 RID: 16995 RVA: 0x00173A7C File Offset: 0x00171C7C
	public int GetCacheData(ActivityBaseData activityData, int defaultValue, int key1, int key2, int key3)
	{
		int cacheKey = this.GetCacheKey(key1, key2, key3);
		int? num = this.ActivityServerCache.Get(activityData.Id, cacheKey);
		if (num != null)
		{
			return num.Value;
		}
		return defaultValue;
	}

	// Token: 0x06004264 RID: 16996 RVA: 0x00173ABC File Offset: 0x00171CBC
	public int GetCacheDataByKey(ActivityBaseData activityData, int defaultValue, int key)
	{
		int? num = this.ActivityServerCache.Get(activityData.Id, key);
		if (num != null)
		{
			return num.Value;
		}
		return defaultValue;
	}

	// Token: 0x06004265 RID: 16997 RVA: 0x00173AF0 File Offset: 0x00171CF0
	private unsafe int GetCacheKey(int key1, int key2, int key3)
	{
		long num = (long)key1 * 100000L + (long)key2 * 1000L + (long)key3 * 100L;
		if (num < -2147483648L || num > 2147483647L)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Activity;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "GetCacheKey 结果超出int32范围，key会回绕并可能与其它key冲突，请检查key1/key2/key3的取值范围";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key1", key1);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key2", key2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("key3", key3);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("wideKey", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("wrappedKey", (int)num);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}
		return key1 * 100000 + key2 * 1000 + key3 * 100;
	}

	// Token: 0x04003419 RID: 13337
	private ServerStorageMapMap ActivityServerCache;
}
