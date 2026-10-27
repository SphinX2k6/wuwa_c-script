using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9B RID: 23195
	public static class ITimeScheduleDistributionConfig_UnionVerify
	{
		// Token: 0x06027851 RID: 161873 RVA: 0x0056FE6C File Offset: 0x0056E06C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITimeScheduleRandomSchedulePositionDistributionVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITimeScheduleDistributionConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
