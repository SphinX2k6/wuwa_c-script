using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007219 RID: 29209
	public static class ISubScreenModeExitVerify
	{
		// Token: 0x06033CF5 RID: 212213 RVA: 0x006F8F1C File Offset: 0x006F711C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISubScreenModeExitVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISubScreenModeExitVerify.<>O.<0>__Verify = new VerifyTableAction(ISetSubScreenDataVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E77 RID: 32375
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A5B RID: 80475
			public static VerifyTableAction <0>__Verify;
		}
	}
}
