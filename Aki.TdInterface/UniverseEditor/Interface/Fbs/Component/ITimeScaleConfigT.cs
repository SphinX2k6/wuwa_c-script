using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200609C RID: 24732
	public class ITimeScaleConfigT
	{
		// Token: 0x1700B7DD RID: 47069
		// (get) Token: 0x06029D61 RID: 171361 RVA: 0x005B6262 File Offset: 0x005B4462
		// (set) Token: 0x06029D62 RID: 171362 RVA: 0x005B626A File Offset: 0x005B446A
		public bool IgnoreGlobalTimeScale { get; set; }

		// Token: 0x06029D63 RID: 171363 RVA: 0x005B6273 File Offset: 0x005B4473
		public ITimeScaleConfigT()
		{
			this.IgnoreGlobalTimeScale = false;
		}
	}
}
