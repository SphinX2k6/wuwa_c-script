using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F9 RID: 29689
	public static class IPerformerRangeBoundaryActionTriggerVerify
	{
		// Token: 0x06033F05 RID: 212741 RVA: 0x00700958 File Offset: 0x006FEB58
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

		// Token: 0x0200866F RID: 34415
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A59 RID: 84569
			public static VerifyTableAction <0>__Verify;
		}
	}
}
