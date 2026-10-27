using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Pawn.Component
{
	// Token: 0x02007074 RID: 28788
	[NullableContext(1)]
	[Nullable(0)]
	public class PawnTimeScaleComponent : EntityComponent
	{
		// Token: 0x06046167 RID: 287079 RVA: 0x0117D598 File Offset: 0x0117B798
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

		// Token: 0x06046168 RID: 287080 RVA: 0x0117D604 File Offset: 0x0117B804
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

		// Token: 0x06046169 RID: 287081 RVA: 0x0117D670 File Offset: 0x0117B870
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

		// Token: 0x0604616A RID: 287082 RVA: 0x0117D6EC File Offset: 0x0117B8EC
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

		// Token: 0x0604616B RID: 287083 RVA: 0x0117D764 File Offset: 0x0117B964
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

		// Token: 0x0604616C RID: 287084 RVA: 0x0117D7BC File Offset: 0x0117B9BC
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<BaseActorComponent>();
			this.HitComp = base.Entity.GetComponent<CharacterHitComponent>();
			SEntityProperty entityPropertyConfig = this.ActorComp.CreatureData.GetEntityPropertyConfig();
			this.BulletHitDiscount = (float)entityPropertyConfig.子弹受击顿帧时长比例 / 100f;
			return true;
		}

		// Token: 0x0604616D RID: 287085 RVA: 0x0117D810 File Offset: 0x0117BA10
		protected virtual bool IsTimescaleValid(TimeScale timescale, float currentTime)
		{
			return timescale.EndTime > timescale.GetCurrentTime() && !timescale.MarkDelete;
		}

		// Token: 0x0604616E RID: 287086 RVA: 0x0117D82B File Offset: 0x0117BA2B
		protected override void OnTick(float delta)
		{
		}

		// Token: 0x0604616F RID: 287087 RVA: 0x0117D830 File Offset: 0x0117BA30
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

		// Token: 0x06046170 RID: 287088 RVA: 0x0117D8D0 File Offset: 0x0117BAD0
		[NullableContext(2)]
		public virtual int SetTimeScale(int priority, float timeDilation, UCurveFloat curve, float duration, ETimeScaleSourceType sourceType, bool needAddSceneItemTag = false, bool immuneSelfCenter = false)
		{
			return this.SetTimeScaleInternal(priority, timeDilation, curve, duration, sourceType, needAddSceneItemTag, immuneSelfCenter);
		}

		// Token: 0x06046171 RID: 287089 RVA: 0x0117D8E4 File Offset: 0x0117BAE4
		private void RemoveTimeScaleInternal(int id)
		{
			TimeScale timeScale;
			if (this.TimeScaleMap.TryGetValue(id, out timeScale))
			{
				timeScale.MarkDelete = true;
			}
		}

		// Token: 0x06046172 RID: 287090 RVA: 0x0117D908 File Offset: 0x0117BB08
		public virtual void RemoveTimeScale(int id)
		{
			this.RemoveTimeScaleInternal(id);
		}

		// Token: 0x06046173 RID: 287091 RVA: 0x0117D914 File Offset: 0x0117BB14
		public void RemoveAllTimeScale()
		{
			foreach (TimeScale timeScale in this.TimeScaleMap.Values)
			{
				timeScale.MarkDelete = true;
			}
		}

		// Token: 0x06046174 RID: 287092 RVA: 0x0117D96C File Offset: 0x0117BB6C
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

		// Token: 0x06046175 RID: 287093 RVA: 0x0117D9FC File Offset: 0x0117BBFC
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

		// Token: 0x06046176 RID: 287094 RVA: 0x0117DA58 File Offset: 0x0117BC58
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

		// Token: 0x06046177 RID: 287095 RVA: 0x0117DA8C File Offset: 0x0117BC8C
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

		// Token: 0x17009C15 RID: 39957
		// (get) Token: 0x06046178 RID: 287096 RVA: 0x0117DB03 File Offset: 0x0117BD03
		public float CurrentTimeScale
		{
			get
			{
				return this.TimeScaleInternal;
			}
		}

		// Token: 0x17009C16 RID: 39958
		// (get) Token: 0x06046179 RID: 287097 RVA: 0x0117DB0B File Offset: 0x0117BD0B
		public float FreezeTimeScale
		{
			get
			{
				return this.FreezeTimeScaleInternal;
			}
		}

		// Token: 0x0604617A RID: 287098 RVA: 0x0117DB13 File Offset: 0x0117BD13
		[NullableContext(2)]
		private int SetLocalTimeScale(int priority, float timeDilation, UCurveFloat curve, float duration, ETimeScaleSourceType sourceType, bool needAddSceneItemTag = false, bool immuneSelfCenter = false)
		{
			return this.SetTimeScaleInternal(priority, timeDilation, curve, duration, sourceType, needAddSceneItemTag, immuneSelfCenter);
		}

		// Token: 0x0604617B RID: 287099 RVA: 0x0117DB26 File Offset: 0x0117BD26
		private void ResetLocalTimeScale(int id)
		{
			this.RemoveTimeScaleInternal(id);
		}

		// Token: 0x0604617C RID: 287100 RVA: 0x0117DB30 File Offset: 0x0117BD30
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

		// Token: 0x0604617D RID: 287101 RVA: 0x0117DBE8 File Offset: 0x0117BDE8
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

		// Token: 0x0604617E RID: 287102 RVA: 0x0117DC38 File Offset: 0x0117BE38
		public void AddPauseLock(string key)
		{
			this.SetKeyedTimeScaleLock(key, ETimeScaleSourceType.InnerPauseLock, 0f, false, true);
			PawnTimeScaleComponent.KeyedTimeScaleLock keyedTimeScaleLock;
			this.PauseLocks[key] = (this.KeyedTimeScaleLocks.TryGetValue(key, out keyedTimeScaleLock) ? keyedTimeScaleLock.Handle : -1);
		}

		// Token: 0x0604617F RID: 287103 RVA: 0x0117DC7A File Offset: 0x0117BE7A
		public void RemovePauseLock(string key)
		{
			this.ResetKeyedTimeScaleLock(key, false);
			this.PauseLocks.Remove(key);
		}

		// Token: 0x06046180 RID: 287104 RVA: 0x0117DC94 File Offset: 0x0117BE94
		public void ImmunePauseLock()
		{
			foreach (string key in this.PauseLocks.Keys.ToList<string>())
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

		// Token: 0x06046181 RID: 287105 RVA: 0x0117DD30 File Offset: 0x0117BF30
		public void ResumePauseLock()
		{
			foreach (string key in this.PauseLocks.Keys.ToList<string>())
			{
				this.SetKeyedTimeScaleLock(key, ETimeScaleSourceType.InnerPauseLock, 0f, false, true);
				PawnTimeScaleComponent.KeyedTimeScaleLock keyedTimeScaleLock;
				this.PauseLocks[key] = (this.KeyedTimeScaleLocks.TryGetValue(key, out keyedTimeScaleLock) ? keyedTimeScaleLock.Handle : -1);
			}
		}

		// Token: 0x06046182 RID: 287106 RVA: 0x0117DDBC File Offset: 0x0117BFBC
		public bool HasPauseLock()
		{
			return this.PauseLocks.Count > 0;
		}

		// Token: 0x06046183 RID: 287107 RVA: 0x0117DDCC File Offset: 0x0117BFCC
		public void AddNormalizeTimeScaleLock(string key, bool refreshImmediately = false)
		{
			this.SetKeyedTimeScaleLock(key, ETimeScaleSourceType.InnerNormalizeTimeScaleLock, 1f, refreshImmediately, false);
			PawnTimeScaleComponent.KeyedTimeScaleLock keyedTimeScaleLock;
			this.NormalizeTimeScaleLocks[key] = (this.KeyedTimeScaleLocks.TryGetValue(key, out keyedTimeScaleLock) ? keyedTimeScaleLock.Handle : -1);
		}

		// Token: 0x06046184 RID: 287108 RVA: 0x0117DE0E File Offset: 0x0117C00E
		public void RemoveNormalizeTimeScaleLock(string key, bool refreshImmediately = false)
		{
			this.ResetKeyedTimeScaleLock(key, refreshImmediately);
			this.NormalizeTimeScaleLocks.Remove(key);
		}

		// Token: 0x06046185 RID: 287109 RVA: 0x0117DE25 File Offset: 0x0117C025
		public void AddForceTimeScale(float scale, string key, bool refreshImmediately = false, ETimeScaleSourceType sourceType = ETimeScaleSourceType.InnerForceTimeScale)
		{
			this.SetKeyedTimeScaleLock(key, sourceType, scale, refreshImmediately, false);
		}

		// Token: 0x06046186 RID: 287110 RVA: 0x0117DE33 File Offset: 0x0117C033
		public void RemoveForceTimeScale(string key, bool refreshImmediately = false)
		{
			this.ResetKeyedTimeScaleLock(key, refreshImmediately);
		}

		// Token: 0x06046187 RID: 287111 RVA: 0x0117DE3D File Offset: 0x0117C03D
		public void AddDelayLock(string key)
		{
			this.AddNormalizeTimeScaleLock(key, false);
		}

		// Token: 0x06046188 RID: 287112 RVA: 0x0117DE47 File Offset: 0x0117C047
		public void RemoveDelayLock(string key)
		{
			this.RemoveNormalizeTimeScaleLock(key, false);
		}

		// Token: 0x06046189 RID: 287113 RVA: 0x0117DE54 File Offset: 0x0117C054
		public float GetTopForeverTimeScale(ESourceEffectGroup? effectGroup = null)
		{
			ForeverTimeScale topForeverTimeScaleConfig = this.GetTopForeverTimeScaleConfig(effectGroup);
			if (topForeverTimeScaleConfig == null)
			{
				return 1f;
			}
			return topForeverTimeScaleConfig.TimeDilation;
		}

		// Token: 0x0604618A RID: 287114 RVA: 0x0117DE78 File Offset: 0x0117C078
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

		// Token: 0x0604618B RID: 287115 RVA: 0x0117DEC0 File Offset: 0x0117C0C0
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

		// Token: 0x0604618C RID: 287116 RVA: 0x0117DF2C File Offset: 0x0117C12C
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

		// Token: 0x0604618D RID: 287117 RVA: 0x0117E038 File Offset: 0x0117C238
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			PawnTimeScaleComponent pawnTimeScaleComponent = (PawnTimeScaleComponent)componentTemplate;
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (pawnTimeScaleComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("HitComp"))
			{
				if (pawnTimeScaleComponent.HitComp == null)
				{
					this.HitComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterHitComponent>(this.HitComp), "HitComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TimeScaleInternal"))
			{
				this.TimeScaleInternal = pawnTimeScaleComponent.TimeScaleInternal;
			}
			if (base.CanResetComponentProperty("DisableHandle"))
			{
				this.DisableHandle = pawnTimeScaleComponent.DisableHandle;
			}
			if (base.CanResetComponentProperty("FreezeTimeScaleInternal"))
			{
				this.FreezeTimeScaleInternal = pawnTimeScaleComponent.FreezeTimeScaleInternal;
			}
			if (base.CanResetComponentProperty("BulletHitDiscount"))
			{
				this.BulletHitDiscount = pawnTimeScaleComponent.BulletHitDiscount;
			}
			if (base.CanResetComponentProperty("TimeScaleList") && pawnTimeScaleComponent.TimeScaleList != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<PriorityQueue<TimeScale>>(this.TimeScaleList), "TimeScaleList"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TimeScaleMap") && pawnTimeScaleComponent.TimeScaleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, TimeScale>>(this.TimeScaleMap), "TimeScaleMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("TimeScaleId"))
			{
				this.TimeScaleId = pawnTimeScaleComponent.TimeScaleId;
			}
			if (base.CanResetComponentProperty("ForeverTimeScaleLogicView") && pawnTimeScaleComponent.ForeverTimeScaleLogicView != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<PriorityQueue<ForeverTimeScale>>(this.ForeverTimeScaleLogicView), "ForeverTimeScaleLogicView"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ForeverTimeScaleViewOnly") && pawnTimeScaleComponent.ForeverTimeScaleViewOnly != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<PriorityQueue<ForeverTimeScale>>(this.ForeverTimeScaleViewOnly), "ForeverTimeScaleViewOnly"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("ForeverTimeScaleMap") && pawnTimeScaleComponent.ForeverTimeScaleMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, ForeverTimeScale>>(this.ForeverTimeScaleMap), "ForeverTimeScaleMap"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("KeyedTimeScaleLocks") && pawnTimeScaleComponent.KeyedTimeScaleLocks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, PawnTimeScaleComponent.KeyedTimeScaleLock>>(this.KeyedTimeScaleLocks), "KeyedTimeScaleLocks"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("PauseLocks"))
			{
				if (pawnTimeScaleComponent.PauseLocks == null)
				{
					this.PauseLocks = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, int>>(this.PauseLocks), "PauseLocks"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("NormalizeTimeScaleLocks"))
			{
				if (pawnTimeScaleComponent.NormalizeTimeScaleLocks == null)
				{
					this.NormalizeTimeScaleLocks = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, int>>(this.NormalizeTimeScaleLocks), "NormalizeTimeScaleLocks"))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0604618E RID: 287118 RVA: 0x0117E2D0 File Offset: 0x0117C4D0
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

		// Token: 0x0604618F RID: 287119 RVA: 0x0117E3B4 File Offset: 0x0117C5B4
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

		// Token: 0x04024B6B RID: 150379
		private const float LIMIT_SCALE = 0f;

		// Token: 0x04024B6C RID: 150380
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ESourceEffectGroup, List<ETimeScaleSourceType>> sourceEffectGroup;

		// Token: 0x04024B6D RID: 150381
		[StaticVariableRuleIgnore]
		public static readonly Dictionary<ETimeScaleSourceGroup, List<ETimeScaleSourceType>> sourceTypeGroup;

		// Token: 0x04024B6E RID: 150382
		[Nullable(2)]
		protected BaseActorComponent ActorComp;

		// Token: 0x04024B6F RID: 150383
		[Nullable(2)]
		private CharacterHitComponent HitComp;

		// Token: 0x04024B70 RID: 150384
		protected float TimeScaleInternal = 1f;

		// Token: 0x04024B71 RID: 150385
		protected int? DisableHandle;

		// Token: 0x04024B72 RID: 150386
		protected float FreezeTimeScaleInternal = 1f;

		// Token: 0x04024B73 RID: 150387
		private float BulletHitDiscount = 1f;

		// Token: 0x04024B74 RID: 150388
		protected readonly PriorityQueue<TimeScale> TimeScaleList;

		// Token: 0x04024B75 RID: 150389
		protected readonly Dictionary<int, TimeScale> TimeScaleMap;

		// Token: 0x04024B76 RID: 150390
		private int TimeScaleId;

		// Token: 0x04024B77 RID: 150391
		protected readonly PriorityQueue<ForeverTimeScale> ForeverTimeScaleLogicView;

		// Token: 0x04024B78 RID: 150392
		protected readonly PriorityQueue<ForeverTimeScale> ForeverTimeScaleViewOnly;

		// Token: 0x04024B79 RID: 150393
		protected readonly Dictionary<int, ForeverTimeScale> ForeverTimeScaleMap;

		// Token: 0x04024B7A RID: 150394
		private readonly Dictionary<string, PawnTimeScaleComponent.KeyedTimeScaleLock> KeyedTimeScaleLocks;

		// Token: 0x04024B7B RID: 150395
		protected Dictionary<string, int> PauseLocks;

		// Token: 0x04024B7C RID: 150396
		protected Dictionary<string, int> NormalizeTimeScaleLocks;

		// Token: 0x0200CE34 RID: 52788
		[NullableContext(0)]
		private class KeyedTimeScaleLock
		{
			// Token: 0x0403E1A2 RID: 254370
			public int Handle;

			// Token: 0x0403E1A3 RID: 254371
			public float Scale;

			// Token: 0x0403E1A4 RID: 254372
			public ETimeScaleSourceType SourceType;

			// Token: 0x0403E1A5 RID: 254373
			public bool NeedImmuneCheck;
		}

		// Token: 0x0200CE35 RID: 52789
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0403E1A6 RID: 254374
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<TimeScale> <0>__CompareScalePriority;

			// Token: 0x0403E1A7 RID: 254375
			[Nullable(new byte[]
			{
				0,
				1
			})]
			public static Comparison<ForeverTimeScale> <1>__CompareScalePriority;
		}
	}
}
