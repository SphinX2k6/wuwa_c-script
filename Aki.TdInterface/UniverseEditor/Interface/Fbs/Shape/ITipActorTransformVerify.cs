using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C5A RID: 15450
	public static class ITipActorTransformVerify
	{
		// Token: 0x060155FA RID: 87546 RVA: 0x003175B0 File Offset: 0x003157B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITipActorTransformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITipActorTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ITipActorTransformVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (ITipActorTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020078A7 RID: 30887
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013116 RID: 78102
			public static VerifyTableAction <0>__Verify;
		}
	}
}
