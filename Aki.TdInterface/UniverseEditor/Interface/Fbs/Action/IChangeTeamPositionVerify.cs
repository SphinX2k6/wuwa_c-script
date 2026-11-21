using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699C RID: 27036
	public static class IChangeTeamPositionVerify
	{
		// Token: 0x0602E60E RID: 189966 RVA: 0x00654810 File Offset: 0x00652A10
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IChangeTeamPositionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeTeamPositionVerify.<>O.<0>__Verify = new VerifyUnionAction(TTeamTypeVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008584 RID: 34180
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401491E RID: 84254
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
