using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007697 RID: 30359
	public static class TControlTrackingTypeVerify
	{
		// Token: 0x060373D7 RID: 226263 RVA: 0x0077C6B8 File Offset: 0x0077A8B8
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
