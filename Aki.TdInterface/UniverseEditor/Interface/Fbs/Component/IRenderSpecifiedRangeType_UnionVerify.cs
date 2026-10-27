using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005854 RID: 22612
	public static class IRenderSpecifiedRangeType_UnionVerify
	{
		// Token: 0x060260F0 RID: 155888 RVA: 0x0053F470 File Offset: 0x0053D670
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
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
