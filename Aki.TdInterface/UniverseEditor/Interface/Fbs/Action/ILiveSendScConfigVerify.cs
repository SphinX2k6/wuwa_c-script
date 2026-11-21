using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007126 RID: 28966
	public static class ILiveSendScConfigVerify
	{
		// Token: 0x0603251A RID: 206106 RVA: 0x006CDA44 File Offset: 0x006CBC44
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILiveSendScConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILiveSendScConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ILiveScConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008618 RID: 34328
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149E2 RID: 84450
			public static VerifyTableAction <0>__Verify;
		}
	}
}
