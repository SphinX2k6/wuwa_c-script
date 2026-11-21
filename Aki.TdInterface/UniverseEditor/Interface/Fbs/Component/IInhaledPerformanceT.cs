using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005997 RID: 22935
	public class IInhaledPerformanceT
	{
		// Token: 0x1700A695 RID: 42645
		// (get) Token: 0x06025651 RID: 153169 RVA: 0x00521956 File Offset: 0x0051FB56
		// (set) Token: 0x06025652 RID: 153170 RVA: 0x0052195E File Offset: 0x0051FB5E
		public float InhaledTime { get; set; }

		// Token: 0x06025653 RID: 153171 RVA: 0x00521967 File Offset: 0x0051FB67
		public IInhaledPerformanceT()
		{
			this.InhaledTime = 0f;
		}
	}
}
