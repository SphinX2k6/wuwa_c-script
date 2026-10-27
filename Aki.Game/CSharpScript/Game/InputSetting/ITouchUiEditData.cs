using System;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007016 RID: 28694
	public interface ITouchUiEditData
	{
		// Token: 0x17009BA4 RID: 39844
		// (get) Token: 0x06045D4F RID: 286031
		// (set) Token: 0x06045D50 RID: 286032
		int StorageId { get; set; }

		// Token: 0x17009BA5 RID: 39845
		// (get) Token: 0x06045D51 RID: 286033
		// (set) Token: 0x06045D52 RID: 286034
		float OffsetX { get; set; }

		// Token: 0x17009BA6 RID: 39846
		// (get) Token: 0x06045D53 RID: 286035
		// (set) Token: 0x06045D54 RID: 286036
		float OffsetY { get; set; }

		// Token: 0x17009BA7 RID: 39847
		// (get) Token: 0x06045D55 RID: 286037
		// (set) Token: 0x06045D56 RID: 286038
		float Scale { get; set; }

		// Token: 0x17009BA8 RID: 39848
		// (get) Token: 0x06045D57 RID: 286039
		// (set) Token: 0x06045D58 RID: 286040
		float Alpha { get; set; }

		// Token: 0x17009BA9 RID: 39849
		// (get) Token: 0x06045D59 RID: 286041
		// (set) Token: 0x06045D5A RID: 286042
		int HierarchyIndex { get; set; }

		// Token: 0x17009BAA RID: 39850
		// (get) Token: 0x06045D5B RID: 286043
		// (set) Token: 0x06045D5C RID: 286044
		bool Editable { get; set; }

		// Token: 0x17009BAB RID: 39851
		// (get) Token: 0x06045D5D RID: 286045
		// (set) Token: 0x06045D5E RID: 286046
		bool DefaultSelect { get; set; }

		// Token: 0x17009BAC RID: 39852
		// (get) Token: 0x06045D5F RID: 286047
		// (set) Token: 0x06045D60 RID: 286048
		bool ShouldCheckOverlap { get; set; }
	}
}
