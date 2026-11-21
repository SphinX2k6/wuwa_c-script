using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using AkiClient.Game.Aki.Character.Vision;
using CSharpScript.Core.Common;
using CSharpScript.Game;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.NewWorld.Character.Common.Component.Explore;
using CSharpScript.Game.NewWorld.Character.Custom.Components;
using CSharpScript.Game.NewWorld.Character.Role.Component;
using UnrealEngine;

// Token: 0x02002615 RID: 9749
[NullableContext(2)]
[Nullable(0)]
public class InputFunctionVisionSkill1 : IStaticVariableResetter
{
	// Token: 0x0601858B RID: 99723 RVA: 0x00758238 File Offset: 0x00756438
	static InputFunctionVisionSkill1()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InputFunctionVisionSkill1.CreateStaticDefaultValue), new Action(InputFunctionVisionSkill1.ResetStaticDefaultValue));
	}

	// Token: 0x0601858C RID: 99724 RVA: 0x00758294 File Offset: 0x00756494
	public static void CreateStaticDefaultValue()
	{
		InputFunctionVisionSkill1.MotorcycleDisableChain = new MotorFunctionDisableHandler();
		InputFunctionVisionSkill1.MotorcycleDisableChain.SetNext(new CharacterResponseInputDisableHandler()).SetNext(new PositionStateDisableHandler()).SetNext(new TagDisableHandler()).SetNext(new EntityDisableHandler()).SetNext(new OnlineDisableHandler());
	}

	// Token: 0x0601858D RID: 99725 RVA: 0x007582E3 File Offset: 0x007564E3
	public static void ResetStaticDefaultValue()
	{
		InputFunctionVisionSkill1.MotorcycleDisableChain = null;
	}

	// Token: 0x0601858E RID: 99726 RVA: 0x007582EC File Offset: 0x007564EC
	[NullableContext(1)]
	private static bool VisionSkill1TraceDetectHasGround(Entity entity)
	{
		CharacterActorComponent component = entity.GetComponent<CharacterActorComponent>();
		if (component == null)
		{
			return false;
		}
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		actorTrace.WorldContextObject = component.Actor;
		actorTrace.Radius = component.ScaledRadius;
		TraceElementCommon.Instance.SetStartLocation(actorTrace, component.FloorLocation);
		Vector tmpVector = InputFunctionVisionSkill1.TmpVector;
		FVectorDouble fvectorDouble = component.ActorTransform.TransformVectorNoScale(InputFunctionVisionSkill1.SoarLandDetectOffset);
		tmpVector.FromUeVector(fvectorDouble);
		InputFunctionVisionSkill1.TmpVector.AdditionEqual(component.FloorLocation);
		TraceElementCommon.Instance.SetEndLocation(actorTrace, InputFunctionVisionSkill1.TmpVector);
		actorTrace.ActorsToIgnore.Empty(true);
		return TraceElementCommon.Instance.ShapeTrace(component.Actor.CapsuleComponent, actorTrace, "SoarEnterDetect", "SoarEnterDetect");
	}

	// Token: 0x0601858F RID: 99727 RVA: 0x007583A8 File Offset: 0x007565A8
	[NullableContext(1)]
	private static bool IsFollowerDisable(BaseTagComponent tagComp)
	{
		return tagComp.HasAnyTag(new int[]
		{
			GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.瞄准蓄力"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.瞄准射击"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.瞄准键进入"],
			GameplayTagDefine.EGameplayTagId["功能.功能制作.瞄准模式.通用瞄准进入"],
			GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.技能中.全身动作"],
			GameplayTagDefine.EGameplayTagId["行为状态.动作状态.受击"]
		});
	}

	// Token: 0x06018590 RID: 99728 RVA: 0x00758430 File Offset: 0x00756630
	[NullableContext(1)]
	private static InputFunctionVisionSkill1.IExploreDeriveResult TryExploreDerive(TsBaseCharacter character, Entity entity, BaseTagComponent tagComp, int exploreToolId, int skillId)
	{
		if (skillId == 210001)
		{
			int pbDataId = character.CharacterActorComponent.CreatureData.GetPbDataId();
			if (RoleConfig.Instance.GetBaseRoleId(pbDataId) == 1208 && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["功能.通用镜头.第一人称镜头"]))
			{
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = true,
					SkillId = 1208713
				};
			}
			if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.风筝钩索可用"]))
			{
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = true,
					SkillId = 210130
				};
			}
			if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.移动钩锁可用"]))
			{
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = true,
					SkillId = 100024
				};
			}
			if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.摩托弹射机关可用"]))
			{
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = true,
					SkillId = 800017
				};
			}
			RoleSceneInteractComponent component = entity.GetComponent<RoleSceneInteractComponent>();
			if (component != null && component.CanActivateFixHook())
			{
				if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.定点钩锁切换"]))
				{
					return new InputFunctionVisionSkill1.ExploreDeriveResult
					{
						Derived = true,
						SkillId = 100021
					};
				}
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = true,
					SkillId = 100020
				};
			}
			else
			{
				if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.定点钩索"]))
				{
					return new InputFunctionVisionSkill1.ExploreDeriveResult
					{
						Derived = true,
						SkillId = 0
					};
				}
				if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.禁用自由钩锁"]))
				{
					InputFunctionVisionSkill1.ExploreDeriveResult exploreDeriveResult = new InputFunctionVisionSkill1.ExploreDeriveResult();
					exploreDeriveResult.Derived = false;
					exploreDeriveResult.SkillId = 0;
					exploreDeriveResult.OnRejected = delegate()
					{
						GenericPromptController.Instance.ShowPromptByCode("ExploreToolsDisable011007", Array.Empty<object>());
					};
					return exploreDeriveResult;
				}
				if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.定点钩索可用"]))
				{
					return new InputFunctionVisionSkill1.ExploreDeriveResult
					{
						Derived = true,
						SkillId = 0
					};
				}
			}
		}
		else if (skillId == 2100081)
		{
			if (tagComp.HasAnyTag(new int[]
			{
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"],
				GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"],
				GameplayTagDefine.EGameplayTagId["战斗状态.技能限制.禁止声骸展示技能"],
				GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.禁用声骸显像"]
			}))
			{
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = false,
					SkillId = 0
				};
			}
		}
		else if (skillId == 210003)
		{
			if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.拉取巨物可用"]))
			{
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = true,
					SkillId = 2100031
				};
			}
			if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.拉取雕像可用"]))
			{
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = true,
					SkillId = 2100033
				};
			}
			if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]) || !tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.控物可用"]))
			{
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = false,
					SkillId = 0
				};
			}
		}
		else if (skillId == 210020)
		{
			if (!tagComp.HasTag(GameplayTagDefine.EGameplayTagId["辅助机.通用射击"]))
			{
				if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.禁用辅助机"]) || tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.禁止瞄准模式"]))
				{
					InputFunctionVisionSkill1.ExploreDeriveResult exploreDeriveResult2 = new InputFunctionVisionSkill1.ExploreDeriveResult();
					exploreDeriveResult2.Derived = false;
					exploreDeriveResult2.SkillId = 0;
					exploreDeriveResult2.OnRejected = delegate()
					{
						GenericPromptController.Instance.ShowPromptByCode("ExploreToolsShooterDisable", Array.Empty<object>());
					};
					return exploreDeriveResult2;
				}
				if (InputFunctionVisionSkill1.IsFollowerDisable(tagComp))
				{
					return new InputFunctionVisionSkill1.ExploreDeriveResult
					{
						Derived = false,
						SkillId = 0
					};
				}
			}
		}
		else if (skillId == 210030)
		{
			if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.探索技能.翱翔内置CD"]))
			{
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = false,
					SkillId = 0
				};
			}
			if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.动作状态.XA"]))
			{
				return new InputFunctionVisionSkill1.ExploreDeriveResult
				{
					Derived = false,
					SkillId = 0,
					OnRejected = delegate
					{
						character.KuroSetMovementMode(new SetMovementModeInfo
						{
							Mode = EMovementMode.MOVE_Falling,
							Context = "[visionSkill1Function]"
						});
					}
				};
			}
			CharacterGlideComponent component2 = entity.GetComponent<CharacterGlideComponent>();
			ValueTuple<bool, string>? valueTuple = (component2 != null) ? new ValueTuple<bool, string>?(component2.CheckSoarAllowed()) : null;
			if (valueTuple == null || !valueTuple.GetValueOrDefault().Item1)
			{
				InputFunctionVisionSkill1.ExploreDeriveResult exploreDeriveResult3 = new InputFunctionVisionSkill1.ExploreDeriveResult();
				exploreDeriveResult3.Derived = false;
				exploreDeriveResult3.SkillId = 0;
				exploreDeriveResult3.OnRejected = delegate()
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
				};
				return exploreDeriveResult3;
			}
			if (tagComp.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
			{
				InputFunctionVisionSkill1.ExploreDeriveResult exploreDeriveResult4 = new InputFunctionVisionSkill1.ExploreDeriveResult();
				exploreDeriveResult4.Derived = false;
				exploreDeriveResult4.SkillId = 0;
				exploreDeriveResult4.OnRejected = delegate()
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
				};
				return exploreDeriveResult4;
			}
			BaseUnifiedStateComponent component3 = entity.GetComponent<BaseUnifiedStateComponent>();
			ECharPositionState? echarPositionState = (component3 != null) ? new ECharPositionState?(component3.PositionState) : null;
			if (echarPositionState.GetValueOrDefault() == ECharPositionState.Air)
			{
				BaseMoveComponent component4 = entity.GetComponent<BaseMoveComponent>();
				float? num = (component4 != null) ? new float?(component4.GetHeightAboveGround(650f)) : null;
				if (num != null)
				{
					float? num2 = num;
					float num3 = 650f;
					if (!(num2.GetValueOrDefault() < num3 & num2 != null))
					{
						goto IL_70C;
					}
				}
				if (InputFunctionVisionSkill1.VisionSkill1TraceDetectHasGround(entity))
				{
					InputFunctionVisionSkill1.ExploreDeriveResult exploreDeriveResult5 = new InputFunctionVisionSkill1.ExploreDeriveResult();
					exploreDeriveResult5.Derived = false;
					exploreDeriveResult5.SkillId = 0;
					exploreDeriveResult5.OnRejected = delegate()
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip", Array.Empty<object>());
					};
					return exploreDeriveResult5;
				}
			}
			else
			{
				ECharPositionState? echarPositionState2 = echarPositionState;
				ECharPositionState echarPositionState3 = ECharPositionState.Ground;
				if (echarPositionState2.GetValueOrDefault() == echarPositionState3 & echarPositionState2 != null)
				{
					return new InputFunctionVisionSkill1.ExploreDeriveResult
					{
						Derived = false,
						SkillId = 210031
					};
				}
				InputFunctionVisionSkill1.ExploreDeriveResult exploreDeriveResult6 = new InputFunctionVisionSkill1.ExploreDeriveResult();
				exploreDeriveResult6.Derived = false;
				exploreDeriveResult6.SkillId = 0;
				exploreDeriveResult6.OnRejected = delegate()
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
				};
				return exploreDeriveResult6;
			}
		}
		else if (skillId == 800001 || skillId == 800002 || skillId == 800003)
		{
			if (InputFunctionVisionSkill1.MotorcycleDisableChain == null || InputFunctionVisionSkill1.MotorcycleDisableChain.Stop(new InputFunctionContext(entity, skillId)))
			{
				InputFunctionVisionSkill1.ExploreDeriveResult exploreDeriveResult7 = new InputFunctionVisionSkill1.ExploreDeriveResult();
				exploreDeriveResult7.Derived = false;
				exploreDeriveResult7.SkillId = 0;
				exploreDeriveResult7.OnRejected = delegate()
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("Flying_Tip_002", Array.Empty<object>());
				};
				return exploreDeriveResult7;
			}
		}
		else if (exploreToolId == 121001 && (!tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.主控机甲"]) || tagComp.HasTag(GameplayTagDefine.EGameplayTagId["角色.AimisiMd10011.状态.低冲刺能量"])))
		{
			return new InputFunctionVisionSkill1.ExploreDeriveResult
			{
				Derived = false,
				SkillId = 0
			};
		}
		IL_70C:
		return new InputFunctionVisionSkill1.ExploreDeriveResult
		{
			Derived = false,
			SkillId = skillId
		};
	}

	// Token: 0x06018591 RID: 99729 RVA: 0x00758B60 File Offset: 0x00756D60
	private static SInputCommand VisionSkill1Function(float time)
	{
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		if (baseCharacter == null)
		{
			return null;
		}
		CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
		Entity entity = (characterActorComponent != null) ? characterActorComponent.Entity : null;
		if (entity == null)
		{
			return null;
		}
		BaseTagComponent component = entity.GetComponent<BaseTagComponent>();
		if (component == null || !component.Valid)
		{
			return null;
		}
		BaseMoveComponent component2 = entity.GetComponent<BaseMoveComponent>();
		if (component2 == null || !component2.CanResponseInput() || component.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"]))
		{
			return null;
		}
		InputFunctionCommon.IInputCommandTransformResult inputCommandTransformResult = InputFunctionCommon.CreateInputCommandFromDataTable(entity.Id, EInputAction.幻象1, EInputState.Press);
		if (inputCommandTransformResult != null && !inputCommandTransformResult.TransformData.PriorityBelowExploreDerive)
		{
			return inputCommandTransformResult.Command;
		}
		SInputCommand sinputCommand = (inputCommandTransformResult != null && inputCommandTransformResult.TransformData.PriorityBelowExploreDerive) ? inputCommandTransformResult.Command : null;
		if (component.HasTag(GameplayTagDefine.EGameplayTagId["关卡.道具.怨鸟泽.水龙卷buff"]))
		{
			CharacterMoveComponent component3 = entity.GetComponent<CharacterMoveComponent>();
			if (component3 != null && component3.IsOnGroundOrOnWater())
			{
				return InputFunctionCommon.CreateSkillCommand(entity, 210014);
			}
		}
		else if (component.HasTag(GameplayTagDefine.EGameplayTagId["关卡.时停状态.可使用时停"]))
		{
			if (component.HasTag(GameplayTagDefine.EGameplayTagId["关卡.时停状态.进入时停"]))
			{
				return InputFunctionCommon.CreateSkillCommand(entity, 210024);
			}
			return InputFunctionCommon.CreateSkillCommand(entity, 210023);
		}
		else if (component.HasTag(GameplayTagDefine.EGameplayTagId["辅助机.通用标签.幻象1召唤"]))
		{
			if (InputFunctionVisionSkill1.IsFollowerDisable(component))
			{
				return null;
			}
			return InputFunctionCommon.CreateSkillCommand(entity, 210020);
		}
		int currentExploreSkillId = RouletteModel.Instance.CurrentExploreSkillId;
		if (currentExploreSkillId == 0)
		{
			return sinputCommand;
		}
		int num = 0;
		SVisionData visionData = PhantomUtil.GetVisionData(currentExploreSkillId);
		if (visionData != null && visionData.类型 == EVisionType.探索)
		{
			num = visionData.技能ID;
		}
		InputFunctionVisionSkill1.IExploreDeriveResult exploreDeriveResult = InputFunctionVisionSkill1.TryExploreDerive(baseCharacter, entity, component, currentExploreSkillId, num);
		num = exploreDeriveResult.SkillId;
		if (!exploreDeriveResult.Derived)
		{
			if (sinputCommand != null)
			{
				return sinputCommand;
			}
			Action onRejected = exploreDeriveResult.OnRejected;
			if (onRejected != null)
			{
				onRejected();
			}
		}
		if (num != 0)
		{
			if (ExploreSkillFlagModel.Instance.GetExploreSkillFlagEnable((EExploreSkillType)num))
			{
				CharacterExploreComponent characterExploreComponent = (entity != null) ? entity.GetComponent<CharacterExploreComponent>() : null;
				RouletteModel instance = RouletteModel.Instance;
				int exploreSkillId = currentExploreSkillId;
				int skillId = num;
				int? num2;
				if (characterExploreComponent == null)
				{
					num2 = null;
				}
				else
				{
					GrapplingHookPointComponent focusTarget = characterExploreComponent.FocusTarget;
					num2 = ((focusTarget != null) ? new int?(focusTarget.EntityConfigId) : null);
				}
				int? num3 = num2;
				instance.TrySendExploreToolGeneralUseLogData(exploreSkillId, skillId, num3.GetValueOrDefault());
				return InputFunctionCommon.CreateSkillCommand(entity, num);
			}
			GenericPromptController.Instance.ShowPromptByCode(EMapExploreToolCheckTipId.TempTeleporterPlacementBanned.ToEnumString(), Array.Empty<object>());
		}
		return null;
	}

	// Token: 0x06018592 RID: 99730 RVA: 0x00758DCE File Offset: 0x00756FCE
	public static SInputCommand VisionSkill1OnPress(float time)
	{
		if (Info.Instance.IsInTouch())
		{
			return null;
		}
		return InputFunctionVisionSkill1.VisionSkill1Function(time);
	}

	// Token: 0x06018593 RID: 99731 RVA: 0x00758DE4 File Offset: 0x00756FE4
	public static SInputCommand VisionSkill1OnRelease(float time)
	{
		if (!Info.Instance.IsInTouch())
		{
			return null;
		}
		if (UiBlueprintFunctionLibrary.IsLongPressExploreButton())
		{
			return null;
		}
		return InputFunctionVisionSkill1.VisionSkill1Function(time);
	}

	// Token: 0x06018594 RID: 99732 RVA: 0x00758E04 File Offset: 0x00757004
	public static int? GetVisionSkill1SkillId()
	{
		SInputCommand sinputCommand = InputFunctionVisionSkill1.VisionSkill1Function(0f);
		if (sinputCommand != null)
		{
			return new int?(sinputCommand.IntValue);
		}
		return null;
	}

	// Token: 0x0400D242 RID: 53826
	private static MotorFunctionDisableHandler MotorcycleDisableChain;

	// Token: 0x0400D243 RID: 53827
	private const float SOAR_HEIGHT_LIMIT = 650f;

	// Token: 0x0400D244 RID: 53828
	[StaticVariableRuleIgnore]
	private static readonly FVectorDouble SoarLandDetectOffset = new FVectorDouble(1100.0, 0.0, -500.0);

	// Token: 0x0400D245 RID: 53829
	private const int ROLE_ID_CALBRENA = 1208;

	// Token: 0x0400D246 RID: 53830
	[Nullable(1)]
	private const string PROFILE_KEY = "SoarEnterDetect";

	// Token: 0x0400D247 RID: 53831
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x02008893 RID: 34963
	public interface IExploreDeriveResult
	{
		// Token: 0x170078A6 RID: 30886
		// (get) Token: 0x0604273C RID: 272188
		// (set) Token: 0x0604273D RID: 272189
		bool Derived { get; set; }

		// Token: 0x170078A7 RID: 30887
		// (get) Token: 0x0604273E RID: 272190
		// (set) Token: 0x0604273F RID: 272191
		int SkillId { get; set; }

		// Token: 0x170078A8 RID: 30888
		// (get) Token: 0x06042740 RID: 272192
		// (set) Token: 0x06042741 RID: 272193
		Action OnRejected { get; set; }
	}

	// Token: 0x02008894 RID: 34964
	[Nullable(0)]
	[RequiredMember]
	public class ExploreDeriveResult : InputFunctionVisionSkill1.IExploreDeriveResult
	{
		// Token: 0x170078A9 RID: 30889
		// (get) Token: 0x06042742 RID: 272194 RVA: 0x013BF6BE File Offset: 0x013BD8BE
		// (set) Token: 0x06042743 RID: 272195 RVA: 0x013BF6C6 File Offset: 0x013BD8C6
		[RequiredMember]
		public bool Derived { get; set; }

		// Token: 0x170078AA RID: 30890
		// (get) Token: 0x06042744 RID: 272196 RVA: 0x013BF6CF File Offset: 0x013BD8CF
		// (set) Token: 0x06042745 RID: 272197 RVA: 0x013BF6D7 File Offset: 0x013BD8D7
		[RequiredMember]
		public int SkillId { get; set; }

		// Token: 0x170078AB RID: 30891
		// (get) Token: 0x06042746 RID: 272198 RVA: 0x013BF6E0 File Offset: 0x013BD8E0
		// (set) Token: 0x06042747 RID: 272199 RVA: 0x013BF6E8 File Offset: 0x013BD8E8
		public Action OnRejected { get; set; }

		// Token: 0x06042748 RID: 272200 RVA: 0x013BF6F1 File Offset: 0x013BD8F1
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ExploreDeriveResult()
		{
		}
	}
}
