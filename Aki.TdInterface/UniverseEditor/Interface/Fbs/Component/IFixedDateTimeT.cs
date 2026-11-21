using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057D3 RID: 22483
	public class IFixedDateTimeT
	{
		// Token: 0x1700A286 RID: 41606
		// (get) Token: 0x060244D7 RID: 148695 RVA: 0x004FCE7E File Offset: 0x004FB07E
		// (set) Token: 0x060244D8 RID: 148696 RVA: 0x004FCE86 File Offset: 0x004FB086
		public int Hours { get; set; }

		// Token: 0x1700A287 RID: 41607
		// (get) Token: 0x060244D9 RID: 148697 RVA: 0x004FCE8F File Offset: 0x004FB08F
		// (set) Token: 0x060244DA RID: 148698 RVA: 0x004FCE97 File Offset: 0x004FB097
		public int Minutes { get; set; }

		// Token: 0x1700A288 RID: 41608
		// (get) Token: 0x060244DB RID: 148699 RVA: 0x004FCEA0 File Offset: 0x004FB0A0
		// (set) Token: 0x060244DC RID: 148700 RVA: 0x004FCEA8 File Offset: 0x004FB0A8
		public int Seconds { get; set; }

		// Token: 0x060244DD RID: 148701 RVA: 0x004FCEB1 File Offset: 0x004FB0B1
		public IFixedDateTimeT()
		{
			this.Hours = 0;
			this.Minutes = 0;
			this.Seconds = 0;
		}
	}
}
