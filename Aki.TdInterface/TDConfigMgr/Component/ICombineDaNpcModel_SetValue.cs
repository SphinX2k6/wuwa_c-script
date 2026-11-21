using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000293 RID: 659
	public class ICombineDaNpcModel_SetValue
	{
		// Token: 0x04000B6A RID: 2922
		public ENpcModelType Type;

		// Token: 0x04000B6B RID: 2923
		public string Da;

		// Token: 0x04000B6C RID: 2924
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> InitialHiddenAttachTypes;
	}
}
