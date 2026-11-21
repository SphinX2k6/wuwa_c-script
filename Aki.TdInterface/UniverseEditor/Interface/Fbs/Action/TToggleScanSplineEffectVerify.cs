using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02008023 RID: 32803
	public static class TToggleScanSplineEffectVerify
	{
		// Token: 0x0603B052 RID: 241746 RVA: 0x007EC9B0 File Offset: 0x007EABB0
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
