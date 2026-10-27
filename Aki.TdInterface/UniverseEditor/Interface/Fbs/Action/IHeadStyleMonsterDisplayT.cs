using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068CE RID: 26830
	public class IHeadStyleMonsterDisplayT
	{
		// Token: 0x1700C715 RID: 50965
		// (get) Token: 0x0602ECC0 RID: 191680 RVA: 0x00662DC0 File Offset: 0x00660FC0
		// (set) Token: 0x0602ECC1 RID: 191681 RVA: 0x00662DC8 File Offset: 0x00660FC8
		public EHeadStyle Type { get; set; }

		// Token: 0x1700C716 RID: 50966
		// (get) Token: 0x0602ECC2 RID: 191682 RVA: 0x00662DD1 File Offset: 0x00660FD1
		// (set) Token: 0x0602ECC3 RID: 191683 RVA: 0x00662DD9 File Offset: 0x00660FD9
		public int MonsterDisplayId { get; set; }

		// Token: 0x0602ECC4 RID: 191684 RVA: 0x00662DE2 File Offset: 0x00660FE2
		public IHeadStyleMonsterDisplayT()
		{
			this.Type = EHeadStyle.Normal;
			this.MonsterDisplayId = 0;
		}
	}
}
