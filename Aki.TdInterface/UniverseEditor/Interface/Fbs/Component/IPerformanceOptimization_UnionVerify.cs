using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005720 RID: 22304
	public static class IPerformanceOptimization_UnionVerify
	{
		// Token: 0x06025511 RID: 152849 RVA: 0x00526354 File Offset: 0x00524554
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IPerformanceOptimizationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IPlaneMovementOptimizationConfigVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDamageTextOptimizationConfigVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
