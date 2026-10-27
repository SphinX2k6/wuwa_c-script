using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

// Token: 0x020031BA RID: 12730
[NullableContext(1)]
[Nullable(0)]
public static class GrapplingHookPointDefine
{
	// Token: 0x0400D729 RID: 55081
	public const int HOOK_VISION_ID = 1001;

	// Token: 0x0400D72A RID: 55082
	public const int HOOK_MAX_SPEED = 3500;

	// Token: 0x0400D72B RID: 55083
	[StaticVariableRuleIgnore]
	public static readonly HashSet<int> UpdateTargetSkillIds = new HashSet<int>
	{
		1208713,
		100020,
		100021,
		100022,
		200004,
		50170004,
		501700042,
		501700043,
		501700044,
		501700045,
		50170001,
		501700011,
		50180004,
		210130,
		100024,
		200006,
		5021005,
		5021008,
		5021009,
		210032,
		210033,
		210034,
		210041,
		800006,
		210044,
		5054010,
		5045008,
		210063
	};

	// Token: 0x0400D72C RID: 55084
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EHookPointState, int> HookPointStateToTagMap = new Dictionary<EHookPointState, int>
	{
		{
			EHookPointState.Normal,
			GameplayTagDefine.EGameplayTagId["关卡.定点钩锁.常态"]
		},
		{
			EHookPointState.Interactive,
			GameplayTagDefine.EGameplayTagId["关卡.定点钩锁.可交互"]
		},
		{
			EHookPointState.NonInteractive,
			GameplayTagDefine.EGameplayTagId["关卡.定点钩锁.不可交互"]
		},
		{
			EHookPointState.Interacting,
			GameplayTagDefine.EGameplayTagId["关卡.定点钩锁.交互中"]
		}
	};

	// Token: 0x0400D72D RID: 55085
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EHookInteractType, int> NormalHookTagMap = new Dictionary<EHookInteractType, int>
	{
		{
			EHookInteractType.FixedPointHook,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.定点钩索可用"]
		},
		{
			EHookInteractType.SuiGuangHook,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.岁光钩索可用"]
		},
		{
			EHookInteractType.FlyingFeather,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.飞雷神可用"]
		},
		{
			EHookInteractType.KiteHook,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.风筝钩索可用"]
		},
		{
			EHookInteractType.RagDollJumpingPoint,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大布偶.跳跃可用"]
		},
		{
			EHookInteractType.RagDollClimbingPoint,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.大布偶.攀爬可用"]
		},
		{
			EHookInteractType.MovementPointHook,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.移动钩锁可用"]
		},
		{
			EHookInteractType.SlashHook,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.古英雄铠.变身可用标识"]
		},
		{
			EHookInteractType.ChargeSlashHook,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.古英雄铠.变身可用标识"]
		},
		{
			EHookInteractType.GravityHook,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.重力钩锁.可用"]
		},
		{
			EHookInteractType.PilotThrow,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.铁驭投掷.可用"]
		},
		{
			EHookInteractType.CableWay,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.索道.可用"]
		},
		{
			EHookInteractType.MotorPullInteract,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.定点钩索可用"]
		},
		{
			EHookInteractType.SunSpiritLauncher,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.日灵交互启动器.可用"]
		},
		{
			EHookInteractType.SpaceStationEnergyCore,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.空间站能量核心.可用"]
		},
		{
			EHookInteractType.MotorEject,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.摩托弹射机关可用"]
		},
		{
			EHookInteractType.FoxJumpingPoint,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.小狐狸.跳跃可用"]
		},
		{
			EHookInteractType.WaterBoxBigWeapon,
			GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.水匣大武器可用"]
		}
	};

	// Token: 0x0400D72E RID: 55086
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EHookInteractType, int[]> MultipurposeHookTagMap = new Dictionary<EHookInteractType, int[]>
	{
		{
			EHookInteractType.FixedPointHook,
			new int[]
			{
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.定点钩索可用"],
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.摩托车.定点钩锁.可用"]
			}
		},
		{
			EHookInteractType.CableWay,
			new int[]
			{
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.索道.可用"],
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.摩托车.索道.可用"]
			}
		},
		{
			EHookInteractType.PilotThrow,
			new int[]
			{
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.铁驭投掷.可用"],
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.摩托车.铁驭投掷.可用"]
			}
		},
		{
			EHookInteractType.MotorPullInteract,
			new int[]
			{
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.定点钩索可用"],
				GameplayTagDefine.EGameplayTagId["角色.Common.技能通用标识.摩托车.拉取采集物.可用"]
			}
		}
	};

	// Token: 0x0400D72F RID: 55087
	[StaticVariableRuleIgnore]
	public static readonly HashSet<EHookInteractType> MotorcycleDetectableHookType = new HashSet<EHookInteractType>
	{
		EHookInteractType.CableWay,
		EHookInteractType.PilotThrow,
		EHookInteractType.MotorPullInteract,
		EHookInteractType.FollowerShoot
	};

	// Token: 0x0400D730 RID: 55088
	[Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<EHookInteractType, Func<HookLockPoint, bool>> MotorcycleDetectableHookCondition = new Dictionary<EHookInteractType, Func<HookLockPoint, bool>>
	{
		{
			EHookInteractType.KiteHook,
			delegate(HookLockPoint config)
			{
				if (config == null)
				{
					return false;
				}
				IMotorHookConfig motorHookConfig = config.MotorHookConfig;
				return ((motorHookConfig != null) ? motorHookConfig.AutoExit : null).GetValueOrDefault();
			}
		}
	};
}
