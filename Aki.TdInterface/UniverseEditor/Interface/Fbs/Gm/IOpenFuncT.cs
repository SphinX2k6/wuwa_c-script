using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AE4 RID: 19172
	public class IOpenFuncT
	{
		// Token: 0x17008664 RID: 34404
		// (get) Token: 0x0601CE26 RID: 118310 RVA: 0x00410DCC File Offset: 0x0040EFCC
		// (set) Token: 0x0601CE27 RID: 118311 RVA: 0x00410DD4 File Offset: 0x0040EFD4
		public EGmCommand Type { get; set; }

		// Token: 0x17008665 RID: 34405
		// (get) Token: 0x0601CE28 RID: 118312 RVA: 0x00410DDD File Offset: 0x0040EFDD
		// (set) Token: 0x0601CE29 RID: 118313 RVA: 0x00410DE5 File Offset: 0x0040EFE5
		public int FuncId { get; set; }

		// Token: 0x0601CE2A RID: 118314 RVA: 0x00410DEE File Offset: 0x0040EFEE
		public IOpenFuncT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
			this.FuncId = 0;
		}
	}
}
