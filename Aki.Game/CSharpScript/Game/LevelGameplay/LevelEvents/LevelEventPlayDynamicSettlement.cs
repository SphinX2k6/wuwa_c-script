using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using AkiClient.Game.Aki.Character.Input.Enum;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B4D RID: 27469
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelEventPlayDynamicSettlement : LevelEventBase
	{
		// Token: 0x060441A4 RID: 278948 RVA: 0x010C1D21 File Offset: 0x010BFF21
		public LevelEventPlayDynamicSettlement(int id) : base(id)
		{
		}

		// Token: 0x060441A5 RID: 278949 RVA: 0x010C1D3C File Offset: 0x010BFF3C
		[NullableContext(1)]
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060441A6 RID: 278950 RVA: 0x010C1D48 File Offset: 0x010BFF48
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			PlayDynamicSettlement playDynamicSettlement = inParams as PlayDynamicSettlement;
			if (playDynamicSettlement == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.CFT, "战斗结算镜头效果参数不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				base.FinishExecute(false, false, true);
				return;
			}
			IDynamicSettlementConfig dynamicSettlementConfig = playDynamicSettlement.DynamicSettlementConfig;
			this.SettlementType = dynamicSettlementConfig.Type;
			int num = 0;
			IBattleSettlement battleSettlement = dynamicSettlementConfig as IBattleSettlement;
			if (battleSettlement != null)
			{
				int? gamePlayCue = battleSettlement.GamePlayCue;
				if (gamePlayCue != null)
				{
					num = gamePlayCue.Value;
				}
			}
			this.ScreenEffectCueId = ((num > 0) ? num : 10010092);
			this.BgmType = ((battleSettlement != null) ? battleSettlement.BgmType : null);
			EventSystem.Instance.Add(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
			EventSystem.Instance.Add(EEventName.DisActiveBattleView, new Action(this.OnDisActiveBattleView));
			if (!UiManager.Instance.IsViewShow(EUiViewName.BattleView))
			{
				this.IsWaitBattleView = true;
				return;
			}
			this.PlayBattleSettlement();
		}

		// Token: 0x060441A7 RID: 278951 RVA: 0x010C1E44 File Offset: 0x010C0044
		private void OnActiveBattleView()
		{
			if (!this.IsWaitBattleView)
			{
				return;
			}
			this.IsWaitBattleView = false;
			if (this.Timer != null)
			{
				TimerSystem.Instance.Resume(this.Timer);
				BattleUiModel.Instance.IsInBattleSettlement = true;
				InputDistributeController.Instance.RefreshInputTag();
				EventSystem.Instance.Emit<bool>(EEventName.BattleSettlementStateChanged, true);
				return;
			}
			this.PlayBattleSettlement();
		}

		// Token: 0x060441A8 RID: 278952 RVA: 0x010C1EA8 File Offset: 0x010C00A8
		private void OnDisActiveBattleView()
		{
			if (this.IsWaitBattleView)
			{
				return;
			}
			this.IsWaitBattleView = true;
			if (this.Timer != null)
			{
				TimerSystem.Instance.Pause(this.Timer, null);
				BattleUiModel.Instance.IsInBattleSettlement = false;
				InputDistributeController.Instance.RefreshInputTag();
				EventSystem.Instance.Emit<bool>(EEventName.BattleSettlementStateChanged, false);
			}
		}

		// Token: 0x060441A9 RID: 278953 RVA: 0x010C1F08 File Offset: 0x010C0108
		private void PlayBattleSettlement()
		{
			BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.LevelEvent, new EBattleUiChild[]
			{
				EBattleUiChild.DamageView
			}, 2);
			BattleUiModel.Instance.IsInBattleSettlement = true;
			InputDistributeController.Instance.RefreshInputTag();
			CameraController.Instance.MainModel.FightCamera.LogicComponent.PlaySettlementCamera(this.SettlementType);
			UCurveFloat loadedAsset = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/Data/Fight/Curves/C_FightFinishSlowMo.C_FightFinishSlowMo");
			this.HandleTimeScale(loadedAsset);
			DamageUiController.Instance.SetDamageTimeScaleEnable(true);
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Entity entity = (baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null;
			if (entity != null)
			{
				if (this.ScreenEffectCueId != 0)
				{
					this.CueComp = entity.GetComponent<CharacterGameplayCueComponent>();
					if (this.CueComp != null)
					{
						this.ScreenEffectCueHandleId = this.CueComp.AddCue((long)this.ScreenEffectCueId, null);
					}
				}
				CharacterInputComponent component = entity.GetComponent<CharacterInputComponent>();
				if (component != null)
				{
					component.ClearInputCache(0, EInputState.None);
				}
			}
			EBattleSettlementBgmType? bgmType = this.BgmType;
			EBattleSettlementBgmType ebattleSettlementBgmType = EBattleSettlementBgmType.BattleSoundWave;
			if (bgmType.GetValueOrDefault() == ebattleSettlementBgmType & bgmType != null)
			{
				AudioSystem.Instance.SetState("plot_phantom_arena_battle_state", "ending", true);
			}
			else
			{
				string stringConfig = ConfigCommonParamById.GetStringConfig("BattleSettlementAudioEvent");
				if (stringConfig != null)
				{
					AudioSystem.Instance.PostEvent(stringConfig);
				}
			}
			EventSystem.Instance.Emit<bool>(EEventName.BattleSettlementStateChanged, true);
			EDynamicSettlementType settlementType = this.SettlementType;
			if (settlementType != EDynamicSettlementType.Battle)
			{
				if (settlementType != EDynamicSettlementType.SoaringChallenge)
				{
					return;
				}
				if (this.IsAsync)
				{
					EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
					base.FinishExecute(true, false, true);
					return;
				}
				this.OpenTimer();
			}
			else
			{
				this.OpenTimer();
				if (this.IsAsync)
				{
					base.FinishExecute(true, false, true);
					return;
				}
			}
		}

		// Token: 0x060441AA RID: 278954 RVA: 0x010C20AC File Offset: 0x010C02AC
		private void HandleTimeScale(UCurveFloat curve)
		{
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (((baseCharacter != null) ? baseCharacter.GetEntityNoBlueprint() : null) != null)
			{
				TsBaseCharacter baseCharacter2 = Global.BaseCharacter;
				global::Vector vector;
				if (baseCharacter2 == null)
				{
					vector = null;
				}
				else
				{
					CharacterActorComponent characterActorComponent = baseCharacter2.CharacterActorComponent;
					vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
				}
				global::Vector vector2 = vector;
				if (vector2 != null)
				{
					int value = ConfigCommonParamById.GetIntConfig("BattleSettlementTimeScaleRadius").Value;
					int value2 = ConfigCommonParamById.GetIntConfig("BattleSettlementTimeScalePriority").Value;
					float value3 = ConfigCommonParamById.GetFloatConfig("BattleSettlementTimeDilation").Value;
					float value4 = ConfigCommonParamById.GetFloatConfig("BattleSettlementTimeScaleDuration").Value;
					IReadOnlyList<EntityHandle> allEntities = CreatureModel.Instance.GetAllEntities();
					if (allEntities != null)
					{
						foreach (EntityHandle entityHandle in allEntities)
						{
							this.HandleEntityTimeScale(entityHandle, vector2, value, value2, value3, curve, value4);
						}
					}
					foreach (EntityHandle entityHandle2 in CreatureModel.Instance.DelayRemoveContainer.GetAllEntities())
					{
						this.HandleEntityTimeScale(entityHandle2, vector2, value, value2, value3, curve, value4);
					}
					BulletModel.Instance.SetAllBulletTimeScale(vector2, (float)value, value2, value3, curve, value4, true);
				}
			}
		}

		// Token: 0x060441AB RID: 278955 RVA: 0x010C2208 File Offset: 0x010C0408
		private void HandleEntityTimeScale(EntityHandle entityHandle, [Nullable(1)] global::Vector centerLocation, int radius, int priority, float timeDilation, UCurveFloat curve, float duration)
		{
			if (entityHandle == null || !entityHandle.Valid)
			{
				return;
			}
			WorldEntity entity = entityHandle.Entity;
			if (entity == null || !entity.IsInit)
			{
				return;
			}
			PawnTimeScaleComponent component = entity.GetComponent<PawnTimeScaleComponent>();
			if (component == null)
			{
				return;
			}
			BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
			global::Vector vector = (component2 != null) ? component2.ActorLocationProxy : null;
			if (vector == null)
			{
				return;
			}
			if (Math.Abs(vector.X - centerLocation.X) <= (double)radius && Math.Abs(vector.Y - centerLocation.Y) <= (double)radius && Math.Abs(vector.Z - centerLocation.Z) <= (double)radius)
			{
				int value = component.SetTimeScale(priority, timeDilation, curve, duration, ETimeScaleSourceType.BattleSettlement, false, false);
				this.EntityTimeScaleMap[entityHandle] = value;
			}
		}

		// Token: 0x060441AC RID: 278956 RVA: 0x010C22C3 File Offset: 0x010C04C3
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FlySettlementView)
			{
				return;
			}
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			this.OnTimerEnd();
		}

		// Token: 0x060441AD RID: 278957 RVA: 0x010C22F4 File Offset: 0x010C04F4
		private void OpenTimer()
		{
			float interval = ConfigCommonParamById.GetFloatConfig("BattleSettlementTime").Value * (float)TimeUtil.Instance.InverseMillisecond;
			this.Timer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.Timer = null;
				this.OnTimerEnd();
				base.FinishExecute(true, false, true);
			}, interval, null, null, true, 1f);
		}

		// Token: 0x060441AE RID: 278958 RVA: 0x010C2348 File Offset: 0x010C0548
		private void OnTimerEnd()
		{
			BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.LevelEvent, 2);
			BattleUiModel.Instance.IsInBattleSettlement = false;
			InputDistributeController.Instance.RefreshInputTag();
			EventSystem.Instance.Remove(EEventName.ActiveBattleView, new Action(this.OnActiveBattleView));
			EventSystem.Instance.Remove(EEventName.DisActiveBattleView, new Action(this.OnDisActiveBattleView));
			this.EntityTimeScaleMap.Clear();
			DamageUiController.Instance.SetDamageTimeScaleEnable(false);
			if (this.ScreenEffectCueHandleId != 0)
			{
				BaseGameplayCueComponent cueComp = this.CueComp;
				if (cueComp != null)
				{
					cueComp.RemoveCueByHandle((long)this.ScreenEffectCueHandleId);
				}
				this.ScreenEffectCueHandleId = 0;
				this.CueComp = null;
			}
			this.ScreenEffectCueId = 0;
			EventSystem.Instance.Emit<bool>(EEventName.BattleSettlementStateChanged, false);
		}

		// Token: 0x060441AF RID: 278959 RVA: 0x010C2410 File Offset: 0x010C0610
		public override void Release()
		{
			base.Release();
			if (this.Timer != null)
			{
				TimerSystem.Instance.Remove(this.Timer);
				this.Timer = null;
				this.OnTimerEnd();
			}
			EBattleSettlementBgmType? bgmType = this.BgmType;
			EBattleSettlementBgmType ebattleSettlementBgmType = EBattleSettlementBgmType.BattleSoundWave;
			if (bgmType.GetValueOrDefault() == ebattleSettlementBgmType & bgmType != null)
			{
				AudioSystem.Instance.SetState("plot_phantom_arena_battle_state", "none", true);
			}
		}

		// Token: 0x04023922 RID: 145698
		private TimerHandle Timer;

		// Token: 0x04023923 RID: 145699
		[Nullable(1)]
		private readonly Dictionary<EntityHandle, int> EntityTimeScaleMap = new Dictionary<EntityHandle, int>();

		// Token: 0x04023924 RID: 145700
		private bool IsWaitBattleView = true;

		// Token: 0x04023925 RID: 145701
		private int ScreenEffectCueId;

		// Token: 0x04023926 RID: 145702
		private int ScreenEffectCueHandleId;

		// Token: 0x04023927 RID: 145703
		private BaseGameplayCueComponent CueComp;

		// Token: 0x04023928 RID: 145704
		private EDynamicSettlementType SettlementType;

		// Token: 0x04023929 RID: 145705
		private EBattleSettlementBgmType? BgmType;
	}
}
