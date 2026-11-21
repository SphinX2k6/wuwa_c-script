using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006158 RID: 24920
	public class IVisionDisplayComponentT
	{
		// Token: 0x1700B99F RID: 47519
		// (get) Token: 0x0602A4C0 RID: 173248 RVA: 0x005C563D File Offset: 0x005C383D
		// (set) Token: 0x0602A4C1 RID: 173249 RVA: 0x005C5645 File Offset: 0x005C3845
		public bool Disabled { get; set; }

		// Token: 0x1700B9A0 RID: 47520
		// (get) Token: 0x0602A4C2 RID: 173250 RVA: 0x005C564E File Offset: 0x005C384E
		// (set) Token: 0x0602A4C3 RID: 173251 RVA: 0x005C5656 File Offset: 0x005C3856
		public bool IsNeedInView { get; set; }

		// Token: 0x1700B9A1 RID: 47521
		// (get) Token: 0x0602A4C4 RID: 173252 RVA: 0x005C565F File Offset: 0x005C385F
		// (set) Token: 0x0602A4C5 RID: 173253 RVA: 0x005C5667 File Offset: 0x005C3867
		public bool IsBanOcclusion { get; set; }

		// Token: 0x1700B9A2 RID: 47522
		// (get) Token: 0x0602A4C6 RID: 173254 RVA: 0x005C5670 File Offset: 0x005C3870
		// (set) Token: 0x0602A4C7 RID: 173255 RVA: 0x005C5678 File Offset: 0x005C3878
		public int ViewEntityId { get; set; }

		// Token: 0x1700B9A3 RID: 47523
		// (get) Token: 0x0602A4C8 RID: 173256 RVA: 0x005C5681 File Offset: 0x005C3881
		// (set) Token: 0x0602A4C9 RID: 173257 RVA: 0x005C5689 File Offset: 0x005C3889
		public bool IsBornInTargetPoint { get; set; }

		// Token: 0x1700B9A4 RID: 47524
		// (get) Token: 0x0602A4CA RID: 173258 RVA: 0x005C5692 File Offset: 0x005C3892
		// (set) Token: 0x0602A4CB RID: 173259 RVA: 0x005C569A File Offset: 0x005C389A
		public IConditionGroupT Condition { get; set; }

		// Token: 0x1700B9A5 RID: 47525
		// (get) Token: 0x0602A4CC RID: 173260 RVA: 0x005C56A3 File Offset: 0x005C38A3
		// (set) Token: 0x0602A4CD RID: 173261 RVA: 0x005C56AB File Offset: 0x005C38AB
		public byte NullMask { get; set; }

		// Token: 0x0602A4CE RID: 173262 RVA: 0x005C56B4 File Offset: 0x005C38B4
		public IVisionDisplayComponentT()
		{
			this.Disabled = false;
			this.IsNeedInView = false;
			this.IsBanOcclusion = false;
			this.ViewEntityId = 0;
			this.IsBornInTargetPoint = false;
			this.Condition = null;
			this.NullMask = 0;
		}
	}
}
