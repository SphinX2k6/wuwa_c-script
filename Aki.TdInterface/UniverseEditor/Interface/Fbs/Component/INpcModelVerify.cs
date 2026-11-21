using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC6 RID: 23494
	public static class INpcModelVerify
	{
		// Token: 0x06026C09 RID: 158729 RVA: 0x0054DD98 File Offset: 0x0054BF98
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = INpcModelVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcModelVerify.<>O.<0>__Verify = new VerifyUnionAction(TNpcModelTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyVectorOfStrings(tablePos, 14, false) && verifier.VerifyVectorOfStrings(tablePos, 16, false) && verifier.VerifyField(tablePos, 18, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 20, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 22, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200840D RID: 33805
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040146D1 RID: 83665
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
