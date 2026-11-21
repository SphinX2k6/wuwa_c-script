using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.Manufacture.Compose
{
	// Token: 0x02004632 RID: 17970
	public class ComposeViewOpenData
	{
		// Token: 0x040183A7 RID: 99239
		public EComposeListType Type = EComposeListType.Purification;

		// Token: 0x040183A8 RID: 99240
		[Nullable(2)]
		public ISelectedData SelectData;

		// Token: 0x040183A9 RID: 99241
		public EUiViewName? SkipSourceView;
	}
}
