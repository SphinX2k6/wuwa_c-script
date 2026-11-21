using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C6F RID: 27759
	public class IDollGrabT
	{
		// Token: 0x1700CBA0 RID: 52128
		// (get) Token: 0x0602FD2E RID: 195886 RVA: 0x0068376C File Offset: 0x0068196C
		// (set) Token: 0x0602FD2F RID: 195887 RVA: 0x00683774 File Offset: 0x00681974
		public ESimpleGameplayType Type { get; set; }

		// Token: 0x1700CBA1 RID: 52129
		// (get) Token: 0x0602FD30 RID: 195888 RVA: 0x0068377D File Offset: 0x0068197D
		// (set) Token: 0x0602FD31 RID: 195889 RVA: 0x00683785 File Offset: 0x00681985
		public int TargetDollGrabMachineId { get; set; }

		// Token: 0x0602FD32 RID: 195890 RVA: 0x0068378E File Offset: 0x0068198E
		public IDollGrabT()
		{
			this.Type = ESimpleGameplayType.Cipher;
			this.TargetDollGrabMachineId = 0;
		}
	}
}
