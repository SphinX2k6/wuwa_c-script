using System;
using System.Runtime.CompilerServices;

// Token: 0x02002018 RID: 8216
[NullableContext(2)]
[Nullable(0)]
public class SubPackageDownLoadMobileClearInfoItemData : ISubPackageDownLoadMobileClearInfoItemData
{
	// Token: 0x17001E9D RID: 7837
	// (get) Token: 0x0601456E RID: 83310 RVA: 0x005ECF85 File Offset: 0x005EB185
	// (set) Token: 0x0601456F RID: 83311 RVA: 0x005ECF8D File Offset: 0x005EB18D
	public ESubPackageDownLoadPackageType Type { get; set; }

	// Token: 0x17001E9E RID: 7838
	// (get) Token: 0x06014570 RID: 83312 RVA: 0x005ECF96 File Offset: 0x005EB196
	// (set) Token: 0x06014571 RID: 83313 RVA: 0x005ECF9E File Offset: 0x005EB19E
	public int? SceneId { get; set; } = new int?(0);

	// Token: 0x17001E9F RID: 7839
	// (get) Token: 0x06014572 RID: 83314 RVA: 0x005ECFA7 File Offset: 0x005EB1A7
	// (set) Token: 0x06014573 RID: 83315 RVA: 0x005ECFAF File Offset: 0x005EB1AF
	public bool? HaveVideoCanClear { get; set; }

	// Token: 0x17001EA0 RID: 7840
	// (get) Token: 0x06014574 RID: 83316 RVA: 0x005ECFB8 File Offset: 0x005EB1B8
	// (set) Token: 0x06014575 RID: 83317 RVA: 0x005ECFC0 File Offset: 0x005EB1C0
	public string VoiceLanguageCode { get; set; }
}
