using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF6 RID: 28662
	public class ISetGlobalTimeScaleT
	{
		// Token: 0x1700D4ED RID: 54509
		// (get) Token: 0x06032B38 RID: 207672 RVA: 0x006D764B File Offset: 0x006D584B
		// (set) Token: 0x06032B39 RID: 207673 RVA: 0x006D7653 File Offset: 0x006D5853
		public ETimeScaleType Type { get; set; }

		// Token: 0x1700D4EE RID: 54510
		// (get) Token: 0x06032B3A RID: 207674 RVA: 0x006D765C File Offset: 0x006D585C
		// (set) Token: 0x06032B3B RID: 207675 RVA: 0x006D7664 File Offset: 0x006D5864
		public TSetGlobalTimeScaleUnion Config { get; set; }

		// Token: 0x06032B3C RID: 207676 RVA: 0x006D766D File Offset: 0x006D586D
		public ISetGlobalTimeScaleT()
		{
			this.Type = ETimeScaleType.Global;
			this.Config = null;
		}
	}
}
