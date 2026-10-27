using System;
using System.Collections.Generic;

// Token: 0x02001F26 RID: 7974
public class HudUnitHandleManager
{
	// Token: 0x0600F58A RID: 62858 RVA: 0x003B37A0 File Offset: 0x003B19A0
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
