using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D93 RID: 23955
	public static class IDynamicSummonGongduolaPointVerify
	{
		// Token: 0x06028FF3 RID: 167923 RVA: 0x005A1860 File Offset: 0x0059FA60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDynamicSummonGongduolaPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDynamicSummonGongduolaPointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IDynamicSummonGongduolaPointVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IDynamicSummonGongduolaPointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007CA5 RID: 31909
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137D2 RID: 79826
			public static VerifyTableAction <0>__Verify;
		}
	}
}
