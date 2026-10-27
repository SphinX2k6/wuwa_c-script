using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E4E RID: 20046
	public class IActivateSpecifiedPieceConfigT
	{
		// Token: 0x17008F76 RID: 36726
		// (get) Token: 0x0601F76C RID: 128876 RVA: 0x00462203 File Offset: 0x00460403
		// (set) Token: 0x0601F76D RID: 128877 RVA: 0x0046220B File Offset: 0x0046040B
		public IJigsawConfigT Jigsaw { get; set; }

		// Token: 0x17008F77 RID: 36727
		// (get) Token: 0x0601F76E RID: 128878 RVA: 0x00462214 File Offset: 0x00460414
		// (set) Token: 0x0601F76F RID: 128879 RVA: 0x0046221C File Offset: 0x0046041C
		public string SelfState { get; set; }

		// Token: 0x0601F770 RID: 128880 RVA: 0x00462225 File Offset: 0x00460425
		public IActivateSpecifiedPieceConfigT()
		{
			this.Jigsaw = null;
			this.SelfState = null;
		}
	}
}
