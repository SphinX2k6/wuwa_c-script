using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F87 RID: 16263
	public class IPhotographSubTargetAnyRoleT
	{
		// Token: 0x17007185 RID: 29061
		// (get) Token: 0x06017394 RID: 95124 RVA: 0x00359C1D File Offset: 0x00357E1D
		// (set) Token: 0x06017395 RID: 95125 RVA: 0x00359C25 File Offset: 0x00357E25
		public EPhotographSubTargetType Type { get; set; }

		// Token: 0x17007186 RID: 29062
		// (get) Token: 0x06017396 RID: 95126 RVA: 0x00359C2E File Offset: 0x00357E2E
		// (set) Token: 0x06017397 RID: 95127 RVA: 0x00359C36 File Offset: 0x00357E36
		public EOnCameraCheckType OnCameraCheckType { get; set; }

		// Token: 0x17007187 RID: 29063
		// (get) Token: 0x06017398 RID: 95128 RVA: 0x00359C3F File Offset: 0x00357E3F
		// (set) Token: 0x06017399 RID: 95129 RVA: 0x00359C47 File Offset: 0x00357E47
		public IConditionGroupT Condition { get; set; }

		// Token: 0x0601739A RID: 95130 RVA: 0x00359C50 File Offset: 0x00357E50
		public IPhotographSubTargetAnyRoleT()
		{
			this.Type = EPhotographSubTargetType.SpecificRole;
			this.OnCameraCheckType = EOnCameraCheckType.All;
			this.Condition = null;
		}
	}
}
