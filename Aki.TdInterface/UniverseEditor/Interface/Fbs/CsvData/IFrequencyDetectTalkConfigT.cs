using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D98 RID: 19864
	public class IFrequencyDetectTalkConfigT
	{
		// Token: 0x17008E24 RID: 36388
		// (get) Token: 0x0601ECF5 RID: 126197 RVA: 0x0044E9EF File Offset: 0x0044CBEF
		// (set) Token: 0x0601ECF6 RID: 126198 RVA: 0x0044E9F7 File Offset: 0x0044CBF7
		public EFrequencyDetectTalkTriggerTiming TriggerTiming { get; set; }

		// Token: 0x17008E25 RID: 36389
		// (get) Token: 0x0601ECF7 RID: 126199 RVA: 0x0044EA00 File Offset: 0x0044CC00
		// (set) Token: 0x0601ECF8 RID: 126200 RVA: 0x0044EA08 File Offset: 0x0044CC08
		public string LineId { get; set; }

		// Token: 0x17008E26 RID: 36390
		// (get) Token: 0x0601ECF9 RID: 126201 RVA: 0x0044EA11 File Offset: 0x0044CC11
		// (set) Token: 0x0601ECFA RID: 126202 RVA: 0x0044EA19 File Offset: 0x0044CC19
		public bool IsBlockPlayerOperation { get; set; }

		// Token: 0x17008E27 RID: 36391
		// (get) Token: 0x0601ECFB RID: 126203 RVA: 0x0044EA22 File Offset: 0x0044CC22
		// (set) Token: 0x0601ECFC RID: 126204 RVA: 0x0044EA2A File Offset: 0x0044CC2A
		public ICommonTalkMessageT Message { get; set; }

		// Token: 0x0601ECFD RID: 126205 RVA: 0x0044EA33 File Offset: 0x0044CC33
		public IFrequencyDetectTalkConfigT()
		{
			this.TriggerTiming = EFrequencyDetectTalkTriggerTiming.AiStartPaint;
			this.LineId = null;
			this.IsBlockPlayerOperation = false;
			this.Message = null;
		}
	}
}
