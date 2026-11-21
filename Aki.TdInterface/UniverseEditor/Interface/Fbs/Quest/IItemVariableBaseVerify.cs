using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004300 RID: 17152
	public static class IItemVariableBaseVerify
	{
		// Token: 0x0601819E RID: 98718 RVA: 0x00370444 File Offset: 0x0036E644
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IItemVariableBaseVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IItemVariableBaseVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008141 RID: 33089
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014217 RID: 82455
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
