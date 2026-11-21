using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200625D RID: 25181
	public static class THookInteractConfigVerify
	{
		// Token: 0x0602ADD6 RID: 175574 RVA: 0x005DA0A8 File Offset: 0x005D82A8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ICableWayVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IChargeSlashHookVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IChongLouHookVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFixedPointHookVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IFlyingFeatherVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IFollowerShootVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IFoxJumpingPointVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IGravityHookVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IHookSpaceStationEnergyCoreVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IKiteHookVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IMechTransformHookVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IMotorEjectHookVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IMotorPullInteractVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IMovementPointHookVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IPilotThrowVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IRagDollClimbingPointVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IRagDollJumpingPointVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = ISlashHookVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = ISuiGuangHookVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = ISunSpiritLauncherVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IWaterBoxBigWeaponHookVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
