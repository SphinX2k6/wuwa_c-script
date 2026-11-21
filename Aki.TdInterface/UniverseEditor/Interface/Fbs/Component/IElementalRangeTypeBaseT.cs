using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569E RID: 22174
	public class IElementalRangeTypeBaseT
	{
		// Token: 0x17009F7B RID: 40827
		// (get) Token: 0x060237F2 RID: 145394 RVA: 0x004E1FF6 File Offset: 0x004E01F6
		// (set) Token: 0x060237F3 RID: 145395 RVA: 0x004E1FFE File Offset: 0x004E01FE
		public EElementalRangeType Type { get; set; }

		// Token: 0x060237F4 RID: 145396 RVA: 0x004E2007 File Offset: 0x004E0207
		public IElementalRangeTypeBaseT()
		{
			this.Type = EElementalRangeType.BaseShape;
		}
	}
}
