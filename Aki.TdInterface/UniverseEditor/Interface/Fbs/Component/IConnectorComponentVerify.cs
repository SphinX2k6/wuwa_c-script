using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005561 RID: 21857
	public static class IConnectorComponentVerify
	{
		// Token: 0x06022B3A RID: 142138 RVA: 0x004C7B90 File Offset: 0x004C5D90
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IConnectorComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConnectorComponentVerify.<>O.<0>__Verify = new VerifyUnionAction(TConnectorLogicVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200831D RID: 33565
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014537 RID: 83255
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
