using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006978 RID: 27000
	public static class IChangeLiftTargetVerify
	{
		// Token: 0x0602E4DB RID: 189659 RVA: 0x00652794 File Offset: 0x00650994
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IChangeLiftTargetVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeLiftTargetVerify.<>O.<0>__Verify = new VerifyUnionAction(TLiftMoveTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008581 RID: 34177
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401491B RID: 84251
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
