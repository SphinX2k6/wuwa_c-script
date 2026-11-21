using System;
using System.Runtime.CompilerServices;

// Token: 0x02001BE2 RID: 7138
[NullableContext(1)]
public interface IRacingBetsDangoActorData
{
	// Token: 0x17001AE4 RID: 6884
	// (get) Token: 0x06011C13 RID: 72723
	// (set) Token: 0x06011C14 RID: 72724
	EUiModelUseWay UiModelUseWay { get; set; }

	// Token: 0x17001AE5 RID: 6885
	// (get) Token: 0x06011C15 RID: 72725
	// (set) Token: 0x06011C16 RID: 72726
	int DangoId { get; set; }

	// Token: 0x17001AE6 RID: 6886
	// (get) Token: 0x06011C17 RID: 72727
	// (set) Token: 0x06011C18 RID: 72728
	int Odds { get; set; }

	// Token: 0x17001AE7 RID: 6887
	// (get) Token: 0x06011C19 RID: 72729
	// (set) Token: 0x06011C1A RID: 72730
	string DangoPointCase { get; set; }

	// Token: 0x17001AE8 RID: 6888
	// (get) Token: 0x06011C1B RID: 72731
	// (set) Token: 0x06011C1C RID: 72732
	string DangoCamera { get; set; }

	// Token: 0x17001AE9 RID: 6889
	// (get) Token: 0x06011C1D RID: 72733
	// (set) Token: 0x06011C1E RID: 72734
	float DangoOffset { get; set; }

	// Token: 0x17001AEA RID: 6890
	// (get) Token: 0x06011C1F RID: 72735
	// (set) Token: 0x06011C20 RID: 72736
	bool IsAbuDango { get; set; }
}
