using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BF1 RID: 15345
	public static class IBoxRangeVerify
	{
		// Token: 0x060151BC RID: 86460 RVA: 0x0030EF3C File Offset: 0x0030D13C
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

		// Token: 0x02007896 RID: 30870
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013104 RID: 78084
			public static VerifyTableAction <0>__Verify;
		}
	}
}
