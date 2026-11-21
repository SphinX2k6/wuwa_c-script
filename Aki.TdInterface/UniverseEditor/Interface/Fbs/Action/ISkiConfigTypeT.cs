using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078EE RID: 30958
	public class ISkiConfigTypeT
	{
		// Token: 0x1700E330 RID: 58160
		// (get) Token: 0x06036849 RID: 223305 RVA: 0x0074C7FF File Offset: 0x0074A9FF
		// (set) Token: 0x0603684A RID: 223306 RVA: 0x0074C807 File Offset: 0x0074AA07
		public ESkiConfig Type { get; set; }

		// Token: 0x1700E331 RID: 58161
		// (get) Token: 0x0603684B RID: 223307 RVA: 0x0074C810 File Offset: 0x0074AA10
		// (set) Token: 0x0603684C RID: 223308 RVA: 0x0074C818 File Offset: 0x0074AA18
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x0603684D RID: 223309 RVA: 0x0074C821 File Offset: 0x0074AA21
		public ISkiConfigTypeT()
		{
			this.Type = ESkiConfig.Open;
			this.Target = null;
		}
	}
}
