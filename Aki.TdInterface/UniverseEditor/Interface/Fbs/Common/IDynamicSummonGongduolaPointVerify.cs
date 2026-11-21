using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063D0 RID: 25552
	public static class IDynamicSummonGongduolaPointVerify
	{
		// Token: 0x0602B67D RID: 177789 RVA: 0x005EA590 File Offset: 0x005E8790
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

		// Token: 0x02008516 RID: 34070
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014878 RID: 84088
			public static VerifyTableAction <0>__Verify;
		}
	}
}
