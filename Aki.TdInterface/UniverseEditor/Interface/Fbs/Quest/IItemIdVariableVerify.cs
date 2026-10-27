using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EB9 RID: 16057
	public static class IItemIdVariableVerify
	{
		// Token: 0x06016AF1 RID: 92913 RVA: 0x00346748 File Offset: 0x00344948
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IItemIdVariableVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemIdVariableVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020078F9 RID: 30969
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040131B7 RID: 78263
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
