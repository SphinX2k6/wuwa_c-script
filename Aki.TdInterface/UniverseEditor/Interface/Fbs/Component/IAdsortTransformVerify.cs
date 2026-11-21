using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537B RID: 21371
	public static class IAdsortTransformVerify
	{
		// Token: 0x060214B2 RID: 136370 RVA: 0x00498024 File Offset: 0x00496224
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAdsortTransformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAdsortTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IAdsortTransformVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IAdsortTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyTable(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x020082C5 RID: 33477
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144B0 RID: 83120
			public static VerifyTableAction <0>__Verify;
		}
	}
}
