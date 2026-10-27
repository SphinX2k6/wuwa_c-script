using System;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004767 RID: 18279
	public class IPerformanceModeSettingT
	{
		// Token: 0x17008320 RID: 33568
		// (get) Token: 0x0601C245 RID: 115269 RVA: 0x003FC926 File Offset: 0x003FAB26
		// (set) Token: 0x0601C246 RID: 115270 RVA: 0x003FC92E File Offset: 0x003FAB2E
		public EPerformanceMode Type { get; set; }

		// Token: 0x0601C247 RID: 115271 RVA: 0x003FC937 File Offset: 0x003FAB37
		public IPerformanceModeSettingT()
		{
			this.Type = EPerformanceMode.High;
		}
	}
}
