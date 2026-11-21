using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006082 RID: 24706
	public static class IThrowMotion_UnionVerify
	{
		// Token: 0x06029C30 RID: 171056 RVA: 0x005B3948 File Offset: 0x005B1B48
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
