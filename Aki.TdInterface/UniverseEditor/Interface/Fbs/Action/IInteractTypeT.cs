using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A9 RID: 27049
	public class IInteractTypeT
	{
		// Token: 0x1700C8A7 RID: 51367
		// (get) Token: 0x0602F427 RID: 193575 RVA: 0x0066FEBE File Offset: 0x0066E0BE
		// (set) Token: 0x0602F428 RID: 193576 RVA: 0x0066FEC6 File Offset: 0x0066E0C6
		public EInteractOption Type { get; set; }

		// Token: 0x0602F429 RID: 193577 RVA: 0x0066FECF File Offset: 0x0066E0CF
		public IInteractTypeT()
		{
			this.Type = EInteractOption.Flow;
		}
	}
}
