using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005804 RID: 22532
	public static class IRangeConstraint_UnionVerify
	{
		// Token: 0x06025E10 RID: 155152 RVA: 0x005395BC File Offset: 0x005377BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISearchSpawnMonsterPointVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRangeConstraintVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
