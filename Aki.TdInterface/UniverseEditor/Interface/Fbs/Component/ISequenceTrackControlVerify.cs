using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F0C RID: 24332
	public static class ISequenceTrackControlVerify
	{
		// Token: 0x06028D73 RID: 167283 RVA: 0x00594DF4 File Offset: 0x00592FF4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISequenceTrackControlVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISequenceTrackControlVerify.<>O.<0>__Verify = new VerifyTableAction(ISequenceTrackControlPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008498 RID: 33944
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040147B1 RID: 83889
			public static VerifyTableAction <0>__Verify;
		}
	}
}
