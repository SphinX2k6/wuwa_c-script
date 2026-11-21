using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F84 RID: 28548
	public class IHeadStyleVoiceOnlyT
	{
		// Token: 0x1700D119 RID: 53529
		// (get) Token: 0x0603169E RID: 202398 RVA: 0x006B3308 File Offset: 0x006B1508
		// (set) Token: 0x0603169F RID: 202399 RVA: 0x006B3310 File Offset: 0x006B1510
		public EHeadStyle Type { get; set; }

		// Token: 0x1700D11A RID: 53530
		// (get) Token: 0x060316A0 RID: 202400 RVA: 0x006B3319 File Offset: 0x006B1519
		// (set) Token: 0x060316A1 RID: 202401 RVA: 0x006B3321 File Offset: 0x006B1521
		public int WhoId { get; set; }

		// Token: 0x060316A2 RID: 202402 RVA: 0x006B332A File Offset: 0x006B152A
		public IHeadStyleVoiceOnlyT()
		{
			this.Type = EHeadStyle.Normal;
			this.WhoId = 0;
		}
	}
}
