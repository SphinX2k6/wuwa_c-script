using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C85 RID: 23685
	public class IPasserbyNpcIntervalExitT
	{
		// Token: 0x1700AE03 RID: 44547
		// (get) Token: 0x060274A7 RID: 160935 RVA: 0x005616A5 File Offset: 0x0055F8A5
		// (set) Token: 0x060274A8 RID: 160936 RVA: 0x005616AD File Offset: 0x0055F8AD
		public IPasserbyNpcPerNpcRandomExitIntervalT IntervalType { get; set; }

		// Token: 0x060274A9 RID: 160937 RVA: 0x005616B6 File Offset: 0x0055F8B6
		public IPasserbyNpcIntervalExitT()
		{
			this.IntervalType = null;
		}
	}
}
