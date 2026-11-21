using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006257 RID: 25175
	public static class THitBulletTypeVerify
	{
		// Token: 0x0602AD8E RID: 175502 RVA: 0x005D9944 File Offset: 0x005D7B44
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
