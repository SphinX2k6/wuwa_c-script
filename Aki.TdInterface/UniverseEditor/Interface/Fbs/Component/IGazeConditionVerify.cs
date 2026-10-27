using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052F0 RID: 21232
	public static class IGazeConditionVerify
	{
		// Token: 0x06022AA1 RID: 141985 RVA: 0x004CDF14 File Offset: 0x004CC114
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IGazeConditionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IGazeConditionVerify.<>O.<0>__Verify = new VerifyTableAction(IConeTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007B3E RID: 31550
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013584 RID: 79236
			public static VerifyTableAction <0>__Verify;
		}
	}
}
