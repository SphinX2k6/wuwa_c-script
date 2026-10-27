using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A2A RID: 23082
	public static class ITargetGearGroupComponentVerify
	{
		// Token: 0x0602739F RID: 160671 RVA: 0x00565A24 File Offset: 0x00563C24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITargetGearGroupComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITargetGearGroupComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ITargetGearGroupConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C52 RID: 31826
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013750 RID: 79696
			public static VerifyTableAction <0>__Verify;
		}
	}
}
