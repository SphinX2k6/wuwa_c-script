using System;
using System.Runtime.CompilerServices;

// Token: 0x02002893 RID: 10387
[NullableContext(2)]
[Nullable(0)]
public class PbEntityAssetElement : AssetElementBundleBase
{
	// Token: 0x0601A525 RID: 107813 RVA: 0x00825B5A File Offset: 0x00823D5A
	public PbEntityAssetElement(int pbDataId)
	{
		this.PbDataId = new int?(pbDataId);
		this.LoadPriority = ResourceSystem.EResourceLoadPriority.Preload;
		this.MainAsset = new PbPreloadAssetElement(pbDataId);
		this.FightAssetManager = new FightAssetManager(this);
	}

	// Token: 0x17002B25 RID: 11045
	// (get) Token: 0x0601A526 RID: 107814 RVA: 0x00825B93 File Offset: 0x00823D93
	// (set) Token: 0x0601A527 RID: 107815 RVA: 0x00825B9B File Offset: 0x00823D9B
	public bool CollectMinorAsset
	{
		get
		{
			return this.CollectMinorAssetInternal;
		}
		set
		{
			this.CollectMinorAssetInternal = value;
		}
	}

	// Token: 0x17002B26 RID: 11046
	// (get) Token: 0x0601A528 RID: 107816 RVA: 0x00825BA4 File Offset: 0x00823DA4
	// (set) Token: 0x0601A529 RID: 107817 RVA: 0x00825BAC File Offset: 0x00823DAC
	public string BlueprintClassPath
	{
		get
		{
			return this.BlueprintClassPathInternal;
		}
		set
		{
			this.BlueprintClassPathInternal = value;
		}
	}

	// Token: 0x17002B27 RID: 11047
	// (get) Token: 0x0601A52A RID: 107818 RVA: 0x00825BB5 File Offset: 0x00823DB5
	private int HolderEntityId
	{
		get
		{
			return -this.PbDataId.GetValueOrDefault();
		}
	}

	// Token: 0x0601A52B RID: 107819 RVA: 0x00825BC4 File Offset: 0x00823DC4
	public override void Clear()
	{
		base.Clear();
		PreloadModelNew.Instance.HoldPreloadObject.RemoveEntityAssets(this.HolderEntityId);
		this.FightAssetManager.Clear();
		this.BlueprintClassPathInternal = null;
		this.CollectMinorAssetInternal = false;
		if (this.Callbacks != null)
		{
			base.DoCallback(ELoadResultType.Destroy);
		}
		this.Callbacks = null;
		this.IsDestroy = true;
	}

	// Token: 0x0400E736 RID: 59190
	public int? PbDataId;

	// Token: 0x0400E737 RID: 59191
	public PbPreloadAssetElement MainAsset;

	// Token: 0x0400E738 RID: 59192
	[Nullable(1)]
	public FightAssetManager FightAssetManager;

	// Token: 0x0400E739 RID: 59193
	private bool CollectMinorAssetInternal;

	// Token: 0x0400E73A RID: 59194
	private string BlueprintClassPathInternal;
}
