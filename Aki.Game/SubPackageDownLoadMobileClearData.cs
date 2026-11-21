using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002016 RID: 8214
[NullableContext(2)]
[Nullable(0)]
public class SubPackageDownLoadMobileClearData : ISubPackageDownLoadMobileClearData
{
	// Token: 0x17001E95 RID: 7829
	// (get) Token: 0x0601455D RID: 83293 RVA: 0x005ECF2E File Offset: 0x005EB12E
	// (set) Token: 0x0601455E RID: 83294 RVA: 0x005ECF36 File Offset: 0x005EB136
	public int TitleId { get; set; }

	// Token: 0x17001E96 RID: 7830
	// (get) Token: 0x0601455F RID: 83295 RVA: 0x005ECF3F File Offset: 0x005EB13F
	// (set) Token: 0x06014560 RID: 83296 RVA: 0x005ECF47 File Offset: 0x005EB147
	public List<int> SceneIdList { get; set; } = new List<int>();

	// Token: 0x17001E97 RID: 7831
	// (get) Token: 0x06014561 RID: 83297 RVA: 0x005ECF50 File Offset: 0x005EB150
	// (set) Token: 0x06014562 RID: 83298 RVA: 0x005ECF58 File Offset: 0x005EB158
	public bool? HaveVideoCanClear { get; set; }

	// Token: 0x17001E98 RID: 7832
	// (get) Token: 0x06014563 RID: 83299 RVA: 0x005ECF61 File Offset: 0x005EB161
	// (set) Token: 0x06014564 RID: 83300 RVA: 0x005ECF69 File Offset: 0x005EB169
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
