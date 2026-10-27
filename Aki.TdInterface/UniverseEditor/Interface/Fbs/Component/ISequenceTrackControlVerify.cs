using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058FF RID: 22783
	public static class ISequenceTrackControlVerify
	{
		// Token: 0x06026809 RID: 157705 RVA: 0x0054E188 File Offset: 0x0054C388
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

		// Token: 0x02007C29 RID: 31785
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401370F RID: 79631
			public static VerifyTableAction <0>__Verify;
		}
	}
}
