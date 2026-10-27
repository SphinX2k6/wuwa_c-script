using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055A8 RID: 21928
	[NullableContext(1)]
	[Nullable(0)]
	public class ExploreData : IExploreData
	{
		// Token: 0x1700868A RID: 34442
		// (get) Token: 0x06037E15 RID: 228885 RVA: 0x00D3DC49 File Offset: 0x00D3BE49
		// (set) Token: 0x06037E16 RID: 228886 RVA: 0x00D3DC51 File Offset: 0x00D3BE51
		public string TitleId { get; set; }

		// Token: 0x1700868B RID: 34443
		// (get) Token: 0x06037E17 RID: 228887 RVA: 0x00D3DC5A File Offset: 0x00D3BE5A
		// (set) Token: 0x06037E18 RID: 228888 RVA: 0x00D3DC62 File Offset: 0x00D3BE62
		public string ValueTxt { get; set; }
	}
}
