using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C51 RID: 19537
	public static class ILevelVoxelInfoVerify
	{
		// Token: 0x0601DF78 RID: 122744 RVA: 0x0043391C File Offset: 0x00431B1C
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

		// Token: 0x0200824C RID: 33356
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014419 RID: 82969
			public static VerifyTableAction <0>__Verify;
		}
	}
}
