using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using CSharpScript.Game.Module.GenericPrompt;

// Token: 0x02001080 RID: 4224
[NullableContext(1)]
[Nullable(0)]
public static class FormationValidators
{
	// Token: 0x0600A7D1 RID: 42961 RVA: 0x003162B4 File Offset: 0x003144B4
	private static TRuleResult Fail(EOpenViewBlockReason reason)
	{
		return new TRuleResult
		{
			Pass = false,
			Reason = reason
		};
	}

	// Token: 0x0600A7D2 RID: 42962 RVA: 0x003162C9 File Offset: 0x003144C9
	private static bool HasTag(int tagId)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		object obj;
		if (getCurrentEntity == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		object obj2 = obj;
		return obj2 != null && obj2.HasTag(tagId);
	}

	// Token: 0x0600A7D3 RID: 42963 RVA: 0x003162F9 File Offset: 0x003144F9
	private static TRuleResult RuleFunctionOpen()
	{
		if (!FunctionModel.Instance.IsOpen(EFunctionType.FormatTeam))
		{
			return FormationValidators.Fail(EOpenViewBlockReason.FunctionNotOpen);
		}
		return FormationValidators.Pass;
	}

	// Token: 0x0600A7D4 RID: 42964 RVA: 0x00316318 File Offset: 0x00314518
	private static TRuleResult RuleNotLockByBehaviorTree()
	{
		if (!FunctionModel.Instance.IsLockByBehaviorTree(10007))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.LockByBehaviorTree);
	}

	// Token: 0x0600A7D5 RID: 42965 RVA: 0x00316337 File Offset: 0x00314537
	private static TRuleResult RuleNotPhantomTeam()
	{
		if (!SceneTeamModel.Instance.IsPhantomTeam)
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InPhantomTeam);
	}

	// Token: 0x0600A7D6 RID: 42966 RVA: 0x00316351 File Offset: 0x00314551
	private static TRuleResult RuleEntityValid()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return FormationValidators.Fail(EOpenViewBlockReason.EntityInvalid);
		}
		return FormationValidators.Pass;
	}

	// Token: 0x0600A7D7 RID: 42967 RVA: 0x00316378 File Offset: 0x00314578
	private static TRuleResult RuleTeamNotDead()
	{
		int playerId = CreatureModel.Instance.GetPlayerId();
		if (SceneTeamModel.Instance.GetCurrentGroupLivingState(playerId) != ETeamLivingState.Dead)
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.Dead);
	}

	// Token: 0x0600A7D8 RID: 42968 RVA: 0x003163AA File Offset: 0x003145AA
	private static TRuleResult RuleTagComponentExists()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		object obj;
		if (getCurrentEntity == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null || !obj2.Valid)
		{
			return FormationValidators.Fail(EOpenViewBlockReason.TagComponentMissing);
		}
		return FormationValidators.Pass;
	}

	// Token: 0x0600A7D9 RID: 42969 RVA: 0x003163E8 File Offset: 0x003145E8
	private static TRuleResult RuleBuffComponentExists()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		object obj;
		if (getCurrentEntity == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			obj = ((entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null || !obj2.Valid)
		{
			return FormationValidators.Fail(EOpenViewBlockReason.BuffComponentMissing);
		}
		return FormationValidators.Pass;
	}

	// Token: 0x0600A7DA RID: 42970 RVA: 0x00316426 File Offset: 0x00314626
	private static TRuleResult RuleNotOnVehicle()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		object obj;
		if (getCurrentEntity == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			obj = ((entity != null) ? entity.GetComponent<RoleDriveVehicleComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null || !obj2.IsOnVehicle)
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.OnVehicle);
	}

	// Token: 0x0600A7DB RID: 42971 RVA: 0x00316464 File Offset: 0x00314664
	private static TRuleResult RuleNotInRoleTrial()
	{
		if (!RoleController.Instance.IsInRoleTrial())
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InRoleTrial);
	}

	// Token: 0x0600A7DC RID: 42972 RVA: 0x0031647F File Offset: 0x0031467F
	private static TRuleResult RuleNotInWater()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InWater);
	}

	// Token: 0x0600A7DD RID: 42973 RVA: 0x003164A4 File Offset: 0x003146A4
	private static TRuleResult RuleNotDrowning()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.Drowning);
	}

	// Token: 0x0600A7DE RID: 42974 RVA: 0x003164C9 File Offset: 0x003146C9
	private static TRuleResult RuleNotInAir()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InAir);
	}

	// Token: 0x0600A7DF RID: 42975 RVA: 0x003164EE File Offset: 0x003146EE
	private static TRuleResult RuleNotInFight()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InFight);
	}

	// Token: 0x0600A7E0 RID: 42976 RVA: 0x00316513 File Offset: 0x00314713
	private static TRuleResult RuleNotClimbing()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.Climbing);
	}

	// Token: 0x0600A7E1 RID: 42977 RVA: 0x00316538 File Offset: 0x00314738
	private static TRuleResult RuleCanSwitchRole()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.CannotSwitchRole);
	}

	// Token: 0x0600A7E2 RID: 42978 RVA: 0x00316560 File Offset: 0x00314760
	private static TRuleResult RuleNotPhantomTransformedInAir()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["角色.BaseRole.技能通用标识.幻象变身中"]))
		{
			return FormationValidators.Pass;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		if (worldEntity == null)
		{
			return FormationValidators.Pass;
		}
		EntityHandle summonedEntity = PhantomUtil.GetSummonedEntity(worldEntity, ESummonType.ConcomitantVision, 1);
		object obj;
		if (summonedEntity == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = summonedEntity.Entity;
			obj = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 == null || !obj2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.PhantomTransformedInAir);
	}

	// Token: 0x0600A7E3 RID: 42979 RVA: 0x003165F4 File Offset: 0x003147F4
	private static TRuleResult RuleNotInElevator()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		object obj;
		if (getCurrentEntity == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			obj = ((entity != null) ? entity.GetComponent<CharacterBuffComponent>() : null);
		}
		object obj2 = obj;
		if (((obj2 != null) ? obj2.GetBuffTotalStackById(90003001L, false) : 0) <= 0)
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InElevator);
	}

	// Token: 0x0600A7E4 RID: 42980 RVA: 0x00316648 File Offset: 0x00314848
	private static TRuleResult RuleNotWalkingOnWater()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		CharacterWalkOnWaterComponent characterWalkOnWaterComponent;
		if (getCurrentEntity == null)
		{
			characterWalkOnWaterComponent = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			characterWalkOnWaterComponent = ((entity != null) ? entity.GetComponent<CharacterWalkOnWaterComponent>() : null);
		}
		CharacterWalkOnWaterComponent characterWalkOnWaterComponent2 = characterWalkOnWaterComponent;
		if (characterWalkOnWaterComponent2 == null || characterWalkOnWaterComponent2.WalkOnWaterStage <= EWalkOnWaterStage.None)
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.WalkingOnWater);
	}

	// Token: 0x0600A7E5 RID: 42981 RVA: 0x00316691 File Offset: 0x00314891
	private static TRuleResult RuleInBattleGroup()
	{
		if (SceneTeamModel.Instance.CurrentGroupType.GetValueOrDefault() != ETeamGroupType.Battle)
		{
			return FormationValidators.Fail(EOpenViewBlockReason.NotBattleGroup);
		}
		return FormationValidators.Pass;
	}

	// Token: 0x0600A7E6 RID: 42982 RVA: 0x003166B4 File Offset: 0x003148B4
	public static void ApplyOpenViewBlockReason(EOpenViewBlockReason reason)
	{
		if (reason == EOpenViewBlockReason.None)
		{
			return;
		}
		IBlockReasonEffect blockReasonEffect;
		if (!FormationValidators.BlockReasonEffects.TryGetValue(reason, out blockReasonEffect))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Formation;
			ELogAuthor author = ELogAuthor.SYB;
			string message = "[FormationValidators] 未配置阻断副作用:{Reason}";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("{Reason}", reason.ToString());
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, blockReasonEffect.LogMessage, default(ReadOnlySpan<ValueTuple<string, object>>));
		if (blockReasonEffect.TipsId != null)
		{
			ScrollingTipsController.Instance.ShowTipsById(blockReasonEffect.TipsId, Array.Empty<object>());
		}
		if (blockReasonEffect.PromptCode != null)
		{
			GenericPromptController.Instance.ShowPromptByCode(blockReasonEffect.PromptCode, Array.Empty<object>());
		}
	}

	// Token: 0x040061A0 RID: 24992
	private const string FORBIDDEN_STAT_TIPS = "EditBattleTeamForbitState";

	// Token: 0x040061A1 RID: 24993
	private const string FORBIDDEN_IN_FIGHT_TIPS = "ForbiddenActionInFight";

	// Token: 0x040061A2 RID: 24994
	private const string PHANTOM_TEAM_TIPS = "PhantomFormationEnterFormationTip";

	// Token: 0x040061A3 RID: 24995
	private const string TRIAL_ROLE_LIMIT_PROMPT = "TrialRoleTeamLimit";

	// Token: 0x040061A4 RID: 24996
	private const int ELEVATOR_BUFF_ID = 90003001;

	// Token: 0x040061A5 RID: 24997
	public const int FORMATION_ID_NONE = 0;

	// Token: 0x040061A6 RID: 24998
	[StaticVariableRuleIgnore]
	private static readonly TRuleResult Pass = new TRuleResult
	{
		Pass = true
	};

	// Token: 0x040061A7 RID: 24999
	[StaticVariableRuleIgnore]
	public static readonly FormationRuleChain CanOpenFormationViewChain = new FormationRuleChain(new Func<TRuleResult>[]
	{
		new Func<TRuleResult>(FormationValidators.RuleFunctionOpen),
		new Func<TRuleResult>(FormationValidators.RuleNotLockByBehaviorTree),
		new Func<TRuleResult>(FormationValidators.RuleNotPhantomTeam),
		new Func<TRuleResult>(FormationValidators.RuleEntityValid),
		new Func<TRuleResult>(FormationValidators.RuleTeamNotDead),
		new Func<TRuleResult>(FormationValidators.RuleTagComponentExists),
		new Func<TRuleResult>(FormationValidators.RuleBuffComponentExists),
		new Func<TRuleResult>(FormationValidators.RuleNotOnVehicle),
		new Func<TRuleResult>(FormationValidators.RuleNotInRoleTrial),
		new Func<TRuleResult>(FormationValidators.RuleNotInWater),
		new Func<TRuleResult>(FormationValidators.RuleNotDrowning),
		new Func<TRuleResult>(FormationValidators.RuleNotInAir),
		new Func<TRuleResult>(FormationValidators.RuleNotInFight),
		new Func<TRuleResult>(FormationValidators.RuleNotClimbing),
		new Func<TRuleResult>(FormationValidators.RuleNotPhantomTransformedInAir),
		new Func<TRuleResult>(FormationValidators.RuleCanSwitchRole),
		new Func<TRuleResult>(FormationValidators.RuleNotInElevator),
		new Func<TRuleResult>(FormationValidators.RuleNotWalkingOnWater),
		new Func<TRuleResult>(FormationValidators.RuleInBattleGroup)
	});

	// Token: 0x040061A8 RID: 25000
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EOpenViewBlockReason, IBlockReasonEffect> BlockReasonEffects = new Dictionary<EOpenViewBlockReason, IBlockReasonEffect>
	{
		{
			EOpenViewBlockReason.FunctionNotOpen,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,未满足开启条件",
				LogOnly = true
			}
		},
		{
			EOpenViewBlockReason.LockByBehaviorTree,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,行为树锁定中",
				TipsId = "EditBattleTeamForbitState"
			}
		},
		{
			EOpenViewBlockReason.InPhantomTeam,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前编队为声骸编队,无法打开",
				TipsId = "PhantomFormationEnterFormationTip"
			}
		},
		{
			EOpenViewBlockReason.EntityInvalid,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前实体不存在",
				LogOnly = true
			}
		},
		{
			EOpenViewBlockReason.Dead,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前编队已死亡",
				LogOnly = true
			}
		},
		{
			EOpenViewBlockReason.TagComponentMissing,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前实体的 TagComponent 不存在",
				LogOnly = true
			}
		},
		{
			EOpenViewBlockReason.BuffComponentMissing,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前实体的 CharacterBuffComponent 不存在",
				LogOnly = true
			}
		},
		{
			EOpenViewBlockReason.OnVehicle,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前角色在载具上",
				TipsId = "EditBattleTeamForbitState"
			}
		},
		{
			EOpenViewBlockReason.InRoleTrial,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,有试用角色无法打开",
				TipsId = "EditBattleTeamForbitState",
				PromptCode = "TrialRoleTeamLimit"
			}
		},
		{
			EOpenViewBlockReason.InWater,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前角色正在水中",
				TipsId = "EditBattleTeamForbitState"
			}
		},
		{
			EOpenViewBlockReason.Drowning,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前角色正在播放溺水",
				TipsId = "EditBattleTeamForbitState"
			}
		},
		{
			EOpenViewBlockReason.InAir,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前角色处于空中",
				TipsId = "EditBattleTeamForbitState"
			}
		},
		{
			EOpenViewBlockReason.InFight,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前角色在战斗中",
				TipsId = "ForbiddenActionInFight"
			}
		},
		{
			EOpenViewBlockReason.Climbing,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前角色处于攀爬中",
				TipsId = "EditBattleTeamForbitState"
			}
		},
		{
			EOpenViewBlockReason.CannotSwitchRole,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前角色不能切人",
				TipsId = "EditBattleTeamForbitState"
			}
		},
		{
			EOpenViewBlockReason.PhantomTransformedInAir,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前角色为声骸变身状态且处于空中",
				TipsId = "EditBattleTeamForbitState"
			}
		},
		{
			EOpenViewBlockReason.InElevator,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前角色在电梯中",
				TipsId = "EditBattleTeamForbitState"
			}
		},
		{
			EOpenViewBlockReason.WalkingOnWater,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,当前角色在水面上行走",
				TipsId = "EditBattleTeamForbitState"
			}
		},
		{
			EOpenViewBlockReason.NotBattleGroup,
			new IBlockReasonEffect
			{
				LogMessage = "打开编队按钮时,在非战斗编队中无法打开",
				LogOnly = true
			}
		}
	};
}
