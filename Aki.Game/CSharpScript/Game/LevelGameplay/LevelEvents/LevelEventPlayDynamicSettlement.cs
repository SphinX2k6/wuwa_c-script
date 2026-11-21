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
	// Token: 0x02005CC5 RID: 23749
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelEventPlayDynamicSettlement : LevelEventBase
	{
		// Token: 0x0603A2F6 RID: 238326 RVA: 0x0106B8D5 File Offset: 0x01069AD5
		public LevelEventPlayDynamicSettlement(int id) : base(id)
		{
		}

		// Token: 0x0603A2F7 RID: 238327 RVA: 0x0106B8F0 File Offset: 0x01069AF0
		[NullableContext(1)]
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A2F8 RID: 238328 RVA: 0x0106B8FC File Offset: 0x01069AFC
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

		// Token: 0x0603A2F9 RID: 238329 RVA: 0x0106B9F8 File Offset: 0x01069BF8
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

		// Token: 0x0603A2FA RID: 238330 RVA: 0x0106BA5C File Offset: 0x01069C5C
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

		// Token: 0x0603A2FB RID: 238331 RVA: 0x0106BABC File Offset: 0x01069CBC
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

		// Token: 0x0603A2FC RID: 238332 RVA: 0x0106BC60 File Offset: 0x01069E60
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

		// Token: 0x0603A2FD RID: 238333 RVA: 0x0106BDBC File Offset: 0x01069FBC
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

		// Token: 0x0603A2FE RID: 238334 RVA: 0x0106BE77 File Offset: 0x0106A077
		private void OnOpenView(EUiViewName viewName, int viewId)
		{
			if (viewName != EUiViewName.FlySettlementView)
			{
				return;
			}
			EventSystem.Instance.Remove(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			this.OnTimerEnd();
		}

		// Token: 0x0603A2FF RID: 238335 RVA: 0x0106BEA8 File Offset: 0x0106A0A8
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

		// Token: 0x0603A300 RID: 238336 RVA: 0x0106BEFC File Offset: 0x0106A0FC
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

		// Token: 0x0603A301 RID: 238337 RVA: 0x0106BFC4 File Offset: 0x0106A1C4
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

		// Token: 0x0401EBC4 RID: 125892
		private TimerHandle Timer;

		// Token: 0x0401EBC5 RID: 125893
		[Nullable(1)]
		private readonly Dictionary<EntityHandle, int> EntityTimeScaleMap = new Dictionary<EntityHandle, int>();

		// Token: 0x0401EBC6 RID: 125894
		private bool IsWaitBattleView = true;

		// Token: 0x0401EBC7 RID: 125895
		private int ScreenEffectCueId;

		// Token: 0x0401EBC8 RID: 125896
		private int ScreenEffectCueHandleId;

		// Token: 0x0401EBC9 RID: 125897
		private BaseGameplayCueComponent CueComp;

		// Token: 0x0401EBCA RID: 125898
		private EDynamicSettlementType SettlementType;

		// Token: 0x0401EBCB RID: 125899
		private EBattleSettlementBgmType? BgmType;
	}
}
