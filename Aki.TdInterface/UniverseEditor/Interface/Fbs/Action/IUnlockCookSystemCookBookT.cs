using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CBD RID: 31933
	public class IUnlockCookSystemCookBookT
	{
		// Token: 0x1700EF11 RID: 61201
		// (get) Token: 0x060399BA RID: 235962 RVA: 0x007C5F8C File Offset: 0x007C418C
		// (set) Token: 0x060399BB RID: 235963 RVA: 0x007C5F94 File Offset: 0x007C4194
		public EUnlockCookSystemType Type { get; set; }

		// Token: 0x1700EF12 RID: 61202
		// (get) Token: 0x060399BC RID: 235964 RVA: 0x007C5F9D File Offset: 0x007C419D
		// (set) Token: 0x060399BD RID: 235965 RVA: 0x007C5FA5 File Offset: 0x007C41A5
		public int CookBookId { get; set; }

		// Token: 0x060399BE RID: 235966 RVA: 0x007C5FAE File Offset: 0x007C41AE
		public IUnlockCookSystemCookBookT()
		{
			this.Type = EUnlockCookSystemType.UnlockCookBook;
			this.CookBookId = 0;
		}
	}
}
