using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062FD RID: 25341
	public class IChangeFlowTemplateT
	{
		// Token: 0x1700BD25 RID: 48421
		// (get) Token: 0x0602BD0D RID: 179469 RVA: 0x00606BC9 File Offset: 0x00604DC9
		// (set) Token: 0x0602BD0E RID: 179470 RVA: 0x00606BD1 File Offset: 0x00604DD1
		public IFlowTemplateModeT TemplateMode { get; set; }

		// Token: 0x1700BD26 RID: 48422
		// (get) Token: 0x0602BD0F RID: 179471 RVA: 0x00606BDA File Offset: 0x00604DDA
		// (set) Token: 0x0602BD10 RID: 179472 RVA: 0x00606BE2 File Offset: 0x00604DE2
		public IPosAT TargetPos { get; set; }

		// Token: 0x1700BD27 RID: 48423
		// (get) Token: 0x0602BD11 RID: 179473 RVA: 0x00606BEB File Offset: 0x00604DEB
		// (set) Token: 0x0602BD12 RID: 179474 RVA: 0x00606BF3 File Offset: 0x00604DF3
		public List<int> ActorIdArray { get; set; }

		// Token: 0x1700BD28 RID: 48424
		// (get) Token: 0x0602BD13 RID: 179475 RVA: 0x00606BFC File Offset: 0x00604DFC
		// (set) Token: 0x0602BD14 RID: 179476 RVA: 0x00606C04 File Offset: 0x00604E04
		public List<int> TalkerIds { get; set; }

		// Token: 0x1700BD29 RID: 48425
		// (get) Token: 0x0602BD15 RID: 179477 RVA: 0x00606C0D File Offset: 0x00604E0D
		// (set) Token: 0x0602BD16 RID: 179478 RVA: 0x00606C15 File Offset: 0x00604E15
		public byte NullMask { get; set; }

		// Token: 0x0602BD17 RID: 179479 RVA: 0x00606C1E File Offset: 0x00604E1E
		public IChangeFlowTemplateT()
		{
			this.TemplateMode = null;
			this.TargetPos = null;
			this.ActorIdArray = null;
			this.TalkerIds = null;
			this.NullMask = 0;
		}
	}
}
