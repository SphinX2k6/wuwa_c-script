using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005086 RID: 20614
	public static class IDestroyStageConfigVerify
	{
		// Token: 0x060210F4 RID: 135412 RVA: 0x004978F4 File Offset: 0x00495AF4
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

		// Token: 0x02007AD2 RID: 31442
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134D1 RID: 79057
			public static VerifyTableAction <0>__Verify;
		}
	}
}
