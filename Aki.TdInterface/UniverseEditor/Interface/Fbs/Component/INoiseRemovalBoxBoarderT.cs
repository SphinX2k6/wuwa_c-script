using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005603 RID: 22019
	public class INoiseRemovalBoxBoarderT
	{
		// Token: 0x1700A2EB RID: 41707
		// (get) Token: 0x06024891 RID: 149649 RVA: 0x0050ABB0 File Offset: 0x00508DB0
		// (set) Token: 0x06024892 RID: 149650 RVA: 0x0050ABB8 File Offset: 0x00508DB8
		public ENoiseRemovalBoarderShape Type { get; set; }

		// Token: 0x1700A2EC RID: 41708
		// (get) Token: 0x06024893 RID: 149651 RVA: 0x0050ABC1 File Offset: 0x00508DC1
		// (set) Token: 0x06024894 RID: 149652 RVA: 0x0050ABC9 File Offset: 0x00508DC9
		public IVectorInfoT BoxExtendPositive { get; set; }

		// Token: 0x1700A2ED RID: 41709
		// (get) Token: 0x06024895 RID: 149653 RVA: 0x0050ABD2 File Offset: 0x00508DD2
		// (set) Token: 0x06024896 RID: 149654 RVA: 0x0050ABDA File Offset: 0x00508DDA
		public IVectorInfoT BoxExtendNegative { get; set; }

		// Token: 0x06024897 RID: 149655 RVA: 0x0050ABE3 File Offset: 0x00508DE3
		public INoiseRemovalBoxBoarderT()
		{
			this.Type = ENoiseRemovalBoarderShape.Box;
			this.BoxExtendPositive = null;
			this.BoxExtendNegative = null;
		}
	}
}
