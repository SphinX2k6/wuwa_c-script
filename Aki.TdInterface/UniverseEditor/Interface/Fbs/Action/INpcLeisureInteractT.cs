using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007323 RID: 29475
	public class INpcLeisureInteractT
	{
		// Token: 0x1700D80A RID: 55306
		// (get) Token: 0x06033667 RID: 210535 RVA: 0x006EE1D5 File Offset: 0x006EC3D5
		// (set) Token: 0x06033668 RID: 210536 RVA: 0x006EE1DD File Offset: 0x006EC3DD
		public TNpcLeisureInteractOpUnion Option { get; set; }

		// Token: 0x06033669 RID: 210537 RVA: 0x006EE1E6 File Offset: 0x006EC3E6
		public INpcLeisureInteractT()
		{
			this.Option = null;
		}
	}
}
