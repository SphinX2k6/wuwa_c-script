using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002015 RID: 8213
[NullableContext(2)]
public interface ISubPackageDownLoadMobileClearData
{
	// Token: 0x17001E91 RID: 7825
	// (get) Token: 0x06014555 RID: 83285
	// (set) Token: 0x06014556 RID: 83286
	int TitleId { get; set; }

	// Token: 0x17001E92 RID: 7826
	// (get) Token: 0x06014557 RID: 83287
	// (set) Token: 0x06014558 RID: 83288
	List<int> SceneIdList { get; set; }

	// Token: 0x17001E93 RID: 7827
	// (get) Token: 0x06014559 RID: 83289
	// (set) Token: 0x0601455A RID: 83290
	bool? HaveVideoCanClear { get; set; }

	// Token: 0x17001E94 RID: 7828
	// (get) Token: 0x0601455B RID: 83291
	// (set) Token: 0x0601455C RID: 83292
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
