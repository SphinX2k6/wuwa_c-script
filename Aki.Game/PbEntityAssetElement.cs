using System;
using System.Runtime.CompilerServices;

// Token: 0x02003321 RID: 13089
[NullableContext(2)]
[Nullable(0)]
public class PbEntityAssetElement : AssetElementBundleBase
{
	// Token: 0x0601C82C RID: 116780 RVA: 0x007FF5EE File Offset: 0x007FD7EE
	public PbEntityAssetElement(int pbDataId)
	{
		this.PbDataId = new int?(pbDataId);
		this.LoadPriority = ResourceSystem.EResourceLoadPriority.Preload;
		this.MainAsset = new PbPreloadAssetElement(pbDataId);
		this.FightAssetManager = new FightAssetManager(this);
	}

	// Token: 0x17002788 RID: 10120
	// (get) Token: 0x0601C82D RID: 116781 RVA: 0x007FF627 File Offset: 0x007FD827
	// (set) Token: 0x0601C82E RID: 116782 RVA: 0x007FF62F File Offset: 0x007FD82F
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

	// Token: 0x17002789 RID: 10121
	// (get) Token: 0x0601C82F RID: 116783 RVA: 0x007FF638 File Offset: 0x007FD838
	// (set) Token: 0x0601C830 RID: 116784 RVA: 0x007FF640 File Offset: 0x007FD840
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

	// Token: 0x1700278A RID: 10122
	// (get) Token: 0x0601C831 RID: 116785 RVA: 0x007FF649 File Offset: 0x007FD849
	private int HolderEntityId
	{
		get
		{
			return -this.PbDataId.GetValueOrDefault();
		}
	}

	// Token: 0x0601C832 RID: 116786 RVA: 0x007FF658 File Offset: 0x007FD858
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

	// Token: 0x0400E285 RID: 57989
	public int? PbDataId;

	// Token: 0x0400E286 RID: 57990
	public PbPreloadAssetElement MainAsset;

	// Token: 0x0400E287 RID: 57991
	[Nullable(1)]
	public FightAssetManager FightAssetManager;

	// Token: 0x0400E288 RID: 57992
	private bool CollectMinorAssetInternal;

	// Token: 0x0400E289 RID: 57993
	private string BlueprintClassPathInternal;
}
