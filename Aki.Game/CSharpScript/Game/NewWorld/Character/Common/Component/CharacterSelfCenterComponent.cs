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
	// Token: 0x02006337 RID: 25399
	[NullableContext(2)]
	[Nullable(0)]
	public class CharacterSelfCenterComponent : EntityComponent
	{
		// Token: 0x170074CD RID: 29901
		// (get) Token: 0x0603D89E RID: 252062 RVA: 0x011D1D44 File Offset: 0x011CFF44
		public float SelfCenterTimeDilation
		{
			get
			{
				return this.SelfCenterTimeDilationInternal;
			}
		}

		// Token: 0x0603D89F RID: 252063 RVA: 0x011D1D4C File Offset: 0x011CFF4C
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

		// Token: 0x0603D8A0 RID: 252064 RVA: 0x011D1D95 File Offset: 0x011CFF95
		private void OnRoleGoDownFinish()
		{
			this.ClearEffect();
		}

		// Token: 0x0603D8A1 RID: 252065 RVA: 0x011D1DA0 File Offset: 0x011CFFA0
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

		// Token: 0x0603D8A2 RID: 252066 RVA: 0x011D1ECC File Offset: 0x011D00CC
		protected override bool OnEnd()
		{
			this.ClearEffect();
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnCharacterSetMaster, new Action<int>(this.OnCharacterSetMaster));
			EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.OnRoleGoDownFinish, new Action(this.OnRoleGoDownFinish));
			EventSystem.Instance.Remove(EEventName.OnSwitchSelfCenteredMode, new Action<ESelfCenteredMode, float>(this.InitEntityBornDilation));
			return true;
		}

		// Token: 0x0603D8A3 RID: 252067 RVA: 0x011D1F40 File Offset: 0x011D0140
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

		// Token: 0x0603D8A4 RID: 252068 RVA: 0x011D1FB8 File Offset: 0x011D01B8
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

		// Token: 0x0603D8A5 RID: 252069 RVA: 0x011D2110 File Offset: 0x011D0310
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

		// Token: 0x0603D8A6 RID: 252070 RVA: 0x011D2150 File Offset: 0x011D0350
		public void RemoveSelfBeHitTimeDilation()
		{
			CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
			if (timeScaleComp != null)
			{
				timeScaleComp.RemoveForeverTimeScale(this.SelfBeHitTimeScaleId, false);
			}
			this.SelfBeHitTimeScaleId = 0;
		}

		// Token: 0x0603D8A7 RID: 252071 RVA: 0x011D2174 File Offset: 0x011D0374
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

		// Token: 0x0603D8A8 RID: 252072 RVA: 0x011D2204 File Offset: 0x011D0404
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

		// Token: 0x0603D8A9 RID: 252073 RVA: 0x011D2269 File Offset: 0x011D0469
		public void RemoveEffect(int effectHandle)
		{
			if (!this.CheckValid())
			{
				return;
			}
			this.ToRemoveEffectHandleSet.Add(effectHandle);
		}

		// Token: 0x0603D8AA RID: 252074 RVA: 0x011D2284 File Offset: 0x011D0484
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

		// Token: 0x0603D8AB RID: 252075 RVA: 0x011D231C File Offset: 0x011D051C
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

		// Token: 0x0603D8AC RID: 252076 RVA: 0x011D2430 File Offset: 0x011D0630
		private bool CheckValid()
		{
			return this.Inited;
		}

		// Token: 0x0603D8AD RID: 252077 RVA: 0x011D2438 File Offset: 0x011D0638
		[NullableContext(1)]
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterSelfCenterComponent characterSelfCenterComponent = (CharacterSelfCenterComponent)componentTemplate;
			if (characterSelfCenterComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
			if (characterSelfCenterComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (characterSelfCenterComponent.TimeScaleComp == null)
			{
				this.TimeScaleComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimeScaleComp), "TimeScaleComp"))
			{
				return false;
			}
			if (characterSelfCenterComponent.FrozenComp == null)
			{
				this.FrozenComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FrozenComp), "FrozenComp"))
			{
				return false;
			}
			if (characterSelfCenterComponent.FollowComp == null)
			{
				this.FollowComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FollowComp), "FollowComp"))
			{
				return false;
			}
			if (characterSelfCenterComponent.PawnTimeScaleComp == null)
			{
				this.PawnTimeScaleComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PawnTimeScaleComp), "PawnTimeScaleComp"))
			{
				return false;
			}
			if (characterSelfCenterComponent.EffectHandleSet == null)
			{
				this.EffectHandleSet = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.EffectHandleSet), "EffectHandleSet"))
			{
				return false;
			}
			if (characterSelfCenterComponent.ToRemoveEffectHandleSet == null)
			{
				this.ToRemoveEffectHandleSet = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.ToRemoveEffectHandleSet), "ToRemoveEffectHandleSet"))
			{
				return false;
			}
			this.SelfCenterTimeDilationInternal = characterSelfCenterComponent.SelfCenterTimeDilationInternal;
			this.WithFollow = characterSelfCenterComponent.WithFollow;
			if (characterSelfCenterComponent.TimerHandle == null)
			{
				this.TimerHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimerHandle), "TimerHandle"))
			{
				return false;
			}
			this.SelfCenteredTimeScaleId = characterSelfCenterComponent.SelfCenteredTimeScaleId;
			this.SelfBeHitTimeScaleId = characterSelfCenterComponent.SelfBeHitTimeScaleId;
			this.Inited = characterSelfCenterComponent.Inited;
			return true;
		}

		// Token: 0x170074CE RID: 29902
		// (get) Token: 0x0603D8AE RID: 252078 RVA: 0x011D2617 File Offset: 0x011D0817
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074CF RID: 29903
		// (get) Token: 0x0603D8AF RID: 252079 RVA: 0x011D261A File Offset: 0x011D081A
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170074D0 RID: 29904
		// (get) Token: 0x0603D8B0 RID: 252080 RVA: 0x011D261D File Offset: 0x011D081D
		public override bool NeedChangeTimeDilationInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04020A4B RID: 133707
		private const int DEFAULT_BE_HIT_SELF_CENTER_DURATION = 200;

		// Token: 0x04020A4C RID: 133708
		private CreatureDataComponent CreatureDataComp;

		// Token: 0x04020A4D RID: 133709
		private CharacterActorComponent ActorComp;

		// Token: 0x04020A4E RID: 133710
		private CharacterTimeScaleComponent TimeScaleComp;

		// Token: 0x04020A4F RID: 133711
		private BaseFrozenComponent FrozenComp;

		// Token: 0x04020A50 RID: 133712
		private CharacterFollowComponent FollowComp;

		// Token: 0x04020A51 RID: 133713
		private PawnTimeScaleComponent PawnTimeScaleComp;

		// Token: 0x04020A52 RID: 133714
		private HashSet<int> EffectHandleSet;

		// Token: 0x04020A53 RID: 133715
		private HashSet<int> ToRemoveEffectHandleSet;

		// Token: 0x04020A54 RID: 133716
		private float SelfCenterTimeDilationInternal = 1f;

		// Token: 0x04020A55 RID: 133717
		private bool WithFollow;

		// Token: 0x04020A56 RID: 133718
		private TimerHandle TimerHandle;

		// Token: 0x04020A57 RID: 133719
		private int SelfCenteredTimeScaleId;

		// Token: 0x04020A58 RID: 133720
		private int SelfBeHitTimeScaleId;

		// Token: 0x04020A59 RID: 133721
		private bool Inited;
	}
}
