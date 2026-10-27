using System;
using Aki.Config;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C4D RID: 19533
	public interface ISheriffProgressPopInfo
	{
		// Token: 0x17007CC6 RID: 31942
		// (get) Token: 0x06032803 RID: 206851
		// (set) Token: 0x06032804 RID: 206852
		SheriffProgress Progress { get; set; }

		// Token: 0x17007CC7 RID: 31943
		// (get) Token: 0x06032805 RID: 206853
		// (set) Token: 0x06032806 RID: 206854
		bool NeedAnim { get; set; }
	}
}
