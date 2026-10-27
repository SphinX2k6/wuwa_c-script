using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F7 RID: 22519
	public class IRangeAdsorptionFoundationT
	{
		// Token: 0x1700A835 RID: 43061
		// (get) Token: 0x06025D98 RID: 155032 RVA: 0x00538593 File Offset: 0x00536793
		// (set) Token: 0x06025D99 RID: 155033 RVA: 0x0053859B File Offset: 0x0053679B
		public EItemFoundation Type { get; set; }

		// Token: 0x1700A836 RID: 43062
		// (get) Token: 0x06025D9A RID: 155034 RVA: 0x005385A4 File Offset: 0x005367A4
		// (set) Token: 0x06025D9B RID: 155035 RVA: 0x005385AC File Offset: 0x005367AC
		public ICategoryMatchingConditionT Condition { get; set; }

		// Token: 0x1700A837 RID: 43063
		// (get) Token: 0x06025D9C RID: 155036 RVA: 0x005385B5 File Offset: 0x005367B5
		// (set) Token: 0x06025D9D RID: 155037 RVA: 0x005385BD File Offset: 0x005367BD
		public IAdsorptionMatchingAnimationT Animation { get; set; }

		// Token: 0x1700A838 RID: 43064
		// (get) Token: 0x06025D9E RID: 155038 RVA: 0x005385C6 File Offset: 0x005367C6
		// (set) Token: 0x06025D9F RID: 155039 RVA: 0x005385CE File Offset: 0x005367CE
		public ICategoryMatchingAnimationT CategoryAnimation { get; set; }

		// Token: 0x1700A839 RID: 43065
		// (get) Token: 0x06025DA0 RID: 155040 RVA: 0x005385D7 File Offset: 0x005367D7
		// (set) Token: 0x06025DA1 RID: 155041 RVA: 0x005385DF File Offset: 0x005367DF
		public ICategoryMatchingSucceedT Callback { get; set; }

		// Token: 0x06025DA2 RID: 155042 RVA: 0x005385E8 File Offset: 0x005367E8
		public IRangeAdsorptionFoundationT()
		{
			this.Type = EItemFoundation.CategoryMatching;
			this.Condition = null;
			this.Animation = null;
			this.CategoryAnimation = null;
			this.Callback = null;
		}
	}
}
