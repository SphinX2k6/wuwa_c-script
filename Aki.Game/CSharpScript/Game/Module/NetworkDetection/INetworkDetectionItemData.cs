using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x02004341 RID: 17217
	[NullableContext(2)]
	public interface INetworkDetectionItemData
	{
		// Token: 0x17005711 RID: 22289
		// (get) Token: 0x0602B7A6 RID: 178086
		// (set) Token: 0x0602B7A7 RID: 178087
		[Nullable(1)]
		INetworkDetectionEntry EntryData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17005712 RID: 22290
		// (get) Token: 0x0602B7A8 RID: 178088
		// (set) Token: 0x0602B7A9 RID: 178089
		INetworkDetectionResult Result { get; set; }

		// Token: 0x17005713 RID: 22291
		// (get) Token: 0x0602B7AA RID: 178090
		// (set) Token: 0x0602B7AB RID: 178091
		bool Proceed { get; set; }

		// Token: 0x17005714 RID: 22292
		// (get) Token: 0x0602B7AC RID: 178092
		// (set) Token: 0x0602B7AD RID: 178093
		string ErrorCodeText { get; set; }
	}
}
