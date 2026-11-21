using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B9 RID: 30393
	public static class ISceneInspectionPointVerify
	{
		// Token: 0x06035516 RID: 218390 RVA: 0x00727164 File Offset: 0x00725364
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

		// Token: 0x020086AE RID: 34478
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AA2 RID: 84642
			public static VerifyTableAction <0>__Verify;

			// Token: 0x04014AA3 RID: 84643
			public static VerifyTableAction <1>__Verify;
		}
	}
}
