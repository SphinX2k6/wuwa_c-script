using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004260 RID: 16992
	public class IFastReturnPosBaseT
	{
		// Token: 0x170073EA RID: 29674
		// (get) Token: 0x06017AE6 RID: 96998 RVA: 0x00360E4A File Offset: 0x0035F04A
		// (set) Token: 0x06017AE7 RID: 96999 RVA: 0x00360E52 File Offset: 0x0035F052
		public EFastReturnPosType Type { get; set; }

		// Token: 0x06017AE8 RID: 97000 RVA: 0x00360E5B File Offset: 0x0035F05B
		public IFastReturnPosBaseT()
		{
			this.Type = EFastReturnPosType.EntityPos;
		}
	}
}
