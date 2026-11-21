using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060B4 RID: 24756
	public static class ITimeScheduleGenerateParams_UnionVerify
	{
		// Token: 0x06029E39 RID: 171577 RVA: 0x005B7DA0 File Offset: 0x005B5FA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITimeScheduleFixedIntervalRefreshVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITimeScheduleGenerateParamsVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
