using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005497 RID: 21655
	public class ICategoryMatchingConfigBaseT
	{
		// Token: 0x17009A40 RID: 39488
		// (get) Token: 0x06022133 RID: 139571 RVA: 0x004B2912 File Offset: 0x004B0B12
		// (set) Token: 0x06022134 RID: 139572 RVA: 0x004B291A File Offset: 0x004B0B1A
		public ICategoryMatchingConditionT Condition { get; set; }

		// Token: 0x17009A41 RID: 39489
		// (get) Token: 0x06022135 RID: 139573 RVA: 0x004B2923 File Offset: 0x004B0B23
		// (set) Token: 0x06022136 RID: 139574 RVA: 0x004B292B File Offset: 0x004B0B2B
		public ICategoryMatchingAnimationBaseT Animation { get; set; }

		// Token: 0x17009A42 RID: 39490
		// (get) Token: 0x06022137 RID: 139575 RVA: 0x004B2934 File Offset: 0x004B0B34
		// (set) Token: 0x06022138 RID: 139576 RVA: 0x004B293C File Offset: 0x004B0B3C
		public ICategoryMatchingSucceedBaseT Callback { get; set; }

		// Token: 0x06022139 RID: 139577 RVA: 0x004B2945 File Offset: 0x004B0B45
		public ICategoryMatchingConfigBaseT()
		{
			this.Condition = null;
			this.Animation = null;
			this.Callback = null;
		}
	}
}
