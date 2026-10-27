using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002A9A RID: 10906
[NullableContext(2)]
[Nullable(0)]
public class SubPackageDownLoadMobileClearData : ISubPackageDownLoadMobileClearData
{
	// Token: 0x17001E3D RID: 7741
	// (get) Token: 0x06016B33 RID: 92979 RVA: 0x005C091E File Offset: 0x005BEB1E
	// (set) Token: 0x06016B34 RID: 92980 RVA: 0x005C0926 File Offset: 0x005BEB26
	public int TitleId { get; set; }

	// Token: 0x17001E3E RID: 7742
	// (get) Token: 0x06016B35 RID: 92981 RVA: 0x005C092F File Offset: 0x005BEB2F
	// (set) Token: 0x06016B36 RID: 92982 RVA: 0x005C0937 File Offset: 0x005BEB37
	public List<int> SceneIdList { get; set; } = new List<int>();

	// Token: 0x17001E3F RID: 7743
	// (get) Token: 0x06016B37 RID: 92983 RVA: 0x005C0940 File Offset: 0x005BEB40
	// (set) Token: 0x06016B38 RID: 92984 RVA: 0x005C0948 File Offset: 0x005BEB48
	public bool? HaveVideoCanClear { get; set; }

	// Token: 0x17001E40 RID: 7744
	// (get) Token: 0x06016B39 RID: 92985 RVA: 0x005C0951 File Offset: 0x005BEB51
	// (set) Token: 0x06016B3A RID: 92986 RVA: 0x005C0959 File Offset: 0x005BEB59
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<string> VoiceLanguageCodeList { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }
}
