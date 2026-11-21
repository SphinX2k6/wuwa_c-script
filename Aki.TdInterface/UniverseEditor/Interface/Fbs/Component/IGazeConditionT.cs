using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005872 RID: 22642
	public class IGazeConditionT
	{
		// Token: 0x1700A404 RID: 41988
		// (get) Token: 0x06024B34 RID: 150324 RVA: 0x0050A9ED File Offset: 0x00508BED
		// (set) Token: 0x06024B35 RID: 150325 RVA: 0x0050A9F5 File Offset: 0x00508BF5
		public int GazeInDistance { get; set; }

		// Token: 0x1700A405 RID: 41989
		// (get) Token: 0x06024B36 RID: 150326 RVA: 0x0050A9FE File Offset: 0x00508BFE
		// (set) Token: 0x06024B37 RID: 150327 RVA: 0x0050AA06 File Offset: 0x00508C06
		public IConeTriggerShapeT ScanRange { get; set; }

		// Token: 0x1700A406 RID: 41990
		// (get) Token: 0x06024B38 RID: 150328 RVA: 0x0050AA0F File Offset: 0x00508C0F
		// (set) Token: 0x06024B39 RID: 150329 RVA: 0x0050AA17 File Offset: 0x00508C17
		public byte NullMask { get; set; }

		// Token: 0x06024B3A RID: 150330 RVA: 0x0050AA20 File Offset: 0x00508C20
		public IGazeConditionT()
		{
			this.GazeInDistance = 0;
			this.ScanRange = null;
			this.NullMask = 0;
		}
	}
}
