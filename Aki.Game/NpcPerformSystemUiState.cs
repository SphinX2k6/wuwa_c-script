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

// Token: 0x0200279E RID: 10142
[NullableContext(2)]
[Nullable(0)]
public class NpcPerformSystemUiState : NpcPerformBaseState
{
	// Token: 0x060196AF RID: 104111 RVA: 0x007C63A4 File Offset: 0x007C45A4
	[NullableContext(1)]
	public NpcPerformSystemUiState(EntityHandle owner, ENpcPerformState state, [Nullable(new byte[]
	{
		2,
		1
	})] StateMachine<EntityHandle, ENpcPerformState> stateMachine = null) : base(owner, state, stateMachine)
	{
	}

	// Token: 0x17002880 RID: 10368
	// (get) Token: 0x060196B0 RID: 104112 RVA: 0x007C63F5 File Offset: 0x007C45F5
	// (set) Token: 0x060196B1 RID: 104113 RVA: 0x007C63FD File Offset: 0x007C45FD
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

	// Token: 0x17002881 RID: 10369
	// (get) Token: 0x060196B2 RID: 104114 RVA: 0x007C6406 File Offset: 0x007C4606
	// (set) Token: 0x060196B3 RID: 104115 RVA: 0x007C640E File Offset: 0x007C460E
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

	// Token: 0x060196B4 RID: 104116 RVA: 0x007C6418 File Offset: 0x007C4618
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

	// Token: 0x060196B5 RID: 104117 RVA: 0x007C6460 File Offset: 0x007C4660
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

	// Token: 0x060196B6 RID: 104118 RVA: 0x007C6548 File Offset: 0x007C4748
	protected override void OnUpdate(float delta)
	{
		if (this.NpcUiInteractType == ENpcUiInteractType.AntiqueShop || this.NpcUiInteractType == ENpcUiInteractType.ChengXiaoShanShop)
		{
			return;
		}
		this.PlayStandByMontage();
	}

	// Token: 0x060196B7 RID: 104119 RVA: 0x007C6564 File Offset: 0x007C4764
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

	// Token: 0x060196B8 RID: 104120 RVA: 0x007C6598 File Offset: 0x007C4798
	protected override void OnDestroy()
	{
		this.RemoveEvents();
		if (this.NpcPerformSequence != null)
		{
			this.NpcPerformSequence.Destroy();
			this.NpcPerformSequence = null;
		}
		this.DisableEntities.Clear();
	}

	// Token: 0x060196B9 RID: 104121 RVA: 0x007C65C5 File Offset: 0x007C47C5
	public override bool CanChangeFrom(ENpcPerformState fromState)
	{
		return fromState != ENpcPerformState.Destroy;
	}

	// Token: 0x060196BA RID: 104122 RVA: 0x007C65D0 File Offset: 0x007C47D0
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

	// Token: 0x060196BB RID: 104123 RVA: 0x007C6DBC File Offset: 0x007C4FBC
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

	// Token: 0x060196BC RID: 104124 RVA: 0x007C6EE8 File Offset: 0x007C50E8
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

	// Token: 0x060196BD RID: 104125 RVA: 0x007C6FD0 File Offset: 0x007C51D0
	private void InitCoolDown()
	{
		this.BuySuccessNpcDialogueTimeInterval = (double)ConfigCommonParamById.GetIntConfig("BuySuccessNpcDialogueTimeInterval").GetValueOrDefault();
		this.StandByMontageStartTimeStamp = Time.Instance.WorldTimeSeconds;
		this.StandByMontageCd = (double)((UiManager.Instance.IsViewOpen(EUiViewName.PupuVillageItemView) || UiManager.Instance.IsViewOpen(EUiViewName.PhonographView)) ? 1f : 20f);
		this.ShopSuccessStartTimeStamp = Time.Instance.WorldTimeSeconds;
		this.ShopSuccessCd = 0.0;
	}

	// Token: 0x060196BE RID: 104126 RVA: 0x007C705C File Offset: 0x007C525C
	private void ResetCoolDown()
	{
		this.LastPlaySwitchMontageTime = 0.0;
		this.StandByMontageStartTimeStamp = 0.0;
		this.StandByMontageCd = 0.0;
		this.ShopSuccessCd = 0.0;
		this.ShopSuccessStartTimeStamp = 0.0;
	}

	// Token: 0x060196BF RID: 104127 RVA: 0x007C70B4 File Offset: 0x007C52B4
	private void FinishUiOpenPerformance()
	{
		this.RemoveEvents();
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
	}

	// Token: 0x060196C0 RID: 104128 RVA: 0x007C7190 File Offset: 0x007C5390
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

	// Token: 0x060196C1 RID: 104129 RVA: 0x007C72D0 File Offset: 0x007C54D0
	private void RemoveEvents()
	{
		if (EventSystem.Instance.Has<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView)))
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnOpenView));
		}
		if (EventSystem.Instance.Has<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView)))
		{
			EventSystem.Instance.Remove<EUiViewName, int>(EEventName.CloseView, new Action<EUiViewName, int>(this.OnCloseView));
		}
		if (EventSystem.Instance.Has<int, int>(EEventName.BoughtItem, new Action<int, int>(this.OnBuySuccess)))
		{
			EventSystem.Instance.Remove<int, int>(EEventName.BoughtItem, new Action<int, int>(this.OnBuySuccess));
		}
		if (EventSystem.Instance.Has(EEventName.OnSubmitItemSuccess, new Action(this.OnSubmitItemSuccess)))
		{
			EventSystem.Instance.Remove(EEventName.OnSubmitItemSuccess, new Action(this.OnSubmitItemSuccess));
		}
		if (EventSystem.Instance.Has(EEventName.OnSubmitItemFail, new Action(this.OnSubmitItemFail)))
		{
			EventSystem.Instance.Remove(EEventName.OnSubmitItemFail, new Action(this.OnSubmitItemFail));
		}
		if (EventSystem.Instance.Has(EEventName.OnSubmitItemLevelUp, new Action(this.OnSubmitItemLevelUp)))
		{
			EventSystem.Instance.Remove(EEventName.OnSubmitItemLevelUp, new Action(this.OnSubmitItemLevelUp));
		}
		if (EventSystem.Instance.Has(EEventName.OnSubmitItemLevelMax, new Action(this.OnSubmitItemLevelMax)))
		{
			EventSystem.Instance.Remove(EEventName.OnSubmitItemLevelMax, new Action(this.OnSubmitItemLevelMax));
		}
		if (EventSystem.Instance.Has(EEventName.OnPhonographSwitchMusic, new Action(this.OnPhonographSwitchMusic)))
		{
			EventSystem.Instance.Remove(EEventName.OnPhonographSwitchMusic, new Action(this.OnPhonographSwitchMusic));
		}
		if (EventSystem.Instance.Has(EEventName.OnExitNpcInteract, new Action(this.OnExitNpcInteract)))
		{
			EventSystem.Instance.Remove(EEventName.OnExitNpcInteract, new Action(this.OnExitNpcInteract));
		}
		if (EventSystem.Instance.Has(EEventName.VillageDeliverySuccess, new Action(this.OnVillageDeliverySuccess)))
		{
			EventSystem.Instance.Remove(EEventName.VillageDeliverySuccess, new Action(this.OnVillageDeliverySuccess));
		}
		if (EventSystem.Instance.Has(EEventName.VillageCompleteDelivery, new Action(this.OnVillageCompleteDelivery)))
		{
			EventSystem.Instance.Remove(EEventName.VillageCompleteDelivery, new Action(this.OnVillageCompleteDelivery));
		}
		if (EventSystem.Instance.Has<bool, bool>(EEventName.OnDollGrabMachineDelivery, new Action<bool, bool>(this.OnDollGrabMachineDelivery)))
		{
			EventSystem.Instance.Remove<bool, bool>(EEventName.OnDollGrabMachineDelivery, new Action<bool, bool>(this.OnDollGrabMachineDelivery));
		}
	}

	// Token: 0x060196C2 RID: 104130 RVA: 0x007C757C File Offset: 0x007C577C
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

	// Token: 0x060196C3 RID: 104131 RVA: 0x007C75FC File Offset: 0x007C57FC
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

	// Token: 0x060196C4 RID: 104132 RVA: 0x007C7658 File Offset: 0x007C5858
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

	// Token: 0x060196C5 RID: 104133 RVA: 0x007C7860 File Offset: 0x007C5A60
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

	// Token: 0x060196C6 RID: 104134 RVA: 0x007C7968 File Offset: 0x007C5B68
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

	// Token: 0x060196C7 RID: 104135 RVA: 0x007C7A2C File Offset: 0x007C5C2C
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

	// Token: 0x060196C8 RID: 104136 RVA: 0x007C7B50 File Offset: 0x007C5D50
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

	// Token: 0x060196C9 RID: 104137 RVA: 0x007C7BF8 File Offset: 0x007C5DF8
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

	// Token: 0x060196CA RID: 104138 RVA: 0x007C7D1C File Offset: 0x007C5F1C
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

	// Token: 0x060196CB RID: 104139 RVA: 0x007C7DC4 File Offset: 0x007C5FC4
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

	// Token: 0x060196CC RID: 104140 RVA: 0x007C7EA8 File Offset: 0x007C60A8
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

	// Token: 0x060196CD RID: 104141 RVA: 0x007C7F84 File Offset: 0x007C6184
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

	// Token: 0x060196CE RID: 104142 RVA: 0x007C8184 File Offset: 0x007C6384
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

	// Token: 0x060196CF RID: 104143 RVA: 0x007C82FC File Offset: 0x007C64FC
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

	// Token: 0x060196D0 RID: 104144 RVA: 0x007C8494 File Offset: 0x007C6694
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

	// Token: 0x060196D1 RID: 104145 RVA: 0x007C871C File Offset: 0x007C691C
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

	// Token: 0x060196D2 RID: 104146 RVA: 0x007C887C File Offset: 0x007C6A7C
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

	// Token: 0x060196D3 RID: 104147 RVA: 0x007C8A2C File Offset: 0x007C6C2C
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

	// Token: 0x060196D4 RID: 104148 RVA: 0x007C8B5C File Offset: 0x007C6D5C
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

	// Token: 0x060196D5 RID: 104149 RVA: 0x007C8BC4 File Offset: 0x007C6DC4
	public void SetNpcAndChildEnable()
	{
		for (int i = 0; i < this.DisableEntities.Count; i++)
		{
			DisableEntityInfo disableEntityInfo = this.DisableEntities[i];
			disableEntityInfo.EntityHandle.Entity.Enable(disableEntityInfo.HandleId, "NpcPerformSystemUiState.SetNpcAndChildEnable");
		}
		this.DisableEntities.Clear();
	}

	// Token: 0x060196D6 RID: 104150 RVA: 0x007C8C1C File Offset: 0x007C6E1C
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

	// Token: 0x060196D7 RID: 104151 RVA: 0x007C8C90 File Offset: 0x007C6E90
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

	// Token: 0x060196D8 RID: 104152 RVA: 0x007C8E28 File Offset: 0x007C7028
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

	// Token: 0x060196D9 RID: 104153 RVA: 0x007C8F8C File Offset: 0x007C718C
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

	// Token: 0x060196DA RID: 104154 RVA: 0x007C90C0 File Offset: 0x007C72C0
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

	// Token: 0x0400DECE RID: 57038
	private const int STAND_BY_MONTAGE_CD = 20;

	// Token: 0x0400DECF RID: 57039
	private const int SWITCH_MONATGE_CD = 2000;

	// Token: 0x0400DED0 RID: 57040
	private NpcShopPerformParams ShopParams;

	// Token: 0x0400DED1 RID: 57041
	private ENpcUiInteractType NpcUiInteractType = ENpcUiInteractType.AntiqueShop;

	// Token: 0x0400DED2 RID: 57042
	private EUiViewName? UiViewName;

	// Token: 0x0400DED3 RID: 57043
	private bool IsViewOpening;

	// Token: 0x0400DED4 RID: 57044
	private int ShopId;

	// Token: 0x0400DED5 RID: 57045
	private NpcPerformSequence NpcPerformSequence;

	// Token: 0x0400DED6 RID: 57046
	[Nullable(1)]
	private readonly List<DisableEntityInfo> DisableEntities = new List<DisableEntityInfo>();

	// Token: 0x0400DED7 RID: 57047
	private double StandByMontageCd;

	// Token: 0x0400DED8 RID: 57048
	private double StandByMontageStartTimeStamp;

	// Token: 0x0400DED9 RID: 57049
	private double ShopSuccessCd = --0.0;

	// Token: 0x0400DEDA RID: 57050
	private double ShopSuccessStartTimeStamp = --0.0;

	// Token: 0x0400DEDB RID: 57051
	private double BuySuccessNpcDialogueTimeInterval;

	// Token: 0x0400DEDC RID: 57052
	private double CanPlayBuySuccessTimeStamp;

	// Token: 0x0400DEDD RID: 57053
	private double LastPlaySwitchMontageTime;

	// Token: 0x0400DEDE RID: 57054
	[Nullable(1)]
	private readonly Dictionary<EUiViewName, EPlotLowLevelPosition> PlotPositionMap = new Dictionary<EUiViewName, EPlotLowLevelPosition>();
}
