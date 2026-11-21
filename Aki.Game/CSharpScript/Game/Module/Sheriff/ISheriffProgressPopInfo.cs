using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02003BFE RID: 15358
	public interface ISheriffProgressPopInfo
	{
		// Token: 0x17005070 RID: 20592
		// (get) Token: 0x060275B6 RID: 161206
		// (set) Token: 0x060275B7 RID: 161207
		SheriffProgress Progress { get; set; }

		// Token: 0x17005071 RID: 20593
		// (get) Token: 0x060275B8 RID: 161208
		// (set) Token: 0x060275B9 RID: 161209
		bool NeedAnim { get; set; }
	}
}
