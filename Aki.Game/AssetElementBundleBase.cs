using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02002892 RID: 10386
public class AssetElementBundleBase
{
	// Token: 0x17002B24 RID: 11044
	// (get) Token: 0x0601A51D RID: 107805 RVA: 0x00825A7A File Offset: 0x00823C7A
	// (set) Token: 0x0601A51E RID: 107806 RVA: 0x00825A82 File Offset: 0x00823C82
	public ELoadResultType LoadState
	{
		get
		{
			return this.LoadStateInternal;
		}
		set
		{
			this.LoadStateInternal = value;
		}
	}

	// Token: 0x0601A51F RID: 107807 RVA: 0x00825A8B File Offset: 0x00823C8B
	[NullableContext(1)]
	public void AddCallback(Action<ELoadResultType> callback)
	{
		if (callback == null)
		{
			return;
		}
		if (this.Callbacks == null)
		{
			this.Callbacks = new List<Action<ELoadResultType>>();
		}
		this.Callbacks.Add(callback);
	}

	// Token: 0x0601A520 RID: 107808 RVA: 0x00825AB0 File Offset: 0x00823CB0
	public void DoCallback(ELoadResultType result)
	{
		if (this.Callbacks == null || this.Callbacks.Count == 0)
		{
			return;
		}
		foreach (Action<ELoadResultType> action in this.Callbacks)
		{
			action(result);
		}
		this.Callbacks = null;
	}

	// Token: 0x0601A521 RID: 107809 RVA: 0x00825B20 File Offset: 0x00823D20
	public void ClearCallback()
	{
		this.Callbacks = null;
	}

	// Token: 0x0601A522 RID: 107810 RVA: 0x00825B29 File Offset: 0x00823D29
	public virtual void Clear()
	{
		if (this.Callbacks != null)
		{
			this.DoCallback(ELoadResultType.Destroy);
		}
		this.Callbacks = null;
		this.IsDestroy = true;
	}

	// Token: 0x0601A523 RID: 107811 RVA: 0x00825B48 File Offset: 0x00823D48
	public virtual void PrintDebugInfo()
	{
	}

	// Token: 0x0400E731 RID: 59185
	public UniTask<ELoadResultType>? Promise;

	// Token: 0x0400E732 RID: 59186
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Action<ELoadResultType>> Callbacks;

	// Token: 0x0400E733 RID: 59187
	public ResourceSystem.EResourceLoadPriority LoadPriority = ResourceSystem.EResourceLoadPriority.Default;

	// Token: 0x0400E734 RID: 59188
	protected ELoadResultType LoadStateInternal;

	// Token: 0x0400E735 RID: 59189
	public bool IsDestroy;
}
