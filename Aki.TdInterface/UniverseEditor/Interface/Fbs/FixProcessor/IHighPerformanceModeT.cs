using System;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004761 RID: 18273
	public class IHighPerformanceModeT
	{
		// Token: 0x1700831A RID: 33562
		// (get) Token: 0x0601C21B RID: 115227 RVA: 0x003FC492 File Offset: 0x003FA692
		// (set) Token: 0x0601C21C RID: 115228 RVA: 0x003FC49A File Offset: 0x003FA69A
		public EPerformanceMode Type { get; set; }

		// Token: 0x0601C21D RID: 115229 RVA: 0x003FC4A3 File Offset: 0x003FA6A3
		public IHighPerformanceModeT()
		{
			this.Type = EPerformanceMode.High;
		}
	}
}
