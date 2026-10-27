using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C38 RID: 23608
	public static class THookInteractConfigVerify
	{
		// Token: 0x060287C8 RID: 165832 RVA: 0x00591E90 File Offset: 0x00590090
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
				result = IFixedPointHookVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFlyingFeatherVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IFollowerShootVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IFoxJumpingPointVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IGravityHookVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IHookSpaceStationEnergyCoreVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IKiteHookVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IMechHookVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IMechPullInteractVerify.Verify(verifier, tablePos);
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
