using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02006E33 RID: 28211
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class FishingQteModel : ModelBase
	{
		// Token: 0x17009A2A RID: 39466
		// (get) Token: 0x06044C49 RID: 281673 RVA: 0x010F7CDB File Offset: 0x010F5EDB
		[Nullable(2)]
		public IFishingQteConfig GameConfig
		{
			[NullableContext(2)]
			get
			{
				if (PublicUtil.Instance.UseDbConfig())
				{
					return this.GameDbConfigProxy;
				}
				return this.GameJsonConfig;
			}
		}

		// Token: 0x06044C4A RID: 281674 RVA: 0x010F7CF8 File Offset: 0x010F5EF8
		[NullableContext(0)]
		public UniTask<bool> GameplayStart(int pbEntityId, long creatureDataId)
		{
			FishingQteModel.<GameplayStart>d__15 <GameplayStart>d__;
			<GameplayStart>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<GameplayStart>d__.<>4__this = this;
			<GameplayStart>d__.pbEntityId = pbEntityId;
			<GameplayStart>d__.creatureDataId = creatureDataId;
			<GameplayStart>d__.<>1__state = -1;
			<GameplayStart>d__.<>t__builder.Start<FishingQteModel.<GameplayStart>d__15>(ref <GameplayStart>d__);
			return <GameplayStart>d__.<>t__builder.Task;
		}

		// Token: 0x06044C4B RID: 281675 RVA: 0x010F7D4C File Offset: 0x010F5F4C
		public bool GameplayStartByTempFishPoint(long creatureDataId)
		{
			TempFishingPointData tempFishingPointDataByCreatureDataId = FishingModel.Instance.GetTempFishingPointDataByCreatureDataId(creatureDataId);
			if (tempFishingPointDataByCreatureDataId == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.YYZ;
				string message = "[FishingQte] 无法查到对应临时捕捞点信息";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("CreatureDataId", creatureDataId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			if (tempFishingPointDataByCreatureDataId.CurrentCount == 0)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.LevelPlay;
				ELogAuthor author2 = ELogAuthor.YYZ;
				string message2 = "[FishingQte] 交互点可捕捞次数不足";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("临时捕捞点实体Id", tempFishingPointDataByCreatureDataId.CreatureDataId);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return false;
			}
			this.CurrentFishingPointCreatureDataId = creatureDataId;
			this.CurrentFishingPointConfigId = 0;
			this.CurrentGameplayId = tempFishingPointDataByCreatureDataId.GamePlayId;
			this.CurrentInteractType = EFishingPointType.Temp;
			this.CurrentFishingIconType = EFishingIconType.Fish;
			return this.InitialGameInfo(tempFishingPointDataByCreatureDataId.CurrentCount);
		}

		// Token: 0x06044C4C RID: 281676 RVA: 0x010F7E08 File Offset: 0x010F6008
		private unsafe bool InitialGameInfo(int maxRound)
		{
			this.InitTechEffect();
			this.InitialConfig();
			if (this.GameInfo == null)
			{
				this.GameInfo = new FishingQteGameInfo();
			}
			this.GameInfo.Clear();
			EArrowDirection arrowDirection = this.GameConfig.IsAnticlockwise ? EArrowDirection.Anticlockwise : EArrowDirection.Clockwise;
			this.GameInfo.CreateRingInfo(arrowDirection);
			this.GameInfo.MaxRound = maxRound;
			IntArray[] invalidArea = this.GameConfig.InvalidArea;
			this.GameInfo.GetRingInfo().IsWholeRing = (invalidArea.Length == 0);
			this.AccumulatePerfectCombo = 0;
			this.TempGetDataMap.Clear();
			this.TempGetDataTagMap.Clear();
			this.TempGetDataList.Clear();
			Log instance = Log.Instance;
			ELogModule module = ELogModule.LevelPlay;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "[FishingQte] 捕鱼玩法开始";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LevelGameplayId", this.CurrentGameplayId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FishingPointId", this.CurrentFishingPointConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("cIncId", this.CurrentFishingPointCreatureDataId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return true;
		}

		// Token: 0x06044C4D RID: 281677 RVA: 0x010F7F3C File Offset: 0x010F613C
		private void InitTechEffect()
		{
			this.FishingQteAutoFactor = 1f;
			this.FishingQteOnFactor = 1f;
			Dictionary<int, HashSet<int>> effectType2TechIdsMap = FishingModel.Instance.EffectType2TechIdsMap;
			HashSet<int> hashSet;
			if (effectType2TechIdsMap.TryGetValue(11, out hashSet))
			{
				foreach (int techId in hashSet)
				{
					if (FishingModel.Instance.GetFishingTechUnlock(techId))
					{
						int techEffectId = FishingConfig.Instance.GetFishingTechById(techId).Effect(0);
						FishingTechEffect fishingTechEffectById = FishingConfig.Instance.GetFishingTechEffectById(techEffectId);
						this.FishingQteAutoFactor += (float)fishingTechEffectById.Params(0) * 0.01f;
					}
				}
			}
			HashSet<int> hashSet2;
			if (effectType2TechIdsMap.TryGetValue(10, out hashSet2))
			{
				foreach (int techId2 in hashSet2)
				{
					if (FishingModel.Instance.GetFishingTechUnlock(techId2))
					{
						int techEffectId2 = FishingConfig.Instance.GetFishingTechById(techId2).Effect(0);
						FishingTechEffect fishingTechEffectById2 = FishingConfig.Instance.GetFishingTechEffectById(techEffectId2);
						this.FishingQteOnFactor += (float)fishingTechEffectById2.Params(0) * 0.01f;
					}
				}
			}
		}

		// Token: 0x06044C4E RID: 281678 RVA: 0x010F8094 File Offset: 0x010F6294
		private void InitialConfig()
		{
			if (PublicUtil.Instance.UseDbConfig())
			{
				this.GameDbConfig = FishingConfig.Instance.GetFishingQteConfig(this.CurrentGameplayId);
				if (this.GameDbConfig != null)
				{
					this.GameDbConfigProxy = new FishingQteConfigDbProxy(this.GameDbConfig.Value);
					return;
				}
				this.GameDbConfigProxy = null;
				return;
			}
			else
			{
				string text = "../Config/Raw/Tables/k.可视化编辑/__Temp__/Json/FishingRouletteConfig.json";
				if (text == null)
				{
					Log.Instance.Error(ELogModule.LevelPlay, ELogAuthor.YYZ, "[FishingQte] 捕鱼转盘玩法找不到Json数据配置", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				string configPath = PublicUtil.Instance.GetConfigPath(text);
				string text2 = "";
				UKuroStaticLibrary.LoadFileToString(ref text2, configPath);
				List<IFishingQteConfig> list = Json.Decode<List<IFishingQteConfig>>(text2, null);
				if (list != null)
				{
					IFishingQteConfig fishingQteConfig = list.Find((IFishingQteConfig value) => value.Id == this.CurrentGameplayId);
					this.GameJsonConfig = fishingQteConfig;
					this.GameJsonConfig.CursorSpeed = this.StringToListValue(fishingQteConfig.CursorSpeed.Cast<object>().ToString());
					this.GameJsonConfig.RouletteRotateSpeed = this.StringToListValue(fishingQteConfig.RouletteRotateSpeed.Cast<object>().ToString());
					this.GameJsonConfig.PerfectAppearRate = this.StringToListValue(fishingQteConfig.PerfectAppearRate.Cast<object>().ToString());
				}
				return;
			}
		}

		// Token: 0x06044C4F RID: 281679 RVA: 0x010F81C4 File Offset: 0x010F63C4
		private Dictionary<int, int> StringToListValue(string stringValue)
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

		// Token: 0x06044C50 RID: 281680 RVA: 0x010F8230 File Offset: 0x010F6430
		public void EnterNextRound()
		{
			this.GameInfo.CurrentRound = Math.Min(this.GameInfo.CurrentRound + 1, this.GameInfo.MaxRound);
			if (this.GameInfo.CurrentRound != this.GameInfo.MaxRound)
			{
				this.GameInfo.CurrentScore -= (float)this.GameConfig.MaxScore;
				return;
			}
			this.GameInfo.SetGameStage(EFishingQteStage.End);
		}

		// Token: 0x17009A2B RID: 39467
		// (get) Token: 0x06044C51 RID: 281681 RVA: 0x010F82A8 File Offset: 0x010F64A8
		public float ScoreUp
		{
			get
			{
				return (float)this.GameConfig.ScoreUp * this.FishingQteAutoFactor;
			}
		}

		// Token: 0x17009A2C RID: 39468
		// (get) Token: 0x06044C52 RID: 281682 RVA: 0x010F82BD File Offset: 0x010F64BD
		public float HitAreaScore
		{
			get
			{
				return (float)this.GameConfig.HitAreaScore * this.FishingQteOnFactor;
			}
		}

		// Token: 0x17009A2D RID: 39469
		// (get) Token: 0x06044C53 RID: 281683 RVA: 0x010F82D2 File Offset: 0x010F64D2
		public float PerfectScore
		{
			get
			{
				return (float)this.GameConfig.PerfectScore * this.FishingQteOnFactor;
			}
		}

		// Token: 0x17009A2E RID: 39470
		// (get) Token: 0x06044C55 RID: 281685 RVA: 0x010F82F6 File Offset: 0x010F64F6
		// (set) Token: 0x06044C54 RID: 281684 RVA: 0x010F82E7 File Offset: 0x010F64E7
		private int AccumulatePerfectCombo
		{
			get
			{
				return this.AccumulatePerfectComboInternal;
			}
			set
			{
				this.AccumulatePerfectComboInternal = value;
				this.RefreshAccumulatePerfectCombo();
			}
		}

		// Token: 0x06044C56 RID: 281686 RVA: 0x010F8300 File Offset: 0x010F6500
		public void OnQteOn()
		{
			this.GameInfo.CurrentScore += this.HitAreaScore;
			int accumulatePerfectCombo = this.AccumulatePerfectCombo;
			this.AccumulatePerfectCombo = accumulatePerfectCombo + 1;
		}

		// Token: 0x06044C57 RID: 281687 RVA: 0x010F8338 File Offset: 0x010F6538
		public void OnPerfectOn()
		{
			this.GameInfo.CurrentScore += this.PerfectScore;
			int accumulatePerfectCombo = this.AccumulatePerfectCombo;
			this.AccumulatePerfectCombo = accumulatePerfectCombo + 1;
		}

		// Token: 0x06044C58 RID: 281688 RVA: 0x010F836D File Offset: 0x010F656D
		public void OnMissOn()
		{
			this.GameInfo.CurrentScore = Math.Max(0f, this.GameInfo.CurrentScore - (float)this.GameConfig.MistakeScore);
			this.AccumulatePerfectCombo = 0;
		}

		// Token: 0x06044C59 RID: 281689 RVA: 0x010F83A4 File Offset: 0x010F65A4
		private void RefreshAccumulatePerfectCombo()
		{
			int accumulatePerfectCombo = this.AccumulatePerfectCombo;
			this.GameInfo.CursorSpeed = (float)this.RefreshInfoByKey(accumulatePerfectCombo, this.GameConfig.CursorSpeed);
			this.GameInfo.RingSpeed = (float)this.RefreshInfoByKey(accumulatePerfectCombo, this.GameConfig.RouletteRotateSpeed);
			this.GameInfo.PerfectAppearRate = (float)this.RefreshInfoByKey(accumulatePerfectCombo, this.GameConfig.PerfectAppearRate);
		}

		// Token: 0x06044C5A RID: 281690 RVA: 0x010F8414 File Offset: 0x010F6614
		private int RefreshInfoByKey(int currentKey, Dictionary<int, int> keyValueMap)
		{
			List<KeyValuePair<int, int>> list = keyValueMap.ToList<KeyValuePair<int, int>>();
			for (int i = 0; i < list.Count; i++)
			{
				int key = list[i].Key;
				int value = list[i].Value;
				if (i >= list.Count - 1)
				{
					return value;
				}
				int key2 = list[i + 1].Key;
				if (key <= currentKey && currentKey < key2)
				{
					return value;
				}
			}
			return 0;
		}

		// Token: 0x06044C5B RID: 281691 RVA: 0x010F8488 File Offset: 0x010F6688
		public void SetTempGetDataListFromServer(List<FishingItemInfo> dataList, EFishingQteGetItemTagType tagType)
		{
			foreach (FishingItemInfo fishingItemInfo in dataList)
			{
				DockyardItemBlockOriginalData dockyardItemBlockOriginalData = new DockyardItemBlockOriginalData(fishingItemInfo);
				this.TempGetDataMap[fishingItemInfo.IncrId] = dockyardItemBlockOriginalData;
				this.TempGetDataTagMap[fishingItemInfo.IncrId] = tagType;
				this.TempGetDataList.Add(dockyardItemBlockOriginalData);
			}
		}

		// Token: 0x06044C5C RID: 281692 RVA: 0x010F8508 File Offset: 0x010F6708
		public List<DockyardItemBlockOriginalData> GetTempGetDataList()
		{
			List<DockyardItemBlockOriginalData> result = this.TempGetDataMap.Values.ToList<DockyardItemBlockOriginalData>();
			this.TempGetDataMap.Clear();
			this.TempGetDataTagMap.Clear();
			this.TempGetDataList.Clear();
			return result;
		}

		// Token: 0x06044C5D RID: 281693 RVA: 0x010F853B File Offset: 0x010F673B
		[NullableContext(2)]
		public DockyardItemBlockOriginalData ShiftTempGetData()
		{
			if (this.TempGetDataList.Count == 0)
			{
				return null;
			}
			DockyardItemBlockOriginalData result = this.TempGetDataList[0];
			this.TempGetDataList.RemoveAt(0);
			return result;
		}

		// Token: 0x06044C5E RID: 281694 RVA: 0x010F8564 File Offset: 0x010F6764
		public bool IsTempGetDataEmpty()
		{
			return this.TempGetDataList.Count == 0;
		}

		// Token: 0x06044C5F RID: 281695 RVA: 0x010F8574 File Offset: 0x010F6774
		public EFishingQteGetItemTagType GetTempGetDataTag(int incId)
		{
			EFishingQteGetItemTagType result;
			if (this.TempGetDataTagMap.TryGetValue(incId, out result))
			{
				return result;
			}
			return EFishingQteGetItemTagType.None;
		}

		// Token: 0x17009A2F RID: 39471
		// (get) Token: 0x06044C60 RID: 281696 RVA: 0x010F8594 File Offset: 0x010F6794
		public static FishingQteModel Instance
		{
			get
			{
				return FishingQteModel._Instance;
			}
		}

		// Token: 0x06044C61 RID: 281697 RVA: 0x010F859B File Offset: 0x010F679B
		public static FishingQteModel GetOrCreateInstance()
		{
			if (FishingQteModel._Instance == null)
			{
				FishingQteModel.CreateInstance();
			}
			return FishingQteModel._Instance;
		}

		// Token: 0x06044C62 RID: 281698 RVA: 0x010F85AF File Offset: 0x010F67AF
		public static bool CreateInstance()
		{
			if (FishingQteModel._Instance != null)
			{
				return true;
			}
			FishingQteModel._Instance = new FishingQteModel();
			return true;
		}

		// Token: 0x06044C63 RID: 281699 RVA: 0x010F85C5 File Offset: 0x010F67C5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044C64 RID: 281700 RVA: 0x010F85C7 File Offset: 0x010F67C7
		public static void ResetStaticDefaultValue()
		{
			FishingQteModel._Instance = null;
		}

		// Token: 0x06044C65 RID: 281701 RVA: 0x010F85CF File Offset: 0x010F67CF
		static FishingQteModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FishingQteModel.CreateStaticDefaultValue), new Action(FishingQteModel.ResetStaticDefaultValue));
		}

		// Token: 0x04023C67 RID: 146535
		private const float PERCENT_CONVERT = 0.01f;

		// Token: 0x04023C68 RID: 146536
		private int CurrentGameplayId;

		// Token: 0x04023C69 RID: 146537
		public int CurrentFishingPointConfigId;

		// Token: 0x04023C6A RID: 146538
		public long CurrentFishingPointCreatureDataId;

		// Token: 0x04023C6B RID: 146539
		public EFishingPointType CurrentInteractType;

		// Token: 0x04023C6C RID: 146540
		public FishingQteGameInfo GameInfo;

		// Token: 0x04023C6D RID: 146541
		private FishingQteConfig? GameDbConfig;

		// Token: 0x04023C6E RID: 146542
		[Nullable(2)]
		private FishingQteConfigDbProxy GameDbConfigProxy;

		// Token: 0x04023C6F RID: 146543
		[Nullable(2)]
		private IFishingQteConfig GameJsonConfig;

		// Token: 0x04023C70 RID: 146544
		public EFishingIconType CurrentFishingIconType;

		// Token: 0x04023C71 RID: 146545
		private float FishingQteOnFactor = 1f;

		// Token: 0x04023C72 RID: 146546
		private float FishingQteAutoFactor = 1f;

		// Token: 0x04023C73 RID: 146547
		private int AccumulatePerfectComboInternal;

		// Token: 0x04023C74 RID: 146548
		private Dictionary<int, DockyardItemBlockOriginalData> TempGetDataMap = new Dictionary<int, DockyardItemBlockOriginalData>();

		// Token: 0x04023C75 RID: 146549
		private Dictionary<int, EFishingQteGetItemTagType> TempGetDataTagMap = new Dictionary<int, EFishingQteGetItemTagType>();

		// Token: 0x04023C76 RID: 146550
		private List<DockyardItemBlockOriginalData> TempGetDataList = new List<DockyardItemBlockOriginalData>();

		// Token: 0x04023C77 RID: 146551
		[Nullable(2)]
		private static FishingQteModel _Instance;
	}
}
