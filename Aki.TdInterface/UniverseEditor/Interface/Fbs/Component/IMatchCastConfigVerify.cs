using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005523 RID: 21795
	public static class IMatchCastConfigVerify
	{
		// Token: 0x0602400E RID: 147470 RVA: 0x004F99D4 File Offset: 0x004F7BD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMatchCastConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMatchCastConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMatchSequenceVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B89 RID: 31625
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401360D RID: 79373
			public static VerifyTableAction <0>__Verify;
		}
	}
}
