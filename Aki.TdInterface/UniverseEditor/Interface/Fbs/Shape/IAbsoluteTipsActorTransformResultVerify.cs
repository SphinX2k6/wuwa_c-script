using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FEE RID: 16366
	public static class IAbsoluteTipsActorTransformResultVerify
	{
		// Token: 0x0601662C RID: 91692 RVA: 0x00334B2C File Offset: 0x00332D2C
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

		// Token: 0x020080D8 RID: 32984
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401415D RID: 82269
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401415E RID: 82270
			public static VerifyTableAction <1>__Verify;
		}
	}
}
