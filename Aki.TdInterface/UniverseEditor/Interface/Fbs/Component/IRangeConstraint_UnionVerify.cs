using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E0B RID: 24075
	public static class IRangeConstraint_UnionVerify
	{
		// Token: 0x06028330 RID: 164656 RVA: 0x0057F748 File Offset: 0x0057D948
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
