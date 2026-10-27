using System;

namespace CSharpScript.Game.Module.AdventureGuide
{
	// Token: 0x02005EB7 RID: 24247
	public interface IDetectingObj
	{
		// Token: 0x17008EB3 RID: 36531
		// (get) Token: 0x0603DAEE RID: 252654
		// (set) Token: 0x0603DAEF RID: 252655
		int Id { get; set; }

		// Token: 0x17008EB4 RID: 36532
		// (get) Token: 0x0603DAF0 RID: 252656
		// (set) Token: 0x0603DAF1 RID: 252657
		long RefreshTime { get; set; }

		// Token: 0x17008EB5 RID: 36533
		// (get) Token: 0x0603DAF2 RID: 252658
		// (set) Token: 0x0603DAF3 RID: 252659
		int MapId { get; set; }

		// Token: 0x17008EB6 RID: 36534
		// (get) Token: 0x0603DAF4 RID: 252660
		// (set) Token: 0x0603DAF5 RID: 252661
		float PositionX { get; set; }

		// Token: 0x17008EB7 RID: 36535
		// (get) Token: 0x0603DAF6 RID: 252662
		// (set) Token: 0x0603DAF7 RID: 252663
		float PositionY { get; set; }

		// Token: 0x17008EB8 RID: 36536
		// (get) Token: 0x0603DAF8 RID: 252664
		// (set) Token: 0x0603DAF9 RID: 252665
		float PositionZ { get; set; }
	}
}
