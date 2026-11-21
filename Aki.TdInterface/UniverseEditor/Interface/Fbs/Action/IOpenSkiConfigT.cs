using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007395 RID: 29589
	public class IOpenSkiConfigT
	{
		// Token: 0x1700D91B RID: 55579
		// (get) Token: 0x06033AF1 RID: 211697 RVA: 0x006F7F9D File Offset: 0x006F619D
		// (set) Token: 0x06033AF2 RID: 211698 RVA: 0x006F7FA5 File Offset: 0x006F61A5
		public ESkiConfig Type { get; set; }

		// Token: 0x1700D91C RID: 55580
		// (get) Token: 0x06033AF3 RID: 211699 RVA: 0x006F7FAE File Offset: 0x006F61AE
		// (set) Token: 0x06033AF4 RID: 211700 RVA: 0x006F7FB6 File Offset: 0x006F61B6
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700D91D RID: 55581
		// (get) Token: 0x06033AF5 RID: 211701 RVA: 0x006F7FBF File Offset: 0x006F61BF
		// (set) Token: 0x06033AF6 RID: 211702 RVA: 0x006F7FC7 File Offset: 0x006F61C7
		public string SkiConfig { get; set; }

		// Token: 0x06033AF7 RID: 211703 RVA: 0x006F7FD0 File Offset: 0x006F61D0
		public IOpenSkiConfigT()
		{
			this.Type = ESkiConfig.Open;
			this.Target = null;
			this.SkiConfig = null;
		}
	}
}
