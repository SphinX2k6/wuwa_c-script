using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F13 RID: 16147
	public static class ILogicNodeOccupationVerify
	{
		// Token: 0x06016EC1 RID: 93889 RVA: 0x0034EE74 File Offset: 0x0034D074
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfStrings(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILogicNodeOccupationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILogicNodeOccupationVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ILogicNodeOccupationVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ILogicNodeOccupationVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyVectorOfData(tablePos, 12, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 16, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007906 RID: 30982
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131D9 RID: 78297
			public static VerifyTableAction <0>__Verify;
		}
	}
}
