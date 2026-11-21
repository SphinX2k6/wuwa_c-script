using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200678F RID: 26511
	public static class IAddFlowInteractOptionVerify
	{
		// Token: 0x0602CF51 RID: 184145 RVA: 0x00625180 File Offset: 0x00623380
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

		// Token: 0x0200854C RID: 34124
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040148B5 RID: 84149
			public static VerifyTableAction <0>__Verify;
		}
	}
}
