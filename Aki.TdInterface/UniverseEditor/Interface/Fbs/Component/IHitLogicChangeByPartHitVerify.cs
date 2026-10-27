using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005391 RID: 21393
	public static class IHitLogicChangeByPartHitVerify
	{
		// Token: 0x06023095 RID: 143509 RVA: 0x004DA06C File Offset: 0x004D826C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IHitLogicChangeByPartHitVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IHitLogicChangeByPartHitVerify.<>O.<0>__Verify = new VerifyTableAction(IPartHitConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B57 RID: 31575
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040135AB RID: 79275
			public static VerifyTableAction <0>__Verify;
		}
	}
}
