using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007396 RID: 29590
	public static class IOpenSkiConfigVerify
	{
		// Token: 0x06033AF8 RID: 211704 RVA: 0x006F7FF0 File Offset: 0x006F61F0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IOpenSkiConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IOpenSkiConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TTargetEntityVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyString(tablePos, 10, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008664 RID: 34404
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A43 RID: 84547
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
