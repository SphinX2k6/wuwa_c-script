using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200001B RID: 27
[NullableContext(1)]
[Nullable(0)]
public class ExternalSourcesPoolItem
{
	// Token: 0x060000BB RID: 187 RVA: 0x00006579 File Offset: 0x00004779
	public ExternalSourcesPoolItem(UAkExternalMediaAsset asset)
	{
		this.ExternalSources = asset;
		this.UseTime = Time.Instance.Now;
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00006598 File Offset: 0x00004798
	public void ClearData(string path)
	{
		if (this.ExternalSources != null)
		{
			this.ExternalSources = null;
		}
	}

	// Token: 0x04000095 RID: 149
	public double UseTime;

	// Token: 0x04000096 RID: 150
	[Nullable(2)]
	private UAkExternalMediaAsset ExternalSources;
}
