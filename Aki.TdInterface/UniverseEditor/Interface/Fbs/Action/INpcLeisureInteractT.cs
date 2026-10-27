using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BBF RID: 27583
	public class INpcLeisureInteractT
	{
		// Token: 0x1700CCFE RID: 52478
		// (get) Token: 0x0603074B RID: 198475 RVA: 0x006948D5 File Offset: 0x00692AD5
		// (set) Token: 0x0603074C RID: 198476 RVA: 0x006948DD File Offset: 0x00692ADD
		public TNpcLeisureInteractOpUnion Option { get; set; }

		// Token: 0x0603074D RID: 198477 RVA: 0x006948E6 File Offset: 0x00692AE6
		public INpcLeisureInteractT()
		{
			this.Option = null;
		}
	}
}
