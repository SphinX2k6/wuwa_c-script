using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EFB RID: 16123
	public static class ILevelPlayInformationVerify
	{
		// Token: 0x06016D17 RID: 93463 RVA: 0x0034A87C File Offset: 0x00348A7C
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

		// Token: 0x02007901 RID: 30977
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131C1 RID: 78273
			public static VerifyTableAction <0>__Verify;
		}
	}
}
