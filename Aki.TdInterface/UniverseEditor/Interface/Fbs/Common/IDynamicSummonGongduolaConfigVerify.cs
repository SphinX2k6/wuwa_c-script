using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D8D RID: 23949
	public static class IDynamicSummonGongduolaConfigVerify
	{
		// Token: 0x06028FB7 RID: 167863 RVA: 0x005A1094 File Offset: 0x0059F294
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicSummonGongduolaConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicSummonGongduolaConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IDynamicSummonGongduolaPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CA3 RID: 31907
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137D0 RID: 79824
			public static VerifyTableAction <0>__Verify;
		}
	}
}
