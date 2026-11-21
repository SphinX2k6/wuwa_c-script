using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051CE RID: 20942
	public static class ISkillUseType_UnionVerify
	{
		// Token: 0x06020F80 RID: 135040 RVA: 0x0048EE6C File Offset: 0x0048D06C
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
