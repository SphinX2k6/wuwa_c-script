using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E78 RID: 28280
	public static class IReportTrackingEventVerify
	{
		// Token: 0x06031FC0 RID: 204736 RVA: 0x006C2FF8 File Offset: 0x006C11F8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IReportTrackingEventVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IReportTrackingEventVerify.<>O.<0>__Verify = new VerifyUnionAction(TTrackingEventTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E12 RID: 32274
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139CD RID: 80333
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
