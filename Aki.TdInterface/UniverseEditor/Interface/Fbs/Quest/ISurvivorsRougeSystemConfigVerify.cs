using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045B2 RID: 17842
	public static class ISurvivorsRougeSystemConfigVerify
	{
		// Token: 0x0601A071 RID: 106609 RVA: 0x003B596C File Offset: 0x003B3B6C
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

		// Token: 0x020081A0 RID: 33184
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014309 RID: 82697
			public static VerifyTableAction <0>__Verify;
		}
	}
}
