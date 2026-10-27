using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C9E RID: 23710
	public static class TRenderSpecifiedRangeConfigVerify
	{
		// Token: 0x060289AA RID: 166314 RVA: 0x00594B38 File Offset: 0x00592D38
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRenderBookPageVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRenderFlowerBridgeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRenderFogBarrierVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRenderQuantumFollowShooterVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
