using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02004E6C RID: 20076
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityCooldownProbability
	{
		// Token: 0x1700625E RID: 25182
		// (get) Token: 0x06032881 RID: 206977 RVA: 0x00E2C789 File Offset: 0x00E2A989
		private Dictionary<int, EntityCooldownProbability.CooldownRecord> AudioEventCooldownTimeMapById
		{
			get
			{
				if (this.AudioEventCooldownTimeMapByIdInternal == null)
				{
					this.AudioEventCooldownTimeMapByIdInternal = new Dictionary<int, EntityCooldownProbability.CooldownRecord>();
				}
				return this.AudioEventCooldownTimeMapByIdInternal;
			}
		}

		// Token: 0x1700625F RID: 25183
		// (get) Token: 0x06032882 RID: 206978 RVA: 0x00E2C7A4 File Offset: 0x00E2A9A4
		private Dictionary<string, EntityCooldownProbability.CooldownRecord> AudioEventCooldownTimeMapByName
		{
			get
			{
				if (this.AudioEventCooldownTimeMapByNameInternal == null)
				{
					this.AudioEventCooldownTimeMapByNameInternal = new Dictionary<string, EntityCooldownProbability.CooldownRecord>();
				}
				return this.AudioEventCooldownTimeMapByNameInternal;
			}
		}

		// Token: 0x06032883 RID: 206979 RVA: 0x00E2C7BF File Offset: 0x00E2A9BF
		public void Init(int id, int modelId)
		{
			this.EntityId = id;
			this.ModelId = modelId;
		}

		// Token: 0x06032884 RID: 206980 RVA: 0x00E2C7CF File Offset: 0x00E2A9CF
		public void Clear()
		{
			this.TagComp = null;
			this.AudioEventCooldownTimeMapById.Clear();
			this.AudioEventCooldownTimeMapByIdInternal = null;
			this.AudioEventCooldownTimeMapByName.Clear();
			this.AudioEventCooldownTimeMapByNameInternal = null;
		}

		// Token: 0x06032885 RID: 206981 RVA: 0x00E2C7FC File Offset: 0x00E2A9FC
		public bool CheckTimeOutCooldownRecords()
		{
			bool flag = this.CheckTimeOutCooldownRecordsImpl<int>(this.AudioEventCooldownTimeMapById);
			bool flag2 = this.CheckTimeOutCooldownRecordsImpl<string>(this.AudioEventCooldownTimeMapByName);
			return flag && flag2;
		}

		// Token: 0x06032886 RID: 206982 RVA: 0x00E2C824 File Offset: 0x00E2AA24
		private bool CheckTimeOutCooldownRecordsImpl<T>(Dictionary<T, EntityCooldownProbability.CooldownRecord> dict)
		{
			List<T> list = new List<T>();
			foreach (KeyValuePair<T, EntityCooldownProbability.CooldownRecord> keyValuePair in dict)
			{
				if (Time.Instance.Now - keyValuePair.Value.Time >= Math.Max(keyValuePair.Value.Cooldown, 20000.0))
				{
					list.Add(keyValuePair.Key);
				}
			}
			foreach (T key in list)
			{
				dict.Remove(key);
			}
			return dict.Count == 0;
		}

		// Token: 0x06032887 RID: 206983 RVA: 0x00E2C8FC File Offset: 0x00E2AAFC
		public bool CheckPlayAudio([Nullable(new byte[]
		{
			0,
			1
		})] OneOf<int, string> eventObj, IAudioCoolDownWithTagInfo info, bool update = true, bool log = true)
		{
			if (info.TagProbability != null && info.TagProbability.Num() > 0)
			{
				if (this.TagComp == null)
				{
					this.TagComp = EntitySystem.Instance.GetComponent<BaseTagComponent>(this.EntityId);
				}
				int num = 0;
				while (num < info.TagProbability.Num() && this.TagComp != null)
				{
					SGameplayTagProbabilityCooldownInfo sgameplayTagProbabilityCooldownInfo = info.TagProbability.Get(num);
					if (sgameplayTagProbabilityCooldownInfo != null && this.TagComp.HasTag(sgameplayTagProbabilityCooldownInfo.GameplayTag.TagId()))
					{
						bool flag = this.CheckCooldownProbability(eventObj, (double)sgameplayTagProbabilityCooldownInfo.Probability, (double)sgameplayTagProbabilityCooldownInfo.CooldownTime, update, log);
						bool flag2 = flag && update && log;
						return flag;
					}
					num++;
				}
			}
			bool flag3 = this.CheckCooldownProbability(eventObj, info.DefaultProbability, (double)info.DefaultCooldownTime, update, log);
			bool flag4 = flag3 && log;
			return flag3;
		}

		// Token: 0x06032888 RID: 206984 RVA: 0x00E2C9C8 File Offset: 0x00E2ABC8
		public void UpdateCooldownRecord([Nullable(new byte[]
		{
			0,
			1
		})] OneOf<int, string> eventObj, double probability, double cooldownTime, bool log = true)
		{
			if (eventObj.IsT1)
			{
				this.UpdateCooldownRecordImpl<int>(this.AudioEventCooldownTimeMapById, eventObj.AsT1, probability, cooldownTime, log);
				return;
			}
			if (eventObj.IsT2)
			{
				this.UpdateCooldownRecordImpl<string>(this.AudioEventCooldownTimeMapByName, eventObj.AsT2, probability, cooldownTime, log);
			}
		}

		// Token: 0x06032889 RID: 206985 RVA: 0x00E2CA18 File Offset: 0x00E2AC18
		private void UpdateCooldownRecordImpl<T>(Dictionary<T, EntityCooldownProbability.CooldownRecord> dict, T eventObj, double probability, double cooldownTime, bool log = true)
		{
			EntityCooldownProbability.CooldownRecord cooldownRecord;
			if (dict.TryGetValue(eventObj, out cooldownRecord))
			{
				double now = Time.Instance.Now;
				double time = cooldownRecord.Time;
			}
			dict[eventObj] = new EntityCooldownProbability.CooldownRecord
			{
				Time = Time.Instance.Now,
				Cooldown = cooldownTime
			};
		}

		// Token: 0x0603288A RID: 206986 RVA: 0x00E2CA6C File Offset: 0x00E2AC6C
		private bool CheckCooldownProbability([Nullable(new byte[]
		{
			0,
			1
		})] OneOf<int, string> eventObj, double probability, double cooldownTime, bool update = true, bool log = true)
		{
			if (this.GetProbabilityResult<OneOf<int, string>>(eventObj, probability, log))
			{
				double num = -1.0;
				EntityCooldownProbability.CooldownRecord cooldownRecord2;
				if (eventObj.IsT1)
				{
					EntityCooldownProbability.CooldownRecord cooldownRecord;
					if (this.AudioEventCooldownTimeMapById.TryGetValue(eventObj.AsT1, out cooldownRecord))
					{
						num = Time.Instance.Now - cooldownRecord.Time;
					}
				}
				else if (eventObj.IsT2 && this.AudioEventCooldownTimeMapByName.TryGetValue(eventObj.AsT2, out cooldownRecord2))
				{
					num = Time.Instance.Now - cooldownRecord2.Time;
				}
				if (num < 0.0 || num > cooldownTime)
				{
					if (cooldownTime != 0.0 && update)
					{
						this.UpdateCooldownRecord(eventObj, probability, cooldownTime, log);
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603288B RID: 206987 RVA: 0x00E2CB2C File Offset: 0x00E2AD2C
		private bool GetProbabilityResult<[Nullable(2)] T>(T eventObj, double probability, bool log = true)
		{
			if (Math.Abs(probability - 1.0) < 0.0001 || Math.Abs(probability) < 0.0001)
			{
				return Math.Abs(probability - 1.0) < 0.0001;
			}
			double num = new Random().NextDouble();
			bool flag = num >= probability && log;
			return num < probability;
		}

		// Token: 0x0603288C RID: 206988 RVA: 0x00E2CB98 File Offset: 0x00E2AD98
		public static bool GetProbability(Number probability)
		{
			if (probability == 1 || probability == 0)
			{
				return probability == 1;
			}
			return new Random().NextDouble() < probability;
		}

		// Token: 0x0401ACC6 RID: 109766
		public int EntityId;

		// Token: 0x0401ACC7 RID: 109767
		public int ModelId;

		// Token: 0x0401ACC8 RID: 109768
		[Nullable(2)]
		public BaseTagComponent TagComp;

		// Token: 0x0401ACC9 RID: 109769
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, EntityCooldownProbability.CooldownRecord> AudioEventCooldownTimeMapByIdInternal;

		// Token: 0x0401ACCA RID: 109770
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, EntityCooldownProbability.CooldownRecord> AudioEventCooldownTimeMapByNameInternal;

		// Token: 0x0200AC13 RID: 44051
		[NullableContext(0)]
		public class CooldownRecord
		{
			// Token: 0x17007A12 RID: 31250
			// (get) Token: 0x06046AA3 RID: 289443 RVA: 0x015546E2 File Offset: 0x015528E2
			// (set) Token: 0x06046AA4 RID: 289444 RVA: 0x015546EA File Offset: 0x015528EA
			public double Time { get; set; }

			// Token: 0x17007A13 RID: 31251
			// (get) Token: 0x06046AA5 RID: 289445 RVA: 0x015546F3 File Offset: 0x015528F3
			// (set) Token: 0x06046AA6 RID: 289446 RVA: 0x015546FB File Offset: 0x015528FB
			public double Cooldown { get; set; }
		}
	}
}
