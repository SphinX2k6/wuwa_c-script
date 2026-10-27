using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C83 RID: 23683
	public static class TPerformanceOptimizationTypeVerify
	{
		// Token: 0x06028928 RID: 166184 RVA: 0x00593F70 File Offset: 0x00592170
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IPlaneMovementOptimizationConfigVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IDamageTextOptimizationConfigVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
