using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075FC RID: 30204
	public static class IReportTrackingEventVerify
	{
		// Token: 0x06035000 RID: 217088 RVA: 0x0071ED2C File Offset: 0x0071CF2C
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

		// Token: 0x0200869E RID: 34462
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A91 RID: 84625
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
