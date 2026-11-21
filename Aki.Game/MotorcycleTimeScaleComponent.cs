using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x0200286F RID: 10351
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleTimeScaleComponent : PawnTimeScaleComponent
{
	// Token: 0x0601A3E4 RID: 107492 RVA: 0x0082131E File Offset: 0x0081F51E
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.IsInSpecialMap = EffectAudioController.Instance.CheckInSpecialInstanceDungeon();
		this.VehiclePerformComp = base.Entity.GetComponent<VehiclePerformComponent>();
		return true;
	}

	// Token: 0x0601A3E5 RID: 107493 RVA: 0x0082134C File Offset: 0x0081F54C
	protected override bool OnEnd()
	{
		return true;
	}

	// Token: 0x0601A3E6 RID: 107494 RVA: 0x00821350 File Offset: 0x0081F550
	protected override bool IsTimescaleValid(TimeScale timescale, float currentTime)
	{
		if (GameModeModel.Instance != null && GameModeModel.Instance.IsMulti)
		{
			ETimeScaleSourceType sourceType = timescale.SourceType;
			if (sourceType - ETimeScaleSourceType.Counter > 4)
			{
				return false;
			}
		}
		return base.IsTimescaleValid(timescale, currentTime);
	}

	// Token: 0x0601A3E7 RID: 107495 RVA: 0x00821388 File Offset: 0x0081F588
	protected override void OnTick(float delta)
	{
		float num = 1f;
		float num2 = 1f;
		float num3 = 1f;
		VehiclePerformComponent vehiclePerformComp = this.VehiclePerformComp;
		CharacterTimeScaleComponent characterTimeScaleComponent;
		if (vehiclePerformComp == null)
		{
			characterTimeScaleComponent = null;
		}
		else
		{
			Entity driver = vehiclePerformComp.Driver;
			characterTimeScaleComponent = ((driver != null) ? driver.GetComponent<CharacterTimeScaleComponent>() : null);
		}
		CharacterTimeScaleComponent characterTimeScaleComponent2 = characterTimeScaleComponent;
		if (characterTimeScaleComponent2 != null)
		{
			this.FreezeTimeScaleInternal = characterTimeScaleComponent2.FreezeTimeScale;
			num = characterTimeScaleComponent2.CurrentTimeScale;
			num2 = characterTimeScaleComponent2.LastAkCompTimeScale;
		}
		else
		{
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
					ETimeScaleSourceType sourceType = top.SourceType;
					num2 = ((top.EndTime - top.StartTime >= 0.800000011920929) ? num : this.LastAkCompTimeScale);
					break;
				}
				this.TimeScaleMap.Remove(top.Id);
				this.TimeScaleList.Pop();
			}
			float topForeverTimeScale = base.GetTopForeverTimeScale(null);
			this.FreezeTimeScaleInternal = num;
			num *= topForeverTimeScale;
			num3 = num2 * base.Entity.TimeDilation * CharacterModel.Instance.SelfCenteredTimeDilation * topForeverTimeScale;
		}
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
			base.Entity.SetTimeDilation(base.TimeDilation);
		}
	}

	// Token: 0x0601A3E8 RID: 107496 RVA: 0x00821590 File Offset: 0x0081F790
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleTimeScaleComponent motorcycleTimeScaleComponent = (MotorcycleTimeScaleComponent)componentTemplate;
		this.LastAkTimeScale = motorcycleTimeScaleComponent.LastAkTimeScale;
		this.LastAkCompTimeScale = motorcycleTimeScaleComponent.LastAkCompTimeScale;
		if (motorcycleTimeScaleComponent.VehiclePerformComp == null)
		{
			this.VehiclePerformComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehiclePerformComp), "VehiclePerformComp"))
		{
			return false;
		}
		this.IsInSpecialMap = motorcycleTimeScaleComponent.IsInSpecialMap;
		return true;
	}

	// Token: 0x17002AF1 RID: 10993
	// (get) Token: 0x0601A3E9 RID: 107497 RVA: 0x008215FF File Offset: 0x0081F7FF
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AF2 RID: 10994
	// (get) Token: 0x0601A3EA RID: 107498 RVA: 0x00821602 File Offset: 0x0081F802
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AF3 RID: 10995
	// (get) Token: 0x0601A3EB RID: 107499 RVA: 0x00821605 File Offset: 0x0081F805
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AF4 RID: 10996
	// (get) Token: 0x0601A3EC RID: 107500 RVA: 0x00821608 File Offset: 0x0081F808
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E673 RID: 58995
	private float LastAkTimeScale = 1f;

	// Token: 0x0400E674 RID: 58996
	private float LastAkCompTimeScale = 1f;

	// Token: 0x0400E675 RID: 58997
	[Nullable(2)]
	protected VehiclePerformComponent VehiclePerformComp;

	// Token: 0x0400E676 RID: 58998
	private bool IsInSpecialMap;
}
