using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004069 RID: 16489
	public static class ITipActorTransformVerify
	{
		// Token: 0x06016B0E RID: 92942 RVA: 0x0033E450 File Offset: 0x0033C650
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

		// Token: 0x020080EB RID: 33003
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014172 RID: 82290
			public static VerifyTableAction <0>__Verify;
		}
	}
}
