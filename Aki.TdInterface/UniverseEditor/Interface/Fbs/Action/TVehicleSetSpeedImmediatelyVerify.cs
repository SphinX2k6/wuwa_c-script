using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008044 RID: 32836
	public static class TVehicleSetSpeedImmediatelyVerify
	{
		// Token: 0x0603B12C RID: 241964 RVA: 0x007EE020 File Offset: 0x007EC220
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
