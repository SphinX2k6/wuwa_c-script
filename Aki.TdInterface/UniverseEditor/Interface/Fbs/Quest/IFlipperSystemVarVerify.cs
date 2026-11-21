using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A6 RID: 17062
	public static class IFlipperSystemVarVerify
	{
		// Token: 0x06017E29 RID: 97833 RVA: 0x003694A8 File Offset: 0x003676A8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFlipperSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFlipperSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008131 RID: 33073
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014201 RID: 82433
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
