using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200455C RID: 17756
	public static class IRollBlockGlobalConfigVerify
	{
		// Token: 0x0601ABC0 RID: 109504 RVA: 0x003D008C File Offset: 0x003CE28C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRollBlockGlobalConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRollBlockGlobalConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRollBlockLevelConfigVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020079B7 RID: 31159
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013352 RID: 78674
			public static VerifyTableAction <0>__Verify;
		}
	}
}
