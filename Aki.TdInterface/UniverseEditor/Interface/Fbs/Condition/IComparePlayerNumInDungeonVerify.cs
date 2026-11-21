using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050AE RID: 20654
	public static class IComparePlayerNumInDungeonVerify
	{
		// Token: 0x06020568 RID: 132456 RVA: 0x0047A938 File Offset: 0x00478B38
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

		// Token: 0x020082A7 RID: 33447
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401448D RID: 83085
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
