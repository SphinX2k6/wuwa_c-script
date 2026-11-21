using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062F6 RID: 25334
	public static class TThrowMotionVerify
	{
		// Token: 0x0602B0B6 RID: 176310 RVA: 0x005DE4E0 File Offset: 0x005DC6E0
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICircumnutationVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IProjectileMotionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IThrowMotionFreeFallVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IThrowMotionLevitateVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IThrowMotionTrackTargetVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
