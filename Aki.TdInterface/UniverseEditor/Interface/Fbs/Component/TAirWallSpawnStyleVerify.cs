using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061FD RID: 25085
	public static class TAirWallSpawnStyleVerify
	{
		// Token: 0x0602AAE0 RID: 174816 RVA: 0x005D1C9C File Offset: 0x005CFE9C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAirWallBothSidesStyleVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAirWallAlongSplineStyleVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
