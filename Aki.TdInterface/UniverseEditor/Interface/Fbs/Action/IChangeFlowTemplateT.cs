using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200696E RID: 26990
	public class IChangeFlowTemplateT
	{
		// Token: 0x1700C6AF RID: 50863
		// (get) Token: 0x0602E476 RID: 189558 RVA: 0x00651BD5 File Offset: 0x0064FDD5
		// (set) Token: 0x0602E477 RID: 189559 RVA: 0x00651BDD File Offset: 0x0064FDDD
		public IFlowTemplateModeT TemplateMode { get; set; }

		// Token: 0x1700C6B0 RID: 50864
		// (get) Token: 0x0602E478 RID: 189560 RVA: 0x00651BE6 File Offset: 0x0064FDE6
		// (set) Token: 0x0602E479 RID: 189561 RVA: 0x00651BEE File Offset: 0x0064FDEE
		public IPosAT TargetPos { get; set; }

		// Token: 0x1700C6B1 RID: 50865
		// (get) Token: 0x0602E47A RID: 189562 RVA: 0x00651BF7 File Offset: 0x0064FDF7
		// (set) Token: 0x0602E47B RID: 189563 RVA: 0x00651BFF File Offset: 0x0064FDFF
		public List<int> ActorIdArray { get; set; }

		// Token: 0x1700C6B2 RID: 50866
		// (get) Token: 0x0602E47C RID: 189564 RVA: 0x00651C08 File Offset: 0x0064FE08
		// (set) Token: 0x0602E47D RID: 189565 RVA: 0x00651C10 File Offset: 0x0064FE10
		public List<int> TalkerIds { get; set; }

		// Token: 0x1700C6B3 RID: 50867
		// (get) Token: 0x0602E47E RID: 189566 RVA: 0x00651C19 File Offset: 0x0064FE19
		// (set) Token: 0x0602E47F RID: 189567 RVA: 0x00651C21 File Offset: 0x0064FE21
		public byte NullMask { get; set; }

		// Token: 0x0602E480 RID: 189568 RVA: 0x00651C2A File Offset: 0x0064FE2A
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
