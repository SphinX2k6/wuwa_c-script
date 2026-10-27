using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005278 RID: 21112
	public static class IFixedStreamingSourceVerify
	{
		// Token: 0x060225E2 RID: 140770 RVA: 0x004C3A50 File Offset: 0x004C1C50
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixedStreamingSourceVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixedStreamingSourceVerify.<>O.<0>__Verify = new VerifyTableAction(IStreamingSourceConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B25 RID: 31525
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401355E RID: 79198
			public static VerifyTableAction <0>__Verify;
		}
	}
}
