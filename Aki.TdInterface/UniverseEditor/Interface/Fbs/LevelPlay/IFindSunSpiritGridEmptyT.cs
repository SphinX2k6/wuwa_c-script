using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004924 RID: 18724
	public class IFindSunSpiritGridEmptyT
	{
		// Token: 0x1700826C RID: 33388
		// (get) Token: 0x0601BC77 RID: 113783 RVA: 0x003ED67A File Offset: 0x003EB87A
		// (set) Token: 0x0601BC78 RID: 113784 RVA: 0x003ED682 File Offset: 0x003EB882
		public EFindSunSpiritGridType Type { get; set; }

		// Token: 0x1700826D RID: 33389
		// (get) Token: 0x0601BC79 RID: 113785 RVA: 0x003ED68B File Offset: 0x003EB88B
		// (set) Token: 0x0601BC7A RID: 113786 RVA: 0x003ED693 File Offset: 0x003EB893
		public bool SpreadDevice { get; set; }

		// Token: 0x1700826E RID: 33390
		// (get) Token: 0x0601BC7B RID: 113787 RVA: 0x003ED69C File Offset: 0x003EB89C
		// (set) Token: 0x0601BC7C RID: 113788 RVA: 0x003ED6A4 File Offset: 0x003EB8A4
		public byte NullMask { get; set; }

		// Token: 0x0601BC7D RID: 113789 RVA: 0x003ED6AD File Offset: 0x003EB8AD
		public IFindSunSpiritGridEmptyT()
		{
			this.Type = EFindSunSpiritGridType.Empty;
			this.SpreadDevice = false;
			this.NullMask = 0;
		}
	}
}
