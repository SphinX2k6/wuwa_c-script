using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043B9 RID: 17337
	public class IPermanentRogueUiT
	{
		// Token: 0x1700776A RID: 30570
		// (get) Token: 0x060189A5 RID: 100773 RVA: 0x003828B2 File Offset: 0x00380AB2
		// (set) Token: 0x060189A6 RID: 100774 RVA: 0x003828BA File Offset: 0x00380ABA
		public EShowUiType Type { get; set; }

		// Token: 0x1700776B RID: 30571
		// (get) Token: 0x060189A7 RID: 100775 RVA: 0x003828C3 File Offset: 0x00380AC3
		// (set) Token: 0x060189A8 RID: 100776 RVA: 0x003828CB File Offset: 0x00380ACB
		public ERogueUiType UiType { get; set; }

		// Token: 0x1700776C RID: 30572
		// (get) Token: 0x060189A9 RID: 100777 RVA: 0x003828D4 File Offset: 0x00380AD4
		// (set) Token: 0x060189AA RID: 100778 RVA: 0x003828DC File Offset: 0x00380ADC
		public int BindId { get; set; }

		// Token: 0x060189AB RID: 100779 RVA: 0x003828E5 File Offset: 0x00380AE5
		public IPermanentRogueUiT()
		{
			this.Type = EShowUiType.All;
			this.UiType = ERogueUiType.None;
			this.BindId = 0;
		}
	}
}
