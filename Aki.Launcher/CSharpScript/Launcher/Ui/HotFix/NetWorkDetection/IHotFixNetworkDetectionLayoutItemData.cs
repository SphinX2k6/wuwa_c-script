using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;

namespace CSharpScript.Launcher.Ui.HotFix.NetWorkDetection
{
	// Token: 0x020000F8 RID: 248
	[NullableContext(2)]
	public interface IHotFixNetworkDetectionLayoutItemData : IHotFixLayoutData
	{
		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000832 RID: 2098
		// (set) Token: 0x06000833 RID: 2099
		[Nullable(1)]
		INetworkDetectionEntry EntryData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000834 RID: 2100
		// (set) Token: 0x06000835 RID: 2101
		INetworkDetectionResult Result { get; set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000836 RID: 2102
		// (set) Token: 0x06000837 RID: 2103
		bool Proceed { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000838 RID: 2104
		// (set) Token: 0x06000839 RID: 2105
		string ErrorCodeText { get; set; }
	}
}
