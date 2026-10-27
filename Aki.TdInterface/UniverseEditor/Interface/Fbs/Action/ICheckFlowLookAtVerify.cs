using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200635D RID: 25437
	public static class ICheckFlowLookAtVerify
	{
		// Token: 0x0602C018 RID: 180248 RVA: 0x0060C080 File Offset: 0x0060A280
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICheckFlowLookAtVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICheckFlowLookAtVerify.<>O.<0>__Verify = new VerifyTableAction(ICheckFlowLookAtConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D16 RID: 32022
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401387B RID: 79995
			public static VerifyTableAction <0>__Verify;
		}
	}
}
