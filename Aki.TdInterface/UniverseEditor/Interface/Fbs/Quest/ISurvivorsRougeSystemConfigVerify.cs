using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200416E RID: 16750
	public static class ISurvivorsRougeSystemConfigVerify
	{
		// Token: 0x060189A9 RID: 100777 RVA: 0x0038B3B0 File Offset: 0x003895B0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISurvivorsRougeSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISurvivorsRougeSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ISurvivorsRougeSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007958 RID: 31064
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132A5 RID: 78501
			public static VerifyTableAction <0>__Verify;
		}
	}
}
