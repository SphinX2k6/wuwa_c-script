using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CBA RID: 19642
	public static class IRoleLevelType_UnionVerify
	{
		// Token: 0x0601F2A8 RID: 127656 RVA: 0x0045A27C File Offset: 0x0045847C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISpecifyRoleLevelVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IRoleLevelTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
