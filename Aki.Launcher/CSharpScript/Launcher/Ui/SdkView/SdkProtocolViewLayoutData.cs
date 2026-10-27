using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Ui.SdkView
{
	// Token: 0x020000C8 RID: 200
	[NullableContext(1)]
	[Nullable(0)]
	public class SdkProtocolViewLayoutData
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x00038167 File Offset: 0x00036367
		public static SdkProtocolViewLayoutData CreateLayoutData(string textId, string keyShortCut, Action<SdkProtocolView> clickCallBack)
		{
			return new SdkProtocolViewLayoutData
			{
				TextId = textId,
				KeyShortCut = keyShortCut,
				ClickCallBack = clickCallBack
			};
		}

		// Token: 0x040003FF RID: 1023
		public string TextId = "";

		// Token: 0x04000400 RID: 1024
		public string KeyShortCut = "";

		// Token: 0x04000401 RID: 1025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SdkProtocolView> ClickCallBack;
	}
}
