using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200710E RID: 28942
	public static class ILiveInteractScOptionVerify
	{
		// Token: 0x06032460 RID: 205920 RVA: 0x006CC624 File Offset: 0x006CA824
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILiveInteractScOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiveInteractScOptionVerify.<>O.<0>__Verify = new VerifyTableAction(ISystemOptionVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 10, 4UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008616 RID: 34326
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149E0 RID: 84448
			public static VerifyTableAction <0>__Verify;
		}
	}
}
