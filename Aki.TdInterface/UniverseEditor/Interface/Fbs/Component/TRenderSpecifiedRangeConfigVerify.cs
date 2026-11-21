using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062CF RID: 25295
	public static class TRenderSpecifiedRangeConfigVerify
	{
		// Token: 0x0602AFF2 RID: 176114 RVA: 0x005DD2A0 File Offset: 0x005DB4A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRenderBeforeYourEyesSceneRevealVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRenderBookPageVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRenderFlowerBridgeVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRenderFogBarrierVerify.Verify(verifier, tablePos);
				break;
			case 5:
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
