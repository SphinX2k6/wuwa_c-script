using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F6 RID: 246
	[NullableContext(1)]
	public interface IHotFixNetworkDetectSelectData : IHotFixLayoutData
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600082B RID: 2091
		// (set) Token: 0x0600082C RID: 2092
		ILoginServersData LoginServersData { get; set; }
	}
}
