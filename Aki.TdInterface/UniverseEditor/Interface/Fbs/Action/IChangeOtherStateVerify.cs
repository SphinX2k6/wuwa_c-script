using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006313 RID: 25363
	public static class IChangeOtherStateVerify
	{
		// Token: 0x0602BDDA RID: 179674 RVA: 0x00608330 File Offset: 0x00606530
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

		// Token: 0x02007D10 RID: 32016
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013874 RID: 79988
			public static VerifyTableAction <0>__Verify;
		}
	}
}
