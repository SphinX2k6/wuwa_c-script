using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x020025EB RID: 9707
[NullableContext(1)]
[Nullable(0)]
public class CharacterTimeScaleComponent : PawnTimeScaleComponent
{
	// Token: 0x0601832B RID: 99115 RVA: 0x0074780C File Offset: 0x00745A0C
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.IsInSpecialMap = EffectAudioController.Instance.CheckInSpecialInstanceDungeon();
		return true;
	}

	// Token: 0x0601832C RID: 99116 RVA: 0x0074782C File Offset: 0x00745A2C
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

	// Token: 0x0601832D RID: 99117 RVA: 0x00747864 File Offset: 0x00745A64
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

	// Token: 0x0601832E RID: 99118 RVA: 0x00747A78 File Offset: 0x00745C78
	public void SetMoveSyncTimeScale(float scale)
	{
		this.MoveSyncTimeScale = scale;
	}

	// Token: 0x0601832F RID: 99119 RVA: 0x00747A84 File Offset: 0x00745C84
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

	// Token: 0x06018330 RID: 99120 RVA: 0x00747AE0 File Offset: 0x00745CE0
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

	// Token: 0x06018331 RID: 99121 RVA: 0x00747B28 File Offset: 0x00745D28
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterTimeScaleComponent characterTimeScaleComponent = (CharacterTimeScaleComponent)componentTemplate;
		this.LastAkTimeScale = characterTimeScaleComponent.LastAkTimeScale;
		this.LastAkCompTimeScale = characterTimeScaleComponent.LastAkCompTimeScale;
		this.MoveSyncTimeScale = characterTimeScaleComponent.MoveSyncTimeScale;
		if (characterTimeScaleComponent.TimeStopEntitySet == null)
		{
			this.TimeStopEntitySet = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityHandle>(this.TimeStopEntitySet), "TimeStopEntitySet"))
		{
			return false;
		}
		this.IsInSpecialMap = characterTimeScaleComponent.IsInSpecialMap;
		return true;
	}

	// Token: 0x170025F3 RID: 9715
	// (get) Token: 0x06018332 RID: 99122 RVA: 0x00747BA3 File Offset: 0x00745DA3
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025F4 RID: 9716
	// (get) Token: 0x06018333 RID: 99123 RVA: 0x00747BA6 File Offset: 0x00745DA6
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025F5 RID: 9717
	// (get) Token: 0x06018334 RID: 99124 RVA: 0x00747BA9 File Offset: 0x00745DA9
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D05B RID: 53339
	private const float AUDIO_SCALE_ENABLE_THRESHOLD = 0.8f;

	// Token: 0x0400D05C RID: 53340
	private const float AUDIO_SCALE_PAUSE_THRESHOLD = 0.0625f;

	// Token: 0x0400D05D RID: 53341
	public float LastAkTimeScale = 1f;

	// Token: 0x0400D05E RID: 53342
	public float LastAkCompTimeScale = 1f;

	// Token: 0x0400D05F RID: 53343
	private float MoveSyncTimeScale = 1f;

	// Token: 0x0400D060 RID: 53344
	public HashSet<EntityHandle> TimeStopEntitySet = new HashSet<EntityHandle>();

	// Token: 0x0400D061 RID: 53345
	private bool IsInSpecialMap;
}
