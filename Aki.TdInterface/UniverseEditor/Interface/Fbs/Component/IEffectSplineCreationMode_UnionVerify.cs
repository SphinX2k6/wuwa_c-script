using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005681 RID: 22145
	public static class IEffectSplineCreationMode_UnionVerify
	{
		// Token: 0x060236B1 RID: 145073 RVA: 0x004DF1A0 File Offset: 0x004DD3A0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IEffectSplineCreationModeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IEffectSplineWholeLineModeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IEffectSplineEquidistantPointModeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
