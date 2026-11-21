using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x020047B2 RID: 18354
	public static class TAngularConstraintMotionVerify
	{
		// Token: 0x0601B06B RID: 110699 RVA: 0x003D4468 File Offset: 0x003D2668
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAcmFreeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAcmLimitedVerify.Verify(verifier, tablePos);
				break;
			case 3:
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
