using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F11 RID: 28433
	public static class IRunActionsVerify
	{
		// Token: 0x060323C0 RID: 205760 RVA: 0x006C9661 File Offset: 0x006C7861
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos))
			{
				short offsetId = 4;
				VerifyTableAction verifyAction;
				if ((verifyAction = IRunActionsVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IRunActionsVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007E1E RID: 32286
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040139DA RID: 80346
			public static VerifyTableAction <0>__Verify;
		}
	}
}
