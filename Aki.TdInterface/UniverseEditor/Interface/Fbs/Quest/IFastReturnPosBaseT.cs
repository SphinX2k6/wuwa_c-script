using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E25 RID: 15909
	public class IFastReturnPosBaseT
	{
		// Token: 0x17006E04 RID: 28164
		// (get) Token: 0x060164B9 RID: 91321 RVA: 0x00338252 File Offset: 0x00336452
		// (set) Token: 0x060164BA RID: 91322 RVA: 0x0033825A File Offset: 0x0033645A
		public EFastReturnPosType Type { get; set; }

		// Token: 0x060164BB RID: 91323 RVA: 0x00338263 File Offset: 0x00336463
		public IFastReturnPosBaseT()
		{
			this.Type = EFastReturnPosType.EntityPos;
		}
	}
}
