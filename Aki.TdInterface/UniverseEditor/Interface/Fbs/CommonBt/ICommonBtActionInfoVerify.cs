using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064E4 RID: 25828
	public static class ICommonBtActionInfoVerify
	{
		// Token: 0x0602BEAD RID: 179885 RVA: 0x005F8B88 File Offset: 0x005F6D88
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICommonBtActionInfoVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICommonBtActionInfoVerify.<>O.<0>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200852C RID: 34092
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014891 RID: 84113
			public static VerifyTableAction <0>__Verify;
		}
	}
}
