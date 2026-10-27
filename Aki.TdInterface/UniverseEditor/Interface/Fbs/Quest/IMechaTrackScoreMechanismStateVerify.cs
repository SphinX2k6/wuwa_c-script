using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F28 RID: 16168
	public static class IMechaTrackScoreMechanismStateVerify
	{
		// Token: 0x06016F5B RID: 94043 RVA: 0x003500D4 File Offset: 0x0034E2D4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMechaTrackScoreMechanismStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMechaTrackScoreMechanismStateVerify.<>O.<0>__Verify = new VerifyTableAction(IMechaTrackScoreMechanismStateTypeVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007908 RID: 30984
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131DB RID: 78299
			public static VerifyTableAction <0>__Verify;
		}
	}
}
