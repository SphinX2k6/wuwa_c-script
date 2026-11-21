using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060DD RID: 24797
	public class ITrampleTipTypeT
	{
		// Token: 0x1700B873 RID: 47219
		// (get) Token: 0x06029FE6 RID: 172006 RVA: 0x005BB722 File Offset: 0x005B9922
		// (set) Token: 0x06029FE7 RID: 172007 RVA: 0x005BB72A File Offset: 0x005B992A
		public ETrampleTipType Type { get; set; }

		// Token: 0x06029FE8 RID: 172008 RVA: 0x005BB733 File Offset: 0x005B9933
		public ITrampleTipTypeT()
		{
			this.Type = ETrampleTipType.CountDownTextTip;
		}
	}
}
