using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002891 RID: 10385
public class PbPreloadAssetElement : AssetElement
{
	// Token: 0x0601A519 RID: 107801 RVA: 0x00825A29 File Offset: 0x00823C29
	public PbPreloadAssetElement(int pbDataId) : base(null)
	{
		this.PbDataId = new int?(pbDataId);
	}

	// Token: 0x17002B22 RID: 11042
	// (get) Token: 0x0601A51A RID: 107802 RVA: 0x00825A3E File Offset: 0x00823C3E
	public int? GetPbDataId
	{
		get
		{
			return this.PbDataId;
		}
	}

	// Token: 0x17002B23 RID: 11043
	// (get) Token: 0x0601A51B RID: 107803 RVA: 0x00825A46 File Offset: 0x00823C46
	private int HolderEntityId
	{
		get
		{
			return -this.PbDataId.GetValueOrDefault();
		}
	}

	// Token: 0x0601A51C RID: 107804 RVA: 0x00825A54 File Offset: 0x00823C54
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

	// Token: 0x0400E730 RID: 59184
	public int? PbDataId;
}
