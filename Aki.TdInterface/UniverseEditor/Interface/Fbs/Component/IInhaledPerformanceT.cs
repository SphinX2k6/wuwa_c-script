using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005411 RID: 21521
	public class IInhaledPerformanceT
	{
		// Token: 0x17009E5B RID: 40539
		// (get) Token: 0x06023599 RID: 144793 RVA: 0x004E492A File Offset: 0x004E2B2A
		// (set) Token: 0x0602359A RID: 144794 RVA: 0x004E4932 File Offset: 0x004E2B32
		public float InhaledTime { get; set; }

		// Token: 0x0602359B RID: 144795 RVA: 0x004E493B File Offset: 0x004E2B3B
		public IInhaledPerformanceT()
		{
			this.InhaledTime = 0f;
		}
	}
}
