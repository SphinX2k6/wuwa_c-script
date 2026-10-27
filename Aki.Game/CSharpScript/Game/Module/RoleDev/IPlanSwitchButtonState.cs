using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CD0 RID: 19664
	[NullableContext(1)]
	public interface IPlanSwitchButtonState
	{
		// Token: 0x17007D77 RID: 32119
		// (get) Token: 0x06032C3A RID: 207930
		// (set) Token: 0x06032C3B RID: 207931
		bool IsShow { get; set; }

		// Token: 0x17007D78 RID: 32120
		// (get) Token: 0x06032C3C RID: 207932
		// (set) Token: 0x06032C3D RID: 207933
		string Text { get; set; }

		// Token: 0x17007D79 RID: 32121
		// (get) Token: 0x06032C3E RID: 207934
		// (set) Token: 0x06032C3F RID: 207935
		bool IsHighlight { get; set; }
	}
}
