using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.GamePlay.FindSunSpirit;
using CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite
{
	// Token: 0x02005FD1 RID: 24529
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class FindSunSpiritModel : ModelBase
	{
		// Token: 0x17006F4A RID: 28490
		// (get) Token: 0x0603AED0 RID: 241360 RVA: 0x010A7502 File Offset: 0x010A5702
		[Nullable(1)]
		public static FindSunSpiritModel Instance
		{
			[NullableContext(1)]
			get
			{
				return FindSunSpiritModel._Instance;
			}
		}

		// Token: 0x0603AED1 RID: 241361 RVA: 0x010A7509 File Offset: 0x010A5709
		[NullableContext(1)]
		public static FindSunSpiritModel GetOrCreateInstance()
		{
			if (FindSunSpiritModel._Instance == null)
			{
				FindSunSpiritModel.CreateInstance();
			}
			return FindSunSpiritModel._Instance;
		}

		// Token: 0x0603AED2 RID: 241362 RVA: 0x010A751D File Offset: 0x010A571D
		public static bool CreateInstance()
		{
			if (FindSunSpiritModel._Instance != null)
			{
				return true;
			}
			FindSunSpiritModel._Instance = new FindSunSpiritModel();
			return true;
		}

		// Token: 0x0603AED3 RID: 241363 RVA: 0x010A7533 File Offset: 0x010A5733
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603AED4 RID: 241364 RVA: 0x010A7535 File Offset: 0x010A5735
		public static void ResetStaticDefaultValue()
		{
			FindSunSpiritModel._Instance = null;
		}

		// Token: 0x0603AED5 RID: 241365 RVA: 0x010A753D File Offset: 0x010A573D
		static FindSunSpiritModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FindSunSpiritModel.CreateStaticDefaultValue), new Action(FindSunSpiritModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EFA5 RID: 126885
		public AActor CurrentCameraActor;

		// Token: 0x0401EFA6 RID: 126886
		public BP_FindSunSpiritGlobalConfig_C GlobalConfig;

		// Token: 0x0401EFA7 RID: 126887
		public IFindSunSpirit Config;

		// Token: 0x0401EFA8 RID: 126888
		public Vector LevelPosition;

		// Token: 0x0401EFA9 RID: 126889
		public Rotator LevelRotator;

		// Token: 0x0401EFAA RID: 126890
		public Quat LevelQuat;

		// Token: 0x0401EFAB RID: 126891
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<FindSunSpiritEndTarget> LevelEndTargetList;

		// Token: 0x0401EFAC RID: 126892
		public int ResetTimes;

		// Token: 0x0401EFAD RID: 126893
		public int FailResetDelayTime;

		// Token: 0x0401EFAE RID: 126894
		public bool IsGameFinish;

		// Token: 0x0401EFAF RID: 126895
		public bool GameFinishResult;

		// Token: 0x0401EFB0 RID: 126896
		public Action<bool> OnFindSunSpiritFinish;

		// Token: 0x0401EFB1 RID: 126897
		public IFindSunSpiritUploadInfo UploadInfo;

		// Token: 0x0401EFB2 RID: 126898
		public FindSunSpiritLevelConfig LevelConfig;

		// Token: 0x0401EFB3 RID: 126899
		public bool IsGameplayReady;

		// Token: 0x0401EFB4 RID: 126900
		public FindSunSpiritLevelPlay LevelPlay;

		// Token: 0x0401EFB5 RID: 126901
		public FindSunSpiritPerformManager PerformManager;

		// Token: 0x0401EFB6 RID: 126902
		public bool IsTriggerCooldown;

		// Token: 0x0401EFB7 RID: 126903
		public int TriggerCooldownTime;

		// Token: 0x0401EFB8 RID: 126904
		public TimerHandle TriggerCooldownTimer;

		// Token: 0x0401EFB9 RID: 126905
		private static FindSunSpiritModel _Instance;
	}
}
