using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C7 RID: 21447
	public static class IHookInteractType_UnionVerify
	{
		// Token: 0x060232AF RID: 144047 RVA: 0x004DE354 File Offset: 0x004DC554
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IHookInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IFixedPointHookVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMovementPointHookVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISuiGuangHookVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IWaterBoxBigWeaponHookVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IMechHookVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IKiteHookVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IRagDollJumpingPointVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IRagDollClimbingPointVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IFoxJumpingPointVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = ISlashHookVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IChargeSlashHookVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IGravityHookVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IFlyingFeatherVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IPilotThrowVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = ISunSpiritLauncherVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = ICableWayVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IFollowerShootVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IMotorPullInteractVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IMechPullInteractVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IHookSpaceStationEnergyCoreVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IMotorEjectHookVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
