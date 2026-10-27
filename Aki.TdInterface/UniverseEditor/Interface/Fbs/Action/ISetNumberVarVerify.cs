using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007048 RID: 28744
	public static class ISetNumberVarVerify
	{
		// Token: 0x06032DD4 RID: 208340 RVA: 0x006DC664 File Offset: 0x006DA864
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISetNumberVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetNumberVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E49 RID: 32329
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013A14 RID: 80404
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
