using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E71 RID: 15985
	public static class IForceClosedRestrictionVerify
	{
		// Token: 0x06016852 RID: 92242 RVA: 0x0034134C File Offset: 0x0033F54C
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
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078EC RID: 30956
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131A4 RID: 78244
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040131A5 RID: 78245
			public static VerifyTableAction <1>__Verify;
		}
	}
}
