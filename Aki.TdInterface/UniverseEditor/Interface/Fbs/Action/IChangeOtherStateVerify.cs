using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006984 RID: 27012
	public static class IChangeOtherStateVerify
	{
		// Token: 0x0602E543 RID: 189763 RVA: 0x0065333C File Offset: 0x0065153C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IChangeOtherStateVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IChangeOtherStateVerify.<>O.<0>__Verify = new VerifyTableAction(IPlayFlowVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008583 RID: 34179
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0401491D RID: 84253
			public static VerifyTableAction <0>__Verify;
		}
	}
}
