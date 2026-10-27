using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004029 RID: 16425
	public class IQuestScheduleMeetConditionT
	{
		// Token: 0x1700738D RID: 29581
		// (get) Token: 0x06017C04 RID: 97284 RVA: 0x0036D3D5 File Offset: 0x0036B5D5
		// (set) Token: 0x06017C05 RID: 97285 RVA: 0x0036D3DD File Offset: 0x0036B5DD
		public EQuestScheduleType Type { get; set; }

		// Token: 0x1700738E RID: 29582
		// (get) Token: 0x06017C06 RID: 97286 RVA: 0x0036D3E6 File Offset: 0x0036B5E6
		// (set) Token: 0x06017C07 RID: 97287 RVA: 0x0036D3EE File Offset: 0x0036B5EE
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700738F RID: 29583
		// (get) Token: 0x06017C08 RID: 97288 RVA: 0x0036D3F7 File Offset: 0x0036B5F7
		// (set) Token: 0x06017C09 RID: 97289 RVA: 0x0036D3FF File Offset: 0x0036B5FF
		public List<TVarRefUnion> Vars { get; set; }

		// Token: 0x17007390 RID: 29584
		// (get) Token: 0x06017C0A RID: 97290 RVA: 0x0036D408 File Offset: 0x0036B608
		// (set) Token: 0x06017C0B RID: 97291 RVA: 0x0036D410 File Offset: 0x0036B610
		public ETimeLeftIconType IconType { get; set; }

		// Token: 0x17007391 RID: 29585
		// (get) Token: 0x06017C0C RID: 97292 RVA: 0x0036D419 File Offset: 0x0036B619
		// (set) Token: 0x06017C0D RID: 97293 RVA: 0x0036D421 File Offset: 0x0036B621
		public byte NullMask { get; set; }

		// Token: 0x06017C0E RID: 97294 RVA: 0x0036D42A File Offset: 0x0036B62A
		public IQuestScheduleMeetConditionT()
		{
			this.Type = EQuestScheduleType.None;
			this.Condition = null;
			this.Vars = null;
			this.IconType = ETimeLeftIconType.AkiWorld;
			this.NullMask = 0;
		}
	}
}
