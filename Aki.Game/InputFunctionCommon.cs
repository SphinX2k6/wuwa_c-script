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

// Token: 0x020030B2 RID: 12466
[NullableContext(1)]
[Nullable(0)]
public class InputFunctionCommon : IStaticVariableResetter
{
	// Token: 0x0601AB53 RID: 109395 RVA: 0x00731CA3 File Offset: 0x0072FEA3
	static InputFunctionCommon()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InputFunctionCommon.CreateStaticDefaultValue), new Action(InputFunctionCommon.ResetStaticDefaultValue));
	}

	// Token: 0x170024B8 RID: 9400
	// (get) Token: 0x0601AB54 RID: 109396 RVA: 0x00731CC2 File Offset: 0x0072FEC2
	private static Skill TempSkill
	{
		get
		{
			return InputFunctionCommon._tempSkill;
		}
	}

	// Token: 0x0601AB55 RID: 109397 RVA: 0x00731CCC File Offset: 0x0072FECC
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
			return new SInputCommand(ECommandType.Skill, skillId, default(FGameplayTag));
		}
		return null;
	}

	// Token: 0x0601AB56 RID: 109398 RVA: 0x00731D58 File Offset: 0x0072FF58
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

	// Token: 0x0601AB57 RID: 109399 RVA: 0x00731E44 File Offset: 0x00730044
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

	// Token: 0x0601AB58 RID: 109400 RVA: 0x00731E80 File Offset: 0x00730080
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

	// Token: 0x0601AB59 RID: 109401 RVA: 0x00731ECC File Offset: 0x007300CC
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
						sinputCommand = new SInputCommand(sinputCommandTransform.Command.CommandType, sinputCommandTransform.Command.IntValue, sinputCommandTransform.Command.TagValue);
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

	// Token: 0x0601AB5A RID: 109402 RVA: 0x00732028 File Offset: 0x00730228
	public static bool HasEnoughEnergy(Entity entity)
	{
		BaseAttributeComponent component = entity.GetComponent<BaseAttributeComponent>();
		return component.GetCurrentValue(EAttributeType.SpecialEnergy4) >= component.GetCurrentValue(EAttributeType.SpecialEnergy4Max);
	}

	// Token: 0x0601AB5B RID: 109403 RVA: 0x00732051 File Offset: 0x00730251
	public static void CreateStaticDefaultValue()
	{
		InputFunctionCommon._tempSkill = new Skill();
	}

	// Token: 0x0601AB5C RID: 109404 RVA: 0x0073205D File Offset: 0x0073025D
	public static void ResetStaticDefaultValue()
	{
		InputFunctionCommon._tempSkill = null;
	}

	// Token: 0x0400CE4F RID: 52815
	[Nullable(2)]
	private static Skill _tempSkill;

	// Token: 0x02009670 RID: 38512
	public interface IInputCommandTransformResult
	{
		// Token: 0x1700A113 RID: 41235
		// (get) Token: 0x0604C2AC RID: 311980
		// (set) Token: 0x0604C2AD RID: 311981
		SInputCommand Command { get; set; }

		// Token: 0x1700A114 RID: 41236
		// (get) Token: 0x0604C2AE RID: 311982
		// (set) Token: 0x0604C2AF RID: 311983
		SInputCommandTransform TransformData { get; set; }
	}

	// Token: 0x02009671 RID: 38513
	[Nullable(0)]
	[RequiredMember]
	public class InputCommandTransformResult : InputFunctionCommon.IInputCommandTransformResult
	{
		// Token: 0x1700A115 RID: 41237
		// (get) Token: 0x0604C2B0 RID: 311984 RVA: 0x01414B78 File Offset: 0x01412D78
		// (set) Token: 0x0604C2B1 RID: 311985 RVA: 0x01414B80 File Offset: 0x01412D80
		[RequiredMember]
		public SInputCommand Command { get; set; }

		// Token: 0x1700A116 RID: 41238
		// (get) Token: 0x0604C2B2 RID: 311986 RVA: 0x01414B89 File Offset: 0x01412D89
		// (set) Token: 0x0604C2B3 RID: 311987 RVA: 0x01414B91 File Offset: 0x01412D91
		[RequiredMember]
		public SInputCommandTransform TransformData { get; set; }

		// Token: 0x0604C2B4 RID: 311988 RVA: 0x01414B9A File Offset: 0x01412D9A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public InputCommandTransformResult()
		{
		}
	}
}
