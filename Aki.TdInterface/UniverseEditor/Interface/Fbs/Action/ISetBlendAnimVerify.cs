using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007799 RID: 30617
	public static class ISetBlendAnimVerify
	{
		// Token: 0x06035BE2 RID: 220130 RVA: 0x007335AC File Offset: 0x007317AC
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

		// Token: 0x020086CA RID: 34506
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AC4 RID: 84676
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014AC5 RID: 84677
			public static VerifyUnionAction <1>__Verify;
		}
	}
}
