using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200438A RID: 17290
	public static class IMotorRacingSystemConfigVerify
	{
		// Token: 0x0601870B RID: 100107 RVA: 0x0037BD80 File Offset: 0x00379F80
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IMotorRacingSystemConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorRacingSystemConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IMotorParkourSystemVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008153 RID: 33107
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014242 RID: 82498
			public static VerifyTableAction <0>__Verify;
		}
	}
}
