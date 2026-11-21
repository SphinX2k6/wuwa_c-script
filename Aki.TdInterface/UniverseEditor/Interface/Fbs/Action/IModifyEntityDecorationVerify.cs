using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F1 RID: 29169
	public static class IModifyEntityDecorationVerify
	{
		// Token: 0x06032BF5 RID: 207861 RVA: 0x006DAEC8 File Offset: 0x006D90C8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IModifyEntityDecorationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IModifyEntityDecorationVerify.<>O.<0>__Verify = new VerifyUnionAction(TEntityDecorationConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008632 RID: 34354
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A05 RID: 84485
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
