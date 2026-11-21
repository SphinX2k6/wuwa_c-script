using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200608B RID: 24715
	public static class ITimelineTrackControlComponentVerify
	{
		// Token: 0x06029CD2 RID: 171218 RVA: 0x005B508C File Offset: 0x005B328C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITimelineTrackControlComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITimelineTrackControlComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITimelineControlGroupVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084CE RID: 33998
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014814 RID: 83988
			public static VerifyTableAction <0>__Verify;
		}
	}
}
