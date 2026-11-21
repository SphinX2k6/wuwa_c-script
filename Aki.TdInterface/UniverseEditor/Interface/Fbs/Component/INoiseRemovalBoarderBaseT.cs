using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B9B RID: 23451
	public class INoiseRemovalBoarderBaseT
	{
		// Token: 0x1700AB6C RID: 43884
		// (get) Token: 0x06026A7D RID: 158333 RVA: 0x0054AD72 File Offset: 0x00548F72
		// (set) Token: 0x06026A7E RID: 158334 RVA: 0x0054AD7A File Offset: 0x00548F7A
		public ENoiseRemovalBoarderShape Type { get; set; }

		// Token: 0x06026A7F RID: 158335 RVA: 0x0054AD83 File Offset: 0x00548F83
		public INoiseRemovalBoarderBaseT()
		{
			this.Type = ENoiseRemovalBoarderShape.Box;
		}
	}
}
