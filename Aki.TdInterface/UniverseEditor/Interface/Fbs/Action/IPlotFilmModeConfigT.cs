using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D54 RID: 27988
	public class IPlotFilmModeConfigT
	{
		// Token: 0x1700D0BD RID: 53437
		// (get) Token: 0x060316B8 RID: 202424 RVA: 0x006B38B4 File Offset: 0x006B1AB4
		// (set) Token: 0x060316B9 RID: 202425 RVA: 0x006B38BC File Offset: 0x006B1ABC
		public bool IsAdaptFilmAspectRatio { get; set; }

		// Token: 0x1700D0BE RID: 53438
		// (get) Token: 0x060316BA RID: 202426 RVA: 0x006B38C5 File Offset: 0x006B1AC5
		// (set) Token: 0x060316BB RID: 202427 RVA: 0x006B38CD File Offset: 0x006B1ACD
		public byte NullMask { get; set; }

		// Token: 0x060316BC RID: 202428 RVA: 0x006B38D6 File Offset: 0x006B1AD6
		public IPlotFilmModeConfigT()
		{
			this.IsAdaptFilmAspectRatio = false;
			this.NullMask = 0;
		}
	}
}
