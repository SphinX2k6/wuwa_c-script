using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EB2 RID: 24242
	public class ICommonBtCoolDownDecoratorT
	{
		// Token: 0x1700B527 RID: 46375
		// (get) Token: 0x06029921 RID: 170273 RVA: 0x005B3EF8 File Offset: 0x005B20F8
		// (set) Token: 0x06029922 RID: 170274 RVA: 0x005B3F00 File Offset: 0x005B2100
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x1700B528 RID: 46376
		// (get) Token: 0x06029923 RID: 170275 RVA: 0x005B3F09 File Offset: 0x005B2109
		// (set) Token: 0x06029924 RID: 170276 RVA: 0x005B3F11 File Offset: 0x005B2111
		public int CoolDown { get; set; }

		// Token: 0x06029925 RID: 170277 RVA: 0x005B3F1A File Offset: 0x005B211A
		public ICommonBtCoolDownDecoratorT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
			this.CoolDown = 0;
		}
	}
}
