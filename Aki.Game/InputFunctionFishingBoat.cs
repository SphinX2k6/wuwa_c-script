using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

// Token: 0x0200260B RID: 9739
[NullableContext(2)]
[Nullable(0)]
public static class InputFunctionFishingBoat
{
	// Token: 0x0601856D RID: 99693 RVA: 0x007579D8 File Offset: 0x00755BD8
	private static EFishingSkillType? GetFishingSkillType(int exploreToolId)
	{
		switch (exploreToolId)
		{
		case 1018:
			return new EFishingSkillType?(EFishingSkillType.鱼饵);
		case 1019:
			return new EFishingSkillType?(EFishingSkillType.传送);
		case 1020:
			return new EFishingSkillType?(EFishingSkillType.驱散幽灵);
		case 1021:
			return new EFishingSkillType?(EFishingSkillType.炸鱼);
		default:
			return null;
		}
	}

	// Token: 0x0601856E RID: 99694 RVA: 0x00757A2C File Offset: 0x00755C2C
	private static SInputCommand VisionSkill1Function(float time)
	{
		EntityHandle entityHandle = FishingModel.Instance.GetShipData().GetEntityHandle();
		WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
		if (worldEntity == null || !worldEntity.Valid)
		{
			return null;
		}
		if (!InputFunctionCommon.CanVehicleResponseInput(worldEntity))
		{
			return null;
		}
		int currentExploreSkillId = RouletteModel.Instance.CurrentExploreSkillId;
		if (currentExploreSkillId == 0)
		{
			return null;
		}
		int num = 0;
		SVisionData visionData = PhantomUtil.GetVisionData(currentExploreSkillId);
		if (visionData != null && visionData.类型 == EVisionType.探索)
		{
			num = visionData.技能ID;
		}
		if (num == 0)
		{
			return null;
		}
		EFishingSkillType? fishingSkillType = InputFunctionFishingBoat.GetFishingSkillType(currentExploreSkillId);
		if (fishingSkillType == null)
		{
			return InputFunctionCommon.CreateSkillCommand(worldEntity, num);
		}
		CharacterSkillCdComponent component = worldEntity.GetComponent<CharacterSkillCdComponent>();
		if (component != null && component.Valid && component.IsSkillInCd(num, true))
		{
			FishingController.Instance.ShowFishingSkillTips(fishingSkillType.Value, EFishingSkillCheckResult.SkillInCd);
			return null;
		}
		EFishingSkillCheckResult efishingSkillCheckResult = FishingController.Instance.CheckFishingSkillCanBegin(fishingSkillType.Value);
		if (efishingSkillCheckResult != EFishingSkillCheckResult.Usable && efishingSkillCheckResult != EFishingSkillCheckResult.TempFishingPointLimit)
		{
			FishingController.Instance.ShowFishingSkillTips(fishingSkillType.Value, efishingSkillCheckResult);
			return null;
		}
		SInputCommand sinputCommand = InputFunctionCommon.CreateSkillCommand(worldEntity, num);
		if (sinputCommand == null)
		{
			return null;
		}
		FishingBoatInputComponent component2 = worldEntity.GetComponent<FishingBoatInputComponent>();
		if (efishingSkillCheckResult == EFishingSkillCheckResult.TempFishingPointLimit)
		{
			if (component2 != null)
			{
				component2.ExecuteSkillWithConfirmBox(num, EConfirmBoxConfigId.FishingBaitLimit, FishingController.Instance.GetFishingSkillCostId());
			}
			return null;
		}
		EConfirmBoxConfigId configId;
		if (InputFunctionFishingBoat.NeedConfirmSkillMap.TryGetValue(fishingSkillType.Value, out configId))
		{
			if (component2 != null)
			{
				component2.ExecuteSkillWithConfirmBox(num, configId, FishingController.Instance.GetFishingSkillCostId());
			}
			return null;
		}
		return sinputCommand;
	}

	// Token: 0x0601856F RID: 99695 RVA: 0x00757BA1 File Offset: 0x00755DA1
	public static SInputCommand FishingBoatVisionSkill1OnPress(float time)
	{
		if (Info.Instance.IsInTouch())
		{
			return null;
		}
		return InputFunctionFishingBoat.VisionSkill1Function(time);
	}

	// Token: 0x06018570 RID: 99696 RVA: 0x00757BB7 File Offset: 0x00755DB7
	public static SInputCommand FishingBoatVisionSkill1OnRelease(float time)
	{
		if (!Info.Instance.IsInTouch())
		{
			return null;
		}
		if (UiBlueprintFunctionLibrary.IsLongPressExploreButton())
		{
			return null;
		}
		return InputFunctionFishingBoat.VisionSkill1Function(time);
	}

	// Token: 0x06018571 RID: 99697 RVA: 0x00757BD8 File Offset: 0x00755DD8
	public static SInputCommand CreateFishingBoatSprintCommand(int skillId)
	{
		EntityHandle entityHandle = FishingModel.Instance.GetShipData().GetEntityHandle();
		WorldEntity worldEntity = (entityHandle != null) ? entityHandle.Entity : null;
		if (worldEntity == null || !worldEntity.Valid)
		{
			return new SInputCommand
			{
				CommandType = ECommandType.Skill,
				IntValue = skillId
			};
		}
		FishingBoatPerformComponent component = worldEntity.GetComponent<FishingBoatPerformComponent>();
		if (component == null || !component.CheckCanSprint())
		{
			return null;
		}
		return InputFunctionCommon.CreateSkillCommand(worldEntity, skillId);
	}

	// Token: 0x06018572 RID: 99698 RVA: 0x00757C46 File Offset: 0x00755E46
	// Note: this type is marked as 'beforefieldinit'.
	static InputFunctionFishingBoat()
	{
		Dictionary<EFishingSkillType, EConfirmBoxConfigId> dictionary = new Dictionary<EFishingSkillType, EConfirmBoxConfigId>();
		dictionary[EFishingSkillType.传送] = EConfirmBoxConfigId.FishingTeleport;
		dictionary[EFishingSkillType.鱼饵] = EConfirmBoxConfigId.FishingBait;
		InputFunctionFishingBoat.NeedConfirmSkillMap = dictionary;
	}

	// Token: 0x0400D23C RID: 53820
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EFishingSkillType, EConfirmBoxConfigId> NeedConfirmSkillMap;
}
