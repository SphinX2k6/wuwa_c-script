using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005849 RID: 22601
	public static class IFrequencyPaintConfigVerify
	{
		// Token: 0x060249E2 RID: 149986 RVA: 0x00508190 File Offset: 0x00506390
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short typeIdVOffset = 6;
				short valueVOffset = 8;
				VerifyUnionAction verifyAction;
				if ((verifyAction = IFrequencyPaintConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFrequencyPaintConfigVerify.<>O.<0>__Verify = new VerifyUnionAction(TFrequencyPaintLineOptionVerify.Verify));
				}
				if (verifier.VerifyUnion(tablePos, typeIdVOffset, valueVOffset, verifyAction, false))
				{
					short offsetId = 10;
					VerifyTableAction verifyAction2;
					if ((verifyAction2 = IFrequencyPaintConfigVerify.<>O.<1>__Verify) == null)
					{
						verifyAction2 = (IFrequencyPaintConfigVerify.<>O.<1>__Verify = new VerifyTableAction(IActionInfoVerify.Verify));
					}
					if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction2, false))
					{
						return verifier.VerifyTableEnd(tablePos);
					}
				}
			}
			return false;
		}

		// Token: 0x02008396 RID: 33686
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040145FE RID: 83454
			public static VerifyUnionAction <0>__Verify;

			// Token: 0x040145FF RID: 83455
			public static VerifyTableAction <1>__Verify;
		}
	}
}
