using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Plot.Flow;
using CSharpScript.Game.Module.Plot.PlotView;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200322F RID: 12847
[NullableContext(2)]
[Nullable(0)]
public class NpcPerformSystemUiState : NpcPerformBaseState
{
	// Token: 0x0601BB2A RID: 113450 RVA: 0x0079DC08 File Offset: 0x0079BE08
	[NullableContext(1)]
	public NpcPerformSystemUiState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x1700263F RID: 9791
	// (get) Token: 0x0601BB2B RID: 113451 RVA: 0x0079DC59 File Offset: 0x0079BE59
	// (set) Token: 0x0601BB2C RID: 113452 RVA: 0x0079DC61 File Offset: 0x0079BE61
	public EUiViewName? SystemUiViewName
	{
		get
		{
			return this.UiViewName;
		}
		set
		{
			this.UiViewName = value;
		}
	}

	// Token: 0x17002640 RID: 9792
	// (get) Token: 0x0601BB2D RID: 113453 RVA: 0x0079DC6A File Offset: 0x0079BE6A
	// (set) Token: 0x0601BB2E RID: 113454 RVA: 0x0079DC72 File Offset: 0x0079BE72
	public int BoardId
	{
		get
		{
			return this.ShopId;
		}
		set
		{
			this.ShopId = value;
		}
	}

	// Token: 0x0601BB2F RID: 113455 RVA: 0x0079DC7C File Offset: 0x0079BE7C
	protected override void OnCreate(IEntityArgs args)
	{
		base.OnCreate(args);
		Aki.TDConfigMgr.Component.NpcPerformComponent p = args.GetP1<Aki.TDConfigMgr.Component.NpcPerformComponent>();
		if (((p != null) ? p.ShowOnUiInteract : null) == null)
		{
			return;
		}
		this.InitShopPerformParams(p.ShowOnUiInteract);
		this.PlotPositionMap[EUiViewName.MingSuView] = EPlotLowLevelPosition.Right;
	}

	// Token: 0x0601BB30 RID: 113456 RVA: 0x0079DCC4 File Offset: 0x0079BEC4
	protected override void OnEnter(ENpcPerformState? lastState)
	{
		CommonNpcPerformComponent performComp = this.PerformComp;
		if (performComp != null)
		{
			performComp.SightTarget(new OneOf<BaseActorComponent, global::Vector, AActor>?(CameraController.Instance.MainModel.WidgetCamera.DisplayComponent.CineCamera), EStareActionType.SystemUI);
		}
		if (this.UiViewName == null)
		{
			return;
		}
		if (this.UiViewName == EUiViewName.ForgingRootView)
		{
			return;
		}
		NpcShopPerformParams shopParams = this.ShopParams;
		if (shopParams != null)
		{
			shopParams.TryLoadAllMontage();
		}
		if (UiManager.Instance.IsViewShow(this.UiViewName.Value))
		{
			this.IsViewOpening = true;
		}
		else
		{
			this.IsViewOpening = false;
			EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		}
		this.AddEvents();
		this.SetForcedLod(true);
		this.TryPlayEnterMontage();
		this.TryPlayEnterFlow();
		this.InitCoolDown();
	}

	// Token: 0x0601BB31 RID: 113457 RVA: 0x0079DDAC File Offset: 0x0079BFAC
	protected override void OnUpdate(float delta)
	{
		if (this.NpcUiInteractType == ENpcUiInteractType.AntiqueShop || this.NpcUiInteractType == ENpcUiInteractType.ChengXiaoShanShop)
		{
			return;
		}
		this.PlayStandByMontage();
	}

	// Token: 0x0601BB32 RID: 113458 RVA: 0x0079DDC8 File Offset: 0x0079BFC8
	protected override void OnExit(ENpcPerformState nextState)
	{
		this.SetForcedLod(false);
		this.SetNpcAndChildEnable();
		CommonNpcPerformComponent performComp = this.PerformComp;
		if (performComp == null)
		{
			return;
		}
		performComp.SightTarget(null, EStareActionType.SystemUI);
	}

	// Token: 0x0601BB33 RID: 113459 RVA: 0x0079DDFC File Offset: 0x0079BFFC
	protected override void OnDestroy()
	{
		if (this.NpcPerformSequence != null)
		{
			this.NpcPerformSequence.Destroy();
			this.NpcPerformSequence = null;
		}
		this.DisableEntities.Clear();
	}

	// Token: 0x0601BB34 RID: 113460 RVA: 0x0079DE23 File Offset: 0x0079C023
	public override bool CanChangeFrom(ENpcPerformState fromState)
	{
		return fromState != ENpcPerformState.Destroy;
	}

	// Token: 0x0601BB35 RID: 113461 RVA: 0x0079DE30 File Offset: 0x0079C030
	[NullableContext(1)]
	private void InitShopPerformParams(INpcUiInteractType config)
	{
		this.NpcUiInteractType = config.Type;
		this.ShopParams = new NpcShopPerformParams();
		INpcUiInteractOnAntiqueShop npcUiInteractOnAntiqueShop = config as INpcUiInteractOnAntiqueShop;
		if (npcUiInteractOnAntiqueShop != null)
		{
			this.ShopParams.EnterMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnAntiqueShop.EnterMontage);
			this.ShopParams.StandByMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnAntiqueShop.StandByMontage);
			this.ShopParams.ShopSuccessMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnAntiqueShop.ShopSuccessMontage);
			this.ShopParams.EnterFlow = npcUiInteractOnAntiqueShop.EnterFlow;
			this.ShopParams.ShopSuccessFlow = npcUiInteractOnAntiqueShop.ShopSuccessFlow;
			this.ShopParams.ShopFailedFlow = npcUiInteractOnAntiqueShop.ShopFailedFlow;
			this.ShopParams.UpgradeSequencePath = npcUiInteractOnAntiqueShop.UpgradeSequence;
			this.ShopParams.ShowNpcWhilePlayingSequence = false;
			return;
		}
		INpcUiInteractOnChengXiaoShanShop npcUiInteractOnChengXiaoShanShop = config as INpcUiInteractOnChengXiaoShanShop;
		if (npcUiInteractOnChengXiaoShanShop != null)
		{
			this.ShopParams.EnterMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnChengXiaoShanShop.EnterMontage);
			this.ShopParams.StandByMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnChengXiaoShanShop.StandByMontage);
			this.ShopParams.ShopSuccessMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnChengXiaoShanShop.ShopSuccessMontage);
			this.ShopParams.EnterFlow = npcUiInteractOnChengXiaoShanShop.EnterFlow;
			this.ShopParams.ShopSuccessFlow = npcUiInteractOnChengXiaoShanShop.ShopSuccessFlow;
			this.ShopParams.ShopFailedFlow = npcUiInteractOnChengXiaoShanShop.ShopFailedFlow;
			this.ShopParams.UpgradeSequencePath = npcUiInteractOnChengXiaoShanShop.UpgradeSequence;
			this.ShopParams.FinishDeliverySequence = npcUiInteractOnChengXiaoShanShop.FinishDeliverySequence;
			this.ShopParams.ShowNpcWhilePlayingSequence = npcUiInteractOnChengXiaoShanShop.ShowNpcWhilePlayingSequence.GetValueOrDefault();
			return;
		}
		INpcUiInteractOnGramophone npcUiInteractOnGramophone = config as INpcUiInteractOnGramophone;
		if (npcUiInteractOnGramophone == null)
		{
			if (!(config is INpcUiInteractOnHandInItem))
			{
				INpcUiInteractOnShop npcUiInteractOnShop = config as INpcUiInteractOnShop;
				if (npcUiInteractOnShop != null)
				{
					this.ShopParams.EnterMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnShop.EnterMontage);
					this.ShopParams.StandByMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnShop.StandByMontage);
					this.ShopParams.ShopSuccessMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnShop.ShopSuccessMontage);
					this.ShopParams.EnterFlow = npcUiInteractOnShop.EnterFlow;
					this.ShopParams.ShopSuccessFlow = npcUiInteractOnShop.ShopSuccessFlow;
					this.ShopParams.ShopFailedFlow = npcUiInteractOnShop.ShopFailedFlow;
					this.ShopParams.ShowNpcWhilePlayingSequence = false;
					return;
				}
				INpcUiInteractOnShopNew npcUiInteractOnShopNew = config as INpcUiInteractOnShopNew;
				if (npcUiInteractOnShopNew != null)
				{
					this.ShopParams.EnterMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnShopNew.EnterMontage);
					this.ShopParams.StandByMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnShopNew.StandByMontage);
					this.ShopParams.ShopSuccessMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnShopNew.ShopSuccessMontage);
					this.ShopParams.EnterFlow = npcUiInteractOnShopNew.EnterFlow;
					this.ShopParams.ShopSuccessFlow = npcUiInteractOnShopNew.ShopSuccessFlow;
					this.ShopParams.ShopFailedFlow = npcUiInteractOnShopNew.ShopFailedFlow;
					this.ShopParams.ShowNpcWhilePlayingSequence = false;
					return;
				}
				INpcUiInteractOnSoundBox3 npcUiInteractOnSoundBox = config as INpcUiInteractOnSoundBox3;
				if (npcUiInteractOnSoundBox == null)
				{
					INpcUiInteractOnSunSpirit npcUiInteractOnSunSpirit = config as INpcUiInteractOnSunSpirit;
					if (npcUiInteractOnSunSpirit == null)
					{
						INpcUiInteractOnSoundBox35 npcUiInteractOnSoundBox2 = config as INpcUiInteractOnSoundBox35;
						if (npcUiInteractOnSoundBox2 == null)
						{
							INpcUiInteractOnVillageInfr npcUiInteractOnVillageInfr = config as INpcUiInteractOnVillageInfr;
							if (npcUiInteractOnVillageInfr != null)
							{
								this.ShopParams.EnterMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnVillageInfr.EnterMontage);
								this.ShopParams.DeliverSuccessMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnVillageInfr.DeliverSuccessMontage);
								this.ShopParams.CompleteMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnVillageInfr.CompleteMontage);
								this.ShopParams.EnterFlow = npcUiInteractOnVillageInfr.EnterFlow;
								this.ShopParams.DeliverSuccessFlow = npcUiInteractOnVillageInfr.DeliverSuccessFlow;
								this.ShopParams.CompleteFlow = npcUiInteractOnVillageInfr.CompleteFlow;
								return;
							}
							INpcUiInteractOnDollGrabDelivery npcUiInteractOnDollGrabDelivery = config as INpcUiInteractOnDollGrabDelivery;
							if (npcUiInteractOnDollGrabDelivery == null)
							{
								return;
							}
							this.ShopParams.FirstDollMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnDollGrabDelivery.OnFirstAchievementPerform.EventMontage);
							this.ShopParams.FirstDollMontageInfo.Duration = npcUiInteractOnDollGrabDelivery.OnFirstAchievementPerform.PerformDuration;
							this.ShopParams.SubsequentDollMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnDollGrabDelivery.OnSubsequentAchievementPerform.EventMontage);
							this.ShopParams.SubsequentDollMontageInfo.Duration = npcUiInteractOnDollGrabDelivery.OnSubsequentAchievementPerform.PerformDuration;
							this.ShopParams.FirstDollPartMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnDollGrabDelivery.OnNeverAchievementPerform.EventMontage);
							this.ShopParams.FirstDollPartMontageInfo.Duration = npcUiInteractOnDollGrabDelivery.OnNeverAchievementPerform.PerformDuration;
							this.ShopParams.SubsequentDollPartMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnDollGrabDelivery.OnAlreadyAchievementPerform.EventMontage);
							this.ShopParams.SubsequentDollPartMontageInfo.Duration = npcUiInteractOnDollGrabDelivery.OnAlreadyAchievementPerform.PerformDuration;
							this.ShopParams.FirstDollFlow = npcUiInteractOnDollGrabDelivery.OnFirstAchievementPerform.Flow;
							this.ShopParams.SubsequentDollFlow = npcUiInteractOnDollGrabDelivery.OnSubsequentAchievementPerform.Flow;
							this.ShopParams.FirstDollPartFlow = npcUiInteractOnDollGrabDelivery.OnNeverAchievementPerform.Flow;
							this.ShopParams.SubsequentDollPartFlow = npcUiInteractOnDollGrabDelivery.OnAlreadyAchievementPerform.Flow;
						}
						else
						{
							this.ShopParams.EnterMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnSoundBox2.EnterMontage);
							this.ShopParams.StandByMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnSoundBox2.StandByMontage);
							this.ShopParams.ShopSuccessMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnSoundBox2.ShopSuccessMontage);
							this.ShopParams.EnterFlow = npcUiInteractOnSoundBox2.EnterFlow;
							this.ShopParams.ShopSuccessFlow = npcUiInteractOnSoundBox2.ShopSuccessFlow;
							this.ShopParams.ShopFailedFlow = npcUiInteractOnSoundBox2.ShopFailedFlow;
							this.ShopParams.UpgradeFlow = npcUiInteractOnSoundBox2.UpgradeFlow;
							this.ShopParams.UpgradeSequencePath = npcUiInteractOnSoundBox2.UpgradeSequence;
							this.ShopParams.ShowNpcWhilePlayingSequence = false;
							IMontageAsset montageAsset = npcUiInteractOnSoundBox2.ExitMontage as IMontageAsset;
							if (montageAsset != null)
							{
								this.ShopParams.ExitMontageInfo = new NpcSystemUiMontageInfo(montageAsset.Asset);
								return;
							}
						}
					}
					else
					{
						this.ShopParams.EnterMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnSunSpirit.EnterMontage);
						this.ShopParams.StandByMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnSunSpirit.StandByMontage);
						this.ShopParams.ShopSuccessMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnSunSpirit.ShopSuccessMontage);
						this.ShopParams.EnterFlow = npcUiInteractOnSunSpirit.EnterFlow;
						this.ShopParams.ShopSuccessFlow = npcUiInteractOnSunSpirit.ShopSuccessFlow;
						this.ShopParams.ShopFailedFlow = npcUiInteractOnSunSpirit.ShopFailedFlow;
						this.ShopParams.UpgradeFlow = npcUiInteractOnSunSpirit.UpgradeFlow;
						this.ShopParams.UpgradeSequencePath = npcUiInteractOnSunSpirit.UpgradeSequence;
						this.ShopParams.ShowNpcWhilePlayingSequence = false;
						IMontageAsset montageAsset2 = npcUiInteractOnSunSpirit.ExitMontage as IMontageAsset;
						if (montageAsset2 != null)
						{
							this.ShopParams.ExitMontageInfo = new NpcSystemUiMontageInfo(montageAsset2.Asset);
							return;
						}
					}
				}
				else
				{
					this.ShopParams.EnterMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnSoundBox.EnterMontage);
					this.ShopParams.StandByMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnSoundBox.StandByMontage);
					this.ShopParams.ShopSuccessMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnSoundBox.ShopSuccessMontage);
					this.ShopParams.EnterFlow = npcUiInteractOnSoundBox.EnterFlow;
					this.ShopParams.ShopSuccessFlow = npcUiInteractOnSoundBox.ShopSuccessFlow;
					this.ShopParams.ShopFailedFlow = npcUiInteractOnSoundBox.ShopFailedFlow;
					this.ShopParams.UpgradeFlow = npcUiInteractOnSoundBox.UpgradeFlow;
					this.ShopParams.UpgradeSequencePath = npcUiInteractOnSoundBox.UpgradeSequence;
					this.ShopParams.ShowNpcWhilePlayingSequence = false;
					IMontageAsset montageAsset3 = npcUiInteractOnSoundBox.ExitMontage as IMontageAsset;
					if (montageAsset3 != null)
					{
						this.ShopParams.ExitMontageInfo = new NpcSystemUiMontageInfo(montageAsset3.Asset);
						return;
					}
				}
			}
			return;
		}
		this.ShopParams.EnterMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnGramophone.EnterMontage);
		this.ShopParams.StandByMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnGramophone.StandByMontage);
		this.ShopParams.SwitchMusicMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnGramophone.SwitchMusicMontage);
		this.ShopParams.ExitMontageInfo = new NpcSystemUiMontageInfo(npcUiInteractOnGramophone.ExitMontage);
		this.ShopParams.EnterFlow = npcUiInteractOnGramophone.EnterFlow;
		this.ShopParams.ShopSuccessFlow = npcUiInteractOnGramophone.SuccessFlow;
		this.ShopParams.ShopFailedFlow = npcUiInteractOnGramophone.FailedFlow;
	}

	// Token: 0x0601BB36 RID: 113462 RVA: 0x0079E61C File Offset: 0x0079C81C
	private unsafe void TryPlayEnterMontage()
	{
		NpcShopPerformParams shopParams = this.ShopParams;
		string path;
		if (shopParams == null)
		{
			path = null;
		}
		else
		{
			NpcSystemUiMontageInfo enterMontageInfo = shopParams.EnterMontageInfo;
			path = ((enterMontageInfo != null) ? enterMontageInfo.Path : null);
		}
		if (!NpcSystemUiMontageInfo.IsPathValid(path))
		{
			return;
		}
		if (this.UiViewName == null || !this.IsViewOpening)
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.WLJ;
		string message = "[NpcPerformSystemUiState]当打开界面时,播放进入界面的动作 EnterMontage";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewName", this.UiViewName);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		bool? isLoop = (this.NpcUiInteractType == ENpcUiInteractType.AntiqueShop || this.NpcUiInteractType == ENpcUiInteractType.ChengXiaoShanShop) ? null : new bool?(false);
		base.PlayMontage(new IPlayMontageParam
		{
			MontagePath = this.ShopParams.EnterMontageInfo.Path,
			IsLoop = isLoop,
			AnimStateParam = this.ShopParams.EnterMontageInfo.State,
			OnPlayCallback = delegate(UAnimMontage montage)
			{
				if (this.IsViewOpening)
				{
					return;
				}
				NpcShopPerformParams shopParams2 = this.ShopParams;
				bool flag;
				if (shopParams2 == null)
				{
					flag = true;
				}
				else
				{
					NpcSystemUiMontageInfo enterMontageInfo2 = shopParams2.EnterMontageInfo;
					bool? flag2;
					if (enterMontageInfo2 == null)
					{
						flag2 = null;
					}
					else
					{
						UAnimMontage asset = enterMontageInfo2.Asset;
						flag2 = ((asset != null) ? new bool?(asset.IsValid()) : null);
					}
					bool? flag3 = flag2;
					flag = !flag3.GetValueOrDefault();
				}
				if (flag)
				{
					return;
				}
				base.StopMontage(new IStopMontageParam
				{
					Montage = this.ShopParams.EnterMontageInfo.Asset
				});
			}
		});
	}

	// Token: 0x0601BB37 RID: 113463 RVA: 0x0079E748 File Offset: 0x0079C948
	private unsafe void TryPlayEnterFlow()
	{
		NpcShopPerformParams shopParams = this.ShopParams;
		if (((shopParams != null) ? shopParams.EnterFlow : null) == null || this.UiViewName == null)
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.WLJ;
		string message = "[NpcPerformSystemUiState]当打开界面时,播放进入界面的D级剧情 EnterFlow";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ViewName", this.UiViewName);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("FlowId", this.ShopParams.EnterFlow.FlowId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		this.StartFlow(this.ShopParams.EnterFlow, this.UiViewName.Value, false);
	}

	// Token: 0x0601BB38 RID: 113464 RVA: 0x0079E830 File Offset: 0x0079CA30
	private void InitCoolDown()
	{
		this.BuySuccessNpcDialogueTimeInterval = (double)ConfigCommonParamById.GetIntConfig("BuySuccessNpcDialogueTimeInterval").GetValueOrDefault();
		this.StandByMontageStartTimeStamp = Time.Instance.WorldTimeSeconds;
		this.StandByMontageCd = (double)((UiManager.Instance.IsViewOpen(EUiViewName.PupuVillageItemView) || UiManager.Instance.IsViewOpen(EUiViewName.PhonographView)) ? 1f : 20f);
		this.ShopSuccessStartTimeStamp = Time.Instance.WorldTimeSeconds;
		this.ShopSuccessCd = 0.0;
	}

	// Token: 0x0601BB39 RID: 113465 RVA: 0x0079E8BC File Offset: 0x0079CABC
	private void ResetCoolDown()
	{
		this.LastPlaySwitchMontageTime = 0.0;
		this.StandByMontageStartTimeStamp = 0.0;
		this.StandByMontageCd = 0.0;
		this.ShopSuccessCd = 0.0;
		this.ShopSuccessStartTimeStamp = 0.0;
	}

	// Token: 0x0601BB3A RID: 113466 RVA: 0x0079E914 File Offset: 0x0079CB14
	private void FinishUiOpenPerformance()
	{
		if (this.NpcUiInteractType == ENpcUiInteractType.AntiqueShop || this.NpcUiInteractType == ENpcUiInteractType.ChengXiaoShanShop)
		{
			NpcShopPerformParams shopParams = this.ShopParams;
			bool flag;
			if (shopParams == null)
			{
				flag = false;
			}
			else
			{
				NpcSystemUiMontageInfo enterMontageInfo = shopParams.EnterMontageInfo;
				bool? flag2;
				if (enterMontageInfo == null)
				{
					flag2 = null;
				}
				else
				{
					UAnimMontage asset = enterMontageInfo.Asset;
					flag2 = ((asset != null) ? new bool?(asset.IsValid()) : null);
				}
				bool? flag3 = flag2;
				flag = flag3.GetValueOrDefault();
			}
			if (flag)
			{
				base.PlayMontage(new IPlayMontageParam
				{
					MontageAsset = this.ShopParams.EnterMontageInfo.Asset,
					InSectionToStartMontageAt = new FName?(CharacterNameDefines.Instance.END_SECTION),
					AnimStateParam = this.ShopParams.EnterMontageInfo.State
				});
			}
		}
		this.SetNpcAndChildEnable();
		this.IsViewOpening = false;
		this.UiViewName = null;
		this.ResetCoolDown();
		this.RemoveEvents();
	}

	// Token: 0x0601BB3B RID: 113467 RVA: 0x0079E9F0 File Offset: 0x0079CBF0
	private void AddEvents()
	{
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Add<int, int>(EEventName.BoughtItem, new Action<int, int>(this.OnBuySuccess));
		EventSystem.Instance.Add(EEventName.OnSubmitItemSuccess, new Action(this.OnSubmitItemSuccess));
		EventSystem.Instance.Add(EEventName.OnSubmitItemFail, new Action(this.OnSubmitItemFail));
		EventSystem.Instance.Add(EEventName.OnSubmitItemLevelUp, new Action(this.OnSubmitItemLevelUp));
		EventSystem.Instance.Add(EEventName.OnSubmitItemLevelMax, new Action(this.OnSubmitItemLevelMax));
		EventSystem.Instance.Add(EEventName.OnPhonographSwitchMusic, new Action(this.OnPhonographSwitchMusic));
		EventSystem.Instance.Add(EEventName.OnExitNpcInteract, new Action(this.OnExitNpcInteract));
		EventSystem.Instance.Add(EEventName.VillageDeliverySuccess, new Action(this.OnVillageDeliverySuccess));
		EventSystem.Instance.Add(EEventName.VillageCompleteDelivery, new Action(this.OnVillageCompleteDelivery));
		EventSystem.Instance.Add<bool, bool>(EEventName.OnDollGrabMachineDelivery, new Action<bool, bool>(this.OnDollGrabMachineDelivery));
	}

	// Token: 0x0601BB3C RID: 113468 RVA: 0x0079EB30 File Offset: 0x0079CD30
	private void RemoveEvents()
	{
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		EventSystem.Instance.Remove<int, int>(EEventName.BoughtItem, new Action<int, int>(this.OnBuySuccess));
		EventSystem.Instance.Remove(EEventName.OnSubmitItemSuccess, new Action(this.OnSubmitItemSuccess));
		EventSystem.Instance.Remove(EEventName.OnSubmitItemFail, new Action(this.OnSubmitItemFail));
		EventSystem.Instance.Remove(EEventName.OnSubmitItemLevelUp, new Action(this.OnSubmitItemLevelUp));
		EventSystem.Instance.Remove(EEventName.OnSubmitItemLevelMax, new Action(this.OnSubmitItemLevelMax));
		EventSystem.Instance.Remove(EEventName.OnPhonographSwitchMusic, new Action(this.OnPhonographSwitchMusic));
		EventSystem.Instance.Remove(EEventName.OnExitNpcInteract, new Action(this.OnExitNpcInteract));
		EventSystem.Instance.Remove(EEventName.VillageDeliverySuccess, new Action(this.OnVillageDeliverySuccess));
		EventSystem.Instance.Remove(EEventName.VillageCompleteDelivery, new Action(this.OnVillageCompleteDelivery));
		EventSystem.Instance.Remove<bool, bool>(EEventName.OnDollGrabMachineDelivery, new Action<bool, bool>(this.OnDollGrabMachineDelivery));
	}

	// Token: 0x0601BB3D RID: 113469 RVA: 0x0079EC70 File Offset: 0x0079CE70
	private void OnOpenView(EUiViewName viewName, int viewId)
	{
		if (this.UiViewName == null)
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
			return;
		}
		if (this.UiViewName != viewName)
		{
			return;
		}
		this.IsViewOpening = true;
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		this.TryPlayEnterMontage();
	}

	// Token: 0x0601BB3E RID: 113470 RVA: 0x0079ECF0 File Offset: 0x0079CEF0
	private void OnCloseView(EUiViewName viewName, int viewId)
	{
		if (this.UiViewName == null)
		{
			this.RemoveEvents();
			return;
		}
		if (this.UiViewName != viewName)
		{
			return;
		}
		this.FinishUiOpenPerformance();
		this.StateMachine.Switch(ENpcPerformState.Idle);
	}

	// Token: 0x0601BB3F RID: 113471 RVA: 0x0079ED4C File Offset: 0x0079CF4C
	private unsafe void OnBuySuccess(int shopId, int id)
	{
		if (this.UiViewName == null)
		{
			return;
		}
		if (shopId != this.ShopId)
		{
			return;
		}
		PlotModel instance = PlotModel.Instance;
		if (instance.IsInPlot && instance.PlotConfig.PlotLevel.GetValueOrDefault() == EPlotLevel.LevelD)
		{
			global::Log instance2 = global::Log.Instance;
			ELogModule module = ELogModule.NPC;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "[NpcPerformSystemUiState]当前正在播放D级剧情，不会再播放购买成功的D级剧情";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", this.Owner.Id);
			instance2.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		double worldTime = Time.Instance.WorldTime;
		if (worldTime < this.CanPlayBuySuccessTimeStamp)
		{
			global::Log instance3 = global::Log.Instance;
			ELogModule module2 = ELogModule.NPC;
			ELogAuthor author2 = ELogAuthor.WLJ;
			string message2 = "[NpcPerformSystemUiState]处于冷却间隔中，无法再次播放购买成功D级剧情";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("worldTime", worldTime);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CanPlayBuySuccessTimeStamp", this.CanPlayBuySuccessTimeStamp);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("BuySuccessNpcDialogueTimeInterval", this.BuySuccessNpcDialogueTimeInterval);
			instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return;
		}
		this.CanPlayBuySuccessTimeStamp = worldTime + this.BuySuccessNpcDialogueTimeInterval;
		global::Log instance4 = global::Log.Instance;
		ELogModule module3 = ELogModule.NPC;
		ELogAuthor author3 = ELogAuthor.WLJ;
		string message3 = "[NpcPerformSystemUiState]当购买成功时播放提交成功动作 ShopSuccessMontage";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Id);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("worldTime", worldTime);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("BuySuccessNpcDialogueTimeInterval", this.BuySuccessNpcDialogueTimeInterval);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3) = new ValueTuple<string, object>("CanPlayBuySuccessTimeStamp", this.CanPlayBuySuccessTimeStamp);
		instance4.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 4));
		NpcShopPerformParams shopParams = this.ShopParams;
		this.StartFlow((shopParams != null) ? shopParams.ShopSuccessFlow : null, this.UiViewName.Value, true);
		this.PlayBuySuccessMontage();
	}

	// Token: 0x0601BB40 RID: 113472 RVA: 0x0079EF54 File Offset: 0x0079D154
	private void OnPhonographSwitchMusic()
	{
		if (this.NpcUiInteractType != ENpcUiInteractType.Gramophone)
		{
			return;
		}
		NpcShopPerformParams shopParams = this.ShopParams;
		bool flag;
		if (shopParams == null)
		{
			flag = true;
		}
		else
		{
			NpcSystemUiMontageInfo switchMusicMontageInfo = shopParams.SwitchMusicMontageInfo;
			bool? flag2;
			if (switchMusicMontageInfo == null)
			{
				flag2 = null;
			}
			else
			{
				UAnimMontage asset = switchMusicMontageInfo.Asset;
				flag2 = ((asset != null) ? new bool?(asset.IsValid()) : null);
			}
			bool? flag3 = flag2;
			flag = !flag3.GetValueOrDefault();
		}
		if (flag)
		{
			return;
		}
		if (Time.Instance.WorldTime - this.LastPlaySwitchMontageTime < 2000.0)
		{
			return;
		}
		this.LastPlaySwitchMontageTime = Time.Instance.WorldTime;
		this.StandByMontageStartTimeStamp = Time.Instance.WorldTimeSeconds;
		this.StandByMontageCd = (double)(this.ShopParams.SwitchMusicMontageInfo.Asset.SequenceLength - 0.1f);
		base.PlayMontage(new IPlayMontageParam
		{
			MontageAsset = this.ShopParams.SwitchMusicMontageInfo.Asset,
			IsLoop = new bool?(false),
			AnimStateParam = this.ShopParams.SwitchMusicMontageInfo.State
		});
	}

	// Token: 0x0601BB41 RID: 113473 RVA: 0x0079F05C File Offset: 0x0079D25C
	private void OnExitNpcInteract()
	{
		if (this.NpcUiInteractType != ENpcUiInteractType.Gramophone && this.NpcUiInteractType != ENpcUiInteractType.SoundBox3 && this.NpcUiInteractType != ENpcUiInteractType.SunSpirit && this.NpcUiInteractType != ENpcUiInteractType.SoundBox35)
		{
			return;
		}
		NpcShopPerformParams shopParams = this.ShopParams;
		bool flag;
		if (shopParams == null)
		{
			flag = true;
		}
		else
		{
			NpcSystemUiMontageInfo exitMontageInfo = shopParams.ExitMontageInfo;
			bool? flag2;
			if (exitMontageInfo == null)
			{
				flag2 = null;
			}
			else
			{
				UAnimMontage asset = exitMontageInfo.Asset;
				flag2 = ((asset != null) ? new bool?(asset.IsValid()) : null);
			}
			bool? flag3 = flag2;
			flag = !flag3.GetValueOrDefault();
		}
		if (flag)
		{
			return;
		}
		base.PlayMontage(new IPlayMontageParam
		{
			MontageAsset = this.ShopParams.ExitMontageInfo.Asset,
			IsLoop = new bool?(false),
			AnimStateParam = this.ShopParams.ExitMontageInfo.State
		});
	}

	// Token: 0x0601BB42 RID: 113474 RVA: 0x0079F120 File Offset: 0x0079D320
	private unsafe void OnVillageDeliverySuccess()
	{
		if (this.UiViewName == null)
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.LYX;
		string message = "[CollectionItemDisplay]当提交物品成功时,播放提交成功剧情 EnterFlow,播放提交成功动作 ShopSuccessMontage";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Id);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "FlowId";
		NpcShopPerformParams shopParams = this.ShopParams;
		int? num;
		if (shopParams == null)
		{
			num = null;
		}
		else
		{
			PlayFlow deliverSuccessFlow = shopParams.DeliverSuccessFlow;
			num = ((deliverSuccessFlow != null) ? new int?(deliverSuccessFlow.FlowId) : null);
		}
		ptr = new ValueTuple<string, object>(item, num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		NpcShopPerformParams shopParams2 = this.ShopParams;
		if (((shopParams2 != null) ? shopParams2.DeliverSuccessFlow : null) != null)
		{
			FlowController.Instance.StartFlow(this.ShopParams.DeliverSuccessFlow.FlowListName, this.ShopParams.DeliverSuccessFlow.FlowId, this.ShopParams.DeliverSuccessFlow.StateId, null, 0L, false, false, false, null);
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
		}
		this.PlayVillageDeliverySuccessMontage();
	}

	// Token: 0x0601BB43 RID: 113475 RVA: 0x0079F244 File Offset: 0x0079D444
	private void PlayVillageDeliverySuccessMontage()
	{
		if (this.NpcUiInteractType != ENpcUiInteractType.VillageInfr)
		{
			return;
		}
		NpcShopPerformParams shopParams = this.ShopParams;
		bool flag;
		if (shopParams == null)
		{
			flag = true;
		}
		else
		{
			NpcSystemUiMontageInfo deliverSuccessMontageInfo = shopParams.DeliverSuccessMontageInfo;
			bool? flag2;
			if (deliverSuccessMontageInfo == null)
			{
				flag2 = null;
			}
			else
			{
				UAnimMontage asset = deliverSuccessMontageInfo.Asset;
				flag2 = ((asset != null) ? new bool?(asset.IsValid()) : null);
			}
			bool? flag3 = flag2;
			flag = !flag3.GetValueOrDefault();
		}
		if (flag)
		{
			return;
		}
		base.PlayMontage(new IPlayMontageParam
		{
			MontageAsset = this.ShopParams.DeliverSuccessMontageInfo.Asset,
			IsLoop = new bool?(false),
			AnimStateParam = this.ShopParams.DeliverSuccessMontageInfo.State
		});
	}

	// Token: 0x0601BB44 RID: 113476 RVA: 0x0079F2EC File Offset: 0x0079D4EC
	private unsafe void OnVillageCompleteDelivery()
	{
		if (this.UiViewName == null)
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.LYX;
		string message = "[CollectionItemDisplay]当提交物品成功时,播放提交成功剧情 EnterFlow,播放提交成功动作 ShopSuccessMontage";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Id);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "FlowId";
		NpcShopPerformParams shopParams = this.ShopParams;
		int? num;
		if (shopParams == null)
		{
			num = null;
		}
		else
		{
			PlayFlow completeFlow = shopParams.CompleteFlow;
			num = ((completeFlow != null) ? new int?(completeFlow.FlowId) : null);
		}
		ptr = new ValueTuple<string, object>(item, num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		NpcShopPerformParams shopParams2 = this.ShopParams;
		if (((shopParams2 != null) ? shopParams2.CompleteFlow : null) != null)
		{
			FlowController.Instance.StartFlow(this.ShopParams.CompleteFlow.FlowListName, this.ShopParams.CompleteFlow.FlowId, this.ShopParams.CompleteFlow.StateId, null, 0L, false, false, false, null);
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
		}
		this.PlayVillageCompleteMontage();
	}

	// Token: 0x0601BB45 RID: 113477 RVA: 0x0079F410 File Offset: 0x0079D610
	private void PlayVillageCompleteMontage()
	{
		if (this.NpcUiInteractType != ENpcUiInteractType.VillageInfr)
		{
			return;
		}
		NpcShopPerformParams shopParams = this.ShopParams;
		bool flag;
		if (shopParams == null)
		{
			flag = true;
		}
		else
		{
			NpcSystemUiMontageInfo completeMontageInfo = shopParams.CompleteMontageInfo;
			bool? flag2;
			if (completeMontageInfo == null)
			{
				flag2 = null;
			}
			else
			{
				UAnimMontage asset = completeMontageInfo.Asset;
				flag2 = ((asset != null) ? new bool?(asset.IsValid()) : null);
			}
			bool? flag3 = flag2;
			flag = !flag3.GetValueOrDefault();
		}
		if (flag)
		{
			return;
		}
		base.PlayMontage(new IPlayMontageParam
		{
			MontageAsset = this.ShopParams.CompleteMontageInfo.Asset,
			IsLoop = new bool?(false),
			AnimStateParam = this.ShopParams.CompleteMontageInfo.State
		});
	}

	// Token: 0x0601BB46 RID: 113478 RVA: 0x0079F4B8 File Offset: 0x0079D6B8
	private unsafe void OnSubmitItemSuccess()
	{
		if (this.UiViewName == null)
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.WLJ;
		string message = "[CollectionItemDisplay]当提交物品成功时,播放提交成功剧情 EnterFlow,播放提交成功动作 ShopSuccessMontage";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Id);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "FlowId";
		NpcShopPerformParams shopParams = this.ShopParams;
		int? num;
		if (shopParams == null)
		{
			num = null;
		}
		else
		{
			PlayFlow shopSuccessFlow = shopParams.ShopSuccessFlow;
			num = ((shopSuccessFlow != null) ? new int?(shopSuccessFlow.FlowId) : null);
		}
		ptr = new ValueTuple<string, object>(item, num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		NpcShopPerformParams shopParams2 = this.ShopParams;
		this.StartFlow((shopParams2 != null) ? shopParams2.ShopSuccessFlow : null, this.UiViewName.Value, true);
		this.PlayBuySuccessMontage();
	}

	// Token: 0x0601BB47 RID: 113479 RVA: 0x0079F59C File Offset: 0x0079D79C
	private unsafe void OnSubmitItemFail()
	{
		if (this.UiViewName == null)
		{
			return;
		}
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.WLJ;
		string message = "[CollectionItemDisplay]当提交物品失败时,播放提交物品失败剧情 ShopFailedFlow";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Owner.Id);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
		string item = "FlowId";
		NpcShopPerformParams shopParams = this.ShopParams;
		int? num;
		if (shopParams == null)
		{
			num = null;
		}
		else
		{
			PlayFlow shopFailedFlow = shopParams.ShopFailedFlow;
			num = ((shopFailedFlow != null) ? new int?(shopFailedFlow.FlowId) : null);
		}
		ptr = new ValueTuple<string, object>(item, num);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		NpcShopPerformParams shopParams2 = this.ShopParams;
		this.StartFlow((shopParams2 != null) ? shopParams2.ShopFailedFlow : null, this.UiViewName.Value, true);
	}

	// Token: 0x0601BB48 RID: 113480 RVA: 0x0079F678 File Offset: 0x0079D878
	private unsafe void OnSubmitItemLevelUp()
	{
		if (this.NpcUiInteractType != ENpcUiInteractType.AntiqueShop && this.NpcUiInteractType != ENpcUiInteractType.ChengXiaoShanShop && this.NpcUiInteractType != ENpcUiInteractType.SoundBox3 && this.NpcUiInteractType != ENpcUiInteractType.SunSpirit && this.NpcUiInteractType != ENpcUiInteractType.SoundBox35)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.NPC;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "[CollectionItemDisplay]当提交物品升级成功时,Npc类型不是ChengXiaoShanShop或AntiqueShop,播放失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("NpcUiInteractType", this.NpcUiInteractType);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.ShopParams == null)
		{
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		if (this.ShopParams.UpgradeFlow != null)
		{
			FlowController.Instance.StartFlow(this.ShopParams.UpgradeFlow.FlowListName, this.ShopParams.UpgradeFlow.FlowId, this.ShopParams.UpgradeFlow.StateId, null, 0L, false, false, false, null);
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		if (NpcSystemUiMontageInfo.IsPathValid(this.ShopParams.UpgradeSequencePath))
		{
			NpcSystemUiMontageInfo standByMontageInfo = this.ShopParams.StandByMontageInfo;
			if (NpcSystemUiMontageInfo.IsPathValid((standByMontageInfo != null) ? standByMontageInfo.Path : null))
			{
				if (this.NpcPerformSequence == null)
				{
					this.NpcPerformSequence = new NpcPerformSequence();
				}
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.NPC;
				ELogAuthor author2 = ELogAuthor.WLJ;
				string message2 = "[CollectionItemDisplay]当提交物品升级成功时,开始加载对应Sequence";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcUiInteractType", this.NpcUiInteractType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("UpgradeSequencePath", this.ShopParams.UpgradeSequencePath);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				this.NpcPerformSequence.Load(this.ShopParams.UpgradeSequencePath, new Action(this.OnLevelUpSequenceLoadCompelete));
				return;
			}
		}
		global::Log instance3 = global::Log.Instance;
		ELogModule module3 = ELogModule.NPC;
		ELogAuthor author3 = ELogAuthor.WLJ;
		string message3 = "[CollectionItemDisplay]当提交物品升级成功时,UpgradeSequencePath为空或者StandByMontagePath为Empty,播放失败";
		ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("NpcUiInteractType", this.NpcUiInteractType);
		instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequencePlayFail);
	}

	// Token: 0x0601BB49 RID: 113481 RVA: 0x0079F878 File Offset: 0x0079DA78
	private unsafe void OnLevelUpSequenceLoadCompelete()
	{
		EntityHandle owner = this.Owner;
		if (owner == null || !owner.Valid || this.ShopParams == null)
		{
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		if (this.NpcPerformSequence == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelSequencePlayer;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "交付道具播放Sequence时Npc已销毁";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.ConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Path", this.ShopParams.UpgradeSequencePath);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.NPC;
		ELogAuthor author2 = ELogAuthor.WLJ;
		string message2 = "[CollectionItemDisplay]当提交物品升级成功时,开始播放对应Sequence";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NpcUiInteractType", this.NpcUiInteractType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FinishDeliverySequence", this.ShopParams.UpgradeSequencePath);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("ShowNpcWhilePlayingSequence", this.ShopParams.ShowNpcWhilePlayingSequence);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		if (!this.ShopParams.ShowNpcWhilePlayingSequence)
		{
			this.SetNpcAndChildDisable();
		}
		this.NpcPerformSequence.Play(new Action(this.OnLevelUpSequencePlayFinished));
	}

	// Token: 0x0601BB4A RID: 113482 RVA: 0x0079F9F0 File Offset: 0x0079DBF0
	private unsafe void OnLevelUpSequencePlayFinished()
	{
		EntityHandle owner = this.Owner;
		if (owner == null || !owner.Valid || this.ShopParams == null)
		{
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		if (this.NpcPerformSequence == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelSequencePlayer;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "交付道具播放Sequence时Npc已销毁";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.ConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Path", this.ShopParams.UpgradeSequencePath);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.NPC;
		ELogAuthor author2 = ELogAuthor.WLJ;
		string message2 = "[CollectionItemDisplay]当提交物品升级成功时,Sequence播放完成";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NpcUiInteractType", this.NpcUiInteractType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FinishDeliverySequence", this.ShopParams.UpgradeSequencePath);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		IPlayMontageParam playMontageParam = new IPlayMontageParam();
		NpcSystemUiMontageInfo enterMontageInfo = this.ShopParams.EnterMontageInfo;
		playMontageParam.MontageAsset = ((enterMontageInfo != null) ? enterMontageInfo.Asset : null);
		playMontageParam.InSectionToStartMontageAt = new FName?(CharacterNameDefines.Instance.LOOP_SECTION);
		NpcSystemUiMontageInfo enterMontageInfo2 = this.ShopParams.EnterMontageInfo;
		playMontageParam.AnimStateParam = ((enterMontageInfo2 != null) ? enterMontageInfo2.State : null);
		base.PlayMontage(playMontageParam);
		this.SetNpcAndChildEnable();
		EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
	}

	// Token: 0x0601BB4B RID: 113483 RVA: 0x0079FB88 File Offset: 0x0079DD88
	private unsafe void OnSubmitItemLevelMax()
	{
		if (this.NpcUiInteractType != ENpcUiInteractType.AntiqueShop && this.NpcUiInteractType != ENpcUiInteractType.ChengXiaoShanShop && this.NpcUiInteractType != ENpcUiInteractType.SoundBox3 && this.NpcUiInteractType != ENpcUiInteractType.SunSpirit && this.NpcUiInteractType != ENpcUiInteractType.SoundBox35)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.NPC;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "[CollectionItemDisplay]当提交物品等级升至满级时,Npc类型不是ChengXiaoShanShop,播放失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("NpcUiInteractType", this.NpcUiInteractType);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.ShopParams == null)
		{
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		if (this.ShopParams.UpgradeFlow != null)
		{
			FlowController.Instance.StartFlow(this.ShopParams.UpgradeFlow.FlowListName, this.ShopParams.UpgradeFlow.FlowId, this.ShopParams.UpgradeFlow.StateId, null, 0L, false, false, false, null);
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		string text = (this.NpcUiInteractType == ENpcUiInteractType.ChengXiaoShanShop) ? this.ShopParams.FinishDeliverySequence : this.ShopParams.UpgradeSequencePath;
		if (NpcSystemUiMontageInfo.IsPathValid(text))
		{
			NpcSystemUiMontageInfo standByMontageInfo = this.ShopParams.StandByMontageInfo;
			if (NpcSystemUiMontageInfo.IsPathValid((standByMontageInfo != null) ? standByMontageInfo.Path : null))
			{
				if (this.NpcPerformSequence == null)
				{
					this.NpcPerformSequence = new NpcPerformSequence();
				}
				global::Log instance2 = global::Log.Instance;
				ELogModule module2 = ELogModule.NPC;
				ELogAuthor author2 = ELogAuthor.WLJ;
				string message2 = "[CollectionItemDisplay]当提交物品等级升至满级时,开始加载对应Sequence";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NpcUiInteractType", this.NpcUiInteractType);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("FinishDeliverySequence", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ShowNpcWhilePlayingSequence", this.ShopParams.ShowNpcWhilePlayingSequence);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.NpcPerformSequence.Load(text, new Action(this.OnLevelMaxSequenceLoadCompelete));
				return;
			}
		}
		global::Log instance3 = global::Log.Instance;
		ELogModule module3 = ELogModule.NPC;
		ELogAuthor author3 = ELogAuthor.WLJ;
		string message3 = "[CollectionItemDisplay]当提交物品等级升至满级时,FinishDeliverySequence为空或者StandByMontagePath为Empty,播放失败";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NpcUiInteractType", this.NpcUiInteractType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FinishDeliverySequence", text);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2);
		string item = "StandByMontagePath";
		NpcSystemUiMontageInfo standByMontageInfo2 = this.ShopParams.StandByMontageInfo;
		ptr = new ValueTuple<string, object>(item, (standByMontageInfo2 != null) ? standByMontageInfo2.Path : null);
		instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequencePlayFail);
	}

	// Token: 0x0601BB4C RID: 113484 RVA: 0x0079FE10 File Offset: 0x0079E010
	private unsafe void OnLevelMaxSequenceLoadCompelete()
	{
		EntityHandle owner = this.Owner;
		if (owner == null || !owner.Valid || this.ShopParams == null)
		{
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		string item = (this.NpcUiInteractType == ENpcUiInteractType.ChengXiaoShanShop) ? this.ShopParams.FinishDeliverySequence : this.ShopParams.UpgradeSequencePath;
		if (this.NpcPerformSequence == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelSequencePlayer;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "交付道具播放Sequence时Npc已销毁";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.ConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Path", item);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.NPC;
		ELogAuthor author2 = ELogAuthor.WLJ;
		string message2 = "[CollectionItemDisplay]当提交物品等级升至满级时,开始播放对应Sequence";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NpcUiInteractType", this.NpcUiInteractType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FinishDeliverySequence", item);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		if (!this.ShopParams.ShowNpcWhilePlayingSequence)
		{
			this.SetNpcAndChildDisable();
		}
		this.NpcPerformSequence.Play(new Action(this.OnLevelMaxSequencePlayFinished));
	}

	// Token: 0x0601BB4D RID: 113485 RVA: 0x0079FF70 File Offset: 0x0079E170
	private unsafe void OnLevelMaxSequencePlayFinished()
	{
		EntityHandle owner = this.Owner;
		if (owner == null || !owner.Valid || this.ShopParams == null)
		{
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		string item = (this.NpcUiInteractType == ENpcUiInteractType.ChengXiaoShanShop) ? this.ShopParams.FinishDeliverySequence : this.ShopParams.UpgradeSequencePath;
		if (this.NpcPerformSequence == null)
		{
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.LevelSequencePlayer;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "交付道具播放Sequence时Npc已销毁";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.ConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Path", this.ShopParams.UpgradeSequencePath);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
			return;
		}
		global::Log instance2 = global::Log.Instance;
		ELogModule module2 = ELogModule.NPC;
		ELogAuthor author2 = ELogAuthor.WLJ;
		string message2 = "[CollectionItemDisplay]当提交物品等级升至满级时,Sequence播放完成";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("NpcUiInteractType", this.NpcUiInteractType);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("FinishDeliverySequence", item);
		instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		IPlayMontageParam playMontageParam = new IPlayMontageParam();
		NpcSystemUiMontageInfo enterMontageInfo = this.ShopParams.EnterMontageInfo;
		playMontageParam.MontageAsset = ((enterMontageInfo != null) ? enterMontageInfo.Asset : null);
		playMontageParam.InSectionToStartMontageAt = new FName?(CharacterNameDefines.Instance.LOOP_SECTION);
		NpcSystemUiMontageInfo enterMontageInfo2 = this.ShopParams.EnterMontageInfo;
		playMontageParam.AnimStateParam = ((enterMontageInfo2 != null) ? enterMontageInfo2.State : null);
		base.PlayMontage(playMontageParam);
		this.SetNpcAndChildEnable();
		EventSystem.Instance.Emit(EEventName.OnAntiqueShopUpgradeSequenceFinished);
	}

	// Token: 0x0601BB4E RID: 113486 RVA: 0x007A0120 File Offset: 0x0079E320
	private void SetNpcAndChildDisable()
	{
		if (this.NpcPerformSequence == null)
		{
			return;
		}
		int handleId = this.Owner.Entity.Disable("播放Sequence隐藏Npc");
		this.DisableEntities.Add(new DisableEntityInfo
		{
			HandleId = handleId,
			EntityHandle = this.Owner
		});
		EntityHandle owner = this.Owner;
		CreatureDataComponent creatureDataComponent = (owner != null) ? owner.Entity.GetComponent<CreatureDataComponent>() : null;
		if (creatureDataComponent == null || !creatureDataComponent.Valid)
		{
			return;
		}
		List<int> childEntityIds = creatureDataComponent.GetBaseInfo().ChildEntityIds;
		if (childEntityIds != null)
		{
			List<int> list = childEntityIds;
			if (list == null || ((ICollection)list).Count >= 1)
			{
				CreatureModel instance = CreatureModel.Instance;
				foreach (int pbDataId in childEntityIds)
				{
					EntityHandle entityByPbDataId = instance.GetEntityByPbDataId(pbDataId);
					if (entityByPbDataId != null && entityByPbDataId.Valid)
					{
						int handleId2 = entityByPbDataId.Entity.Disable("播放Sequence隐藏子实体");
						this.DisableEntities.Add(new DisableEntityInfo
						{
							HandleId = handleId2,
							EntityHandle = entityByPbDataId
						});
					}
				}
				return;
			}
		}
	}

	// Token: 0x0601BB4F RID: 113487 RVA: 0x007A0250 File Offset: 0x0079E450
	private void SetForcedLod(bool forcedLod)
	{
		EntityHandle owner = this.Owner;
		BaseActorComponent baseActorComponent;
		if (owner == null)
		{
			baseActorComponent = null;
		}
		else
		{
			WorldEntity entity = owner.Entity;
			baseActorComponent = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
		}
		BaseActorComponent baseActorComponent2 = baseActorComponent;
		if (baseActorComponent2 != null)
		{
			USkeletalMeshComponent skeletalMesh = baseActorComponent2.SkeletalMesh;
			if (((skeletalMesh != null) ? new bool?(skeletalMesh.IsValid()) : null).GetValueOrDefault())
			{
				baseActorComponent2.SkeletalMesh.ForcedLodModel = ((forcedLod > false) ? 1 : 0);
			}
		}
	}

	// Token: 0x0601BB50 RID: 113488 RVA: 0x007A02B8 File Offset: 0x0079E4B8
	public void SetNpcAndChildEnable()
	{
		for (int i = 0; i < this.DisableEntities.Count; i++)
		{
			DisableEntityInfo disableEntityInfo = this.DisableEntities[i];
			disableEntityInfo.EntityHandle.Entity.Enable(disableEntityInfo.HandleId, "NpcPerformSystemUiState.SetNpcAndChildEnable");
		}
		this.DisableEntities.Clear();
	}

	// Token: 0x0601BB51 RID: 113489 RVA: 0x007A0310 File Offset: 0x0079E510
	private void StartFlow(PlayFlow playFlow, EUiViewName uiViewName, bool canBeAbandoned)
	{
		if (playFlow == null)
		{
			return;
		}
		EPlotLowLevelPosition? valueOrNull = this.PlotPositionMap.GetValueOrNull(uiViewName);
		UiParam uiParam = new UiParam
		{
			ViewName = new EUiViewName?(uiViewName),
			Position = new EPlotLowLevelPosition?(valueOrNull.GetValueOrDefault(EPlotLowLevelPosition.Center)),
			TextWidth = new EPlotTextWidthType?(EPlotTextWidthType.Short)
		};
		FlowController.Instance.StartFlowForView(playFlow.FlowListName, playFlow.FlowId, playFlow.StateId, uiParam, canBeAbandoned);
	}

	// Token: 0x0601BB52 RID: 113490 RVA: 0x007A0384 File Offset: 0x0079E584
	private void PlayStandByMontage()
	{
		NpcShopPerformParams shopParams = this.ShopParams;
		bool flag;
		if (shopParams == null)
		{
			flag = false;
		}
		else
		{
			NpcSystemUiMontageInfo standByMontageInfo = shopParams.StandByMontageInfo;
			bool? flag2;
			if (standByMontageInfo == null)
			{
				flag2 = null;
			}
			else
			{
				UAnimMontage asset = standByMontageInfo.Asset;
				flag2 = ((asset != null) ? new bool?(asset.IsValid()) : null);
			}
			bool? flag3 = flag2;
			flag = flag3.GetValueOrDefault();
		}
		if (flag && this.StandByMontageStartTimeStamp != 0.0 && Time.Instance.WorldTimeSeconds > this.StandByMontageStartTimeStamp + this.StandByMontageCd)
		{
			bool flag4 = false;
			UAnimMontage asset2 = this.ShopParams.StandByMontageInfo.Asset;
			int num = asset2.CompositeSections.Num();
			for (int i = 0; i < num; i++)
			{
				FCompositeSection fcompositeSection = asset2.CompositeSections.Get(i);
				if (fcompositeSection != null && fcompositeSection.SectionName == CharacterNameDefines.Instance.LOOP_SECTION)
				{
					this.StandByMontageCd = (double)fcompositeSection.SegmentLength;
					flag4 = true;
				}
			}
			if (flag4)
			{
				base.PlayMontage(new IPlayMontageParam
				{
					MontageAsset = asset2,
					InSectionToStartMontageAt = new FName?(CharacterNameDefines.Instance.LOOP_SECTION),
					AnimStateParam = this.ShopParams.StandByMontageInfo.State
				});
				this.StandByMontageStartTimeStamp = Time.Instance.WorldTimeSeconds;
				return;
			}
			base.PlayMontage(new IPlayMontageParam
			{
				MontageAsset = asset2,
				AnimStateParam = this.ShopParams.StandByMontageInfo.State
			});
			this.StandByMontageStartTimeStamp = Time.Instance.WorldTimeSeconds;
			this.StandByMontageCd = (double)(asset2.SequenceLength + 20f);
		}
	}

	// Token: 0x0601BB53 RID: 113491 RVA: 0x007A051C File Offset: 0x0079E71C
	private void PlayBuySuccessMontage()
	{
		NpcShopPerformParams shopParams = this.ShopParams;
		UAnimMontage uanimMontage;
		if (shopParams == null)
		{
			uanimMontage = null;
		}
		else
		{
			NpcSystemUiMontageInfo enterMontageInfo = shopParams.EnterMontageInfo;
			uanimMontage = ((enterMontageInfo != null) ? enterMontageInfo.Asset : null);
		}
		UAnimMontage uanimMontage2 = uanimMontage;
		if (uanimMontage2 != null && uanimMontage2.IsValid())
		{
			EntityHandle owner = this.Owner;
			if (owner != null && owner.Valid)
			{
				BaseAnimationComponent animComp = this.AnimComp;
				bool? flag;
				if (animComp == null)
				{
					flag = null;
				}
				else
				{
					UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
					flag = ((mainAnimInstance != null) ? new bool?(mainAnimInstance.Montage_IsPlaying(uanimMontage2)) : null);
				}
				bool? flag2 = flag;
				if (flag2.GetValueOrDefault())
				{
					return;
				}
			}
		}
		NpcShopPerformParams shopParams2 = this.ShopParams;
		UAnimMontage uanimMontage3;
		if (shopParams2 == null)
		{
			uanimMontage3 = null;
		}
		else
		{
			NpcSystemUiMontageInfo shopSuccessMontageInfo = shopParams2.ShopSuccessMontageInfo;
			uanimMontage3 = ((shopSuccessMontageInfo != null) ? shopSuccessMontageInfo.Asset : null);
		}
		UAnimMontage uanimMontage4 = uanimMontage3;
		if (uanimMontage4 != null && uanimMontage4.IsValid() && this.IsViewOpening && Time.Instance.WorldTimeSeconds > this.ShopSuccessStartTimeStamp + this.ShopSuccessCd)
		{
			IPlayMontageParam playMontageParam = new IPlayMontageParam();
			playMontageParam.MontageAsset = uanimMontage4;
			playMontageParam.IsLoop = new bool?(false);
			NpcShopPerformParams shopParams3 = this.ShopParams;
			IAnimStateParam animStateParam;
			if (shopParams3 == null)
			{
				animStateParam = null;
			}
			else
			{
				NpcSystemUiMontageInfo shopSuccessMontageInfo2 = shopParams3.ShopSuccessMontageInfo;
				animStateParam = ((shopSuccessMontageInfo2 != null) ? shopSuccessMontageInfo2.State : null);
			}
			playMontageParam.AnimStateParam = animStateParam;
			base.PlayMontage(playMontageParam);
			this.ShopSuccessStartTimeStamp = Time.Instance.WorldTimeSeconds;
			this.ShopSuccessCd = (double)uanimMontage4.SequenceLength;
			this.StandByMontageStartTimeStamp = Time.Instance.WorldTimeSeconds;
			this.StandByMontageCd = (double)(uanimMontage4.SequenceLength + 20f);
		}
	}

	// Token: 0x0601BB54 RID: 113492 RVA: 0x007A0680 File Offset: 0x0079E880
	private unsafe void OnDollGrabMachineDelivery(bool isAlreadyFirst, bool isComplete)
	{
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.NPC;
		ELogAuthor author = ELogAuthor.FJH;
		string message = "[DollGrabMachineDelivery]当提交物品成功时,播放提交成功剧情 EnterFlow,播放提交成功动作 ShopSuccessMontage";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isAlreadyFirst", isAlreadyFirst);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("isComplete", isComplete);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		PlayFlow playFlow = null;
		NpcSystemUiMontageInfo playMontage = null;
		if (!isAlreadyFirst && isComplete)
		{
			NpcShopPerformParams shopParams = this.ShopParams;
			playFlow = ((shopParams != null) ? shopParams.FirstDollFlow : null);
			NpcShopPerformParams shopParams2 = this.ShopParams;
			playMontage = ((shopParams2 != null) ? shopParams2.FirstDollMontageInfo : null);
		}
		else if (isAlreadyFirst && isComplete)
		{
			NpcShopPerformParams shopParams3 = this.ShopParams;
			playFlow = ((shopParams3 != null) ? shopParams3.SubsequentDollFlow : null);
			NpcShopPerformParams shopParams4 = this.ShopParams;
			playMontage = ((shopParams4 != null) ? shopParams4.SubsequentDollMontageInfo : null);
		}
		else if (!isAlreadyFirst && !isComplete)
		{
			NpcShopPerformParams shopParams5 = this.ShopParams;
			playFlow = ((shopParams5 != null) ? shopParams5.FirstDollPartFlow : null);
			NpcShopPerformParams shopParams6 = this.ShopParams;
			playMontage = ((shopParams6 != null) ? shopParams6.FirstDollPartMontageInfo : null);
		}
		else if (isAlreadyFirst && !isComplete)
		{
			NpcShopPerformParams shopParams7 = this.ShopParams;
			playFlow = ((shopParams7 != null) ? shopParams7.SubsequentDollPartFlow : null);
			NpcShopPerformParams shopParams8 = this.ShopParams;
			playMontage = ((shopParams8 != null) ? shopParams8.SubsequentDollPartMontageInfo : null);
		}
		this.PlayDollFlowAndMontage(playFlow, playMontage);
	}

	// Token: 0x0601BB55 RID: 113493 RVA: 0x007A07B4 File Offset: 0x0079E9B4
	private void PlayDollFlowAndMontage(PlayFlow playFlow, NpcSystemUiMontageInfo playMontage)
	{
		if (playFlow != null && this.UiViewName != null)
		{
			this.StartFlow(playFlow, this.UiViewName.Value, true);
		}
		if (playMontage != null)
		{
			if (playMontage.Duration != null)
			{
				float? duration = playMontage.Duration;
				float num = 0f;
				if (duration.GetValueOrDefault() > num & duration != null)
				{
					TimerSystem.Instance.Delay(delegate(float _)
					{
						EventSystem.Instance.Emit<bool>(EEventName.OnDollGrabMachineDeliveryFinish, true);
					}, playMontage.Duration.Value * 1000f, null, null, true, 1f);
					if (NpcSystemUiMontageInfo.IsPathValid(playMontage.Path))
					{
						base.PlayMontage(new IPlayMontageParam
						{
							MontagePath = playMontage.Path,
							IsLoop = new bool?(false),
							AnimStateParam = playMontage.State
						});
						return;
					}
					return;
				}
			}
			if (NpcSystemUiMontageInfo.IsPathValid(playMontage.Path))
			{
				IPlayMontageParam playMontageParam = new IPlayMontageParam();
				playMontageParam.MontagePath = playMontage.Path;
				playMontageParam.IsLoop = new bool?(false);
				playMontageParam.AnimStateParam = playMontage.State;
				playMontageParam.OnEndCallback = delegate(UAnimMontage montage, bool bInterrupted)
				{
					if (!bInterrupted)
					{
						EventSystem.Instance.Emit<bool>(EEventName.OnDollGrabMachineDeliveryFinish, true);
					}
				};
				base.PlayMontage(playMontageParam);
			}
		}
	}

	// Token: 0x0400DA2F RID: 55855
	private const int STAND_BY_MONTAGE_CD = 20;

	// Token: 0x0400DA30 RID: 55856
	private const int SWITCH_MONATGE_CD = 2000;

	// Token: 0x0400DA31 RID: 55857
	private NpcShopPerformParams ShopParams;

	// Token: 0x0400DA32 RID: 55858
	private ENpcUiInteractType NpcUiInteractType = ENpcUiInteractType.AntiqueShop;

	// Token: 0x0400DA33 RID: 55859
	private EUiViewName? UiViewName;

	// Token: 0x0400DA34 RID: 55860
	private bool IsViewOpening;

	// Token: 0x0400DA35 RID: 55861
	private int ShopId;

	// Token: 0x0400DA36 RID: 55862
	private NpcPerformSequence NpcPerformSequence;

	// Token: 0x0400DA37 RID: 55863
	[Nullable(1)]
	private readonly List<DisableEntityInfo> DisableEntities = new List<DisableEntityInfo>();

	// Token: 0x0400DA38 RID: 55864
	private double StandByMontageCd;

	// Token: 0x0400DA39 RID: 55865
	private double StandByMontageStartTimeStamp;

	// Token: 0x0400DA3A RID: 55866
	private double ShopSuccessCd = --0.0;

	// Token: 0x0400DA3B RID: 55867
	private double ShopSuccessStartTimeStamp = --0.0;

	// Token: 0x0400DA3C RID: 55868
	private double BuySuccessNpcDialogueTimeInterval;

	// Token: 0x0400DA3D RID: 55869
	private double CanPlayBuySuccessTimeStamp;

	// Token: 0x0400DA3E RID: 55870
	private double LastPlaySwitchMontageTime;

	// Token: 0x0400DA3F RID: 55871
	[Nullable(1)]
	private readonly Dictionary<EUiViewName, EPlotLowLevelPosition> PlotPositionMap = new Dictionary<EUiViewName, EPlotLowLevelPosition>();
}
