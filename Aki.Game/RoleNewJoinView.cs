using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Scene.NewGacha.BP;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BlackScreen;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E6E RID: 7790
[NullableContext(2)]
[Nullable(0)]
public class RoleNewJoinView : UiViewBase
{
	// Token: 0x06013443 RID: 78915 RVA: 0x005A133D File Offset: 0x0059F53D
	[NullableContext(1)]
	public RoleNewJoinView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013444 RID: 78916 RVA: 0x005A1348 File Offset: 0x0059F548
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

	// Token: 0x06013445 RID: 78917 RVA: 0x005A144C File Offset: 0x0059F64C
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

	// Token: 0x06013446 RID: 78918 RVA: 0x005A14BC File Offset: 0x0059F6BC
	protected override UniTask OnCreateAsync()
	{
		RoleNewJoinView.<OnCreateAsync>d__16 <OnCreateAsync>d__;
		<OnCreateAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCreateAsync>d__.<>1__state = -1;
		<OnCreateAsync>d__.<>t__builder.Start<RoleNewJoinView.<OnCreateAsync>d__16>(ref <OnCreateAsync>d__);
		return <OnCreateAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013447 RID: 78919 RVA: 0x005A14F8 File Offset: 0x0059F6F8
	protected override UniTask OnBeforeStartAsync()
	{
		RoleNewJoinView.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleNewJoinView.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013448 RID: 78920 RVA: 0x005A153B File Offset: 0x0059F73B
	protected override void OnStart()
	{
		this.StarLayout = new SimpleGenericLayout(base.GetHorizontalLayout(4));
	}

	// Token: 0x06013449 RID: 78921 RVA: 0x005A154F File Offset: 0x0059F74F
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<string>(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnSequenceEventByStringParam));
		EventSystem.Instance.Add(EEventName.CloseGachaSceneView, new Action(this.CloseViewEvent));
	}

	// Token: 0x0601344A RID: 78922 RVA: 0x005A158C File Offset: 0x0059F78C
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
		this.UiCameraHandleData = UiCameraModel.Instance.PushCameraHandleByHandleName("1041_New", true, true, "10007", false, null);
	}

	// Token: 0x0601344B RID: 78923 RVA: 0x005A188F File Offset: 0x0059FA8F
	protected override void OnAfterShow()
	{
		this.IsDetail = false;
		this.Refresh();
	}

	// Token: 0x0601344C RID: 78924 RVA: 0x005A189E File Offset: 0x0059FA9E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PlaySequenceEventByStringParam, new Action<string>(this.OnSequenceEventByStringParam));
		EventSystem.Instance.Remove(EEventName.CloseGachaSceneView, new Action(this.CloseViewEvent));
	}

	// Token: 0x0601344D RID: 78925 RVA: 0x005A18D8 File Offset: 0x0059FAD8
	protected override void OnBeforeDestroy()
	{
		if (this.UiCameraHandleData != null)
		{
			UiCameraModel.Instance.PopCameraHandle(this.UiCameraHandleData, "10007");
		}
	}

	// Token: 0x0601344E RID: 78926 RVA: 0x005A18F8 File Offset: 0x0059FAF8
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

	// Token: 0x0601344F RID: 78927 RVA: 0x005A19D8 File Offset: 0x0059FBD8
	private void Refresh()
	{
		this.HideBackgroundEffects();
		this.RefreshView();
		this.PlayGachaSequence();
		this.UiViewSequence.StopPrevSequence(false, false);
		this.UiViewSequence.PlaySequence("Show", true, null);
	}

	// Token: 0x06013450 RID: 78928 RVA: 0x005A1A20 File Offset: 0x0059FC20
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

	// Token: 0x06013451 RID: 78929 RVA: 0x005A1B44 File Offset: 0x0059FD44
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

	// Token: 0x06013452 RID: 78930 RVA: 0x005A1B98 File Offset: 0x0059FD98
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

	// Token: 0x06013453 RID: 78931 RVA: 0x005A1D18 File Offset: 0x0059FF18
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

	// Token: 0x06013454 RID: 78932 RVA: 0x005A1DA2 File Offset: 0x0059FFA2
	private void Finish()
	{
		EventSystem.Instance.Emit(EEventName.CloseGachaSceneView);
	}

	// Token: 0x06013455 RID: 78933 RVA: 0x005A1DB4 File Offset: 0x0059FFB4
	protected void CloseViewEvent()
	{
		this.BindCloseUiScene();
	}

	// Token: 0x06013456 RID: 78934 RVA: 0x005A1DBC File Offset: 0x0059FFBC
	private void BindCloseUiScene()
	{
		this.AfterCloseUiScene(true);
	}

	// Token: 0x06013457 RID: 78935 RVA: 0x005A1DC5 File Offset: 0x0059FFC5
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

	// Token: 0x06013458 RID: 78936 RVA: 0x005A1DF9 File Offset: 0x0059FFF9
	private void CloseBtn()
	{
		this.Finish();
	}

	// Token: 0x06013459 RID: 78937 RVA: 0x005A1E01 File Offset: 0x005A0001
	private void DetailBtn()
	{
		if (this.IsDetail)
		{
			return;
		}
		this.IsDetail = true;
		this.ClickDetail().Forget();
	}

	// Token: 0x0601345A RID: 78938 RVA: 0x005A1E20 File Offset: 0x005A0020
	private UniTask ClickDetail()
	{
		RoleNewJoinView.<ClickDetail>d__36 <ClickDetail>d__;
		<ClickDetail>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ClickDetail>d__.<>4__this = this;
		<ClickDetail>d__.<>1__state = -1;
		<ClickDetail>d__.<>t__builder.Start<RoleNewJoinView.<ClickDetail>d__36>(ref <ClickDetail>d__);
		return <ClickDetail>d__.<>t__builder.Task;
	}

	// Token: 0x0400A4E0 RID: 42208
	private int RoleId;

	// Token: 0x0400A4E1 RID: 42209
	protected UiCameraHandleData UiCameraHandleData;

	// Token: 0x0400A4E2 RID: 42210
	private ANiagaraActor CameraEffect;

	// Token: 0x0400A4E3 RID: 42211
	private ANiagaraActor EffectGold;

	// Token: 0x0400A4E4 RID: 42212
	private ANiagaraActor EffectPurple;

	// Token: 0x0400A4E5 RID: 42213
	private ANiagaraActor EffectWhite;

	// Token: 0x0400A4E6 RID: 42214
	private AActor SceneCamera;

	// Token: 0x0400A4E7 RID: 42215
	private BP_UpdateInteract_C UpdateInteractBP;

	// Token: 0x0400A4E8 RID: 42216
	private SimpleGenericLayout StarLayout;

	// Token: 0x0400A4E9 RID: 42217
	private UiBehaviorGachaSequence GachaSequence;

	// Token: 0x0400A4EA RID: 42218
	private int CurQuality;

	// Token: 0x0400A4EB RID: 42219
	private bool IsDetail;

	// Token: 0x02008144 RID: 33092
	[NullableContext(0)]
	private enum ERoleNewJoinComponents
	{
		// Token: 0x04029CC7 RID: 171207
		NameText,
		// Token: 0x04029CC8 RID: 171208
		AttributesItem,
		// Token: 0x04029CC9 RID: 171209
		AttributesTexture,
		// Token: 0x04029CCA RID: 171210
		AttributesBoxSprite,
		// Token: 0x04029CCB RID: 171211
		StarParentItem,
		// Token: 0x04029CCC RID: 171212
		TxtDetail,
		// Token: 0x04029CCD RID: 171213
		BtnConfirm,
		// Token: 0x04029CCE RID: 171214
		BtnBack
	}
}
