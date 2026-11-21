using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053AE RID: 21422
	public static class IAirWallSpawnMode_UnionVerify
	{
		// Token: 0x0602170A RID: 136970 RVA: 0x0049D068 File Offset: 0x0049B268
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IAirWallWholeSpawnModeVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IAirWallSpawnModeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
