using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x02004350 RID: 17232
	public static class TAngularConstraintMotionVerify
	{
		// Token: 0x060198DD RID: 104669 RVA: 0x003A8A40 File Offset: 0x003A6C40
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
