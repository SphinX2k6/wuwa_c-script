using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x0200288A RID: 10378
[NullableContext(1)]
[Nullable(0)]
public class ModelAssetElement
{
	// Token: 0x17002B1C RID: 11036
	// (get) Token: 0x0601A4DE RID: 107742 RVA: 0x00824AF9 File Offset: 0x00822CF9
	// (set) Token: 0x0601A4DF RID: 107743 RVA: 0x00824B01 File Offset: 0x00822D01
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

	// Token: 0x17002B1D RID: 11037
	// (get) Token: 0x0601A4E0 RID: 107744 RVA: 0x00824B0A File Offset: 0x00822D0A
	// (set) Token: 0x0601A4E1 RID: 107745 RVA: 0x00824B12 File Offset: 0x00822D12
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

	// Token: 0x0601A4E2 RID: 107746 RVA: 0x00824B1B File Offset: 0x00822D1B
	public ModelAssetElement()
	{
		this.SkillAssetManager = new ModelAssetSkillManager(this);
		this.BulletAssetManager = new ModelAssetBulletManager(this);
	}

	// Token: 0x0601A4E3 RID: 107747 RVA: 0x00824B4F File Offset: 0x00822D4F
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

	// Token: 0x0601A4E4 RID: 107748 RVA: 0x00824B74 File Offset: 0x00822D74
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

	// Token: 0x0601A4E5 RID: 107749 RVA: 0x00824BE4 File Offset: 0x00822DE4
	public void ClearCallback()
	{
		this.Callbacks = null;
	}

	// Token: 0x0601A4E6 RID: 107750 RVA: 0x00824BED File Offset: 0x00822DED
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

	// Token: 0x0601A4E7 RID: 107751 RVA: 0x00824C22 File Offset: 0x00822E22
	public void PrintDebugInfo()
	{
	}

	// Token: 0x0400E70E RID: 59150
	[Nullable(0)]
	public UniTask<ELoadResultType>? Promise;

	// Token: 0x0400E70F RID: 59151
	public AssetElement MainAsset = new AssetElement(null);

	// Token: 0x0400E710 RID: 59152
	public ModelAssetSkillManager SkillAssetManager;

	// Token: 0x0400E711 RID: 59153
	public ModelAssetBulletManager BulletAssetManager;

	// Token: 0x0400E712 RID: 59154
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<Action<ELoadResultType>> Callbacks;

	// Token: 0x0400E713 RID: 59155
	public bool IsDestroy;

	// Token: 0x0400E714 RID: 59156
	public readonly ResourceSystem.EResourceLoadPriority LoadPriority = ResourceSystem.EResourceLoadPriority.Preload;

	// Token: 0x0400E715 RID: 59157
	private ELoadResultType LoadStateInternal;

	// Token: 0x0400E716 RID: 59158
	[Nullable(2)]
	private string BlueprintClassPathInternal;
}
