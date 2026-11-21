using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x020021AD RID: 8621
[NullableContext(1)]
[Nullable(0)]
public class LoadAsyncPromise<[Nullable(0)] T> where T : UObject
{
	// Token: 0x0601536D RID: 86893 RVA: 0x0062B8EA File Offset: 0x00629AEA
	public LoadAsyncPromise(string path, ResourceSystem.EResourceLoadPriority priority = ResourceSystem.EResourceLoadPriority.Default)
	{
		this.CustomPromiseObject = new CustomPromise<T>();
		this.LoadAsync(path, priority);
	}

	// Token: 0x17002020 RID: 8224
	// (get) Token: 0x0601536E RID: 86894 RVA: 0x0062B90C File Offset: 0x00629B0C
	public CustomPromise<T> CustomPromise
	{
		get
		{
			return this.CustomPromiseObject;
		}
	}

	// Token: 0x17002021 RID: 8225
	// (get) Token: 0x0601536F RID: 86895 RVA: 0x0062B914 File Offset: 0x00629B14
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

	// Token: 0x17002022 RID: 8226
	// (get) Token: 0x06015370 RID: 86896 RVA: 0x0062B921 File Offset: 0x00629B21
	public int HandleId
	{
		get
		{
			return this.HandleIdInternal;
		}
	}

	// Token: 0x06015371 RID: 86897 RVA: 0x0062B929 File Offset: 0x00629B29
	private void LoadAsync(string path, ResourceSystem.EResourceLoadPriority priority = ResourceSystem.EResourceLoadPriority.Default)
	{
		this.HandleIdInternal = ResourceSystem.Instance.LoadAsync<T>(path2, delegate(T asset, string path)
		{
			this.CustomPromise.SetResult(asset);
		}, (int)priority, "Ui.LoadAsync");
	}

	// Token: 0x06015372 RID: 86898 RVA: 0x0062B950 File Offset: 0x00629B50
	public void CancelAsyncLoad()
	{
		if (this.HandleId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.HandleId);
			this.HandleIdInternal = -1;
			this.CustomPromiseObject.SetResult(default(T));
		}
	}

	// Token: 0x0400B3E3 RID: 46051
	private int HandleIdInternal = -1;

	// Token: 0x0400B3E4 RID: 46052
	private readonly CustomPromise<T> CustomPromiseObject;
}
