using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.Module.Audio
{
	// Token: 0x02005E87 RID: 24199
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityCooldownProbability
	{
		// Token: 0x17008E8C RID: 36492
		// (get) Token: 0x0603D8F1 RID: 252145 RVA: 0x00EDB1FD File Offset: 0x00ED93FD
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

		// Token: 0x17008E8D RID: 36493
		// (get) Token: 0x0603D8F2 RID: 252146 RVA: 0x00EDB218 File Offset: 0x00ED9418
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

		// Token: 0x0603D8F3 RID: 252147 RVA: 0x00EDB233 File Offset: 0x00ED9433
		public void Init(int id, int modelId)
		{
			this.EntityId = id;
			this.ModelId = modelId;
		}

		// Token: 0x0603D8F4 RID: 252148 RVA: 0x00EDB243 File Offset: 0x00ED9443
		public void Clear()
		{
			this.TagComp = null;
			this.AudioEventCooldownTimeMapById.Clear();
			this.AudioEventCooldownTimeMapByIdInternal = null;
			this.AudioEventCooldownTimeMapByName.Clear();
			this.AudioEventCooldownTimeMapByNameInternal = null;
		}

		// Token: 0x0603D8F5 RID: 252149 RVA: 0x00EDB270 File Offset: 0x00ED9470
		public bool CheckTimeOutCooldownRecords()
		{
			bool flag = this.CheckTimeOutCooldownRecordsImpl<int>(this.AudioEventCooldownTimeMapById);
			bool flag2 = this.CheckTimeOutCooldownRecordsImpl<string>(this.AudioEventCooldownTimeMapByName);
			return flag && flag2;
		}

		// Token: 0x0603D8F6 RID: 252150 RVA: 0x00EDB298 File Offset: 0x00ED9498
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

		// Token: 0x0603D8F7 RID: 252151 RVA: 0x00EDB370 File Offset: 0x00ED9570
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

		// Token: 0x0603D8F8 RID: 252152 RVA: 0x00EDB43C File Offset: 0x00ED963C
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

		// Token: 0x0603D8F9 RID: 252153 RVA: 0x00EDB48C File Offset: 0x00ED968C
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

		// Token: 0x0603D8FA RID: 252154 RVA: 0x00EDB4E0 File Offset: 0x00ED96E0
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

		// Token: 0x0603D8FB RID: 252155 RVA: 0x00EDB5A0 File Offset: 0x00ED97A0
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

		// Token: 0x0603D8FC RID: 252156 RVA: 0x00EDB60C File Offset: 0x00ED980C
		public static bool GetProbability(Number probability)
		{
			if (probability == 1 || probability == 0)
			{
				return probability == 1;
			}
			return new Random().NextDouble() < probability;
		}

		// Token: 0x040201FF RID: 131583
		public int EntityId;

		// Token: 0x04020200 RID: 131584
		public int ModelId;

		// Token: 0x04020201 RID: 131585
		[Nullable(2)]
		public BaseTagComponent TagComp;

		// Token: 0x04020202 RID: 131586
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private Dictionary<int, EntityCooldownProbability.CooldownRecord> AudioEventCooldownTimeMapByIdInternal;

		// Token: 0x04020203 RID: 131587
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private Dictionary<string, EntityCooldownProbability.CooldownRecord> AudioEventCooldownTimeMapByNameInternal;

		// Token: 0x0200C204 RID: 49668
		[NullableContext(0)]
		public class CooldownRecord
		{
			// Token: 0x1700A275 RID: 41589
			// (get) Token: 0x06050556 RID: 329046 RVA: 0x0159ADCE File Offset: 0x01598FCE
			// (set) Token: 0x06050557 RID: 329047 RVA: 0x0159ADD6 File Offset: 0x01598FD6
			public double Time { get; set; }

			// Token: 0x1700A276 RID: 41590
			// (get) Token: 0x06050558 RID: 329048 RVA: 0x0159ADDF File Offset: 0x01598FDF
			// (set) Token: 0x06050559 RID: 329049 RVA: 0x0159ADE7 File Offset: 0x01598FE7
			public double Cooldown { get; set; }
		}
	}
}
