using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052EF RID: 21231
	public class IGazeConditionT
	{
		// Token: 0x17009BD3 RID: 39891
		// (get) Token: 0x06022A9A RID: 141978 RVA: 0x004CDEC1 File Offset: 0x004CC0C1
		// (set) Token: 0x06022A9B RID: 141979 RVA: 0x004CDEC9 File Offset: 0x004CC0C9
		public int GazeInDistance { get; set; }

		// Token: 0x17009BD4 RID: 39892
		// (get) Token: 0x06022A9C RID: 141980 RVA: 0x004CDED2 File Offset: 0x004CC0D2
		// (set) Token: 0x06022A9D RID: 141981 RVA: 0x004CDEDA File Offset: 0x004CC0DA
		public IConeTriggerShapeT ScanRange { get; set; }

		// Token: 0x17009BD5 RID: 39893
		// (get) Token: 0x06022A9E RID: 141982 RVA: 0x004CDEE3 File Offset: 0x004CC0E3
		// (set) Token: 0x06022A9F RID: 141983 RVA: 0x004CDEEB File Offset: 0x004CC0EB
		public byte NullMask { get; set; }

		// Token: 0x06022AA0 RID: 141984 RVA: 0x004CDEF4 File Offset: 0x004CC0F4
		public IGazeConditionT()
		{
			this.GazeInDistance = 0;
			this.ScanRange = null;
			this.NullMask = 0;
		}
	}
}
