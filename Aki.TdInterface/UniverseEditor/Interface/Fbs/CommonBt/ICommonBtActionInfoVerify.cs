using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EA1 RID: 24225
	public static class ICommonBtActionInfoVerify
	{
		// Token: 0x06029805 RID: 169989 RVA: 0x005AFBE4 File Offset: 0x005ADDE4
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

		// Token: 0x02007CBB RID: 31931
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040137EB RID: 79851
			public static VerifyTableAction <0>__Verify;
		}
	}
}
