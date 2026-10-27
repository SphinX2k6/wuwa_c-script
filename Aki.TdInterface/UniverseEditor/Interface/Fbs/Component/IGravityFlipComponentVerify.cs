using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005323 RID: 21283
	public static class IGravityFlipComponentVerify
	{
		// Token: 0x06022C77 RID: 142455 RVA: 0x004D1770 File Offset: 0x004CF970
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGravityFlipComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGravityFlipComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IGravityFlipConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B47 RID: 31559
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013590 RID: 79248
			public static VerifyTableAction <0>__Verify;
		}
	}
}
