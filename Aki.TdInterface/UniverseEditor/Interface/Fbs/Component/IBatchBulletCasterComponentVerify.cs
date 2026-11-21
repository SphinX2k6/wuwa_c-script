using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542C RID: 21548
	public static class IBatchBulletCasterComponentVerify
	{
		// Token: 0x06021C73 RID: 138355 RVA: 0x004A82AC File Offset: 0x004A64AC
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

		// Token: 0x020082E1 RID: 33505
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144DB RID: 83163
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040144DC RID: 83164
			public static VerifyTableAction <1>__Verify;
		}
	}
}
