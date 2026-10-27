using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Physics
{
	// Token: 0x0200434A RID: 17226
	public static class IAngularConstraintMotion_UnionVerify
	{
		// Token: 0x060198A2 RID: 104610 RVA: 0x003A7FA0 File Offset: 0x003A61A0
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
