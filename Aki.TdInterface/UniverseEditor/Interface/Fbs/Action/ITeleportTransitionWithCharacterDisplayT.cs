using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B94 RID: 31636
	public class ITeleportTransitionWithCharacterDisplayT
	{
		// Token: 0x1700ECDC RID: 60636
		// (get) Token: 0x06038FC6 RID: 233414 RVA: 0x007B3A4C File Offset: 0x007B1C4C
		// (set) Token: 0x06038FC7 RID: 233415 RVA: 0x007B3A54 File Offset: 0x007B1C54
		public ETeleportTransitionType Type { get; set; }

		// Token: 0x1700ECDD RID: 60637
		// (get) Token: 0x06038FC8 RID: 233416 RVA: 0x007B3A5D File Offset: 0x007B1C5D
		// (set) Token: 0x06038FC9 RID: 233417 RVA: 0x007B3A65 File Offset: 0x007B1C65
		public int StyleId { get; set; }

		// Token: 0x06038FCA RID: 233418 RVA: 0x007B3A6E File Offset: 0x007B1C6E
		public ITeleportTransitionWithCharacterDisplayT()
		{
			this.Type = ETeleportTransitionType.PlayMp4;
			this.StyleId = 0;
		}
	}
}
