using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F49 RID: 16201
	public static class IMotorFightSystemVarVerify
	{
		// Token: 0x06017089 RID: 94345 RVA: 0x003524D4 File Offset: 0x003506D4
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

		// Token: 0x0200790C RID: 30988
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131E1 RID: 78305
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
