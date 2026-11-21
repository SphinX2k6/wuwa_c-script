using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B63 RID: 23395
	public static class IMotorInteractConstraintType_UnionVerify
	{
		// Token: 0x06026807 RID: 157703 RVA: 0x00545A64 File Offset: 0x00543C64
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
