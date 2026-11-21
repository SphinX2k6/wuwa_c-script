using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FA4 RID: 24484
	public static class ISpwanMonsterMode_UnionVerify
	{
		// Token: 0x060292E7 RID: 168679 RVA: 0x0059F508 File Offset: 0x0059D708
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
