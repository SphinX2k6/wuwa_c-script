using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020028F3 RID: 10483
[NullableContext(2)]
[Nullable(0)]
public class RoleNewJoinView : UiViewBase
{
	// Token: 0x06015A3F RID: 88639 RVA: 0x00576469 File Offset: 0x00574669
	[NullableContext(1)]
	public RoleNewJoinView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015A40 RID: 88640 RVA: 0x00576474 File Offset: 0x00574674
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUITexture)),
			new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.DetailBtn)),
			new ValueTuple<int, Delegate>(7, new Action(this.CloseBtn))
		};
	}

	// Token: 0x06015A41 RID: 88641 RVA: 0x00576578 File Offset: 0x00574778
	protected override void OnBeforeCreate()
	{
		this.RoleId = (int)(this.OpenParam ?? 0);
		RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(this.RoleId);
		if (roleInfoById != null)
		{
			this.CurQuality = roleInfoById.Value.QualityId;
		}
		this.GachaSequence = new UiBehaviorGachaSequence();
		base.AddUiBehavior(this.GachaSequence);
	}

	// Token: 0x06015A42 RID: 88642 RVA: 0x005765E8 File Offset: 0x005747E8
	protected override UniTask OnCreateAsync()
	{
		RoleNewJoinView.<OnCreateAsync>d__16 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<RoleNewJoinView.<OnCreateAsync>d__16>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015A43 RID: 88643 RVA: 0x00576624 File Offset: 0x00574824
	protected override UniTask OnBeforeStartAsync()
	{
		RoleNewJoinView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleNewJoinView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015A44 RID: 88644 RVA: 0x00576667 File Offset: 0x00574867
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(4));
	}

	// Token: 0x06015A45 RID: 88645 RVA: 0x0057667B File Offset: 0x0057487B
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnSequenceEventByStringParam));
		EventSystem.Instance.Add(EEventName.CloseGachaSceneView, new Action(this.CloseViewEvent));
	}

	// Token: 0x06015A46 RID: 88646 RVA: 0x005766B8 File Offset: 0x005748B8
	protected override void OnHandleLoadScene()
	{
		this.SceneCamera = UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("SceneCamera1").Value, ECollectActorType.Default);
		if (this.GachaSequence != null && this.SceneCamera != null)
		{
			this.GachaSequence.BindSceneSequenceCamera(this.SceneCamera);
		}
		this.CameraEffect = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("Flash1").Value, ECollectActorType.Default) as ANiagaraActor);
		this.EffectGold = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("BurstGold").Value, ECollectActorType.Default) as ANiagaraActor);
		this.EffectPurple = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("BurstPurple").Value, ECollectActorType.Default) as ANiagaraActor);
		this.EffectWhite = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("BurstWhite").Value, ECollectActorType.Default) as ANiagaraActor);
		this.UpdateInteractBP = (UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName("UpdateInteractBP").Value, ECollectActorType.Default) as BP_UpdateInteract_C);
		if (this.UpdateInteractBP != null)
		{
			this.UpdateInteractBP.SetTickableWhenPaused(true);
			if (this.GachaSequence != null)
			{
				this.GachaSequence.BindUpdateInteractBp(this.UpdateInteractBP);
			}
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
		this.UiCameraHandleData = UiCameraAnimationManager.Instance.PushCameraHandleByHandleName("1041_New", true, true, "10007", false, null, null);
	}

	// Token: 0x06015A47 RID: 88647 RVA: 0x005769C5 File Offset: 0x00574BC5
	protected override void OnAfterShow()
	{
		this.IsDetail = false;
		this.Refresh();
	}

	// Token: 0x06015A48 RID: 88648 RVA: 0x005769D4 File Offset: 0x00574BD4
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnSequenceEventByStringParam));
		EventSystem.Instance.Remove(EEventName.CloseGachaSceneView, new Action(this.CloseViewEvent));
	}

	// Token: 0x06015A49 RID: 88649 RVA: 0x00576A0E File Offset: 0x00574C0E
	protected override void OnBeforeDestroy()
	{
		if (this.UiCameraHandleData != null)
		{
			UiCameraAnimationManager.Instance.PopCameraHandle(this.UiCameraHandleData, "10007");
		}
	}

	// Token: 0x06015A4A RID: 88650 RVA: 0x00576A30 File Offset: 0x00574C30
	[NullableContext(1)]
	protected void OnSequenceEventByStringParam(string param)
	{
		if (!(param == "Flash1"))
		{
			if (!(param == "Flash2"))
			{
				return;
			}
			if (this.CurQuality == 5)
			{
				if (this.EffectGold != null)
				{
					this.EffectGold.SetActorHiddenInGame(false);
					UNiagaraComponent niagaraComponent = this.EffectGold.NiagaraComponent;
					if (niagaraComponent == null)
					{
						return;
					}
					niagaraComponent.ReinitializeSystem();
					return;
				}
			}
			else if (this.CurQuality == 4)
			{
				if (this.EffectPurple != null)
				{
					this.EffectPurple.SetActorHiddenInGame(false);
					UNiagaraComponent niagaraComponent2 = this.EffectPurple.NiagaraComponent;
					if (niagaraComponent2 == null)
					{
						return;
					}
					niagaraComponent2.ReinitializeSystem();
					return;
				}
			}
			else if (this.CurQuality == 3 && this.EffectWhite != null)
			{
				this.EffectWhite.SetActorHiddenInGame(false);
				UNiagaraComponent niagaraComponent3 = this.EffectWhite.NiagaraComponent;
				if (niagaraComponent3 == null)
				{
					return;
				}
				niagaraComponent3.ReinitializeSystem();
			}
			return;
		}
		else
		{
			ANiagaraActor cameraEffect = this.CameraEffect;
			if (cameraEffect == null)
			{
				return;
			}
			UNiagaraComponent niagaraComponent4 = cameraEffect.NiagaraComponent;
			if (niagaraComponent4 == null)
			{
				return;
			}
			niagaraComponent4.ReinitializeSystem();
			return;
		}
	}

	// Token: 0x06015A4B RID: 88651 RVA: 0x00576B10 File Offset: 0x00574D10
	private void Refresh()
	{
		this.HideBackgroundEffects();
		this.RefreshView();
		this.PlayGachaSequence();
		this.UiViewSequence.StopPrevSequence(false, false);
		this.UiViewSequence.PlaySequence("Show", true, null);
	}

	// Token: 0x06015A4C RID: 88652 RVA: 0x00576B58 File Offset: 0x00574D58
	private void RefreshView()
	{
		int roleId = this.RoleId;
		RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(roleId);
		if (roleInfoById == null)
		{
			return;
		}
		ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(roleInfoById.Value.ElementId);
		if (elementConfig != null)
		{
			base.GetTexture(3).SetColor(FColor.FromHex(elementConfig.Value.ElementColor));
			UUITexture texture = base.GetTexture(2);
			base.SetTextureByPath(elementConfig.Value.Icon, texture, null, null);
			FColor color = FColor.FromHex(elementConfig.Value.ElementColor);
			if (texture != null)
			{
				texture.SetColor(color);
			}
		}
		base.GetText(0).ShowTextNew(roleInfoById.Value.Name);
		base.GetText(5).ShowTextNew(roleInfoById.Value.Introduction);
		this.StarLayout.RebuildLayout(this.CurQuality);
		BlackScreenController.Instance.RemoveBlackScreen("Close", EUiViewName.RoleNewJoinView, "Default");
	}

	// Token: 0x06015A4D RID: 88653 RVA: 0x00576C7C File Offset: 0x00574E7C
	protected void PlayGachaSequence()
	{
		if (this.GachaSequence == null)
		{
			return;
		}
		FMovieSceneSequencePlaybackSettings fmovieSceneSequencePlaybackSettings = new FMovieSceneSequencePlaybackSettings();
		fmovieSceneSequencePlaybackSettings.bRestoreState = true;
		fmovieSceneSequencePlaybackSettings.bPauseAtEnd = true;
		this.GachaSequence.SetSequencePlayBackSetting(this.RoleId, fmovieSceneSequencePlaybackSettings);
		this.GachaSequence.PlayRoleSequence(this.RoleId, 0);
		this.ShowRole();
	}

	// Token: 0x06015A4E RID: 88654 RVA: 0x00576CD0 File Offset: 0x00574ED0
	private void ShowRole()
	{
		RoleInfo? roleInfoById = GachaConfig.Instance.GetRoleInfoById(this.RoleId);
		if (roleInfoById == null)
		{
			return;
		}
		if (roleInfoById.Value.Id == 1302)
		{
			BP_UpdateInteract_C updateInteractBP = this.UpdateInteractBP;
			if (updateInteractBP == null)
			{
				return;
			}
			updateInteractBP.Yinlin();
			return;
		}
		else if (roleInfoById.Value.Id == 1404)
		{
			BP_UpdateInteract_C updateInteractBP2 = this.UpdateInteractBP;
			if (updateInteractBP2 == null)
			{
				return;
			}
			updateInteractBP2.Jiyan();
			return;
		}
		else if (roleInfoById.Value.Id == 1203)
		{
			BP_UpdateInteract_C updateInteractBP3 = this.UpdateInteractBP;
			if (updateInteractBP3 == null)
			{
				return;
			}
			updateInteractBP3.Anke();
			return;
		}
		else if (roleInfoById.Value.Id == 1503)
		{
			BP_UpdateInteract_C updateInteractBP4 = this.UpdateInteractBP;
			if (updateInteractBP4 == null)
			{
				return;
			}
			updateInteractBP4.Jueyuan();
			return;
		}
		else if (roleInfoById.Value.Id == 1301)
		{
			BP_UpdateInteract_C updateInteractBP5 = this.UpdateInteractBP;
			if (updateInteractBP5 == null)
			{
				return;
			}
			updateInteractBP5.Kakaluo();
			return;
		}
		else if (roleInfoById.Value.Id == 1603)
		{
			BP_UpdateInteract_C updateInteractBP6 = this.UpdateInteractBP;
			if (updateInteractBP6 == null)
			{
				return;
			}
			updateInteractBP6.Chun();
			return;
		}
		else if (roleInfoById.Value.Id == 1104)
		{
			BP_UpdateInteract_C updateInteractBP7 = this.UpdateInteractBP;
			if (updateInteractBP7 == null)
			{
				return;
			}
			updateInteractBP7.Awu();
			return;
		}
		else
		{
			if (roleInfoById.Value.QualityId != 5)
			{
				if (roleInfoById.Value.QualityId == 4)
				{
					BP_UpdateInteract_C updateInteractBP8 = this.UpdateInteractBP;
					if (updateInteractBP8 == null)
					{
						return;
					}
					updateInteractBP8.CharacterPurple();
				}
				return;
			}
			BP_UpdateInteract_C updateInteractBP9 = this.UpdateInteractBP;
			if (updateInteractBP9 == null)
			{
				return;
			}
			updateInteractBP9.CharacterGolden();
			return;
		}
	}

	// Token: 0x06015A4F RID: 88655 RVA: 0x00576E50 File Offset: 0x00575050
	private void HideBackgroundEffects()
	{
		if (this.EffectGold != null)
		{
			this.EffectGold.SetActorHiddenInGame(true);
			UNiagaraComponent niagaraComponent = this.EffectGold.NiagaraComponent;
			if (niagaraComponent != null)
			{
				niagaraComponent.Deactivate();
			}
		}
		if (this.EffectPurple != null)
		{
			this.EffectPurple.SetActorHiddenInGame(true);
			UNiagaraComponent niagaraComponent2 = this.EffectPurple.NiagaraComponent;
			if (niagaraComponent2 != null)
			{
				niagaraComponent2.Deactivate();
			}
		}
		if (this.EffectWhite != null)
		{
			this.EffectWhite.SetActorHiddenInGame(true);
			UNiagaraComponent niagaraComponent3 = this.EffectWhite.NiagaraComponent;
			if (niagaraComponent3 == null)
			{
				return;
			}
			niagaraComponent3.Deactivate();
		}
	}

	// Token: 0x06015A50 RID: 88656 RVA: 0x00576EDA File Offset: 0x005750DA
	private void Finish()
	{
		EventSystem.Instance.Emit(EEventName.CloseGachaSceneView);
	}

	// Token: 0x06015A51 RID: 88657 RVA: 0x00576EEC File Offset: 0x005750EC
	protected void CloseViewEvent()
	{
		this.BindCloseUiScene();
	}

	// Token: 0x06015A52 RID: 88658 RVA: 0x00576EF4 File Offset: 0x005750F4
	private void BindCloseUiScene()
	{
		this.AfterCloseUiScene(true);
	}

	// Token: 0x06015A53 RID: 88659 RVA: 0x00576EFD File Offset: 0x005750FD
	private void AfterCloseUiScene(bool ret)
	{
		if (!ret)
		{
			return;
		}
		if (UiManager.Instance.IsViewShow(this.ViewInfo.Name))
		{
			base.CloseMe(null);
		}
		EventSystem.Instance.Emit(EEventName.AfterCloseGachaScene);
	}

	// Token: 0x06015A54 RID: 88660 RVA: 0x00576F31 File Offset: 0x00575131
	private void CloseBtn()
	{
		this.Finish();
	}

	// Token: 0x06015A55 RID: 88661 RVA: 0x00576F39 File Offset: 0x00575139
	private void DetailBtn()
	{
		if (this.IsDetail)
		{
			return;
		}
		this.IsDetail = true;
		this.ClickDetail().Forget();
	}

	// Token: 0x06015A56 RID: 88662 RVA: 0x00576F58 File Offset: 0x00575158
	private UniTask ClickDetail()
	{
		RoleNewJoinView.<ClickDetail>d__36 <ClickDetail>d__;
		<ClickDetail>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ClickDetail>d__.<>4__this = this;
		<ClickDetail>d__.<>1__state = -1;
		<ClickDetail>d__.<>t__builder.Start<RoleNewJoinView.<ClickDetail>d__36>(ref <ClickDetail>d__);
		return <ClickDetail>d__.<>t__builder.Task;
	}

	// Token: 0x0400A0F5 RID: 41205
	private int RoleId;

	// Token: 0x0400A0F6 RID: 41206
	protected UiCameraHandleData UiCameraHandleData;

	// Token: 0x0400A0F7 RID: 41207
	private ANiagaraActor CameraEffect;

	// Token: 0x0400A0F8 RID: 41208
	private ANiagaraActor EffectGold;

	// Token: 0x0400A0F9 RID: 41209
	private ANiagaraActor EffectPurple;

	// Token: 0x0400A0FA RID: 41210
	private ANiagaraActor EffectWhite;

	// Token: 0x0400A0FB RID: 41211
	private AActor SceneCamera;

	// Token: 0x0400A0FC RID: 41212
	private BP_UpdateInteract_C UpdateInteractBP;

	// Token: 0x0400A0FD RID: 41213
	private SimpleGenericLayout StarLayout;

	// Token: 0x0400A0FE RID: 41214
	private UiBehaviorGachaSequence GachaSequence;

	// Token: 0x0400A0FF RID: 41215
	private int CurQuality;

	// Token: 0x0400A100 RID: 41216
	private bool IsDetail;

	// Token: 0x02008EFC RID: 36604
	[NullableContext(0)]
	private enum ERoleNewJoinComponents
	{
		// Token: 0x0402E5CC RID: 189900
		NameText,
		// Token: 0x0402E5CD RID: 189901
		AttributesItem,
		// Token: 0x0402E5CE RID: 189902
		AttributesTexture,
		// Token: 0x0402E5CF RID: 189903
		AttributesBoxSprite,
		// Token: 0x0402E5D0 RID: 189904
		StarParentItem,
		// Token: 0x0402E5D1 RID: 189905
		TxtDetail,
		// Token: 0x0402E5D2 RID: 189906
		BtnConfirm,
		// Token: 0x0402E5D3 RID: 189907
		BtnBack
	}
}
