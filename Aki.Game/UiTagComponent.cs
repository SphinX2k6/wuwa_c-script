using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002C64 RID: 11364
[NullableContext(1)]
[Nullable(0)]
public class UiTagComponent
{
	// Token: 0x06017BFB RID: 97275 RVA: 0x00609968 File Offset: 0x00607B68
	public void AddTagById(int tagId, params object[] args)
	{
		if (tagId == 0)
		{
			return;
		}
		int num = 0;
		if (this.TagMap.ContainsKey(tagId))
		{
			num = this.TagMap[tagId];
		}
		this.TagMap[tagId] = num + 1;
		this.DispatchEvent(tagId, num, num + 1, args);
	}

	// Token: 0x06017BFC RID: 97276 RVA: 0x006099B4 File Offset: 0x00607BB4
	public void ReduceTagById(int tagId, params object[] args)
	{
		if (tagId == 0)
		{
			return;
		}
		if (!this.TagMap.ContainsKey(tagId))
		{
			return;
		}
		int num = this.TagMap[tagId];
		if (num == 0)
		{
			return;
		}
		if (num == 1)
		{
			this.TagMap.Remove(tagId);
		}
		else
		{
			this.TagMap[tagId] = num - 1;
		}
		this.DispatchEvent(tagId, num, num - 1, args);
	}

	// Token: 0x06017BFD RID: 97277 RVA: 0x00609A14 File Offset: 0x00607C14
	public void RemoveTagById(int tagId, params object[] args)
	{
		if (tagId == 0)
		{
			return;
		}
		if (!this.TagMap.ContainsKey(tagId))
		{
			return;
		}
		int oldCount = this.TagMap[tagId];
		this.TagMap.Remove(tagId);
		this.DispatchEvent(tagId, oldCount, 0, args);
	}

	// Token: 0x06017BFE RID: 97278 RVA: 0x00609A58 File Offset: 0x00607C58
	public bool ContainsTagById(int tagId)
	{
		return this.TagMap.ContainsKey(tagId);
	}

	// Token: 0x06017BFF RID: 97279 RVA: 0x00609A68 File Offset: 0x00607C68
	public bool ContainsTagByName(string tagName)
	{
		int? num = new int?(GameplayTagUtils.GetTagIdByName(tagName));
		return num != null && this.ContainsTagById(num.Value);
	}

	// Token: 0x06017C00 RID: 97280 RVA: 0x00609A9A File Offset: 0x00607C9A
	public int GetTagCountById(int tagId)
	{
		if (tagId == 0)
		{
			return 0;
		}
		if (!this.TagMap.ContainsKey(tagId))
		{
			return 0;
		}
		return this.TagMap[tagId];
	}

	// Token: 0x06017C01 RID: 97281 RVA: 0x00609AC0 File Offset: 0x00607CC0
	private void DispatchEvent(int tagId, int oldCount, int newCount, params object[] args)
	{
		if (tagId == 0)
		{
			return;
		}
		if (oldCount == newCount)
		{
			return;
		}
		bool flag = oldCount == 0 != (newCount == 0);
		bool tagExist = newCount > 0;
		if (flag && this.TagSwitchedCallbacks.ContainsKey(tagId))
		{
			this.Emit(tagId, tagExist, this.TagSwitchedCallbacks[tagId], args);
		}
	}

	// Token: 0x06017C02 RID: 97282 RVA: 0x00609B10 File Offset: 0x00607D10
	private unsafe void Emit(int tagId, bool tagExist, IEnumerable<TTagSwitchedCallback> callbacks, params object[] args)
	{
		if (tagId == 0 || callbacks == null)
		{
			return;
		}
		string nameByTagId = GameplayTagUtils.GetNameByTagId(tagId);
		foreach (TTagSwitchedCallback ttagSwitchedCallback in new List<TTagSwitchedCallback>(callbacks))
		{
			try
			{
				ttagSwitchedCallback(tagId, tagExist, args);
			}
			catch (Exception ex)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Event;
				ELogAuthor author = ELogAuthor.LZK;
				string message = "tag事件回调执行异常";
				Exception error = ex;
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tag", nameByTagId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("error", ex.Message);
				instance.ErrorWithStack(module, author, message, error, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
		}
	}

	// Token: 0x06017C03 RID: 97283 RVA: 0x00609BE4 File Offset: 0x00607DE4
	public void AddListener(int tagId, TTagSwitchedCallback callback)
	{
		if (!this.TagSwitchedCallbacks.ContainsKey(tagId))
		{
			this.TagSwitchedCallbacks[tagId] = new HashSet<TTagSwitchedCallback>();
		}
		this.TagSwitchedCallbacks[tagId].Add(callback);
	}

	// Token: 0x06017C04 RID: 97284 RVA: 0x00609C18 File Offset: 0x00607E18
	public void RemoveListener(int tagId, TTagSwitchedCallback callback)
	{
		if (!this.TagSwitchedCallbacks.ContainsKey(tagId))
		{
			return;
		}
		this.TagSwitchedCallbacks[tagId].Remove(callback);
	}

	// Token: 0x06017C05 RID: 97285 RVA: 0x00609C3C File Offset: 0x00607E3C
	public void RemoveAllTag()
	{
		foreach (int tagId in new List<int>(this.TagMap.Keys))
		{
			this.RemoveTagById(tagId, Array.Empty<object>());
		}
	}

	// Token: 0x0400B0D5 RID: 45269
	private readonly Dictionary<int, int> TagMap = new Dictionary<int, int>();

	// Token: 0x0400B0D6 RID: 45270
	private readonly Dictionary<int, HashSet<TTagSwitchedCallback>> TagSwitchedCallbacks = new Dictionary<int, HashSet<TTagSwitchedCallback>>();
}
