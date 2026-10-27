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

// Token: 0x020030BD RID: 12477
[NullableContext(2)]
[Nullable(0)]
public class InputFunctionVisionSkill1 : IStaticVariableResetter
{
	// Token: 0x0601AB7C RID: 109436 RVA: 0x007328CC File Offset: 0x00730ACC
	static InputFunctionVisionSkill1()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InputFunctionVisionSkill1.CreateStaticDefaultValue), new Action(InputFunctionVisionSkill1.ResetStaticDefaultValue));
	}

	// Token: 0x0601AB7D RID: 109437 RVA: 0x00732928 File Offset: 0x00730B28
	public static void CreateStaticDefaultValue()
	{
		InputFunctionVisionSkill1.MotorcycleDisableChain = new MotorFunctionDisableHandler();
		InputFunctionVisionSkill1.MotorcycleDisableChain.SetNext(new CharacterResponseInputDisableHandler()).SetNext(new PositionStateDisableHandler()).SetNext(new TagDisableHandler()).SetNext(new EntityDisableHandler()).SetNext(new OnlineDisableHandler());
	}

	// Token: 0x0601AB7E RID: 109438 RVA: 0x00732977 File Offset: 0x00730B77
	public static void ResetStaticDefaultValue()
	{
		InputFunctionVisionSkill1.MotorcycleDisableChain = null;
	}

	// Token: 0x0601AB7F RID: 109439 RVA: 0x00732980 File Offset: 0x00730B80
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

	// Token: 0x0601AB80 RID: 109440 RVA: 0x00732A3C File Offset: 0x00730C3C
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

	// Token: 0x0601AB81 RID: 109441 RVA: 0x00732AC4 File Offset: 0x00730CC4
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

	// Token: 0x0601AB82 RID: 109442 RVA: 0x007331F4 File Offset: 0x007313F4
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

	// Token: 0x0601AB83 RID: 109443 RVA: 0x00733462 File Offset: 0x00731662
	public static SInputCommand VisionSkill1OnPress(float time)
	{
		if (Info.Instance.IsInTouch())
		{
			return null;
		}
		return InputFunctionVisionSkill1.VisionSkill1Function(time);
	}

	// Token: 0x0601AB84 RID: 109444 RVA: 0x00733478 File Offset: 0x00731678
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

	// Token: 0x0601AB85 RID: 109445 RVA: 0x00733498 File Offset: 0x00731698
	public static int? GetVisionSkill1SkillId()
	{
		SInputCommand sinputCommand = InputFunctionVisionSkill1.VisionSkill1Function(0f);
		if (sinputCommand != null)
		{
			return new int?(sinputCommand.IntValue);
		}
		return null;
	}

	// Token: 0x0400CE56 RID: 52822
	private static MotorFunctionDisableHandler MotorcycleDisableChain;

	// Token: 0x0400CE57 RID: 52823
	private const float SOAR_HEIGHT_LIMIT = 650f;

	// Token: 0x0400CE58 RID: 52824
	[StaticVariableRuleIgnore]
	private static readonly FVectorDouble SoarLandDetectOffset = new FVectorDouble(1100.0, 0.0, -500.0);

	// Token: 0x0400CE59 RID: 52825
	private const int ROLE_ID_CALBRENA = 1208;

	// Token: 0x0400CE5A RID: 52826
	[Nullable(1)]
	private const string PROFILE_KEY = "SoarEnterDetect";

	// Token: 0x0400CE5B RID: 52827
	[Nullable(1)]
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x02009672 RID: 38514
	public interface IExploreDeriveResult
	{
		// Token: 0x1700A117 RID: 41239
		// (get) Token: 0x0604C2B5 RID: 311989
		// (set) Token: 0x0604C2B6 RID: 311990
		bool Derived { get; set; }

		// Token: 0x1700A118 RID: 41240
		// (get) Token: 0x0604C2B7 RID: 311991
		// (set) Token: 0x0604C2B8 RID: 311992
		int SkillId { get; set; }

		// Token: 0x1700A119 RID: 41241
		// (get) Token: 0x0604C2B9 RID: 311993
		// (set) Token: 0x0604C2BA RID: 311994
		Action OnRejected { get; set; }
	}

	// Token: 0x02009673 RID: 38515
	[Nullable(0)]
	[RequiredMember]
	public class ExploreDeriveResult : InputFunctionVisionSkill1.IExploreDeriveResult
	{
		// Token: 0x1700A11A RID: 41242
		// (get) Token: 0x0604C2BB RID: 311995 RVA: 0x01414BA2 File Offset: 0x01412DA2
		// (set) Token: 0x0604C2BC RID: 311996 RVA: 0x01414BAA File Offset: 0x01412DAA
		[RequiredMember]
		public bool Derived { get; set; }

		// Token: 0x1700A11B RID: 41243
		// (get) Token: 0x0604C2BD RID: 311997 RVA: 0x01414BB3 File Offset: 0x01412DB3
		// (set) Token: 0x0604C2BE RID: 311998 RVA: 0x01414BBB File Offset: 0x01412DBB
		[RequiredMember]
		public int SkillId { get; set; }

		// Token: 0x1700A11C RID: 41244
		// (get) Token: 0x0604C2BF RID: 311999 RVA: 0x01414BC4 File Offset: 0x01412DC4
		// (set) Token: 0x0604C2C0 RID: 312000 RVA: 0x01414BCC File Offset: 0x01412DCC
		public Action OnRejected { get; set; }

		// Token: 0x0604C2C1 RID: 312001 RVA: 0x01414BD5 File Offset: 0x01412DD5
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ExploreDeriveResult()
		{
		}
	}
}
