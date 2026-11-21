using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D99 RID: 19865
	public static class IFrequencyDetectTalkConfigVerify
	{
		// Token: 0x0601ECFE RID: 126206 RVA: 0x0044EA58 File Offset: 0x0044CC58
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false))
			{
				short offsetId = 10;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFrequencyDetectTalkConfigVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFrequencyDetectTalkConfigVerify.<>O.<0>__Verify = new VerifyTableAction(ICommonTalkMessageVerify.Verify));
				}
				if (verifier.VerifyTable(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008268 RID: 33384
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014447 RID: 83015
			public static VerifyTableAction <0>__Verify;
		}
	}
}
