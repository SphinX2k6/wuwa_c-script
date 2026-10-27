using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BE2 RID: 15330
	public static class IAbsoluteTipsActorTransformResultVerify
	{
		// Token: 0x06015136 RID: 86326 RVA: 0x0030DFA4 File Offset: 0x0030C1A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAbsoluteTipsActorTransformResultVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAbsoluteTipsActorTransformResultVerify.<>O.<0>__Verify = new VerifyTableAction(IShapeTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAbsoluteTipsActorTransformResultVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IAbsoluteTipsActorTransformResultVerify.<>O.<1>__Verify = new VerifyTableAction(IHollowTipsActorComponentVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007894 RID: 30868
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013101 RID: 78081
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013102 RID: 78082
			public static VerifyTableAction <1>__Verify;
		}
	}
}
