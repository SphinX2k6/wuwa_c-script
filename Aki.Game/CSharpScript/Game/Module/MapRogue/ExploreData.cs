using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x0200457E RID: 17790
	[NullableContext(1)]
	[Nullable(0)]
	public class ExploreData : IExploreData
	{
		// Token: 0x17005A51 RID: 23121
		// (get) Token: 0x0602CD13 RID: 183571 RVA: 0x00C8B991 File Offset: 0x00C89B91
		// (set) Token: 0x0602CD14 RID: 183572 RVA: 0x00C8B999 File Offset: 0x00C89B99
		public string TitleId { get; set; }

		// Token: 0x17005A52 RID: 23122
		// (get) Token: 0x0602CD15 RID: 183573 RVA: 0x00C8B9A2 File Offset: 0x00C89BA2
		// (set) Token: 0x0602CD16 RID: 183574 RVA: 0x00C8B9AA File Offset: 0x00C89BAA
		public string ValueTxt { get; set; }
	}
}
