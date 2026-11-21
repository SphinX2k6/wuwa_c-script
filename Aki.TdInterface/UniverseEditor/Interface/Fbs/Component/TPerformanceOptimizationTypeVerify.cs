using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062B4 RID: 25268
	public static class TPerformanceOptimizationTypeVerify
	{
		// Token: 0x0602AF6E RID: 175982 RVA: 0x005DC6A8 File Offset: 0x005DA8A8
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
