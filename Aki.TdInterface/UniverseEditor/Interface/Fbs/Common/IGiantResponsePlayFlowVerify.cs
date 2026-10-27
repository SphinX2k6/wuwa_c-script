using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DC6 RID: 24006
	public static class IGiantResponsePlayFlowVerify
	{
		// Token: 0x0602916F RID: 168303 RVA: 0x005A3EB0 File Offset: 0x005A20B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGiantResponsePlayFlowVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGiantResponsePlayFlowVerify.<>O.<0>__Verify = new VerifyTableAction(IGiantFlowConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CA8 RID: 31912
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137D5 RID: 79829
			public static VerifyTableAction <0>__Verify;
		}
	}
}
