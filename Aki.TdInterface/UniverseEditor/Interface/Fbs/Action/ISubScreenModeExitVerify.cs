using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079EE RID: 31214
	public static class ISubScreenModeExitVerify
	{
		// Token: 0x06036FF7 RID: 225271 RVA: 0x0075A27C File Offset: 0x0075847C
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

		// Token: 0x0200870E RID: 34574
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014B32 RID: 84786
			public static VerifyTableAction <0>__Verify;
		}
	}
}
