using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043B1 RID: 17329
	public static class IParallaxPointPairVerify
	{
		// Token: 0x06018873 RID: 100467 RVA: 0x0037EA3C File Offset: 0x0037CC3C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IParallaxPointPairVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IParallaxPointPairVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IParallaxPointPairVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IParallaxPointPairVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008159 RID: 33113
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401424C RID: 82508
			public static VerifyTableAction <0>__Verify;
		}
	}
}
