using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007312 RID: 29458
	public static class INpcGroupSequenceBlendAnimVerify
	{
		// Token: 0x060335E4 RID: 210404 RVA: 0x006ED3EC File Offset: 0x006EB5EC
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = INpcGroupSequenceBlendAnimVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (INpcGroupSequenceBlendAnimVerify.<>O.<0>__Verify = new VerifyTableAction(INpcGroupSequenceMontageBlendAnimTypeVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008650 RID: 34384
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014A2C RID: 84524
			public static VerifyTableAction <0>__Verify;
		}
	}
}
