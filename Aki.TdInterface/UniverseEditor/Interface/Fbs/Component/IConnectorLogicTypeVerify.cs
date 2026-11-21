using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005567 RID: 21863
	public static class IConnectorLogicTypeVerify
	{
		// Token: 0x06022B70 RID: 142192 RVA: 0x004C8160 File Offset: 0x004C6360
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IConnectorLogicTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IConnectorLogicTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IConnectorEffectConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x0200831E RID: 33566
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014538 RID: 83256
			public static VerifyTableAction <0>__Verify;
		}
	}
}
