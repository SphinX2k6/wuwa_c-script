using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074C4 RID: 29892
	public class IUnlockAtlasSystemItemT
	{
		// Token: 0x1700E2E2 RID: 58082
		// (get) Token: 0x0603658F RID: 222607 RVA: 0x00762B0B File Offset: 0x00760D0B
		// (set) Token: 0x06036590 RID: 222608 RVA: 0x00762B13 File Offset: 0x00760D13
		public EUnlockSystemItemType Type { get; set; }

		// Token: 0x1700E2E3 RID: 58083
		// (get) Token: 0x06036591 RID: 222609 RVA: 0x00762B1C File Offset: 0x00760D1C
		// (set) Token: 0x06036592 RID: 222610 RVA: 0x00762B24 File Offset: 0x00760D24
		public TUnlockAtlasSystemOptionV2Union UnlockOption { get; set; }

		// Token: 0x06036593 RID: 222611 RVA: 0x00762B2D File Offset: 0x00760D2D
		public IUnlockAtlasSystemItemT()
		{
			this.Type = EUnlockSystemItemType.CookSystem;
			this.UnlockOption = null;
		}
	}
}
