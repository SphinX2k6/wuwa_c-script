using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062B6 RID: 25270
	public static class ICatapultVerify
	{
		// Token: 0x0602BAB4 RID: 178868 RVA: 0x00602BA4 File Offset: 0x00600DA4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICatapultVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICatapultVerify.<>O.<0>__Verify = new VerifyTableAction(ICatapultParamVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D08 RID: 32008
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401386B RID: 79979
			public static VerifyTableAction <0>__Verify;
		}
	}
}
