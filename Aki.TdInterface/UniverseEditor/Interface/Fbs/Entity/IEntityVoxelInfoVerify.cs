using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047E0 RID: 18400
	public static class IEntityVoxelInfoVerify
	{
		// Token: 0x0601C72D RID: 116525 RVA: 0x00406674 File Offset: 0x00404874
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IEntityVoxelInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IEntityVoxelInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IVoxelInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A01 RID: 31233
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040133B0 RID: 78768
			public static VerifyTableAction <0>__Verify;
		}
	}
}
