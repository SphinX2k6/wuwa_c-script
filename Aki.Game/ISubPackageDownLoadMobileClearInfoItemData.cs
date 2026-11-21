using System;
using System.Runtime.CompilerServices;

// Token: 0x02002017 RID: 8215
[NullableContext(2)]
public interface ISubPackageDownLoadMobileClearInfoItemData
{
	// Token: 0x17001E99 RID: 7833
	// (get) Token: 0x06014566 RID: 83302
	// (set) Token: 0x06014567 RID: 83303
	ESubPackageDownLoadPackageType Type { get; set; }

	// Token: 0x17001E9A RID: 7834
	// (get) Token: 0x06014568 RID: 83304
	// (set) Token: 0x06014569 RID: 83305
	int? SceneId { get; set; }

	// Token: 0x17001E9B RID: 7835
	// (get) Token: 0x0601456A RID: 83306
	// (set) Token: 0x0601456B RID: 83307
	bool? HaveVideoCanClear { get; set; }

	// Token: 0x17001E9C RID: 7836
	// (get) Token: 0x0601456C RID: 83308
	// (set) Token: 0x0601456D RID: 83309
	string VoiceLanguageCode { get; set; }
}
