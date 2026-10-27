using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200428E RID: 17038
	public static class IWarningPreformVerify
	{
		// Token: 0x060193E4 RID: 103396 RVA: 0x003A0660 File Offset: 0x0039E860
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short typeIdVOffset = 4;
				short valueVOffset = 6;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IWarningPreformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWarningPreformVerify.<>O.<0>__Verify = new VerifyUnionAction(TWarningPreformConfigVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007982 RID: 31106
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040132FE RID: 78590
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
