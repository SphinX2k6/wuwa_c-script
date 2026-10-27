using System;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020052F7 RID: 21239
	public interface IRogueEndingItemParam
	{
		// Token: 0x1700831A RID: 33562
		// (get) Token: 0x060365B7 RID: 222647
		// (set) Token: 0x060365B8 RID: 222648
		int ConfigId { get; set; }

		// Token: 0x1700831B RID: 33563
		// (get) Token: 0x060365B9 RID: 222649
		// (set) Token: 0x060365BA RID: 222650
		int Index { get; set; }

		// Token: 0x1700831C RID: 33564
		// (get) Token: 0x060365BB RID: 222651
		// (set) Token: 0x060365BC RID: 222652
		float? Rotation { get; set; }

		// Token: 0x1700831D RID: 33565
		// (get) Token: 0x060365BD RID: 222653
		// (set) Token: 0x060365BE RID: 222654
		bool IsSubView { get; set; }

		// Token: 0x1700831E RID: 33566
		// (get) Token: 0x060365BF RID: 222655
		// (set) Token: 0x060365C0 RID: 222656
		bool IsUnlock { get; set; }
	}
}
