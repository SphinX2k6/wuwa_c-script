using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E20 RID: 28192
	public static class IFindSunSpiritVerify
	{
		// Token: 0x06030AFD RID: 199421 RVA: 0x0069BCA0 File Offset: 0x00699EA0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFindSunSpiritVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFindSunSpiritVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFindSunSpiritVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFindSunSpiritVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 14, 4UL, false))
					{
						short offsetId3 = 16;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IFindSunSpiritVerify.<>O.<1>__Verify) == null)
						{
							verifyAction3 = (IFindSunSpiritVerify.<>O.<1>__Verify = new VerifyTableAction(ISunSpiritDifficultyReductionVerify.Verify));
						}
						if (verifier.VerifyTable(tablePos, offsetId3, verifyAction3, false))
						{
							return verifier.VerifyTableEnd(tablePos);
						}
					}
				}
			}
			return false;
		}

		// Token: 0x020085E1 RID: 34273
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014998 RID: 84376
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014999 RID: 84377
			public static VerifyTableAction <1>__Verify;
		}
	}
}
