using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055EB RID: 21995
	public static class IDestroyStageConfigVerify
	{
		// Token: 0x06023048 RID: 143432 RVA: 0x004D1838 File Offset: 0x004CFA38
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IDestroyStageConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IDestroyStageConfigVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200832C RID: 33580
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401454F RID: 83279
			public static VerifyTableAction <0>__Verify;
		}
	}
}
