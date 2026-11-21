using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Launcher.Ui.SdkView
{
	// Token: 0x020000CB RID: 203
	[NullableContext(1)]
	[Nullable(0)]
	public class SdkProtocolViewLayoutData
	{
		// Token: 0x060006BB RID: 1723 RVA: 0x00039C97 File Offset: 0x00037E97
		public static SdkProtocolViewLayoutData CreateLayoutData(string textId, string keyShortCut, Action<SdkProtocolView> clickCallBack)
		{
			return new SdkProtocolViewLayoutData
			{
				TextId = textId,
				KeyShortCut = keyShortCut,
				ClickCallBack = clickCallBack
			};
		}

		// Token: 0x0400042E RID: 1070
		public string TextId = "";

		// Token: 0x0400042F RID: 1071
		public string KeyShortCut = "";

		// Token: 0x04000430 RID: 1072
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<SdkProtocolView> ClickCallBack;
	}
}
