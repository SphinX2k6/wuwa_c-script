using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E9 RID: 27113
	public static class ILeisureInteractType_UnionVerify
	{
		// Token: 0x0602F6F0 RID: 194288 RVA: 0x00675CE8 File Offset: 0x00673EE8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ILeisureInteractTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICustomSkillVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = ISitDownVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ISitOnGroundVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBounceVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IMotorBounceVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IMotorCatapultVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = ICatapultVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = ISuperCatapultVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IManipulateVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IStandControlVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IStandControl2Verify.Verify(verifier, tablePos);
				break;
			case 13:
				result = ISoarVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = ISoar2Verify.Verify(verifier, tablePos);
				break;
			case 15:
				result = IGlideVerify.Verify(verifier, tablePos);
				break;
			case 16:
				result = IGetUpVerify.Verify(verifier, tablePos);
				break;
			case 17:
				result = IHookLockInteractVerify.Verify(verifier, tablePos);
				break;
			case 18:
				result = IKiteHookInteractVerify.Verify(verifier, tablePos);
				break;
			case 19:
				result = IFailurePoseInteractVerify.Verify(verifier, tablePos);
				break;
			case 20:
				result = IGameplayPose1InteractVerify.Verify(verifier, tablePos);
				break;
			case 21:
				result = IGameplayPose2InteractVerify.Verify(verifier, tablePos);
				break;
			case 22:
				result = IGameplayPose3InteractVerify.Verify(verifier, tablePos);
				break;
			case 23:
				result = IFaithJumpVerify.Verify(verifier, tablePos);
				break;
			case 24:
				result = IWindProtagonistParkour1Verify.Verify(verifier, tablePos);
				break;
			case 25:
				result = IWindProtagonistParkour2Verify.Verify(verifier, tablePos);
				break;
			case 26:
				result = IWindProtagonistParkour3Verify.Verify(verifier, tablePos);
				break;
			case 27:
				result = IWindProtagonistParkour4Verify.Verify(verifier, tablePos);
				break;
			case 28:
				result = IWindProtagonistParkour5Verify.Verify(verifier, tablePos);
				break;
			case 29:
				result = IPainCoveringHeadVerify.Verify(verifier, tablePos);
				break;
			case 30:
				result = ISwingVerify.Verify(verifier, tablePos);
				break;
			case 31:
				result = ISwingGetUpVerify.Verify(verifier, tablePos);
				break;
			case 32:
				result = IMotorEnterSlideVerify.Verify(verifier, tablePos);
				break;
			case 33:
				result = IQiuyuanLongPressQinggongVerify.Verify(verifier, tablePos);
				break;
			case 34:
				result = IQiuyuanQinggongEndVerify.Verify(verifier, tablePos);
				break;
			case 35:
				result = IQiuyuanQinggongExploration1Verify.Verify(verifier, tablePos);
				break;
			case 36:
				result = IQiuyuanQinggongExploration2Verify.Verify(verifier, tablePos);
				break;
			case 37:
				result = IQiuyuanQinggongExploration3Verify.Verify(verifier, tablePos);
				break;
			case 38:
				result = IQiuyuanQinggongExploration4Verify.Verify(verifier, tablePos);
				break;
			case 39:
				result = IQiuyuanQinggongStraightVerify.Verify(verifier, tablePos);
				break;
			case 40:
				result = IQiuyuanQinggongHoveringVerify.Verify(verifier, tablePos);
				break;
			case 41:
				result = ISunPalaceInteractVerify.Verify(verifier, tablePos);
				break;
			case 42:
				result = ILandSlideInteractVerify.Verify(verifier, tablePos);
				break;
			case 43:
				result = ILandSlideEndInteractVerify.Verify(verifier, tablePos);
				break;
			case 44:
				result = IRideMotorcycleInteractVerify.Verify(verifier, tablePos);
				break;
			case 45:
				result = IGetOffMotorcycleInteractVerify.Verify(verifier, tablePos);
				break;
			case 46:
				result = IMoneHackingDoorInteractVerify.Verify(verifier, tablePos);
				break;
			case 47:
				result = IMotorSoarInteractVerify.Verify(verifier, tablePos);
				break;
			case 48:
				result = IParticipateGroupPatrolVerify.Verify(verifier, tablePos);
				break;
			case 49:
				result = IFoxPickUpVerify.Verify(verifier, tablePos);
				break;
			case 50:
				result = IFoxPutDownVerify.Verify(verifier, tablePos);
				break;
			case 51:
				result = IFoxPushBoxVerify.Verify(verifier, tablePos);
				break;
			case 52:
				result = IFoxReversePushVerify.Verify(verifier, tablePos);
				break;
			case 53:
				result = IFoxAutoJumpVerify.Verify(verifier, tablePos);
				break;
			case 54:
				result = IMechStuntVerify.Verify(verifier, tablePos);
				break;
			case 55:
				result = IMechEscortFlyVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
