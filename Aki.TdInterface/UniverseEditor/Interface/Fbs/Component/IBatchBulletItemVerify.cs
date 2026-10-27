using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EFD RID: 20221
	public static class IBatchBulletItemVerify
	{
		// Token: 0x0601FF1F RID: 130847 RVA: 0x0047231C File Offset: 0x0047051C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IBatchBulletItemVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IBatchBulletItemVerify.<>O.<0>__Verify = new VerifyTableAction(IBatchBulletCasterVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A8B RID: 31371
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013466 RID: 78950
			public static VerifyTableAction <0>__Verify;
		}
	}
}
