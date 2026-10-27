using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006962 RID: 26978
	public static class IInfrastructureItemDeliveryType_UnionVerify
	{
		// Token: 0x0602F1A1 RID: 192929 RVA: 0x0066B018 File Offset: 0x00669218
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
