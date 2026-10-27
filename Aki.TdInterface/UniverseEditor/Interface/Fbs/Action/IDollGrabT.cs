using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065FE RID: 26110
	public class IDollGrabT
	{
		// Token: 0x1700C202 RID: 49666
		// (get) Token: 0x0602D55D RID: 185693 RVA: 0x00636C04 File Offset: 0x00634E04
		// (set) Token: 0x0602D55E RID: 185694 RVA: 0x00636C0C File Offset: 0x00634E0C
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700C203 RID: 49667
		// (get) Token: 0x0602D55F RID: 185695 RVA: 0x00636C15 File Offset: 0x00634E15
		// (set) Token: 0x0602D560 RID: 185696 RVA: 0x00636C1D File Offset: 0x00634E1D
		public int TargetDollGrabMachineId { get; set; }

		// Token: 0x0602D561 RID: 185697 RVA: 0x00636C26 File Offset: 0x00634E26
		public IDollGrabT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.TargetDollGrabMachineId = 0;
		}
	}
}
