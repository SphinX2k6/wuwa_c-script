using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F4 RID: 244
	[NullableContext(2)]
	public interface IHotFixNetworkDetectionLayoutItemData : IHotFixLayoutData
	{
		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060007FE RID: 2046
		// (set) Token: 0x060007FF RID: 2047
		[Nullable(1)]
		INetworkDetectionEntry EntryData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000800 RID: 2048
		// (set) Token: 0x06000801 RID: 2049
		INetworkDetectionResult Result { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000802 RID: 2050
		// (set) Token: 0x06000803 RID: 2051
		bool Proceed { get; set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000804 RID: 2052
		// (set) Token: 0x06000805 RID: 2053
		string ErrorCodeText { get; set; }
	}
}
