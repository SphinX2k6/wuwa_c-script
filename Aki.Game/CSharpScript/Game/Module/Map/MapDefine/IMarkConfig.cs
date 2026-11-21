using System;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200453A RID: 17722
	public interface IMarkConfig
	{
		// Token: 0x170059A3 RID: 22947
		// (get) Token: 0x0602CAD2 RID: 182994
		int MarkId { get; }

		// Token: 0x170059A4 RID: 22948
		// (get) Token: 0x0602CAD3 RID: 182995
		int TrackHudEnable { get; }

		// Token: 0x170059A5 RID: 22949
		// (get) Token: 0x0602CAD4 RID: 182996
		float TrackAutoCancelDistance { get; }

		// Token: 0x170059A6 RID: 22950
		// (get) Token: 0x0602CAD5 RID: 182997
		int? RelativeId { get; }

		// Token: 0x170059A7 RID: 22951
		// (get) Token: 0x0602CAD6 RID: 182998
		int? RelativeDungeonId { get; }

		// Token: 0x170059A8 RID: 22952
		// (get) Token: 0x0602CAD7 RID: 182999
		EMarkRelativeType? RelativeType { get; }

		// Token: 0x170059A9 RID: 22953
		// (get) Token: 0x0602CAD8 RID: 183000
		EMarkRelativeSubType? RelativeSubType { get; }

		// Token: 0x170059AA RID: 22954
		// (get) Token: 0x0602CAD9 RID: 183001
		int? FogHide { get; }

		// Token: 0x170059AB RID: 22955
		// (get) Token: 0x0602CADA RID: 183002
		int AssociatedGameplayMarksLength { get; }

		// Token: 0x0602CADB RID: 183003
		int AssociatedGameplayMarks(int index);
	}
}
