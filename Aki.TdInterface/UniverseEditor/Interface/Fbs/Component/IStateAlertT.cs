using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FA9 RID: 24489
	public class IStateAlertT
	{
		// Token: 0x1700B55A RID: 46426
		// (get) Token: 0x06029310 RID: 168720 RVA: 0x0059F9A7 File Offset: 0x0059DBA7
		// (set) Token: 0x06029311 RID: 168721 RVA: 0x0059F9AF File Offset: 0x0059DBAF
		public string State { get; set; }

		// Token: 0x1700B55B RID: 46427
		// (get) Token: 0x06029312 RID: 168722 RVA: 0x0059F9B8 File Offset: 0x0059DBB8
		// (set) Token: 0x06029313 RID: 168723 RVA: 0x0059F9C0 File Offset: 0x0059DBC0
		public int Alert { get; set; }

		// Token: 0x06029314 RID: 168724 RVA: 0x0059F9C9 File Offset: 0x0059DBC9
		public IStateAlertT()
		{
			this.State = null;
			this.Alert = 0;
		}
	}
}
