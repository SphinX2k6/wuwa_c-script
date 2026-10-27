using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MowingRisk
{
	// Token: 0x020063A7 RID: 25511
	[NullableContext(1)]
	[Nullable(0)]
	public class MowingRiskProtocolContext : ActivityBaseData, IMowingRiskContextDisposable
	{
		// Token: 0x060402FD RID: 262909 RVA: 0x00F8AC4C File Offset: 0x00F88E4C
		protected override void OnInit(ActivityData data)
		{
			MowingRiskModel.Instance.InitContext();
		}

		// Token: 0x060402FE RID: 262910 RVA: 0x00F8AC58 File Offset: 0x00F88E58
		public void Dispose()
		{
		}

		// Token: 0x060402FF RID: 262911 RVA: 0x00F8AC5C File Offset: 0x00F88E5C
		protected override void PhraseEx(ActivityData data)
		{
			RiskHarvestActivityInfo riskHarvestActivityInfo = data.RiskHarvestActivityInfo;
			if (riskHarvestActivityInfo != null)
			{
				this.ParseActivityInfo(riskHarvestActivityInfo);
			}
		}

		// Token: 0x06040300 RID: 262912 RVA: 0x00F8AC7C File Offset: 0x00F88E7C
		public override bool GetExDataRedPointShowState()
		{
			MowingRiskModel instance = MowingRiskModel.Instance;
			return instance.HasAnyReward || instance.IsNewInstanceOpen;
		}

		// Token: 0x06040301 RID: 262913 RVA: 0x00F8AC9F File Offset: 0x00F88E9F
		public void ParseRiskHarvestEndNotify(RiskHarvestEndNotify msg)
		{
		}

		// Token: 0x06040302 RID: 262914 RVA: 0x00F8ACA1 File Offset: 0x00F88EA1
		public void ParseRiskHarvestInstUpdateNotify(RiskHarvestInstUpdateNotify msg)
		{
			this.ParseInstInfosIncremental(msg.InstInfos.ToArray<RiskHarvestInstInfo>());
		}

		// Token: 0x06040303 RID: 262915 RVA: 0x00F8ACB4 File Offset: 0x00F88EB4
		public void ParseRiskHarvestArtifactNotify(RiskHarvestArtifactNotify msg)
		{
			this.ParseArtifactInfo(msg.ArtifactInfo);
		}

		// Token: 0x06040304 RID: 262916 RVA: 0x00F8ACC2 File Offset: 0x00F88EC2
		public void ParseRiskHarvestBuffUpdateNotify(RiskHarvestBuffUpdateNotify msg)
		{
			this.ParseArtifactInfo(msg.ArtifactInfo);
		}

		// Token: 0x06040305 RID: 262917 RVA: 0x00F8ACD0 File Offset: 0x00F88ED0
		public void ParseRiskHarvestBuffUnlockNotify(RiskHarvestBuffUnlockNotify msg)
		{
			this.ParseUnlockBuffGroup(msg.UnlockBuffGroup.ToArray<int>());
		}

		// Token: 0x06040306 RID: 262918 RVA: 0x00F8ACE4 File Offset: 0x00F88EE4
		public void ParseRiskHarvestActivityUpdateNotify(RiskHarvestActivityUpdateNotify msg)
		{
			RiskHarvestActivityInfo activityInfo = msg.ActivityInfo;
			if (activityInfo == null)
			{
				return;
			}
			this.ParseActivityInfo(activityInfo);
		}

		// Token: 0x06040307 RID: 262919 RVA: 0x00F8AD04 File Offset: 0x00F88F04
		private void ParseInstInfosIncremental(RiskHarvestInstInfo[] data)
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

		// Token: 0x06040308 RID: 262920 RVA: 0x00F8AD74 File Offset: 0x00F88F74
		private void ParseInstInfosAll(RiskHarvestInstInfo[] data)
		{
			this.TotalScoreCache = 0;
			foreach (RiskHarvestInstInfo riskHarvestInstInfo in data)
			{
				this.InstanceInfoCache[riskHarvestInstInfo.Id] = riskHarvestInstInfo;
				this.TotalScoreCache += riskHarvestInstInfo.Score;
			}
		}

		// Token: 0x06040309 RID: 262921 RVA: 0x00F8ADC4 File Offset: 0x00F88FC4
		private void ParseRewardedScores(int[] data)
		{
			this.RewardedScoreCache.Clear();
			foreach (int item in data)
			{
				this.RewardedScoreCache.Add(item);
			}
		}

		// Token: 0x0604030A RID: 262922 RVA: 0x00F8AE00 File Offset: 0x00F89000
		private void ParseUnlockBuffGroup(int[] data)
		{
			foreach (int item in data)
			{
				this.UnlockBuffCache.Add(item);
			}
		}

		// Token: 0x0604030B RID: 262923 RVA: 0x00F8AE30 File Offset: 0x00F89030
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

		// Token: 0x0604030C RID: 262924 RVA: 0x00F8AEA4 File Offset: 0x00F890A4
		private void ParseActivityInfo(RiskHarvestActivityInfo data)
		{
			this.ParseInstInfosAll(data.InstInfos.ToArray<RiskHarvestInstInfo>());
			this.ParseRewardedScores(data.RewardedScores.ToArray<int>());
			this.ParseUnlockBuffGroup(data.UnlockBuffGroups.ToArray<int>());
		}

		// Token: 0x1700936F RID: 37743
		// (get) Token: 0x0604030D RID: 262925 RVA: 0x00F8AED9 File Offset: 0x00F890D9
		public Dictionary<int, RiskHarvestInstInfo> InstanceInfo
		{
			get
			{
				return this.InstanceInfoCache;
			}
		}

		// Token: 0x17009370 RID: 37744
		// (get) Token: 0x0604030E RID: 262926 RVA: 0x00F8AEE4 File Offset: 0x00F890E4
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

		// Token: 0x17009371 RID: 37745
		// (get) Token: 0x0604030F RID: 262927 RVA: 0x00F8AF1E File Offset: 0x00F8911E
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

		// Token: 0x17009372 RID: 37746
		// (get) Token: 0x06040310 RID: 262928 RVA: 0x00F8AF31 File Offset: 0x00F89131
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

		// Token: 0x17009373 RID: 37747
		// (get) Token: 0x06040311 RID: 262929 RVA: 0x00F8AF44 File Offset: 0x00F89144
		public Dictionary<int, int> BasicBuffInfoInBattle
		{
			get
			{
				return this.BasicBuffInfoInBattleCache;
			}
		}

		// Token: 0x17009374 RID: 37748
		// (get) Token: 0x06040312 RID: 262930 RVA: 0x00F8AF4C File Offset: 0x00F8914C
		public int TotalScore
		{
			get
			{
				return this.TotalScoreCache;
			}
		}

		// Token: 0x17009375 RID: 37749
		// (get) Token: 0x06040313 RID: 262931 RVA: 0x00F8AF54 File Offset: 0x00F89154
		public int UnlockBuffTotalCount
		{
			get
			{
				return this.UnlockBuffCache.Count;
			}
		}

		// Token: 0x17009376 RID: 37750
		// (get) Token: 0x06040314 RID: 262932 RVA: 0x00F8AF61 File Offset: 0x00F89161
		public HashSet<int> UnlockBuff
		{
			get
			{
				return this.UnlockBuffCache;
			}
		}

		// Token: 0x06040315 RID: 262933 RVA: 0x00F8AF69 File Offset: 0x00F89169
		public bool IsBuffUnlocked(int id)
		{
			return this.UnlockBuffCache.Contains(id);
		}

		// Token: 0x06040316 RID: 262934 RVA: 0x00F8AF78 File Offset: 0x00F89178
		public int? GetBuffCountInBattleById(int id)
		{
			int value;
			if (!this.BasicBuffInfoInBattleCache.TryGetValue(id, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06040317 RID: 262935 RVA: 0x00F8AFA8 File Offset: 0x00F891A8
		public int GetScoreById(int id)
		{
			RiskHarvestInstInfo riskHarvestInstInfo;
			if (!this.InstanceInfoCache.TryGetValue(id, out riskHarvestInstInfo))
			{
				return 0;
			}
			return riskHarvestInstInfo.Score;
		}

		// Token: 0x06040318 RID: 262936 RVA: 0x00F8AFD0 File Offset: 0x00F891D0
		public bool IsInstanceUnlockedById(int id)
		{
			RiskHarvestInstInfo riskHarvestInstInfo;
			return this.InstanceInfoCache.TryGetValue(id, out riskHarvestInstInfo) && riskHarvestInstInfo.IsUnlock;
		}

		// Token: 0x06040319 RID: 262937 RVA: 0x00F8AFF8 File Offset: 0x00F891F8
		public bool IsInstancePlayedById(int id)
		{
			RiskHarvestInstInfo riskHarvestInstInfo;
			return this.InstanceInfoCache.TryGetValue(id, out riskHarvestInstInfo) && riskHarvestInstInfo.Pass;
		}

		// Token: 0x0604031A RID: 262938 RVA: 0x00F8B020 File Offset: 0x00F89220
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

		// Token: 0x0604031B RID: 262939 RVA: 0x00F8B071 File Offset: 0x00F89271
		public bool IsInstancePassUnlockTimeById(int id)
		{
			return TimeUtil.Instance.GetServerTimeStamp() >= this.GetInstanceUnlockTimestampById(id);
		}

		// Token: 0x0604031C RID: 262940 RVA: 0x00F8B089 File Offset: 0x00F89289
		public void ResetCacheInBattle()
		{
			this.ArtifactInfoCache = null;
			this.BasicBuffInfoInBattleCache.Clear();
			this.InBattleRecordData.Clear();
		}

		// Token: 0x0604031D RID: 262941 RVA: 0x00F8B0A8 File Offset: 0x00F892A8
		public bool HasScoreRewarded(int id)
		{
			return this.RewardedScoreCache.Contains(id);
		}

		// Token: 0x0604031E RID: 262942 RVA: 0x00F8B0B6 File Offset: 0x00F892B6
		public void RecordBuffId(int buffId)
		{
			this.InBattleRecordData.BasicBuffRecord.Add(buffId);
		}

		// Token: 0x0604031F RID: 262943 RVA: 0x00F8B0CA File Offset: 0x00F892CA
		public HashSet<int> GetRecordBuffIdSet()
		{
			return this.InBattleRecordData.BasicBuffRecord;
		}

		// Token: 0x06040320 RID: 262944 RVA: 0x00F8B0D7 File Offset: 0x00F892D7
		public void RecordProgressPanelBasicBuffCount(int count)
		{
			this.InBattleRecordData.ProgressPanelBasicBuffCountRecord = count;
		}

		// Token: 0x06040321 RID: 262945 RVA: 0x00F8B0E5 File Offset: 0x00F892E5
		public int GetProgressPanelBasicBuffCountRecord()
		{
			return this.InBattleRecordData.ProgressPanelBasicBuffCountRecord;
		}

		// Token: 0x040216CA RID: 136906
		private readonly Dictionary<int, RiskHarvestInstInfo> InstanceInfoCache = new Dictionary<int, RiskHarvestInstInfo>();

		// Token: 0x040216CB RID: 136907
		[Nullable(2)]
		private RiskHarvestInstArtifactInfo ArtifactInfoCache;

		// Token: 0x040216CC RID: 136908
		private readonly Dictionary<int, int> BasicBuffInfoInBattleCache = new Dictionary<int, int>();

		// Token: 0x040216CD RID: 136909
		private readonly MowingRiskInBattleRecordData InBattleRecordData = new MowingRiskInBattleRecordData();

		// Token: 0x040216CE RID: 136910
		private readonly HashSet<int> RewardedScoreCache = new HashSet<int>();

		// Token: 0x040216CF RID: 136911
		private readonly HashSet<int> UnlockBuffCache = new HashSet<int>();

		// Token: 0x040216D0 RID: 136912
		private int TotalScoreCache;
	}
}
