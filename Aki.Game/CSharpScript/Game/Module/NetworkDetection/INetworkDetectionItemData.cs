using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x0200535E RID: 21342
	[NullableContext(2)]
	public interface INetworkDetectionItemData
	{
		// Token: 0x17008345 RID: 33605
		// (get) Token: 0x06036860 RID: 223328
		// (set) Token: 0x06036861 RID: 223329
		[Nullable(1)]
		INetworkDetectionEntry EntryData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x17008346 RID: 33606
		// (get) Token: 0x06036862 RID: 223330
		// (set) Token: 0x06036863 RID: 223331
		INetworkDetectionResult Result { get; set; }

		// Token: 0x17008347 RID: 33607
		// (get) Token: 0x06036864 RID: 223332
		// (set) Token: 0x06036865 RID: 223333
		bool Proceed { get; set; }

		// Token: 0x17008348 RID: 33608
		// (get) Token: 0x06036866 RID: 223334
		// (set) Token: 0x06036867 RID: 223335
		string ErrorCodeText { get; set; }
	}
}
