using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006224 RID: 25124
	public static class TEffectSplineCreateOptionVerify
	{
		// Token: 0x0602AC90 RID: 175248 RVA: 0x005D81F8 File Offset: 0x005D63F8
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
