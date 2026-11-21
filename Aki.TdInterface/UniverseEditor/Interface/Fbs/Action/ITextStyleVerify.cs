using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BB9 RID: 31673
	public static class ITextStyleVerify
	{
		// Token: 0x06039159 RID: 233817 RVA: 0x007B7178 File Offset: 0x007B5378
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ITextStyleVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITextStyleVerify.<>O.<0>__Verify = new VerifyUnionAction(TCenterTextShowAnimVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200873B RID: 34619
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014CBB RID: 85179
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
