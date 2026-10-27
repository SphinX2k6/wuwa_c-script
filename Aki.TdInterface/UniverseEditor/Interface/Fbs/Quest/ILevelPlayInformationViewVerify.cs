using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EFE RID: 16126
	public static class ILevelPlayInformationViewVerify
	{
		// Token: 0x06016D33 RID: 93491 RVA: 0x0034AC24 File Offset: 0x00348E24
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

		// Token: 0x02007902 RID: 30978
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131C2 RID: 78274
			public static VerifyTableAction <0>__Verify;
		}
	}
}
