using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E08 RID: 15880
	public static class IEntityDeadPositionVerify
	{
		// Token: 0x0601637F RID: 91007 RVA: 0x00335478 File Offset: 0x00333678
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IEntityDeadPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityDeadPositionVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078D6 RID: 30934
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401317A RID: 78202
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
