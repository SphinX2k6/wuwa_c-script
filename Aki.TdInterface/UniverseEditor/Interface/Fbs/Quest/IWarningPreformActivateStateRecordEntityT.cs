using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004290 RID: 17040
	public class IWarningPreformActivateStateRecordEntityT
	{
		// Token: 0x17007903 RID: 30979
		// (get) Token: 0x060193FD RID: 103421 RVA: 0x003A097B File Offset: 0x0039EB7B
		// (set) Token: 0x060193FE RID: 103422 RVA: 0x003A0983 File Offset: 0x0039EB83
		public EWarningPreformType Type { get; set; }

		// Token: 0x17007904 RID: 30980
		// (get) Token: 0x060193FF RID: 103423 RVA: 0x003A098C File Offset: 0x0039EB8C
		// (set) Token: 0x06019400 RID: 103424 RVA: 0x003A0994 File Offset: 0x0039EB94
		public List<int> TargetEntityIds { get; set; }

		// Token: 0x06019401 RID: 103425 RVA: 0x003A099D File Offset: 0x0039EB9D
		public IWarningPreformActivateStateRecordEntityT()
		{
			this.Type = EWarningPreformType.FadeInScreen;
			this.TargetEntityIds = null;
		}
	}
}
