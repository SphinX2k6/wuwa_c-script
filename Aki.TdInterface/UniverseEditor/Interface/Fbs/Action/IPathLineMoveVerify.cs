using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D8 RID: 29656
	public static class IPathLineMoveVerify
	{
		// Token: 0x06033E1F RID: 212511 RVA: 0x006FF0EC File Offset: 0x006FD2EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
			{
				short typeIdVOffset = 18;
				short valueVOffset = 20;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPathLineMoveVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPathLineMoveVerify.<>O.<0>__Verify = new VerifyUnionAction(TPathLineFacingConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 22, false) && verifier.VerifyField(tablePos, 24, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 26, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 28, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 30, 2UL, 2UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200866C RID: 34412
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A56 RID: 84566
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
