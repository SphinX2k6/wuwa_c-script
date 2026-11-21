using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FDB RID: 16347
	public static class IShowTimelineTrackVerify
	{
		// Token: 0x060165CE RID: 91598 RVA: 0x00333FF9 File Offset: 0x003321F9
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

		// Token: 0x020080D6 RID: 32982
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401415B RID: 82267
			public static VerifyTableAction <0>__Verify;
		}
	}
}
