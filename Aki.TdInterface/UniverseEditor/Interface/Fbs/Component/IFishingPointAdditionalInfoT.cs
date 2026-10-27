using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005262 RID: 21090
	public class IFishingPointAdditionalInfoT
	{
		// Token: 0x17009A77 RID: 39543
		// (get) Token: 0x060224F1 RID: 140529 RVA: 0x004C1ABA File Offset: 0x004BFCBA
		// (set) Token: 0x060224F2 RID: 140530 RVA: 0x004C1AC2 File Offset: 0x004BFCC2
		public EInteractAdditionalInfoType Type { get; set; }

		// Token: 0x060224F3 RID: 140531 RVA: 0x004C1ACB File Offset: 0x004BFCCB
		public IFishingPointAdditionalInfoT()
		{
			this.Type = EInteractAdditionalInfoType.FishingPoint;
		}
	}
}
