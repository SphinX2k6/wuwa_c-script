using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CBA RID: 31930
	public class IUnlockAtlasSystemItemT
	{
		// Token: 0x1700EF0C RID: 61196
		// (get) Token: 0x060399A4 RID: 235940 RVA: 0x007C5D5B File Offset: 0x007C3F5B
		// (set) Token: 0x060399A5 RID: 235941 RVA: 0x007C5D63 File Offset: 0x007C3F63
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x1700EF0D RID: 61197
		// (get) Token: 0x060399A6 RID: 235942 RVA: 0x007C5D6C File Offset: 0x007C3F6C
		// (set) Token: 0x060399A7 RID: 235943 RVA: 0x007C5D74 File Offset: 0x007C3F74
		public TUnlockAtlasSystemOptionV2Union UnlockOption { get; set; }

		// Token: 0x060399A8 RID: 235944 RVA: 0x007C5D7D File Offset: 0x007C3F7D
		public IUnlockAtlasSystemItemT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
			this.UnlockOption = null;
		}
	}
}
