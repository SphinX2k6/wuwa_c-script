using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005702 RID: 22274
	public class IPatrolT
	{
		// Token: 0x1700A5D6 RID: 42454
		// (get) Token: 0x060253D1 RID: 152529 RVA: 0x0052391C File Offset: 0x00521B1C
		// (set) Token: 0x060253D2 RID: 152530 RVA: 0x00523924 File Offset: 0x00521B24
		public bool Disabled { get; set; }

		// Token: 0x1700A5D7 RID: 42455
		// (get) Token: 0x060253D3 RID: 152531 RVA: 0x0052392D File Offset: 0x00521B2D
		// (set) Token: 0x060253D4 RID: 152532 RVA: 0x00523935 File Offset: 0x00521B35
		public int SplineEntityId { get; set; }

		// Token: 0x1700A5D8 RID: 42456
		// (get) Token: 0x060253D5 RID: 152533 RVA: 0x0052393E File Offset: 0x00521B3E
		// (set) Token: 0x060253D6 RID: 152534 RVA: 0x00523946 File Offset: 0x00521B46
		public List<int> SplineEntityIds { get; set; }

		// Token: 0x1700A5D9 RID: 42457
		// (get) Token: 0x060253D7 RID: 152535 RVA: 0x0052394F File Offset: 0x00521B4F
		// (set) Token: 0x060253D8 RID: 152536 RVA: 0x00523957 File Offset: 0x00521B57
		public bool IsCircle { get; set; }

		// Token: 0x1700A5DA RID: 42458
		// (get) Token: 0x060253D9 RID: 152537 RVA: 0x00523960 File Offset: 0x00521B60
		// (set) Token: 0x060253DA RID: 152538 RVA: 0x00523968 File Offset: 0x00521B68
		public List<IPatrolActionT> Actions { get; set; }

		// Token: 0x1700A5DB RID: 42459
		// (get) Token: 0x060253DB RID: 152539 RVA: 0x00523971 File Offset: 0x00521B71
		// (set) Token: 0x060253DC RID: 152540 RVA: 0x00523979 File Offset: 0x00521B79
		public byte NullMask { get; set; }

		// Token: 0x060253DD RID: 152541 RVA: 0x00523982 File Offset: 0x00521B82
		public IPatrolT()
		{
			this.Disabled = false;
			this.SplineEntityId = 0;
			this.SplineEntityIds = null;
			this.IsCircle = false;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
