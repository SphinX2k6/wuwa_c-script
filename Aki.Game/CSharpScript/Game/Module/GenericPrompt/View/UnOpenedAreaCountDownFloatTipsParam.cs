using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200498A RID: 18826
	[RequiredMember]
	public class UnOpenedAreaCountDownFloatTipsParam
	{
		// Token: 0x0602F2C5 RID: 193221 RVA: 0x00D25ED3 File Offset: 0x00D240D3
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public UnOpenedAreaCountDownFloatTipsParam()
		{
		}

		// Token: 0x04019091 RID: 102545
		[Nullable(1)]
		[RequiredMember]
		public string TidCountDownTip;

		// Token: 0x04019092 RID: 102546
		public float RemainSec;
	}
}
