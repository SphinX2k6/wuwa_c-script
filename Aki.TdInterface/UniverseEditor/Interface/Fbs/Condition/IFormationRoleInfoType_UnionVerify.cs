using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005120 RID: 20768
	public static class IFormationRoleInfoType_UnionVerify
	{
		// Token: 0x06020A6A RID: 133738 RVA: 0x004867E8 File Offset: 0x004849E8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFormationRoleInfoTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRoleLevelVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IWeaponLevelVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHasEquippedVisionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHasUpgradableVisionVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IFeatureCollectionLevelVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
