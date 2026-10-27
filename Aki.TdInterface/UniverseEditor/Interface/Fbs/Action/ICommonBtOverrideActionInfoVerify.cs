using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200646A RID: 25706
	public static class ICommonBtOverrideActionInfoVerify
	{
		// Token: 0x0602C7D5 RID: 182229 RVA: 0x00619D94 File Offset: 0x00617F94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonBtOverrideActionInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtOverrideActionInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D2D RID: 32045
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401389C RID: 80028
			public static VerifyTableAction <0>__Verify;
		}
	}
}
