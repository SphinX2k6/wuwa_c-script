using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583D RID: 22589
	public static class IFoxJumpShapeAndPointsParamsVerify
	{
		// Token: 0x06024948 RID: 149832 RVA: 0x00506B20 File Offset: 0x00504D20
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFoxJumpShapeAndPointsParamsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFoxJumpShapeAndPointsParamsVerify.<>O.<0>__Verify = new VerifyTableAction(IBoxTriggerShapeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFoxJumpShapeAndPointsParamsVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFoxJumpShapeAndPointsParamsVerify.<>O.<1>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008393 RID: 33683
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145FA RID: 83450
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040145FB RID: 83451
			public static VerifyTableAction <1>__Verify;
		}
	}
}
