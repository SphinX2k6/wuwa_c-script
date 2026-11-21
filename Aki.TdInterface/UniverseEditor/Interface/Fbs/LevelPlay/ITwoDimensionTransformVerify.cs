using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A4E RID: 19022
	public static class ITwoDimensionTransformVerify
	{
		// Token: 0x0601C955 RID: 117077 RVA: 0x004088E4 File Offset: 0x00406AE4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITwoDimensionTransformVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITwoDimensionTransformVerify.<>O.<0>__Verify = new VerifyTableAction(IVector2Verify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008210 RID: 33296
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040143CA RID: 82890
			public static VerifyTableAction <0>__Verify;
		}
	}
}
