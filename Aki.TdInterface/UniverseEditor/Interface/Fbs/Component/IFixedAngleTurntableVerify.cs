using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005269 RID: 21097
	public static class IFixedAngleTurntableVerify
	{
		// Token: 0x0602252E RID: 140590 RVA: 0x004C2164 File Offset: 0x004C0364
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFixedAngleTurntableVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFixedAngleTurntableVerify.<>O.<0>__Verify = new VerifyTableAction(IFixedAngleItemVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B21 RID: 31521
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013558 RID: 79192
			public static VerifyTableAction <0>__Verify;
		}
	}
}
