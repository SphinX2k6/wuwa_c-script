using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC0 RID: 23488
	public static class IWuWaGoInteractStateActionVerify
	{
		// Token: 0x0602839C RID: 164764 RVA: 0x00586DF8 File Offset: 0x00584FF8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IWuWaGoInteractStateActionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IWuWaGoInteractStateActionVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007C87 RID: 31879
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137B1 RID: 79793
			public static VerifyTableAction <0>__Verify;
		}
	}
}
