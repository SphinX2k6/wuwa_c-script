using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F97 RID: 28567
	public static class IHideGroupVerify
	{
		// Token: 0x0603174E RID: 202574 RVA: 0x006B46F4 File Offset: 0x006B28F4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IHideGroupVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHideGroupVerify.<>O.<0>__Verify = new VerifyUnionAction(THideGroupConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008601 RID: 34305
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149BE RID: 84414
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
