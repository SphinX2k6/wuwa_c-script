using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004330 RID: 17200
	public static class IKurotatoSystemConfigVerify
	{
		// Token: 0x0601831D RID: 99101 RVA: 0x00372F40 File Offset: 0x00371140
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

		// Token: 0x02008144 RID: 33092
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401421D RID: 82461
			public static VerifyTableAction <0>__Verify;
		}
	}
}
