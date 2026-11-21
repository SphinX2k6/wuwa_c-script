using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004366 RID: 17254
	public static class IMechaTrackScoreMechanismStateVerify
	{
		// Token: 0x060185B3 RID: 99763 RVA: 0x003792FC File Offset: 0x003774FC
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

		// Token: 0x0200814E RID: 33102
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401423A RID: 82490
			public static VerifyTableAction <0>__Verify;
		}
	}
}
