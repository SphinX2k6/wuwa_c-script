using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005AB0 RID: 23216
	[NullableContext(1)]
	public interface IDreamLinkReachedData
	{
		// Token: 0x17008C16 RID: 35862
		// (get) Token: 0x0603ACEE RID: 240878
		// (set) Token: 0x0603ACEF RID: 240879
		string Title { get; set; }

		// Token: 0x17008C17 RID: 35863
		// (get) Token: 0x0603ACF0 RID: 240880
		// (set) Token: 0x0603ACF1 RID: 240881
		string Score { get; set; }

		// Token: 0x17008C18 RID: 35864
		// (get) Token: 0x0603ACF2 RID: 240882
		// (set) Token: 0x0603ACF3 RID: 240883
		bool IsReached { get; set; }
	}
}
