using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x0200565C RID: 22108
	public class ComposeViewOpenData
	{
		// Token: 0x0401D91C RID: 121116
		public EComposeListType Type = EComposeListType.Purification;

		// Token: 0x0401D91D RID: 121117
		[Nullable(2)]
		public ISelectedData SelectData;

		// Token: 0x0401D91E RID: 121118
		public EUiViewName? SkipSourceView;
	}
}
