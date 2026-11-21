using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004585 RID: 17797
	public static class ISpecificMonsterDeadPositionVerify
	{
		// Token: 0x06019EC7 RID: 106183 RVA: 0x003B2544 File Offset: 0x003B0744
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = ISpecificMonsterDeadPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISpecificMonsterDeadPositionVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200819C RID: 33180
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014303 RID: 82691
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
