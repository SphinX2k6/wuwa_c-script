using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057CA RID: 22474
	public class IFishingPointAdditionalInfoT
	{
		// Token: 0x1700A273 RID: 41587
		// (get) Token: 0x06024487 RID: 148615 RVA: 0x004FC57E File Offset: 0x004FA77E
		// (set) Token: 0x06024488 RID: 148616 RVA: 0x004FC586 File Offset: 0x004FA786
		public EInteractAdditionalInfoType Type { get; set; }

		// Token: 0x06024489 RID: 148617 RVA: 0x004FC58F File Offset: 0x004FA78F
		public IFishingPointAdditionalInfoT()
		{
			this.Type = EInteractAdditionalInfoType.FishingPoint;
		}
	}
}
