using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B6 RID: 30390
	public static class ISceneInspectionVerify
	{
		// Token: 0x060354FA RID: 218362 RVA: 0x00726D38 File Offset: 0x00724F38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISceneInspectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISceneInspectionVerify.<>O.<0>__Verify = new VerifyTableAction(ISceneInspectionPointVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086AD RID: 34477
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014AA1 RID: 84641
			public static VerifyTableAction <0>__Verify;
		}
	}
}
