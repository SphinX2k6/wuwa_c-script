using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E44 RID: 24132
	public static class IProcessedValueConstraintVerify
	{
		// Token: 0x06029500 RID: 169216 RVA: 0x005AA104 File Offset: 0x005A8304
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IProcessedValueConstraintVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProcessedValueConstraintVerify.<>O.<0>__Verify = new VerifyUnionAction(TConstraintValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CB3 RID: 31923
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137E1 RID: 79841
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
