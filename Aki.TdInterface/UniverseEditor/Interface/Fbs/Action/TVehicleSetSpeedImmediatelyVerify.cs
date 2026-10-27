using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007806 RID: 30726
	public static class TVehicleSetSpeedImmediatelyVerify
	{
		// Token: 0x06037B87 RID: 228231 RVA: 0x007886A8 File Offset: 0x007868A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISetTotalVehicleSpeedImmediatelyVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISetHorizontalVerticalSpeedImmediatelyVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
