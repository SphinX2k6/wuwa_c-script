using System;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D8A RID: 19850
	public static class IFrequencyDetectGraphicsLineVerify
	{
		// Token: 0x0601EC78 RID: 126072 RVA: 0x0044DBD4 File Offset: 0x0044BDD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			if (verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false))
			{
				short offsetId = 8;
				VerifyTableAction verifyAction;
				if ((verifyAction = IFrequencyDetectGraphicsLineVerify.<>O.<0>__Verify) == null)
				{
					verifyAction = (IFrequencyDetectGraphicsLineVerify.<>O.<0>__Verify = new VerifyTableAction(IFrequencyDetectGraphicsSegmentVerify.Verify));
				}
				if (verifier.VerifyVectorOfTables(tablePos, offsetId, verifyAction, false))
				{
					return verifier.VerifyTableEnd(tablePos);
				}
			}
			return false;
		}

		// Token: 0x02008267 RID: 33383
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04014446 RID: 83014
			public static VerifyTableAction <0>__Verify;
		}
	}
}
