using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB8 RID: 28088
	public static class IProjectionMachineVerify
	{
		// Token: 0x060319DC RID: 203228 RVA: 0x006B9074 File Offset: 0x006B7274
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = IProjectionMachineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IProjectionMachineVerify.<>O.<0>__Verify = new VerifyTableAction(IProjectionMachinePhotoFilterVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E07 RID: 32263
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139C2 RID: 80322
			public static VerifyTableAction <0>__Verify;
		}
	}
}
