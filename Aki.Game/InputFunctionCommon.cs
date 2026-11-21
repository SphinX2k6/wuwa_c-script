using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using AkiClient.Game.Aki.Data.Fight.Struct;
using CSharpScript.Game;
using CSharpScript.Game.Input;
using UnrealEngine;

// Token: 0x0200260A RID: 9738
[NullableContext(1)]
[Nullable(0)]
public class InputFunctionCommon : IStaticVariableResetter
{
	// Token: 0x06018562 RID: 99682 RVA: 0x007575F3 File Offset: 0x007557F3
	static InputFunctionCommon()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InputFunctionCommon.CreateStaticDefaultValue), new Action(InputFunctionCommon.ResetStaticDefaultValue));
	}

	// Token: 0x1700263B RID: 9787
	// (get) Token: 0x06018563 RID: 99683 RVA: 0x00757612 File Offset: 0x00755812
	private static Skill TempSkill
	{
		get
		{
			return InputFunctionCommon._tempSkill;
		}
	}

	// Token: 0x06018564 RID: 99684 RVA: 0x0075761C File Offset: 0x0075581C
	[return: Nullable(2)]
	public static SInputCommand CreateSkillCommand(Entity entity, int skillId)
	{
		if (skillId == 0)
		{
			return null;
		}
		BaseSkillComponent component = entity.GetComponent<BaseSkillComponent>();
		if (component == null || !component.Valid)
		{
			return null;
		}
		SSkillInfo skillInfo = component.GetSkillInfo(skillId);
		int priority = component.GetPriority(skillId);
		int skillIdWithGroupId = component.GetSkillIdWithGroupId(1);
		int activePriority = component.GetActivePriority(skillIdWithGroupId);
		if (priority > activePriority || component.IsMainSkillReadyEnd || (priority == activePriority && component.SkillAcceptInput) || (skillInfo != null && skillInfo.GroupId != 1))
		{
			return new SInputCommand
			{
				CommandType = ECommandType.Skill,
				IntValue = skillId
			};
		}
		return null;
	}

	// Token: 0x06018565 RID: 99685 RVA: 0x007576AC File Offset: 0x007558AC
	public static bool CanResponseInput(Entity entity)
	{
		BaseMoveComponent component = entity.GetComponent<BaseMoveComponent>();
		if (component == null || !component.CanResponseInput())
		{
			return false;
		}
		BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
		return (component2 == null || !component2.HasAnyTag(new int[]
		{
			GameplayTagDefine.EGameplayTagId["功能.功能制作.被击硬直时间"],
			GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"],
			GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"],
			GameplayTagDefine.EGameplayTagId["行为状态.动作状态.滑坡"],
			GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击.被抓取"],
			GameplayTagDefine.EGameplayTagId["角色.BaseRole.状态通用标识.输入硬直"]
		})) && (component2 == null || !component2.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"]) || (component2 != null && component2.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中.可输入"])));
	}

	// Token: 0x06018566 RID: 99686 RVA: 0x00757798 File Offset: 0x00755998
	public static bool CanCharacterResponseInput()
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		Entity entity;
		if (baseCharacter == null)
		{
			entity = null;
		}
		else
		{
			CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
			entity = ((characterActorComponent != null) ? characterActorComponent.Entity : null);
		}
		Entity entity2 = entity;
		return entity2 != null && InputFunctionCommon.CanResponseInput(entity2);
	}

	// Token: 0x06018567 RID: 99687 RVA: 0x007577D4 File Offset: 0x007559D4
	public static bool CanVehicleResponseInput(Entity entity)
	{
		VehicleMoveComponent component = entity.GetComponent<VehicleMoveComponent>();
		if (component == null || !component.CanResponseInput())
		{
			return false;
		}
		BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
		return component2 == null || !component2.HasTag(GameplayTagDefine.EGameplayTagId["载具.行为状态.动作状态.冲刺"]);
	}

	// Token: 0x06018568 RID: 99688 RVA: 0x00757820 File Offset: 0x00755A20
	[NullableContext(2)]
	public static InputFunctionCommon.IInputCommandTransformResult CreateInputCommandFromDataTable(int entityId, AkiClient.Game.Aki.Character.Input.Enum.EInputAction action, EInputState state)
	{
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity == null)
		{
			return null;
		}
		BaseTagComponent component = EntitySystem.Instance.GetComponent<BaseTagComponent>(entityId);
		BaseSkillComponent component2 = EntitySystem.Instance.GetComponent<BaseSkillComponent>(entityId);
		if (component == null || component2 == null)
		{
			return null;
		}
		SInputCommandTransform[] inputCommandTransformData = InputModel.Instance.GetInputCommandTransformData(action, state);
		if (inputCommandTransformData == null)
		{
			return null;
		}
		foreach (SInputCommandTransform sinputCommandTransform in inputCommandTransformData)
		{
			if (component.HasTag(sinputCommandTransform.Tag.TagId()))
			{
				bool flag = false;
				if (sinputCommandTransform.BehaviorConditionGroup.Num() == 0)
				{
					flag = true;
				}
				else if (SkillBehaviorCondition.SatisfyGroup(sinputCommandTransform.BehaviorConditionGroup, sinputCommandTransform.BehaviorConditionFormula, new BeginSkillBehaviorConditionParam
				{
					Entity = entity,
					SkillComponent = component2,
					Skill = InputFunctionCommon.TempSkill
				}))
				{
					flag = true;
				}
				if (flag)
				{
					SInputCommand sinputCommand;
					if (sinputCommandTransform.Command.CommandType == ECommandType.Skill)
					{
						sinputCommand = InputFunctionCommon.CreateSkillCommand(entity, sinputCommandTransform.Command.IntValue);
					}
					else
					{
						sinputCommand = new SInputCommand
						{
							CommandType = sinputCommandTransform.Command.CommandType,
							IntValue = sinputCommandTransform.Command.IntValue,
							TagValue = sinputCommandTransform.Command.TagValue
						};
					}
					if (sinputCommand == null)
					{
						return null;
					}
					return new InputFunctionCommon.InputCommandTransformResult
					{
						Command = sinputCommand,
						TransformData = sinputCommandTransform
					};
				}
			}
		}
		return null;
	}

	// Token: 0x06018569 RID: 99689 RVA: 0x00757990 File Offset: 0x00755B90
	public static bool HasEnoughEnergy(Entity entity)
	{
		BaseAttributeComponent component = entity.GetComponent<BaseAttributeComponent>();
		return component.GetCurrentValue(EAttributeType.SpecialEnergy4) >= component.GetCurrentValue(EAttributeType.SpecialEnergy4Max);
	}

	// Token: 0x0601856A RID: 99690 RVA: 0x007579B9 File Offset: 0x00755BB9
	public static void CreateStaticDefaultValue()
	{
		InputFunctionCommon._tempSkill = new Skill();
	}

	// Token: 0x0601856B RID: 99691 RVA: 0x007579C5 File Offset: 0x00755BC5
	public static void ResetStaticDefaultValue()
	{
		InputFunctionCommon._tempSkill = null;
	}

	// Token: 0x0400D23B RID: 53819
	[Nullable(2)]
	private static Skill _tempSkill;

	// Token: 0x02008891 RID: 34961
	public interface IInputCommandTransformResult
	{
		// Token: 0x170078A2 RID: 30882
		// (get) Token: 0x06042733 RID: 272179
		// (set) Token: 0x06042734 RID: 272180
		SInputCommand Command { get; set; }

		// Token: 0x170078A3 RID: 30883
		// (get) Token: 0x06042735 RID: 272181
		// (set) Token: 0x06042736 RID: 272182
		SInputCommandTransform TransformData { get; set; }
	}

	// Token: 0x02008892 RID: 34962
	[Nullable(0)]
	[RequiredMember]
	public class InputCommandTransformResult : InputFunctionCommon.IInputCommandTransformResult
	{
		// Token: 0x170078A4 RID: 30884
		// (get) Token: 0x06042737 RID: 272183 RVA: 0x013BF694 File Offset: 0x013BD894
		// (set) Token: 0x06042738 RID: 272184 RVA: 0x013BF69C File Offset: 0x013BD89C
		[RequiredMember]
		public SInputCommand Command { get; set; }

		// Token: 0x170078A5 RID: 30885
		// (get) Token: 0x06042739 RID: 272185 RVA: 0x013BF6A5 File Offset: 0x013BD8A5
		// (set) Token: 0x0604273A RID: 272186 RVA: 0x013BF6AD File Offset: 0x013BD8AD
		[RequiredMember]
		public SInputCommandTransform TransformData { get; set; }

		// Token: 0x0604273B RID: 272187 RVA: 0x013BF6B6 File Offset: 0x013BD8B6
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public InputCommandTransformResult()
		{
		}
	}
}
