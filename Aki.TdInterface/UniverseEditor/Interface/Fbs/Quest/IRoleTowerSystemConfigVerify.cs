using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004525 RID: 17701
	public static class IRoleTowerSystemConfigVerify
	{
		// Token: 0x060199F0 RID: 104944 RVA: 0x003A651C File Offset: 0x003A471C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRoleTowerSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRoleTowerSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IRoleTowerSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008194 RID: 33172
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142D1 RID: 82641
			public static VerifyTableAction <0>__Verify;
		}
	}
}
