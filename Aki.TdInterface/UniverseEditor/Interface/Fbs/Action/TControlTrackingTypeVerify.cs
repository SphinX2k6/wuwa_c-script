using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EA2 RID: 32418
	public static class TControlTrackingTypeVerify
	{
		// Token: 0x0603A87A RID: 239738 RVA: 0x007E080C File Offset: 0x007DEA0C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IControlTrackingSelfVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IControlTrackingOtherVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
