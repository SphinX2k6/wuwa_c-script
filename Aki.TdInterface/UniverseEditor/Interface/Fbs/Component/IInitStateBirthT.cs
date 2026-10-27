using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005420 RID: 21536
	public class IInitStateBirthT
	{
		// Token: 0x17009E6A RID: 40554
		// (get) Token: 0x060235F3 RID: 144883 RVA: 0x004E50EF File Offset: 0x004E32EF
		// (set) Token: 0x060235F4 RID: 144884 RVA: 0x004E50F7 File Offset: 0x004E32F7
		public EInitStateType Type { get; set; }

		// Token: 0x17009E6B RID: 40555
		// (get) Token: 0x060235F5 RID: 144885 RVA: 0x004E5100 File Offset: 0x004E3300
		// (set) Token: 0x060235F6 RID: 144886 RVA: 0x004E5108 File Offset: 0x004E3308
		public string BirthTag { get; set; }

		// Token: 0x060235F7 RID: 144887 RVA: 0x004E5111 File Offset: 0x004E3311
		public IInitStateBirthT()
		{
			this.Type = EInitStateType.Birth;
			this.BirthTag = null;
		}
	}
}
