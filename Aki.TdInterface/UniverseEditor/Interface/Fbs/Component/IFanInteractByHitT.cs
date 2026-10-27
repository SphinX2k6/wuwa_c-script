using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005235 RID: 21045
	public class IFanInteractByHitT
	{
		// Token: 0x17009A35 RID: 39477
		// (get) Token: 0x060223B3 RID: 140211 RVA: 0x004BF9E6 File Offset: 0x004BDBE6
		// (set) Token: 0x060223B4 RID: 140212 RVA: 0x004BF9EE File Offset: 0x004BDBEE
		public EFanInteractType Type { get; set; }

		// Token: 0x060223B5 RID: 140213 RVA: 0x004BF9F7 File Offset: 0x004BDBF7
		public IFanInteractByHitT()
		{
			this.Type = EFanInteractType.Hit;
		}
	}
}
