using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C92 RID: 27794
	public static class IPerformerRangeBoundaryActionTriggerVerify
	{
		// Token: 0x06030FAA RID: 200618 RVA: 0x006A6458 File Offset: 0x006A4658
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IPerformerRangeBoundaryActionTriggerVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IPerformerRangeBoundaryActionTriggerVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007DE5 RID: 32229
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013997 RID: 80279
			public static VerifyTableAction <0>__Verify;
		}
	}
}
