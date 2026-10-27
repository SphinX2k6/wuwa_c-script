using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006517 RID: 25879
	public class ICustomShowUiT
	{
		// Token: 0x1700C06C RID: 49260
		// (get) Token: 0x0602CE47 RID: 183879 RVA: 0x0062A5A1 File Offset: 0x006287A1
		// (set) Token: 0x0602CE48 RID: 183880 RVA: 0x0062A5A9 File Offset: 0x006287A9
		public ICustomScreenTextSettingT TextSetting { get; set; }

		// Token: 0x1700C06D RID: 49261
		// (get) Token: 0x0602CE49 RID: 183881 RVA: 0x0062A5B2 File Offset: 0x006287B2
		// (set) Token: 0x0602CE4A RID: 183882 RVA: 0x0062A5BA File Offset: 0x006287BA
		public bool IsHideCircle { get; set; }

		// Token: 0x1700C06E RID: 49262
		// (get) Token: 0x0602CE4B RID: 183883 RVA: 0x0062A5C3 File Offset: 0x006287C3
		// (set) Token: 0x0602CE4C RID: 183884 RVA: 0x0062A5CB File Offset: 0x006287CB
		public byte NullMask { get; set; }

		// Token: 0x0602CE4D RID: 183885 RVA: 0x0062A5D4 File Offset: 0x006287D4
		public ICustomShowUiT()
		{
			this.TextSetting = null;
			this.IsHideCircle = false;
			this.NullMask = 0;
		}
	}
}
