using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062AF RID: 25263
	public class ICaptureElementalBoxT
	{
		// Token: 0x1700BC97 RID: 48279
		// (get) Token: 0x0602BA81 RID: 178817 RVA: 0x006025E9 File Offset: 0x006007E9
		// (set) Token: 0x0602BA82 RID: 178818 RVA: 0x006025F1 File Offset: 0x006007F1
		public TControlElementalBoxTypeUnion CtrlConfig { get; set; }

		// Token: 0x1700BC98 RID: 48280
		// (get) Token: 0x0602BA83 RID: 178819 RVA: 0x006025FA File Offset: 0x006007FA
		// (set) Token: 0x0602BA84 RID: 178820 RVA: 0x00602602 File Offset: 0x00600802
		public TElementalBoxTargetPosTypeUnion TargetPosConfig { get; set; }

		// Token: 0x1700BC99 RID: 48281
		// (get) Token: 0x0602BA85 RID: 178821 RVA: 0x0060260B File Offset: 0x0060080B
		// (set) Token: 0x0602BA86 RID: 178822 RVA: 0x00602613 File Offset: 0x00600813
		public float MoveSpeed { get; set; }

		// Token: 0x0602BA87 RID: 178823 RVA: 0x0060261C File Offset: 0x0060081C
		public ICaptureElementalBoxT()
		{
			this.CtrlConfig = null;
			this.TargetPosConfig = null;
			this.MoveSpeed = 0f;
		}
	}
}
