using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001A44 RID: 6724
[NullableContext(1)]
[Nullable(0)]
public class PhotoMontageItemData
{
	// Token: 0x1700191C RID: 6428
	// (get) Token: 0x0601096F RID: 67951 RVA: 0x004DAD36 File Offset: 0x004D8F36
	public bool IsDefault
	{
		get
		{
			return this.MontageConfig == null;
		}
	}

	// Token: 0x1700191D RID: 6429
	// (get) Token: 0x06010970 RID: 67952 RVA: 0x004DAD48 File Offset: 0x004D8F48
	public string Name
	{
		get
		{
			return ((this.MontageConfig != null) ? this.MontageConfig.GetValueOrDefault().Name : null) ?? "PhotoMontageDefault";
		}
	}

	// Token: 0x06010971 RID: 67953 RVA: 0x004DAD7D File Offset: 0x004D8F7D
	public static PhotoMontageItemData FromConfig(PhotoMontage cfg)
	{
		return new PhotoMontageItemData
		{
			Id = cfg.Id,
			MontageConfig = new PhotoMontage?(cfg)
		};
	}

	// Token: 0x06010972 RID: 67954 RVA: 0x004DAD9D File Offset: 0x004D8F9D
	public static PhotoMontageItemData CreateDefault()
	{
		return new PhotoMontageItemData
		{
			Id = 0
		};
	}

	// Token: 0x040092DC RID: 37596
	public int Id;

	// Token: 0x040092DD RID: 37597
	public PhotoMontage? MontageConfig;
}
