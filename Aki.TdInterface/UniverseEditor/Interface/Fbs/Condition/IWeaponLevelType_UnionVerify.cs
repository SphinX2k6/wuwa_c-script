using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200521F RID: 21023
	public static class IWeaponLevelType_UnionVerify
	{
		// Token: 0x060211C2 RID: 135618 RVA: 0x00492A94 File Offset: 0x00490C94
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
