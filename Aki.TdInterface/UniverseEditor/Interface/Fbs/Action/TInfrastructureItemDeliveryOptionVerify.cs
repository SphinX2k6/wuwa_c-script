using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F0B RID: 32523
	public static class TInfrastructureItemDeliveryOptionVerify
	{
		// Token: 0x0603AA90 RID: 240272 RVA: 0x007E3D18 File Offset: 0x007E1F18
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IInfrastructureItemDeliveryRoadBuildVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IInfrastructureItemDeliveryObservatoryVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
