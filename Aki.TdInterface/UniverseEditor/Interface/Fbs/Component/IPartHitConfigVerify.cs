using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C5F RID: 23647
	public static class IPartHitConfigVerify
	{
		// Token: 0x060273C0 RID: 160704 RVA: 0x0055FFD0 File Offset: 0x0055E1D0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IPartHitConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPartHitConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(THitBulletTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IPartHitConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IPartHitConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008429 RID: 33833
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014708 RID: 83720
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x04014709 RID: 83721
			public static VerifyTableAction <1>__Verify;
		}
	}
}
