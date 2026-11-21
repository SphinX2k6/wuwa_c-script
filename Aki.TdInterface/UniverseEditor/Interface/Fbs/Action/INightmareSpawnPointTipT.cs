using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F6 RID: 29430
	public class INightmareSpawnPointTipT
	{
		// Token: 0x1700D7C6 RID: 55238
		// (get) Token: 0x06033515 RID: 210197 RVA: 0x006EBD38 File Offset: 0x006E9F38
		// (set) Token: 0x06033516 RID: 210198 RVA: 0x006EBD40 File Offset: 0x006E9F40
		public ECommonTipType Type { get; set; }

		// Token: 0x1700D7C7 RID: 55239
		// (get) Token: 0x06033517 RID: 210199 RVA: 0x006EBD49 File Offset: 0x006E9F49
		// (set) Token: 0x06033518 RID: 210200 RVA: 0x006EBD51 File Offset: 0x006E9F51
		public string TidMainText { get; set; }

		// Token: 0x1700D7C8 RID: 55240
		// (get) Token: 0x06033519 RID: 210201 RVA: 0x006EBD5A File Offset: 0x006E9F5A
		// (set) Token: 0x0603351A RID: 210202 RVA: 0x006EBD62 File Offset: 0x006E9F62
		public string TidSubText { get; set; }

		// Token: 0x0603351B RID: 210203 RVA: 0x006EBD6B File Offset: 0x006E9F6B
		public INightmareSpawnPointTipT()
		{
			this.Type = ECommonTipType.ChallengeCondition;
			this.TidMainText = null;
			this.TidSubText = null;
		}
	}
}
