using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x020061F5 RID: 25077
	[NullableContext(1)]
	[Nullable(0)]
	public class PawnTimeScaleComponent : EntityComponent
	{
		// Token: 0x0603C36E RID: 246638 RVA: 0x01126E88 File Offset: 0x01125088
		public static ESourceEffectGroup getSourceEffectGroup(ETimeScaleSourceType sourceType)
		{
			foreach (KeyValuePair<ESourceEffectGroup, List<ETimeScaleSourceType>> keyValuePair in PawnTimeScaleComponent.sourceEffectGroup)
			{
				ESourceEffectGroup esourceEffectGroup;
				List<ETimeScaleSourceType> list;
				keyValuePair.Deconstruct(out esourceEffectGroup, out list);
				ESourceEffectGroup result = esourceEffectGroup;
				if (list.Contains(sourceType))
				{
					return result;
				}
			}
			return ESourceEffectGroup.LogicAndView;
		}

		// Token: 0x0603C36F RID: 246639 RVA: 0x01126EF4 File Offset: 0x011250F4
		public static ETimeScaleSourceGroup getSourceGroup(ETimeScaleSourceType sourceType)
		{
			foreach (KeyValuePair<ETimeScaleSourceGroup, List<ETimeScaleSourceType>> keyValuePair in PawnTimeScaleComponent.sourceTypeGroup)
			{
				ETimeScaleSourceGroup etimeScaleSourceGroup;
				List<ETimeScaleSourceType> list;
				keyValuePair.Deconstruct(out etimeScaleSourceGroup, out list);
				ETimeScaleSourceGroup result = etimeScaleSourceGroup;
				if (list.Contains(sourceType))
				{
					return result;
				}
			}
			return ETimeScaleSourceGroup.Default;
		}

		// Token: 0x0603C370 RID: 246640 RVA: 0x01126F60 File Offset: 0x01125160
		public static int CompareScalePriority(ForeverTimeScale scale1, ForeverTimeScale scale2)
		{
			if (scale1.SourceTypeGroup != scale2.SourceTypeGroup)
			{
				return scale2.SourceTypeGroup - scale1.SourceTypeGroup;
			}
			if (scale1.Priority != scale2.Priority)
			{
				return scale2.Priority - scale1.Priority;
			}
			if (scale1.TimeDilation != scale2.TimeDilation)
			{
				return scale1.TimeDilation.CompareTo(scale2.TimeDilation);
			}
			return scale2.EndTime.CompareTo(scale1.EndTime);
		}

		// Token: 0x0603C371 RID: 246641 RVA: 0x01126FDC File Offset: 0x011251DC
		public static int CompareScalePriority(TimeScale scale1, TimeScale scale2)
		{
			if (scale1.SourceTypeGroup != scale2.SourceTypeGroup)
			{
				return scale2.SourceTypeGroup - scale1.SourceTypeGroup;
			}
			if (scale1.Priority != scale2.Priority)
			{
				return scale2.Priority - scale1.Priority;
			}
			if (scale1.TimeDilation != scale2.TimeDilation)
			{
				return scale1.TimeDilation.CompareTo(scale2.TimeDilation);
			}
			return scale2.EndTime.CompareTo(scale1.EndTime);
		}

		// Token: 0x0603C372 RID: 246642 RVA: 0x01127054 File Offset: 0x01125254
		protected override bool OnInit()
		{
			this.TimeScaleList.Clear();
			this.TimeScaleMap.Clear();
			this.ForeverTimeScaleLogicView.Clear();
			this.ForeverTimeScaleViewOnly.Clear();
			this.ForeverTimeScaleMap.Clear();
			this.TimeScaleId = 1;
			this.KeyedTimeScaleLocks.Clear();
			return true;
		}

		// Token: 0x0603C373 RID: 246643 RVA: 0x011270AC File Offset: 0x011252AC
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.HitComp = base.Entity.GetComponent<CharacterHitComponent>();
			SEntityProperty entityPropertyConfig = this.ActorComp.CreatureData.GetEntityPropertyConfig();
			this.BulletHitDiscount = (float)entityPropertyConfig.子弹受击顿帧时长比例 / 100f;
			return true;
		}

		// Token: 0x0603C374 RID: 246644 RVA: 0x01127100 File Offset: 0x01125300
		protected virtual bool IsTimescaleValid(TimeScale timescale, float currentTime)
		{
			return timescale.EndTime > timescale.GetCurrentTime() && !timescale.MarkDelete;
		}

		// Token: 0x0603C375 RID: 246645 RVA: 0x0112711B File Offset: 0x0112531B
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0603C376 RID: 246646 RVA: 0x01127120 File Offset: 0x01125320
		[NullableContext(2)]
		private int SetTimeScaleInternal(int priority, float timeDilation, UCurveFloat curve, float duration, ETimeScaleSourceType sourceType, bool needAddSceneItemTag = false, bool immuneSelfCenter = false)
		{
			if (sourceType == ETimeScaleSourceType.OthersBullet)
			{
				duration *= this.BulletHitDiscount;
			}
			if (duration <= 0f)
			{
				return -1;
			}
			double num = immuneSelfCenter ? Time.Instance.PlayerWorldTimeSeconds : Time.Instance.WorldTimeSeconds;
			double num2 = num + (double)duration;
			double endTime = num2;
			float timeDilation2 = Math.Max(timeDilation, 0f);
			float duration2 = duration;
			int timeScaleId = this.TimeScaleId;
			this.TimeScaleId = timeScaleId + 1;
			TimeScale timeScale = new TimeScale(num, endTime, priority, timeDilation2, curve, duration2, timeScaleId, sourceType, PawnTimeScaleComponent.getSourceGroup(sourceType), needAddSceneItemTag, immuneSelfCenter);
			this.TimeScaleList.Push(timeScale);
			this.TimeScaleMap[timeScale.Id] = timeScale;
			return timeScale.Id;
		}

		// Token: 0x0603C377 RID: 246647 RVA: 0x011271C0 File Offset: 0x011253C0
		[NullableContext(2)]
		public virtual int SetTimeScale(int priority, float timeDilation, UCurveFloat curve, float duration, ETimeScaleSourceType sourceType, bool needAddSceneItemTag = false, bool immuneSelfCenter = false)
		{
			return this.SetTimeScaleInternal(priority, timeDilation, curve, duration, sourceType, needAddSceneItemTag, immuneSelfCenter);
		}

		// Token: 0x0603C378 RID: 246648 RVA: 0x011271D4 File Offset: 0x011253D4
		private void RemoveTimeScaleInternal(int id)
		{
			TimeScale timeScale;
			if (this.TimeScaleMap.TryGetValue(id, out timeScale))
			{
				timeScale.MarkDelete = true;
			}
		}

		// Token: 0x0603C379 RID: 246649 RVA: 0x011271F8 File Offset: 0x011253F8
		public virtual void RemoveTimeScale(int id)
		{
			this.RemoveTimeScaleInternal(id);
		}

		// Token: 0x0603C37A RID: 246650 RVA: 0x01127204 File Offset: 0x01125404
		public void RemoveAllTimeScale()
		{
			foreach (TimeScale timeScale in this.TimeScaleMap.Values)
			{
				timeScale.MarkDelete = true;
			}
		}

		// Token: 0x0603C37B RID: 246651 RVA: 0x0112725C File Offset: 0x0112545C
		public virtual int SetForeverTimeScale(ETimeScaleSourceType type, float timeScale, int priority = 0, bool refreshImmediately = false)
		{
			ETimeScaleSourceGroup sourceGroup = PawnTimeScaleComponent.getSourceGroup(type);
			int timeScaleId = this.TimeScaleId;
			this.TimeScaleId = timeScaleId + 1;
			ForeverTimeScale foreverTimeScale = new ForeverTimeScale(priority, timeScale, type, sourceGroup, timeScaleId);
			if (PawnTimeScaleComponent.getSourceEffectGroup(type) == ESourceEffectGroup.ViewOnly)
			{
				this.ForeverTimeScaleViewOnly.Push(foreverTimeScale);
			}
			else
			{
				this.ForeverTimeScaleLogicView.Push(foreverTimeScale);
			}
			this.ForeverTimeScaleMap[foreverTimeScale.Id] = foreverTimeScale;
			if (refreshImmediately)
			{
				this.OnTick(0f);
			}
			EventSystem.Instance.EmitWithTarget<ETimeScaleSourceType, float, int>(base.Entity, EEventName.OnForeverTimeDilationAdd, type, timeScale, priority);
			return foreverTimeScale.Id;
		}

		// Token: 0x0603C37C RID: 246652 RVA: 0x011272EC File Offset: 0x011254EC
		public virtual void RemoveForeverTimeScale(int id, bool refreshImmediately = false)
		{
			ForeverTimeScale foreverTimeScale;
			if (this.ForeverTimeScaleMap.TryGetValue(id, out foreverTimeScale))
			{
				foreverTimeScale.MarkDelete = true;
				if (refreshImmediately)
				{
					this.OnTick(0f);
				}
				EventSystem.Instance.EmitWithTarget<ETimeScaleSourceType, float, int>(base.Entity, EEventName.OnForeverTimeDilationRemove, foreverTimeScale.SourceType, foreverTimeScale.TimeDilation, foreverTimeScale.Priority);
			}
		}

		// Token: 0x0603C37D RID: 246653 RVA: 0x01127348 File Offset: 0x01125548
		public float GetForeverTimeScale(int id)
		{
			ForeverTimeScale foreverTimeScale2;
			ForeverTimeScale foreverTimeScale = this.ForeverTimeScaleMap.TryGetValue(id, out foreverTimeScale2) ? foreverTimeScale2 : null;
			if (foreverTimeScale == null)
			{
				return 1f;
			}
			return foreverTimeScale.TimeDilation;
		}

		// Token: 0x0603C37E RID: 246654 RVA: 0x0112737C File Offset: 0x0112557C
		[NullableContext(2)]
		public virtual void SetTimeScaleTicking(bool enable, string reason = null)
		{
			if (enable && this.DisableHandle != null)
			{
				if (base.Enable(new int?(this.DisableHandle.Value), reason ?? "[PawnTimeScaleComponent] 开启Tick"))
				{
					this.DisableHandle = null;
					return;
				}
			}
			else if (!enable && this.DisableHandle == null)
			{
				this.DisableHandle = new int?(base.Disable(reason ?? "[PawnTimeScaleComponent] 关闭Tick"));
			}
		}

		// Token: 0x170071A7 RID: 29095
		// (get) Token: 0x0603C37F RID: 246655 RVA: 0x011273F3 File Offset: 0x011255F3
		public float CurrentTimeScale
		{
			get
			{
				return this.TimeScaleInternal;
			}
		}

		// Token: 0x170071A8 RID: 29096
		// (get) Token: 0x0603C380 RID: 246656 RVA: 0x011273FB File Offset: 0x011255FB
		public float FreezeTimeScale
		{
			get
			{
				return this.FreezeTimeScaleInternal;
			}
		}

		// Token: 0x0603C381 RID: 246657 RVA: 0x01127403 File Offset: 0x01125603
		[NullableContext(2)]
		private int SetLocalTimeScale(int priority, float timeDilation, UCurveFloat curve, float duration, ETimeScaleSourceType sourceType, bool needAddSceneItemTag = false, bool immuneSelfCenter = false)
		{
			return this.SetTimeScaleInternal(priority, timeDilation, curve, duration, sourceType, needAddSceneItemTag, immuneSelfCenter);
		}

		// Token: 0x0603C382 RID: 246658 RVA: 0x01127416 File Offset: 0x01125616
		private void ResetLocalTimeScale(int id)
		{
			this.RemoveTimeScaleInternal(id);
		}

		// Token: 0x0603C383 RID: 246659 RVA: 0x01127420 File Offset: 0x01125620
		private void SetKeyedTimeScaleLock(string key, ETimeScaleSourceType sourceType, float scale, bool refreshImmediately = false, bool needImmuneCheck = false)
		{
			PawnTimeScaleComponent.KeyedTimeScaleLock keyedTimeScaleLock;
			if (this.KeyedTimeScaleLocks.TryGetValue(key, out keyedTimeScaleLock) && keyedTimeScaleLock.Handle >= 0 && keyedTimeScaleLock.Scale == scale && keyedTimeScaleLock.SourceType == sourceType && keyedTimeScaleLock.NeedImmuneCheck == needImmuneCheck)
			{
				return;
			}
			this.ResetKeyedTimeScaleLock(key, false);
			int handle = -1;
			if (needImmuneCheck)
			{
				CharacterHitComponent hitComp = this.HitComp;
				if (hitComp != null && hitComp.IsImmuneTimeScaleEffect())
				{
					goto IL_6E;
				}
			}
			handle = this.SetLocalTimeScale(int.MaxValue, scale, null, float.PositiveInfinity, sourceType, false, false);
			IL_6E:
			this.KeyedTimeScaleLocks[key] = new PawnTimeScaleComponent.KeyedTimeScaleLock
			{
				Handle = handle,
				Scale = scale,
				SourceType = sourceType,
				NeedImmuneCheck = needImmuneCheck
			};
			if (refreshImmediately)
			{
				this.OnTick(0f);
			}
		}

		// Token: 0x0603C384 RID: 246660 RVA: 0x011274D8 File Offset: 0x011256D8
		private void ResetKeyedTimeScaleLock(string key, bool refreshImmediately = false)
		{
			PawnTimeScaleComponent.KeyedTimeScaleLock keyedTimeScaleLock;
			if (!this.KeyedTimeScaleLocks.TryGetValue(key, out keyedTimeScaleLock))
			{
				return;
			}
			if (keyedTimeScaleLock.Handle >= 0)
			{
				this.ResetLocalTimeScale(keyedTimeScaleLock.Handle);
			}
			this.KeyedTimeScaleLocks.Remove(key);
			if (refreshImmediately)
			{
				this.OnTick(0f);
			}
		}

		// Token: 0x0603C385 RID: 246661 RVA: 0x01127528 File Offset: 0x01125728
		public void AddPauseLock(string key)
		{
			this.SetKeyedTimeScaleLock(key, ETimeScaleSourceType.InnerPauseLock, 0f, false, true);
			PawnTimeScaleComponent.KeyedTimeScaleLock keyedTimeScaleLock;
			this.PauseLocks[key] = (this.KeyedTimeScaleLocks.TryGetValue(key, out keyedTimeScaleLock) ? keyedTimeScaleLock.Handle : -1);
		}

		// Token: 0x0603C386 RID: 246662 RVA: 0x0112756A File Offset: 0x0112576A
		public void RemovePauseLock(string key)
		{
			this.ResetKeyedTimeScaleLock(key, false);
			this.PauseLocks.Remove(key);
		}

		// Token: 0x0603C387 RID: 246663 RVA: 0x01127584 File Offset: 0x01125784
		public void ImmunePauseLock()
		{
			string[] array = new string[this.PauseLocks.Count];
			this.PauseLocks.Keys.CopyTo(array, 0);
			foreach (string key in array)
			{
				PawnTimeScaleComponent.KeyedTimeScaleLock keyedTimeScaleLock;
				if (this.KeyedTimeScaleLocks.TryGetValue(key, out keyedTimeScaleLock) && keyedTimeScaleLock.Handle >= 0)
				{
					this.ResetLocalTimeScale(keyedTimeScaleLock.Handle);
					keyedTimeScaleLock.Handle = -1;
					this.KeyedTimeScaleLocks[key] = keyedTimeScaleLock;
					this.PauseLocks[key] = -1;
				}
			}
		}

		// Token: 0x0603C388 RID: 246664 RVA: 0x01127614 File Offset: 0x01125814
		public void ResumePauseLock()
		{
			string[] array = new string[this.PauseLocks.Count];
			this.PauseLocks.Keys.CopyTo(array, 0);
			foreach (string key in array)
			{
				this.SetKeyedTimeScaleLock(key, ETimeScaleSourceType.InnerPauseLock, 0f, false, true);
				PawnTimeScaleComponent.KeyedTimeScaleLock keyedTimeScaleLock;
				this.PauseLocks[key] = (this.KeyedTimeScaleLocks.TryGetValue(key, out keyedTimeScaleLock) ? keyedTimeScaleLock.Handle : -1);
			}
		}

		// Token: 0x0603C389 RID: 246665 RVA: 0x0112768E File Offset: 0x0112588E
		public bool HasPauseLock()
		{
			return this.PauseLocks.Count > 0;
		}

		// Token: 0x0603C38A RID: 246666 RVA: 0x011276A0 File Offset: 0x011258A0
		public void AddNormalizeTimeScaleLock(string key, bool refreshImmediately = false)
		{
			this.SetKeyedTimeScaleLock(key, ETimeScaleSourceType.InnerNormalizeTimeScaleLock, 1f, refreshImmediately, false);
			PawnTimeScaleComponent.KeyedTimeScaleLock keyedTimeScaleLock;
			this.NormalizeTimeScaleLocks[key] = (this.KeyedTimeScaleLocks.TryGetValue(key, out keyedTimeScaleLock) ? keyedTimeScaleLock.Handle : -1);
		}

		// Token: 0x0603C38B RID: 246667 RVA: 0x011276E2 File Offset: 0x011258E2
		public void RemoveNormalizeTimeScaleLock(string key, bool refreshImmediately = false)
		{
			this.ResetKeyedTimeScaleLock(key, refreshImmediately);
			this.NormalizeTimeScaleLocks.Remove(key);
		}

		// Token: 0x0603C38C RID: 246668 RVA: 0x011276F9 File Offset: 0x011258F9
		public void AddForceTimeScale(float scale, string key, bool refreshImmediately = false, ETimeScaleSourceType sourceType = ETimeScaleSourceType.InnerForceTimeScale)
		{
			this.SetKeyedTimeScaleLock(key, sourceType, scale, refreshImmediately, false);
		}

		// Token: 0x0603C38D RID: 246669 RVA: 0x01127707 File Offset: 0x01125907
		public void RemoveForceTimeScale(string key, bool refreshImmediately = false)
		{
			this.ResetKeyedTimeScaleLock(key, refreshImmediately);
		}

		// Token: 0x0603C38E RID: 246670 RVA: 0x01127711 File Offset: 0x01125911
		public void AddDelayLock(string key)
		{
			this.AddNormalizeTimeScaleLock(key, false);
		}

		// Token: 0x0603C38F RID: 246671 RVA: 0x0112771B File Offset: 0x0112591B
		public void RemoveDelayLock(string key)
		{
			this.RemoveNormalizeTimeScaleLock(key, false);
		}

		// Token: 0x0603C390 RID: 246672 RVA: 0x01127728 File Offset: 0x01125928
		public float GetTopForeverTimeScale(ESourceEffectGroup? effectGroup = null)
		{
			ForeverTimeScale topForeverTimeScaleConfig = this.GetTopForeverTimeScaleConfig(effectGroup);
			if (topForeverTimeScaleConfig == null)
			{
				return 1f;
			}
			return topForeverTimeScaleConfig.TimeDilation;
		}

		// Token: 0x0603C391 RID: 246673 RVA: 0x0112774C File Offset: 0x0112594C
		[return: Nullable(2)]
		public ForeverTimeScale GetTopForeverTimeScaleByList(PriorityQueue<ForeverTimeScale> list)
		{
			while (!list.Empty)
			{
				ForeverTimeScale top = list.Top;
				if (top == null)
				{
					return null;
				}
				if (!top.MarkDelete)
				{
					return top;
				}
				this.ForeverTimeScaleMap.Remove(top.Id);
				list.Pop();
			}
			return null;
		}

		// Token: 0x0603C392 RID: 246674 RVA: 0x01127794 File Offset: 0x01125994
		[NullableContext(2)]
		public ForeverTimeScale GetTopForeverTimeScaleConfig(ESourceEffectGroup? effectGroup = null)
		{
			if (effectGroup == null)
			{
				ForeverTimeScale topForeverTimeScaleByList = this.GetTopForeverTimeScaleByList(this.ForeverTimeScaleViewOnly);
				ForeverTimeScale topForeverTimeScaleByList2 = this.GetTopForeverTimeScaleByList(this.ForeverTimeScaleLogicView);
				if (topForeverTimeScaleByList == null)
				{
					return topForeverTimeScaleByList2;
				}
				if (topForeverTimeScaleByList2 == null)
				{
					return topForeverTimeScaleByList;
				}
				if (PawnTimeScaleComponent.CompareScalePriority(topForeverTimeScaleByList, topForeverTimeScaleByList2) >= 0)
				{
					return topForeverTimeScaleByList2;
				}
				return topForeverTimeScaleByList;
			}
			else
			{
				if (effectGroup.GetValueOrDefault() == ESourceEffectGroup.ViewOnly)
				{
					return this.GetTopForeverTimeScaleByList(this.ForeverTimeScaleViewOnly);
				}
				return this.GetTopForeverTimeScaleByList(this.ForeverTimeScaleLogicView);
			}
		}

		// Token: 0x0603C393 RID: 246675 RVA: 0x01127800 File Offset: 0x01125A00
		public string GetDebugString()
		{
			string text = "";
			if (this.ForeverTimeScaleLogicView.Empty && this.ForeverTimeScaleViewOnly.Empty)
			{
				text += "没有生效的ForeverTimeScale\n";
			}
			else
			{
				ForeverTimeScale topForeverTimeScaleConfig = this.GetTopForeverTimeScaleConfig(new ESourceEffectGroup?(ESourceEffectGroup.LogicAndView));
				if (topForeverTimeScaleConfig != null)
				{
					string str = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(56, 2);
					defaultInterpolatedStringHandler.AppendLiteral("\t生效的LogicAndViewTimeScale: SourceType: ");
					defaultInterpolatedStringHandler.AppendFormatted<ETimeScaleSourceType>(topForeverTimeScaleConfig.SourceType);
					defaultInterpolatedStringHandler.AppendLiteral(", TimeDilation: ");
					defaultInterpolatedStringHandler.AppendFormatted<float>(topForeverTimeScaleConfig.TimeDilation);
					defaultInterpolatedStringHandler.AppendLiteral("\n");
					text = str + defaultInterpolatedStringHandler.ToStringAndClear();
				}
				ForeverTimeScale topForeverTimeScaleConfig2 = this.GetTopForeverTimeScaleConfig(new ESourceEffectGroup?(ESourceEffectGroup.ViewOnly));
				if (topForeverTimeScaleConfig2 != null)
				{
					string str2 = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(52, 2);
					defaultInterpolatedStringHandler.AppendLiteral("\t生效的ViewOnlyTimeScale: SourceType: ");
					defaultInterpolatedStringHandler.AppendFormatted<ETimeScaleSourceType>(topForeverTimeScaleConfig2.SourceType);
					defaultInterpolatedStringHandler.AppendLiteral(", TimeDilation: ");
					defaultInterpolatedStringHandler.AppendFormatted<float>(topForeverTimeScaleConfig2.TimeDilation);
					defaultInterpolatedStringHandler.AppendLiteral("\n");
					text = str2 + defaultInterpolatedStringHandler.ToStringAndClear();
				}
			}
			return text;
		}

		// Token: 0x0603C394 RID: 246676 RVA: 0x0112790C File Offset: 0x01125B0C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PawnTimeScaleComponent pawnTimeScaleComponent = (PawnTimeScaleComponent)componentTemplate;
			if (pawnTimeScaleComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (pawnTimeScaleComponent.HitComp == null)
			{
				this.HitComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.HitComp), "HitComp"))
			{
				return false;
			}
			this.TimeScaleInternal = pawnTimeScaleComponent.TimeScaleInternal;
			this.DisableHandle = pawnTimeScaleComponent.DisableHandle;
			this.FreezeTimeScaleInternal = pawnTimeScaleComponent.FreezeTimeScaleInternal;
			this.BulletHitDiscount = pawnTimeScaleComponent.BulletHitDiscount;
			if (pawnTimeScaleComponent.TimeScaleList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimeScaleList), "TimeScaleList"))
			{
				return false;
			}
			if (pawnTimeScaleComponent.TimeScaleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimeScaleMap), "TimeScaleMap"))
			{
				return false;
			}
			this.TimeScaleId = pawnTimeScaleComponent.TimeScaleId;
			if (pawnTimeScaleComponent.ForeverTimeScaleLogicView != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ForeverTimeScaleLogicView), "ForeverTimeScaleLogicView"))
			{
				return false;
			}
			if (pawnTimeScaleComponent.ForeverTimeScaleViewOnly != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ForeverTimeScaleViewOnly), "ForeverTimeScaleViewOnly"))
			{
				return false;
			}
			if (pawnTimeScaleComponent.ForeverTimeScaleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ForeverTimeScaleMap), "ForeverTimeScaleMap"))
			{
				return false;
			}
			if (pawnTimeScaleComponent.KeyedTimeScaleLocks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.KeyedTimeScaleLocks), "KeyedTimeScaleLocks"))
			{
				return false;
			}
			if (pawnTimeScaleComponent.PauseLocks == null)
			{
				this.PauseLocks = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PauseLocks), "PauseLocks"))
			{
				return false;
			}
			if (pawnTimeScaleComponent.NormalizeTimeScaleLocks == null)
			{
				this.NormalizeTimeScaleLocks = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.NormalizeTimeScaleLocks), "NormalizeTimeScaleLocks"))
			{
				return false;
			}
			return true;
		}

		// Token: 0x170071A9 RID: 29097
		// (get) Token: 0x0603C395 RID: 246677 RVA: 0x01127AE0 File Offset: 0x01125CE0
		public override bool NeedInitInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071AA RID: 29098
		// (get) Token: 0x0603C396 RID: 246678 RVA: 0x01127AE3 File Offset: 0x01125CE3
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170071AB RID: 29099
		// (get) Token: 0x0603C397 RID: 246679 RVA: 0x01127AE6 File Offset: 0x01125CE6
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0603C398 RID: 246680 RVA: 0x01127AEC File Offset: 0x01125CEC
		public PawnTimeScaleComponent()
		{
			Comparison<TimeScale> compare;
			if ((compare = PawnTimeScaleComponent.<>O.<0>__CompareScalePriority) == null)
			{
				compare = (PawnTimeScaleComponent.<>O.<0>__CompareScalePriority = new Comparison<TimeScale>(PawnTimeScaleComponent.CompareScalePriority));
			}
			this.TimeScaleList = new PriorityQueue<TimeScale>(compare);
			this.TimeScaleMap = new Dictionary<int, TimeScale>();
			this.TimeScaleId = 1;
			Comparison<ForeverTimeScale> compare2;
			if ((compare2 = PawnTimeScaleComponent.<>O.<1>__CompareScalePriority) == null)
			{
				compare2 = (PawnTimeScaleComponent.<>O.<1>__CompareScalePriority = new Comparison<ForeverTimeScale>(PawnTimeScaleComponent.CompareScalePriority));
			}
			this.ForeverTimeScaleLogicView = new PriorityQueue<ForeverTimeScale>(compare2);
			Comparison<ForeverTimeScale> compare3;
			if ((compare3 = PawnTimeScaleComponent.<>O.<1>__CompareScalePriority) == null)
			{
				compare3 = (PawnTimeScaleComponent.<>O.<1>__CompareScalePriority = new Comparison<ForeverTimeScale>(PawnTimeScaleComponent.CompareScalePriority));
			}
			this.ForeverTimeScaleViewOnly = new PriorityQueue<ForeverTimeScale>(compare3);
			this.ForeverTimeScaleMap = new Dictionary<int, ForeverTimeScale>();
			this.KeyedTimeScaleLocks = new Dictionary<string, PawnTimeScaleComponent.KeyedTimeScaleLock>();
			this.PauseLocks = new Dictionary<string, int>();
			this.NormalizeTimeScaleLocks = new Dictionary<string, int>();
			base..ctor();
		}

		// Token: 0x0603C399 RID: 246681 RVA: 0x01127BD0 File Offset: 0x01125DD0
		// Note: this type is marked as 'beforefieldinit'.
		unsafe static PawnTimeScaleComponent()
		{
			Dictionary<ESourceEffectGroup, List<ETimeScaleSourceType>> dictionary = new Dictionary<ESourceEffectGroup, List<ETimeScaleSourceType>>();
			ESourceEffectGroup key = ESourceEffectGroup.LogicAndView;
			int num = 17;
			List<ETimeScaleSourceType> list = new List<ETimeScaleSourceType>(num);
			CollectionsMarshal.SetCount<ETimeScaleSourceType>(list, num);
			Span<ETimeScaleSourceType> span = CollectionsMarshal.AsSpan<ETimeScaleSourceType>(list);
			int num2 = 0;
			*span[num2] = ETimeScaleSourceType.DefaultTimeScale;
			num2++;
			*span[num2] = ETimeScaleSourceType.MyBullet;
			num2++;
			*span[num2] = ETimeScaleSourceType.OthersBullet;
			num2++;
			*span[num2] = ETimeScaleSourceType.Counter;
			num2++;
			*span[num2] = ETimeScaleSourceType.BeCountered;
			num2++;
			*span[num2] = ETimeScaleSourceType.BattleSettlement;
			num2++;
			*span[num2] = ETimeScaleSourceType.Buff;
			num2++;
			*span[num2] = ETimeScaleSourceType.PanelQte;
			num2++;
			*span[num2] = ETimeScaleSourceType.TimeStopMachine;
			num2++;
			*span[num2] = ETimeScaleSourceType.InnerPauseLock;
			num2++;
			*span[num2] = ETimeScaleSourceType.InnerNormalizeTimeScaleLock;
			num2++;
			*span[num2] = ETimeScaleSourceType.InnerForceTimeScale;
			num2++;
			*span[num2] = ETimeScaleSourceType.Portal;
			num2++;
			*span[num2] = ETimeScaleSourceType.DeathEffect;
			num2++;
			*span[num2] = ETimeScaleSourceType.SelfCentered;
			num2++;
			*span[num2] = ETimeScaleSourceType.ElementalField;
			num2++;
			*span[num2] = ETimeScaleSourceType.WithKscEntityUpdate;
			dictionary[key] = list;
			ESourceEffectGroup key2 = ESourceEffectGroup.ViewOnly;
			num2 = 1;
			List<ETimeScaleSourceType> list2 = new List<ETimeScaleSourceType>(num2);
			CollectionsMarshal.SetCount<ETimeScaleSourceType>(list2, num2);
			span = CollectionsMarshal.AsSpan<ETimeScaleSourceType>(list2);
			num = 0;
			*span[num] = ETimeScaleSourceType.SelfBeHit;
			dictionary[key2] = list2;
			PawnTimeScaleComponent.sourceEffectGroup = dictionary;
			Dictionary<ETimeScaleSourceGroup, List<ETimeScaleSourceType>> dictionary2 = new Dictionary<ETimeScaleSourceGroup, List<ETimeScaleSourceType>>();
			ETimeScaleSourceGroup key3 = ETimeScaleSourceGroup.Battle;
			num = 12;
			List<ETimeScaleSourceType> list3 = new List<ETimeScaleSourceType>(num);
			CollectionsMarshal.SetCount<ETimeScaleSourceType>(list3, num);
			span = CollectionsMarshal.AsSpan<ETimeScaleSourceType>(list3);
			num2 = 0;
			*span[num2] = ETimeScaleSourceType.DefaultTimeScale;
			num2++;
			*span[num2] = ETimeScaleSourceType.MyBullet;
			num2++;
			*span[num2] = ETimeScaleSourceType.OthersBullet;
			num2++;
			*span[num2] = ETimeScaleSourceType.Counter;
			num2++;
			*span[num2] = ETimeScaleSourceType.BeCountered;
			num2++;
			*span[num2] = ETimeScaleSourceType.Buff;
			num2++;
			*span[num2] = ETimeScaleSourceType.PanelQte;
			num2++;
			*span[num2] = ETimeScaleSourceType.TimeStopMachine;
			num2++;
			*span[num2] = ETimeScaleSourceType.Portal;
			num2++;
			*span[num2] = ETimeScaleSourceType.DeathEffect;
			num2++;
			*span[num2] = ETimeScaleSourceType.ElementalField;
			num2++;
			*span[num2] = ETimeScaleSourceType.WithKscEntityUpdate;
			dictionary2[key3] = list3;
			ETimeScaleSourceGroup key4 = ETimeScaleSourceGroup.SelfCentered;
			num2 = 1;
			List<ETimeScaleSourceType> list4 = new List<ETimeScaleSourceType>(num2);
			CollectionsMarshal.SetCount<ETimeScaleSourceType>(list4, num2);
			span = CollectionsMarshal.AsSpan<ETimeScaleSourceType>(list4);
			num = 0;
			*span[num] = ETimeScaleSourceType.SelfCentered;
			dictionary2[key4] = list4;
			ETimeScaleSourceGroup key5 = ETimeScaleSourceGroup.AdvancedBattle;
			num = 2;
			List<ETimeScaleSourceType> list5 = new List<ETimeScaleSourceType>(num);
			CollectionsMarshal.SetCount<ETimeScaleSourceType>(list5, num);
			span = CollectionsMarshal.AsSpan<ETimeScaleSourceType>(list5);
			num2 = 0;
			*span[num2] = ETimeScaleSourceType.SelfBeHit;
			num2++;
			*span[num2] = ETimeScaleSourceType.InnerForceTimeScale;
			dictionary2[key5] = list5;
			ETimeScaleSourceGroup key6 = ETimeScaleSourceGroup.ULT;
			num2 = 2;
			List<ETimeScaleSourceType> list6 = new List<ETimeScaleSourceType>(num2);
			CollectionsMarshal.SetCount<ETimeScaleSourceType>(list6, num2);
			span = CollectionsMarshal.AsSpan<ETimeScaleSourceType>(list6);
			num = 0;
			*span[num] = ETimeScaleSourceType.InnerPauseLock;
			num++;
			*span[num] = ETimeScaleSourceType.InnerNormalizeTimeScaleLock;
			dictionary2[key6] = list6;
			ETimeScaleSourceGroup key7 = ETimeScaleSourceGroup.BattleFinish;
			num = 1;
			List<ETimeScaleSourceType> list7 = new List<ETimeScaleSourceType>(num);
			CollectionsMarshal.SetCount<ETimeScaleSourceType>(list7, num);
			span = CollectionsMarshal.AsSpan<ETimeScaleSourceType>(list7);
			num2 = 0;
			*span[num2] = ETimeScaleSourceType.BattleSettlement;
			dictionary2[key7] = list7;
			PawnTimeScaleComponent.sourceTypeGroup = dictionary2;
		}

		// Token: 0x0401FE26 RID: 130598
		private const float LIMIT_SCALE = 0f;

		// Token: 0x0401FE27 RID: 130599
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ESourceEffectGroup, List<ETimeScaleSourceType>> sourceEffectGroup;

		// Token: 0x0401FE28 RID: 130600
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ETimeScaleSourceGroup, List<ETimeScaleSourceType>> sourceTypeGroup;

		// Token: 0x0401FE29 RID: 130601
		[Nullable(2)]
		protected BaseActorComponent ActorComp;

		// Token: 0x0401FE2A RID: 130602
		[Nullable(2)]
		private CharacterHitComponent HitComp;

		// Token: 0x0401FE2B RID: 130603
		protected float TimeScaleInternal = 1f;

		// Token: 0x0401FE2C RID: 130604
		protected int? DisableHandle;

		// Token: 0x0401FE2D RID: 130605
		protected float FreezeTimeScaleInternal = 1f;

		// Token: 0x0401FE2E RID: 130606
		private float BulletHitDiscount = 1f;

		// Token: 0x0401FE2F RID: 130607
		protected readonly PriorityQueue<TimeScale> TimeScaleList;

		// Token: 0x0401FE30 RID: 130608
		protected readonly Dictionary<int, TimeScale> TimeScaleMap;

		// Token: 0x0401FE31 RID: 130609
		private int TimeScaleId;

		// Token: 0x0401FE32 RID: 130610
		protected readonly PriorityQueue<ForeverTimeScale> ForeverTimeScaleLogicView;

		// Token: 0x0401FE33 RID: 130611
		protected readonly PriorityQueue<ForeverTimeScale> ForeverTimeScaleViewOnly;

		// Token: 0x0401FE34 RID: 130612
		protected readonly Dictionary<int, ForeverTimeScale> ForeverTimeScaleMap;

		// Token: 0x0401FE35 RID: 130613
		private readonly Dictionary<string, PawnTimeScaleComponent.KeyedTimeScaleLock> KeyedTimeScaleLocks;

		// Token: 0x0401FE36 RID: 130614
		protected Dictionary<string, int> PauseLocks;

		// Token: 0x0401FE37 RID: 130615
		protected Dictionary<string, int> NormalizeTimeScaleLocks;

		// Token: 0x0200BA25 RID: 47653
		[NullableContext(0)]
		private class KeyedTimeScaleLock
		{
			// Token: 0x040395CD RID: 234957
			public int Handle;

			// Token: 0x040395CE RID: 234958
			public float Scale;

			// Token: 0x040395CF RID: 234959
			public ETimeScaleSourceType SourceType;

			// Token: 0x040395D0 RID: 234960
			public bool NeedImmuneCheck;
		}

		// Token: 0x0200BA26 RID: 47654
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x040395D1 RID: 234961
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<TimeScale> <0>__CompareScalePriority;

			// Token: 0x040395D2 RID: 234962
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<ForeverTimeScale> <1>__CompareScalePriority;
		}
	}
}
