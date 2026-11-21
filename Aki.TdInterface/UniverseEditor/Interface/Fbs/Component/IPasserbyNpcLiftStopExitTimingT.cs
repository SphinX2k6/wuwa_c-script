using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C91 RID: 23697
	public class IPasserbyNpcLiftStopExitTimingT
	{
		// Token: 0x1700AE11 RID: 44561
		// (get) Token: 0x060274EF RID: 161007 RVA: 0x00561DFF File Offset: 0x0055FFFF
		// (set) Token: 0x060274F0 RID: 161008 RVA: 0x00561E07 File Offset: 0x00560007
		public EPasserbyNpcExitTimingType Type { get; set; }

		// Token: 0x1700AE12 RID: 44562
		// (get) Token: 0x060274F1 RID: 161009 RVA: 0x00561E10 File Offset: 0x00560010
		// (set) Token: 0x060274F2 RID: 161010 RVA: 0x00561E18 File Offset: 0x00560018
		public IPasserbyNpcIntervalExitT IntervalExit { get; set; }

		// Token: 0x060274F3 RID: 161011 RVA: 0x00561E21 File Offset: 0x00560021
		public IPasserbyNpcLiftStopExitTimingT()
		{
			this.Type = EPasserbyNpcExitTimingType.LiftStop;
			this.IntervalExit = null;
		}
	}
}
