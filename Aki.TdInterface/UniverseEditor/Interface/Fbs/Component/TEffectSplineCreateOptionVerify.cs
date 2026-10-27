using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C05 RID: 23557
	public static class TEffectSplineCreateOptionVerify
	{
		// Token: 0x060286A0 RID: 165536 RVA: 0x005902B0 File Offset: 0x0058E4B0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IEffectSplineWholeLineModeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IEffectSplineEquidistantPointModeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
