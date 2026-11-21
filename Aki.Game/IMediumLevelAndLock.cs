using System;

// Token: 0x02000DD5 RID: 3541
public interface IMediumLevelAndLock
{
	// Token: 0x17000FD5 RID: 4053
	// (get) Token: 0x0600902D RID: 36909
	// (set) Token: 0x0600902E RID: 36910
	int? Level { get; set; }

	// Token: 0x17000FD6 RID: 4054
	// (get) Token: 0x0600902F RID: 36911
	// (set) Token: 0x06009030 RID: 36912
	bool? IsLevelInfinite { get; set; }

	// Token: 0x17000FD7 RID: 4055
	// (get) Token: 0x06009031 RID: 36913
	// (set) Token: 0x06009032 RID: 36914
	bool? IsLockVisible { get; set; }

	// Token: 0x17000FD8 RID: 4056
	// (get) Token: 0x06009033 RID: 36915
	// (set) Token: 0x06009034 RID: 36916
	bool? IsLevelUseChangeColor { get; set; }

	// Token: 0x17000FD9 RID: 4057
	// (get) Token: 0x06009035 RID: 36917
	// (set) Token: 0x06009036 RID: 36918
	bool? IsUseVision { get; set; }

	// Token: 0x17000FDA RID: 4058
	// (get) Token: 0x06009037 RID: 36919
	// (set) Token: 0x06009038 RID: 36920
	bool? IsDeprecate { get; set; }
}
