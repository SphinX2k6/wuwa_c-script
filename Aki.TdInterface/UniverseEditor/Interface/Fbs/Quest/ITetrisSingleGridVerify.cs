using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200462A RID: 17962
	public static class ITetrisSingleGridVerify
	{
		// Token: 0x0601A477 RID: 107639 RVA: 0x003BD845 File Offset: 0x003BBA45
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = ITetrisSingleGridVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ITetrisSingleGridVerify.<>O.<0>__Verify = new VerifyTableAction(ITetrisSingleBlockVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020081AF RID: 33199
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401432C RID: 82732
			public static VerifyTableAction <0>__Verify;
		}
	}
}
