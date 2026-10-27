using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006487 RID: 25735
	public class ICommonTip2TypeT
	{
		// Token: 0x1700BF8A RID: 49034
		// (get) Token: 0x0602C9A0 RID: 182688 RVA: 0x00620152 File Offset: 0x0061E352
		// (set) Token: 0x0602C9A1 RID: 182689 RVA: 0x0062015A File Offset: 0x0061E35A
		public ECommonTip2Type Type { get; set; }

		// Token: 0x0602C9A2 RID: 182690 RVA: 0x00620163 File Offset: 0x0061E363
		public ICommonTip2TypeT()
		{
			this.Type = ECommonTip2Type.PrepareCountdown;
		}
	}
}
