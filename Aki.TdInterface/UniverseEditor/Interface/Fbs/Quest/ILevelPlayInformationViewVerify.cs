using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200433C RID: 17212
	public static class ILevelPlayInformationViewVerify
	{
		// Token: 0x0601838A RID: 99210 RVA: 0x00373DF0 File Offset: 0x00371FF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayInformationViewVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayInformationViewVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelPlayInformationVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008148 RID: 33096
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014221 RID: 82465
			public static VerifyTableAction <0>__Verify;
		}
	}
}
