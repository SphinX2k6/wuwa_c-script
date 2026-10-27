using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CBF RID: 19647
	public class ISelfClientEventT
	{
		// Token: 0x17008EA5 RID: 36517
		// (get) Token: 0x0601F2D1 RID: 127697 RVA: 0x0045A672 File Offset: 0x00458872
		// (set) Token: 0x0601F2D2 RID: 127698 RVA: 0x0045A67A File Offset: 0x0045887A
		public EClientEventTarget Type { get; set; }

		// Token: 0x0601F2D3 RID: 127699 RVA: 0x0045A683 File Offset: 0x00458883
		public ISelfClientEventT()
		{
			this.Type = EClientEventTarget.Self;
		}
	}
}
