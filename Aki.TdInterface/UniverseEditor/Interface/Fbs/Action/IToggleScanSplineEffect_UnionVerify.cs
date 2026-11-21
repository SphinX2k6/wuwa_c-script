using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C0D RID: 31757
	public static class IToggleScanSplineEffect_UnionVerify
	{
		// Token: 0x060393C5 RID: 234437 RVA: 0x007BB2EC File Offset: 0x007B94EC
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
