using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.Common
{
	// Token: 0x020060A0 RID: 24736
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class LevelGamePlayConfig : ConfigBase
	{
		// Token: 0x0603B54D RID: 243021 RVA: 0x010CB918 File Offset: 0x010C9B18
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

		// Token: 0x0603B54E RID: 243022 RVA: 0x010CB9D9 File Offset: 0x010C9BD9
		protected override bool OnClear()
		{
			this.ScanInfoCache = null;
			return true;
		}

		// Token: 0x0603B54F RID: 243023 RVA: 0x010CB9E4 File Offset: 0x010C9BE4
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

		// Token: 0x17007048 RID: 28744
		// (get) Token: 0x0603B550 RID: 243024 RVA: 0x010CBA43 File Offset: 0x010C9C43
		public static LevelGamePlayConfig Instance
		{
			get
			{
				return LevelGamePlayConfig._Instance;
			}
		}

		// Token: 0x0603B551 RID: 243025 RVA: 0x010CBA4A File Offset: 0x010C9C4A
		public static LevelGamePlayConfig GetOrCreateInstance()
		{
			if (LevelGamePlayConfig._Instance == null)
			{
				LevelGamePlayConfig.CreateInstance();
			}
			return LevelGamePlayConfig._Instance;
		}

		// Token: 0x0603B552 RID: 243026 RVA: 0x010CBA5E File Offset: 0x010C9C5E
		public static bool CreateInstance()
		{
			if (LevelGamePlayConfig._Instance != null)
			{
				return true;
			}
			LevelGamePlayConfig._Instance = new LevelGamePlayConfig();
			return true;
		}

		// Token: 0x0603B553 RID: 243027 RVA: 0x010CBA74 File Offset: 0x010C9C74
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B554 RID: 243028 RVA: 0x010CBA76 File Offset: 0x010C9C76
		public static void ResetStaticDefaultValue()
		{
			LevelGamePlayConfig._Instance = null;
		}

		// Token: 0x0603B555 RID: 243029 RVA: 0x010CBA7E File Offset: 0x010C9C7E
		static LevelGamePlayConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LevelGamePlayConfig.CreateStaticDefaultValue), new Action(LevelGamePlayConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401F431 RID: 128049
		[Nullable(2)]
		private Dictionary<int, GamePlayScan> ScanInfoCache;

		// Token: 0x0401F432 RID: 128050
		public int ScanMaxDistance;

		// Token: 0x0401F433 RID: 128051
		public int ScanShowInteractionEffectMaxDistance;

		// Token: 0x0401F434 RID: 128052
		public int ScanDetectConcealedDistance;

		// Token: 0x0401F435 RID: 128053
		public int InteractInputCacheTime;

		// Token: 0x0401F436 RID: 128054
		public int GenExtraGuideEffectMaxDist;

		// Token: 0x0401F437 RID: 128055
		public int GenExtraGuideEffectMinDist;

		// Token: 0x0401F438 RID: 128056
		public int ExtraGuideEffectRaiseDist;

		// Token: 0x0401F439 RID: 128057
		[Nullable(2)]
		private static LevelGamePlayConfig _Instance;
	}
}
