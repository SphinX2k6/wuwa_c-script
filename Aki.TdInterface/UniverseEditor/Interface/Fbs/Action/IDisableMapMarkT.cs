using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C51 RID: 27729
	public class IDisableMapMarkT
	{
		// Token: 0x1700CB44 RID: 52036
		// (get) Token: 0x0602FBC9 RID: 195529 RVA: 0x006803A0 File Offset: 0x0067E5A0
		// (set) Token: 0x0602FBCA RID: 195530 RVA: 0x006803A8 File Offset: 0x0067E5A8
		public EMapMarkState Type { get; set; }

		// Token: 0x1700CB45 RID: 52037
		// (get) Token: 0x0602FBCB RID: 195531 RVA: 0x006803B1 File Offset: 0x0067E5B1
		// (set) Token: 0x0602FBCC RID: 195532 RVA: 0x006803B9 File Offset: 0x0067E5B9
		public int MarkId { get; set; }

		// Token: 0x0602FBCD RID: 195533 RVA: 0x006803C2 File Offset: 0x0067E5C2
		public IDisableMapMarkT()
		{
			this.Type = EMapMarkState.Show;
			this.MarkId = 0;
		}
	}
}
