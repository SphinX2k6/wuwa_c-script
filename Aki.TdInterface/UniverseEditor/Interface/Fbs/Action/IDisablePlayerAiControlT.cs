using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5A RID: 27738
	public class IDisablePlayerAiControlT
	{
		// Token: 0x1700CB70 RID: 52080
		// (get) Token: 0x0602FC60 RID: 195680 RVA: 0x00681C0E File Offset: 0x0067FE0E
		// (set) Token: 0x0602FC61 RID: 195681 RVA: 0x00681C16 File Offset: 0x0067FE16
		public EPlayerAiControlType Type { get; set; }

		// Token: 0x0602FC62 RID: 195682 RVA: 0x00681C1F File Offset: 0x0067FE1F
		public IDisablePlayerAiControlT()
		{
			this.Type = EPlayerAiControlType.Enable;
		}
	}
}
