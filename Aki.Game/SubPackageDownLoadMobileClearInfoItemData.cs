using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A9C RID: 10908
[NullableContext(2)]
[Nullable(0)]
public class SubPackageDownLoadMobileClearInfoItemData : ISubPackageDownLoadMobileClearInfoItemData
{
	// Token: 0x17001E45 RID: 7749
	// (get) Token: 0x06016B44 RID: 92996 RVA: 0x005C0975 File Offset: 0x005BEB75
	// (set) Token: 0x06016B45 RID: 92997 RVA: 0x005C097D File Offset: 0x005BEB7D
	public ESubPackageDownLoadPackageType Type { get; set; }

	// Token: 0x17001E46 RID: 7750
	// (get) Token: 0x06016B46 RID: 92998 RVA: 0x005C0986 File Offset: 0x005BEB86
	// (set) Token: 0x06016B47 RID: 92999 RVA: 0x005C098E File Offset: 0x005BEB8E
	public int? SceneId { get; set; } = new int?(0);

	// Token: 0x17001E47 RID: 7751
	// (get) Token: 0x06016B48 RID: 93000 RVA: 0x005C0997 File Offset: 0x005BEB97
	// (set) Token: 0x06016B49 RID: 93001 RVA: 0x005C099F File Offset: 0x005BEB9F
	public bool? HaveVideoCanClear { get; set; }

	// Token: 0x17001E48 RID: 7752
	// (get) Token: 0x06016B4A RID: 93002 RVA: 0x005C09A8 File Offset: 0x005BEBA8
	// (set) Token: 0x06016B4B RID: 93003 RVA: 0x005C09B0 File Offset: 0x005BEBB0
	public string VoiceLanguageCode { get; set; }
}
