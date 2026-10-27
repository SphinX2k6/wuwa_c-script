using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AB4 RID: 23220
	[NullableContext(1)]
	[Nullable(0)]
	public class DreamLinkRecordData : IDreamLinkRecordData
	{
		// Token: 0x17008C1F RID: 35871
		// (get) Token: 0x0603AD04 RID: 240900 RVA: 0x00E03477 File Offset: 0x00E01677
		// (set) Token: 0x0603AD05 RID: 240901 RVA: 0x00E0347F File Offset: 0x00E0167F
		public string Title { get; set; }

		// Token: 0x17008C20 RID: 35872
		// (get) Token: 0x0603AD06 RID: 240902 RVA: 0x00E03488 File Offset: 0x00E01688
		// (set) Token: 0x0603AD07 RID: 240903 RVA: 0x00E03490 File Offset: 0x00E01690
		public string Score { get; set; }

		// Token: 0x17008C21 RID: 35873
		// (get) Token: 0x0603AD08 RID: 240904 RVA: 0x00E03499 File Offset: 0x00E01699
		// (set) Token: 0x0603AD09 RID: 240905 RVA: 0x00E034A1 File Offset: 0x00E016A1
		public bool IsNew { get; set; }
	}
}
