using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003FBB RID: 16315
	public static class IProgressBarVerify
	{
		// Token: 0x06017547 RID: 95559 RVA: 0x0035CE3C File Offset: 0x0035B03C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProgressBarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProgressBarVerify.<>O.<0>__Verify = new VerifyTableAction(IProgressCalculateVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007921 RID: 31009
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401320F RID: 78351
			public static VerifyTableAction <0>__Verify;
		}
	}
}
