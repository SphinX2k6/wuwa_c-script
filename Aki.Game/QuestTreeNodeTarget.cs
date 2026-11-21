using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001B7D RID: 7037
[NullableContext(2)]
[Nullable(0)]
public class QuestTreeNodeTarget : IQuestTreeNodeTarget
{
	// Token: 0x17001A59 RID: 6745
	// (get) Token: 0x060118C4 RID: 71876 RVA: 0x0052CFAF File Offset: 0x0052B1AF
	// (set) Token: 0x060118C5 RID: 71877 RVA: 0x0052CFB7 File Offset: 0x0052B1B7
	public EQuestTreeNodeTargetType Type { get; set; }

	// Token: 0x17001A5A RID: 6746
	// (get) Token: 0x060118C6 RID: 71878 RVA: 0x0052CFC0 File Offset: 0x0052B1C0
	// (set) Token: 0x060118C7 RID: 71879 RVA: 0x0052CFC8 File Offset: 0x0052B1C8
	public string Text { get; set; }

	// Token: 0x17001A5B RID: 6747
	// (get) Token: 0x060118C8 RID: 71880 RVA: 0x0052CFD1 File Offset: 0x0052B1D1
	// (set) Token: 0x060118C9 RID: 71881 RVA: 0x0052CFD9 File Offset: 0x0052B1D9
	public string TextKey { get; set; }

	// Token: 0x17001A5C RID: 6748
	// (get) Token: 0x060118CA RID: 71882 RVA: 0x0052CFE2 File Offset: 0x0052B1E2
	// (set) Token: 0x060118CB RID: 71883 RVA: 0x0052CFEA File Offset: 0x0052B1EA
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<object> TextParam { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17001A5D RID: 6749
	// (get) Token: 0x060118CC RID: 71884 RVA: 0x0052CFF3 File Offset: 0x0052B1F3
	// (set) Token: 0x060118CD RID: 71885 RVA: 0x0052CFFB File Offset: 0x0052B1FB
	public bool? IsFinished { get; set; }

	// Token: 0x17001A5E RID: 6750
	// (get) Token: 0x060118CE RID: 71886 RVA: 0x0052D004 File Offset: 0x0052B204
	// (set) Token: 0x060118CF RID: 71887 RVA: 0x0052D00C File Offset: 0x0052B20C
	public int? HelpId { get; set; }

	// Token: 0x17001A5F RID: 6751
	// (get) Token: 0x060118D0 RID: 71888 RVA: 0x0052D015 File Offset: 0x0052B215
	// (set) Token: 0x060118D1 RID: 71889 RVA: 0x0052D01D File Offset: 0x0052B21D
	public int? GotoId { get; set; }

	// Token: 0x17001A60 RID: 6752
	// (get) Token: 0x060118D2 RID: 71890 RVA: 0x0052D026 File Offset: 0x0052B226
	// (set) Token: 0x060118D3 RID: 71891 RVA: 0x0052D02E File Offset: 0x0052B22E
	public Action OnGoto { get; set; }
}
