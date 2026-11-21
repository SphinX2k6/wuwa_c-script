using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B25 RID: 27429
	public class ICompleteGuideT
	{
		// Token: 0x1700C96C RID: 51564
		// (get) Token: 0x0602F2F8 RID: 193272 RVA: 0x006716AF File Offset: 0x0066F8AF
		// (set) Token: 0x0602F2F9 RID: 193273 RVA: 0x006716B7 File Offset: 0x0066F8B7
		public EGuideTriggerType Type { get; set; }

		// Token: 0x1700C96D RID: 51565
		// (get) Token: 0x0602F2FA RID: 193274 RVA: 0x006716C0 File Offset: 0x0066F8C0
		// (set) Token: 0x0602F2FB RID: 193275 RVA: 0x006716C8 File Offset: 0x0066F8C8
		public List<ICondition2_UnionUnion> Conditions { get; set; }

		// Token: 0x1700C96E RID: 51566
		// (get) Token: 0x0602F2FC RID: 193276 RVA: 0x006716D1 File Offset: 0x0066F8D1
		// (set) Token: 0x0602F2FD RID: 193277 RVA: 0x006716D9 File Offset: 0x0066F8D9
		public int GuideId { get; set; }

		// Token: 0x1700C96F RID: 51567
		// (get) Token: 0x0602F2FE RID: 193278 RVA: 0x006716E2 File Offset: 0x0066F8E2
		// (set) Token: 0x0602F2FF RID: 193279 RVA: 0x006716EA File Offset: 0x0066F8EA
		public byte NullMask { get; set; }

		// Token: 0x0602F300 RID: 193280 RVA: 0x006716F3 File Offset: 0x0066F8F3
		public ICompleteGuideT()
		{
			this.Type = EGuideTriggerType.BeginnerGuide;
			this.Conditions = null;
			this.GuideId = 0;
			this.NullMask = 0;
		}
	}
}
