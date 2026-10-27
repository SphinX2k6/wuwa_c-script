using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FF0 RID: 4080
	[NullableContext(1)]
	[Nullable(0)]
	public class ILevelPlayInformation_SetValue
	{
		// Token: 0x040036A3 RID: 13987
		public string TidMainTitle;

		// Token: 0x040036A4 RID: 13988
		public List<IInformationSubTitle> SubTitles;

		// Token: 0x040036A5 RID: 13989
		[Nullable(2)]
		public string EdTidMainTitle;
	}
}
