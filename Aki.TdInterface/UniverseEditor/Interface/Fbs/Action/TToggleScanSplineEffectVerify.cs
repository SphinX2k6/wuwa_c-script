using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077E5 RID: 30693
	public static class TToggleScanSplineEffectVerify
	{
		// Token: 0x06037AB3 RID: 228019 RVA: 0x00787104 File Offset: 0x00785304
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IOpenTraceSplineVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ICloseTraceSplineVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
