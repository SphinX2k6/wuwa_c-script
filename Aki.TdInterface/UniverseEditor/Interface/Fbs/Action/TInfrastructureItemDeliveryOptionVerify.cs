using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076F7 RID: 30455
	public static class TInfrastructureItemDeliveryOptionVerify
	{
		// Token: 0x060375C3 RID: 226755 RVA: 0x0077F80C File Offset: 0x0077DA0C
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
