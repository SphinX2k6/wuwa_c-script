using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB6 RID: 23222
	public static class ITimeScheduleRefreshConfig_UnionVerify
	{
		// Token: 0x06027905 RID: 162053 RVA: 0x005711C0 File Offset: 0x0056F3C0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITimeScheduleGameDailyRefreshVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITimeScheduleRefreshConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
