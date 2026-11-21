using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200522E RID: 21038
	public static class TCheckFormationRoleInfoVerify
	{
		// Token: 0x06021230 RID: 135728 RVA: 0x004935B8 File Offset: 0x004917B8
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
