using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AC RID: 17068
	public static class IForceClosedRestrictionVerify
	{
		// Token: 0x06017E89 RID: 97929 RVA: 0x0036A0B0 File Offset: 0x003682B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IForceClosedRestrictionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IForceClosedRestrictionVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 8, 4UL, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IForceClosedRestrictionVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IForceClosedRestrictionVerify.<>O.<1>__Verify = new VerifyTableAction(Aki.UniverseEditor.Interface.Fbs.Action.IPosAVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyVectorOfData(tablePos, 14, 4UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008132 RID: 33074
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014202 RID: 82434
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014203 RID: 82435
			public static VerifyTableAction <1>__Verify;
		}
	}
}
