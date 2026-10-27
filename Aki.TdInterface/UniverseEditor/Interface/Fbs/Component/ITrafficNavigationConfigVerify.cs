using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC8 RID: 23240
	public static class ITrafficNavigationConfigVerify
	{
		// Token: 0x060279DA RID: 162266 RVA: 0x00572CB0 File Offset: 0x00570EB0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITrafficNavigationConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITrafficNavigationConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					short typeIdVOffset = 8;
					short valueVOffset = 10;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ITrafficNavigationConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITrafficNavigationConfigVerify.<>O.<1>__Verify = new VerifyUnionAction(TTriggerShapeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyString(tablePos, 18, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007C68 RID: 31848
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401377D RID: 79741
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401377E RID: 79742
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
