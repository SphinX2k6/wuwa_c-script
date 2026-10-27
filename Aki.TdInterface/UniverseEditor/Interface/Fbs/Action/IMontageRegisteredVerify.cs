using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B05 RID: 27397
	public static class IMontageRegisteredVerify
	{
		// Token: 0x060300CD RID: 196813 RVA: 0x00688538 File Offset: 0x00686738
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMontageRegisteredVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMontageRegisteredVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DB1 RID: 32177
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401394F RID: 80207
			public static VerifyTableAction <0>__Verify;
		}
	}
}
