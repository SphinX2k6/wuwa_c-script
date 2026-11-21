using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C48 RID: 19528
	public static class IEntityVoxelInfoVerify
	{
		// Token: 0x0601DF2A RID: 122666 RVA: 0x00432FC4 File Offset: 0x004311C4
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

		// Token: 0x0200824A RID: 33354
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014417 RID: 82967
			public static VerifyTableAction <0>__Verify;
		}
	}
}
