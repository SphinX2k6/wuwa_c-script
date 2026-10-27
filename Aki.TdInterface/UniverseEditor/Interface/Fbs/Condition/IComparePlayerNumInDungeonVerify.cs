using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BC4 RID: 19396
	public static class IComparePlayerNumInDungeonVerify
	{
		// Token: 0x0601E9BC RID: 125372 RVA: 0x00447DD4 File Offset: 0x00445FD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short typeIdVOffset = 8;
				short valueVOffset = 10;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IComparePlayerNumInDungeonVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IComparePlayerNumInDungeonVerify.<>O.<0>__Verify = new VerifyUnionAction(TVarRefVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007A55 RID: 31317
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401341D RID: 78877
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
