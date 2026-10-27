using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02002A7D RID: 10877
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class SpecialTransitionController : ControllerBase
{
	// Token: 0x06016A5D RID: 92765 RVA: 0x005BCE89 File Offset: 0x005BB089
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

	// Token: 0x06016A5E RID: 92766 RVA: 0x005BCEA6 File Offset: 0x005BB0A6
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

	// Token: 0x06016A5F RID: 92767 RVA: 0x005BCEC4 File Offset: 0x005BB0C4
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

	// Token: 0x06016A60 RID: 92768 RVA: 0x005BCF18 File Offset: 0x005BB118
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

	// Token: 0x06016A61 RID: 92769 RVA: 0x005BCF6C File Offset: 0x005BB16C
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

	// Token: 0x06016A62 RID: 92770 RVA: 0x005BCFC0 File Offset: 0x005BB1C0
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

	// Token: 0x06016A63 RID: 92771 RVA: 0x005BD014 File Offset: 0x005BB214
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

	// Token: 0x06016A64 RID: 92772 RVA: 0x005BD0CC File Offset: 0x005BB2CC
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

	// Token: 0x06016A65 RID: 92773 RVA: 0x005BD124 File Offset: 0x005BB324
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

	// Token: 0x06016A66 RID: 92774 RVA: 0x005BD198 File Offset: 0x005BB398
	public UniTask CloseSpecialTransitionLoading()
	{
		SpecialTransitionController.<CloseSpecialTransitionLoading>d__9 <CloseSpecialTransitionLoading>d__;
		<CloseSpecialTransitionLoading>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseSpecialTransitionLoading>d__.<>4__this = this;
		<CloseSpecialTransitionLoading>d__.<>1__state = -1;
		<CloseSpecialTransitionLoading>d__.<>t__builder.Start<SpecialTransitionController.<CloseSpecialTransitionLoading>d__9>(ref <CloseSpecialTransitionLoading>d__);
		return <CloseSpecialTransitionLoading>d__.<>t__builder.Task;
	}

	// Token: 0x06016A67 RID: 92775 RVA: 0x005BD1DC File Offset: 0x005BB3DC
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

	// Token: 0x06016A68 RID: 92776 RVA: 0x005BD228 File Offset: 0x005BB428
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

	// Token: 0x06016A69 RID: 92777 RVA: 0x005BD26C File Offset: 0x005BB46C
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

	// Token: 0x06016A6A RID: 92778 RVA: 0x005BD2B0 File Offset: 0x005BB4B0
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

	// Token: 0x06016A6B RID: 92779 RVA: 0x005BD2FC File Offset: 0x005BB4FC
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

	// Token: 0x06016A6C RID: 92780 RVA: 0x005BD340 File Offset: 0x005BB540
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

	// Token: 0x06016A6D RID: 92781 RVA: 0x005BD664 File Offset: 0x005BB864
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

	// Token: 0x17001E17 RID: 7703
	// (get) Token: 0x06016A6E RID: 92782 RVA: 0x005BD85A File Offset: 0x005BBA5A
	public static SpecialTransitionController Instance
	{
		get
		{
			return SpecialTransitionController._Instance;
		}
	}

	// Token: 0x06016A6F RID: 92783 RVA: 0x005BD861 File Offset: 0x005BBA61
	public static SpecialTransitionController GetOrCreateInstance()
	{
		if (SpecialTransitionController._Instance == null)
		{
			SpecialTransitionController.CreateInstance();
		}
		return SpecialTransitionController._Instance;
	}

	// Token: 0x06016A70 RID: 92784 RVA: 0x005BD875 File Offset: 0x005BBA75
	public static bool CreateInstance()
	{
		if (SpecialTransitionController._Instance != null)
		{
			return true;
		}
		SpecialTransitionController._Instance = new SpecialTransitionController();
		return true;
	}

	// Token: 0x06016A71 RID: 92785 RVA: 0x005BD88B File Offset: 0x005BBA8B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06016A72 RID: 92786 RVA: 0x005BD88D File Offset: 0x005BBA8D
	public static void ResetStaticDefaultValue()
	{
		SpecialTransitionController._Instance = null;
	}

	// Token: 0x06016A73 RID: 92787 RVA: 0x005BD895 File Offset: 0x005BBA95
	static SpecialTransitionController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialTransitionController.CreateStaticDefaultValue), new Action(SpecialTransitionController.ResetStaticDefaultValue));
	}

	// Token: 0x0400A81A RID: 43034
	[Nullable(2)]
	private static SpecialTransitionController _Instance;
}
