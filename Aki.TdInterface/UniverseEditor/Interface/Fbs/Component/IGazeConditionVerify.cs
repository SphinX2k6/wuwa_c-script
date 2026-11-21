using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005873 RID: 22643
	public static class IGazeConditionVerify
	{
		// Token: 0x06024B3B RID: 150331 RVA: 0x0050AA40 File Offset: 0x00508C40
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

		// Token: 0x0200839C RID: 33692
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014608 RID: 83464
			public static VerifyTableAction <0>__Verify;
		}
	}
}
