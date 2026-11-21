using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E6D RID: 15981
	public static class IConstVarRefVerify
	{
		// Token: 0x0601589F RID: 88223 RVA: 0x0031B040 File Offset: 0x00319240
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IConstVarRefVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConstVarRefVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarValueVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020080B8 RID: 32952
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014137 RID: 82231
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
