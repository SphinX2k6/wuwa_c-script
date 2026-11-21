using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060C3 RID: 24771
	public static class ITimeScheduleRefreshPosition_UnionVerify
	{
		// Token: 0x06029E8B RID: 171659 RVA: 0x005B84A8 File Offset: 0x005B66A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ITimeScheduleFixedPositionsVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ITimeScheduleRefreshPositionVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
