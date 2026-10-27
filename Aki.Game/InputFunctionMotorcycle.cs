using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;

// Token: 0x020030B4 RID: 12468
[NullableContext(2)]
[Nullable(0)]
public static class InputFunctionMotorcycle
{
	// Token: 0x0601AB64 RID: 109412 RVA: 0x00732300 File Offset: 0x00730500
	private static SInputCommand VisionSkill1Function(float time, bool isForce = false)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null)
		{
			return null;
		}
		CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		CharacterDriveVehicleComponent characterDriveVehicleComponent = (entity != null) ? entity.GetComponent<CharacterDriveVehicleComponent>() : null;
		Entity entity2 = (characterDriveVehicleComponent != null) ? characterDriveVehicleComponent.VehicleEntity : null;
		if (entity2 == null)
		{
			return null;
		}
		BaseTagComponent component = entity2.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return null;
		}
		InputFunctionCommon.IInputCommandTransformResult inputCommandTransformResult = InputFunctionCommon.CreateInputCommandFromDataTable(entity2.Id, EInputAction.幻象1, EInputState.Press);
		if (inputCommandTransformResult != null)
		{
			return inputCommandTransformResult.Command;
		}
		int num = 0;
		int num2 = 0;
		MotorcycleExploreComponent component2 = entity2.GetComponent<MotorcycleExploreComponent>();
		int? num3 = (component2 != null) ? new int?(component2.GetSkillIdByCurrentTarget()) : null;
		if (num3 != null && num3.Value != 0)
		{
			num = num3.Value;
			num2 = 6004;
		}
		if (num == 0)
		{
			num2 = RouletteModel.Instance.CurrentExploreSkillId;
			SVisionData visionData = PhantomUtil.GetVisionData(num2);
			if (visionData != null && visionData.类型 == EVisionType.探索)
			{
				num = visionData.技能ID;
			}
			if (num == 10001012 && component.HasAnyTag(new int[]
			{
				GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中"],
				GameplayTagDefine.EGameplayTagId["载具.摩托.跳跃"],
				GameplayTagDefine.EGameplayTagId["战斗状态.技能限制.禁止声骸展示技能"],
				GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.禁用声骸显像"]
			}))
			{
				return null;
			}
			if (InputFunctionMotorcycle.PullCollectionMutexSkillIds.Contains(num) && component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.摩托车.拉取采集物.技能中"]))
			{
				return null;
			}
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.Vehicle;
		ELogAuthor author = ELogAuthor.CK;
		string message = "摩托车释放技能";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", num);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		if (num != 0)
		{
			if (isForce || ExploreSkillFlagModel.Instance.GetExploreSkillFlagEnable((EExploreSkillType)num))
			{
				RouletteModel.Instance.TrySendExploreToolGeneralUseLogData(num2, 0, 0);
				return InputFunctionCommon.CreateSkillCommand(entity2, num);
			}
			GenericPromptController.Instance.ShowPromptByCode(EMapExploreToolCheckTipId.TempTeleporterPlacementBanned.ToEnumString(), Array.Empty<object>());
		}
		return null;
	}

	// Token: 0x0601AB65 RID: 109413 RVA: 0x007324F4 File Offset: 0x007306F4
	public static SInputCommand MotorcycleVisionSkill1OnPress(float time)
	{
		if (Info.Instance.IsInTouch())
		{
			return null;
		}
		return InputFunctionMotorcycle.VisionSkill1Function(time, false);
	}

	// Token: 0x0601AB66 RID: 109414 RVA: 0x0073250B File Offset: 0x0073070B
	public static SInputCommand MotorcycleVisionSkill1OnRelease(float time)
	{
		if (!Info.Instance.IsInTouch())
		{
			return null;
		}
		if (UiBlueprintFunctionLibrary.IsLongPressExploreButton())
		{
			return null;
		}
		return InputFunctionMotorcycle.VisionSkill1Function(time, false);
	}

	// Token: 0x0601AB67 RID: 109415 RVA: 0x0073252C File Offset: 0x0073072C
	public static int? GetVisionSkill1SkillId(bool isForce = false)
	{
		SInputCommand sinputCommand = InputFunctionMotorcycle.VisionSkill1Function(0f, isForce);
		if (sinputCommand != null)
		{
			return new int?(sinputCommand.IntValue);
		}
		return null;
	}

	// Token: 0x0400CE51 RID: 52817
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly HashSet<int> PullCollectionMutexSkillIds = new HashSet<int>
	{
		10001012,
		10001007,
		10001013,
		10001011
	};
}
