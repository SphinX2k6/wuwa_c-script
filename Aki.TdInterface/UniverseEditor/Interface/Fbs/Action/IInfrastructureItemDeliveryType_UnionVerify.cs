using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007015 RID: 28693
	public static class IInfrastructureItemDeliveryType_UnionVerify
	{
		// Token: 0x06031B71 RID: 203633 RVA: 0x006BB500 File Offset: 0x006B9700
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IInfrastructureItemDeliveryTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IInfrastructureItemDeliveryObservatoryVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IInfrastructureItemDeliveryRoadBuildVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
