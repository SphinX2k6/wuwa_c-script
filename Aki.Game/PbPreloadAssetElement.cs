using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200331F RID: 13087
public class PbPreloadAssetElement : AssetElement
{
	// Token: 0x0601C820 RID: 116768 RVA: 0x007FF4BD File Offset: 0x007FD6BD
	public PbPreloadAssetElement(int pbDataId) : base(null)
	{
		this.PbDataId = new int?(pbDataId);
	}

	// Token: 0x17002785 RID: 10117
	// (get) Token: 0x0601C821 RID: 116769 RVA: 0x007FF4D2 File Offset: 0x007FD6D2
	public int? GetPbDataId
	{
		get
		{
			return this.PbDataId;
		}
	}

	// Token: 0x17002786 RID: 10118
	// (get) Token: 0x0601C822 RID: 116770 RVA: 0x007FF4DA File Offset: 0x007FD6DA
	private int HolderEntityId
	{
		get
		{
			return -this.PbDataId.GetValueOrDefault();
		}
	}

	// Token: 0x0601C823 RID: 116771 RVA: 0x007FF4E8 File Offset: 0x007FD6E8
	[NullableContext(1)]
	public override bool AddObject(string path, UObject @object)
	{
		if (!base.AddObject(path, @object))
		{
			return false;
		}
		PreloadModelNew.Instance.HoldPreloadObject.AddEntityAsset(this.HolderEntityId, @object);
		return true;
	}

	// Token: 0x0400E27F RID: 57983
	public int? PbDataId;
}
