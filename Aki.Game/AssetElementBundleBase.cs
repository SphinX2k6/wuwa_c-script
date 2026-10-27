using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02003320 RID: 13088
public class AssetElementBundleBase
{
	// Token: 0x17002787 RID: 10119
	// (get) Token: 0x0601C824 RID: 116772 RVA: 0x007FF50E File Offset: 0x007FD70E
	// (set) Token: 0x0601C825 RID: 116773 RVA: 0x007FF516 File Offset: 0x007FD716
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

	// Token: 0x0601C826 RID: 116774 RVA: 0x007FF51F File Offset: 0x007FD71F
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

	// Token: 0x0601C827 RID: 116775 RVA: 0x007FF544 File Offset: 0x007FD744
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

	// Token: 0x0601C828 RID: 116776 RVA: 0x007FF5B4 File Offset: 0x007FD7B4
	public void ClearCallback()
	{
		this.Callbacks = null;
	}

	// Token: 0x0601C829 RID: 116777 RVA: 0x007FF5BD File Offset: 0x007FD7BD
	public virtual void Clear()
	{
		if (this.Callbacks != null)
		{
			this.DoCallback(ELoadResultType.Destroy);
		}
		this.Callbacks = null;
		this.IsDestroy = true;
	}

	// Token: 0x0601C82A RID: 116778 RVA: 0x007FF5DC File Offset: 0x007FD7DC
	public virtual void PrintDebugInfo()
	{
	}

	// Token: 0x0400E280 RID: 57984
	public UniTask<ELoadResultType>? Promise;

	// Token: 0x0400E281 RID: 57985
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Action<ELoadResultType>> Callbacks;

	// Token: 0x0400E282 RID: 57986
	public ResourceSystem.EResourceLoadPriority LoadPriority = ResourceSystem.EResourceLoadPriority.Default;

	// Token: 0x0400E283 RID: 57987
	protected ELoadResultType LoadStateInternal;

	// Token: 0x0400E284 RID: 57988
	public bool IsDestroy;
}
