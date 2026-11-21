using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB2 RID: 28338
	public class IFlowTemplateTransitionEffectT
	{
		// Token: 0x1700CFDD RID: 53213
		// (get) Token: 0x0603106B RID: 200811 RVA: 0x006A63CA File Offset: 0x006A45CA
		// (set) Token: 0x0603106C RID: 200812 RVA: 0x006A63D2 File Offset: 0x006A45D2
		public EFlowTemplateTransitionEffectType Type { get; set; }

		// Token: 0x0603106D RID: 200813 RVA: 0x006A63DB File Offset: 0x006A45DB
		public IFlowTemplateTransitionEffectT()
		{
			this.Type = EFlowTemplateTransitionEffectType.Blur;
		}
	}
}
