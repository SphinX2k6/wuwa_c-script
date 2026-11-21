using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C3F RID: 19519
	[NullableContext(1)]
	[Nullable(0)]
	public class GroupSkillCdInfo
	{
		// Token: 0x17006193 RID: 24979
		// (get) Token: 0x06030BAD RID: 199597 RVA: 0x00D96AC4 File Offset: 0x00D94CC4
		public float CurRemainingCd
		{
			get
			{
				if (this.SkillCdFinishStamp != 0.0)
				{
					return (float)((this.SkillCdFinishStamp - Time.Instance.FlowTime) * TimeUtil.Instance.Millisecond);
				}
				return 0f;
			}
		}

		// Token: 0x06030BAE RID: 199598 RVA: 0x00D96AFA File Offset: 0x00D94CFA
		public bool IsInCd()
		{
			return this.RemainingCount < this.LimitCount;
		}

		// Token: 0x06030BAF RID: 199599 RVA: 0x00D96B0A File Offset: 0x00D94D0A
		public bool HasRemainingCount()
		{
			return this.RemainingCount > 0;
		}

		// Token: 0x06030BB0 RID: 199600 RVA: 0x00D96B15 File Offset: 0x00D94D15
		public bool IsInDelay()
		{
			return this.IsInDelayInner;
		}

		// Token: 0x06030BB1 RID: 199601 RVA: 0x00D96B20 File Offset: 0x00D94D20
		public bool StartCd(int skillId, float cdProportion, [Nullable(2)] EntityHandle handle, CharacterSkillCdComponent cdComp, IReadOnlyList<ESkillGenre> skillGenres)
		{
			this.EntityHandle = handle;
			SkillCdInfo skillCdInfo;
			if (!this.SkillCdInfoMap.TryGetValue(skillId, out skillCdInfo))
			{
				return false;
			}
			if (this.RemainingCount <= 0)
			{
				return false;
			}
			float num = cdComp.CalcExtraEffectCd(skillCdInfo.SkillCd, skillId, skillGenres) * cdProportion;
			if (this.IsInDelay())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Battle;
				ELogAuthor author = ELogAuthor.CFT;
				string message = "技能CD延迟期间，不能再用一次技能，必须先打断前一次技能";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("skillId", skillId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			float cdDelay = skillCdInfo.CdDelay;
			if (cdDelay > 0f)
			{
				this.CurDelaySkillId = skillId;
				this.CurDelaySkillCd = num;
				this.IsInDelayInner = true;
				float interval = Math.Max(20f, cdDelay * (float)TimeUtil.Instance.InverseMillisecond);
				this.SkillDelayTimer = TimerSystem.FlowTimeInstance.Delay(new TTimerAction(this.OnDelayFinish), interval, null, null, true, 1f);
				return true;
			}
			if (num <= 0f)
			{
				return true;
			}
			if (!this.IsInCd())
			{
				this.StartSkillCdTimer(skillId, num);
			}
			else
			{
				this.CdQueue.Push(num);
				this.SkillIdQueue.Push(skillId);
			}
			this.RemainingCount--;
			this.OnCountChanged();
			return true;
		}

		// Token: 0x06030BB2 RID: 199602 RVA: 0x00D96C48 File Offset: 0x00D94E48
		private void OnDelayFinish(float delta)
		{
			this.SkillDelayTimer = null;
			this.IsInDelayInner = false;
			if (this.RemainingCount <= 0)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.ZFJ, "技能CD延迟计时结束时，可用次数为0，不能进入CD", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int curDelaySkillId = this.CurDelaySkillId;
			float curDelaySkillCd = this.CurDelaySkillCd;
			if (!this.IsInCd())
			{
				this.RemainingCount--;
				this.OnCountChanged();
				this.StartSkillCdTimer(curDelaySkillId, curDelaySkillCd);
				return;
			}
			this.CdQueue.Push(curDelaySkillCd);
			this.SkillIdQueue.Push(curDelaySkillId);
			this.RemainingCount--;
			this.OnCountChanged();
		}

		// Token: 0x06030BB3 RID: 199603 RVA: 0x00D96CE8 File Offset: 0x00D94EE8
		private void OnSkillCdFinish(float delta)
		{
			double skillCdFinishStamp = this.SkillCdFinishStamp;
			this.SkillCdTimer = null;
			this.SkillCdFinishStamp = 0.0;
			this.RemainingCount++;
			float num = (float)(Math.Max(0.0, Time.Instance.FlowTime - skillCdFinishStamp) * TimeUtil.Instance.Millisecond);
			ValueTuple<int?, float?> nextSkill = this.GetNextSkill();
			int? item = nextSkill.Item1;
			float? item2 = nextSkill.Item2;
			while (item2 != null && num >= item2.Value)
			{
				this.RemainingCount++;
				num -= item2.Value;
				ValueTuple<int?, float?> nextSkill2 = this.GetNextSkill();
				item = nextSkill2.Item1;
				item2 = nextSkill2.Item2;
			}
			if (this.RemainingCount > this.LimitCount)
			{
				this.RemainingCount = this.LimitCount;
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "技能CD结束，可用次数已达上限", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.OnCountChanged();
			if (item == null || item2 == null)
			{
				return;
			}
			this.StartSkillCdTimer(item.Value, item2.Value - num);
		}

		// Token: 0x06030BB4 RID: 199604 RVA: 0x00D96E00 File Offset: 0x00D95000
		[NullableContext(0)]
		private ValueTuple<int?, float?> GetNextSkill()
		{
			if (this.SkillIdQueue.Size <= 0 || this.CdQueue.Size <= 0)
			{
				return new ValueTuple<int?, float?>(null, null);
			}
			return new ValueTuple<int?, float?>(new int?(this.SkillIdQueue.Pop()), new float?(this.CdQueue.Pop()));
		}

		// Token: 0x06030BB5 RID: 199605 RVA: 0x00D96E66 File Offset: 0x00D95066
		private void AheadFinishSkillDelay()
		{
			if (this.SkillDelayTimer != null)
			{
				TimerSystem.FlowTimeInstance.Remove(this.SkillDelayTimer);
				this.IsInDelayInner = false;
				this.SkillDelayTimer = null;
			}
		}

		// Token: 0x06030BB6 RID: 199606 RVA: 0x00D96E8F File Offset: 0x00D9508F
		private void AheadFinishSkillCd()
		{
			if (this.SkillCdTimer != null)
			{
				TimerSystem.FlowTimeInstance.Remove(this.SkillCdTimer);
				this.OnSkillCdFinish(0f);
			}
		}

		// Token: 0x06030BB7 RID: 199607 RVA: 0x00D96EB8 File Offset: 0x00D950B8
		private void ChangeSkillCd(float newCd)
		{
			this.SkillCdFinishStamp = ((newCd <= 0f) ? Time.Instance.FlowTime : (Time.Instance.FlowTime + (double)(newCd * (float)TimeUtil.Instance.InverseMillisecond)));
			if (this.SkillCdTimer != null)
			{
				TimerSystem.FlowTimeInstance.Remove(this.SkillCdTimer);
				float interval = Math.Max(20f, newCd * (float)TimeUtil.Instance.InverseMillisecond);
				this.SkillCdTimer = TimerSystem.FlowTimeInstance.Delay(new TTimerAction(this.OnSkillCdFinish), interval, null, null, true, 1f);
			}
		}

		// Token: 0x06030BB8 RID: 199608 RVA: 0x00D96F50 File Offset: 0x00D95150
		public void StartSkillCdTimer(int skillId, float cdSecond)
		{
			this.CurMaxCd = cdSecond;
			this.CurSkillId = (long)skillId;
			float num = cdSecond * (float)TimeUtil.Instance.InverseMillisecond;
			float interval = Math.Max(20f, num);
			this.SkillCdTimer = TimerSystem.FlowTimeInstance.Delay(new TTimerAction(this.OnSkillCdFinish), interval, null, null, true, 1f);
			this.SkillCdFinishStamp = Time.Instance.FlowTime + (double)num;
		}

		// Token: 0x06030BB9 RID: 199609 RVA: 0x00D96FC0 File Offset: 0x00D951C0
		public void SetLimitCount(int? count = null)
		{
			this.LimitCountModify = (count ?? this.ConfigMaxCount);
			this.LimitCount = this.LimitCountModify + this.LimitCountAdd;
			this.ResetAllCd();
		}

		// Token: 0x06030BBA RID: 199610 RVA: 0x00D97008 File Offset: 0x00D95208
		public void AddLimitCount(int count)
		{
			if (count == 0)
			{
				return;
			}
			this.LimitCountAdd += count;
			if (this.LimitCountAdd < 0)
			{
				Log.Instance.Error(ELogModule.Battle, ELogAuthor.CFT, "技能次数叠加不能小于0", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.LimitCountAdd = 0;
			}
			int num = this.LimitCount - this.RemainingCount;
			this.LimitCount = this.LimitCountModify + this.LimitCountAdd;
			this.RemainingCount = this.LimitCount - num;
			if (count < 0 && this.RemainingCount < 0)
			{
				for (int i = 0; i > this.RemainingCount; i--)
				{
					if (this.CdQueue.Size > 0)
					{
						this.CdQueue.Pop();
					}
					if (this.SkillIdQueue.Size > 0)
					{
						this.SkillIdQueue.Pop();
					}
				}
				this.RemainingCount = 0;
			}
			this.OnCountChanged();
		}

		// Token: 0x06030BBB RID: 199611 RVA: 0x00D970E4 File Offset: 0x00D952E4
		public void ResetAllCd()
		{
			this.CdQueue.Clear();
			this.SkillIdQueue.Clear();
			this.AheadFinishSkillDelay();
			if (this.SkillCdTimer != null)
			{
				TimerSystem.FlowTimeInstance.Remove(this.SkillCdTimer);
				this.SkillCdTimer = null;
				this.SkillCdFinishStamp = 0.0;
			}
			this.RemainingCount = this.LimitCount;
			this.OnCountChanged();
		}

		// Token: 0x06030BBC RID: 199612 RVA: 0x00D9714E File Offset: 0x00D9534E
		public bool ResetDelayCd()
		{
			if (this.SkillDelayTimer == null)
			{
				return false;
			}
			this.AheadFinishSkillDelay();
			return true;
		}

		// Token: 0x06030BBD RID: 199613 RVA: 0x00D97164 File Offset: 0x00D95364
		public void ModifyRemainingCd(float modifyTime, float changeTimePercentage)
		{
			if (!this.IsInCd())
			{
				return;
			}
			float num = this.CurRemainingCd + modifyTime + this.CurMaxCd * changeTimePercentage;
			if (num <= 0f)
			{
				this.AheadFinishSkillCd();
				return;
			}
			this.ChangeSkillCd(num);
			EventSystem.Instance.Emit<GroupSkillCdInfo>(EEventName.CharSkillRemainCdChanged, this);
		}

		// Token: 0x06030BBE RID: 199614 RVA: 0x00D971B0 File Offset: 0x00D953B0
		public void OnCountChanged()
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle != null && entityHandle.Valid)
			{
				CharacterBuffComponent component = this.EntityHandle.Entity.GetComponent<CharacterBuffComponent>();
				if (this.RemainingCount <= 0)
				{
					int item = component.AddTagWithReturnHandle(this.CdTags, -1f);
					this.CdTagsHandles.Add(item);
				}
				else
				{
					foreach (int handle in this.CdTagsHandles)
					{
						component.RemoveBuffByHandle(handle, -1, "技能CD结束移除", null, null, null);
					}
					this.CdTagsHandles.Clear();
				}
			}
			this.DispatchCountChangedEvent();
		}

		// Token: 0x06030BBF RID: 199615 RVA: 0x00D9728C File Offset: 0x00D9548C
		[NullableContext(2)]
		public void InitCdTags(EntityHandle handle)
		{
			this.EntityHandle = handle;
			if (this.RemainingCount > 0 || this.CdTagsHandles.Count > 0)
			{
				return;
			}
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle != null && entityHandle.Valid)
			{
				int item = this.EntityHandle.Entity.GetComponent<CharacterBuffComponent>().AddTagWithReturnHandle(this.CdTags, -1f);
				this.CdTagsHandles.Add(item);
			}
		}

		// Token: 0x06030BC0 RID: 199616 RVA: 0x00D972FC File Offset: 0x00D954FC
		public void ClearCdTags(int entityId)
		{
			EntityHandle entityHandle = this.EntityHandle;
			if (entityHandle == null || entityHandle.Id != entityId)
			{
				return;
			}
			EntityHandle entityHandle2 = this.EntityHandle;
			if (entityHandle2 != null && entityHandle2.Valid)
			{
				CharacterBuffComponent component = this.EntityHandle.Entity.GetComponent<CharacterBuffComponent>();
				foreach (int handle in this.CdTagsHandles)
				{
					component.RemoveBuffByHandle(handle, -1, "实体清理时移除技能CDTag", null, null, null);
				}
			}
			this.EntityHandle = null;
			this.CdTagsHandles.Clear();
		}

		// Token: 0x06030BC1 RID: 199617 RVA: 0x00D973C4 File Offset: 0x00D955C4
		public void ClearLimitCountChange()
		{
			if (this.ConfigMaxCount != this.LimitCount)
			{
				this.SetLimitCount(new int?(this.ConfigMaxCount));
			}
		}

		// Token: 0x06030BC2 RID: 199618 RVA: 0x00D973E5 File Offset: 0x00D955E5
		private void DispatchCountChangedEvent()
		{
			EventSystem.Instance.Emit<GroupSkillCdInfo>(EEventName.CharSkillCountChanged, this);
		}

		// Token: 0x06030BC3 RID: 199619 RVA: 0x00D973F5 File Offset: 0x00D955F5
		public void CheckConfigValid()
		{
		}

		// Token: 0x04019CAB RID: 105643
		public int GroupId;

		// Token: 0x04019CAC RID: 105644
		public int ConfigMaxCount;

		// Token: 0x04019CAD RID: 105645
		public int LimitCountModify;

		// Token: 0x04019CAE RID: 105646
		public int LimitCountAdd;

		// Token: 0x04019CAF RID: 105647
		public int LimitCount;

		// Token: 0x04019CB0 RID: 105648
		public int RemainingCount;

		// Token: 0x04019CB1 RID: 105649
		public readonly Dictionary<int, SkillCdInfo> SkillCdInfoMap = new Dictionary<int, SkillCdInfo>();

		// Token: 0x04019CB2 RID: 105650
		public readonly HashSet<int> EntityIds = new HashSet<int>();

		// Token: 0x04019CB3 RID: 105651
		public readonly Queue<int> SkillIdQueue = new Queue<int>(4);

		// Token: 0x04019CB4 RID: 105652
		public readonly Queue<float> CdQueue = new Queue<float>(4);

		// Token: 0x04019CB5 RID: 105653
		public float CurMaxCd;

		// Token: 0x04019CB6 RID: 105654
		public double SkillCdFinishStamp;

		// Token: 0x04019CB7 RID: 105655
		public long CurSkillId;

		// Token: 0x04019CB8 RID: 105656
		[Nullable(2)]
		private TimerHandle SkillDelayTimer;

		// Token: 0x04019CB9 RID: 105657
		[Nullable(2)]
		private TimerHandle SkillCdTimer;

		// Token: 0x04019CBA RID: 105658
		public int CurDelaySkillId;

		// Token: 0x04019CBB RID: 105659
		public float CurDelaySkillCd;

		// Token: 0x04019CBC RID: 105660
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x04019CBD RID: 105661
		public readonly List<int> CdTags = new List<int>();

		// Token: 0x04019CBE RID: 105662
		private readonly List<int> CdTagsHandles = new List<int>();

		// Token: 0x04019CBF RID: 105663
		private bool IsInDelayInner;
	}
}
