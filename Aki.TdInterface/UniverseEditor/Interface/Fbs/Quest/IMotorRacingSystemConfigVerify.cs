using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F4C RID: 16204
	public static class IMotorRacingSystemConfigVerify
	{
		// Token: 0x060170A9 RID: 94377 RVA: 0x0035290C File Offset: 0x00350B0C
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

		// Token: 0x0200790D RID: 30989
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131E2 RID: 78306
			public static VerifyTableAction <0>__Verify;
		}
	}
}
