using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054B0 RID: 21680
	public static class ICharacterConnectorLogicTypeVerify
	{
		// Token: 0x06022250 RID: 139856 RVA: 0x004B4C8C File Offset: 0x004B2E8C
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

		// Token: 0x020082FE RID: 33534
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014507 RID: 83207
			public static VerifyTableAction <0>__Verify;
		}
	}
}
