using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F81 RID: 20353
	public static class ICharacterConnectorLogicTypeVerify
	{
		// Token: 0x060204FE RID: 132350 RVA: 0x0047EC9C File Offset: 0x0047CE9C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICharacterConnectorLogicTypeVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICharacterConnectorLogicTypeVerify.<>O.<0>__Verify = new VerifyTableAction(IConnectorEffectConfigVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007AA8 RID: 31400
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013491 RID: 78993
			public static VerifyTableAction <0>__Verify;
		}
	}
}
