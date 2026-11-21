using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll
{
	// Token: 0x020060D2 RID: 24786
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class BigStuffedDollModel : ModelBase
	{
		// Token: 0x1700709B RID: 28827
		// (get) Token: 0x0603B6D3 RID: 243411 RVA: 0x010D05A0 File Offset: 0x010CE7A0
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
				if (this.GameDbConfig == null)
				{
					return default(OneOf<BrokenRockConfig, BrokenRockConfig>);
				}
				return this.GameDbConfig.Value;
			}
		}

		// Token: 0x0603B6D4 RID: 243412 RVA: 0x010D05D4 File Offset: 0x010CE7D4
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

		// Token: 0x0603B6D5 RID: 243413 RVA: 0x010D0688 File Offset: 0x010CE888
		public void InitialConfig()
		{
			this.GameDbConfig = ConfigBrokenRockConfigById.GetConfig(this.CurrentGameplayId, true);
		}

		// Token: 0x0603B6D6 RID: 243414 RVA: 0x010D06A8 File Offset: 0x010CE8A8
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

		// Token: 0x0603B6D7 RID: 243415 RVA: 0x010D0714 File Offset: 0x010CE914
		public int GetCurrentGameplayId()
		{
			return this.CurrentGameplayId;
		}

		// Token: 0x0603B6D8 RID: 243416 RVA: 0x010D071C File Offset: 0x010CE91C
		public void SetGameStage(EGameStage stage)
		{
			this.LastGameStage = this.GameStage;
			this.GameStage = stage;
			EventSystem.Instance.Emit<EGameStage>(EEventName.OnBigStuffedDollGameStageUpdate, this.GameStage);
		}

		// Token: 0x0603B6D9 RID: 243417 RVA: 0x010D0747 File Offset: 0x010CE947
		public EGameStage GetGameStage()
		{
			return this.GameStage;
		}

		// Token: 0x0603B6DA RID: 243418 RVA: 0x010D0750 File Offset: 0x010CE950
		public void EnterNextGameStage()
		{
			this.LastGameStage = this.GameStage;
			EventSystem instance = EventSystem.Instance;
			EEventName name = EEventName.OnBigStuffedDollGameStageUpdate;
			EGameStage egameStage = this.GameStage + 1;
			this.GameStage = egameStage;
			instance.Emit<EGameStage>(name, egameStage);
		}

		// Token: 0x0603B6DB RID: 243419 RVA: 0x010D078C File Offset: 0x010CE98C
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

		// Token: 0x0603B6DC RID: 243420 RVA: 0x010D0874 File Offset: 0x010CEA74
		public int GetGlobalTime()
		{
			if (this.GameDbConfig == null)
			{
				return 0;
			}
			return this.GameDbConfig.GetValueOrDefault().GlobalTime;
		}

		// Token: 0x0603B6DD RID: 243421 RVA: 0x010D08A0 File Offset: 0x010CEAA0
		public int GetScoreDown()
		{
			if (this.GameDbConfig == null)
			{
				return 0;
			}
			return this.GameDbConfig.GetValueOrDefault().ScoreDown;
		}

		// Token: 0x0603B6DE RID: 243422 RVA: 0x010D08CC File Offset: 0x010CEACC
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public OneOf<BrokenRockRing, BrokenRockRingConfig> GetRingConfig(int ringId)
		{
			BrokenRockRing? config = ConfigBrokenRockRingById.GetConfig(ringId, true);
			if (config == null)
			{
				return default(OneOf<BrokenRockRing, BrokenRockRingConfig>);
			}
			return config.Value;
		}

		// Token: 0x0603B6DF RID: 243423 RVA: 0x010D0900 File Offset: 0x010CEB00
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

		// Token: 0x0603B6E0 RID: 243424 RVA: 0x010D0A00 File Offset: 0x010CEC00
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

		// Token: 0x1700709C RID: 28828
		// (get) Token: 0x0603B6E1 RID: 243425 RVA: 0x010D0A38 File Offset: 0x010CEC38
		public static BigStuffedDollModel Instance
		{
			get
			{
				return BigStuffedDollModel._Instance;
			}
		}

		// Token: 0x0603B6E2 RID: 243426 RVA: 0x010D0A3F File Offset: 0x010CEC3F
		public static BigStuffedDollModel GetOrCreateInstance()
		{
			if (BigStuffedDollModel._Instance == null)
			{
				BigStuffedDollModel.CreateInstance();
			}
			return BigStuffedDollModel._Instance;
		}

		// Token: 0x0603B6E3 RID: 243427 RVA: 0x010D0A53 File Offset: 0x010CEC53
		public static bool CreateInstance()
		{
			if (BigStuffedDollModel._Instance != null)
			{
				return true;
			}
			BigStuffedDollModel._Instance = new BigStuffedDollModel();
			return true;
		}

		// Token: 0x0603B6E4 RID: 243428 RVA: 0x010D0A69 File Offset: 0x010CEC69
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603B6E5 RID: 243429 RVA: 0x010D0A6B File Offset: 0x010CEC6B
		public static void ResetStaticDefaultValue()
		{
			BigStuffedDollModel._Instance = null;
		}

		// Token: 0x0603B6E6 RID: 243430 RVA: 0x010D0A73 File Offset: 0x010CEC73
		static BigStuffedDollModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(BigStuffedDollModel.CreateStaticDefaultValue), new Action(BigStuffedDollModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401F526 RID: 128294
		private int CurrentGameplayId;

		// Token: 0x0401F527 RID: 128295
		public int BehaviorTreeConfigId;

		// Token: 0x0401F528 RID: 128296
		public int BrokenRockEntityPbDataId;

		// Token: 0x0401F529 RID: 128297
		public long BrokenRockEntityCreatureDataId;

		// Token: 0x0401F52A RID: 128298
		private BrokenRockConfig? GameDbConfig;

		// Token: 0x0401F52B RID: 128299
		[Nullable(2)]
		private BrokenRockConfig GameJsonConfig;

		// Token: 0x0401F52C RID: 128300
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, BrokenRockRingConfig> GameJsonRingConfig;

		// Token: 0x0401F52D RID: 128301
		public readonly BigStuffedGameInfo GameInfo = new BigStuffedGameInfo();

		// Token: 0x0401F52E RID: 128302
		private EGameStage GameStage;

		// Token: 0x0401F52F RID: 128303
		public bool GameResult;

		// Token: 0x0401F530 RID: 128304
		public float CurrentScore;

		// Token: 0x0401F531 RID: 128305
		public EArrowDirection CurrentArrowDirection;

		// Token: 0x0401F532 RID: 128306
		public EGameStage LastGameStage;

		// Token: 0x0401F533 RID: 128307
		[Nullable(2)]
		private static BigStuffedDollModel _Instance;
	}
}
