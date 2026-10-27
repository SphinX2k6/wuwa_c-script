using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200612A RID: 24874
	public static class IAddFlowInteractOptionVerify
	{
		// Token: 0x0602A858 RID: 174168 RVA: 0x005DAFA4 File Offset: 0x005D91A4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IAddFlowInteractOptionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IAddFlowInteractOptionVerify.<>O.<0>__Verify = new VerifyTableAction(IInteractOptionVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CDB RID: 31963
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401380F RID: 79887
			public static VerifyTableAction <0>__Verify;
		}
	}
}
