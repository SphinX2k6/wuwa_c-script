using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005385 RID: 21381
	public static class IHitBulletType_UnionVerify
	{
		// Token: 0x06022FEB RID: 143339 RVA: 0x004D82C4 File Offset: 0x004D64C4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHitBulletTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHitBulletTypeOnlyDropAttackVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHitBulletTypeCrystalAttackVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHitBulletTypeFixedBulletIdVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHitBulletTypePlayerAttackVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IHitBulletTypeAllCharacterAttackVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IHitBulletTypePlayerOrThrenodianAttackVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
