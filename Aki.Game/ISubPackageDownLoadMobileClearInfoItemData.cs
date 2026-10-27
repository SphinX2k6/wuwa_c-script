using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A9B RID: 10907
[NullableContext(2)]
public interface ISubPackageDownLoadMobileClearInfoItemData
{
	// Token: 0x17001E41 RID: 7745
	// (get) Token: 0x06016B3C RID: 92988
	// (set) Token: 0x06016B3D RID: 92989
	ESubPackageDownLoadPackageType Type { get; set; }

	// Token: 0x17001E42 RID: 7746
	// (get) Token: 0x06016B3E RID: 92990
	// (set) Token: 0x06016B3F RID: 92991
	int? SceneId { get; set; }

	// Token: 0x17001E43 RID: 7747
	// (get) Token: 0x06016B40 RID: 92992
	// (set) Token: 0x06016B41 RID: 92993
	bool? HaveVideoCanClear { get; set; }

	// Token: 0x17001E44 RID: 7748
	// (get) Token: 0x06016B42 RID: 92994
	// (set) Token: 0x06016B43 RID: 92995
	string VoiceLanguageCode { get; set; }
}
