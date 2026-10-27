using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D23 RID: 19747
	public static class IWeaponLevelType_UnionVerify
	{
		// Token: 0x0601F57B RID: 128379 RVA: 0x0045EB04 File Offset: 0x0045CD04
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || ISpecifyRoleWeaponLevelVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IWeaponLevelTypeVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
