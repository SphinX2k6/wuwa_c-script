using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F32 RID: 28466
	public static class ISceneInspectionPointVerify
	{
		// Token: 0x060324BE RID: 206014 RVA: 0x006CB1FC File Offset: 0x006C93FC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneInspectionPointVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneInspectionPointVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					short offsetId2 = 6;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = ISceneInspectionPointVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (ISceneInspectionPointVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId2, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02007E22 RID: 32290
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139DE RID: 80350
			public static VerifyTableAction <0>__Verify;

			// Token: 0x040139DF RID: 80351
			public static VerifyTableAction <1>__Verify;
		}
	}
}
