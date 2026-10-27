using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol.Summon;
using CSharpScript.Game.Module.GenericPrompt;

// Token: 0x02001BC1 RID: 7105
[NullableContext(1)]
[Nullable(0)]
public static class FormationValidators
{
	// Token: 0x0600D3BF RID: 54207 RVA: 0x0030B168 File Offset: 0x00309368
	private static TRuleResult Fail(EOpenViewBlockReason reason)
	{
		return new TRuleResult
		{
			Pass = false,
			Reason = reason
		};
	}

	// Token: 0x0600D3C0 RID: 54208 RVA: 0x0030B17D File Offset: 0x0030937D
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

	// Token: 0x0600D3C1 RID: 54209 RVA: 0x0030B1AD File Offset: 0x003093AD
	private static TRuleResult RuleFunctionOpen()
	{
		if (!FunctionModel.Instance.IsOpen(EFunctionType.FormatTeam))
		{
			return FormationValidators.Fail(EOpenViewBlockReason.FunctionNotOpen);
		}
		return FormationValidators.Pass;
	}

	// Token: 0x0600D3C2 RID: 54210 RVA: 0x0030B1CC File Offset: 0x003093CC
	private static TRuleResult RuleNotLockByBehaviorTree()
	{
		if (!FunctionModel.Instance.IsLockByBehaviorTree(10007))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.LockByBehaviorTree);
	}

	// Token: 0x0600D3C3 RID: 54211 RVA: 0x0030B1EB File Offset: 0x003093EB
	private static TRuleResult RuleNotPhantomTeam()
	{
		if (!SceneTeamModel.Instance.IsPhantomTeam)
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InPhantomTeam);
	}

	// Token: 0x0600D3C4 RID: 54212 RVA: 0x0030B205 File Offset: 0x00309405
	private static TRuleResult RuleEntityValid()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null || !getCurrentEntity.Valid)
		{
			return FormationValidators.Fail(EOpenViewBlockReason.EntityInvalid);
		}
		return FormationValidators.Pass;
	}

	// Token: 0x0600D3C5 RID: 54213 RVA: 0x0030B22C File Offset: 0x0030942C
	private static TRuleResult RuleTeamNotDead()
	{
		int playerId = CreatureModel.Instance.GetPlayerId();
		if (SceneTeamModel.Instance.GetCurrentGroupLivingState(playerId) != ETeamLivingState.Dead)
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.Dead);
	}

	// Token: 0x0600D3C6 RID: 54214 RVA: 0x0030B25E File Offset: 0x0030945E
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

	// Token: 0x0600D3C7 RID: 54215 RVA: 0x0030B29C File Offset: 0x0030949C
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

	// Token: 0x0600D3C8 RID: 54216 RVA: 0x0030B2DA File Offset: 0x003094DA
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

	// Token: 0x0600D3C9 RID: 54217 RVA: 0x0030B318 File Offset: 0x00309518
	private static TRuleResult RuleNotInRoleTrial()
	{
		if (!RoleController.Instance.IsInRoleTrial())
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InRoleTrial);
	}

	// Token: 0x0600D3CA RID: 54218 RVA: 0x0030B333 File Offset: 0x00309533
	private static TRuleResult RuleNotInWater()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.水中"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InWater);
	}

	// Token: 0x0600D3CB RID: 54219 RVA: 0x0030B358 File Offset: 0x00309558
	private static TRuleResult RuleNotDrowning()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.溺水"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.Drowning);
	}

	// Token: 0x0600D3CC RID: 54220 RVA: 0x0030B37D File Offset: 0x0030957D
	private static TRuleResult RuleNotInAir()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.空中"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InAir);
	}

	// Token: 0x0600D3CD RID: 54221 RVA: 0x0030B3A2 File Offset: 0x003095A2
	private static TRuleResult RuleNotInFight()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.进入战斗"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.InFight);
	}

	// Token: 0x0600D3CE RID: 54222 RVA: 0x0030B3C7 File Offset: 0x003095C7
	private static TRuleResult RuleNotClimbing()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.位置状态.攀爬"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.Climbing);
	}

	// Token: 0x0600D3CF RID: 54223 RVA: 0x0030B3EC File Offset: 0x003095EC
	private static TRuleResult RuleCanSwitchRole()
	{
		if (!FormationValidators.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.BUFF通用标识.不能切人"]))
		{
			return FormationValidators.Pass;
		}
		return FormationValidators.Fail(EOpenViewBlockReason.CannotSwitchRole);
	}

	// Token: 0x0600D3D0 RID: 54224 RVA: 0x0030B414 File Offset: 0x00309614
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

	// Token: 0x0600D3D1 RID: 54225 RVA: 0x0030B4A8 File Offset: 0x003096A8
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

	// Token: 0x0600D3D2 RID: 54226 RVA: 0x0030B4FC File Offset: 0x003096FC
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

	// Token: 0x0600D3D3 RID: 54227 RVA: 0x0030B545 File Offset: 0x00309745
	private static TRuleResult RuleInBattleGroup()
	{
		if (SceneTeamModel.Instance.CurrentGroupType.GetValueOrDefault() != ETeamGroupType.Battle)
		{
			return FormationValidators.Fail(EOpenViewBlockReason.NotBattleGroup);
		}
		return FormationValidators.Pass;
	}

	// Token: 0x0600D3D4 RID: 54228 RVA: 0x0030B568 File Offset: 0x00309768
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

	// Token: 0x040060D1 RID: 24785
	private const string FORBIDDEN_STAT_TIPS = "EditBattleTeamForbitState";

	// Token: 0x040060D2 RID: 24786
	private const string FORBIDDEN_IN_FIGHT_TIPS = "ForbiddenActionInFight";

	// Token: 0x040060D3 RID: 24787
	private const string PHANTOM_TEAM_TIPS = "PhantomFormationEnterFormationTip";

	// Token: 0x040060D4 RID: 24788
	private const string TRIAL_ROLE_LIMIT_PROMPT = "TrialRoleTeamLimit";

	// Token: 0x040060D5 RID: 24789
	private const int ELEVATOR_BUFF_ID = 90003001;

	// Token: 0x040060D6 RID: 24790
	public const int FORMATION_ID_NONE = 0;

	// Token: 0x040060D7 RID: 24791
	[StaticVariableRuleIgnore]
	private static readonly TRuleResult Pass = new TRuleResult
	{
		Pass = true
	};

	// Token: 0x040060D8 RID: 24792
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

	// Token: 0x040060D9 RID: 24793
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
