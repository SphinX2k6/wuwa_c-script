using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007475 RID: 29813
	public class IPlayerInputT
	{
		// Token: 0x1700DB07 RID: 56071
		// (get) Token: 0x0603430D RID: 213773 RVA: 0x00707C46 File Offset: 0x00705E46
		// (set) Token: 0x0603430E RID: 213774 RVA: 0x00707C4E File Offset: 0x00705E4E
		public EPlayerInputType Input { get; set; }

		// Token: 0x0603430F RID: 213775 RVA: 0x00707C57 File Offset: 0x00705E57
		public IPlayerInputT()
		{
			this.Input = EPlayerInputType.None;
		}
	}
}
