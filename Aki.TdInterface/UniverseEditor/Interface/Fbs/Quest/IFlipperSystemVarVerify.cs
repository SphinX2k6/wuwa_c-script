using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E6B RID: 15979
	public static class IFlipperSystemVarVerify
	{
		// Token: 0x06016802 RID: 92162 RVA: 0x00340978 File Offset: 0x0033EB78
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

		// Token: 0x020078EB RID: 30955
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131A3 RID: 78243
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
