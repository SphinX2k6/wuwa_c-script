using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C5F RID: 23647
	[NullableContext(1)]
	[Nullable(0)]
	public class GroupSkillCdInfo
	{
		// Token: 0x17008DC1 RID: 36289
		// (get) Token: 0x0603BC62 RID: 244834 RVA: 0x00E466E4 File Offset: 0x00E448E4
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

		// Token: 0x0603BC63 RID: 244835 RVA: 0x00E4671A File Offset: 0x00E4491A
		public bool IsInCd()
		{
			return this.RemainingCount < this.LimitCount;
		}

		// Token: 0x0603BC64 RID: 244836 RVA: 0x00E4672A File Offset: 0x00E4492A
		public bool HasRemainingCount()
		{
			return this.RemainingCount > 0;
		}

		// Token: 0x0603BC65 RID: 244837 RVA: 0x00E46735 File Offset: 0x00E44935
		public bool IsInDelay()
		{
			return this.IsInDelayInner;
		}

		// Token: 0x0603BC66 RID: 244838 RVA: 0x00E46740 File Offset: 0x00E44940
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

		// Token: 0x0603BC67 RID: 244839 RVA: 0x00E46868 File Offset: 0x00E44A68
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

		// Token: 0x0603BC68 RID: 244840 RVA: 0x00E46908 File Offset: 0x00E44B08
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

		// Token: 0x0603BC69 RID: 244841 RVA: 0x00E46A20 File Offset: 0x00E44C20
		[NullableContext(0)]
		private ValueTuple<int?, float?> GetNextSkill()
		{
			if (this.SkillIdQueue.Size <= 0 || this.CdQueue.Size <= 0)
			{
				return new ValueTuple<int?, float?>(null, null);
			}
			return new ValueTuple<int?, float?>(new int?(this.SkillIdQueue.Pop()), new float?(this.CdQueue.Pop()));
		}

		// Token: 0x0603BC6A RID: 244842 RVA: 0x00E46A86 File Offset: 0x00E44C86
		private void AheadFinishSkillDelay()
		{
			if (this.SkillDelayTimer != null)
			{
				TimerSystem.FlowTimeInstance.Remove(this.SkillDelayTimer);
				this.IsInDelayInner = false;
				this.SkillDelayTimer = null;
			}
		}

		// Token: 0x0603BC6B RID: 244843 RVA: 0x00E46AAF File Offset: 0x00E44CAF
		private void AheadFinishSkillCd()
		{
			if (this.SkillCdTimer != null)
			{
				TimerSystem.FlowTimeInstance.Remove(this.SkillCdTimer);
				this.OnSkillCdFinish(0f);
			}
		}

		// Token: 0x0603BC6C RID: 244844 RVA: 0x00E46AD8 File Offset: 0x00E44CD8
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

		// Token: 0x0603BC6D RID: 244845 RVA: 0x00E46B70 File Offset: 0x00E44D70
		public void StartSkillCdTimer(int skillId, float cdSecond)
		{
			this.CurMaxCd = cdSecond;
			this.CurSkillId = (long)skillId;
			float num = cdSecond * (float)TimeUtil.Instance.InverseMillisecond;
			float interval = Math.Max(20f, num);
			this.SkillCdTimer = TimerSystem.FlowTimeInstance.Delay(new TTimerAction(this.OnSkillCdFinish), interval, null, null, true, 1f);
			this.SkillCdFinishStamp = Time.Instance.FlowTime + (double)num;
		}

		// Token: 0x0603BC6E RID: 244846 RVA: 0x00E46BE0 File Offset: 0x00E44DE0
		public void SetLimitCount(int? count = null)
		{
			this.LimitCountModify = (count ?? this.ConfigMaxCount);
			this.LimitCount = this.LimitCountModify + this.LimitCountAdd;
			this.ResetAllCd();
		}

		// Token: 0x0603BC6F RID: 244847 RVA: 0x00E46C28 File Offset: 0x00E44E28
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

		// Token: 0x0603BC70 RID: 244848 RVA: 0x00E46D04 File Offset: 0x00E44F04
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

		// Token: 0x0603BC71 RID: 244849 RVA: 0x00E46D6E File Offset: 0x00E44F6E
		public bool ResetDelayCd()
		{
			if (this.SkillDelayTimer == null)
			{
				return false;
			}
			this.AheadFinishSkillDelay();
			return true;
		}

		// Token: 0x0603BC72 RID: 244850 RVA: 0x00E46D84 File Offset: 0x00E44F84
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

		// Token: 0x0603BC73 RID: 244851 RVA: 0x00E46DD0 File Offset: 0x00E44FD0
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

		// Token: 0x0603BC74 RID: 244852 RVA: 0x00E46EAC File Offset: 0x00E450AC
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

		// Token: 0x0603BC75 RID: 244853 RVA: 0x00E46F1C File Offset: 0x00E4511C
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

		// Token: 0x0603BC76 RID: 244854 RVA: 0x00E46FE4 File Offset: 0x00E451E4
		public void ClearLimitCountChange()
		{
			if (this.ConfigMaxCount != this.LimitCount)
			{
				this.SetLimitCount(new int?(this.ConfigMaxCount));
			}
		}

		// Token: 0x0603BC77 RID: 244855 RVA: 0x00E47005 File Offset: 0x00E45205
		private void DispatchCountChangedEvent()
		{
			EventSystem.Instance.Emit<GroupSkillCdInfo>(EEventName.CharSkillCountChanged, this);
		}

		// Token: 0x0603BC78 RID: 244856 RVA: 0x00E47015 File Offset: 0x00E45215
		public void CheckConfigValid()
		{
		}

		// Token: 0x0401F1FA RID: 127482
		public int GroupId;

		// Token: 0x0401F1FB RID: 127483
		public int ConfigMaxCount;

		// Token: 0x0401F1FC RID: 127484
		public int LimitCountModify;

		// Token: 0x0401F1FD RID: 127485
		public int LimitCountAdd;

		// Token: 0x0401F1FE RID: 127486
		public int LimitCount;

		// Token: 0x0401F1FF RID: 127487
		public int RemainingCount;

		// Token: 0x0401F200 RID: 127488
		public readonly Dictionary<int, SkillCdInfo> SkillCdInfoMap = new Dictionary<int, SkillCdInfo>();

		// Token: 0x0401F201 RID: 127489
		public readonly HashSet<int> EntityIds = new HashSet<int>();

		// Token: 0x0401F202 RID: 127490
		public readonly Queue<int> SkillIdQueue = new Queue<int>(4);

		// Token: 0x0401F203 RID: 127491
		public readonly Queue<float> CdQueue = new Queue<float>(4);

		// Token: 0x0401F204 RID: 127492
		public float CurMaxCd;

		// Token: 0x0401F205 RID: 127493
		public double SkillCdFinishStamp;

		// Token: 0x0401F206 RID: 127494
		public long CurSkillId;

		// Token: 0x0401F207 RID: 127495
		[Nullable(2)]
		private TimerHandle SkillDelayTimer;

		// Token: 0x0401F208 RID: 127496
		[Nullable(2)]
		private TimerHandle SkillCdTimer;

		// Token: 0x0401F209 RID: 127497
		public int CurDelaySkillId;

		// Token: 0x0401F20A RID: 127498
		public float CurDelaySkillCd;

		// Token: 0x0401F20B RID: 127499
		[Nullable(2)]
		private EntityHandle EntityHandle;

		// Token: 0x0401F20C RID: 127500
		public readonly List<int> CdTags = new List<int>();

		// Token: 0x0401F20D RID: 127501
		private readonly List<int> CdTagsHandles = new List<int>();

		// Token: 0x0401F20E RID: 127502
		private bool IsInDelayInner;
	}
}
