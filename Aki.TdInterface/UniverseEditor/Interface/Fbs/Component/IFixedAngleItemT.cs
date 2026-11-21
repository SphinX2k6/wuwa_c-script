using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CD RID: 22477
	public class IFixedAngleItemT
	{
		// Token: 0x1700A278 RID: 41592
		// (get) Token: 0x0602449D RID: 148637 RVA: 0x004FC7B6 File Offset: 0x004FA9B6
		// (set) Token: 0x0602449E RID: 148638 RVA: 0x004FC7BE File Offset: 0x004FA9BE
		public int InitAngle { get; set; }

		// Token: 0x1700A279 RID: 41593
		// (get) Token: 0x0602449F RID: 148639 RVA: 0x004FC7C7 File Offset: 0x004FA9C7
		// (set) Token: 0x060244A0 RID: 148640 RVA: 0x004FC7CF File Offset: 0x004FA9CF
		public int TargetAngle { get; set; }

		// Token: 0x1700A27A RID: 41594
		// (get) Token: 0x060244A1 RID: 148641 RVA: 0x004FC7D8 File Offset: 0x004FA9D8
		// (set) Token: 0x060244A2 RID: 148642 RVA: 0x004FC7E0 File Offset: 0x004FA9E0
		public int RotateAngle { get; set; }

		// Token: 0x060244A3 RID: 148643 RVA: 0x004FC7E9 File Offset: 0x004FA9E9
		public IFixedAngleItemT()
		{
			this.InitAngle = 0;
			this.TargetAngle = 0;
			this.RotateAngle = 0;
		}
	}
}
