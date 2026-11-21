using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E5E RID: 24158
	public static class IRenderSpecifiedRangeType_UnionVerify
	{
		// Token: 0x0602863A RID: 165434 RVA: 0x00585D68 File Offset: 0x00583F68
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRenderSpecifiedRangeTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRenderFlowerBridgeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRenderBookPageVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRenderFogBarrierVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRenderQuantumFollowShooterVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IRenderBeforeYourEyesSceneRevealVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
