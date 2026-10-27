using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005008 RID: 20488
	public static class IConnectorLogicTypeVerify
	{
		// Token: 0x06020C50 RID: 134224 RVA: 0x0048E710 File Offset: 0x0048C910
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

		// Token: 0x02007AC4 RID: 31428
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040134BA RID: 79034
			public static VerifyTableAction <0>__Verify;
		}
	}
}
