using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EF2 RID: 16114
	public static class IKurotatoSystemConfigVerify
	{
		// Token: 0x06016CC6 RID: 93382 RVA: 0x00349D74 File Offset: 0x00347F74
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IKurotatoSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IKurotatoSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IKurotatoSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078FE RID: 30974
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131BE RID: 78270
			public static VerifyTableAction <0>__Verify;
		}
	}
}
