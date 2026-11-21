using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007023 RID: 28707
	public class IInstrumentKeyConfigsT
	{
		// Token: 0x1700D231 RID: 53809
		// (get) Token: 0x06031BEA RID: 203754 RVA: 0x006BC289 File Offset: 0x006BA489
		// (set) Token: 0x06031BEB RID: 203755 RVA: 0x006BC291 File Offset: 0x006BA491
		public List<IInstrumentKeyAttributeT> Grids { get; set; }

		// Token: 0x1700D232 RID: 53810
		// (get) Token: 0x06031BEC RID: 203756 RVA: 0x006BC29A File Offset: 0x006BA49A
		// (set) Token: 0x06031BED RID: 203757 RVA: 0x006BC2A2 File Offset: 0x006BA4A2
		public IInstrumentBoardSizeT BoardSize { get; set; }

		// Token: 0x06031BEE RID: 203758 RVA: 0x006BC2AB File Offset: 0x006BA4AB
		public IInstrumentKeyConfigsT()
		{
			this.Grids = null;
			this.BoardSize = null;
		}
	}
}
