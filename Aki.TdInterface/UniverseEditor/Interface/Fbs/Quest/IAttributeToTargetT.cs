using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D23 RID: 15651
	public class IAttributeToTargetT
	{
		// Token: 0x17006B5A RID: 27482
		// (get) Token: 0x0601599F RID: 88479 RVA: 0x0031E642 File Offset: 0x0031C842
		// (set) Token: 0x060159A0 RID: 88480 RVA: 0x0031E64A File Offset: 0x0031C84A
		public EAttributeToTarget Type { get; set; }

		// Token: 0x060159A1 RID: 88481 RVA: 0x0031E653 File Offset: 0x0031C853
		public IAttributeToTargetT()
		{
			this.Type = EAttributeToTarget.Health;
		}
	}
}
