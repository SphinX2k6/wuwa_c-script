using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200425E RID: 16990
	public static class IUseVarVerify
	{
		// Token: 0x0601924C RID: 102988 RVA: 0x0039D430 File Offset: 0x0039B630
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IUseVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IUseVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200797B RID: 31099
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132F4 RID: 78580
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
