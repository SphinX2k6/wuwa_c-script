using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A99 RID: 10905
[NullableContext(2)]
public interface ISubPackageDownLoadMobileClearData
{
	// Token: 0x17001E39 RID: 7737
	// (get) Token: 0x06016B2B RID: 92971
	// (set) Token: 0x06016B2C RID: 92972
	int TitleId { get; set; }

	// Token: 0x17001E3A RID: 7738
	// (get) Token: 0x06016B2D RID: 92973
	// (set) Token: 0x06016B2E RID: 92974
	List<int> SceneIdList { get; set; }

	// Token: 0x17001E3B RID: 7739
	// (get) Token: 0x06016B2F RID: 92975
	// (set) Token: 0x06016B30 RID: 92976
	bool? HaveVideoCanClear { get; set; }

	// Token: 0x17001E3C RID: 7740
	// (get) Token: 0x06016B31 RID: 92977
	// (set) Token: 0x06016B32 RID: 92978
	[Nullable(new byte[]
	{
		2,
		1
	})]
	List<string> VoiceLanguageCodeList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}
