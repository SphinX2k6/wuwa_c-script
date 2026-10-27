using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007703 RID: 30467
	public static class TLeisureInteractOptionVerify
	{
		// Token: 0x06037661 RID: 226913 RVA: 0x0078076C File Offset: 0x0077E96C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBounceVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICatapultVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ICustomSkillVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IFailurePoseInteractVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IFaithJumpVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IFoxAutoJumpVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IFoxPickUpVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IFoxPushBoxVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IFoxPutDownVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IFoxReversePushVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IGameplayPose1InteractVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IGameplayPose2InteractVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IGameplayPose3InteractVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IGetOffMotorcycleInteractVerify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IGetUpVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IGlideVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IHookLockInteractVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IKiteHookInteractVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = ILandSlideEndInteractVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = ILandSlideInteractVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IManipulateVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IMechEscortFlyVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IMechStuntVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IMoneHackingDoorInteractVerify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IMotorBounceVerify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IMotorCatapultVerify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IMotorEnterSlideVerify.Verify(verifier, tablePos);
				break;
			case 28:
				result = IMotorSoarInteractVerify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IPainCoveringHeadVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = IParticipateGroupPatrolVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = IQiuyuanLongPressQinggongVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = IQiuyuanQinggongEndVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = IQiuyuanQinggongExploration1Verify.Verify(verifier, tablePos);
				break;
			case 34:
				result = IQiuyuanQinggongExploration2Verify.Verify(verifier, tablePos);
				break;
			case 35:
				result = IQiuyuanQinggongExploration3Verify.Verify(verifier, tablePos);
				break;
			case 36:
				result = IQiuyuanQinggongExploration4Verify.Verify(verifier, tablePos);
				break;
			case 37:
				result = IQiuyuanQinggongHoveringVerify.Verify(verifier, tablePos);
				break;
			case 38:
				result = IQiuyuanQinggongStraightVerify.Verify(verifier, tablePos);
				break;
			case 39:
				result = IRideMotorcycleInteractVerify.Verify(verifier, tablePos);
				break;
			case 40:
				result = ISitDownVerify.Verify(verifier, tablePos);
				break;
			case 41:
				result = ISitOnGroundVerify.Verify(verifier, tablePos);
				break;
			case 42:
				result = ISoarVerify.Verify(verifier, tablePos);
				break;
			case 43:
				result = ISoar2Verify.Verify(verifier, tablePos);
				break;
			case 44:
				result = IStandControlVerify.Verify(verifier, tablePos);
				break;
			case 45:
				result = IStandControl2Verify.Verify(verifier, tablePos);
				break;
			case 46:
				result = ISunPalaceInteractVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = ISuperCatapultVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = ISwingVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = ISwingGetUpVerify.Verify(verifier, tablePos);
				break;
			case 50:
				result = IWindProtagonistParkour1Verify.Verify(verifier, tablePos);
				break;
			case 51:
				result = IWindProtagonistParkour2Verify.Verify(verifier, tablePos);
				break;
			case 52:
				result = IWindProtagonistParkour3Verify.Verify(verifier, tablePos);
				break;
			case 53:
				result = IWindProtagonistParkour4Verify.Verify(verifier, tablePos);
				break;
			case 54:
				result = IWindProtagonistParkour5Verify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
