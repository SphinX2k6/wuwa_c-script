using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047E9 RID: 18409
	public static class ILevelVoxelInfoVerify
	{
		// Token: 0x0601C77B RID: 116603 RVA: 0x00406FCC File Offset: 0x004051CC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ILevelVoxelInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ILevelVoxelInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IEntityVoxelInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A03 RID: 31235
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133B2 RID: 78770
			public static VerifyTableAction <0>__Verify;
		}
	}
}
