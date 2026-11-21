using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CA RID: 27082
	public class ICheckClimbT
	{
		// Token: 0x1700C749 RID: 51017
		// (get) Token: 0x0602E75D RID: 190301 RVA: 0x00656D9F File Offset: 0x00654F9F
		// (set) Token: 0x0602E75E RID: 190302 RVA: 0x00656DA7 File Offset: 0x00654FA7
		public IVectorInfoT Direction { get; set; }

		// Token: 0x1700C74A RID: 51018
		// (get) Token: 0x0602E75F RID: 190303 RVA: 0x00656DB0 File Offset: 0x00654FB0
		// (set) Token: 0x0602E760 RID: 190304 RVA: 0x00656DB8 File Offset: 0x00654FB8
		public int Distance { get; set; }

		// Token: 0x1700C74B RID: 51019
		// (get) Token: 0x0602E761 RID: 190305 RVA: 0x00656DC1 File Offset: 0x00654FC1
		// (set) Token: 0x0602E762 RID: 190306 RVA: 0x00656DC9 File Offset: 0x00654FC9
		public int FallBackClimbPointId { get; set; }

		// Token: 0x1700C74C RID: 51020
		// (get) Token: 0x0602E763 RID: 190307 RVA: 0x00656DD2 File Offset: 0x00654FD2
		// (set) Token: 0x0602E764 RID: 190308 RVA: 0x00656DDA File Offset: 0x00654FDA
		public byte NullMask { get; set; }

		// Token: 0x0602E765 RID: 190309 RVA: 0x00656DE3 File Offset: 0x00654FE3
		public ICheckClimbT()
		{
			this.Direction = null;
			this.Distance = 0;
			this.FallBackClimbPointId = 0;
			this.NullMask = 0;
		}
	}
}
