using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003FEB RID: 16363
	public static class IAbsoluteTipActorTransformVerify
	{
		// Token: 0x06016608 RID: 91656 RVA: 0x00334664 File Offset: 0x00332864
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAbsoluteTipActorTransformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAbsoluteTipActorTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAbsoluteTipActorTransformVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAbsoluteTipActorTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020080D7 RID: 32983
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401415C RID: 82268
			public static VerifyTableAction <0>__Verify;
		}
	}
}
