using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200406F RID: 16495
	public static class ITipsActorTransformResultVerify
	{
		// Token: 0x06016B40 RID: 92992 RVA: 0x0033EA60 File Offset: 0x0033CC60
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITipsActorTransformResultVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITipsActorTransformResultVerify.<>O.<0>__Verify = new VerifyTableAction(IShapeTransformVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITipsActorTransformResultVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ITipsActorTransformResultVerify.<>O.<1>__Verify = new VerifyTableAction(IHollowTipsActorComponentVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020080EC RID: 33004
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014173 RID: 82291
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014174 RID: 82292
			public static VerifyTableAction <1>__Verify;
		}
	}
}
