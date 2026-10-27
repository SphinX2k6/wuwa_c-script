using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200406E RID: 16494
	public class IReadMailConditionT
	{
		// Token: 0x1700745F RID: 29791
		// (get) Token: 0x06017F91 RID: 98193 RVA: 0x00375B7D File Offset: 0x00373D7D
		// (set) Token: 0x06017F92 RID: 98194 RVA: 0x00375B85 File Offset: 0x00373D85
		public EChildQuest Type { get; set; }

		// Token: 0x17007460 RID: 29792
		// (get) Token: 0x06017F93 RID: 98195 RVA: 0x00375B8E File Offset: 0x00373D8E
		// (set) Token: 0x06017F94 RID: 98196 RVA: 0x00375B96 File Offset: 0x00373D96
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007461 RID: 29793
		// (get) Token: 0x06017F95 RID: 98197 RVA: 0x00375B9F File Offset: 0x00373D9F
		// (set) Token: 0x06017F96 RID: 98198 RVA: 0x00375BA7 File Offset: 0x00373DA7
		public int MailId { get; set; }

		// Token: 0x06017F97 RID: 98199 RVA: 0x00375BB0 File Offset: 0x00373DB0
		public IReadMailConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.MailId = 0;
		}
	}
}
