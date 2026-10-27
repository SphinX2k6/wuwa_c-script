using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A89 RID: 27273
	public class IMechStuntBurrowT
	{
		// Token: 0x1700CA80 RID: 51840
		// (get) Token: 0x0602FCC8 RID: 195784 RVA: 0x006812B2 File Offset: 0x0067F4B2
		// (set) Token: 0x0602FCC9 RID: 195785 RVA: 0x006812BA File Offset: 0x0067F4BA
		public EMechStuntType Type { get; set; }

		// Token: 0x0602FCCA RID: 195786 RVA: 0x006812C3 File Offset: 0x0067F4C3
		public IMechStuntBurrowT()
		{
			this.Type = EMechStuntType.Dive;
		}
	}
}
