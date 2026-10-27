using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AF RID: 29103
	public class IStartFlowTemplateT
	{
		// Token: 0x1700D822 RID: 55330
		// (get) Token: 0x060339B0 RID: 211376 RVA: 0x006F3121 File Offset: 0x006F1321
		// (set) Token: 0x060339B1 RID: 211377 RVA: 0x006F3129 File Offset: 0x006F1329
		public IFlowTemplateModeT TemplateMode { get; set; }

		// Token: 0x1700D823 RID: 55331
		// (get) Token: 0x060339B2 RID: 211378 RVA: 0x006F3132 File Offset: 0x006F1332
		// (set) Token: 0x060339B3 RID: 211379 RVA: 0x006F313A File Offset: 0x006F133A
		public IPosAT TargetPos { get; set; }

		// Token: 0x1700D824 RID: 55332
		// (get) Token: 0x060339B4 RID: 211380 RVA: 0x006F3143 File Offset: 0x006F1343
		// (set) Token: 0x060339B5 RID: 211381 RVA: 0x006F314B File Offset: 0x006F134B
		public List<int> ActorIdArray { get; set; }

		// Token: 0x1700D825 RID: 55333
		// (get) Token: 0x060339B6 RID: 211382 RVA: 0x006F3154 File Offset: 0x006F1354
		// (set) Token: 0x060339B7 RID: 211383 RVA: 0x006F315C File Offset: 0x006F135C
		public List<int> TalkerIds { get; set; }

		// Token: 0x1700D826 RID: 55334
		// (get) Token: 0x060339B8 RID: 211384 RVA: 0x006F3165 File Offset: 0x006F1365
		// (set) Token: 0x060339B9 RID: 211385 RVA: 0x006F316D File Offset: 0x006F136D
		public byte NullMask { get; set; }

		// Token: 0x060339BA RID: 211386 RVA: 0x006F3176 File Offset: 0x006F1376
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
