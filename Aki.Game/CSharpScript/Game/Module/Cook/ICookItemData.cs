using System;

namespace CSharpScript.Game.Module.Cook
{
	// Token: 0x02004ADF RID: 19167
	public interface ICookItemData
	{
		// Token: 0x1700601A RID: 24602
		// (get) Token: 0x0602FF10 RID: 196368
		// (set) Token: 0x0602FF11 RID: 196369
		ECookListType MainType { get; set; }

		// Token: 0x1700601B RID: 24603
		// (get) Token: 0x0602FF12 RID: 196370
		// (set) Token: 0x0602FF13 RID: 196371
		int ItemId { get; set; }

		// Token: 0x1700601C RID: 24604
		// (get) Token: 0x0602FF14 RID: 196372
		// (set) Token: 0x0602FF15 RID: 196373
		bool IsNew { get; set; }

		// Token: 0x1700601D RID: 24605
		// (get) Token: 0x0602FF16 RID: 196374
		// (set) Token: 0x0602FF17 RID: 196375
		int Quality { get; set; }

		// Token: 0x1700601E RID: 24606
		// (get) Token: 0x0602FF18 RID: 196376
		// (set) Token: 0x0602FF19 RID: 196377
		bool IsUnLock { get; set; }
	}
}
