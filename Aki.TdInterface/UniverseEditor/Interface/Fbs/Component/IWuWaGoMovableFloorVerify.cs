using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061DF RID: 25055
	public static class IWuWaGoMovableFloorVerify
	{
		// Token: 0x0602A9D0 RID: 174544 RVA: 0x005CF7BC File Offset: 0x005CD9BC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 2UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 2UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoMovableFloorVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoMovableFloorVerify.<>O.<0>__Verify = new VerifyTableAction(IWuWaGoMovableGridStatePosVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020084FA RID: 34042
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401485A RID: 84058
			public static VerifyTableAction <0>__Verify;
		}
	}
}
