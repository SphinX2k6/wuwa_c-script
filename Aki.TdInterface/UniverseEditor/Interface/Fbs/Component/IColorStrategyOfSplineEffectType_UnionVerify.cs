using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FC3 RID: 20419
	public static class IColorStrategyOfSplineEffectType_UnionVerify
	{
		// Token: 0x0602081C RID: 133148 RVA: 0x00485788 File Offset: 0x00483988
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IColorChangeStrategyOfRGBVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IColorStrategyOfSplineEffectTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
