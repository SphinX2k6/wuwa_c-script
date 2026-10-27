using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055FD RID: 22013
	public class INoiseRemovalBoarderBaseT
	{
		// Token: 0x1700A2E4 RID: 41700
		// (get) Token: 0x0602486D RID: 149613 RVA: 0x0050A75A File Offset: 0x0050895A
		// (set) Token: 0x0602486E RID: 149614 RVA: 0x0050A762 File Offset: 0x00508962
		public ENoiseRemovalBoarderShape Type { get; set; }

		// Token: 0x0602486F RID: 149615 RVA: 0x0050A76B File Offset: 0x0050896B
		public INoiseRemovalBoarderBaseT()
		{
			this.Type = ENoiseRemovalBoarderShape.Box;
		}
	}
}
