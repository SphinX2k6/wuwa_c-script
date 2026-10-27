using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BD0 RID: 15312
	public static class IShowTimelineTrackVerify
	{
		// Token: 0x060150D8 RID: 86232 RVA: 0x0030D471 File Offset: 0x0030B671
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IShowTimelineTrackVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IShowTimelineTrackVerify.<>O.<0>__Verify = new VerifyTableAction(IShowTimelineFrameVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007892 RID: 30866
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040130FF RID: 78079
			public static VerifyTableAction <0>__Verify;
		}
	}
}
