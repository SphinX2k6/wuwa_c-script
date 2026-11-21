using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D27 RID: 23847
	public static class IPerformanceOptimization_UnionVerify
	{
		// Token: 0x06027A20 RID: 162336 RVA: 0x0056C05C File Offset: 0x0056A25C
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
