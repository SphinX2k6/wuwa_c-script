using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E0E RID: 24078
	public static class IMotorParkourSystemVarVerify
	{
		// Token: 0x06029390 RID: 168848 RVA: 0x005A7A78 File Offset: 0x005A5C78
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IMotorParkourSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IMotorParkourSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007CAF RID: 31919
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137DC RID: 79836
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
