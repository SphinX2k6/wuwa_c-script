using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200741A RID: 29722
	public static class IToggleScanSplineEffect_UnionVerify
	{
		// Token: 0x06035FDC RID: 221148 RVA: 0x007585C0 File Offset: 0x007567C0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IToggleScanSplineEffectVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IOpenTraceSplineVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICloseTraceSplineVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
