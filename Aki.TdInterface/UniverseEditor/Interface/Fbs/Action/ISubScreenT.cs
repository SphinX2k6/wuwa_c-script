using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007200 RID: 29184
	public class ISubScreenT
	{
		// Token: 0x1700D8AD RID: 55469
		// (get) Token: 0x06033C36 RID: 212022 RVA: 0x006F79BB File Offset: 0x006F5BBB
		// (set) Token: 0x06033C37 RID: 212023 RVA: 0x006F79C3 File Offset: 0x006F5BC3
		public EScreenType Type { get; set; }

		// Token: 0x1700D8AE RID: 55470
		// (get) Token: 0x06033C38 RID: 212024 RVA: 0x006F79CC File Offset: 0x006F5BCC
		// (set) Token: 0x06033C39 RID: 212025 RVA: 0x006F79D4 File Offset: 0x006F5BD4
		public string SubScreenKey { get; set; }

		// Token: 0x06033C3A RID: 212026 RVA: 0x006F79DD File Offset: 0x006F5BDD
		public ISubScreenT()
		{
			this.Type = EScreenType.Main;
			this.SubScreenKey = null;
		}
	}
}
