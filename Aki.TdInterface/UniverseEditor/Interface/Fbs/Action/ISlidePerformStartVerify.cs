using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007144 RID: 28996
	public static class ISlidePerformStartVerify
	{
		// Token: 0x0603367B RID: 210555 RVA: 0x006ED5AC File Offset: 0x006EB7AC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISlidePerformStartVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISlidePerformStartVerify.<>O.<0>__Verify = new VerifyTableAction(ISlopeSlidePerformStartVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E64 RID: 32356
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A41 RID: 80449
			public static VerifyTableAction <0>__Verify;
		}
	}
}
