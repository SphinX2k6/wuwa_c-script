using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F7E RID: 20350
	public static class ICharacterConnectorComponentVerify
	{
		// Token: 0x060204E8 RID: 132328 RVA: 0x0047EA00 File Offset: 0x0047CC00
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

		// Token: 0x02007AA7 RID: 31399
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013490 RID: 78992
			public static VerifyTableAction <0>__Verify;
		}
	}
}
