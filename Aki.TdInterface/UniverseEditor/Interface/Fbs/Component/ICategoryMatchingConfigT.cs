using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F65 RID: 20325
	public class ICategoryMatchingConfigT
	{
		// Token: 0x170092BF RID: 37567
		// (get) Token: 0x060203C5 RID: 132037 RVA: 0x0047C4C5 File Offset: 0x0047A6C5
		// (set) Token: 0x060203C6 RID: 132038 RVA: 0x0047C4CD File Offset: 0x0047A6CD
		public ICategoryMatchingConditionT Condition { get; set; }

		// Token: 0x170092C0 RID: 37568
		// (get) Token: 0x060203C7 RID: 132039 RVA: 0x0047C4D6 File Offset: 0x0047A6D6
		// (set) Token: 0x060203C8 RID: 132040 RVA: 0x0047C4DE File Offset: 0x0047A6DE
		public ICategoryMatchingAnimationT Animation { get; set; }

		// Token: 0x170092C1 RID: 37569
		// (get) Token: 0x060203C9 RID: 132041 RVA: 0x0047C4E7 File Offset: 0x0047A6E7
		// (set) Token: 0x060203CA RID: 132042 RVA: 0x0047C4EF File Offset: 0x0047A6EF
		public ICategoryMatchingSucceedT Callback { get; set; }

		// Token: 0x170092C2 RID: 37570
		// (get) Token: 0x060203CB RID: 132043 RVA: 0x0047C4F8 File Offset: 0x0047A6F8
		// (set) Token: 0x060203CC RID: 132044 RVA: 0x0047C500 File Offset: 0x0047A700
		public IItemLockingConfigT ItemLockingConfig { get; set; }

		// Token: 0x060203CD RID: 132045 RVA: 0x0047C509 File Offset: 0x0047A709
		public ICategoryMatchingConfigT()
		{
			this.Condition = null;
			this.Animation = null;
			this.Callback = null;
			this.ItemLockingConfig = null;
		}
	}
}
