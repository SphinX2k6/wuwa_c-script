using System;
using System.Collections.Generic;

// Token: 0x020013E8 RID: 5096
public class HudUnitHandleManager
{
	// Token: 0x0600C9A9 RID: 51625 RVA: 0x003BF28C File Offset: 0x003BD48C
	public static void Init()
	{
		HudUnitManager.Instance.HudUnitHandleClassArray = new Type[]
		{
			typeof(LockCursorHandle),
			typeof(StrengthHandle),
			typeof(AimHandle),
			typeof(MonsterCursorHandle),
			typeof(ManipulateCursorHandle),
			typeof(ManipulateAimHandle),
			typeof(LockExecutionHandle),
			typeof(CameraAimHandle),
			typeof(LockPredictedHandle),
			typeof(RoleSideEnergyHandle),
			typeof(SlowTimeHandle)
		};
		HudUnitManager.Instance.HudUnitHandleClassMap = new Dictionary<EHudUnitType, Type>
		{
			{
				EHudUnitType.MigrationStrength,
				typeof(MigrationStrengthHandle)
			},
			{
				EHudUnitType.FollowShootAim,
				typeof(FollowShootAimHandle)
			},
			{
				EHudUnitType.FollowShootAutoAim,
				typeof(FollowShootAutoAimHandle)
			},
			{
				EHudUnitType.FollowShootOnlyAutoAim,
				typeof(FollowShootAutoAimHandle)
			},
			{
				EHudUnitType.FollowShootVisionCar,
				typeof(FollowShootAutoAimHandle)
			},
			{
				EHudUnitType.TreasureCompass,
				typeof(TreasureCompassHandle)
			},
			{
				EHudUnitType.FlyRaceStrength,
				typeof(FlyRaceStrengthHandle)
			},
			{
				EHudUnitType.LuPaAim,
				typeof(LuPaAimHandle)
			},
			{
				EHudUnitType.WeeklyRogue,
				typeof(WeeklyRogueHandle)
			},
			{
				EHudUnitType.TDFollowShootAim,
				typeof(TDFollowShootAimHandle)
			},
			{
				EHudUnitType.AiMiSiHud,
				typeof(AiMiSiHudHandle)
			},
			{
				EHudUnitType.FollowShootAutoAimNoRing,
				typeof(FollowShootAutoAimHandle)
			},
			{
				EHudUnitType.RoverlikeMonsterCursor,
				typeof(RoverlikeMonsterCursorHandle)
			}
		};
	}
}
