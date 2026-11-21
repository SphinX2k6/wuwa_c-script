using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004339 RID: 17209
	public static class ILevelPlayInformationVerify
	{
		// Token: 0x0601836E RID: 99182 RVA: 0x00373A48 File Offset: 0x00371C48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayInformationVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayInformationVerify.<>O.<0>__Verify = new VerifyTableAction(IInformationSubTitleVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008147 RID: 33095
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014220 RID: 82464
			public static VerifyTableAction <0>__Verify;
		}
	}
}
