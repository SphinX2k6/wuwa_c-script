using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F04 RID: 16132
	public static class ILevelPlayRecallDataVerify
	{
		// Token: 0x06016D6B RID: 93547 RVA: 0x0034B258 File Offset: 0x00349458
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelPlayRecallDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelPlayRecallDataVerify.<>O.<0>__Verify = new VerifyTableAction(ILevelPlayRecallConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007903 RID: 30979
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131C3 RID: 78275
			public static VerifyTableAction <0>__Verify;
		}
	}
}
