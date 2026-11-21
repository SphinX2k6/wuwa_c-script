using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053B4 RID: 21428
	public static class IAirWallSpawnStyle_UnionVerify
	{
		// Token: 0x0602172A RID: 137002 RVA: 0x0049D314 File Offset: 0x0049B514
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IAirWallSpawnStyleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAirWallAlongSplineStyleVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IAirWallBothSidesStyleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
