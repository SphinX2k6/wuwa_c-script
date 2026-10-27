using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.PerformerAI
{
	// Token: 0x02004380 RID: 17280
	public static class IPerformerAiTaskVerify
	{
		// Token: 0x06019B4E RID: 105294 RVA: 0x003AE988 File Offset: 0x003ACB88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyVectorOfData(tablePos, 10, 1UL, false) && verifier.VerifyField(tablePos, 14, 1UL, 1UL, false))
			{
				short offsetId = 16;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPerformerAiTaskVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPerformerAiTaskVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007989 RID: 31113
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013307 RID: 78599
			public static VerifyTableAction <0>__Verify;
		}
	}
}
