using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004528 RID: 17704
	public static class IRoleTowerSystemVarVerify
	{
		// Token: 0x06019A0D RID: 104973 RVA: 0x003A6998 File Offset: 0x003A4B98
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IRoleTowerSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRoleTowerSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008195 RID: 33173
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040142D2 RID: 82642
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
