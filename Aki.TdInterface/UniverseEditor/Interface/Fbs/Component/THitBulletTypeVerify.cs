using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C32 RID: 23602
	public static class THitBulletTypeVerify
	{
		// Token: 0x06028780 RID: 165760 RVA: 0x0059172C File Offset: 0x0058F92C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHitBulletTypeAllCharacterAttackVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IHitBulletTypeCrystalAttackVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IHitBulletTypeFixedBulletIdVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IHitBulletTypeOnlyDropAttackVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IHitBulletTypePlayerAttackVerify.Verify(verifier, tablePos);
				break;
			case 6:
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
