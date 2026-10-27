using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002559 RID: 9561
[NullableContext(1)]
[Nullable(0)]
public class PhotoMontageItemData
{
	// Token: 0x170018E3 RID: 6371
	// (get) Token: 0x0601348F RID: 78991 RVA: 0x004CC1FA File Offset: 0x004CA3FA
	public bool IsDefault
	{
		get
		{
			return this.MontageConfig == null;
		}
	}

	// Token: 0x170018E4 RID: 6372
	// (get) Token: 0x06013490 RID: 78992 RVA: 0x004CC20C File Offset: 0x004CA40C
	public string Name
	{
		get
		{
			return ((this.MontageConfig != null) ? this.MontageConfig.GetValueOrDefault().Name : null) ?? "PhotoMontageDefault";
		}
	}

	// Token: 0x06013491 RID: 78993 RVA: 0x004CC241 File Offset: 0x004CA441
	public static PhotoMontageItemData FromConfig(PhotoMontage cfg)
	{
		return new PhotoMontageItemData
		{
			Id = cfg.Id,
			MontageConfig = new PhotoMontage?(cfg)
		};
	}

	// Token: 0x06013492 RID: 78994 RVA: 0x004CC261 File Offset: 0x004CA461
	public static PhotoMontageItemData CreateDefault()
	{
		return new PhotoMontageItemData
		{
			Id = 0
		};
	}

	// Token: 0x04009183 RID: 37251
	public int Id;

	// Token: 0x04009184 RID: 37252
	public PhotoMontage? MontageConfig;
}
