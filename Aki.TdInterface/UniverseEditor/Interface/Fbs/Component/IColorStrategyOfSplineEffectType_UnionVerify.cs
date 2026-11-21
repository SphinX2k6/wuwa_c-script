using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200551F RID: 21791
	public static class IColorStrategyOfSplineEffectType_UnionVerify
	{
		// Token: 0x06022710 RID: 141072 RVA: 0x004BEC6C File Offset: 0x004BCE6C
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
