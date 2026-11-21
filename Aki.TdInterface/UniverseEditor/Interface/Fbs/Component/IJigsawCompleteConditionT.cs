using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A27 RID: 23079
	public class IJigsawCompleteConditionT
	{
		// Token: 0x1700A7C1 RID: 42945
		// (get) Token: 0x06025B4C RID: 154444 RVA: 0x0052B18A File Offset: 0x0052938A
		// (set) Token: 0x06025B4D RID: 154445 RVA: 0x0052B192 File Offset: 0x00529392
		public EJigsawCompleteCondition Type { get; set; }

		// Token: 0x06025B4E RID: 154446 RVA: 0x0052B19B File Offset: 0x0052939B
		public IJigsawCompleteConditionT()
		{
			this.Type = EJigsawCompleteCondition.ActivateAllCorrectPiece;
		}
	}
}
