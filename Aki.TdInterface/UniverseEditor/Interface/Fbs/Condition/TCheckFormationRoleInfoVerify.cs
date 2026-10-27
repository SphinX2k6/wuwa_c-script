using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D32 RID: 19762
	public static class TCheckFormationRoleInfoVerify
	{
		// Token: 0x0601F5E9 RID: 128489 RVA: 0x0045F628 File Offset: 0x0045D828
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IFeatureCollectionLevelVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHasEquippedVisionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHasUpgradableVisionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRoleLevelVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IWeaponLevelVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
