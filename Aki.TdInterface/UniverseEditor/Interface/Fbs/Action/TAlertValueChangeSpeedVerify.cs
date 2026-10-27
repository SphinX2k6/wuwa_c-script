using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007643 RID: 30275
	public static class TAlertValueChangeSpeedVerify
	{
		// Token: 0x06037223 RID: 225827 RVA: 0x00779DA0 File Offset: 0x00777FA0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ICustomAlertValueChangeSpeedVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAddOrSubAlertValueChangeSpeedVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
