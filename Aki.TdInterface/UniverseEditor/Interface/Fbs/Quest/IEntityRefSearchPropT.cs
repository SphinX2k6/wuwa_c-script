using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E0D RID: 15885
	public class IEntityRefSearchPropT
	{
		// Token: 0x17006DCC RID: 28108
		// (get) Token: 0x060163B0 RID: 91056 RVA: 0x00335A37 File Offset: 0x00333C37
		// (set) Token: 0x060163B1 RID: 91057 RVA: 0x00335A3F File Offset: 0x00333C3F
		public string SearchText { get; set; }

		// Token: 0x17006DCD RID: 28109
		// (get) Token: 0x060163B2 RID: 91058 RVA: 0x00335A48 File Offset: 0x00333C48
		// (set) Token: 0x060163B3 RID: 91059 RVA: 0x00335A50 File Offset: 0x00333C50
		public int ResultCount { get; set; }

		// Token: 0x17006DCE RID: 28110
		// (get) Token: 0x060163B4 RID: 91060 RVA: 0x00335A59 File Offset: 0x00333C59
		// (set) Token: 0x060163B5 RID: 91061 RVA: 0x00335A61 File Offset: 0x00333C61
		public int ResultIndex { get; set; }

		// Token: 0x17006DCF RID: 28111
		// (get) Token: 0x060163B6 RID: 91062 RVA: 0x00335A6A File Offset: 0x00333C6A
		// (set) Token: 0x060163B7 RID: 91063 RVA: 0x00335A72 File Offset: 0x00333C72
		public byte NullMask { get; set; }

		// Token: 0x060163B8 RID: 91064 RVA: 0x00335A7B File Offset: 0x00333C7B
		public IEntityRefSearchPropT()
		{
			this.SearchText = null;
			this.ResultCount = 0;
			this.ResultIndex = 0;
			this.NullMask = 0;
		}
	}
}
