using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A8F RID: 19087
	[NullableContext(1)]
	public interface IDreamLinkRecordData
	{
		// Token: 0x17005FEA RID: 24554
		// (get) Token: 0x0602FC4A RID: 195658
		// (set) Token: 0x0602FC4B RID: 195659
		string Title { get; set; }

		// Token: 0x17005FEB RID: 24555
		// (get) Token: 0x0602FC4C RID: 195660
		// (set) Token: 0x0602FC4D RID: 195661
		string Score { get; set; }

		// Token: 0x17005FEC RID: 24556
		// (get) Token: 0x0602FC4E RID: 195662
		// (set) Token: 0x0602FC4F RID: 195663
		bool IsNew { get; set; }
	}
}
