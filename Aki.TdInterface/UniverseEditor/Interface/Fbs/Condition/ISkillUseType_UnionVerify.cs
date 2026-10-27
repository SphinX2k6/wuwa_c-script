using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CD2 RID: 19666
	public static class ISkillUseType_UnionVerify
	{
		// Token: 0x0601F33C RID: 127804 RVA: 0x0045AF74 File Offset: 0x00459174
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISkillUseTypeRoleSkillVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = ISkillUseTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
