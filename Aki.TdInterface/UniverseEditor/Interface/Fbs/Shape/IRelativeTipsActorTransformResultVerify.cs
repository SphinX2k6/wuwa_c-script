using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004045 RID: 16453
	public static class IRelativeTipsActorTransformResultVerify
	{
		// Token: 0x060169A2 RID: 92578 RVA: 0x0033B9B8 File Offset: 0x00339BB8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRelativeTipsActorTransformResultVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRelativeTipsActorTransformResultVerify.<>O.<0>__Verify = new VerifyTableAction(IShapeTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IRelativeTipsActorTransformResultVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IRelativeTipsActorTransformResultVerify.<>O.<1>__Verify = new VerifyTableAction(IHollowTipsActorComponentVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						short offsetId3 = 14;
						VerifyTableAction verifyAction3;
						if ((verifyAction3 = IRelativeTipsActorTransformResultVerify.<>O.<0>__Verify) == null)
						{
							verifyAction3 = (IRelativeTipsActorTransformResultVerify.<>O.<0>__Verify = new VerifyTableAction(IShapeTransformVerify.Verify));
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

		// Token: 0x020080E6 RID: 32998
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401416C RID: 82284
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401416D RID: 82285
			public static VerifyTableAction <1>__Verify;
		}
	}
}
