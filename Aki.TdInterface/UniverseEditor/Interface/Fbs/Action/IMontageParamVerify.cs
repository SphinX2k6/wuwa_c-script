using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B02 RID: 27394
	public static class IMontageParamVerify
	{
		// Token: 0x060300B7 RID: 196791 RVA: 0x0068827C File Offset: 0x0068647C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMontageParamVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMontageParamVerify.<>O.<0>__Verify = new VerifyTableAction(IMontageIdVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DB0 RID: 32176
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401394E RID: 80206
			public static VerifyTableAction <0>__Verify;
		}
	}
}
