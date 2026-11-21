using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005831 RID: 22577
	public static class IFoxJumpInteractPointRelationTypeVerify
	{
		// Token: 0x060248CE RID: 149710 RVA: 0x005058F8 File Offset: 0x00503AF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFoxJumpInteractPointRelationTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFoxJumpInteractPointRelationTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFoxJumpInteractPointRelationTypeVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IFoxJumpInteractPointRelationTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008390 RID: 33680
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145F5 RID: 83445
			public static VerifyTableAction <0>__Verify;
		}
	}
}
