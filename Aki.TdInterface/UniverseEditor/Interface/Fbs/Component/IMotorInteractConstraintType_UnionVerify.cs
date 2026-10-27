using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055C5 RID: 21957
	public static class IMotorInteractConstraintType_UnionVerify
	{
		// Token: 0x060245FA RID: 148986 RVA: 0x005054EC File Offset: 0x005036EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IFaceToTargetMotorInteractConstraintVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMotorInteractConstraintTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
