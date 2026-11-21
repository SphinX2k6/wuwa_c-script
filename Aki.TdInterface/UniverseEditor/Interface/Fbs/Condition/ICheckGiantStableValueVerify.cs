using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EFE RID: 20222
	public static class ICheckGiantStableValueVerify
	{
		// Token: 0x0601F694 RID: 128660 RVA: 0x00460134 File Offset: 0x0045E334
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ICheckGiantStableValueVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckGiantStableValueVerify.<>O.<0>__Verify = new VerifyUnionAction(TGiantStableValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008282 RID: 33410
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014464 RID: 83044
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
