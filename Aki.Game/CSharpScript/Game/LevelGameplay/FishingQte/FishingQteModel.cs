using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FB4 RID: 24500
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class FishingQteModel : ModelBase
	{
		// Token: 0x17006F3F RID: 28479
		// (get) Token: 0x0603ADD7 RID: 241111 RVA: 0x010A23AF File Offset: 0x010A05AF
		[Nullable(2)]
		public IFishingQteConfig GameConfig
		{
			[NullableContext(2)]
			get
			{
				return this.GameDbConfigProxy;
			}
		}

		// Token: 0x0603ADD8 RID: 241112 RVA: 0x010A23B8 File Offset: 0x010A05B8
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

		// Token: 0x0603ADD9 RID: 241113 RVA: 0x010A240C File Offset: 0x010A060C
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

		// Token: 0x0603ADDA RID: 241114 RVA: 0x010A24C8 File Offset: 0x010A06C8
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
			List<List<int>> invalidArea = this.GameConfig.InvalidArea;
			this.GameInfo.GetRingInfo().IsWholeRing = (invalidArea.Count == 0);
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

		// Token: 0x0603ADDB RID: 241115 RVA: 0x010A2600 File Offset: 0x010A0800
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

		// Token: 0x0603ADDC RID: 241116 RVA: 0x010A2758 File Offset: 0x010A0958
		private void InitialConfig()
		{
			this.GameDbConfig = FishingConfig.Instance.GetFishingQteConfig(this.CurrentGameplayId);
			if (this.GameDbConfig != null)
			{
				this.GameDbConfigProxy = new FishingQteConfigDbProxy(this.GameDbConfig.Value);
				return;
			}
			this.GameDbConfigProxy = null;
		}

		// Token: 0x0603ADDD RID: 241117 RVA: 0x010A27A8 File Offset: 0x010A09A8
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

		// Token: 0x17006F40 RID: 28480
		// (get) Token: 0x0603ADDE RID: 241118 RVA: 0x010A2820 File Offset: 0x010A0A20
		public float ScoreUp
		{
			get
			{
				return (float)this.GameConfig.ScoreUp * this.FishingQteAutoFactor;
			}
		}

		// Token: 0x17006F41 RID: 28481
		// (get) Token: 0x0603ADDF RID: 241119 RVA: 0x010A2835 File Offset: 0x010A0A35
		public float HitAreaScore
		{
			get
			{
				return (float)this.GameConfig.HitAreaScore * this.FishingQteOnFactor;
			}
		}

		// Token: 0x17006F42 RID: 28482
		// (get) Token: 0x0603ADE0 RID: 241120 RVA: 0x010A284A File Offset: 0x010A0A4A
		public float PerfectScore
		{
			get
			{
				return (float)this.GameConfig.PerfectScore * this.FishingQteOnFactor;
			}
		}

		// Token: 0x17006F43 RID: 28483
		// (get) Token: 0x0603ADE2 RID: 241122 RVA: 0x010A286E File Offset: 0x010A0A6E
		// (set) Token: 0x0603ADE1 RID: 241121 RVA: 0x010A285F File Offset: 0x010A0A5F
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

		// Token: 0x0603ADE3 RID: 241123 RVA: 0x010A2878 File Offset: 0x010A0A78
		public void OnQteOn()
		{
			this.GameInfo.CurrentScore += this.HitAreaScore;
			int accumulatePerfectCombo = this.AccumulatePerfectCombo;
			this.AccumulatePerfectCombo = accumulatePerfectCombo + 1;
		}

		// Token: 0x0603ADE4 RID: 241124 RVA: 0x010A28B0 File Offset: 0x010A0AB0
		public void OnPerfectOn()
		{
			this.GameInfo.CurrentScore += this.PerfectScore;
			int accumulatePerfectCombo = this.AccumulatePerfectCombo;
			this.AccumulatePerfectCombo = accumulatePerfectCombo + 1;
		}

		// Token: 0x0603ADE5 RID: 241125 RVA: 0x010A28E5 File Offset: 0x010A0AE5
		public void OnMissOn()
		{
			this.GameInfo.CurrentScore = Math.Max(0f, this.GameInfo.CurrentScore - (float)this.GameConfig.MistakeScore);
			this.AccumulatePerfectCombo = 0;
		}

		// Token: 0x0603ADE6 RID: 241126 RVA: 0x010A291C File Offset: 0x010A0B1C
		private void RefreshAccumulatePerfectCombo()
		{
			int accumulatePerfectCombo = this.AccumulatePerfectCombo;
			this.GameInfo.CursorSpeed = (float)this.RefreshInfoByKey(accumulatePerfectCombo, this.GameConfig.CursorSpeed);
			this.GameInfo.RingSpeed = (float)this.RefreshInfoByKey(accumulatePerfectCombo, this.GameConfig.RouletteRotateSpeed);
			this.GameInfo.PerfectAppearRate = (float)this.RefreshInfoByKey(accumulatePerfectCombo, this.GameConfig.PerfectAppearRate);
		}

		// Token: 0x0603ADE7 RID: 241127 RVA: 0x010A298C File Offset: 0x010A0B8C
		private int RefreshInfoByKey(int currentKey, Dictionary<int, int> keyValueMap)
		{
			List<KeyValuePair<int, int>> list = new List<KeyValuePair<int, int>>(keyValueMap);
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

		// Token: 0x0603ADE8 RID: 241128 RVA: 0x010A2A00 File Offset: 0x010A0C00
		public void SetTempGetDataListFromServer(IEnumerable<FishingItemInfo> dataList, EFishingQteGetItemTagType tagType)
		{
			foreach (FishingItemInfo fishingItemInfo in dataList)
			{
				DockyardItemBlockOriginalData dockyardItemBlockOriginalData = new DockyardItemBlockOriginalData(fishingItemInfo);
				this.TempGetDataMap[fishingItemInfo.IncrId] = dockyardItemBlockOriginalData;
				this.TempGetDataTagMap[fishingItemInfo.IncrId] = tagType;
				this.TempGetDataList.Add(dockyardItemBlockOriginalData);
			}
		}

		// Token: 0x0603ADE9 RID: 241129 RVA: 0x010A2A78 File Offset: 0x010A0C78
		public List<DockyardItemBlockOriginalData> GetTempGetDataList()
		{
			List<DockyardItemBlockOriginalData> result = new List<DockyardItemBlockOriginalData>(this.TempGetDataMap.Values);
			this.TempGetDataMap.Clear();
			this.TempGetDataTagMap.Clear();
			this.TempGetDataList.Clear();
			return result;
		}

		// Token: 0x0603ADEA RID: 241130 RVA: 0x010A2AAB File Offset: 0x010A0CAB
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

		// Token: 0x0603ADEB RID: 241131 RVA: 0x010A2AD4 File Offset: 0x010A0CD4
		public bool IsTempGetDataEmpty()
		{
			return this.TempGetDataList.Count == 0;
		}

		// Token: 0x0603ADEC RID: 241132 RVA: 0x010A2AE4 File Offset: 0x010A0CE4
		public EFishingQteGetItemTagType GetTempGetDataTag(int incId)
		{
			EFishingQteGetItemTagType result;
			if (this.TempGetDataTagMap.TryGetValue(incId, out result))
			{
				return result;
			}
			return EFishingQteGetItemTagType.None;
		}

		// Token: 0x17006F44 RID: 28484
		// (get) Token: 0x0603ADED RID: 241133 RVA: 0x010A2B04 File Offset: 0x010A0D04
		public static FishingQteModel Instance
		{
			get
			{
				return FishingQteModel._Instance;
			}
		}

		// Token: 0x0603ADEE RID: 241134 RVA: 0x010A2B0B File Offset: 0x010A0D0B
		public static FishingQteModel GetOrCreateInstance()
		{
			if (FishingQteModel._Instance == null)
			{
				FishingQteModel.CreateInstance();
			}
			return FishingQteModel._Instance;
		}

		// Token: 0x0603ADEF RID: 241135 RVA: 0x010A2B1F File Offset: 0x010A0D1F
		public static bool CreateInstance()
		{
			if (FishingQteModel._Instance != null)
			{
				return true;
			}
			FishingQteModel._Instance = new FishingQteModel();
			return true;
		}

		// Token: 0x0603ADF0 RID: 241136 RVA: 0x010A2B35 File Offset: 0x010A0D35
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603ADF1 RID: 241137 RVA: 0x010A2B37 File Offset: 0x010A0D37
		public static void ResetStaticDefaultValue()
		{
			FishingQteModel._Instance = null;
		}

		// Token: 0x0603ADF2 RID: 241138 RVA: 0x010A2B3F File Offset: 0x010A0D3F
		static FishingQteModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FishingQteModel.CreateStaticDefaultValue), new Action(FishingQteModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401EF1C RID: 126748
		private const float PERCENT_CONVERT = 0.01f;

		// Token: 0x0401EF1D RID: 126749
		private int CurrentGameplayId;

		// Token: 0x0401EF1E RID: 126750
		public int CurrentFishingPointConfigId;

		// Token: 0x0401EF1F RID: 126751
		public long CurrentFishingPointCreatureDataId;

		// Token: 0x0401EF20 RID: 126752
		public EFishingPointType CurrentInteractType;

		// Token: 0x0401EF21 RID: 126753
		public FishingQteGameInfo GameInfo;

		// Token: 0x0401EF22 RID: 126754
		private FishingQteConfig? GameDbConfig;

		// Token: 0x0401EF23 RID: 126755
		[Nullable(2)]
		private FishingQteConfigDbProxy GameDbConfigProxy;

		// Token: 0x0401EF24 RID: 126756
		[Nullable(2)]
		private IFishingQteConfig GameJsonConfig;

		// Token: 0x0401EF25 RID: 126757
		public EFishingIconType CurrentFishingIconType;

		// Token: 0x0401EF26 RID: 126758
		private float FishingQteOnFactor = 1f;

		// Token: 0x0401EF27 RID: 126759
		private float FishingQteAutoFactor = 1f;

		// Token: 0x0401EF28 RID: 126760
		private int AccumulatePerfectComboInternal;

		// Token: 0x0401EF29 RID: 126761
		private Dictionary<int, DockyardItemBlockOriginalData> TempGetDataMap = new Dictionary<int, DockyardItemBlockOriginalData>();

		// Token: 0x0401EF2A RID: 126762
		private Dictionary<int, EFishingQteGetItemTagType> TempGetDataTagMap = new Dictionary<int, EFishingQteGetItemTagType>();

		// Token: 0x0401EF2B RID: 126763
		private List<DockyardItemBlockOriginalData> TempGetDataList = new List<DockyardItemBlockOriginalData>();

		// Token: 0x0401EF2C RID: 126764
		[Nullable(2)]
		private static FishingQteModel _Instance;
	}
}
