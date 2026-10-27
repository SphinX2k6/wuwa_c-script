using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Skin.Skip
{
	// Token: 0x02004BF3 RID: 19443
	[NullableContext(1)]
	[Nullable(0)]
	public class SkinSkipData : ISkinSkipData
	{
		// Token: 0x17007C71 RID: 31857
		// (get) Token: 0x06032462 RID: 205922 RVA: 0x00BAE066 File Offset: 0x00BAC266
		// (set) Token: 0x06032463 RID: 205923 RVA: 0x00BAE06E File Offset: 0x00BAC26E
		public int Id { get; set; }

		// Token: 0x17007C72 RID: 31858
		// (get) Token: 0x06032464 RID: 205924 RVA: 0x00BAE077 File Offset: 0x00BAC277
		// (set) Token: 0x06032465 RID: 205925 RVA: 0x00BAE07F File Offset: 0x00BAC27F
		public int ConfigId { get; set; }

		// Token: 0x17007C73 RID: 31859
		// (get) Token: 0x06032466 RID: 205926 RVA: 0x00BAE088 File Offset: 0x00BAC288
		// (set) Token: 0x06032467 RID: 205927 RVA: 0x00BAE090 File Offset: 0x00BAC290
		public ESkinSkipType Type { get; set; }

		// Token: 0x17007C74 RID: 31860
		// (get) Token: 0x06032468 RID: 205928 RVA: 0x00BAE099 File Offset: 0x00BAC299
		// (set) Token: 0x06032469 RID: 205929 RVA: 0x00BAE0A1 File Offset: 0x00BAC2A1
		public string Text { get; set; }

		// Token: 0x17007C75 RID: 31861
		// (get) Token: 0x0603246A RID: 205930 RVA: 0x00BAE0AA File Offset: 0x00BAC2AA
		// (set) Token: 0x0603246B RID: 205931 RVA: 0x00BAE0B2 File Offset: 0x00BAC2B2
		public int SortIndex { get; set; }
	}
}
