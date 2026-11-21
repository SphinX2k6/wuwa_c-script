using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047AC RID: 18348
	public static class IAngularConstraintMotion_UnionVerify
	{
		// Token: 0x0601B030 RID: 110640 RVA: 0x003D39C8 File Offset: 0x003D1BC8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAngularConstraintMotionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAcmFreeVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAcmLimitedVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IAcmLockedVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
