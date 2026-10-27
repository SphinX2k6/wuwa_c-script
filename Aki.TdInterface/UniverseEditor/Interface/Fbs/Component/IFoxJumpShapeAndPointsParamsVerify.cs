using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052D2 RID: 21202
	public static class IFoxJumpShapeAndPointsParamsVerify
	{
		// Token: 0x06022984 RID: 141700 RVA: 0x004CBA24 File Offset: 0x004C9C24
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

		// Token: 0x02007B37 RID: 31543
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013579 RID: 79225
			public static VerifyTableAction <0>__Verify;

			// Token: 0x0401357A RID: 79226
			public static VerifyTableAction <1>__Verify;
		}
	}
}
