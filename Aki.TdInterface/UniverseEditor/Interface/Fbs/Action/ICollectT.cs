using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ABA RID: 27322
	public class ICollectT
	{
		// Token: 0x1700C8AC RID: 51372
		// (get) Token: 0x0602EE67 RID: 192103 RVA: 0x00663B7C File Offset: 0x00661D7C
		// (set) Token: 0x0602EE68 RID: 192104 RVA: 0x00663B84 File Offset: 0x00661D84
		public int TargetEntity { get; set; }

		// Token: 0x1700C8AD RID: 51373
		// (get) Token: 0x0602EE69 RID: 192105 RVA: 0x00663B8D File Offset: 0x00661D8D
		// (set) Token: 0x0602EE6A RID: 192106 RVA: 0x00663B95 File Offset: 0x00661D95
		public byte NullMask { get; set; }

		// Token: 0x0602EE6B RID: 192107 RVA: 0x00663B9E File Offset: 0x00661D9E
		public ICollectT()
		{
			this.TargetEntity = 0;
			this.NullMask = 0;
		}
	}
}
