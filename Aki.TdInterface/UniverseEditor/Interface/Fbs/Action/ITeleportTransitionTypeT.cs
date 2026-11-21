using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B8B RID: 31627
	public class ITeleportTransitionTypeT
	{
		// Token: 0x1700ECD1 RID: 60625
		// (get) Token: 0x06038F7C RID: 233340 RVA: 0x007B324E File Offset: 0x007B144E
		// (set) Token: 0x06038F7D RID: 233341 RVA: 0x007B3256 File Offset: 0x007B1456
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x06038F7E RID: 233342 RVA: 0x007B325F File Offset: 0x007B145F
		public ITeleportTransitionTypeT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
		}
	}
}
