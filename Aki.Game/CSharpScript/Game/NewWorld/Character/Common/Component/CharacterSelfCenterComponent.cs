using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Utils;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070D3 RID: 28883
	[NullableContext(2)]
	[Nullable(0)]
	public class CharacterSelfCenterComponent : EntityComponent
	{
		// Token: 0x17009CB0 RID: 40112
		// (get) Token: 0x0604679E RID: 288670 RVA: 0x011B2BDB File Offset: 0x011B0DDB
		public float SelfCenterTimeDilation
		{
			get
			{
				return this.SelfCenterTimeDilationInternal;
			}
		}

		// Token: 0x0604679F RID: 288671 RVA: 0x011B2BE4 File Offset: 0x011B0DE4
		private void OnCharacterSetMaster(int masterId)
		{
			CharacterSelfCenterComponent component = EntitySystem.Instance.GetComponent<CharacterSelfCenterComponent>(masterId);
			if (component != null && component.WithFollow)
			{
				CharacterTimeScaleComponent timeScaleComp = component.TimeScaleComp;
				float timeDilation = (timeScaleComp != null) ? timeScaleComp.GetForeverTimeScale(component.SelfCenteredTimeScaleId) : 1f;
				this.SetSelfCenterTimeDilation(timeDilation, true);
			}
		}

		// Token: 0x060467A0 RID: 288672 RVA: 0x011B2C2D File Offset: 0x011B0E2D
		private void OnRoleGoDownFinish()
		{
			this.ClearEffect();
		}

		// Token: 0x060467A1 RID: 288673 RVA: 0x011B2C38 File Offset: 0x011B0E38
		protected override bool OnStart()
		{
			this.Inited = true;
			this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
			this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
			this.TimeScaleComp = base.Entity.GetComponent<CharacterTimeScaleComponent>();
			this.FollowComp = base.Entity.GetComponent<CharacterFollowComponent>();
			this.FrozenComp = base.Entity.GetComponent<BaseFrozenComponent>();
			this.PawnTimeScaleComp = base.Entity.GetComponent<PawnTimeScaleComponent>();
			this.EffectHandleSet = new HashSet<int>();
			this.ToRemoveEffectHandleSet = new HashSet<int>();
			CharacterModel instance = CharacterModel.Instance;
			if (instance != null && instance.EnabledSelfCentered && CharacterModel.Instance.SelfCenteredMode == ESelfCenteredMode.Skill)
			{
				this.InitEntityBornDilation(CharacterModel.Instance.SelfCenteredMode, CharacterModel.Instance.SelfCenteredTimeDilation);
			}
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnCharacterSetMaster, new Action<int>(this.OnCharacterSetMaster));
			EventSystem.Instance.AddWithTarget(base.Entity, EEventName.OnRoleGoDownFinish, new Action(this.OnRoleGoDownFinish));
			EventSystem.Instance.Add(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.InitEntityBornDilation));
			return true;
		}

		// Token: 0x060467A2 RID: 288674 RVA: 0x011B2D64 File Offset: 0x011B0F64
		protected override bool OnEnd()
		{
			this.ClearEffect();
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnCharacterSetMaster, new Action<int>(this.OnCharacterSetMaster));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnRoleGoDownFinish, new Action(this.OnRoleGoDownFinish));
			EventSystem.Instance.Remove(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.InitEntityBornDilation));
			return true;
		}

		// Token: 0x060467A3 RID: 288675 RVA: 0x011B2DD8 File Offset: 0x011B0FD8
		protected void InitEntityBornDilation(ESelfCenteredMode selfCenteredMode, float globalTimeDilation)
		{
			if (this.ActorComp.CreatureData.GetEntityType() == EEntityType.Monster)
			{
				float buffBaseForeverTimeScale = 0f;
				if (selfCenteredMode == ESelfCenteredMode.Skill)
				{
					buffBaseForeverTimeScale = (MathUtils.Instance.IsNearlyEqual((double)globalTimeDilation, 1.0, null) ? 0f : ConfigCommonParamById.GetFloatConfig("MonsterSlowTimeDilation").GetValueOrDefault());
				}
				BaseFrozenComponent frozenComp = this.FrozenComp;
				if (frozenComp == null)
				{
					return;
				}
				frozenComp.SetBuffBaseForeverTimeScale(buffBaseForeverTimeScale);
			}
		}

		// Token: 0x060467A4 RID: 288676 RVA: 0x011B2E50 File Offset: 0x011B1050
		public void SetSelfCenterTimeDilation(float timeDilation, bool withFollow = true)
		{
			this.SelfCenterTimeDilationInternal = timeDilation;
			if (this.SelfCenteredTimeScaleId > 0)
			{
				CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
				if (timeScaleComp != null)
				{
					timeScaleComp.RemoveForeverTimeScale(this.SelfCenteredTimeScaleId, false);
				}
			}
			CharacterTimeScaleComponent timeScaleComp2 = this.TimeScaleComp;
			this.SelfCenteredTimeScaleId = ((timeScaleComp2 != null) ? timeScaleComp2.SetForeverTimeScale(ETimeScaleSourceType.SelfCentered, timeDilation, 0, true) : 0);
			if (withFollow)
			{
				CharacterFollowComponent followComp = this.FollowComp;
				List<int> list = (followComp != null) ? followComp.AttributeSharerIds : null;
				if (list != null)
				{
					foreach (int id in list)
					{
						CharacterSelfCenterComponent component = EntitySystem.Instance.GetComponent<CharacterSelfCenterComponent>(id);
						if (component != null)
						{
							component.SetSelfCenterTimeDilation(timeDilation, withFollow);
						}
					}
				}
				IList<long> customServerEntityIds = this.CreatureDataComp.CustomServerEntityIds;
				if (customServerEntityIds.Count > 0)
				{
					foreach (long creatureDataId in customServerEntityIds)
					{
						CharacterSelfCenterComponent component2 = EntitySystem.Instance.GetComponent<CharacterSelfCenterComponent>(CreatureModel.Instance.GetEntityId(creatureDataId));
						if (component2 != null)
						{
							component2.SetSelfCenterTimeDilation(timeDilation, withFollow);
						}
					}
				}
			}
			this.WithFollow = (!MathUtils.Instance.IsNearlyEqual((double)timeDilation, 1.0, null) && withFollow);
		}

		// Token: 0x060467A5 RID: 288677 RVA: 0x011B2FA8 File Offset: 0x011B11A8
		public void SetSelfBeHitTimeDilation(float timeDilation)
		{
			if (this.SelfBeHitTimeScaleId > 0)
			{
				CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
				if (timeScaleComp != null)
				{
					timeScaleComp.RemoveForeverTimeScale(this.SelfBeHitTimeScaleId, false);
				}
			}
			CharacterTimeScaleComponent timeScaleComp2 = this.TimeScaleComp;
			this.SelfBeHitTimeScaleId = ((timeScaleComp2 != null) ? timeScaleComp2.SetForeverTimeScale(ETimeScaleSourceType.SelfBeHit, timeDilation, 0, false) : 0);
		}

		// Token: 0x060467A6 RID: 288678 RVA: 0x011B2FE8 File Offset: 0x011B11E8
		public void RemoveSelfBeHitTimeDilation()
		{
			CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
			if (timeScaleComp != null)
			{
				timeScaleComp.RemoveForeverTimeScale(this.SelfBeHitTimeScaleId, false);
			}
			this.SelfBeHitTimeScaleId = 0;
		}

		// Token: 0x060467A7 RID: 288679 RVA: 0x011B300C File Offset: 0x011B120C
		public void SetBeHitTimeDilation(float timeDilation, float duration = 200f)
		{
			if (!MathUtils.Instance.IsNearlyEqual((double)this.SelfCenterTimeDilationInternal, 1.0, null))
			{
				return;
			}
			this.SetSelfBeHitTimeDilation(timeDilation);
			TimerHandle timerHandle = this.TimerHandle;
			if (timerHandle != null && timerHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
			this.TimerHandle = TimerSystem.Instance.Delay(delegate(float delta)
			{
				this.RemoveSelfBeHitTimeDilation();
			}, duration, null, null, true, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
		}

		// Token: 0x060467A8 RID: 288680 RVA: 0x011B309C File Offset: 0x011B129C
		public void AddEffect(int handleId)
		{
			if (!this.CheckValid() || !base.Active)
			{
				return;
			}
			if (!EffectSystem.Instance.IsValid(handleId))
			{
				return;
			}
			this.EffectHandleSet.Add(handleId);
			PawnTimeScaleComponent pawnTimeScaleComp = this.PawnTimeScaleComp;
			if (pawnTimeScaleComp != null && pawnTimeScaleComp.Valid)
			{
				EffectUtil.SetEffectTimeScale(handleId, this.PawnTimeScaleComp, this.PawnTimeScaleComp.TimeDilation, ETimeScaleType.FollowEntity);
			}
		}

		// Token: 0x060467A9 RID: 288681 RVA: 0x011B3101 File Offset: 0x011B1301
		public void RemoveEffect(int effectHandle)
		{
			if (!this.CheckValid())
			{
				return;
			}
			this.ToRemoveEffectHandleSet.Add(effectHandle);
		}

		// Token: 0x060467AA RID: 288682 RVA: 0x011B311C File Offset: 0x011B131C
		private void ClearEffect()
		{
			if (!this.CheckValid())
			{
				return;
			}
			if (this.EffectHandleSet.Count <= 0)
			{
				return;
			}
			foreach (int id in this.EffectHandleSet)
			{
				if (EffectSystem.Instance.IsValid(id))
				{
					EffectSystem.Instance.SetTimeScale(id, 1f, true);
				}
			}
			this.EffectHandleSet.Clear();
			this.ToRemoveEffectHandleSet.Clear();
		}

		// Token: 0x060467AB RID: 288683 RVA: 0x011B31B4 File Offset: 0x011B13B4
		protected override void OnChangeTimeDilation(float timeDilation)
		{
			if (!this.CheckValid())
			{
				return;
			}
			if (this.EffectHandleSet.Count <= 0)
			{
				return;
			}
			foreach (int num in this.EffectHandleSet)
			{
				if (!EffectSystem.Instance.IsValid(num))
				{
					this.ToRemoveEffectHandleSet.Add(num);
				}
				else
				{
					PawnTimeScaleComponent pawnTimeScaleComp = this.PawnTimeScaleComp;
					if (pawnTimeScaleComp != null && pawnTimeScaleComp.Valid)
					{
						EffectUtil.SetEffectTimeScale(num, this.PawnTimeScaleComp, this.PawnTimeScaleComp.TimeDilation, ETimeScaleType.FollowEntity);
					}
					else
					{
						EffectSystem.Instance.SetTimeScale(num, 1f, true);
					}
				}
			}
			foreach (int item in this.ToRemoveEffectHandleSet)
			{
				this.EffectHandleSet.Remove(item);
			}
			this.ToRemoveEffectHandleSet.Clear();
		}

		// Token: 0x060467AC RID: 288684 RVA: 0x011B32C8 File Offset: 0x011B14C8
		private bool CheckValid()
		{
			return this.Inited;
		}

		// Token: 0x060467AD RID: 288685 RVA: 0x011B32D0 File Offset: 0x011B14D0
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterSelfCenterComponent characterSelfCenterComponent = (CharacterSelfCenterComponent)componentTemplate;
			if (base.CanResetComponentProperty("CreatureDataComp"))
			{
				if (characterSelfCenterComponent.CreatureDataComp == null)
				{
					this.CreatureDataComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (characterSelfCenterComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TimeScaleComp"))
			{
				if (characterSelfCenterComponent.TimeScaleComp == null)
				{
					this.TimeScaleComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterTimeScaleComponent>(this.TimeScaleComp), "TimeScaleComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FrozenComp"))
			{
				if (characterSelfCenterComponent.FrozenComp == null)
				{
					this.FrozenComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseFrozenComponent>(this.FrozenComp), "FrozenComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("FollowComp"))
			{
				if (characterSelfCenterComponent.FollowComp == null)
				{
					this.FollowComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterFollowComponent>(this.FollowComp), "FollowComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PawnTimeScaleComp"))
			{
				if (characterSelfCenterComponent.PawnTimeScaleComp == null)
				{
					this.PawnTimeScaleComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnTimeScaleComponent>(this.PawnTimeScaleComp), "PawnTimeScaleComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("EffectHandleSet"))
			{
				if (characterSelfCenterComponent.EffectHandleSet == null)
				{
					this.EffectHandleSet = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.EffectHandleSet), "EffectHandleSet"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ToRemoveEffectHandleSet"))
			{
				if (characterSelfCenterComponent.ToRemoveEffectHandleSet == null)
				{
					this.ToRemoveEffectHandleSet = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.ToRemoveEffectHandleSet), "ToRemoveEffectHandleSet"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SelfCenterTimeDilationInternal"))
			{
				this.SelfCenterTimeDilationInternal = characterSelfCenterComponent.SelfCenterTimeDilationInternal;
			}
			if (base.CanResetComponentProperty("WithFollow"))
			{
				this.WithFollow = characterSelfCenterComponent.WithFollow;
			}
			if (base.CanResetComponentProperty("TimerHandle"))
			{
				if (characterSelfCenterComponent.TimerHandle == null)
				{
					this.TimerHandle = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.TimerHandle), "TimerHandle"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("SelfCenteredTimeScaleId"))
			{
				this.SelfCenteredTimeScaleId = characterSelfCenterComponent.SelfCenteredTimeScaleId;
			}
			if (base.CanResetComponentProperty("SelfBeHitTimeScaleId"))
			{
				this.SelfBeHitTimeScaleId = characterSelfCenterComponent.SelfBeHitTimeScaleId;
			}
			if (base.CanResetComponentProperty("Inited"))
			{
				this.Inited = characterSelfCenterComponent.Inited;
			}
			return true;
		}

		// Token: 0x04024F0C RID: 151308
		private const int DEFAULT_BE_HIT_SELF_CENTER_DURATION = 200;

		// Token: 0x04024F0D RID: 151309
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04024F0E RID: 151310
		private CharacterActorComponent ActorComp;

		// Token: 0x04024F0F RID: 151311
		private CharacterTimeScaleComponent TimeScaleComp;

		// Token: 0x04024F10 RID: 151312
		private BaseFrozenComponent FrozenComp;

		// Token: 0x04024F11 RID: 151313
		private CharacterFollowComponent FollowComp;

		// Token: 0x04024F12 RID: 151314
		private PawnTimeScaleComponent PawnTimeScaleComp;

		// Token: 0x04024F13 RID: 151315
		private HashSet<int> EffectHandleSet;

		// Token: 0x04024F14 RID: 151316
		private HashSet<int> ToRemoveEffectHandleSet;

		// Token: 0x04024F15 RID: 151317
		private float SelfCenterTimeDilationInternal = 1f;

		// Token: 0x04024F16 RID: 151318
		private bool WithFollow;

		// Token: 0x04024F17 RID: 151319
		private TimerHandle TimerHandle;

		// Token: 0x04024F18 RID: 151320
		private int SelfCenteredTimeScaleId;

		// Token: 0x04024F19 RID: 151321
		private int SelfBeHitTimeScaleId;

		// Token: 0x04024F1A RID: 151322
		private bool Inited;
	}
}
