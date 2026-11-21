using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703E RID: 28734
	public class IInteractionConfirmBoxTypeT
	{
		// Token: 0x1700D262 RID: 53858
		// (get) Token: 0x06031CD4 RID: 203988 RVA: 0x006BDC32 File Offset: 0x006BBE32
		// (set) Token: 0x06031CD5 RID: 203989 RVA: 0x006BDC3A File Offset: 0x006BBE3A
		public EInteractionConfirmBoxType Type { get; set; }

		// Token: 0x06031CD6 RID: 203990 RVA: 0x006BDC43 File Offset: 0x006BBE43
		public IInteractionConfirmBoxTypeT()
		{
			this.Type = EInteractionConfirmBoxType.Common;
		}
	}
}
