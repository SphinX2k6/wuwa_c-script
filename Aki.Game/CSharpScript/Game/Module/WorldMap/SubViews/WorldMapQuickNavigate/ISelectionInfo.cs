using System;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x0200370A RID: 14090
	public interface ISelectionInfo
	{
		// Token: 0x17004B72 RID: 19314
		// (get) Token: 0x06024ABC RID: 150204
		// (set) Token: 0x06024ABD RID: 150205
		int FirstIndex { get; set; }

		// Token: 0x17004B73 RID: 19315
		// (get) Token: 0x06024ABE RID: 150206
		// (set) Token: 0x06024ABF RID: 150207
		int SecondIndex { get; set; }

		// Token: 0x17004B74 RID: 19316
		// (get) Token: 0x06024AC0 RID: 150208
		// (set) Token: 0x06024AC1 RID: 150209
		int CountryId { get; set; }

		// Token: 0x17004B75 RID: 19317
		// (get) Token: 0x06024AC2 RID: 150210
		// (set) Token: 0x06024AC3 RID: 150211
		bool ExpandCountry { get; set; }

		// Token: 0x17004B76 RID: 19318
		// (get) Token: 0x06024AC4 RID: 150212
		// (set) Token: 0x06024AC5 RID: 150213
		int StateId { get; set; }

		// Token: 0x17004B77 RID: 19319
		// (get) Token: 0x06024AC6 RID: 150214
		// (set) Token: 0x06024AC7 RID: 150215
		int AreaId { get; set; }
	}
}
