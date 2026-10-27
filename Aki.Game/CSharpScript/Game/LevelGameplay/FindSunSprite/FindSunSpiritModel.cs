using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.GamePlay.FindSunSpirit;
using CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite
{
	// Token: 0x02006E50 RID: 28240
	[NullableContext(2)]
	[Nullable(0)]
	[Model(0)]
	public class FindSunSpiritModel : ModelBase
	{
		// Token: 0x17009A35 RID: 39477
		// (get) Token: 0x06044D43 RID: 281923 RVA: 0x010FCFA2 File Offset: 0x010FB1A2
		[Nullable(1)]
		public static FindSunSpiritModel Instance
		{
			[NullableContext(1)]
			get
			{
				return FindSunSpiritModel._Instance;
			}
		}

		// Token: 0x06044D44 RID: 281924 RVA: 0x010FCFA9 File Offset: 0x010FB1A9
		[NullableContext(1)]
		public static FindSunSpiritModel GetOrCreateInstance()
		{
			if (FindSunSpiritModel._Instance == null)
			{
				FindSunSpiritModel.CreateInstance();
			}
			return FindSunSpiritModel._Instance;
		}

		// Token: 0x06044D45 RID: 281925 RVA: 0x010FCFBD File Offset: 0x010FB1BD
		public static bool CreateInstance()
		{
			if (FindSunSpiritModel._Instance != null)
			{
				return true;
			}
			FindSunSpiritModel._Instance = new FindSunSpiritModel();
			return true;
		}

		// Token: 0x06044D46 RID: 281926 RVA: 0x010FCFD3 File Offset: 0x010FB1D3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044D47 RID: 281927 RVA: 0x010FCFD5 File Offset: 0x010FB1D5
		public static void ResetStaticDefaultValue()
		{
			FindSunSpiritModel._Instance = null;
		}

		// Token: 0x06044D48 RID: 281928 RVA: 0x010FCFDD File Offset: 0x010FB1DD
		static FindSunSpiritModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FindSunSpiritModel.CreateStaticDefaultValue), new Action(FindSunSpiritModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023CF0 RID: 146672
		public AActor CurrentCameraActor;

		// Token: 0x04023CF1 RID: 146673
		public BP_FindSunSpiritGlobalConfig_C GlobalConfig;

		// Token: 0x04023CF2 RID: 146674
		public IFindSunSpirit Config;

		// Token: 0x04023CF3 RID: 146675
		public Vector LevelPosition;

		// Token: 0x04023CF4 RID: 146676
		public Rotator LevelRotator;

		// Token: 0x04023CF5 RID: 146677
		public Quat LevelQuat;

		// Token: 0x04023CF6 RID: 146678
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<FindSunSpiritEndTarget> LevelEndTargetList;

		// Token: 0x04023CF7 RID: 146679
		public int ResetTimes;

		// Token: 0x04023CF8 RID: 146680
		public int FailResetDelayTime;

		// Token: 0x04023CF9 RID: 146681
		public bool IsGameFinish;

		// Token: 0x04023CFA RID: 146682
		public bool GameFinishResult;

		// Token: 0x04023CFB RID: 146683
		public Action<bool> OnFindSunSpiritFinish;

		// Token: 0x04023CFC RID: 146684
		public IFindSunSpiritUploadInfo UploadInfo;

		// Token: 0x04023CFD RID: 146685
		public FindSunSpiritLevelConfig LevelConfig;

		// Token: 0x04023CFE RID: 146686
		public bool IsGameplayReady;

		// Token: 0x04023CFF RID: 146687
		public FindSunSpiritLevelPlay LevelPlay;

		// Token: 0x04023D00 RID: 146688
		public FindSunSpiritPerformManager PerformManager;

		// Token: 0x04023D01 RID: 146689
		public bool IsTriggerCooldown;

		// Token: 0x04023D02 RID: 146690
		public int TriggerCooldownTime;

		// Token: 0x04023D03 RID: 146691
		public TimerHandle TriggerCooldownTimer;

		// Token: 0x04023D04 RID: 146692
		private static FindSunSpiritModel _Instance;
	}
}
