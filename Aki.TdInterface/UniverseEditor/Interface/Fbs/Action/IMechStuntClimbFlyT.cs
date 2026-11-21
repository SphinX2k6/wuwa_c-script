using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B1 RID: 29105
	public class IMechStuntClimbFlyT
	{
		// Token: 0x1700D533 RID: 54579
		// (get) Token: 0x06032A16 RID: 207382 RVA: 0x006D76EA File Offset: 0x006D58EA
		// (set) Token: 0x06032A17 RID: 207383 RVA: 0x006D76F2 File Offset: 0x006D58F2
		public EMechStuntType Type { get; set; }

		// Token: 0x06032A18 RID: 207384 RVA: 0x006D76FB File Offset: 0x006D58FB
		public IMechStuntClimbFlyT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
