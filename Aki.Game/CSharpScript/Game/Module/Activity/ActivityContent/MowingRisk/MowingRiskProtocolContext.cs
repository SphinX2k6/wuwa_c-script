using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x02005325 RID: 21285
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskProtocolContext : ActivityBaseData, IMowingRiskContextDisposable
	{
		// Token: 0x06034FBE RID: 217022 RVA: 0x00ED1B84 File Offset: 0x00ECFD84
		protected override void OnInit(ActivityData data)
		{
			MowingRiskModel.Instance.InitContext();
		}

		// Token: 0x06034FBF RID: 217023 RVA: 0x00ED1B90 File Offset: 0x00ECFD90
		public void Dispose()
		{
		}

		// Token: 0x06034FC0 RID: 217024 RVA: 0x00ED1B94 File Offset: 0x00ECFD94
		protected override void PhraseEx(ActivityData data)
		{
			RiskHarvestActivityInfo riskHarvestActivityInfo = data.RiskHarvestActivityInfo;
			if (riskHarvestActivityInfo != null)
			{
				this.ParseActivityInfo(riskHarvestActivityInfo);
			}
		}

		// Token: 0x06034FC1 RID: 217025 RVA: 0x00ED1BB4 File Offset: 0x00ECFDB4
		public override bool GetExDataRedPointShowState()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			return instance.HasAnyReward || instance.IsNewInstanceOpen;
		}

		// Token: 0x06034FC2 RID: 217026 RVA: 0x00ED1BD7 File Offset: 0x00ECFDD7
		public void ParseRiskHarvestEndNotify(RiskHarvestEndNotify msg)
		{
		}

		// Token: 0x06034FC3 RID: 217027 RVA: 0x00ED1BD9 File Offset: 0x00ECFDD9
		public void ParseRiskHarvestInstUpdateNotify(RiskHarvestInstUpdateNotify msg)
		{
			this.ParseInstInfosIncremental(msg.InstInfos);
		}

		// Token: 0x06034FC4 RID: 217028 RVA: 0x00ED1BE7 File Offset: 0x00ECFDE7
		public void ParseRiskHarvestArtifactNotify(RiskHarvestArtifactNotify msg)
		{
			this.ParseArtifactInfo(msg.ArtifactInfo);
		}

		// Token: 0x06034FC5 RID: 217029 RVA: 0x00ED1BF5 File Offset: 0x00ECFDF5
		public void ParseRiskHarvestBuffUpdateNotify(RiskHarvestBuffUpdateNotify msg)
		{
			this.ParseArtifactInfo(msg.ArtifactInfo);
		}

		// Token: 0x06034FC6 RID: 217030 RVA: 0x00ED1C03 File Offset: 0x00ECFE03
		public void ParseRiskHarvestBuffUnlockNotify(RiskHarvestBuffUnlockNotify msg)
		{
			this.ParseUnlockBuffGroup(msg.UnlockBuffGroup);
		}

		// Token: 0x06034FC7 RID: 217031 RVA: 0x00ED1C14 File Offset: 0x00ECFE14
		public void ParseRiskHarvestActivityUpdateNotify(RiskHarvestActivityUpdateNotify msg)
		{
			RiskHarvestActivityInfo activityInfo = msg.ActivityInfo;
			if (activityInfo == null)
			{
				return;
			}
			this.ParseActivityInfo(activityInfo);
		}

		// Token: 0x06034FC8 RID: 217032 RVA: 0x00ED1C34 File Offset: 0x00ECFE34
		private void ParseInstInfosIncremental(IReadOnlyList<RiskHarvestInstInfo> data)
		{
			foreach (RiskHarvestInstInfo riskHarvestInstInfo in data)
			{
				RiskHarvestInstInfo riskHarvestInstInfo2;
				if (this.InstanceInfoCache.TryGetValue(riskHarvestInstInfo.Id, out riskHarvestInstInfo2))
				{
					this.TotalScoreCache -= riskHarvestInstInfo2.Score;
				}
				this.InstanceInfoCache[riskHarvestInstInfo.Id] = riskHarvestInstInfo;
				this.TotalScoreCache += riskHarvestInstInfo.Score;
			}
		}

		// Token: 0x06034FC9 RID: 217033 RVA: 0x00ED1CC4 File Offset: 0x00ECFEC4
		private void ParseInstInfosAll(IReadOnlyList<RiskHarvestInstInfo> data)
		{
			this.TotalScoreCache = 0;
			foreach (RiskHarvestInstInfo riskHarvestInstInfo in data)
			{
				this.InstanceInfoCache[riskHarvestInstInfo.Id] = riskHarvestInstInfo;
				this.TotalScoreCache += riskHarvestInstInfo.Score;
			}
		}

		// Token: 0x06034FCA RID: 217034 RVA: 0x00ED1D34 File Offset: 0x00ECFF34
		private void ParseRewardedScores(IReadOnlyList<int> data)
		{
			this.RewardedScoreCache.Clear();
			foreach (int item in data)
			{
				this.RewardedScoreCache.Add(item);
			}
		}

		// Token: 0x06034FCB RID: 217035 RVA: 0x00ED1D90 File Offset: 0x00ECFF90
		private void ParseUnlockBuffGroup(IReadOnlyList<int> data)
		{
			foreach (int item in data)
			{
				this.UnlockBuffCache.Add(item);
			}
		}

		// Token: 0x06034FCC RID: 217036 RVA: 0x00ED1DE0 File Offset: 0x00ECFFE0
		[NullableContext(2)]
		private void ParseArtifactInfo(RiskHarvestInstArtifactInfo data)
		{
			if (data == null)
			{
				return;
			}
			this.ArtifactInfoCache = data;
			this.BasicBuffInfoInBattleCache.Clear();
			foreach (RiskHarvestInstBuffInfo riskHarvestInstBuffInfo in data.Buffs)
			{
				this.BasicBuffInfoInBattleCache[riskHarvestInstBuffInfo.Id] = riskHarvestInstBuffInfo.Count;
			}
		}

		// Token: 0x06034FCD RID: 217037 RVA: 0x00ED1E54 File Offset: 0x00ED0054
		private void ParseActivityInfo(RiskHarvestActivityInfo data)
		{
			this.ParseInstInfosAll(data.InstInfos);
			this.ParseRewardedScores(data.RewardedScores);
			this.ParseUnlockBuffGroup(data.UnlockBuffGroups);
		}

		// Token: 0x170066D1 RID: 26321
		// (get) Token: 0x06034FCE RID: 217038 RVA: 0x00ED1E7A File Offset: 0x00ED007A
		public Dictionary<int, RiskHarvestInstInfo> InstanceInfo
		{
			get
			{
				return this.InstanceInfoCache;
			}
		}

		// Token: 0x170066D2 RID: 26322
		// (get) Token: 0x06034FCF RID: 217039 RVA: 0x00ED1E84 File Offset: 0x00ED0084
		[Nullable(2)]
		public RiskHarvestInstArtifactInfo ArtifactInfo
		{
			[NullableContext(2)]
			get
			{
				if (this.ArtifactInfoCache == null)
				{
					Log.Instance.Error(ELogModule.MowingRisk, ELogAuthor.WZ, "尚未获得割草局内buff数据", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
				return this.ArtifactInfoCache;
			}
		}

		// Token: 0x170066D3 RID: 26323
		// (get) Token: 0x06034FD0 RID: 217040 RVA: 0x00ED1EBE File Offset: 0x00ED00BE
		public int ArtifactId
		{
			get
			{
				RiskHarvestInstArtifactInfo artifactInfoCache = this.ArtifactInfoCache;
				if (artifactInfoCache == null)
				{
					return 0;
				}
				return artifactInfoCache.Id;
			}
		}

		// Token: 0x170066D4 RID: 26324
		// (get) Token: 0x06034FD1 RID: 217041 RVA: 0x00ED1ED1 File Offset: 0x00ED00D1
		public int ArtifactBasicBuffTotalCount
		{
			get
			{
				RiskHarvestInstArtifactInfo artifactInfoCache = this.ArtifactInfoCache;
				if (artifactInfoCache == null)
				{
					return 0;
				}
				return artifactInfoCache.Progress;
			}
		}

		// Token: 0x170066D5 RID: 26325
		// (get) Token: 0x06034FD2 RID: 217042 RVA: 0x00ED1EE4 File Offset: 0x00ED00E4
		public Dictionary<int, int> BasicBuffInfoInBattle
		{
			get
			{
				return this.BasicBuffInfoInBattleCache;
			}
		}

		// Token: 0x170066D6 RID: 26326
		// (get) Token: 0x06034FD3 RID: 217043 RVA: 0x00ED1EEC File Offset: 0x00ED00EC
		public int TotalScore
		{
			get
			{
				return this.TotalScoreCache;
			}
		}

		// Token: 0x170066D7 RID: 26327
		// (get) Token: 0x06034FD4 RID: 217044 RVA: 0x00ED1EF4 File Offset: 0x00ED00F4
		public int UnlockBuffTotalCount
		{
			get
			{
				return this.UnlockBuffCache.Count;
			}
		}

		// Token: 0x170066D8 RID: 26328
		// (get) Token: 0x06034FD5 RID: 217045 RVA: 0x00ED1F01 File Offset: 0x00ED0101
		public HashSet<int> UnlockBuff
		{
			get
			{
				return this.UnlockBuffCache;
			}
		}

		// Token: 0x06034FD6 RID: 217046 RVA: 0x00ED1F09 File Offset: 0x00ED0109
		public bool IsBuffUnlocked(int id)
		{
			return this.UnlockBuffCache.Contains(id);
		}

		// Token: 0x06034FD7 RID: 217047 RVA: 0x00ED1F18 File Offset: 0x00ED0118
		public int? GetBuffCountInBattleById(int id)
		{
			int value;
			if (!this.BasicBuffInfoInBattleCache.TryGetValue(id, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06034FD8 RID: 217048 RVA: 0x00ED1F48 File Offset: 0x00ED0148
		public int GetScoreById(int id)
		{
			RiskHarvestInstInfo riskHarvestInstInfo;
			if (!this.InstanceInfoCache.TryGetValue(id, out riskHarvestInstInfo))
			{
				return 0;
			}
			return riskHarvestInstInfo.Score;
		}

		// Token: 0x06034FD9 RID: 217049 RVA: 0x00ED1F70 File Offset: 0x00ED0170
		public bool IsInstanceUnlockedById(int id)
		{
			RiskHarvestInstInfo riskHarvestInstInfo;
			return this.InstanceInfoCache.TryGetValue(id, out riskHarvestInstInfo) && riskHarvestInstInfo.IsUnlock;
		}

		// Token: 0x06034FDA RID: 217050 RVA: 0x00ED1F98 File Offset: 0x00ED0198
		public bool IsInstancePlayedById(int id)
		{
			RiskHarvestInstInfo riskHarvestInstInfo;
			return this.InstanceInfoCache.TryGetValue(id, out riskHarvestInstInfo) && riskHarvestInstInfo.Pass;
		}

		// Token: 0x06034FDB RID: 217051 RVA: 0x00ED1FC0 File Offset: 0x00ED01C0
		public double GetInstanceUnlockTimestampById(int id)
		{
			RiskHarvestInstInfo riskHarvestInstInfo;
			this.InstanceInfoCache.TryGetValue(id, out riskHarvestInstInfo);
			long? num = (riskHarvestInstInfo != null) ? new long?(riskHarvestInstInfo.UnlockTime) : null;
			if (num == null)
			{
				return double.MaxValue;
			}
			return (double)num.Value;
		}

		// Token: 0x06034FDC RID: 217052 RVA: 0x00ED2011 File Offset: 0x00ED0211
		public bool IsInstancePassUnlockTimeById(int id)
		{
			return TimeUtil.Instance.GetServerTimeStamp() >= this.GetInstanceUnlockTimestampById(id);
		}

		// Token: 0x06034FDD RID: 217053 RVA: 0x00ED2029 File Offset: 0x00ED0229
		public void ResetCacheInBattle()
		{
			this.ArtifactInfoCache = null;
			this.BasicBuffInfoInBattleCache.Clear();
			this.InBattleRecordData.Clear();
		}

		// Token: 0x06034FDE RID: 217054 RVA: 0x00ED2048 File Offset: 0x00ED0248
		public bool HasScoreRewarded(int id)
		{
			return this.RewardedScoreCache.Contains(id);
		}

		// Token: 0x06034FDF RID: 217055 RVA: 0x00ED2056 File Offset: 0x00ED0256
		public void RecordBuffId(int buffId)
		{
			this.InBattleRecordData.BasicBuffRecord.Add(buffId);
		}

		// Token: 0x06034FE0 RID: 217056 RVA: 0x00ED206A File Offset: 0x00ED026A
		public HashSet<int> GetRecordBuffIdSet()
		{
			return this.InBattleRecordData.BasicBuffRecord;
		}

		// Token: 0x06034FE1 RID: 217057 RVA: 0x00ED2077 File Offset: 0x00ED0277
		public void RecordProgressPanelBasicBuffCount(int count)
		{
			this.InBattleRecordData.ProgressPanelBasicBuffCountRecord = count;
		}

		// Token: 0x06034FE2 RID: 217058 RVA: 0x00ED2085 File Offset: 0x00ED0285
		public int GetProgressPanelBasicBuffCountRecord()
		{
			return this.InBattleRecordData.ProgressPanelBasicBuffCountRecord;
		}

		// Token: 0x0401BFF9 RID: 114681
		private readonly Dictionary<int, RiskHarvestInstInfo> InstanceInfoCache = new Dictionary<int, RiskHarvestInstInfo>();

		// Token: 0x0401BFFA RID: 114682
		[Nullable(2)]
		private RiskHarvestInstArtifactInfo ArtifactInfoCache;

		// Token: 0x0401BFFB RID: 114683
		private readonly Dictionary<int, int> BasicBuffInfoInBattleCache = new Dictionary<int, int>();

		// Token: 0x0401BFFC RID: 114684
		private readonly MowingRiskInBattleRecordData InBattleRecordData = new MowingRiskInBattleRecordData();

		// Token: 0x0401BFFD RID: 114685
		private readonly HashSet<int> RewardedScoreCache = new HashSet<int>();

		// Token: 0x0401BFFE RID: 114686
		private readonly HashSet<int> UnlockBuffCache = new HashSet<int>();

		// Token: 0x0401BFFF RID: 114687
		private int TotalScoreCache;
	}
}
