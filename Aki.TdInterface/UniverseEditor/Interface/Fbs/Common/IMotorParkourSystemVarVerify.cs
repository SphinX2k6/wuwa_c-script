using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200644B RID: 25675
	public static class IMotorParkourSystemVarVerify
	{
		// Token: 0x0602BA1A RID: 178714 RVA: 0x005F07A8 File Offset: 0x005EE9A8
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

		// Token: 0x02008520 RID: 34080
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014882 RID: 84098
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
