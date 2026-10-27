using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006292 RID: 25234
	public static class ICameraOffsetInMovementDirectionVerify
	{
		// Token: 0x0602B982 RID: 178562 RVA: 0x0060066C File Offset: 0x005FE86C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false))
			{
				short offsetId = 12;
				VerifyTableAction verifyAction;
				if ((verifyAction = ICameraOffsetInMovementDirectionVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (ICameraOffsetInMovementDirectionVerify.<>O.<0>__Verify = new VerifyTableAction(IBaseCurveVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false) && verifier.VerifyField(tablePos, 14, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 16, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 18, 1UL, 1UL, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02007D03 RID: 32003
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04013865 RID: 79973
			public static VerifyTableAction <0>__Verify;
		}
	}
}
