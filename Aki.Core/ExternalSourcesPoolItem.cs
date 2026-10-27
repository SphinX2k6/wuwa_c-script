using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200001B RID: 27
[NullableContext(1)]
[Nullable(0)]
public class ExternalSourcesPoolItem
{
	// Token: 0x060000B9 RID: 185 RVA: 0x00006801 File Offset: 0x00004A01
	public ExternalSourcesPoolItem(UAkExternalMediaAsset asset)
	{
		this.ExternalSources = asset;
		this.UseTime = Time.Instance.Now;
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00006820 File Offset: 0x00004A20
	public void ClearData(string path)
	{
		if (this.ExternalSources != null)
		{
			this.ExternalSources = null;
		}
	}

	// Token: 0x04000094 RID: 148
	public double UseTime;

	// Token: 0x04000095 RID: 149
	[Nullable(2)]
	private UAkExternalMediaAsset ExternalSources;
}
