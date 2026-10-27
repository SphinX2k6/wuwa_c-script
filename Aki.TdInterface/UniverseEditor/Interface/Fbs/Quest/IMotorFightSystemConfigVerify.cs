using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F46 RID: 16198
	public static class IMotorFightSystemConfigVerify
	{
		// Token: 0x0601706C RID: 94316 RVA: 0x00352058 File Offset: 0x00350258
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorFightSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorFightSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMotorFightSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200790B RID: 30987
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131E0 RID: 78304
			public static VerifyTableAction <0>__Verify;
		}
	}
}
