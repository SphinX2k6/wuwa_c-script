using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020044AF RID: 17583
	public class IReadMailConditionT
	{
		// Token: 0x17007A61 RID: 31329
		// (get) Token: 0x0601962A RID: 103978 RVA: 0x0039F9B5 File Offset: 0x0039DBB5
		// (set) Token: 0x0601962B RID: 103979 RVA: 0x0039F9BD File Offset: 0x0039DBBD
		public EChildQuest Type { get; set; }

		// Token: 0x17007A62 RID: 31330
		// (get) Token: 0x0601962C RID: 103980 RVA: 0x0039F9C6 File Offset: 0x0039DBC6
		// (set) Token: 0x0601962D RID: 103981 RVA: 0x0039F9CE File Offset: 0x0039DBCE
		public IConditionGroupT PreConditions { get; set; }

		// Token: 0x17007A63 RID: 31331
		// (get) Token: 0x0601962E RID: 103982 RVA: 0x0039F9D7 File Offset: 0x0039DBD7
		// (set) Token: 0x0601962F RID: 103983 RVA: 0x0039F9DF File Offset: 0x0039DBDF
		public int MailId { get; set; }

		// Token: 0x06019630 RID: 103984 RVA: 0x0039F9E8 File Offset: 0x0039DBE8
		public IReadMailConditionT()
		{
			this.Type = EChildQuest.DoInteract;
			this.PreConditions = null;
			this.MailId = 0;
		}
	}
}
