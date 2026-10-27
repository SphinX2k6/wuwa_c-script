using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AB3 RID: 23219
	[NullableContext(1)]
	public interface IDreamLinkRecordData
	{
		// Token: 0x17008C1C RID: 35868
		// (get) Token: 0x0603ACFE RID: 240894
		// (set) Token: 0x0603ACFF RID: 240895
		string Title { get; set; }

		// Token: 0x17008C1D RID: 35869
		// (get) Token: 0x0603AD00 RID: 240896
		// (set) Token: 0x0603AD01 RID: 240897
		string Score { get; set; }

		// Token: 0x17008C1E RID: 35870
		// (get) Token: 0x0603AD02 RID: 240898
		// (set) Token: 0x0603AD03 RID: 240899
		bool IsNew { get; set; }
	}
}
