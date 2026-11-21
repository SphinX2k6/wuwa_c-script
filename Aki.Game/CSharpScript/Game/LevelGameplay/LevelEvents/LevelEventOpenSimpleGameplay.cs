using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.BigStuffedDoll;
using CSharpScript.Game.LevelGamePlay.Cipher;
using CSharpScript.Game.LevelGamePlay.DollGrabMachine;
using CSharpScript.Game.LevelGamePlay.FindSunSprite;
using CSharpScript.Game.LevelGamePlay.FishingQte;
using CSharpScript.Game.LevelGamePlay.Hourglass;
using CSharpScript.Game.LevelGamePlay.ItemInspect;
using CSharpScript.Game.LevelGamePlay.LevelEvents.SimpleGameplay;
using CSharpScript.Game.LevelGamePlay.LevelPickControl;
using CSharpScript.Game.LevelGamePlay.LifePoint;
using CSharpScript.Game.LevelGamePlay.PianoGameplay;
using CSharpScript.Game.LevelGamePlay.ProjectPuzzle;
using CSharpScript.Game.LevelGamePlay.SceneInspection;
using CSharpScript.Game.LevelGamePlay.SeekTrace;
using CSharpScript.Game.LevelGamePlay.SignalDeviceControl;
using CSharpScript.Game.LevelGamePlay.TuningStand;
using CSharpScript.Game.LevelGamePlay.WriteLetter;
using CSharpScript.Game.Module.Interaction;
using CSharpScript.Game.Module.MusicalInstrument;
using CSharpScript.Game.Module.Sheriff;
using CSharpScript.Game.Module.WuwaGo.Controller;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CBF RID: 23743
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventOpenSimpleGameplay : LevelEventBase, ISimpleGameplayOpenHost
	{
		// Token: 0x17006E8D RID: 28301
		// (get) Token: 0x0603A2D0 RID: 238288 RVA: 0x01069ADB File Offset: 0x01067CDB
		// (set) Token: 0x0603A2D1 RID: 238289 RVA: 0x01069AE3 File Offset: 0x01067CE3
		public GeneralContext Context { get; set; } = new GeneralContext();

		// Token: 0x17006E8E RID: 28302
		// (get) Token: 0x0603A2D2 RID: 238290 RVA: 0x01069AEC File Offset: 0x01067CEC
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public Action<string> SetFinishSendSelfEvent
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				return new Action<string>(this.SetFinishSendSelfEventImpl);
			}
		}

		// Token: 0x17006E8F RID: 28303
		// (get) Token: 0x0603A2D3 RID: 238291 RVA: 0x01069AFA File Offset: 0x01067CFA
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public Action<string> SetFailSendSelfEvent
		{
			[return: Nullable(new byte[]
			{
				1,
				2
			})]
			get
			{
				return new Action<string>(this.SetFailSendSelfEventImpl);
			}
		}

		// Token: 0x17006E90 RID: 28304
		// (get) Token: 0x0603A2D4 RID: 238292 RVA: 0x01069B08 File Offset: 0x01067D08
		public Action<long> SetCreatureDataId
		{
			get
			{
				return new Action<long>(this.SetCreatureDataIdImpl);
			}
		}

		// Token: 0x17006E91 RID: 28305
		// (get) Token: 0x0603A2D5 RID: 238293 RVA: 0x01069B16 File Offset: 0x01067D16
		public Action FinishCallback
		{
			get
			{
				return new Action(this.FinishCallbackImpl);
			}
		}

		// Token: 0x17006E92 RID: 28306
		// (get) Token: 0x0603A2D6 RID: 238294 RVA: 0x01069B24 File Offset: 0x01067D24
		public Action<bool> FinishWithResultCallback
		{
			get
			{
				return new Action<bool>(this.FinishWithResultCallbackImpl);
			}
		}

		// Token: 0x0603A2D7 RID: 238295 RVA: 0x01069B32 File Offset: 0x01067D32
		[NullableContext(2)]
		private void SetFinishSendSelfEventImpl(string eventName)
		{
			this.FinishSendSelfEvent = eventName;
		}

		// Token: 0x0603A2D8 RID: 238296 RVA: 0x01069B3B File Offset: 0x01067D3B
		[NullableContext(2)]
		private void SetFailSendSelfEventImpl(string eventName)
		{
			this.FailSendSelfEvent = eventName;
		}

		// Token: 0x0603A2D9 RID: 238297 RVA: 0x01069B44 File Offset: 0x01067D44
		private void SetCreatureDataIdImpl(long id)
		{
			this.CreatureDataId = id;
		}

		// Token: 0x0603A2DA RID: 238298 RVA: 0x01069B4D File Offset: 0x01067D4D
		public LevelEventOpenSimpleGameplay(int id) : base(id)
		{
		}

		// Token: 0x0603A2DB RID: 238299 RVA: 0x01069B6C File Offset: 0x01067D6C
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			OpenSimpleGameplay openSimpleGameplay = inParams as OpenSimpleGameplay;
			if (openSimpleGameplay == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "参数不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int? num = null;
			EntityContext entityContext = context as EntityContext;
			if (entityContext != null)
			{
				num = entityContext.EntityId;
			}
			else
			{
				DynamicInteractContext dynamicInteractContext = context as DynamicInteractContext;
				if (dynamicInteractContext != null)
				{
					num = dynamicInteractContext.EntityId;
				}
			}
			IUiGame gameplayConfig = openSimpleGameplay.GameplayConfig;
			if ((gameplayConfig is ISignalDevice || gameplayConfig is ISignalDevice2 || gameplayConfig is ILifePoint || gameplayConfig is IFishingRoulette || gameplayConfig is ITuningStand || gameplayConfig is IItemInspection || gameplayConfig is ITraceTracing || gameplayConfig is IFindSunSpirit || gameplayConfig is IDaemonHack || gameplayConfig is IProjectorPuzzle || gameplayConfig is IProjectionMachine) && num == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "上下文不合法", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.Context = context;
			ISimpleGameplayOpenHandler simpleGameplayOpenHandler = SimpleGameplayHandlerRegistry.Open.Get(openSimpleGameplay.GameplayConfig.Type);
			if (simpleGameplayOpenHandler != null)
			{
				simpleGameplayOpenHandler.Open(openSimpleGameplay.GameplayConfig, openSimpleGameplay, this);
				return;
			}
			gameplayConfig = openSimpleGameplay.GameplayConfig;
			ICipherGameplay cipherGameplay = gameplayConfig as ICipherGameplay;
			if (cipherGameplay != null)
			{
				TsInteractionUtils.RegisterOpenViewName(EUiViewName.CipherView);
				this.OpenCipher(cipherGameplay.CipherId);
				return;
			}
			ISignalBreakGameplay signalBreakGameplay = gameplayConfig as ISignalBreakGameplay;
			if (signalBreakGameplay != null)
			{
				TsInteractionUtils.RegisterOpenViewName(EUiViewName.SignalDecodeView);
				UiManager.Instance.OpenView(EUiViewName.SignalDecodeView, signalBreakGameplay.SignalBreakId, null);
				return;
			}
			if (gameplayConfig is ISundialPuzzleGameplay)
			{
				TsInteractionUtils.RegisterOpenViewName(EUiViewName.SundialControlView);
				UiManager.Instance.OpenView(EUiViewName.SundialControlView, null, null);
				return;
			}
			ISignalDevice signalDevice = gameplayConfig as ISignalDevice;
			if (signalDevice != null)
			{
				this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
				Entity entity = EntitySystem.Instance.Get(num.Value);
				this.CreatureDataId = entity.GetComponent<CreatureDataComponent>().GetCreatureDataId();
				TsInteractionUtils.RegisterOpenViewName(EUiViewName.SignalDeviceView);
				SignalDeviceController.Instance.OpenGameplay(signalDevice.Config, this.FinishCallback);
				return;
			}
			ISignalDevice2 signalDevice2 = gameplayConfig as ISignalDevice2;
			if (signalDevice2 != null)
			{
				this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
				Entity entity2 = EntitySystem.Instance.Get(num.Value);
				this.CreatureDataId = entity2.GetComponent<CreatureDataComponent>().GetCreatureDataId();
				TsInteractionUtils.RegisterOpenViewName(EUiViewName.SignalDeviceChasingMoonView);
				SignalDeviceController.Instance.OpenGameplayChasingMoon(signalDevice2.Config, this.FinishCallback);
				return;
			}
			IMorseCode morseCode = gameplayConfig as IMorseCode;
			if (morseCode != null)
			{
				TsInteractionUtils.RegisterOpenViewName(EUiViewName.SignalDecodeView);
				SignalDecodeController.Instance.Open(morseCode.MorseCodeId);
				return;
			}
			IRenjuChess renjuChess = gameplayConfig as IRenjuChess;
			if (renjuChess != null)
			{
				LevelPickInteractController.Instance.EnterPickInteractModel(renjuChess, false);
				return;
			}
			ILifePoint lifePoint = gameplayConfig as ILifePoint;
			if (lifePoint != null)
			{
				LifePointView.Params param = new LifePointView.Params
				{
					Config = lifePoint,
					EntityId = num.Value,
					Callback = this.FinishCallback
				};
				this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
				Entity entity3 = EntitySystem.Instance.Get(num.Value);
				this.CreatureDataId = entity3.GetComponent<CreatureDataComponent>().GetCreatureDataId();
				TsInteractionUtils.RegisterOpenViewName(EUiViewName.LifePointView);
				UiManager.Instance.OpenView(EUiViewName.LifePointView, param, null);
				return;
			}
			IBrokenRock brokenRock = gameplayConfig as IBrokenRock;
			if (brokenRock == null)
			{
				if (gameplayConfig is IFishingRoulette)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					Entity entity4 = EntitySystem.Instance.Get(num.Value);
					this.CreatureDataId = entity4.GetComponent<CreatureDataComponent>().GetCreatureDataId();
					FishingQteController.Instance.OpenGameplay(entity4, delegate(bool success)
					{
						if (success)
						{
							TsInteractionUtils.RegisterOpenViewName(EUiViewName.FishingQteView);
						}
					});
					return;
				}
				if (gameplayConfig is IDaolingAuthentication)
				{
					TsInteractionUtils.RegisterOpenViewName(EUiViewName.LiuLiDaoLingView);
					UiManager.Instance.OpenView(EUiViewName.LiuLiDaoLingView, null, null);
					return;
				}
				IReigns reigns = gameplayConfig as IReigns;
				if (reigns != null)
				{
					TsInteractionUtils.RegisterOpenViewName(EUiViewName.KingShipMainView);
					IKingShipMainViewOpenData kingShipOpenData = KingShipUtil.GetKingShipOpenData(reigns.ReignsId);
					UiManager.Instance.OpenView(EUiViewName.KingShipLoadingView, kingShipOpenData, null);
					return;
				}
				ITuningStand tuningStand = gameplayConfig as ITuningStand;
				if (tuningStand != null)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					Entity entity5 = EntitySystem.Instance.Get(num.Value);
					this.CreatureDataId = entity5.GetComponent<CreatureDataComponent>().GetCreatureDataId();
					TsInteractionUtils.RegisterOpenViewName(EUiViewName.TuningStandView);
					TuningStandView.Params param2 = new TuningStandView.Params
					{
						Config = tuningStand,
						Cb = this.FinishCallback
					};
					UiManager.Instance.OpenView(EUiViewName.TuningStandView, param2, null);
					return;
				}
				IItemInspection itemInspection = gameplayConfig as IItemInspection;
				if (itemInspection != null)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					Entity entity6 = EntitySystem.Instance.Get(num.Value);
					this.CreatureDataId = entity6.GetComponent<CreatureDataComponent>().GetCreatureDataId();
					ItemInspectController instance = ItemInspectController.Instance;
					IItemInspection config = itemInspection;
					Action<EUiViewName> onBeforeOpenView;
					if ((onBeforeOpenView = LevelEventOpenSimpleGameplay.<>O.<0>__RegisterOpenViewName) == null)
					{
						onBeforeOpenView = (LevelEventOpenSimpleGameplay.<>O.<0>__RegisterOpenViewName = new Action<EUiViewName>(TsInteractionUtils.RegisterOpenViewName));
					}
					instance.OpenItemInspect(config, onBeforeOpenView, delegate(bool result)
					{
						if (result)
						{
							this.FinishCallback();
						}
					});
					return;
				}
				ISceneInspection sceneInspection = gameplayConfig as ISceneInspection;
				if (sceneInspection != null)
				{
					TsInteractionUtils.RegisterOpenViewName(EUiViewName.CheckInteractionView);
					CheckInteractionOpenParam param3 = new CheckInteractionOpenParam
					{
						Config = sceneInspection,
						Context = GeneralContext.Copy(context)
					};
					UiManager.Instance.OpenView(EUiViewName.CheckInteractionView, param3, null);
					return;
				}
				ITraceTracing traceTracing = gameplayConfig as ITraceTracing;
				if (traceTracing != null)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					Entity entity7 = EntitySystem.Instance.Get(num.Value);
					this.CreatureDataId = entity7.GetComponent<CreatureDataComponent>().GetCreatureDataId();
					TsInteractionUtils.RegisterOpenViewName(EUiViewName.SeekTraceView);
					SeekTraceController.OpenSeekTrace(traceTracing, num.Value, delegate(bool result)
					{
						if (result)
						{
							this.FinishCallback();
						}
					});
					return;
				}
				IFindSunSpirit findSunSpirit = gameplayConfig as IFindSunSpirit;
				if (findSunSpirit != null)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					this.FailSendSelfEvent = openSimpleGameplay.FailSendSelfEvent;
					CreatureDataComponent component = EntitySystem.Instance.Get(num.Value).GetComponent<CreatureDataComponent>();
					this.CreatureDataId = component.GetCreatureDataId();
					TsInteractionUtils.RegisterOpenViewName(EUiViewName.FindSunSpiritView);
					FindSunSpiritController.Instance.StartFindSunSpirit(findSunSpirit, this.FinishWithResultCallback, component.GetPbDataId());
					return;
				}
				IDaemonHack daemonHack = gameplayConfig as IDaemonHack;
				if (daemonHack != null)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					this.FailSendSelfEvent = openSimpleGameplay.FailSendSelfEvent;
					Entity entity8 = EntitySystem.Instance.Get(num.Value);
					if (entity8 != null)
					{
						CreatureDataComponent component2 = entity8.GetComponent<CreatureDataComponent>();
						this.CreatureDataId = component2.GetCreatureDataId();
					}
					TsInteractionUtils.RegisterOpenViewName(EUiViewName.GolemHackingGameView);
					int configId = 0;
					configId = GolemHackingController.Instance.OpenGameplayView(daemonHack.Ids, delegate(bool result)
					{
						if (result)
						{
							this.FinishCallback();
							GolemHackingController.Instance.OnUiGameplayFinish(configId);
						}
					}, daemonHack.FinishOnClose.GetValueOrDefault(), null);
					return;
				}
				if (gameplayConfig is IProjectorPuzzle)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					this.FailSendSelfEvent = openSimpleGameplay.FailSendSelfEvent;
					CreatureDataComponent component3 = EntitySystem.Instance.Get(num.Value).GetComponent<CreatureDataComponent>();
					this.CreatureDataId = component3.GetCreatureDataId();
					TsInteractionUtils.RegisterOpenViewName(EUiViewName.ProjectorPuzzleView);
					ProjectorPuzzleController.StartProjectorPuzzle(num.Value, this.FinishWithResultCallback);
					return;
				}
				IDollGrab dollGrab = gameplayConfig as IDollGrab;
				if (dollGrab != null)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					this.FailSendSelfEvent = openSimpleGameplay.FailSendSelfEvent;
					CreatureDataComponent component4 = EntitySystem.Instance.Get(num.Value).GetComponent<CreatureDataComponent>();
					this.CreatureDataId = component4.GetCreatureDataId();
					DollGrabMachineController.Instance.StartDollGrabMachine(dollGrab);
					return;
				}
				IProjectionMachine projectionMachine = gameplayConfig as IProjectionMachine;
				if (projectionMachine != null)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					this.FailSendSelfEvent = openSimpleGameplay.FailSendSelfEvent;
					CreatureDataComponent component5 = EntitySystem.Instance.Get(num.Value).GetComponent<CreatureDataComponent>();
					this.CreatureDataId = component5.GetCreatureDataId();
					int pbDataId = component5.GetPbDataId();
					TsInteractionUtils.RegisterOpenViewName(EUiViewName.ProjectionPhotoView);
					ProjectionPhotoController.Instance.StartProjectionPhotoGameplay(this.CreatureDataId, pbDataId, projectionMachine, this.FinishWithResultCallback);
					return;
				}
				IDollGrabShowcase dollGrabShowcase = gameplayConfig as IDollGrabShowcase;
				if (dollGrabShowcase != null)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					this.FailSendSelfEvent = openSimpleGameplay.FailSendSelfEvent;
					CreatureDataComponent component6 = EntitySystem.Instance.Get(num.Value).GetComponent<CreatureDataComponent>();
					this.CreatureDataId = component6.GetCreatureDataId();
					DollGrabShowcaseController.Instance.StartDollGrabShowcaseView(dollGrabShowcase);
					return;
				}
				IWuWaGoGame wuWaGoGame = gameplayConfig as IWuWaGoGame;
				if (wuWaGoGame != null)
				{
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					this.FailSendSelfEvent = openSimpleGameplay.FailSendSelfEvent;
					Entity entity9 = EntitySystem.Instance.Get(num.Value);
					this.CreatureDataId = entity9.GetComponent<CreatureDataComponent>().GetCreatureDataId();
					WuWaGoController.Instance.StartGameplay(wuWaGoGame.LevelCenterId, this.FinishWithResultCallback).Forget<bool>();
					return;
				}
				ISheriffReasoning sheriffReasoning = gameplayConfig as ISheriffReasoning;
				if (sheriffReasoning != null)
				{
					TsInteractionUtils.RegisterOpenViewName(EUiViewName.SheriffMainView);
					SheriffController.Instance.OpenAnalysisClueView(sheriffReasoning.Id);
					return;
				}
				IWriteLetter writeLetter = gameplayConfig as IWriteLetter;
				if (writeLetter != null)
				{
					WriteLetterController.Instance.OpenWriteLetter(writeLetter);
					return;
				}
				IQteHourglass qteHourglass = gameplayConfig as IQteHourglass;
				if (qteHourglass != null)
				{
					HourglassOpenParam param4 = new HourglassOpenParam
					{
						Config = qteHourglass,
						AutoStartQte = new bool?(false)
					};
					UiManager.Instance.OpenView(EUiViewName.QteHourglassView, param4, null);
					return;
				}
				IInstrumentQteGameplay instrumentQteGameplay = gameplayConfig as IInstrumentQteGameplay;
				if (instrumentQteGameplay == null)
				{
					IPlayPianoGameplay playPianoGameplay = gameplayConfig as IPlayPianoGameplay;
					if (playPianoGameplay == null)
					{
						return;
					}
					Entity entity10 = null;
					EntityContext entityContext2 = context as EntityContext;
					if (entityContext2 != null && !(context.Type != EGeneralContextType.Entity))
					{
						int? num2 = entityContext2.EntityId;
						if (num2 != null)
						{
							int valueOrDefault = num2.GetValueOrDefault();
							entity10 = EntitySystem.Instance.Get(valueOrDefault);
							goto IL_B0C;
						}
					}
					TriggerContext triggerContext = context as TriggerContext;
					if (triggerContext != null && !(context.Type != EGeneralContextType.Trigger))
					{
						int? num2 = triggerContext.TriggerEntityId;
						if (num2 != null)
						{
							int valueOrDefault2 = num2.GetValueOrDefault();
							entity10 = EntitySystem.Instance.Get(valueOrDefault2);
						}
					}
					IL_B0C:
					if (entity10 == null)
					{
						global::Log.Instance.Error(ELogModule.Event, ELogAuthor.FJH, "钢琴玩法开启失败：找不到实体", default(ReadOnlySpan<ValueTuple<string, object>>));
						return;
					}
					CreatureDataComponent component7 = entity10.GetComponent<CreatureDataComponent>();
					this.CreatureDataId = component7.GetCreatureDataId();
					this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
					this.FailSendSelfEvent = openSimpleGameplay.FailSendSelfEvent;
					PianoGameplayController.Instance.StartPianoGameplay(component7.GetPbDataId(), playPianoGameplay, this.FinishWithResultCallback);
					return;
				}
				else
				{
					MusicalInstrumentQteConfig? config2 = ConfigMusicalInstrumentQteConfigById.GetConfig(instrumentQteGameplay.Id, true);
					if (config2 != null)
					{
						MusicalInstrumentQteConfig valueOrDefault3 = config2.GetValueOrDefault();
						MusicalInstrumentController.Instance.Enter(new MusicalInstrumentEnterParam
						{
							Type = (EInstrumentType)valueOrDefault3.InstrumentType,
							QteId = new int?(valueOrDefault3.Id)
						}).Forget();
						return;
					}
					global::Log.Instance.Error(ELogModule.MusicalInstrument, ELogAuthor.CB, "乐器Qte:获取乐器Qte配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
			}
			else
			{
				GeneralLogicTreeContext generalLogicTreeContext = context as GeneralLogicTreeContext;
				if (generalLogicTreeContext == null || !(context.Type == EGeneralContextType.GeneralLogicTree))
				{
					global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CJH, "大个布偶坚固岩石玩法开启失败：只能由行为中打开", default(ReadOnlySpan<ValueTuple<string, object>>));
					return;
				}
				this.FinishSendSelfEvent = openSimpleGameplay.FinishSendSelfEvent;
				TsInteractionUtils.RegisterOpenViewName(EUiViewName.BigStuffedDollView);
				BigStuffedDollController.Instance.Open(brokenRock.Id, generalLogicTreeContext.TreeConfigId, this.FinishCallback);
				return;
			}
		}

		// Token: 0x0603A2DC RID: 238300 RVA: 0x0106A6EE File Offset: 0x010688EE
		private void OpenCipher(string cipherId)
		{
			CipherController.Instance.OpenCipherView(cipherId);
		}

		// Token: 0x0603A2DD RID: 238301 RVA: 0x0106A6FB File Offset: 0x010688FB
		private void FinishCallbackImpl()
		{
			if (this.FinishSendSelfEvent != null)
			{
				LevelGeneralNetworks.RequestEntitySendEvent(this.CreatureDataId, this.FinishSendSelfEvent);
			}
		}

		// Token: 0x0603A2DE RID: 238302 RVA: 0x0106A718 File Offset: 0x01068918
		private void FinishWithResultCallbackImpl(bool result)
		{
			if (result && this.FinishSendSelfEvent != null)
			{
				LevelGeneralNetworks.RequestEntitySendEvent(this.CreatureDataId, this.FinishSendSelfEvent);
			}
			if (!result && this.FailSendSelfEvent != null)
			{
				LevelGeneralNetworks.RequestEntitySendEvent(this.CreatureDataId, this.FailSendSelfEvent);
			}
			this.FinishSendSelfEvent = null;
			this.FailSendSelfEvent = null;
		}

		// Token: 0x0401EBBC RID: 125884
		[Nullable(2)]
		private string FinishSendSelfEvent;

		// Token: 0x0401EBBD RID: 125885
		[Nullable(2)]
		private string FailSendSelfEvent;

		// Token: 0x0401EBBE RID: 125886
		private long CreatureDataId = -1L;

		// Token: 0x0200B7DE RID: 47070
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x04038D49 RID: 232777
			[Nullable(0)]
			public static Action<EUiViewName> <0>__RegisterOpenViewName;
		}
	}
}
