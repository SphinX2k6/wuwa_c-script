using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FFD RID: 16381
	public static class IBoxRangeVerify
	{
		// Token: 0x060166B2 RID: 91826 RVA: 0x00335AC4 File Offset: 0x00333CC4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBoxRangeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBoxRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBoxRangeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IBoxRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 10;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IBoxRangeVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IBoxRangeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
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

		// Token: 0x020080DA RID: 32986
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014160 RID: 82272
			public static VerifyTableAction <0>__Verify;
		}
	}
}
