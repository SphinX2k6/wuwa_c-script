using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004387 RID: 17287
	public static class IMotorFightSystemVarVerify
	{
		// Token: 0x060186EB RID: 100075 RVA: 0x0037B948 File Offset: 0x00379B48
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMotorFightSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorFightSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008152 RID: 33106
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014241 RID: 82497
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
