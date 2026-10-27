using System;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200556A RID: 21866
	public interface IWorldMapNavigate
	{
		// Token: 0x17008606 RID: 34310
		// (get) Token: 0x06037C09 RID: 228361
		int AreaId { get; }

		// Token: 0x17008607 RID: 34311
		// (get) Token: 0x06037C0A RID: 228362
		int? StateId { get; }

		// Token: 0x17008608 RID: 34312
		// (get) Token: 0x06037C0B RID: 228363
		int SortIndex { get; }

		// Token: 0x17008609 RID: 34313
		// (get) Token: 0x06037C0C RID: 228364
		int CountryId { get; }

		// Token: 0x1700860A RID: 34314
		// (get) Token: 0x06037C0D RID: 228365
		int MarkId { get; }

		// Token: 0x1700860B RID: 34315
		// (get) Token: 0x06037C0E RID: 228366
		EMarkType MarkType { get; }

		// Token: 0x1700860C RID: 34316
		// (get) Token: 0x06037C0F RID: 228367
		int MapConfigId { get; }
	}
}
