using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F01 RID: 28417
	public static class IFrequencyDetectionTipVerify
	{
		// Token: 0x060312CE RID: 201422 RVA: 0x006AA344 File Offset: 0x006A8544
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false))
			{
				short offsetId = 6;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFrequencyDetectionTipVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFrequencyDetectionTipVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonTalkMessageVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x020085F7 RID: 34295
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040149B3 RID: 84403
			public static VerifyTableAction <0>__Verify;
		}
	}
}
