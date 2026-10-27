using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005556 RID: 21846
	public static class IMismatchCastConfigVerify
	{
		// Token: 0x060241EC RID: 147948 RVA: 0x004FD57C File Offset: 0x004FB77C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMismatchCastConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMismatchCastConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMismatchSequenceVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B8F RID: 31631
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013617 RID: 79383
			public static VerifyTableAction <0>__Verify;
		}
	}
}
