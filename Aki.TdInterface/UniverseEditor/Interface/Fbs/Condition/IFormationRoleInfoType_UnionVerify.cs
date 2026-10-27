using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C2D RID: 19501
	public static class IFormationRoleInfoType_UnionVerify
	{
		// Token: 0x0601EE66 RID: 126566 RVA: 0x00452F0C File Offset: 0x0045110C
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
