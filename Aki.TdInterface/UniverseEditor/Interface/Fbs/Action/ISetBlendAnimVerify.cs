using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD0 RID: 28624
	public static class ISetBlendAnimVerify
	{
		// Token: 0x0603297C RID: 207228 RVA: 0x006D3968 File Offset: 0x006D1B68
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetBlendAnimVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetBlendAnimVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayerBlendAnimTargetVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					short typeIdVOffset = 6;
					short valueVOffset = 8;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = ISetBlendAnimVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISetBlendAnimVerify.<>O.<1>__Verify = new VerifyUnionAction(TBlendAnimTypeVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007E35 RID: 32309
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139F3 RID: 80371
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040139F4 RID: 80372
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
