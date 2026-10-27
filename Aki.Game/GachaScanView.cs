using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseSeqCharacter;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using AkiClient.Game.Aki.Data.GaCha.Struct;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Npc;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C9F RID: 7327
[NullableContext(2)]
[Nullable(0)]
public class GachaScanView : GachaSceneView
{
	// Token: 0x0600DD23 RID: 56611 RVA: 0x00339FA5 File Offset: 0x003381A5
	[NullableContext(1)]
	public GachaScanView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DD24 RID: 56612 RVA: 0x00339FCB File Offset: 0x003381CB
	[NullableContext(1)]
	private global::GachaResult GetCurResult()
	{
		return this.GachaResult[this.CurIndex];
	}

	// Token: 0x0600DD25 RID: 56613 RVA: 0x00339FDA File Offset: 0x003381DA
	private global::GachaResult GetLastResult()
	{
		if (this.LastIndex < 0)
		{
			return null;
		}
		return this.GachaResult[this.LastIndex];
	}

	// Token: 0x0600DD26 RID: 56614 RVA: 0x00339FF4 File Offset: 0x003381F4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUITexture)),
			new ValueTuple<int, Type>(6, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUITexture)),
			new ValueTuple<int, Type>(16, typeof(UUIText)),
			new ValueTuple<int, Type>(18, typeof(UUIItem)),
			new ValueTuple<int, Type>(19, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(20, typeof(UUIItem)),
			new ValueTuple<int, Type>(21, typeof(UUIItem)),
			new ValueTuple<int, Type>(22, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.SkipBtn)),
			new ValueTuple<int, Delegate>(1, new Action(this.NextBtn)),
			new ValueTuple<int, Delegate>(19, new Action(this.ShareBtn))
		};
	}

	// Token: 0x0600DD27 RID: 56615 RVA: 0x0033A254 File Offset: 0x00338454
	protected override UniTask OnBeforeStartAsync()
	{
		GachaScanView.<OnBeforeStartAsync>d__44 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GachaScanView.<OnBeforeStartAsync>d__44>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DD28 RID: 56616 RVA: 0x0033A298 File Offset: 0x00338498
	protected override void OnAfterOpenUiScene()
	{
		this.SceneCamera = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("SceneCamera1").Value, ECollectActorType.Default);
		this.CameraEffect = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("Flash1").Value, ECollectActorType.Default) as ANiagaraActor);
		this.EffectGold = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("BurstGold").Value, ECollectActorType.Default) as ANiagaraActor);
		this.EffectPurple = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("BurstPurple").Value, ECollectActorType.Default) as ANiagaraActor);
		this.EffectWhite = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("BurstWhite").Value, ECollectActorType.Default) as ANiagaraActor);
		this.UpdateInteractBP = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("UpdateInteractBP").Value, ECollectActorType.Default) as BP_UpdateInteract_C);
		if (this.UpdateInteractBP != null)
		{
			this.UpdateInteractBP.SetTickableWhenPaused(true);
		}
		if (this.CameraEffect != null && this.SceneCamera != null)
		{
			this.CameraEffect.K2_AttachToActor(this.SceneCamera, null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
		}
		if (this.EffectGold != null && this.SceneCamera != null)
		{
			this.EffectGold.K2_AttachToActor(this.SceneCamera, null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
		}
		if (this.EffectPurple != null && this.SceneCamera != null)
		{
			this.EffectPurple.K2_AttachToActor(this.SceneCamera, null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
		}
		if (this.EffectWhite != null && this.SceneCamera != null)
		{
			this.EffectWhite.K2_AttachToActor(this.SceneCamera, null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
		}
		FVectorDouble newRelativeLocation = new FVectorDouble(200.0, 0.0, 0.0);
		FVectorDouble newRelativeLocation2 = new FVectorDouble(60.0, 0.0, 0.0);
		FRotator newRelativeRotation = new FRotator(0f, 90f, 0f);
		FHitResult fhitResult = new FHitResult();
		FHitResult fhitResult2 = new FHitResult();
		if (this.CameraEffect != null)
		{
			this.CameraEffect.D_K2_SetActorRelativeLocation(newRelativeLocation2, false, ref fhitResult, false);
			this.CameraEffect.K2_SetActorRelativeRotation(newRelativeRotation, false, ref fhitResult2, false);
		}
		if (this.EffectGold != null)
		{
			this.EffectGold.D_K2_SetActorRelativeLocation(newRelativeLocation, false, ref fhitResult, false);
			this.EffectGold.K2_SetActorRelativeRotation(newRelativeRotation, false, ref fhitResult2, false);
		}
		if (this.EffectPurple != null)
		{
			this.EffectPurple.D_K2_SetActorRelativeLocation(newRelativeLocation, false, ref fhitResult, false);
			this.EffectPurple.K2_SetActorRelativeRotation(newRelativeRotation, false, ref fhitResult2, false);
		}
		if (this.EffectWhite != null)
		{
			this.EffectWhite.D_K2_SetActorRelativeLocation(newRelativeLocation, false, ref fhitResult, false);
			this.EffectWhite.K2_SetActorRelativeRotation(newRelativeRotation, false, ref fhitResult2, false);
		}
	}

	// Token: 0x0600DD29 RID: 56617 RVA: 0x0033A544 File Offset: 0x00338744
	private void HideBackgroundEffects()
	{
		ANiagaraActor effectGold = this.EffectGold;
		if (effectGold != null)
		{
			effectGold.SetActorHiddenInGame(true);
		}
		ANiagaraActor effectPurple = this.EffectPurple;
		if (effectPurple != null)
		{
			effectPurple.SetActorHiddenInGame(true);
		}
		ANiagaraActor effectWhite = this.EffectWhite;
		if (effectWhite != null)
		{
			effectWhite.SetActorHiddenInGame(true);
		}
		ANiagaraActor effectGold2 = this.EffectGold;
		if (effectGold2 != null)
		{
			UNiagaraComponent niagaraComponent = effectGold2.NiagaraComponent;
			if (niagaraComponent != null)
			{
				niagaraComponent.Deactivate();
			}
		}
		ANiagaraActor effectPurple2 = this.EffectPurple;
		if (effectPurple2 != null)
		{
			UNiagaraComponent niagaraComponent2 = effectPurple2.NiagaraComponent;
			if (niagaraComponent2 != null)
			{
				niagaraComponent2.Deactivate();
			}
		}
		ANiagaraActor effectWhite2 = this.EffectWhite;
		if (effectWhite2 == null)
		{
			return;
		}
		UNiagaraComponent niagaraComponent3 = effectWhite2.NiagaraComponent;
		if (niagaraComponent3 == null)
		{
			return;
		}
		niagaraComponent3.Deactivate();
	}

	// Token: 0x0600DD2A RID: 56618 RVA: 0x0033A5DC File Offset: 0x003387DC
	private void InitProduct()
	{
		this.ConvertItem = new SmallItemGrid();
		this.ConvertItem.Initialize(base.GetItem(8).GetOwner());
		this.ExtraItem = new SmallItemGrid();
		this.ExtraItem.Initialize(base.GetItem(10).GetOwner());
	}

	// Token: 0x0600DD2B RID: 56619 RVA: 0x0033A630 File Offset: 0x00338830
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnSequenceEventByStringParam));
		EventSystem.Instance.Add(EEventName.OnFirstShare, new Action(this.RefreshShare));
		EventSystem.Instance.Add<string>(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600DD2C RID: 56620 RVA: 0x0033A694 File Offset: 0x00338894
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnSequenceEventByStringParam));
		EventSystem.Instance.Remove(EEventName.OnFirstShare, new Action(this.RefreshShare));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
	}

	// Token: 0x0600DD2D RID: 56621 RVA: 0x0033A6F8 File Offset: 0x003388F8
	protected void Refresh()
	{
		this.HideBackgroundEffects();
		GachaReward proto_GachaReward = this.GetCurResult().Proto_GachaReward;
		int num = (proto_GachaReward != null) ? proto_GachaReward.ItemId : 0;
		if (num <= 0)
		{
			Log.Instance.Error(ELogModule.Gacha, ELogAuthor.LZK, "抽卡获得物品为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		GachaDefine.EItemQuality gachaQuality = GachaModel.Instance.GetGachaQuality(num);
		if (gachaQuality == GachaDefine.EItemQuality.Blue)
		{
			AudioSystem.Instance.SetState("ui_gacha_quality", "normal", true);
		}
		else if (gachaQuality == GachaDefine.EItemQuality.Purple)
		{
			AudioSystem.Instance.SetState("ui_gacha_quality", "purple", true);
		}
		else if (gachaQuality == GachaDefine.EItemQuality.Gold)
		{
			AudioSystem.Instance.SetState("ui_gacha_quality", "golden", true);
		}
		AudioSystem.Instance.PostEvent("ui_gacha_scan_next");
		if (gachaQuality != GachaDefine.EItemQuality.Gold)
		{
			this.AfterFiveStarAnimation();
			return;
		}
		base.GetItem(12).SetUIActive(true);
		LevelSequencePlayer fiveStarLevelSequencePlayer = this.FiveStarLevelSequencePlayer;
		if (fiveStarLevelSequencePlayer == null)
		{
			return;
		}
		fiveStarLevelSequencePlayer.PlayLevelSequenceByName("Start", true, null, false);
	}

	// Token: 0x0600DD2E RID: 56622 RVA: 0x0033A7EC File Offset: 0x003389EC
	private void RefreshShare()
	{
		bool flag = this.CurQuality >= 5 && ChannelController.Instance.CouldShare();
		UUIItem item = base.GetItem(18);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (flag)
		{
			ShareReward? config = ConfigShareRewardById.GetConfig((GachaConfig.Instance.GetItemIdType(this.GetCurResult().Proto_GachaReward.ItemId) == InventoryDefine.EItemDataType.WeaponItem) ? 4 : 3, true);
			if (config == null)
			{
				return;
			}
			bool flag2 = ChannelModel.Instance.CouldGetShareReward((EShareActionId)config.Value.Id);
			UUIItem item2 = base.GetItem(20);
			if (item2 != null)
			{
				item2.SetUIActive(flag2);
			}
			if (flag2)
			{
				List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
				foreach (KeyValuePair<int, int> keyValuePair in config.Value.Reward())
				{
					list.Add(new ValueTuple<int, int>(keyValuePair.Key, keyValuePair.Value));
				}
				ValueTuple<int, int> valueTuple = list[0];
				ShareRewardInfo shareRewardInfo = this.ShareRewardInfo;
				if (shareRewardInfo == null)
				{
					return;
				}
				shareRewardInfo.SetItemInfo(valueTuple.Item1, valueTuple.Item2);
			}
		}
	}

	// Token: 0x0600DD2F RID: 56623 RVA: 0x0033A924 File Offset: 0x00338B24
	protected void AfterFiveStarAnimation()
	{
		this.RefreshModel();
		this.RefreshView();
		this.RefreshShare();
	}

	// Token: 0x0600DD30 RID: 56624 RVA: 0x0033A938 File Offset: 0x00338B38
	protected unsafe void RefreshView()
	{
		global::GachaResult curResult = this.GetCurResult();
		int itemId = curResult.Proto_GachaReward.ItemId;
		InventoryDefine.EItemDataType itemIdType = GachaConfig.Instance.GetItemIdType(curResult.Proto_GachaReward.ItemId);
		CSharpScript.Game.Module.Inventory.ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(itemId);
		if (itemConfigData == null)
		{
			return;
		}
		RoleInfo? roleInfo = null;
		LevelSequencePlayer uiLevelSequencePlayer = this.UiLevelSequencePlayer;
		if (uiLevelSequencePlayer != null)
		{
			uiLevelSequencePlayer.StopSequenceByKey("Show", false, false);
		}
		LevelSequencePlayer uiLevelSequencePlayer2 = this.UiLevelSequencePlayer;
		if (uiLevelSequencePlayer2 != null)
		{
			uiLevelSequencePlayer2.StopSequenceByKey("ConvertShow", false, false);
		}
		base.GetItem(13).SetAlpha(0f);
		base.GetItem(22).SetAlpha(0f);
		base.GetItem(18).GetParentAsUIItem().SetUIActive(false);
		int qualityId;
		if (itemIdType != InventoryDefine.EItemDataType.RoleItem)
		{
			if (itemIdType != InventoryDefine.EItemDataType.WeaponItem)
			{
			}
			base.GetItem(3).SetUIActive(true);
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(itemId);
			if (weaponConfigByItemId == null)
			{
				return;
			}
			GachaWeaponTransform? gachaWeaponTransformConfig = GachaConfig.Instance.GetGachaWeaponTransformConfig(weaponConfigByItemId.Value.WeaponType);
			if (gachaWeaponTransformConfig != null)
			{
				base.SetTextureByPath(gachaWeaponTransformConfig.Value.WeaponTypeTexture, base.GetTexture(4), null, null);
			}
			FVector uiitemScale = new FVector(0.8f, 0.8f, 0.8f);
			base.GetTexture(4).SetUIItemScale(uiitemScale);
			base.GetTexture(4).SetColor(ColorUtils.ColorWhile);
			qualityId = itemConfigData.QualityId;
			base.GetText(2).ShowTextNew(itemConfigData.Name);
		}
		else
		{
			base.GetItem(3).SetUIActive(true);
			RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(itemId);
			if (roleInfoById == null)
			{
				return;
			}
			roleInfo = new RoleInfo?(roleInfoById.Value);
			qualityId = roleInfo.Value.QualityId;
			int elementId = roleInfo.Value.ElementId;
			ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(elementId);
			if (elementConfig != null)
			{
				base.GetTexture(5).SetColor(FColor.FromHex(elementConfig.Value.ElementColor));
				UUITexture texture = base.GetTexture(4);
				base.SetTextureByPath(elementConfig.Value.Icon, texture, null, null);
				FColor color = FColor.FromHex(elementConfig.Value.ElementColor);
				texture.SetColor(color);
			}
			base.GetText(2).ShowTextNew(roleInfo.Value.Name);
		}
		bool flag = qualityId == 5 || (qualityId == 4 && curResult.IsNew);
		base.GetButton(0).RootUIComp.Get().SetUIActive(!flag);
		this.StarLayout.RebuildLayout(qualityId);
		IReadOnlyList<GachaReward> proto_TransformRewards = curResult.Proto_TransformRewards;
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(curResult.IsNew);
		}
		base.GetItem(7).SetUIActive(proto_TransformRewards != null && proto_TransformRewards.Count > 0);
		if (curResult.Proto_TransformRewards != null && curResult.Proto_TransformRewards.Count > 0)
		{
			this.ConvertItem.SetActive(true);
			GachaReward reward = curResult.Proto_TransformRewards[0];
			PropSmallItemGrid parameters = new PropSmallItemGrid
			{
				ItemConfigId = new int?(reward.ItemId),
				BottomText = reward.ItemCount.ToString(),
				Data = null
			};
			this.ConvertItem.Apply<PropSmallItemGrid>(parameters);
			this.ConvertItem.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
			this.ConvertItem.BindOnExtendToggleRelease(delegate(MediumItemGridExtendCallback _)
			{
				ItemController.Instance.OpenItemTipsByItemId(reward.ItemId, true, null);
			});
		}
		else
		{
			this.ConvertItem.SetActive(false);
		}
		IReadOnlyList<GachaReward> proto_ExtraRewards = curResult.Proto_ExtraRewards;
		base.GetItem(9).SetUIActive(((proto_ExtraRewards != null) ? proto_ExtraRewards.Count : 0) > 0);
		if (proto_ExtraRewards != null && proto_ExtraRewards.Count > 0)
		{
			this.ExtraItem.SetActive(true);
			GachaReward reward = proto_ExtraRewards[0];
			PropSmallItemGrid parameters2 = new PropSmallItemGrid
			{
				ItemConfigId = new int?(reward.ItemId),
				BottomText = reward.ItemCount.ToString(),
				Data = null
			};
			this.ExtraItem.Apply<PropSmallItemGrid>(parameters2);
			this.ExtraItem.BindOnCanExecuteChange((object _1, bool _2, EToggleState _3) => false);
			this.ExtraItem.BindOnExtendToggleRelease(delegate(MediumItemGridExtendCallback _)
			{
				ItemController.Instance.OpenItemTipsByItemId(reward.ItemId, true, null);
			});
		}
		else
		{
			this.ExtraItem.SetActive(false);
		}
		if (((proto_ExtraRewards != null) ? proto_ExtraRewards.Count : 0) > 1)
		{
			GachaReward gachaReward = proto_ExtraRewards[1];
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Gacha;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "转换奖励只能有一个!, 请检查配置表";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("itemId", gachaReward.ItemId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("itemCount", gachaReward.ItemCount);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		GachaReward proto_BottomExtraReward = curResult.Proto_BottomExtraReward;
		base.GetItem(14).GetParentAsUIItem().SetUIActive(false);
		if (proto_BottomExtraReward != null && proto_BottomExtraReward.ItemId > 0 && proto_BottomExtraReward.ItemCount > 0)
		{
			base.SetItemIcon(base.GetTexture(15), proto_BottomExtraReward.ItemId, null, null);
			UUIText text = base.GetText(16);
			if (text != null)
			{
				text.SetText(proto_BottomExtraReward.ItemCount.ToString(), true);
			}
			base.GetItem(14).SetUIActive(true);
			return;
		}
		base.GetItem(14).SetUIActive(false);
	}

	// Token: 0x0600DD31 RID: 56625 RVA: 0x0033AF30 File Offset: 0x00339130
	protected void RefreshModel()
	{
		global::GachaResult lastResult = this.GetLastResult();
		if (lastResult != null)
		{
			int itemId = lastResult.Proto_GachaReward.ItemId;
			InventoryDefine.EItemDataType itemIdType = GachaConfig.Instance.GetItemIdType(itemId);
			if (itemIdType != InventoryDefine.EItemDataType.RoleItem)
			{
				if (itemIdType == InventoryDefine.EItemDataType.WeaponItem)
				{
					this.HideWeaponObserver();
				}
			}
			else
			{
				this.HideRoleSequence();
			}
		}
		global::GachaResult curResult = this.GetCurResult();
		if (curResult != null)
		{
			int itemId2 = curResult.Proto_GachaReward.ItemId;
			GachaTextureInfo? gachaTextureInfo = GachaConfig.Instance.GetGachaTextureInfo(itemId2);
			if (gachaTextureInfo == null)
			{
				return;
			}
			string gachaSequencePath = GachaModel.Instance.GetGachaSequencePath(itemId2);
			InventoryDefine.EItemDataType itemIdType2 = GachaConfig.Instance.GetItemIdType(itemId2);
			ULevelSequence loadedSequence = GachaModel.Instance.GetLoadedSequence(gachaSequencePath);
			GameSettingsDeviceRender.Instance.TemporaryDisableFrameGeneration("RefreshModel");
			UKuroSequencePerformanceManager.OpenKuroPerformanceMode(loadedSequence);
			this.DestroySequence();
			CameraController.Instance.SetViewTarget(this.SceneCamera, "GachaScanView.RefreshModel", 0f, EViewTargetBlendFunction.VTBlend_Linear, 0f, null, null, "MainCamera", null, null);
			FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
			fmovieSceneSequencePlaybackSettings.bRestoreState = true;
			fmovieSceneSequencePlaybackSettings.bPauseAtEnd = true;
			this.SequenceActor = (ActorSystem.Instance.Spawn(ALevelSequenceActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null) as ALevelSequenceActor);
			if (this.SequenceActor == null)
			{
				return;
			}
			this.SequenceActor.PlaybackSettings = fmovieSceneSequencePlaybackSettings;
			this.LevelSequencePlayer = this.SequenceActor.SequencePlayer;
			this.SequenceActor.SetSequence(loadedSequence);
			UKuroSequenceRuntimeFunctionLibrary.SetSequenceInUiScene(loadedSequence, true);
			this.SequenceActor.SetTickableWhenPaused(true);
			this.SequenceActor.AddBindingByTag(GachaScanView.SCENE_CAMERA_TAG, this.SceneCamera, false, true);
			bool flag = !string.IsNullOrEmpty(gachaTextureInfo.Value.BindPoint);
			if (itemIdType2 == InventoryDefine.EItemDataType.WeaponItem)
			{
				bool flag2 = GachaModel.Instance.ShouldUseWeaponGachaAnim();
				flag = (flag && flag2);
			}
			if (RenderModuleController.Instance.DebugNewUiSceneWorkflow)
			{
				if (flag)
				{
					this.SequenceActor.bOverrideInstanceData = true;
					UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
					if (udefaultLevelSequenceInstanceData != null)
					{
						udefaultLevelSequenceInstanceData.TransformOriginActor = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(gachaTextureInfo.Value.BindPoint).Value, ECollectActorType.UI);
					}
				}
				else
				{
					this.SequenceActor.bOverrideInstanceData = true;
					UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData2 = this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
					if (udefaultLevelSequenceInstanceData2 != null)
					{
						AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("KuroUiSceneRoot").Value, ECollectActorType.UI);
						if (actorWithTag != null)
						{
							FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(actorWithTag.D_GetTransform());
							udefaultLevelSequenceInstanceData2.TransformOrigin = transformOrigin;
						}
					}
				}
			}
			else if (flag)
			{
				this.SequenceActor.bOverrideInstanceData = true;
				UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData3 = this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
				if (udefaultLevelSequenceInstanceData3 != null)
				{
					udefaultLevelSequenceInstanceData3.TransformOriginActor = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(gachaTextureInfo.Value.BindPoint).Value, ECollectActorType.UI);
				}
			}
			TArray<UObject> bindingByTagInTemplate = this.SequenceActor.GetBindingByTagInTemplate(GachaScanView.SCENE_ROLE_TAG, true);
			int num = bindingByTagInTemplate.Num();
			for (int i = 0; i < num; i++)
			{
				AActor aactor = bindingByTagInTemplate.Get(i) as AActor;
				if (aactor != null)
				{
					TArray<UActorComponent> tarray = aactor.K2_GetComponentsByClass(USkeletalMeshComponent.StaticClass());
					int num2 = tarray.Num();
					for (int j = 0; j < num2; j++)
					{
						UActorComponent uactorComponent = tarray.Get(j);
						if (uactorComponent != null)
						{
							uactorComponent.SetTickableWhenPaused(true);
						}
					}
					if (num2 == 0)
					{
						ASkeletalMeshActor askeletalMeshActor = aactor as ASkeletalMeshActor;
						if (askeletalMeshActor != null)
						{
							USkeletalMeshComponent skeletalMeshComponent = askeletalMeshActor.SkeletalMeshComponent;
							if (skeletalMeshComponent != null)
							{
								skeletalMeshComponent.SetTickableWhenPaused(true);
							}
						}
					}
					if (aactor is BP_BaseRole_Seq_V2_C)
					{
						aactor.SetTickableWhenPaused(true);
						aactor.PrimaryActorTick.bTickEvenWhenPaused = true;
					}
					BP_NpcCombinedMesh_C bp_NpcCombinedMesh_C = aactor as BP_NpcCombinedMesh_C;
					if (bp_NpcCombinedMesh_C != null)
					{
						bp_NpcCombinedMesh_C.SetTickableWhenPaused(true);
						bp_NpcCombinedMesh_C.SetSkelTickableWhenPaused(true);
						bp_NpcCombinedMesh_C.PrimaryActorTick.bTickEvenWhenPaused = true;
					}
				}
			}
			this.IsCanContinue = false;
			if (itemIdType2 == InventoryDefine.EItemDataType.RoleItem)
			{
				this.LevelSequencePlayer.OnPause.Add(delegate()
				{
					this.IsCanContinue = true;
				});
				FFrameTime time = this.LevelSequencePlayer.GetStartTime().Time;
				this.LevelSequencePlayer.PlayTo(new FMovieSceneSequencePlaybackParams(time, 0f, "A", EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Play));
			}
			else
			{
				this.LevelSequencePlayer.OnPause.Add(delegate()
				{
					if (!this.IsWeaponToEnd)
					{
						this.IsWeaponToEnd = true;
						ULevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
						if (levelSequencePlayer == null)
						{
							return;
						}
						levelSequencePlayer.Play();
					}
				});
				this.IsWeaponToEnd = false;
				FFrameTime time2 = this.LevelSequencePlayer.GetStartTime().Time;
				this.TryDisableDlss(itemId2);
				this.LevelSequencePlayer.PlayTo(new FMovieSceneSequencePlaybackParams(time2, 0f, "A", EMovieScenePositionType.MarkedFrame, EUpdatePositionMethod.Play));
			}
			PersonalUtil.ApplyTickableWhenPausedOnRuntimeBindings(this.SequenceActor, true);
			if (this.PlayUiSequenceTimerId != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.PlayUiSequenceTimerId);
				this.PlayUiSequenceTimerId = null;
			}
			int beforeEndFrame = 120;
			switch (itemIdType2)
			{
			case InventoryDefine.EItemDataType.RoleItem:
			{
				RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(itemId2);
				if (roleInfoById != null)
				{
					this.CurQuality = roleInfoById.Value.QualityId;
				}
				beforeEndFrame = this.RoleBeforeEndFrame;
				this.ShowRole();
				break;
			}
			case InventoryDefine.EItemDataType.WeaponItem:
			{
				this.ShowItemObserver(itemId2);
				WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(itemId2);
				if (weaponConfigByItemId != null)
				{
					this.CurQuality = weaponConfigByItemId.Value.QualityId;
				}
				beforeEndFrame = GachaModel.Instance.GetGachaSequenceEndFrame(itemId2);
				break;
			}
			}
			this.UiLevelSequencePlayer.StopSequenceByKey("Show", false, false);
			this.PlayUiSequenceTimerId = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				int value = this.LevelSequencePlayer.GetCurrentTime().Time.FrameNumber.Value;
				if (this.LevelSequencePlayer.GetEndTime().Time.FrameNumber.Value - value < beforeEndFrame)
				{
					this.UiLevelSequencePlayer.PlayLevelSequenceByName("Show", false, null, false);
					TimerSystem.GameplayTimeInstance.Remove(this.PlayUiSequenceTimerId);
					this.PlayUiSequenceTimerId = null;
				}
			}, 100f, 1f, null, null, true);
		}
	}

	// Token: 0x0600DD32 RID: 56626 RVA: 0x0033B4E0 File Offset: 0x003396E0
	private void HideWeaponObserver()
	{
		SkeletalObserverHandle gachaItemObserver = this.GachaItemObserver;
		UiModelBase uiModelBase = (gachaItemObserver != null) ? gachaItemObserver.Model : null;
		SkeletalObserverHandle gachaWeaponScabbardObserver = this.GachaWeaponScabbardObserver;
		UiModelBase uiModelBase2 = (gachaWeaponScabbardObserver != null) ? gachaWeaponScabbardObserver.Model : null;
		if (uiModelBase != null)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase, false);
		}
		if (uiModelBase2 != null)
		{
			UiModelUtil.Instance.SetVisible(uiModelBase2, false);
		}
		this.DestroySequence();
	}

	// Token: 0x0600DD33 RID: 56627 RVA: 0x0033B53C File Offset: 0x0033973C
	private void ShowRole()
	{
		int itemId = this.GetCurResult().Proto_GachaReward.ItemId;
		RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(itemId);
		if (roleInfoById == null)
		{
			return;
		}
		if (roleInfoById.Value.QualityId == 5)
		{
			BP_UpdateInteract_C updateInteractBP = this.UpdateInteractBP;
			if (updateInteractBP == null)
			{
				return;
			}
			updateInteractBP.UpdateGachaShowItem(roleInfoById.Value.Id, 4);
			return;
		}
		else
		{
			BP_UpdateInteract_C updateInteractBP2 = this.UpdateInteractBP;
			if (updateInteractBP2 == null)
			{
				return;
			}
			updateInteractBP2.UpdateGachaShowItem(roleInfoById.Value.Id, 3);
			return;
		}
	}

	// Token: 0x0600DD34 RID: 56628 RVA: 0x0033B5C3 File Offset: 0x003397C3
	private void HideRoleSequence()
	{
		this.DestroySequence();
	}

	// Token: 0x0600DD35 RID: 56629 RVA: 0x0033B5CC File Offset: 0x003397CC
	private void DestroySequence()
	{
		try
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.OnStop.Clear();
				this.LevelSequencePlayer.OnPause.Clear();
				this.LevelSequencePlayer.Stop();
				this.LevelSequencePlayer = null;
			}
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			if (sequenceActor != null && sequenceActor.IsValid())
			{
				this.SequenceActor.ResetBindings();
				this.SequenceActor.SetSequence(null);
				this.SequenceActor.K2_DestroyActor();
				this.SequenceActor = null;
			}
		}
		finally
		{
			this.RestoreDlss();
		}
	}

	// Token: 0x0600DD36 RID: 56630 RVA: 0x0033B66C File Offset: 0x0033986C
	private unsafe void TryDisableDlss(int itemId)
	{
		if (itemId != 21050116 || this.OriginDlssEnableValue != null)
		{
			return;
		}
		this.OriginDlssEnableValue = new int?(UKismetSystemLibrary.GetConsoleVariableIntValue("r.NGX.DLSS.Enable"));
		if (this.OriginDlssEnableValue.Value != 0)
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Enable 0", null);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Gacha;
		ELogAuthor author = ELogAuthor.LZK;
		string message = "[GachaScanView][DLSS][Begin] 心月狐武器Seq关闭DLSS";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("itemId", itemId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("originValue", this.OriginDlssEnableValue.Value);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("targetValue", 0);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0600DD37 RID: 56631 RVA: 0x0033B748 File Offset: 0x00339948
	private unsafe void RestoreDlss()
	{
		if (this.OriginDlssEnableValue == null)
		{
			return;
		}
		int value = this.OriginDlssEnableValue.Value;
		UObject world = GlobalData.World;
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
		defaultInterpolatedStringHandler.AppendFormatted("r.NGX.DLSS.Enable");
		defaultInterpolatedStringHandler.AppendLiteral(" ");
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Gacha;
		ELogAuthor author = ELogAuthor.LZK;
		string message = "[GachaScanView][DLSS][End] 心月狐武器Seq恢复DLSS";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("itemId", 21050116);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("restoreValue", value);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		this.OriginDlssEnableValue = null;
	}

	// Token: 0x0600DD38 RID: 56632 RVA: 0x0033B81A File Offset: 0x00339A1A
	private void ShowItemObserver(int itemId)
	{
		if (GachaConfig.Instance.GetItemIdType(itemId) == InventoryDefine.EItemDataType.WeaponItem)
		{
			this.HandleWeapon(itemId);
		}
	}

	// Token: 0x0600DD39 RID: 56633 RVA: 0x0033B834 File Offset: 0x00339A34
	private void HandleWeapon(int itemId)
	{
		GachaScanView.<>c__DisplayClass62_0 CS$<>8__locals1 = new GachaScanView.<>c__DisplayClass62_0();
		SkeletalObserverHandle gachaItemObserver = this.GachaItemObserver;
		if (gachaItemObserver == null)
		{
			return;
		}
		WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(itemId);
		if (weaponConfigByItemId == null)
		{
			return;
		}
		SGachaWeaponTransform? value;
		CS$<>8__locals1.transformData = (DataTableUtil.TryGetDataTableRowStruct<SGachaWeaponTransform>(this.WeaponDataTable, itemId.ToString(), out value) ? value : GachaConfig.Instance.GetGachaWeaponTransformConfig(weaponConfigByItemId.Value.WeaponType));
		CS$<>8__locals1.weaponModel = gachaItemObserver.Model;
		if (CS$<>8__locals1.weaponModel == null)
		{
			return;
		}
		UiModelLoadComponent uiModelLoadComponent = CS$<>8__locals1.weaponModel.CheckGetComponent<UiModelLoadComponent>();
		CS$<>8__locals1.weaponActorComponent = CS$<>8__locals1.weaponModel.CheckGetComponent<UiModelActorComponent>();
		Action loadFinishCallBack = delegate()
		{
			if (CS$<>8__locals1.transformData == null || !CS$<>8__locals1.transformData.ShowScabbard)
			{
				UiModelUtil.Instance.SetVisible(CS$<>8__locals1.weaponModel, true);
			}
			AActor actorWithTag = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("WeaponCase").Value, ECollectActorType.UI);
			UiModelActorComponent weaponActorComponent = CS$<>8__locals1.weaponActorComponent;
			if (((weaponActorComponent != null) ? weaponActorComponent.Actor : null) != null && actorWithTag != null)
			{
				CS$<>8__locals1.weaponActorComponent.Actor.K2_AttachToActor(actorWithTag, null, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, false, true);
			}
			if (CS$<>8__locals1.transformData != null)
			{
				global::Transform transform = global::Transform.Create();
				global::Vector rotation = CS$<>8__locals1.transformData.Rotation;
				global::Rotator rotator = global::Rotator.Create((float)rotation.Y, (float)rotation.Z, (float)rotation.X);
				float size = CS$<>8__locals1.transformData.Size;
				global::Vector vector = global::Vector.Create((double)size, (double)size, (double)size);
				transform.SetLocation(new FVector((float)CS$<>8__locals1.transformData.Location.X, (float)CS$<>8__locals1.transformData.Location.Y, (float)CS$<>8__locals1.transformData.Location.Z));
				transform.SetRotation(rotator.Quaternion(null));
				transform.SetScale3D(vector.ToUeVector(false));
				FHitResult fhitResult = new FHitResult();
				UiModelActorComponent weaponActorComponent2 = CS$<>8__locals1.weaponActorComponent;
				if (weaponActorComponent2 != null)
				{
					USkeletalMeshComponent mainMeshComponent = weaponActorComponent2.MainMeshComponent;
					if (mainMeshComponent != null)
					{
						FTransformDouble ftransformDouble = transform.ToUeTransform();
						mainMeshComponent.D_K2_SetRelativeTransform(ftransformDouble, false, ref fhitResult, false);
					}
				}
				UiModelRotateComponent uiModelRotateComponent = CS$<>8__locals1.weaponModel.CheckGetComponent<UiModelRotateComponent>();
				if (uiModelRotateComponent != null)
				{
					uiModelRotateComponent.SetRotateParam(CS$<>8__locals1.transformData.RotateTime, ERotateAxis.Yaw, true);
				}
				FRotator newRotation = new FRotator((float)CS$<>8__locals1.transformData.AxisRotate.Y, (float)CS$<>8__locals1.transformData.AxisRotate.Z, (float)CS$<>8__locals1.transformData.AxisRotate.X);
				UiModelActorComponent weaponActorComponent3 = CS$<>8__locals1.weaponActorComponent;
				if (weaponActorComponent3 != null)
				{
					AActor actor = weaponActorComponent3.Actor;
					if (actor != null)
					{
						actor.K2_SetActorRotation(newRotation, false);
					}
				}
				if (uiModelRotateComponent == null)
				{
					return;
				}
				uiModelRotateComponent.StartRotate();
			}
		};
		int weaponBreachMaxLevel = WeaponModel.Instance.GetWeaponBreachMaxLevel(weaponConfigByItemId.Value.BreachId);
		UiModelUtil.Instance.SetWeaponLevelMaterialBreachLevel(CS$<>8__locals1.weaponModel, weaponBreachMaxLevel);
		if (uiModelLoadComponent != null)
		{
			uiModelLoadComponent.LoadModelByModelId(weaponConfigByItemId.Value.ModelId, false, loadFinishCallBack, null);
		}
		if (weaponConfigByItemId.Value.QualityId == 5)
		{
			BP_UpdateInteract_C updateInteractBP = this.UpdateInteractBP;
			if (updateInteractBP != null)
			{
				updateInteractBP.WeaponGolden();
			}
		}
		else if (weaponConfigByItemId.Value.QualityId == 4)
		{
			BP_UpdateInteract_C updateInteractBP2 = this.UpdateInteractBP;
			if (updateInteractBP2 != null)
			{
				updateInteractBP2.WeaponPurple();
			}
		}
		else if (weaponConfigByItemId.Value.QualityId == 3)
		{
			BP_UpdateInteract_C updateInteractBP3 = this.UpdateInteractBP;
			if (updateInteractBP3 != null)
			{
				updateInteractBP3.WeaponNormal();
			}
		}
		GachaScanView.<>c__DisplayClass62_0 CS$<>8__locals2 = CS$<>8__locals1;
		SkeletalObserverHandle gachaWeaponScabbardObserver = this.GachaWeaponScabbardObserver;
		CS$<>8__locals2.scabbardModel = ((gachaWeaponScabbardObserver != null) ? gachaWeaponScabbardObserver.Model : null);
		if (CS$<>8__locals1.scabbardModel == null)
		{
			return;
		}
		int[] array = weaponConfigByItemId.Value.Models();
		if (CS$<>8__locals1.transformData == null || !CS$<>8__locals1.transformData.ShowScabbard || array == null || array.Length <= 1)
		{
			UiModelUtil.Instance.SetVisible(CS$<>8__locals1.scabbardModel, false);
			return;
		}
		int modelId = array[1];
		UiModelLoadComponent uiModelLoadComponent2 = CS$<>8__locals1.scabbardModel.CheckGetComponent<UiModelLoadComponent>();
		Action loadFinishCallBack2 = delegate()
		{
			UiModelActorComponent uiModelActorComponent = CS$<>8__locals1.scabbardModel.CheckGetComponent<UiModelActorComponent>();
			if (((uiModelActorComponent != null) ? uiModelActorComponent.Actor : null) != null)
			{
				UiModelActorComponent weaponActorComponent = CS$<>8__locals1.weaponActorComponent;
				if (((weaponActorComponent != null) ? weaponActorComponent.Actor : null) != null)
				{
					uiModelActorComponent.Actor.K2_AttachToActor(CS$<>8__locals1.weaponActorComponent.Actor, null, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, false, true);
				}
			}
			if (CS$<>8__locals1.transformData != null)
			{
				global::Transform transform = global::Transform.Create();
				transform.SetLocation(new FVector((float)CS$<>8__locals1.transformData.ScabbardOffset.X, (float)CS$<>8__locals1.transformData.ScabbardOffset.Y, (float)CS$<>8__locals1.transformData.ScabbardOffset.Z));
				FHitResult fhitResult = new FHitResult();
				if (uiModelActorComponent != null)
				{
					USkeletalMeshComponent mainMeshComponent = uiModelActorComponent.MainMeshComponent;
					if (mainMeshComponent != null)
					{
						FTransformDouble ftransformDouble = transform.ToUeTransform();
						mainMeshComponent.D_K2_SetRelativeTransform(ftransformDouble, false, ref fhitResult, false);
					}
				}
			}
			UiModelUtil.Instance.SetVisible(CS$<>8__locals1.scabbardModel, true);
		};
		UiModelUtil.Instance.SetWeaponLevelMaterialBreachLevel(CS$<>8__locals1.scabbardModel, weaponBreachMaxLevel);
		if (uiModelLoadComponent2 == null)
		{
			return;
		}
		uiModelLoadComponent2.LoadModelByModelId(modelId, false, loadFinishCallBack2, null);
	}

	// Token: 0x0600DD3A RID: 56634 RVA: 0x0033BA4E File Offset: 0x00339C4E
	private void ShareBtn()
	{
		ChannelController.Instance.ShareGacha(new global::GachaResult[]
		{
			this.GetCurResult()
		});
	}

	// Token: 0x0600DD3B RID: 56635 RVA: 0x0033BA69 File Offset: 0x00339C69
	private void SkipBtn()
	{
		this.IsOnlyShowGold = true;
		this.AddIndex();
	}

	// Token: 0x0600DD3C RID: 56636 RVA: 0x0033BA78 File Offset: 0x00339C78
	private void NextBtn()
	{
		if (!this.IsCanContinue)
		{
			return;
		}
		this.AddIndex();
	}

	// Token: 0x0600DD3D RID: 56637 RVA: 0x0033BA8C File Offset: 0x00339C8C
	protected void AddIndex()
	{
		if (this.CurIndex >= this.GachaResult.Length - 1)
		{
			this.Finish();
			return;
		}
		if (this.IsOnlyShowGold)
		{
			int num = this.FindNextGoldIndex();
			if (num <= 0)
			{
				this.Finish();
				return;
			}
			this.LastIndex = this.CurIndex;
			this.CurIndex = num;
		}
		else
		{
			this.LastIndex = this.CurIndex;
			this.CurIndex++;
		}
		this.Refresh();
	}

	// Token: 0x0600DD3E RID: 56638 RVA: 0x0033BB04 File Offset: 0x00339D04
	private int FindNextGoldIndex()
	{
		for (int i = this.CurIndex + 1; i < this.GachaResult.Length; i++)
		{
			global::GachaResult gachaResult = this.GachaResult[i];
			int itemId = gachaResult.Proto_GachaReward.ItemId;
			GachaDefine.EItemQuality gachaQuality = GachaModel.Instance.GetGachaQuality(itemId);
			if (gachaQuality == GachaDefine.EItemQuality.Gold || (gachaQuality >= GachaDefine.EItemQuality.Purple && gachaResult.IsNew))
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x0600DD3F RID: 56639 RVA: 0x0033BB5F File Offset: 0x00339D5F
	protected void Finish()
	{
		GachaModel.Instance.CanCloseView = true;
		this.FinishAsync().Forget();
		GachaModel.Instance.CanCloseView = false;
	}

	// Token: 0x0600DD40 RID: 56640 RVA: 0x0033BB84 File Offset: 0x00339D84
	private UniTask FinishAsync()
	{
		GachaScanView.<FinishAsync>d__69 <FinishAsync>d__;
		<FinishAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FinishAsync>d__.<>4__this = this;
		<FinishAsync>d__.<>1__state = -1;
		<FinishAsync>d__.<>t__builder.Start<GachaScanView.<FinishAsync>d__69>(ref <FinishAsync>d__);
		return <FinishAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600DD41 RID: 56641 RVA: 0x0033BBC8 File Offset: 0x00339DC8
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		BlackScreenController.Instance.RemoveBlackScreen("Close", "GachaSkip", "Default");
		UiSceneManager.Instance.InitGachaItemObserver();
		this.GachaItemObserver = UiSceneManager.Instance.GetGachaItemObserver();
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.GachaScanView);
		this.GachaWeaponScabbardObserver = UiSceneManager.Instance.InitWeaponScabbardObserver();
		BP_GachaInteract_C bp_GachaInteract_C = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("GachaBP").Value, ECollectActorType.Default) as BP_GachaInteract_C;
		if (bp_GachaInteract_C != null && !bp_GachaInteract_C.IsSkip)
		{
			bp_GachaInteract_C.WhiteScreenOff();
		}
		UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroBloomEnable 1", null);
		this.WeaponDataTable = ResourceSystem.Instance.Load<UDataTable>("/Game/Aki/Data/GaCha/GachaWeaponTransform.GachaWeaponTransform", this.MemoryTag);
		this.InitProduct();
		IGachaViewOpenData gachaViewOpenData = this.OpenParam as IGachaViewOpenData;
		this.IsOnlyShowGold = (gachaViewOpenData != null && gachaViewOpenData.IsOnlyShowGold);
		if (this.IsOnlyShowGold)
		{
			this.CurIndex = -1;
			int num = this.FindNextGoldIndex();
			if (num > 0)
			{
				this.CurIndex = num;
			}
			else
			{
				this.CurIndex = 0;
			}
		}
		else
		{
			this.CurIndex = 0;
		}
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(6));
		this.UiLevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.UiLevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnUiLevelSequenceStop), false);
		int? intConfig = ConfigCommonParamById.GetIntConfig("GachaRoleBeforeEndFrame");
		if (intConfig != null)
		{
			this.RoleBeforeEndFrame = intConfig.Value;
		}
		int? intConfig2 = ConfigCommonParamById.GetIntConfig("GachaWeaponBeforeEndFrame");
		if (intConfig2 != null)
		{
			this.WeaponBeforeEndFrame = intConfig2.Value;
		}
		this.Refresh();
	}

	// Token: 0x0600DD42 RID: 56642 RVA: 0x0033BD64 File Offset: 0x00339F64
	protected override void OnBeforeHideImplement()
	{
		GameSettingsManager.Instance.ReApply(EFunction.BLOOM, EGameSettingsApplyReason.AnyTime, true);
		BP_UpdateInteract_C updateInteractBP = this.UpdateInteractBP;
		if (updateInteractBP != null && updateInteractBP.IsValid())
		{
			BP_UpdateInteract_C updateInteractBP2 = this.UpdateInteractBP;
			if (updateInteractBP2 != null)
			{
				updateInteractBP2.EndGachaScene();
			}
		}
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.None);
	}

	// Token: 0x0600DD43 RID: 56643 RVA: 0x0033BDB4 File Offset: 0x00339FB4
	protected override void OnBeforeDestroyImplementImplement()
	{
		this.WeaponDataTable = null;
		LevelSequencePlayer fiveStarLevelSequencePlayer = this.FiveStarLevelSequencePlayer;
		if (fiveStarLevelSequencePlayer != null)
		{
			fiveStarLevelSequencePlayer.Clear();
		}
		this.FiveStarLevelSequencePlayer = null;
		LevelSequencePlayer uiLevelSequencePlayer = this.UiLevelSequencePlayer;
		if (uiLevelSequencePlayer != null)
		{
			uiLevelSequencePlayer.Clear();
		}
		this.UiLevelSequencePlayer = null;
		UiSceneManager.Instance.DestroyGachaItemObserver();
		UiSceneManager.Instance.DestroyWeaponScabbardObserver(this.GachaWeaponScabbardObserver);
		this.GachaItemObserver = null;
		this.GachaWeaponScabbardObserver = null;
		if (this.PlayUiSequenceTimerId != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.PlayUiSequenceTimerId);
			this.PlayUiSequenceTimerId = null;
		}
		this.RestoreDlss();
	}

	// Token: 0x0600DD44 RID: 56644 RVA: 0x0033BE48 File Offset: 0x0033A048
	[NullableContext(1)]
	protected void OnSequenceEventByStringParam(string param)
	{
		SkeletalObserverHandle gachaItemObserver = this.GachaItemObserver;
		SkeletalObserverHandle gachaWeaponScabbardObserver = this.GachaWeaponScabbardObserver;
		UiModelBase uiModelBase = (gachaItemObserver != null) ? gachaItemObserver.Model : null;
		UiModelBase uiModelBase2 = (gachaWeaponScabbardObserver != null) ? gachaWeaponScabbardObserver.Model : null;
		if (!(param == "Flash1"))
		{
			if (!(param == "Flash2"))
			{
				if (!(param == "WeaponDA"))
				{
					if (!(param == "WeaponEffect"))
					{
						if (!(param == "RemoveWeaponDA"))
						{
							return;
						}
						if (uiModelBase != null)
						{
							UiModelUtil.Instance.RemoveRenderingMaterial(uiModelBase, this.MaterialId);
							UiModelUtil.Instance.RemoveRenderingMaterial(uiModelBase, this.WeaponColorMaterialId);
						}
						if (uiModelBase2 != null)
						{
							UiModelUtil.Instance.RemoveRenderingMaterial(uiModelBase2, this.ScabbardMaterialId);
							UiModelUtil.Instance.RemoveRenderingMaterial(uiModelBase2, this.WeaponColorScabbardMaterialId);
						}
					}
					else if (this.CurQuality == 5)
					{
						if (uiModelBase != null)
						{
							this.WeaponColorMaterialId = UiModelUtil.Instance.SetRenderingMaterial(uiModelBase, "GachaBurstGoldController");
						}
						if (uiModelBase2 != null)
						{
							this.WeaponColorScabbardMaterialId = UiModelUtil.Instance.SetRenderingMaterial(uiModelBase2, "GachaBurstGoldController");
							return;
						}
					}
					else if (this.CurQuality == 4)
					{
						if (uiModelBase != null)
						{
							this.WeaponColorMaterialId = UiModelUtil.Instance.SetRenderingMaterial(uiModelBase, "GachaBurstPurpleController");
						}
						if (uiModelBase2 != null)
						{
							this.WeaponColorScabbardMaterialId = UiModelUtil.Instance.SetRenderingMaterial(uiModelBase2, "GachaBurstPurpleController");
							return;
						}
					}
					else if (this.CurQuality == 3)
					{
						if (uiModelBase != null)
						{
							this.WeaponColorMaterialId = UiModelUtil.Instance.SetRenderingMaterial(uiModelBase, "GachaBurstWhiteController");
						}
						if (uiModelBase2 != null)
						{
							this.WeaponColorScabbardMaterialId = UiModelUtil.Instance.SetRenderingMaterial(uiModelBase2, "GachaBurstWhiteController");
							return;
						}
					}
				}
				else
				{
					if (uiModelBase != null)
					{
						this.MaterialId = UiModelUtil.Instance.SetRenderingMaterial(uiModelBase, "GachaMaterialController");
					}
					if (uiModelBase2 != null)
					{
						this.ScabbardMaterialId = UiModelUtil.Instance.SetRenderingMaterial(uiModelBase2, "GachaMaterialController");
						return;
					}
				}
			}
			else
			{
				AudioSystem.Instance.PostEvent("ui_gacha_scan_burst");
				if (this.CurQuality == 5)
				{
					this.EffectGold.SetActorHiddenInGame(false);
					ANiagaraActor effectGold = this.EffectGold;
					if (effectGold == null)
					{
						return;
					}
					effectGold.NiagaraComponent.ReinitializeSystem();
					return;
				}
				else if (this.CurQuality == 4)
				{
					this.EffectPurple.SetActorHiddenInGame(false);
					ANiagaraActor effectPurple = this.EffectPurple;
					if (effectPurple == null)
					{
						return;
					}
					effectPurple.NiagaraComponent.ReinitializeSystem();
					return;
				}
				else if (this.CurQuality == 3)
				{
					this.EffectWhite.SetActorHiddenInGame(false);
					ANiagaraActor effectWhite = this.EffectWhite;
					if (effectWhite == null)
					{
						return;
					}
					effectWhite.NiagaraComponent.ReinitializeSystem();
					return;
				}
			}
			return;
		}
		this.CameraEffect.NiagaraComponent.ReinitializeSystem();
	}

	// Token: 0x0600DD45 RID: 56645 RVA: 0x0033C0A8 File Offset: 0x0033A2A8
	protected override void OnBeforeDestroy()
	{
		base.AddChild(this.ConvertItem);
		base.AddChild(this.ExtraItem);
		this.HideRoleSequence();
		GachaModel.Instance.ReleaseLoadGachaSequence();
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("RefreshModel");
		UKuroSequencePerformanceManager.CloseKuroPerformanceMode();
		if (this.NeedProcessSkyBlending)
		{
			UKuroSequencePerformanceManager.SimpleExecuteCommand("r.SkyBlending.AllowSettingLerpPerFrame 0");
		}
		if (Info.Instance.IsLowMemoryDevice && this.OriginDepthOfFieldQuality != 0)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.DepthOfFieldQuality ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.OriginDepthOfFieldQuality);
			UKuroSequencePerformanceManager.SimpleExecuteCommand(defaultInterpolatedStringHandler.ToStringAndClear());
		}
		if (Info.Instance.IsMacPlatform())
		{
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.AllowHardwareOcclusion 1", null);
		}
		RenderUtil.EndPSOSyncMode();
	}

	// Token: 0x0600DD46 RID: 56646 RVA: 0x0033C168 File Offset: 0x0033A368
	[NullableContext(1)]
	private void OnActivitySequenceEmitEvent(string param)
	{
		if (this.StarLayout == null)
		{
			return;
		}
		if (param == "GachaStart")
		{
			UUIInturnAnimController uuiinturnAnimController = base.GetHorizontalLayout(6).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController;
			if (uuiinturnAnimController != null)
			{
				uuiinturnAnimController.Play("", this.StarLayout.GetDisplayCount(), false);
			}
		}
	}

	// Token: 0x0600DD47 RID: 56647 RVA: 0x0033C1C6 File Offset: 0x0033A3C6
	[NullableContext(1)]
	private void OnUiLevelSequenceStop(string seqName)
	{
		if (seqName == "Show" && this.IsWeaponToEnd)
		{
			this.IsCanContinue = true;
		}
	}

	// Token: 0x0400656E RID: 25966
	private const int XINYUEHU_WEAPON_ID = 21050116;

	// Token: 0x0400656F RID: 25967
	[Nullable(1)]
	private const string DLSS_ENABLE_CVAR = "r.NGX.DLSS.Enable";

	// Token: 0x04006570 RID: 25968
	public static readonly FName SCENE_CAMERA_TAG = FNameUtil.GetDynamicFName("SequenceCamera").Value;

	// Token: 0x04006571 RID: 25969
	public static readonly FName SCENE_ROLE_TAG = FNameUtil.GetDynamicFName("Role").Value;

	// Token: 0x04006572 RID: 25970
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected global::GachaResult[] GachaResult;

	// Token: 0x04006573 RID: 25971
	protected int CurIndex;

	// Token: 0x04006574 RID: 25972
	protected int LastIndex = -1;

	// Token: 0x04006575 RID: 25973
	private SmallItemGrid ConvertItem;

	// Token: 0x04006576 RID: 25974
	private SmallItemGrid ExtraItem;

	// Token: 0x04006577 RID: 25975
	private ULevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006578 RID: 25976
	private LevelSequencePlayer FiveStarLevelSequencePlayer;

	// Token: 0x04006579 RID: 25977
	private LevelSequencePlayer UiLevelSequencePlayer;

	// Token: 0x0400657A RID: 25978
	private ALevelSequenceActor SequenceActor;

	// Token: 0x0400657B RID: 25979
	private ANiagaraActor CameraEffect;

	// Token: 0x0400657C RID: 25980
	private ANiagaraActor EffectGold;

	// Token: 0x0400657D RID: 25981
	private ANiagaraActor EffectPurple;

	// Token: 0x0400657E RID: 25982
	private ANiagaraActor EffectWhite;

	// Token: 0x0400657F RID: 25983
	private AActor SceneCamera;

	// Token: 0x04006580 RID: 25984
	private SimpleGenericLayout StarLayout;

	// Token: 0x04006581 RID: 25985
	private ShareRewardInfo ShareRewardInfo;

	// Token: 0x04006582 RID: 25986
	private int MaterialId;

	// Token: 0x04006583 RID: 25987
	private int ScabbardMaterialId;

	// Token: 0x04006584 RID: 25988
	private int WeaponColorMaterialId;

	// Token: 0x04006585 RID: 25989
	private int WeaponColorScabbardMaterialId;

	// Token: 0x04006586 RID: 25990
	private BP_UpdateInteract_C UpdateInteractBP;

	// Token: 0x04006587 RID: 25991
	private int CurQuality;

	// Token: 0x04006588 RID: 25992
	private bool IsOnlyShowGold;

	// Token: 0x04006589 RID: 25993
	private UDataTable WeaponDataTable;

	// Token: 0x0400658A RID: 25994
	private TimerHandle PlayUiSequenceTimerId;

	// Token: 0x0400658B RID: 25995
	private int RoleBeforeEndFrame = 190;

	// Token: 0x0400658C RID: 25996
	private int WeaponBeforeEndFrame = 190;

	// Token: 0x0400658D RID: 25997
	private bool IsCanContinue;

	// Token: 0x0400658E RID: 25998
	private bool IsWeaponToEnd;

	// Token: 0x0400658F RID: 25999
	private AActor OriginalCamera;

	// Token: 0x04006590 RID: 26000
	private bool NeedProcessSkyBlending;

	// Token: 0x04006591 RID: 26001
	private int OriginDepthOfFieldQuality;

	// Token: 0x04006592 RID: 26002
	private int? OriginDlssEnableValue;

	// Token: 0x04006593 RID: 26003
	private SkeletalObserverHandle GachaItemObserver;

	// Token: 0x04006594 RID: 26004
	private SkeletalObserverHandle GachaWeaponScabbardObserver;

	// Token: 0x0200827D RID: 33405
	[NullableContext(0)]
	private enum EGachaScanCom
	{
		// Token: 0x0402A92F RID: 174383
		SkipBtn,
		// Token: 0x0402A930 RID: 174384
		NextBtn,
		// Token: 0x0402A931 RID: 174385
		NameText,
		// Token: 0x0402A932 RID: 174386
		AttributesItem,
		// Token: 0x0402A933 RID: 174387
		AttributeTexture,
		// Token: 0x0402A934 RID: 174388
		AttributeBoxTexture,
		// Token: 0x0402A935 RID: 174389
		StarLayout,
		// Token: 0x0402A936 RID: 174390
		ConvertParentItem,
		// Token: 0x0402A937 RID: 174391
		ConvertItem,
		// Token: 0x0402A938 RID: 174392
		ExtraParentItem,
		// Token: 0x0402A939 RID: 174393
		ExtraItem,
		// Token: 0x0402A93A RID: 174394
		NewItem,
		// Token: 0x0402A93B RID: 174395
		FiveStarPanel,
		// Token: 0x0402A93C RID: 174396
		InfoPanel,
		// Token: 0x0402A93D RID: 174397
		BottomExtraRewardParentItem,
		// Token: 0x0402A93E RID: 174398
		BottomExtraRewardTexture,
		// Token: 0x0402A93F RID: 174399
		BottomExtraRewardCountText,
		// Token: 0x0402A940 RID: 174400
		BottomExtraRewardNameText,
		// Token: 0x0402A941 RID: 174401
		ShareInfo,
		// Token: 0x0402A942 RID: 174402
		ShareBtn,
		// Token: 0x0402A943 RID: 174403
		ShareReward,
		// Token: 0x0402A944 RID: 174404
		ShareRewardTip,
		// Token: 0x0402A945 RID: 174405
		PanelMask
	}
}
