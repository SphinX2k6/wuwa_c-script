using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC0 RID: 27840
	public class IEnableAoiNotifyT
	{
		// Token: 0x1700CC39 RID: 52281
		// (get) Token: 0x0602FFC2 RID: 196546 RVA: 0x00687CB6 File Offset: 0x00685EB6
		// (set) Token: 0x0602FFC3 RID: 196547 RVA: 0x00687CBE File Offset: 0x00685EBE
		public EAoiNotifyState State { get; set; }

		// Token: 0x0602FFC4 RID: 196548 RVA: 0x00687CC7 File Offset: 0x00685EC7
		public IEnableAoiNotifyT()
		{
			this.State = EAoiNotifyState.Open;
		}
	}
}
