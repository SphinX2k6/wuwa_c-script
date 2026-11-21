using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558B RID: 21899
	public static class IConveyorBeltComponentVerify
	{
		// Token: 0x06022D4C RID: 142668 RVA: 0x004CC648 File Offset: 0x004CA848
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConveyorBeltComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConveyorBeltComponentVerify.<>O.<0>__Verify = new VerifyTableAction(IConveyorBeltStateVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008325 RID: 33573
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014546 RID: 83270
			public static VerifyTableAction <0>__Verify;
		}
	}
}
