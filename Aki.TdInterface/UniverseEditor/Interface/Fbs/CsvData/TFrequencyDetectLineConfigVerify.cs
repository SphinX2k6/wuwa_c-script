using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004DCC RID: 19916
	public static class TFrequencyDetectLineConfigVerify
	{
		// Token: 0x0601EE7E RID: 126590 RVA: 0x0045160C File Offset: 0x0044F80C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFrequencyDetectPlayerLineConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IFrequencyDetectAiLineConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
