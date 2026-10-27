using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EFA RID: 20218
	public static class IBatchBulletCasterComponentVerify
	{
		// Token: 0x0601FF03 RID: 130819 RVA: 0x00471F18 File Offset: 0x00470118
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBatchBulletCasterComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBatchBulletCasterComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IPosRotVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 12;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IBatchBulletCasterComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IBatchBulletCasterComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IBatchBulletItemVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A8A RID: 31370
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013464 RID: 78948
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04013465 RID: 78949
			public static VerifyTableAction <1>__Verify;
		}
	}
}
