using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.Common
{
	// Token: 0x02006F1F RID: 28447
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class LevelGamePlayConfig : ConfigBase
	{
		// Token: 0x0604539F RID: 283551 RVA: 0x0112196C File Offset: 0x0111FB6C
		protected override bool OnInit()
		{
			this.ScanInfoCache = new Dictionary<int, GamePlayScan>();
			this.ScanMaxDistance = ConfigCommonParamById.GetIntConfig("scan_max_distance").GetValueOrDefault();
			this.ScanShowInteractionEffectMaxDistance = ConfigCommonParamById.GetIntConfig("scan_interaction_effect_max_distance").GetValueOrDefault();
			this.ScanDetectConcealedDistance = ConfigCommonParamById.GetIntConfig("scan_detect_concealed_distance").GetValueOrDefault();
			this.InteractInputCacheTime = ConfigCommonParamById.GetIntConfig("interact_input_cache_time").GetValueOrDefault();
			this.GenExtraGuideEffectMaxDist = ConfigCommonParamById.GetIntConfig("MaxNavigateToGuideEffectDist").GetValueOrDefault();
			this.GenExtraGuideEffectMinDist = ConfigCommonParamById.GetIntConfig("MinNavigateToGuideEffectDist").GetValueOrDefault();
			this.ExtraGuideEffectRaiseDist = ConfigCommonParamById.GetIntConfig("GuideEffectRaiseDist").GetValueOrDefault();
			return true;
		}

		// Token: 0x060453A0 RID: 283552 RVA: 0x01121A2D File Offset: 0x0111FC2D
		protected override bool OnClear()
		{
			this.ScanInfoCache = null;
			return true;
		}

		// Token: 0x060453A1 RID: 283553 RVA: 0x01121A38 File Offset: 0x0111FC38
		public GamePlayScan? GetScanInfoById(int id)
		{
			GamePlayScan value = default(GamePlayScan);
			Dictionary<int, GamePlayScan> scanInfoCache = this.ScanInfoCache;
			if (scanInfoCache != null && scanInfoCache.TryGetValue(id, out value))
			{
				return new GamePlayScan?(value);
			}
			GamePlayScan? config = ConfigGamePlayScanByUid.GetConfig(id, true);
			if (config != null)
			{
				value = config.Value;
				this.ScanInfoCache[id] = value;
			}
			return new GamePlayScan?(value);
		}

		// Token: 0x17009B09 RID: 39689
		// (get) Token: 0x060453A2 RID: 283554 RVA: 0x01121A97 File Offset: 0x0111FC97
		public static LevelGamePlayConfig Instance
		{
			get
			{
				return LevelGamePlayConfig._Instance;
			}
		}

		// Token: 0x060453A3 RID: 283555 RVA: 0x01121A9E File Offset: 0x0111FC9E
		public static LevelGamePlayConfig GetOrCreateInstance()
		{
			if (LevelGamePlayConfig._Instance == null)
			{
				LevelGamePlayConfig.CreateInstance();
			}
			return LevelGamePlayConfig._Instance;
		}

		// Token: 0x060453A4 RID: 283556 RVA: 0x01121AB2 File Offset: 0x0111FCB2
		public static bool CreateInstance()
		{
			if (LevelGamePlayConfig._Instance != null)
			{
				return true;
			}
			LevelGamePlayConfig._Instance = new LevelGamePlayConfig();
			return true;
		}

		// Token: 0x060453A5 RID: 283557 RVA: 0x01121AC8 File Offset: 0x0111FCC8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060453A6 RID: 283558 RVA: 0x01121ACA File Offset: 0x0111FCCA
		public static void ResetStaticDefaultValue()
		{
			LevelGamePlayConfig._Instance = null;
		}

		// Token: 0x060453A7 RID: 283559 RVA: 0x01121AD2 File Offset: 0x0111FCD2
		static LevelGamePlayConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelGamePlayConfig.CreateStaticDefaultValue), new Action(LevelGamePlayConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0402417C RID: 147836
		[Nullable(2)]
		private Dictionary<int, GamePlayScan> ScanInfoCache;

		// Token: 0x0402417D RID: 147837
		public int ScanMaxDistance;

		// Token: 0x0402417E RID: 147838
		public int ScanShowInteractionEffectMaxDistance;

		// Token: 0x0402417F RID: 147839
		public int ScanDetectConcealedDistance;

		// Token: 0x04024180 RID: 147840
		public int InteractInputCacheTime;

		// Token: 0x04024181 RID: 147841
		public int GenExtraGuideEffectMaxDist;

		// Token: 0x04024182 RID: 147842
		public int GenExtraGuideEffectMinDist;

		// Token: 0x04024183 RID: 147843
		public int ExtraGuideEffectRaiseDist;

		// Token: 0x04024184 RID: 147844
		[Nullable(2)]
		private static LevelGamePlayConfig _Instance;
	}
}
