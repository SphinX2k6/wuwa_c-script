using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02002C54 RID: 11348
[NullableContext(1)]
[Nullable(0)]
public class LoadAsyncPromise<[Nullable(0)] T> where T : UObject
{
	// Token: 0x06017AF7 RID: 97015 RVA: 0x00605E4A File Offset: 0x0060404A
	public LoadAsyncPromise(string path, ResourceSystem.EResourceLoadPriority priority = ResourceSystem.EResourceLoadPriority.Default)
	{
		this.CustomPromiseObject = new CustomPromise<T>();
		this.LoadAsync(path, priority);
	}

	// Token: 0x17001FCD RID: 8141
	// (get) Token: 0x06017AF8 RID: 97016 RVA: 0x00605E6C File Offset: 0x0060406C
	public CustomPromise<T> CustomPromise
	{
		get
		{
			return this.CustomPromiseObject;
		}
	}

	// Token: 0x17001FCE RID: 8142
	// (get) Token: 0x06017AF9 RID: 97017 RVA: 0x00605E74 File Offset: 0x00604074
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public UniTask<T> Promise
	{
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		get
		{
			return this.CustomPromise.Promise;
		}
	}

	// Token: 0x17001FCF RID: 8143
	// (get) Token: 0x06017AFA RID: 97018 RVA: 0x00605E81 File Offset: 0x00604081
	public int HandleId
	{
		get
		{
			return this.HandleIdInternal;
		}
	}

	// Token: 0x06017AFB RID: 97019 RVA: 0x00605E89 File Offset: 0x00604089
	private void LoadAsync(string path, ResourceSystem.EResourceLoadPriority priority = ResourceSystem.EResourceLoadPriority.Default)
	{
		this.HandleIdInternal = ResourceSystem.Instance.LoadAsync<T>(path2, delegate(T asset, string path)
		{
			this.CustomPromise.SetResult(asset);
		}, (int)priority, "Ui.LoadAsync");
	}

	// Token: 0x06017AFC RID: 97020 RVA: 0x00605EB0 File Offset: 0x006040B0
	public void CancelAsyncLoad()
	{
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
			this.HandleIdInternal = -1;
			this.CustomPromiseObject.SetResult(default(T));
		}
	}

	// Token: 0x0400B075 RID: 45173
	private int HandleIdInternal = -1;

	// Token: 0x0400B076 RID: 45174
	private readonly CustomPromise<T> CustomPromiseObject;
}
