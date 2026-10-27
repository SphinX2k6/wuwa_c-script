using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200634E RID: 25422
	public static class ICharacterLookAtPositionDataVerify
	{
		// Token: 0x0602BF95 RID: 180117 RVA: 0x0060B014 File Offset: 0x00609214
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICharacterLookAtPositionDataVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICharacterLookAtPositionDataVerify.<>O.<0>__Verify = new VerifyTableAction(IVectorInfoVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D13 RID: 32019
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013877 RID: 79991
			public static VerifyTableAction <0>__Verify;
		}
	}
}
