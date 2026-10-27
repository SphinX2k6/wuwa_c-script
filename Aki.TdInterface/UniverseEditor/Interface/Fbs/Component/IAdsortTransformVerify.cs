using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E6A RID: 20074
	public static class IAdsortTransformVerify
	{
		// Token: 0x0601F867 RID: 129127 RVA: 0x0046400C File Offset: 0x0046220C
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

		// Token: 0x02007A73 RID: 31347
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013440 RID: 78912
			public static VerifyTableAction <0>__Verify;
		}
	}
}
