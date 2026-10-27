using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A75 RID: 23157
	public static class IThrowMotion_UnionVerify
	{
		// Token: 0x060276B8 RID: 161464 RVA: 0x0056C93C File Offset: 0x0056AB3C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IThrowMotionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IProjectileMotionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICircumnutationVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IThrowMotionTrackTargetVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IThrowMotionLevitateVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IThrowMotionFreeFallVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
