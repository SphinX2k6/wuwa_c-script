using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005432 RID: 21554
	public class IInteractAdditionalInfoT
	{
		// Token: 0x17009E86 RID: 40582
		// (get) Token: 0x0602368D RID: 145037 RVA: 0x004E618A File Offset: 0x004E438A
		// (set) Token: 0x0602368E RID: 145038 RVA: 0x004E6192 File Offset: 0x004E4392
		public EInteractAdditionalInfoType Type { get; set; }

		// Token: 0x0602368F RID: 145039 RVA: 0x004E619B File Offset: 0x004E439B
		public IInteractAdditionalInfoT()
		{
			this.Type = EInteractAdditionalInfoType.FishingPoint;
		}
	}
}
