using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050D3 RID: 20691
	public class IDynamicAttachTargetT
	{
		// Token: 0x17009697 RID: 38551
		// (get) Token: 0x060214A3 RID: 136355 RVA: 0x0049F9E6 File Offset: 0x0049DBE6
		// (set) Token: 0x060214A4 RID: 136356 RVA: 0x0049F9EE File Offset: 0x0049DBEE
		public EAttachType Type { get; set; }

		// Token: 0x060214A5 RID: 136357 RVA: 0x0049F9F7 File Offset: 0x0049DBF7
		public IDynamicAttachTargetT()
		{
			this.Type = EAttachType.Actor;
		}
	}
}
