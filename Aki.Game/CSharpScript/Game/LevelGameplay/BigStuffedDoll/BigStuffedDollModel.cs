using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x02006F51 RID: 28497
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class BigStuffedDollModel : ModelBase
	{
		// Token: 0x17009B5C RID: 39772
		// (get) Token: 0x06045525 RID: 283941 RVA: 0x011265F4 File Offset: 0x011247F4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public OneOf<BrokenRockConfig, BrokenRockConfig> Config
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				if (!PublicUtil.Instance.UseDbConfig())
				{
					if (this.GameJsonConfig == null)
					{
						return default(OneOf<BrokenRockConfig, BrokenRockConfig>);
					}
					return this.GameJsonConfig;
				}
				else
				{
					if (this.GameDbConfig == null)
					{
						return default(OneOf<BrokenRockConfig, BrokenRockConfig>);
					}
					return this.GameDbConfig.Value;
				}
			}
		}

		// Token: 0x06045526 RID: 283942 RVA: 0x01126654 File Offset: 0x01124854
		public void GameplayStart(int id, int treeConfigId)
		{
			this.CurrentGameplayId = id;
			this.BehaviorTreeConfigId = treeConfigId;
			this.SetGameStage(EGameStage.None);
			this.GameInfo.Clear();
			this.CurrentScore = 0f;
			this.CurrentArrowDirection = EArrowDirection.Clockwise;
			this.InitialConfig();
			if (!this.Config.HasValue)
			{
				return;
			}
			string[] array;
			if (this.Config.IsT1)
			{
				array = this.Config.AsT1.EntityUid.Split('_', StringSplitOptions.None);
			}
			else
			{
				array = this.Config.AsT2.EntityUid.Split('_', StringSplitOptions.None);
			}
			int.TryParse(array[2], out this.BrokenRockEntityPbDataId);
		}

		// Token: 0x06045527 RID: 283943 RVA: 0x01126708 File Offset: 0x01124908
		public void InitialConfig()
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				this.GameDbConfig = ConfigBrokenRockConfigById.GetConfig(this.CurrentGameplayId, true);
				return;
			}
			string text = "../Config/Raw/Tables/k.可视化编辑/__Temp__/Json/BrokenRockConfig.json";
			if (string.IsNullOrEmpty(text))
			{
				Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.YSQ, "大个布偶坚固岩石玩法找不到Json数据配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			string configPath = PublicUtil.Instance.GetConfigPath(text);
			string text2 = "";
			UKuroStaticLibrary.LoadFileToString(ref text2, configPath);
			BrokenRockJsonConfig brokenRockJsonConfig = Json.Decode<BrokenRockJsonConfig>(text2, null);
			if (brokenRockJsonConfig != null)
			{
				this.GameJsonConfig = null;
				foreach (BrokenRockConfig brokenRockConfig in brokenRockJsonConfig.Config)
				{
					if (brokenRockConfig.Id == this.CurrentGameplayId)
					{
						this.GameJsonConfig = brokenRockConfig;
						break;
					}
				}
				if (this.GameJsonConfig != null)
				{
					this.GameJsonRingConfig = new Dictionary<int, BrokenRockRingConfig>();
					foreach (int num in this.GameJsonConfig.Rings)
					{
						BrokenRockRingConfig brokenRockRingConfig = null;
						foreach (BrokenRockRingConfig brokenRockRingConfig2 in brokenRockJsonConfig.Rings)
						{
							if (brokenRockRingConfig2.Id == num)
							{
								brokenRockRingConfig = brokenRockRingConfig2;
								break;
							}
						}
						if (brokenRockRingConfig != null)
						{
							this.GameJsonRingConfig[num] = brokenRockRingConfig;
						}
					}
				}
			}
		}

		// Token: 0x06045528 RID: 283944 RVA: 0x01126850 File Offset: 0x01124A50
		private Dictionary<int, int> StringToMapValue(string stringValue)
		{
			string[] array = stringValue.Replace("[", "").Replace("]", "").Split(',', StringSplitOptions.None);
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string[] array3 = array2[i].Split(':', StringSplitOptions.None);
				dictionary[int.Parse(array3[0])] = int.Parse(array3[1]);
			}
			return dictionary;
		}

		// Token: 0x06045529 RID: 283945 RVA: 0x011268BC File Offset: 0x01124ABC
		public int GetCurrentGameplayId()
		{
			return this.CurrentGameplayId;
		}

		// Token: 0x0604552A RID: 283946 RVA: 0x011268C4 File Offset: 0x01124AC4
		public void SetGameStage(EGameStage stage)
		{
			this.LastGameStage = this.GameStage;
			this.GameStage = stage;
			EventSystem.Instance.Emit<EGameStage>(EEventName.OnBigStuffedDollGameStageUpdate, this.GameStage);
		}

		// Token: 0x0604552B RID: 283947 RVA: 0x011268EF File Offset: 0x01124AEF
		public EGameStage GetGameStage()
		{
			return this.GameStage;
		}

		// Token: 0x0604552C RID: 283948 RVA: 0x011268F8 File Offset: 0x01124AF8
		public void EnterNextGameStage()
		{
			this.LastGameStage = this.GameStage;
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnBigStuffedDollGameStageUpdate;
			EGameStage egameStage = this.GameStage + 1;
			this.GameStage = egameStage;
			instance.Emit<EGameStage>(name, egameStage);
		}

		// Token: 0x0604552D RID: 283949 RVA: 0x01126934 File Offset: 0x01124B34
		public void ArrowEnterNextValidArea()
		{
			int validAreaNum = this.GameInfo.GetValidAreaNum();
			if (validAreaNum == 0)
			{
				return;
			}
			int currentArrowStayTotalIndex = this.GameInfo.CurrentArrowStayTotalIndex;
			EArrowDirection currentArrowDirection = this.CurrentArrowDirection;
			if (currentArrowDirection != EArrowDirection.Clockwise)
			{
				if (currentArrowDirection == EArrowDirection.Anticlockwise)
				{
					this.GameInfo.CurrentArrowStayTotalIndex--;
				}
			}
			else
			{
				this.GameInfo.CurrentArrowStayTotalIndex++;
			}
			if (this.GameInfo.CurrentArrowStayTotalIndex > validAreaNum - 1)
			{
				this.GameInfo.CurrentArrowStayTotalIndex = 0;
			}
			else if (this.GameInfo.CurrentArrowStayTotalIndex < 0)
			{
				this.GameInfo.CurrentArrowStayTotalIndex = validAreaNum - 1;
			}
			if (currentArrowStayTotalIndex == this.GameInfo.CurrentArrowStayTotalIndex)
			{
				return;
			}
			int currentArrowStayRingId = this.GameInfo.CurrentArrowStayRingId;
			this.GameInfo.UpdateCurrentArrowStayInfo();
			EventSystem.Instance.Emit<int, int, int>(EEventName.OnBigStuffedDollArrowStayAreaUpdate, currentArrowStayRingId, this.GameInfo.CurrentArrowStayRingId, this.GameInfo.CurrentArrowStayRelativeValidAreaIndex);
		}

		// Token: 0x0604552E RID: 283950 RVA: 0x01126A1C File Offset: 0x01124C1C
		public int GetGlobalTime()
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				if (this.GameDbConfig == null)
				{
					return 0;
				}
				return this.GameDbConfig.GetValueOrDefault().GlobalTime;
			}
			else
			{
				BrokenRockConfig gameJsonConfig = this.GameJsonConfig;
				if (gameJsonConfig == null)
				{
					return 0;
				}
				return gameJsonConfig.GlobalTime;
			}
		}

		// Token: 0x0604552F RID: 283951 RVA: 0x01126A68 File Offset: 0x01124C68
		public int GetScoreDown()
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				if (this.GameDbConfig == null)
				{
					return 0;
				}
				return this.GameDbConfig.GetValueOrDefault().ScoreDown;
			}
			else
			{
				BrokenRockConfig gameJsonConfig = this.GameJsonConfig;
				if (gameJsonConfig == null)
				{
					return 0;
				}
				return gameJsonConfig.ScoreDown;
			}
		}

		// Token: 0x06045530 RID: 283952 RVA: 0x01126AB4 File Offset: 0x01124CB4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public OneOf<BrokenRockRing, BrokenRockRingConfig> GetRingConfig(int ringId)
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				BrokenRockRing? config = ConfigBrokenRockRingById.GetConfig(ringId, true);
				if (config == null)
				{
					return default(OneOf<BrokenRockRing, BrokenRockRingConfig>);
				}
				return config.Value;
			}
			else
			{
				BrokenRockRingConfig value;
				if (this.GameJsonRingConfig != null && this.GameJsonRingConfig.TryGetValue(ringId, out value))
				{
					return value;
				}
				return default(OneOf<BrokenRockRing, BrokenRockRingConfig>);
			}
		}

		// Token: 0x06045531 RID: 283953 RVA: 0x01126B20 File Offset: 0x01124D20
		public int GetArrowSpeed([Nullable(new byte[]
		{
			0,
			1
		})] OneOf<BrokenRockRing, BrokenRockRingConfig>? ringConfig)
		{
			int result = 0;
			if (ringConfig == null)
			{
				return result;
			}
			float currentScore = this.CurrentScore;
			if (ringConfig.Value.IsT1)
			{
				BrokenRockRing asT = ringConfig.Value.AsT1;
				for (int i = 0; i < asT.SpeedLength; i++)
				{
					DicIntInt? dicIntInt = asT.Speed(i);
					int key = dicIntInt.Value.Key;
					int value = dicIntInt.Value.Value;
					if (currentScore < (float)key)
					{
						break;
					}
					result = value;
				}
			}
			else
			{
				foreach (KeyValuePair<int, int> keyValuePair in ringConfig.Value.AsT2.Speed)
				{
					int key2 = keyValuePair.Key;
					int value2 = keyValuePair.Value;
					if (currentScore < (float)key2)
					{
						break;
					}
					result = value2;
				}
			}
			return result;
		}

		// Token: 0x06045532 RID: 283954 RVA: 0x01126C20 File Offset: 0x01124E20
		public void ArrowDirectionReverse()
		{
			EArrowDirection currentArrowDirection = this.CurrentArrowDirection;
			if (currentArrowDirection != EArrowDirection.Clockwise)
			{
				if (currentArrowDirection == EArrowDirection.Anticlockwise)
				{
					this.CurrentArrowDirection = EArrowDirection.Clockwise;
				}
			}
			else
			{
				this.CurrentArrowDirection = EArrowDirection.Anticlockwise;
			}
			this.GameInfo.OnArrowDirectionReverse();
		}

		// Token: 0x17009B5D RID: 39773
		// (get) Token: 0x06045533 RID: 283955 RVA: 0x01126C58 File Offset: 0x01124E58
		public static BigStuffedDollModel Instance
		{
			get
			{
				return BigStuffedDollModel._Instance;
			}
		}

		// Token: 0x06045534 RID: 283956 RVA: 0x01126C5F File Offset: 0x01124E5F
		public static BigStuffedDollModel GetOrCreateInstance()
		{
			if (BigStuffedDollModel._Instance == null)
			{
				BigStuffedDollModel.CreateInstance();
			}
			return BigStuffedDollModel._Instance;
		}

		// Token: 0x06045535 RID: 283957 RVA: 0x01126C73 File Offset: 0x01124E73
		public static bool CreateInstance()
		{
			if (BigStuffedDollModel._Instance != null)
			{
				return true;
			}
			BigStuffedDollModel._Instance = new BigStuffedDollModel();
			return true;
		}

		// Token: 0x06045536 RID: 283958 RVA: 0x01126C89 File Offset: 0x01124E89
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045537 RID: 283959 RVA: 0x01126C8B File Offset: 0x01124E8B
		public static void ResetStaticDefaultValue()
		{
			BigStuffedDollModel._Instance = null;
		}

		// Token: 0x06045538 RID: 283960 RVA: 0x01126C93 File Offset: 0x01124E93
		static BigStuffedDollModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BigStuffedDollModel.CreateStaticDefaultValue), new Action(BigStuffedDollModel.ResetStaticDefaultValue));
		}

		// Token: 0x04024271 RID: 148081
		private int CurrentGameplayId;

		// Token: 0x04024272 RID: 148082
		public int BehaviorTreeConfigId;

		// Token: 0x04024273 RID: 148083
		public int BrokenRockEntityPbDataId;

		// Token: 0x04024274 RID: 148084
		public long BrokenRockEntityCreatureDataId;

		// Token: 0x04024275 RID: 148085
		private BrokenRockConfig? GameDbConfig;

		// Token: 0x04024276 RID: 148086
		[Nullable(2)]
		private BrokenRockConfig GameJsonConfig;

		// Token: 0x04024277 RID: 148087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, BrokenRockRingConfig> GameJsonRingConfig;

		// Token: 0x04024278 RID: 148088
		public readonly BigStuffedGameInfo GameInfo = new BigStuffedGameInfo();

		// Token: 0x04024279 RID: 148089
		private EGameStage GameStage;

		// Token: 0x0402427A RID: 148090
		public bool GameResult;

		// Token: 0x0402427B RID: 148091
		public float CurrentScore;

		// Token: 0x0402427C RID: 148092
		public EArrowDirection CurrentArrowDirection;

		// Token: 0x0402427D RID: 148093
		public EGameStage LastGameStage;

		// Token: 0x0402427E RID: 148094
		[Nullable(2)]
		private static BigStuffedDollModel _Instance;
	}
}
