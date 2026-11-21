using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006149 RID: 24905
	public class IViewDistanceModeT
	{
		// Token: 0x1700B980 RID: 47488
		// (get) Token: 0x0602A436 RID: 173110 RVA: 0x005C43CA File Offset: 0x005C25CA
		// (set) Token: 0x0602A437 RID: 173111 RVA: 0x005C43D2 File Offset: 0x005C25D2
		public EViewDistanceType Type { get; set; }

		// Token: 0x0602A438 RID: 173112 RVA: 0x005C43DB File Offset: 0x005C25DB
		public IViewDistanceModeT()
		{
			this.Type = EViewDistanceType.Low;
		}
	}
}
