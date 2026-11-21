using System;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064F5 RID: 25845
	public class ICommonBtCoolDownDecoratorT
	{
		// Token: 0x1700BE92 RID: 48786
		// (get) Token: 0x0602BFD5 RID: 180181 RVA: 0x005FD3DC File Offset: 0x005FB5DC
		// (set) Token: 0x0602BFD6 RID: 180182 RVA: 0x005FD3E4 File Offset: 0x005FB5E4
		public ECommonBtDecoratorType Type { get; set; }

		// Token: 0x1700BE93 RID: 48787
		// (get) Token: 0x0602BFD7 RID: 180183 RVA: 0x005FD3ED File Offset: 0x005FB5ED
		// (set) Token: 0x0602BFD8 RID: 180184 RVA: 0x005FD3F5 File Offset: 0x005FB5F5
		public int CoolDown { get; set; }

		// Token: 0x0602BFD9 RID: 180185 RVA: 0x005FD3FE File Offset: 0x005FB5FE
		public ICommonBtCoolDownDecoratorT()
		{
			this.Type = ECommonBtDecoratorType.Condition;
			this.CoolDown = 0;
		}
	}
}
