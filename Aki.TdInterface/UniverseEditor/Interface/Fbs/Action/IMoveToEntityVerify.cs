using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072A5 RID: 29349
	public static class IMoveToEntityVerify
	{
		// Token: 0x06033259 RID: 209497 RVA: 0x006E6ABC File Offset: 0x006E4CBC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMoveToEntityVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMoveToEntityVerify.<>O.<0>__Verify = new VerifyUnionAction(TMoveToPointTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008644 RID: 34372
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A19 RID: 84505
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
