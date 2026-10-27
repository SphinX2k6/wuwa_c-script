using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F51 RID: 20305
	public static class ICalculateComponentVerify
	{
		// Token: 0x060202CE RID: 131790 RVA: 0x0047A2E0 File Offset: 0x004784E0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICalculateComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICalculateComponentVerify.<>O.<0>__Verify = new VerifyTableAction(INumberVarVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 8;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ICalculateComponentVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ICalculateComponentVerify.<>O.<1>__Verify = new VerifyTableAction(IFunctionVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007A9B RID: 31387
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401347D RID: 78973
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401347E RID: 78974
			public static VerifyTableAction <1>__Verify;
		}
	}
}
