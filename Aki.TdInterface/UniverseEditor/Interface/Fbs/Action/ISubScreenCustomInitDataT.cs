using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007206 RID: 29190
	public class ISubScreenCustomInitDataT
	{
		// Token: 0x1700D8BC RID: 55484
		// (get) Token: 0x06033C6E RID: 212078 RVA: 0x006F80E5 File Offset: 0x006F62E5
		// (set) Token: 0x06033C6F RID: 212079 RVA: 0x006F80ED File Offset: 0x006F62ED
		public ESubScreenInitDataType Type { get; set; }

		// Token: 0x1700D8BD RID: 55485
		// (get) Token: 0x06033C70 RID: 212080 RVA: 0x006F80F6 File Offset: 0x006F62F6
		// (set) Token: 0x06033C71 RID: 212081 RVA: 0x006F80FE File Offset: 0x006F62FE
		public string SubScreenKey { get; set; }

		// Token: 0x1700D8BE RID: 55486
		// (get) Token: 0x06033C72 RID: 212082 RVA: 0x006F8107 File Offset: 0x006F6307
		// (set) Token: 0x06033C73 RID: 212083 RVA: 0x006F810F File Offset: 0x006F630F
		public ISubScreenConfigT InitConfig { get; set; }

		// Token: 0x06033C74 RID: 212084 RVA: 0x006F8118 File Offset: 0x006F6318
		public ISubScreenCustomInitDataT()
		{
			this.Type = ESubScreenInitDataType.Preset;
			this.SubScreenKey = null;
			this.InitConfig = null;
		}
	}
}
