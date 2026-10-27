using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045E6 RID: 17894
	public static class ITwoDimensionTransformVerify
	{
		// Token: 0x0601B180 RID: 110976 RVA: 0x003DC648 File Offset: 0x003DA848
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

		// Token: 0x020079C7 RID: 31175
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013363 RID: 78691
			public static VerifyTableAction <0>__Verify;
		}
	}
}
