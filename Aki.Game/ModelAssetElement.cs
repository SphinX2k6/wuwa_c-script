using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02003318 RID: 13080
[NullableContext(1)]
[Nullable(0)]
public class ModelAssetElement
{
	// Token: 0x1700277F RID: 10111
	// (get) Token: 0x0601C7E5 RID: 116709 RVA: 0x007FE58D File Offset: 0x007FC78D
	// (set) Token: 0x0601C7E6 RID: 116710 RVA: 0x007FE595 File Offset: 0x007FC795
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

	// Token: 0x17002780 RID: 10112
	// (get) Token: 0x0601C7E7 RID: 116711 RVA: 0x007FE59E File Offset: 0x007FC79E
	// (set) Token: 0x0601C7E8 RID: 116712 RVA: 0x007FE5A6 File Offset: 0x007FC7A6
	[Nullable(2)]
	public string BlueprintClassPath
	{
		[NullableContext(2)]
		get
		{
			return this.BlueprintClassPathInternal;
		}
		[NullableContext(2)]
		set
		{
			this.BlueprintClassPathInternal = value;
		}
	}

	// Token: 0x0601C7E9 RID: 116713 RVA: 0x007FE5AF File Offset: 0x007FC7AF
	public ModelAssetElement()
	{
		this.SkillAssetManager = new ModelAssetSkillManager(this);
		this.BulletAssetManager = new ModelAssetBulletManager(this);
	}

	// Token: 0x0601C7EA RID: 116714 RVA: 0x007FE5E3 File Offset: 0x007FC7E3
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

	// Token: 0x0601C7EB RID: 116715 RVA: 0x007FE608 File Offset: 0x007FC808
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

	// Token: 0x0601C7EC RID: 116716 RVA: 0x007FE678 File Offset: 0x007FC878
	public void ClearCallback()
	{
		this.Callbacks = null;
	}

	// Token: 0x0601C7ED RID: 116717 RVA: 0x007FE681 File Offset: 0x007FC881
	public void Clear()
	{
		this.IsDestroy = true;
		if (this.Callbacks != null)
		{
			this.DoCallback(ELoadResultType.Destroy);
		}
		this.SkillAssetManager.Clear();
		this.BulletAssetManager.Clear();
		this.Callbacks = null;
	}

	// Token: 0x0601C7EE RID: 116718 RVA: 0x007FE6B6 File Offset: 0x007FC8B6
	public void PrintDebugInfo()
	{
	}

	// Token: 0x0400E25D RID: 57949
	[Nullable(0)]
	public UniTask<ELoadResultType>? Promise;

	// Token: 0x0400E25E RID: 57950
	public AssetElement MainAsset = new AssetElement(null);

	// Token: 0x0400E25F RID: 57951
	public ModelAssetSkillManager SkillAssetManager;

	// Token: 0x0400E260 RID: 57952
	public ModelAssetBulletManager BulletAssetManager;

	// Token: 0x0400E261 RID: 57953
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Action<ELoadResultType>> Callbacks;

	// Token: 0x0400E262 RID: 57954
	public bool IsDestroy;

	// Token: 0x0400E263 RID: 57955
	public readonly ResourceSystem.EResourceLoadPriority LoadPriority = ResourceSystem.EResourceLoadPriority.Preload;

	// Token: 0x0400E264 RID: 57956
	private ELoadResultType LoadStateInternal;

	// Token: 0x0400E265 RID: 57957
	[Nullable(2)]
	private string BlueprintClassPathInternal;
}
