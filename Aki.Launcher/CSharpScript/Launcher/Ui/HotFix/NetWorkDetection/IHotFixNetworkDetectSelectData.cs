using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F2 RID: 242
	[NullableContext(1)]
	public interface IHotFixNetworkDetectSelectData : IHotFixLayoutData
	{
		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060007F7 RID: 2039
		// (set) Token: 0x060007F8 RID: 2040
		ILoginServersData LoginServersData { get; set; }
	}
}
