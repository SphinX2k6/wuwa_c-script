using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005414 RID: 21524
	public class IInhaledPerResultTypeT
	{
		// Token: 0x17009E5E RID: 40542
		// (get) Token: 0x060235AB RID: 144811 RVA: 0x004E4AA6 File Offset: 0x004E2CA6
		// (set) Token: 0x060235AC RID: 144812 RVA: 0x004E4AAE File Offset: 0x004E2CAE
		public EInhaledPerResultType Type { get; set; }

		// Token: 0x060235AD RID: 144813 RVA: 0x004E4AB7 File Offset: 0x004E2CB7
		public IInhaledPerResultTypeT()
		{
			this.Type = EInhaledPerResultType.DestroySelf;
		}
	}
}
