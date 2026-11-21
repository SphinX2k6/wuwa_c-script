using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041A6 RID: 16806
	public class ICiacconaAvgBoardT
	{
		// Token: 0x17007216 RID: 29206
		// (get) Token: 0x06017352 RID: 95058 RVA: 0x00350312 File Offset: 0x0034E512
		// (set) Token: 0x06017353 RID: 95059 RVA: 0x0035031A File Offset: 0x0034E51A
		public EShowUiType Type { get; set; }

		// Token: 0x17007217 RID: 29207
		// (get) Token: 0x06017354 RID: 95060 RVA: 0x00350323 File Offset: 0x0034E523
		// (set) Token: 0x06017355 RID: 95061 RVA: 0x0035032B File Offset: 0x0034E52B
		public int EndingId { get; set; }

		// Token: 0x17007218 RID: 29208
		// (get) Token: 0x06017356 RID: 95062 RVA: 0x00350334 File Offset: 0x0034E534
		// (set) Token: 0x06017357 RID: 95063 RVA: 0x0035033C File Offset: 0x0034E53C
		public byte NullMask { get; set; }

		// Token: 0x06017358 RID: 95064 RVA: 0x00350345 File Offset: 0x0034E545
		public ICiacconaAvgBoardT()
		{
			this.Type = EShowUiType.All;
			this.EndingId = 0;
			this.NullMask = 0;
		}
	}
}
