using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D93 RID: 19859
	public static class IFrequencyDetectLineConfigBase_UnionVerify
	{
		// Token: 0x0601ECBE RID: 126142 RVA: 0x0044E34C File Offset: 0x0044C54C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFrequencyDetectLineConfigBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFrequencyDetectAiLineConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFrequencyDetectPlayerLineConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
