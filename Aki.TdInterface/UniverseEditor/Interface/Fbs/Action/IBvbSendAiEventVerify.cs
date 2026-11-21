using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D0 RID: 26832
	public static class IBvbSendAiEventVerify
	{
		// Token: 0x0602DE88 RID: 188040 RVA: 0x00645F94 File Offset: 0x00644194
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IBvbSendAiEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBvbSendAiEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TBvbEventDataVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200856E RID: 34158
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014902 RID: 84226
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
