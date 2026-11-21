using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004333 RID: 17203
	public static class IKurotatoSystemVarVerify
	{
		// Token: 0x0601833A RID: 99130 RVA: 0x003733BC File Offset: 0x003715BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IKurotatoSystemVarVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IKurotatoSystemVarVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008145 RID: 33093
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401421E RID: 82462
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
