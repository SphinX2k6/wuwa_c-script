using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02003094 RID: 12436
[NullableContext(1)]
[Nullable(0)]
public class CharacterTimeScaleComponent : PawnTimeScaleComponent
{
	// Token: 0x0601A93B RID: 108859 RVA: 0x00721794 File Offset: 0x0071F994
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.IsInSpecialMap = EffectAudioController.Instance.CheckInSpecialInstanceDungeon();
		return true;
	}

	// Token: 0x0601A93C RID: 108860 RVA: 0x007217B4 File Offset: 0x0071F9B4
	protected override bool IsTimescaleValid(TimeScale timescale, float currentTime)
	{
		GameModeModel instance = GameModeModel.Instance;
		if (instance != null && instance.IsMulti)
		{
			ETimeScaleSourceType sourceType = timescale.SourceType;
			if (sourceType - ETimeScaleSourceType.Counter > 4)
			{
				return false;
			}
		}
		return base.IsTimescaleValid(timescale, currentTime);
	}

	// Token: 0x0601A93D RID: 108861 RVA: 0x007217EC File Offset: 0x0071F9EC
	protected override void OnTick(float delta)
	{
		float num = 1f;
		ETimeScaleSourceType p = ETimeScaleSourceType.DefaultTimeScale;
		float num2 = 1f;
		while (!this.TimeScaleList.Empty)
		{
			TimeScale top = this.TimeScaleList.Top;
			if (top == null)
			{
				break;
			}
			if (this.IsTimescaleValid(top, delta))
			{
				num = top.CalculateTimeScale();
				p = top.SourceType;
				num2 = ((top.EndTime - top.StartTime >= 0.800000011920929) ? num : this.LastAkCompTimeScale);
				break;
			}
			this.TimeScaleMap.Remove(top.Id);
			this.TimeScaleList.Pop();
		}
		BaseDeathComponent component = base.Entity.GetComponent<BaseDeathComponent>();
		if (this.ActorComp != null && !this.ActorComp.IsMoveAutonomousProxy && (component == null || !component.IsDead()))
		{
			num = this.MoveSyncTimeScale;
			num2 = this.MoveSyncTimeScale;
		}
		this.FreezeTimeScaleInternal = num;
		float topForeverTimeScale = base.GetTopForeverTimeScale(null);
		num *= topForeverTimeScale;
		float num3 = num2 * base.Entity.TimeDilation * CharacterModel.Instance.SelfCenteredTimeDilation * topForeverTimeScale;
		if (num3 != this.LastAkTimeScale)
		{
			BaseActorComponent actorComp = this.ActorComp;
			AActor aactor = (actorComp != null) ? actorComp.Owner : null;
			if (aactor != null)
			{
				if (!this.IsInSpecialMap)
				{
					AudioSystem.Instance.SetRtpcValue("entity_time_scale_combat", num3, new SetRtpcValueArgs?(new SetRtpcValueArgs
					{
						Actor = aactor
					}));
				}
				if (num3 < 0.0625f && this.LastAkTimeScale >= 0.0625f)
				{
					AudioSystem.Instance.PostEvent("time_scale_pause", aactor, null);
				}
				else if (num3 >= 0.0625f && this.LastAkTimeScale < 0.0625f)
				{
					AudioSystem.Instance.PostEvent("time_scale_resume", aactor, null);
				}
			}
		}
		this.LastAkTimeScale = num3;
		this.LastAkCompTimeScale = num2;
		if (num != this.TimeScaleInternal)
		{
			this.TimeScaleInternal = num;
			EventSystem.Instance.EmitWithTarget<float, ETimeScaleSourceType>(base.Entity, EEventName.CharBeHitTimeScale, num, p);
			base.Entity.SetTimeDilation(base.TimeDilation);
		}
	}

	// Token: 0x0601A93E RID: 108862 RVA: 0x00721A00 File Offset: 0x0071FC00
	public void SetMoveSyncTimeScale(float scale)
	{
		this.MoveSyncTimeScale = scale;
	}

	// Token: 0x0601A93F RID: 108863 RVA: 0x00721A0C File Offset: 0x0071FC0C
	[NullableContext(2)]
	public override int SetTimeScale(int priority, float timeDilation, UCurveFloat curve, float duration, ETimeScaleSourceType sourceType, bool needAddSceneItemTag = false, bool immuneSelfCenter = false)
	{
		CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
		SyncTimeScaleEffect syncTimeScaleEffect;
		if (component == null)
		{
			syncTimeScaleEffect = null;
		}
		else
		{
			ExtraEffectManager buffEffectManager = component.BuffEffectManager;
			syncTimeScaleEffect = ((buffEffectManager != null) ? buffEffectManager.FilterFirstById<SyncTimeScaleEffect>(EExtraEffectId.SyncTimeScaleEffect, null) : null);
		}
		SyncTimeScaleEffect syncTimeScaleEffect2 = syncTimeScaleEffect;
		if (syncTimeScaleEffect2 != null)
		{
			return syncTimeScaleEffect2.SetTimeScale(priority, timeDilation, curve, duration, sourceType, needAddSceneItemTag, immuneSelfCenter);
		}
		return base.SetTimeScale(priority, timeDilation, curve, duration, sourceType, needAddSceneItemTag, immuneSelfCenter);
	}

	// Token: 0x0601A940 RID: 108864 RVA: 0x00721A68 File Offset: 0x0071FC68
	public override void RemoveTimeScale(int id)
	{
		CharacterBuffComponent component = base.Entity.GetComponent<CharacterBuffComponent>();
		SyncTimeScaleEffect syncTimeScaleEffect;
		if (component == null)
		{
			syncTimeScaleEffect = null;
		}
		else
		{
			ExtraEffectManager buffEffectManager = component.BuffEffectManager;
			syncTimeScaleEffect = ((buffEffectManager != null) ? buffEffectManager.FilterFirstById<SyncTimeScaleEffect>(EExtraEffectId.SyncTimeScaleEffect, null) : null);
		}
		SyncTimeScaleEffect syncTimeScaleEffect2 = syncTimeScaleEffect;
		if (syncTimeScaleEffect2 != null)
		{
			syncTimeScaleEffect2.RemoveTimeScale(id, true);
			return;
		}
		base.RemoveTimeScale(id);
	}

	// Token: 0x0601A941 RID: 108865 RVA: 0x00721AB0 File Offset: 0x0071FCB0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterTimeScaleComponent characterTimeScaleComponent = (CharacterTimeScaleComponent)componentTemplate;
		if (base.CanResetComponentProperty("LastAkTimeScale"))
		{
			this.LastAkTimeScale = characterTimeScaleComponent.LastAkTimeScale;
		}
		if (base.CanResetComponentProperty("LastAkCompTimeScale"))
		{
			this.LastAkCompTimeScale = characterTimeScaleComponent.LastAkCompTimeScale;
		}
		if (base.CanResetComponentProperty("MoveSyncTimeScale"))
		{
			this.MoveSyncTimeScale = characterTimeScaleComponent.MoveSyncTimeScale;
		}
		if (base.CanResetComponentProperty("TimeStopEntitySet"))
		{
			if (characterTimeScaleComponent.TimeStopEntitySet == null)
			{
				this.TimeStopEntitySet = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityHandle>(this.TimeStopEntitySet), "TimeStopEntitySet"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsInSpecialMap"))
		{
			this.IsInSpecialMap = characterTimeScaleComponent.IsInSpecialMap;
		}
		return true;
	}

	// Token: 0x0400CC78 RID: 52344
	private const float AUDIO_SCALE_ENABLE_THRESHOLD = 0.8f;

	// Token: 0x0400CC79 RID: 52345
	private const float AUDIO_SCALE_PAUSE_THRESHOLD = 0.0625f;

	// Token: 0x0400CC7A RID: 52346
	public float LastAkTimeScale = 1f;

	// Token: 0x0400CC7B RID: 52347
	public float LastAkCompTimeScale = 1f;

	// Token: 0x0400CC7C RID: 52348
	private float MoveSyncTimeScale = 1f;

	// Token: 0x0400CC7D RID: 52349
	public HashSet<EntityHandle> TimeStopEntitySet = new HashSet<EntityHandle>();

	// Token: 0x0400CC7E RID: 52350
	private bool IsInSpecialMap;
}
