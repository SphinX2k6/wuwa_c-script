using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CC5 RID: 23749
	public static class TThrowMotionVerify
	{
		// Token: 0x06028A6E RID: 166510 RVA: 0x00595D6C File Offset: 0x00593F6C
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
