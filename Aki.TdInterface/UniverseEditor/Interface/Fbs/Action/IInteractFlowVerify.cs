using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006989 RID: 27017
	public static class IInteractFlowVerify
	{
		// Token: 0x0602F2F5 RID: 193269 RVA: 0x0066D5C4 File Offset: 0x0066B7C4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IInteractFlowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IInteractFlowVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D8E RID: 32142
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013918 RID: 80152
			public static VerifyTableAction <0>__Verify;
		}
	}
}
