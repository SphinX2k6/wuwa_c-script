using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065FC RID: 26108
	public static class IDoCalculateVerify
	{
		// Token: 0x0602D54C RID: 185676 RVA: 0x006369C8 File Offset: 0x00634BC8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IDoCalculateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDoCalculateVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					short typeIdVOffset2 = 10;
					short valueVOffset2 = 12;
					VerifyUnionAction verifyAction2;
					if ((verifyAction2 = IDoCalculateVerify.<>O.<0>__Verify) == null)
					{
						verifyAction2 = (IDoCalculateVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarValueVerify.Verify));
					}
					if (verifier.VerifyUnion(tablePos, typeIdVOffset2, valueVOffset2, verifyAction2, false) && verifier.VerifyString(tablePos, 14, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007D44 RID: 32068
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040138BE RID: 80062
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
