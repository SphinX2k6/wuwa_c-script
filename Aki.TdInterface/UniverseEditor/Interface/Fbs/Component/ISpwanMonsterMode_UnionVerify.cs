using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005997 RID: 22935
	public static class ISpwanMonsterMode_UnionVerify
	{
		// Token: 0x06026D7D RID: 159101 RVA: 0x0055889C File Offset: 0x00556A9C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISpawnMonsterConstraintAnnularSectorVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISpwanMonsterModeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
