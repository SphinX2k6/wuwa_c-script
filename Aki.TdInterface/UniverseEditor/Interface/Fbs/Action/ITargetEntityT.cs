using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B37 RID: 31543
	public class ITargetEntityT
	{
		// Token: 0x1700EC49 RID: 60489
		// (get) Token: 0x06038CF3 RID: 232691 RVA: 0x007AECE4 File Offset: 0x007ACEE4
		// (set) Token: 0x06038CF4 RID: 232692 RVA: 0x007AECEC File Offset: 0x007ACEEC
		public ETargetEntityType Type { get; set; }

		// Token: 0x1700EC4A RID: 60490
		// (get) Token: 0x06038CF5 RID: 232693 RVA: 0x007AECF5 File Offset: 0x007ACEF5
		// (set) Token: 0x06038CF6 RID: 232694 RVA: 0x007AECFD File Offset: 0x007ACEFD
		public int EntityId { get; set; }

		// Token: 0x06038CF7 RID: 232695 RVA: 0x007AED06 File Offset: 0x007ACF06
		public ITargetEntityT()
		{
			this.Type = ETargetEntityType.Target;
			this.EntityId = 0;
		}
	}
}
