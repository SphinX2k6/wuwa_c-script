using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007984 RID: 31108
	public class IStartFlowTemplateT
	{
		// Token: 0x1700E419 RID: 58393
		// (get) Token: 0x06036CAE RID: 224430 RVA: 0x007543ED File Offset: 0x007525ED
		// (set) Token: 0x06036CAF RID: 224431 RVA: 0x007543F5 File Offset: 0x007525F5
		public IFlowTemplateModeT TemplateMode { get; set; }

		// Token: 0x1700E41A RID: 58394
		// (get) Token: 0x06036CB0 RID: 224432 RVA: 0x007543FE File Offset: 0x007525FE
		// (set) Token: 0x06036CB1 RID: 224433 RVA: 0x00754406 File Offset: 0x00752606
		public IPosAT TargetPos { get; set; }

		// Token: 0x1700E41B RID: 58395
		// (get) Token: 0x06036CB2 RID: 224434 RVA: 0x0075440F File Offset: 0x0075260F
		// (set) Token: 0x06036CB3 RID: 224435 RVA: 0x00754417 File Offset: 0x00752617
		public List<int> ActorIdArray { get; set; }

		// Token: 0x1700E41C RID: 58396
		// (get) Token: 0x06036CB4 RID: 224436 RVA: 0x00754420 File Offset: 0x00752620
		// (set) Token: 0x06036CB5 RID: 224437 RVA: 0x00754428 File Offset: 0x00752628
		public List<int> TalkerIds { get; set; }

		// Token: 0x1700E41D RID: 58397
		// (get) Token: 0x06036CB6 RID: 224438 RVA: 0x00754431 File Offset: 0x00752631
		// (set) Token: 0x06036CB7 RID: 224439 RVA: 0x00754439 File Offset: 0x00752639
		public byte NullMask { get; set; }

		// Token: 0x06036CB8 RID: 224440 RVA: 0x00754442 File Offset: 0x00752642
		public IStartFlowTemplateT()
		{
			this.TemplateMode = null;
			this.TargetPos = null;
			this.ActorIdArray = null;
			this.TalkerIds = null;
			this.NullMask = 0;
		}
	}
}
