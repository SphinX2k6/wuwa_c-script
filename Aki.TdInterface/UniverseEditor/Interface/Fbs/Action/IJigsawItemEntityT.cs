using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007080 RID: 28800
	public class IJigsawItemEntityT
	{
		// Token: 0x1700D302 RID: 54018
		// (get) Token: 0x06031F67 RID: 204647 RVA: 0x006C31FF File Offset: 0x006C13FF
		// (set) Token: 0x06031F68 RID: 204648 RVA: 0x006C3207 File Offset: 0x006C1407
		public EResetEntityType Type { get; set; }

		// Token: 0x1700D303 RID: 54019
		// (get) Token: 0x06031F69 RID: 204649 RVA: 0x006C3210 File Offset: 0x006C1410
		// (set) Token: 0x06031F6A RID: 204650 RVA: 0x006C3218 File Offset: 0x006C1418
		public List<int> EntityIds { get; set; }

		// Token: 0x06031F6B RID: 204651 RVA: 0x006C3221 File Offset: 0x006C1421
		public IJigsawItemEntityT()
		{
			this.Type = EResetEntityType.TeleControl;
			this.EntityIds = null;
		}
	}
}
