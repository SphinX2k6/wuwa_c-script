using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005917 RID: 22807
	public static class IHitLogicChangeByPartHitVerify
	{
		// Token: 0x06025149 RID: 151881 RVA: 0x00516F40 File Offset: 0x00515140
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

		// Token: 0x020083B6 RID: 33718
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014630 RID: 83504
			public static VerifyTableAction <0>__Verify;
		}
	}
}
