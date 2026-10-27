using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DC8 RID: 24008
	public class IGiantResponseTypeT
	{
		// Token: 0x1700B3BE RID: 46014
		// (get) Token: 0x0602917E RID: 168318 RVA: 0x005A4036 File Offset: 0x005A2236
		// (set) Token: 0x0602917F RID: 168319 RVA: 0x005A403E File Offset: 0x005A223E
		public EGiantResponseType Type { get; set; }

		// Token: 0x06029180 RID: 168320 RVA: 0x005A4047 File Offset: 0x005A2247
		public IGiantResponseTypeT()
		{
			this.Type = EGiantResponseType.PlayAnimation;
		}
	}
}
