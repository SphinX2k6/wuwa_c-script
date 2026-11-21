using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542F RID: 21551
	public static class IBatchBulletItemVerify
	{
		// Token: 0x06021C8F RID: 138383 RVA: 0x004A86B0 File Offset: 0x004A68B0
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

		// Token: 0x020082E2 RID: 33506
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040144DD RID: 83165
			public static VerifyTableAction <0>__Verify;
		}
	}
}
