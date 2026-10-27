using System;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.NetworkDetection;

namespace CSharpScript.Game.Module.NetworkDetection
{
	// Token: 0x0200535F RID: 21343
	[NullableContext(2)]
	[Nullable(0)]
	public class NetworkDetectionItemData : INetworkDetectionItemData
	{
		// Token: 0x17008349 RID: 33609
		// (get) Token: 0x06036868 RID: 223336 RVA: 0x00CE9284 File Offset: 0x00CE7484
		// (set) Token: 0x06036869 RID: 223337 RVA: 0x00CE928C File Offset: 0x00CE748C
		[Nullable(1)]
		public INetworkDetectionEntry EntryData { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x1700834A RID: 33610
		// (get) Token: 0x0603686A RID: 223338 RVA: 0x00CE9295 File Offset: 0x00CE7495
		// (set) Token: 0x0603686B RID: 223339 RVA: 0x00CE929D File Offset: 0x00CE749D
		public INetworkDetectionResult Result { get; set; }

		// Token: 0x1700834B RID: 33611
		// (get) Token: 0x0603686C RID: 223340 RVA: 0x00CE92A6 File Offset: 0x00CE74A6
		// (set) Token: 0x0603686D RID: 223341 RVA: 0x00CE92AE File Offset: 0x00CE74AE
		public bool Proceed { get; set; }

		// Token: 0x1700834C RID: 33612
		// (get) Token: 0x0603686E RID: 223342 RVA: 0x00CE92B7 File Offset: 0x00CE74B7
		// (set) Token: 0x0603686F RID: 223343 RVA: 0x00CE92BF File Offset: 0x00CE74BF
		public string ErrorCodeText { get; set; }
	}
}
