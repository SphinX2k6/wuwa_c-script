using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005882 RID: 22658
	public static class IGraffitiPointPairVerify
	{
		// Token: 0x06024BE7 RID: 150503 RVA: 0x0050BFD8 File Offset: 0x0050A1D8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGraffitiPointPairVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGraffitiPointPairVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IGraffitiPointPairVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IGraffitiPointPairVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x0200839F RID: 33695
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401460C RID: 83468
			public static VerifyTableAction <0>__Verify;
		}
	}
}
