using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200664F RID: 26191
	public class IEnableAoiNotifyT
	{
		// Token: 0x1700C29B RID: 49819
		// (get) Token: 0x0602D7F1 RID: 186353 RVA: 0x0063B14E File Offset: 0x0063934E
		// (set) Token: 0x0602D7F2 RID: 186354 RVA: 0x0063B156 File Offset: 0x00639356
		public EAoiNotifyState State { get; set; }

		// Token: 0x0602D7F3 RID: 186355 RVA: 0x0063B15F File Offset: 0x0063935F
		public IEnableAoiNotifyT()
		{
			this.State = EAoiNotifyState.Open;
		}
	}
}
