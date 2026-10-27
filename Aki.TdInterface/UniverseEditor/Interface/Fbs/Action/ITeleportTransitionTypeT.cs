using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A4 RID: 29604
	public class ITeleportTransitionTypeT
	{
		// Token: 0x1700E0C1 RID: 57537
		// (get) Token: 0x06035BE1 RID: 220129 RVA: 0x00750D0E File Offset: 0x0074EF0E
		// (set) Token: 0x06035BE2 RID: 220130 RVA: 0x00750D16 File Offset: 0x0074EF16
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x06035BE3 RID: 220131 RVA: 0x00750D1F File Offset: 0x0074EF1F
		public ITeleportTransitionTypeT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
		}
	}
}
