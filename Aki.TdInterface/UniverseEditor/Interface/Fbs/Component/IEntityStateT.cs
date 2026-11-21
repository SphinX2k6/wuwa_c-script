using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005716 RID: 22294
	public class IEntityStateT
	{
		// Token: 0x1700A0C8 RID: 41160
		// (get) Token: 0x06023D09 RID: 146697 RVA: 0x004EC336 File Offset: 0x004EA536
		// (set) Token: 0x06023D0A RID: 146698 RVA: 0x004EC33E File Offset: 0x004EA53E
		public string Type { get; set; }

		// Token: 0x1700A0C9 RID: 41161
		// (get) Token: 0x06023D0B RID: 146699 RVA: 0x004EC347 File Offset: 0x004EA547
		// (set) Token: 0x06023D0C RID: 146700 RVA: 0x004EC34F File Offset: 0x004EA54F
		public string State { get; set; }

		// Token: 0x06023D0D RID: 146701 RVA: 0x004EC358 File Offset: 0x004EA558
		public IEntityStateT()
		{
			this.Type = null;
			this.State = null;
		}
	}
}
