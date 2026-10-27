using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200511C RID: 20764
	public static class IEffectSplineCreationMode_UnionVerify
	{
		// Token: 0x0602175D RID: 137053 RVA: 0x004A5214 File Offset: 0x004A3414
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
