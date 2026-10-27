using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005002 RID: 20482
	public static class IConnectorComponentVerify
	{
		// Token: 0x06020C1A RID: 134170 RVA: 0x0048E140 File Offset: 0x0048C340
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

		// Token: 0x02007AC3 RID: 31427
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134B9 RID: 79033
			public static VerifyUnionAction <0>__Verify;
		}
	}
}
