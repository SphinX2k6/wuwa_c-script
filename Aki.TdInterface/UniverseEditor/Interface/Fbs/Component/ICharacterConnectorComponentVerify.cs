using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054AD RID: 21677
	public static class ICharacterConnectorComponentVerify
	{
		// Token: 0x0602223A RID: 139834 RVA: 0x004B49F0 File Offset: 0x004B2BF0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICharacterConnectorComponentVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICharacterConnectorComponentVerify.<>O.<0>__Verify = new VerifyTableAction(ICharacterConnectorRangeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020082FD RID: 33533
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014506 RID: 83206
			public static VerifyTableAction <0>__Verify;
		}
	}
}
