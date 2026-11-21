using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007779 RID: 30585
	public static class ISetAssistCharacterPosVerify
	{
		// Token: 0x06035AF4 RID: 219892 RVA: 0x00731A28 File Offset: 0x0072FC28
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ISetAssistCharacterPosVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ISetAssistCharacterPosVerify.<>O.<0>__Verify = new VerifyTableAction(IPosAVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020086C4 RID: 34500
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014ABE RID: 84670
			public static VerifyTableAction <0>__Verify;
		}
	}
}
