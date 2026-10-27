using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DDD RID: 15837
	public class IDistributeParamsT
	{
		// Token: 0x17006D5E RID: 27998
		// (get) Token: 0x060161EF RID: 90607 RVA: 0x003326D5 File Offset: 0x003308D5
		// (set) Token: 0x060161F0 RID: 90608 RVA: 0x003326DD File Offset: 0x003308DD
		public int InformationViewCheck { get; set; }

		// Token: 0x17006D5F RID: 27999
		// (get) Token: 0x060161F1 RID: 90609 RVA: 0x003326E6 File Offset: 0x003308E6
		// (set) Token: 0x060161F2 RID: 90610 RVA: 0x003326EE File Offset: 0x003308EE
		public IItemConfigT UseItem { get; set; }

		// Token: 0x17006D60 RID: 28000
		// (get) Token: 0x060161F3 RID: 90611 RVA: 0x003326F7 File Offset: 0x003308F7
		// (set) Token: 0x060161F4 RID: 90612 RVA: 0x003326FF File Offset: 0x003308FF
		public byte NullMask { get; set; }

		// Token: 0x060161F5 RID: 90613 RVA: 0x00332708 File Offset: 0x00330908
		public IDistributeParamsT()
		{
			this.InformationViewCheck = 0;
			this.UseItem = null;
			this.NullMask = 0;
		}
	}
}
