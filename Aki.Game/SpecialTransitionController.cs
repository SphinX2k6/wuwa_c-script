using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001FF9 RID: 8185
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SpecialTransitionController : ControllerBase
{
	// Token: 0x06014482 RID: 83074 RVA: 0x005E90B9 File Offset: 0x005E72B9
	[NullableContext(2)]
	public static bool IsTeleportPbLoadingMode(TransitionWithSpineLoadingPb pb)
	{
		object obj;
		if (pb == null)
		{
			obj = null;
		}
		else
		{
			ICustomScreenTypeBasePb icustomScreenTypeBasePb = pb.ICustomScreenTypeBasePb;
			obj = ((icustomScreenTypeBasePb != null) ? icustomScreenTypeBasePb.ICustomScreenLoadingPb : null);
		}
		return obj != null;
	}

	// Token: 0x06014483 RID: 83075 RVA: 0x005E90D6 File Offset: 0x005E72D6
	[NullableContext(2)]
	public bool HasScreenEffectFadeIn(TransitionWithSpineLoadingPb pb)
	{
		object obj;
		if (pb == null)
		{
			obj = null;
		}
		else
		{
			FadeBackgroundFadeInEffectPb fadeBackgroundFadeInEffectPb = pb.FadeBackgroundFadeInEffectPb;
			obj = ((fadeBackgroundFadeInEffectPb != null) ? fadeBackgroundFadeInEffectPb.FadeBackgroundFadeInEffectScreenPb : null);
		}
		return obj != null;
	}

	// Token: 0x06014484 RID: 83076 RVA: 0x005E90F4 File Offset: 0x005E72F4
	public UniTask OpenSpecialTransitionLoadingByTeleportPb(TransitionWithSpineLoadingPb spineLoadingPb, [Nullable(2)] Action finishCallback = null)
	{
		SpecialTransitionController.<OpenSpecialTransitionLoadingByTeleportPb>d__2 <OpenSpecialTransitionLoadingByTeleportPb>d__;
		<OpenSpecialTransitionLoadingByTeleportPb>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenSpecialTransitionLoadingByTeleportPb>d__.<>4__this = this;
		<OpenSpecialTransitionLoadingByTeleportPb>d__.spineLoadingPb = spineLoadingPb;
		<OpenSpecialTransitionLoadingByTeleportPb>d__.finishCallback = finishCallback;
		<OpenSpecialTransitionLoadingByTeleportPb>d__.<>1__state = -1;
		<OpenSpecialTransitionLoadingByTeleportPb>d__.<>t__builder.Start<SpecialTransitionController.<OpenSpecialTransitionLoadingByTeleportPb>d__2>(ref <OpenSpecialTransitionLoadingByTeleportPb>d__);
		return <OpenSpecialTransitionLoadingByTeleportPb>d__.<>t__builder.Task;
	}

	// Token: 0x06014485 RID: 83077 RVA: 0x005E9148 File Offset: 0x005E7348
	public UniTask OpenSpecialTransitionLoadingByConfig(ITeleportTransitionWithCustomScreen option, [Nullable(2)] Action finishCallback = null)
	{
		SpecialTransitionController.<OpenSpecialTransitionLoadingByConfig>d__3 <OpenSpecialTransitionLoadingByConfig>d__;
		<OpenSpecialTransitionLoadingByConfig>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenSpecialTransitionLoadingByConfig>d__.<>4__this = this;
		<OpenSpecialTransitionLoadingByConfig>d__.option = option;
		<OpenSpecialTransitionLoadingByConfig>d__.finishCallback = finishCallback;
		<OpenSpecialTransitionLoadingByConfig>d__.<>1__state = -1;
		<OpenSpecialTransitionLoadingByConfig>d__.<>t__builder.Start<SpecialTransitionController.<OpenSpecialTransitionLoadingByConfig>d__3>(ref <OpenSpecialTransitionLoadingByConfig>d__);
		return <OpenSpecialTransitionLoadingByConfig>d__.<>t__builder.Task;
	}

	// Token: 0x06014486 RID: 83078 RVA: 0x005E919C File Offset: 0x005E739C
	public UniTask OpenSpecialTransitionLoading(ISpecialTransitionParams @params, bool? closeBySelf = null)
	{
		SpecialTransitionController.<OpenSpecialTransitionLoading>d__4 <OpenSpecialTransitionLoading>d__;
		<OpenSpecialTransitionLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenSpecialTransitionLoading>d__.<>4__this = this;
		<OpenSpecialTransitionLoading>d__.@params = @params;
		<OpenSpecialTransitionLoading>d__.closeBySelf = closeBySelf;
		<OpenSpecialTransitionLoading>d__.<>1__state = -1;
		<OpenSpecialTransitionLoading>d__.<>t__builder.Start<SpecialTransitionController.<OpenSpecialTransitionLoading>d__4>(ref <OpenSpecialTransitionLoading>d__);
		return <OpenSpecialTransitionLoading>d__.<>t__builder.Task;
	}

	// Token: 0x06014487 RID: 83079 RVA: 0x005E91F0 File Offset: 0x005E73F0
	private UniTask OpenSpecialTransitionLoadingForLoadingMode(ISpecialTransitionParams @params, bool? closeBySelf)
	{
		SpecialTransitionController.<OpenSpecialTransitionLoadingForLoadingMode>d__5 <OpenSpecialTransitionLoadingForLoadingMode>d__;
		<OpenSpecialTransitionLoadingForLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OpenSpecialTransitionLoadingForLoadingMode>d__.<>4__this = this;
		<OpenSpecialTransitionLoadingForLoadingMode>d__.@params = @params;
		<OpenSpecialTransitionLoadingForLoadingMode>d__.closeBySelf = closeBySelf;
		<OpenSpecialTransitionLoadingForLoadingMode>d__.<>1__state = -1;
		<OpenSpecialTransitionLoadingForLoadingMode>d__.<>t__builder.Start<SpecialTransitionController.<OpenSpecialTransitionLoadingForLoadingMode>d__5>(ref <OpenSpecialTransitionLoadingForLoadingMode>d__);
		return <OpenSpecialTransitionLoadingForLoadingMode>d__.<>t__builder.Task;
	}

	// Token: 0x06014488 RID: 83080 RVA: 0x005E9244 File Offset: 0x005E7444
	[NullableContext(2)]
	private void PlayFadeInEffect(IFadeEffect fadeInEffect)
	{
		if (fadeInEffect == null)
		{
			return;
		}
		string screenEffect = fadeInEffect.ScreenEffect;
		if (!string.IsNullOrEmpty(screenEffect))
		{
			ScreenEffectModel.Instance.PlayScreenEffect(screenEffect, "Teleport", null);
			global::Log.Instance.Info(ELogModule.Loading, ELogAuthor.HYF, "SpecialTransition:进入效果：屏幕特效淡入(开始)", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		float? fadeInTime = fadeInEffect.FadeInTime;
		EFadeInScreenShowType? fadeColor = fadeInEffect.FadeColor;
		if (fadeInTime != null && fadeColor != null)
		{
			LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.Common, ELoadingPerform.CameraFade, "SpecialTransition", delegate
			{
				global::Log.Instance.Info(ELogModule.Loading, ELogAuthor.CB, "SpecialTransition:进入效果：黑幕淡入(完成)", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, new object[]
			{
				fadeInTime,
				fadeColor
			});
		}
	}

	// Token: 0x06014489 RID: 83081 RVA: 0x005E92FC File Offset: 0x005E74FC
	[NullableContext(2)]
	private void PlayFadeInOutPhase(IFadeEffect fadeInEffect, float? fadeOutTime)
	{
		if (fadeInEffect == null || !string.IsNullOrEmpty(fadeInEffect.ScreenEffect))
		{
			return;
		}
		if (fadeOutTime != null)
		{
			LevelLoadingController.Instance.CloseLoading(ELoadingReason.Common, "SpecialTransition", delegate
			{
				global::Log.Instance.Info(ELogModule.Loading, ELogAuthor.CB, "SpecialTransition:进入效果：黑幕淡出(完成)", default(ReadOnlySpan<ValueTuple<string, object>>));
			}, fadeOutTime);
		}
	}

	// Token: 0x0601448A RID: 83082 RVA: 0x005E9354 File Offset: 0x005E7554
	private void KeepSpecialTransitionLoading(ISpecialTransitionParams @params)
	{
		if (@params.FlowParams.KeepTime == null)
		{
			return;
		}
		LevelLoadingController.Instance.OpenLoading<ELoadingPerform>(ELoadingReason.SpecialTransitionKeep, ELoadingPerform.SpecialTransition, null, delegate
		{
			global::Log.Instance.Info(ELogModule.Loading, ELogAuthor.CB, "SpecialTransitionView 等待显示完成", default(ReadOnlySpan<ValueTuple<string, object>>));
		}, new object[]
		{
			@params
		});
		LevelLoadingController.Instance.CloseLoading(ELoadingReason.SpecialTransitionKeep, null, null, null);
	}

	// Token: 0x0601448B RID: 83083 RVA: 0x005E93C8 File Offset: 0x005E75C8
	public UniTask CloseSpecialTransitionLoading()
	{
		SpecialTransitionController.<CloseSpecialTransitionLoading>d__9 <CloseSpecialTransitionLoading>d__;
		<CloseSpecialTransitionLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseSpecialTransitionLoading>d__.<>4__this = this;
		<CloseSpecialTransitionLoading>d__.<>1__state = -1;
		<CloseSpecialTransitionLoading>d__.<>t__builder.Start<SpecialTransitionController.<CloseSpecialTransitionLoading>d__9>(ref <CloseSpecialTransitionLoading>d__);
		return <CloseSpecialTransitionLoading>d__.<>t__builder.Task;
	}

	// Token: 0x0601448C RID: 83084 RVA: 0x005E940C File Offset: 0x005E760C
	private UniTask CloseSpecialTransitionLoadingForLoadingMode(ISpecialTransitionParams @params)
	{
		SpecialTransitionController.<CloseSpecialTransitionLoadingForLoadingMode>d__10 <CloseSpecialTransitionLoadingForLoadingMode>d__;
		<CloseSpecialTransitionLoadingForLoadingMode>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseSpecialTransitionLoadingForLoadingMode>d__.<>4__this = this;
		<CloseSpecialTransitionLoadingForLoadingMode>d__.@params = @params;
		<CloseSpecialTransitionLoadingForLoadingMode>d__.<>1__state = -1;
		<CloseSpecialTransitionLoadingForLoadingMode>d__.<>t__builder.Start<SpecialTransitionController.<CloseSpecialTransitionLoadingForLoadingMode>d__10>(ref <CloseSpecialTransitionLoadingForLoadingMode>d__);
		return <CloseSpecialTransitionLoadingForLoadingMode>d__.<>t__builder.Task;
	}

	// Token: 0x0601448D RID: 83085 RVA: 0x005E9458 File Offset: 0x005E7658
	[NullableContext(2)]
	private UniTask PlayFadeOutEffectIn(IFadeEffect fadeOutEffect)
	{
		SpecialTransitionController.<PlayFadeOutEffectIn>d__11 <PlayFadeOutEffectIn>d__;
		<PlayFadeOutEffectIn>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFadeOutEffectIn>d__.fadeOutEffect = fadeOutEffect;
		<PlayFadeOutEffectIn>d__.<>1__state = -1;
		<PlayFadeOutEffectIn>d__.<>t__builder.Start<SpecialTransitionController.<PlayFadeOutEffectIn>d__11>(ref <PlayFadeOutEffectIn>d__);
		return <PlayFadeOutEffectIn>d__.<>t__builder.Task;
	}

	// Token: 0x0601448E RID: 83086 RVA: 0x005E949C File Offset: 0x005E769C
	[NullableContext(2)]
	private UniTask WaitFadeOutEffectEnd(IFadeEffect fadeOutEffect)
	{
		SpecialTransitionController.<WaitFadeOutEffectEnd>d__12 <WaitFadeOutEffectEnd>d__;
		<WaitFadeOutEffectEnd>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<WaitFadeOutEffectEnd>d__.fadeOutEffect = fadeOutEffect;
		<WaitFadeOutEffectEnd>d__.<>1__state = -1;
		<WaitFadeOutEffectEnd>d__.<>t__builder.Start<SpecialTransitionController.<WaitFadeOutEffectEnd>d__12>(ref <WaitFadeOutEffectEnd>d__);
		return <WaitFadeOutEffectEnd>d__.<>t__builder.Task;
	}

	// Token: 0x0601448F RID: 83087 RVA: 0x005E94E0 File Offset: 0x005E76E0
	public UniTask PlayFadeInEffectBeforeLeavingLevel(TransitionWithSpineLoadingPb spineLoadingPb)
	{
		SpecialTransitionController.<PlayFadeInEffectBeforeLeavingLevel>d__13 <PlayFadeInEffectBeforeLeavingLevel>d__;
		<PlayFadeInEffectBeforeLeavingLevel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayFadeInEffectBeforeLeavingLevel>d__.<>4__this = this;
		<PlayFadeInEffectBeforeLeavingLevel>d__.spineLoadingPb = spineLoadingPb;
		<PlayFadeInEffectBeforeLeavingLevel>d__.<>1__state = -1;
		<PlayFadeInEffectBeforeLeavingLevel>d__.<>t__builder.Start<SpecialTransitionController.<PlayFadeInEffectBeforeLeavingLevel>d__13>(ref <PlayFadeInEffectBeforeLeavingLevel>d__);
		return <PlayFadeInEffectBeforeLeavingLevel>d__.<>t__builder.Task;
	}

	// Token: 0x06014490 RID: 83088 RVA: 0x005E952C File Offset: 0x005E772C
	public void CloseFadeInEffectAfterOpeningLoading(TransitionWithSpineLoadingPb spineLoadingPb)
	{
		IFadeEffect fadeInEffect = this.ParsePbIntoSpecialTransitionParams(spineLoadingPb).FlowParams.FadeInEffect;
		if (fadeInEffect == null || string.IsNullOrEmpty(fadeInEffect.ScreenEffect))
		{
			return;
		}
		string screenEffect = fadeInEffect.ScreenEffect;
		ScreenEffectModel.Instance.EndScreenEffectByPath(screenEffect);
	}

	// Token: 0x06014491 RID: 83089 RVA: 0x005E9570 File Offset: 0x005E7770
	private ISpecialTransitionParams ParsePbIntoSpecialTransitionParams(TransitionWithSpineLoadingPb spineLoadingPb)
	{
		IFadeEffect fadeInEffect = null;
		FadeBackgroundFadeInEffectPb fadeBackgroundFadeInEffectPb = spineLoadingPb.FadeBackgroundFadeInEffectPb;
		FadeBackgroundFadeInEffectBlackPb fadeBackgroundFadeInEffectBlackPb = (fadeBackgroundFadeInEffectPb != null) ? fadeBackgroundFadeInEffectPb.FadeBackgroundFadeInEffectBlackPb : null;
		FadeBackgroundFadeInEffectPb fadeBackgroundFadeInEffectPb2 = spineLoadingPb.FadeBackgroundFadeInEffectPb;
		FadeBackgroundFadeInEffectScreenPb fadeBackgroundFadeInEffectScreenPb = (fadeBackgroundFadeInEffectPb2 != null) ? fadeBackgroundFadeInEffectPb2.FadeBackgroundFadeInEffectScreenPb : null;
		if (fadeBackgroundFadeInEffectBlackPb != null)
		{
			fadeInEffect = new FadeEffect
			{
				FadeColor = new EFadeInScreenShowType?((fadeBackgroundFadeInEffectBlackPb.FadeColor == 0) ? EFadeInScreenShowType.White : EFadeInScreenShowType.Black),
				FadeInTime = (fadeBackgroundFadeInEffectBlackPb.HasFadeInTime ? new float?(fadeBackgroundFadeInEffectBlackPb.FadeInTime) : null),
				FadeOutTime = (fadeBackgroundFadeInEffectBlackPb.HasFadeOutTime ? new float?(fadeBackgroundFadeInEffectBlackPb.FadeOutTime) : null)
			};
		}
		else if (fadeBackgroundFadeInEffectScreenPb != null)
		{
			fadeInEffect = new FadeEffect
			{
				ScreenEffect = fadeBackgroundFadeInEffectScreenPb.ScreenEffect
			};
		}
		IFadeEffect fadeOutEffect = null;
		FadeBackgroundFadeOutEffectPb fadeBackgroundFadeOutEffectPb = spineLoadingPb.FadeBackgroundFadeOutEffectPb;
		FadeBackgroundFadeOutEffectBlackPb fadeBackgroundFadeOutEffectBlackPb = (fadeBackgroundFadeOutEffectPb != null) ? fadeBackgroundFadeOutEffectPb.FadeBackgroundFadeOutEffectBlackPb : null;
		FadeBackgroundFadeOutEffectPb fadeBackgroundFadeOutEffectPb2 = spineLoadingPb.FadeBackgroundFadeOutEffectPb;
		FadeBackgroundFadeOutEffectSceenPb fadeBackgroundFadeOutEffectSceenPb = (fadeBackgroundFadeOutEffectPb2 != null) ? fadeBackgroundFadeOutEffectPb2.FadeBackgroundFadeOutEffectSceenPb : null;
		if (fadeBackgroundFadeOutEffectBlackPb != null)
		{
			fadeOutEffect = new FadeEffect
			{
				FadeColor = new EFadeInScreenShowType?((fadeBackgroundFadeOutEffectBlackPb.FadeColor == 0) ? EFadeInScreenShowType.White : EFadeInScreenShowType.Black),
				FadeInTime = (fadeBackgroundFadeOutEffectBlackPb.HasFadeInTime ? new float?(fadeBackgroundFadeOutEffectBlackPb.FadeInTime) : null),
				FadeOutTime = (fadeBackgroundFadeOutEffectBlackPb.HasFadeOutTime ? new float?(fadeBackgroundFadeOutEffectBlackPb.FadeOutTime) : null)
			};
		}
		else if (fadeBackgroundFadeOutEffectSceenPb != null)
		{
			fadeOutEffect = new FadeEffect
			{
				ScreenEffect = fadeBackgroundFadeOutEffectSceenPb.ScreenEffect
			};
		}
		ICustomShowUi customShowUi = null;
		ICustomShowUiPb icustomShowUiPb = spineLoadingPb.ICustomShowUiPb;
		if (icustomShowUiPb != null)
		{
			customShowUi = new ICustomShowUi();
			ICustomScreenTextSettingPb icustomScreenTextSettingPb = icustomShowUiPb.ICustomScreenTextSettingPb;
			if (icustomScreenTextSettingPb != null)
			{
				customShowUi.TextSetting = new ICustomScreenTextSetting
				{
					IsShowTextInfo = (icustomScreenTextSettingPb.HasIsShowTextInfo ? new bool?(icustomScreenTextSettingPb.IsShowTextInfo) : null),
					TidTextContent = (icustomScreenTextSettingPb.HasTidTextContent ? icustomScreenTextSettingPb.TidTextContent : null),
					EdTidTextContent = (icustomScreenTextSettingPb.HasEdTidTextContent ? icustomScreenTextSettingPb.EdTidTextContent : null)
				};
			}
			customShowUi.IsHideCircle = (icustomShowUiPb.HasIsHideCircle ? new bool?(icustomShowUiPb.IsHideCircle) : null);
		}
		ICustomScreenTypeBasePb icustomScreenTypeBasePb = spineLoadingPb.ICustomScreenTypeBasePb;
		ICustomScreenLoadingPb customScreenLoadingPb = (icustomScreenTypeBasePb != null) ? icustomScreenTypeBasePb.ICustomScreenLoadingPb : null;
		ECustomScreenLoading? loadingType = null;
		if (customScreenLoadingPb != null && customScreenLoadingPb.ICustomScreenLoadingCyberpunkPb != null)
		{
			loadingType = new ECustomScreenLoading?(ECustomScreenLoading.Cyberpunk);
		}
		SpecialTransitionParams specialTransitionParams = new SpecialTransitionParams();
		SpecialTransitionViewParams specialTransitionViewParams = new SpecialTransitionViewParams();
		ICustomScreenTypeBasePb icustomScreenTypeBasePb2 = spineLoadingPb.ICustomScreenTypeBasePb;
		int? spineId;
		if (icustomScreenTypeBasePb2 == null)
		{
			spineId = null;
		}
		else
		{
			ICustomScreenSpinePb icustomScreenSpinePb = icustomScreenTypeBasePb2.ICustomScreenSpinePb;
			spineId = ((icustomScreenSpinePb != null) ? new int?(icustomScreenSpinePb.SpineId) : null);
		}
		specialTransitionViewParams.SpineId = spineId;
		ICustomScreenTypeBasePb icustomScreenTypeBasePb3 = spineLoadingPb.ICustomScreenTypeBasePb;
		string bgPath;
		if (icustomScreenTypeBasePb3 == null)
		{
			bgPath = null;
		}
		else
		{
			ICustomScreenBackgroundImagePb icustomScreenBackgroundImagePb = icustomScreenTypeBasePb3.ICustomScreenBackgroundImagePb;
			bgPath = ((icustomScreenBackgroundImagePb != null) ? icustomScreenBackgroundImagePb.BackgroundImagePath : null);
		}
		specialTransitionViewParams.BgPath = bgPath;
		specialTransitionViewParams.CustomShowUi = customShowUi;
		specialTransitionViewParams.AkEvent = (spineLoadingPb.HasStartAkEvent ? spineLoadingPb.StartAkEvent : null);
		specialTransitionParams.ViewParams = specialTransitionViewParams;
		specialTransitionParams.FlowParams = new SpecialTransitionFlowParams
		{
			FadeInEffect = fadeInEffect,
			FadeOutEffect = fadeOutEffect,
			KeepTime = (spineLoadingPb.HasKeepTime ? new float?(spineLoadingPb.KeepTime) : null)
		};
		specialTransitionParams.LoadingType = loadingType;
		return specialTransitionParams;
	}

	// Token: 0x06014492 RID: 83090 RVA: 0x005E9894 File Offset: 0x005E7A94
	private ISpecialTransitionParams ParseConfigIntoSpecialTransitionParams(ITeleportTransitionWithCustomScreen option)
	{
		IFadeEffect fadeInEffect = null;
		IFadeBackgroundFadeInEffect fadeInEffect2 = option.FadeInEffect;
		IFadeBackgroundFadeInEffectTypeBase fadeBackgroundFadeInEffectTypeBase = (fadeInEffect2 != null) ? fadeInEffect2.FadeInEffect : null;
		if (fadeBackgroundFadeInEffectTypeBase != null)
		{
			if (fadeBackgroundFadeInEffectTypeBase.Type == EFadeBackgroundFadeInEffectType.Black)
			{
				IFadeBackgroundFadeInEffectBlack fadeBackgroundFadeInEffectBlack = (IFadeBackgroundFadeInEffectBlack)fadeBackgroundFadeInEffectTypeBase;
				fadeInEffect = new FadeEffect
				{
					FadeColor = new EFadeInScreenShowType?(fadeBackgroundFadeInEffectBlack.FadeColor),
					FadeInTime = fadeBackgroundFadeInEffectBlack.FadeInTime,
					FadeOutTime = fadeBackgroundFadeInEffectBlack.FadeOutTime
				};
			}
			else if (fadeBackgroundFadeInEffectTypeBase.Type == EFadeBackgroundFadeInEffectType.ScreenEffect)
			{
				IFadeBackgroundFadeInEffectScreenEffect fadeBackgroundFadeInEffectScreenEffect = (IFadeBackgroundFadeInEffectScreenEffect)fadeBackgroundFadeInEffectTypeBase;
				fadeInEffect = new FadeEffect
				{
					ScreenEffect = fadeBackgroundFadeInEffectScreenEffect.ScreenEffect
				};
			}
		}
		IFadeEffect fadeOutEffect = null;
		IFadeBackgroundFadeOutEffect fadeOutEffect2 = option.FadeOutEffect;
		IFadeBackgroundFadeOutEffectTypeBase fadeBackgroundFadeOutEffectTypeBase = (fadeOutEffect2 != null) ? fadeOutEffect2.FadeOutEffect : null;
		if (fadeBackgroundFadeOutEffectTypeBase != null)
		{
			if (fadeBackgroundFadeOutEffectTypeBase.Type == EFadeBackgroundFadeOutEffectType.Black)
			{
				IFadeBackgroundFadeOutEffectBlack fadeBackgroundFadeOutEffectBlack = (IFadeBackgroundFadeOutEffectBlack)fadeBackgroundFadeOutEffectTypeBase;
				fadeOutEffect = new FadeEffect
				{
					FadeColor = new EFadeInScreenShowType?(fadeBackgroundFadeOutEffectBlack.FadeColor),
					FadeInTime = fadeBackgroundFadeOutEffectBlack.FadeInTime,
					FadeOutTime = fadeBackgroundFadeOutEffectBlack.FadeOutTime
				};
			}
			else if (fadeBackgroundFadeOutEffectTypeBase.Type == EFadeBackgroundFadeOutEffectType.ScreenEffect)
			{
				IFadeBackgroundFadeOutEffectScreenEffect fadeBackgroundFadeOutEffectScreenEffect = (IFadeBackgroundFadeOutEffectScreenEffect)fadeBackgroundFadeOutEffectTypeBase;
				fadeOutEffect = new FadeEffect
				{
					ScreenEffect = fadeBackgroundFadeOutEffectScreenEffect.ScreenEffect
				};
			}
		}
		int? spineId = null;
		string bgPath = null;
		ECustomScreenLoading? loadingType = null;
		ICustomScreenTypeBase screenType = option.ScreenType;
		switch (screenType.Type)
		{
		case ECustomScreenType.Spine:
			spineId = new int?(((ICustomScreenSpine)screenType).SpineId);
			break;
		case ECustomScreenType.BackgroundImage:
			bgPath = ((ICustomScreenBackgroundImage)screenType).BackgroundImagePath;
			break;
		case ECustomScreenType.Loading:
			if (((ICustomScreenLoading)screenType).LoadingType != null)
			{
				loadingType = new ECustomScreenLoading?(((ICustomScreenLoading)screenType).LoadingType.Type);
			}
			break;
		}
		return new SpecialTransitionParams
		{
			ViewParams = new SpecialTransitionViewParams
			{
				SpineId = spineId,
				BgPath = bgPath,
				CustomShowUi = option.CustomShowUi,
				AkEvent = option.StartAkEvent
			},
			FlowParams = new SpecialTransitionFlowParams
			{
				FadeInEffect = fadeInEffect,
				FadeOutEffect = fadeOutEffect,
				KeepTime = option.KeepTime
			},
			LoadingType = loadingType
		};
	}

	// Token: 0x17001E6F RID: 7791
	// (get) Token: 0x06014493 RID: 83091 RVA: 0x005E9A8A File Offset: 0x005E7C8A
	public static SpecialTransitionController Instance
	{
		get
		{
			return SpecialTransitionController._Instance;
		}
	}

	// Token: 0x06014494 RID: 83092 RVA: 0x005E9A91 File Offset: 0x005E7C91
	public static SpecialTransitionController GetOrCreateInstance()
	{
		if (SpecialTransitionController._Instance == null)
		{
			SpecialTransitionController.CreateInstance();
		}
		return SpecialTransitionController._Instance;
	}

	// Token: 0x06014495 RID: 83093 RVA: 0x005E9AA5 File Offset: 0x005E7CA5
	public static bool CreateInstance()
	{
		if (SpecialTransitionController._Instance != null)
		{
			return true;
		}
		SpecialTransitionController._Instance = new SpecialTransitionController();
		return true;
	}

	// Token: 0x06014496 RID: 83094 RVA: 0x005E9ABB File Offset: 0x005E7CBB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06014497 RID: 83095 RVA: 0x005E9ABD File Offset: 0x005E7CBD
	public static void ResetStaticDefaultValue()
	{
		SpecialTransitionController._Instance = null;
	}

	// Token: 0x06014498 RID: 83096 RVA: 0x005E9AC5 File Offset: 0x005E7CC5
	static SpecialTransitionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialTransitionController.CreateStaticDefaultValue), new Action(SpecialTransitionController.ResetStaticDefaultValue));
	}

	// Token: 0x0400AC1F RID: 44063
	[Nullable(2)]
	private static SpecialTransitionController _Instance;
}
