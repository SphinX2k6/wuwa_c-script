using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02001A9C RID: 6812
[NullableContext(2)]
[Nullable(0)]
public class FightPhotoSaveView : UiViewBase
{
	// Token: 0x06010DD6 RID: 69078 RVA: 0x004F232E File Offset: 0x004F052E
	[NullableContext(1)]
	public FightPhotoSaveView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06010DD7 RID: 69079 RVA: 0x004F2344 File Offset: 0x004F0544
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIText)),
			new ValueTuple<int, Type>(9, typeof(UUITexture)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnCloseBtnClick)),
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickedConfirmButton)),
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickPersonalInfoShow))
		};
	}

	// Token: 0x06010DD8 RID: 69080 RVA: 0x004F24BC File Offset: 0x004F06BC
	protected override UniTask OnBeforeStartAsync()
	{
		FightPhotoSaveView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FightPhotoSaveView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010DD9 RID: 69081 RVA: 0x004F2500 File Offset: 0x004F0700
	private void RefreshSaveButton()
	{
		bool flag = Info.Instance.IsXSXPlatform();
		UUIButtonComponent button = base.GetButton(2);
		if (button == null)
		{
			return;
		}
		button.RootUIComp.Get().SetUIActive(!flag);
	}

	// Token: 0x06010DDA RID: 69082 RVA: 0x004F253C File Offset: 0x004F073C
	private UniTask CaptureForPreviewAndMissionAsync()
	{
		FightPhotoSaveView.<CaptureForPreviewAndMissionAsync>d__11 <CaptureForPreviewAndMissionAsync>d__;
		<CaptureForPreviewAndMissionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CaptureForPreviewAndMissionAsync>d__.<>4__this = this;
		<CaptureForPreviewAndMissionAsync>d__.<>1__state = -1;
		<CaptureForPreviewAndMissionAsync>d__.<>t__builder.Start<FightPhotoSaveView.<CaptureForPreviewAndMissionAsync>d__11>(ref <CaptureForPreviewAndMissionAsync>d__);
		return <CaptureForPreviewAndMissionAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010DDB RID: 69083 RVA: 0x004F257F File Offset: 0x004F077F
	protected override void OnBeforeHide()
	{
		base.OnBeforeHide();
		PhotographController.OnFightPhotoSaveViewClose();
	}

	// Token: 0x06010DDC RID: 69084 RVA: 0x004F258C File Offset: 0x004F078C
	private void RefreshPhotoPanel()
	{
		UUIItem item = base.GetItem(3);
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		float viewportScale = UWidgetLayoutLibrary.GetViewportScale(GlobalData.World);
		item.SetWidth(viewportSize.X / (viewportScale * 1.5f));
		item.SetHeight(viewportSize.Y / (viewportScale * 1.5f));
	}

	// Token: 0x06010DDD RID: 69085 RVA: 0x004F25E0 File Offset: 0x004F07E0
	protected override void OnAfterShow()
	{
		PhotoSaveMarkItem markItem = this.MarkItem;
		if (markItem != null)
		{
			markItem.SetUiActive(this.IsShowPlayerName);
		}
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.PlaySequence("ScreenShot", true, null);
	}

	// Token: 0x06010DDE RID: 69086 RVA: 0x004F2624 File Offset: 0x004F0824
	private void OnClickedConfirmButton()
	{
		Log.Instance.Info(ELogModule.FightPhotograph, ELogAuthor.CXJ, "点击保存截图按钮", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (KuroSdkController.Instance.CheckPhotoPermission())
		{
			this.TakeScreenshot(false, new Action<int, int, TArray<FColor>>(this.OnTakePhoto), new Action<bool>(this.OnIOSPhotoLibraryAuthorizationCompleted), new Action<TArray<byte>>(this.OnPhotoCompressed));
			return;
		}
		ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.PhotoPermissionRequest);
		Action value = delegate()
		{
			if (PhotographController.Instance.CouldRequestPhotoPermission())
			{
				ELocalStorageGlobalKey key = ELocalStorageGlobalKey.RequestPhotoPermissionMinTime;
				double serverTime = TimeUtil.Instance.GetServerTime();
				int? intConfig = ConfigCommonParamById.GetIntConfig("PermissionRequestsTimeId");
				LocalStorage.SetGlobal<double?>(key, serverTime + ((intConfig != null) ? new double?((double)intConfig.GetValueOrDefault()) : null));
				KuroSdkController.Instance.RequestPhotoPermission(new Action<bool>(this.OnRequestPermissionCallback));
				return;
			}
			this.OnPhotoPermissionDenied();
		};
		confirmBoxDataNew.FunctionMap.Add(1, new Action(this.OnPhotoPermissionDenied));
		confirmBoxDataNew.FunctionMap.Add(2, value);
		ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
	}

	// Token: 0x06010DDF RID: 69087 RVA: 0x004F26D4 File Offset: 0x004F08D4
	private unsafe void TakeScreenshot(bool isSaveFile, [Nullable(new byte[]
	{
		1,
		2
	})] Action<int, int, TArray<FColor>> onTakeScreenShotCallback, Action<bool> onIOSPhotoLibraryAuthorizationCompleted = null, Action<TArray<byte>> onPhotoCompressed = null)
	{
		string photoName = this.GetPhotoName();
		this.RelativeShotPath = this.GetRelativeShotPath(photoName);
		string storagePath = UBlueprintPathsLibrary.ProjectUserDir() + this.RelativeShotPath;
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		bool isPs5 = Info.Instance.IsPs5Platform();
		int multiplier = isPs5 ? 1 : this.GetFightSafeMultiplierScale(viewportSize);
		PhotographController.PrepareFightPhotoCapture();
		this.EnterCaptureMode(this.IsShowPlayerName);
		FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate <>9__1;
		FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate <>9__2;
		TimerSystem.GameplayTimeInstance.Next(delegate(float _)
		{
			UGameScreenshotTask ugameScreenshotTask = ScreenShotManager.PrepareTakeScreenshot(storagePath, 0f, 0f, viewportSize.X, viewportSize.Y, isSaveFile, viewportSize.X, viewportSize.Y, multiplier);
			if (ugameScreenshotTask == null)
			{
				Log.Instance.Error(ELogModule.FightPhotograph, ELogAuthor.CXJ, "战斗拍照保存：PrepareTakeScreenshot 返回 undefined", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.ExitCaptureMode();
				PhotographController.OnFightPhotoCaptured();
				return;
			}
			FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate fonTakeScreenshotCaptured_ScriptDelegate;
			if ((fonTakeScreenshotCaptured_ScriptDelegate = <>9__1) == null)
			{
				fonTakeScreenshotCaptured_ScriptDelegate = (<>9__1 = delegate(int width, int height, in TArray<FColor> colors)
				{
					this.ExitCaptureMode();
					PhotographController.OnFightPhotoCaptured();
					onTakeScreenShotCallback(width, height, colors);
				});
			}
			FOnTakeScreenshotCaptured.FOnTakeScreenshotCaptured_ScriptDelegate callback = fonTakeScreenshotCaptured_ScriptDelegate;
			ugameScreenshotTask.OnTakeScreenshotCapturedDelegate.Add(callback);
			if (onIOSPhotoLibraryAuthorizationCompleted != null)
			{
				ugameScreenshotTask.OnIOSPhotoLibraryAuthorizationCompletedDelegate.Add(onIOSPhotoLibraryAuthorizationCompleted);
			}
			if (onPhotoCompressed != null)
			{
				FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate fonTakeScreenshotCompressed_ScriptDelegate;
				if ((fonTakeScreenshotCompressed_ScriptDelegate = <>9__2) == null)
				{
					fonTakeScreenshotCompressed_ScriptDelegate = (<>9__2 = delegate(in TArray<byte> compressedBitmap)
					{
						onPhotoCompressed(compressedBitmap);
					});
				}
				FOnTakeScreenshotCompressed.FOnTakeScreenshotCompressed_ScriptDelegate callback2 = fonTakeScreenshotCompressed_ScriptDelegate;
				ugameScreenshotTask.OnTakeScreenshotCompressedDelegate.Add(callback2);
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.FightPhotograph;
			ELogAuthor author = ELogAuthor.CXJ;
			string message = "开始战斗拍照保存截图";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isSaveFile", isSaveFile);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("multiplier", multiplier);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			if (isPs5)
			{
				ugameScreenshotTask.TakeScreenshot();
				return;
			}
			ugameScreenshotTask.TakeScreenshotHighRes(multiplier);
		}, null, null);
	}

	// Token: 0x06010DE0 RID: 69088 RVA: 0x004F279C File Offset: 0x004F099C
	private unsafe void OnTakePhoto(int width, int height, TArray<FColor> colors)
	{
		this.CurrentTakeWidth = width;
		this.CurrentTakeHeight = height;
		this.CurrentTakeColors = colors;
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FightPhotograph;
		ELogAuthor author = ELogAuthor.CXJ;
		string message = "截图完成，截图结果进行保存";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("width", width);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("height", height);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ColorSize", (colors != null) ? new int?(colors.Num()) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		ESourcePlatformType platformType = Info.Instance.PlatformType;
		if (platformType <= ESourcePlatformType.Android)
		{
			if (platformType != ESourcePlatformType.IOS)
			{
				if (platformType == ESourcePlatformType.Android)
				{
					TArray<byte> tarray = new TArray<byte>();
					UKuroGameScreenshotBPLibrary.ConvertColorsToBitmap(width, height, colors, ref tarray);
					TArray<byte> tarray2 = tarray;
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.FightPhotograph;
					ELogAuthor author2 = ELogAuthor.CXJ;
					string message2 = "截图保存至Android相册";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("bitmapSize", (tarray2 != null) ? new int?(tarray2.Num()) : null);
					instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					UKuroGameScreenshotBPLibrary.SaveColorArrayToAndroidAlbum(width, height, tarray2);
					GenericPromptController.Instance.ShowPromptByCode("SaveGalleryPathTips", Array.Empty<object>());
					goto IL_31E;
				}
			}
			else
			{
				if (!UKuroGameScreenshotBPLibrary.IsPhotoLibraryAuthorized())
				{
					Log.Instance.Info(ELogModule.FightPhotograph, ELogAuthor.CXJ, "没有获得IOS相册权限，请求权限，请求完成后再次尝试截图", default(ReadOnlySpan<ValueTuple<string, object>>));
					ScreenShotManager.RequestIOSPhotoLibraryAuthorization();
					return;
				}
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.FightPhotograph;
				ELogAuthor author3 = ELogAuthor.CXJ;
				string message3 = "截图保存IOS相册";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("colors", (colors != null) ? new int?(colors.Num()) : null);
				instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				UKuroGameScreenshotBPLibrary.SaveColorArrayToIosAlbum(width, height, colors);
				GenericPromptController.Instance.ShowPromptByCode("SaveGalleryPathTips", Array.Empty<object>());
				goto IL_31E;
			}
		}
		else
		{
			if (platformType == ESourcePlatformType.PS5)
			{
				goto IL_31E;
			}
			if (platformType == ESourcePlatformType.OpenHarmony)
			{
				TArray<byte> tarray3 = new TArray<byte>();
				UKuroGameScreenshotBPLibrary.CompressConvertColorsToBitmap(this.CurrentTakeWidth, this.CurrentTakeHeight, this.CurrentTakeColors, ref tarray3);
				TArray<byte> tarray4 = tarray3;
				Log instance4 = Log.Instance;
				ELogModule module4 = ELogModule.Photo;
				ELogAuthor author4 = ELogAuthor.CXJ;
				string message4 = "截图保存至鸿蒙相册";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("bitmapSize", (tarray4 != null) ? new int?(tarray4.Num()) : null);
				instance4.Info(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				UKuroGameScreenshotBPLibrary.SaveColorArrayToOpenHarmonyAlbum(this.CurrentTakeWidth, this.CurrentTakeHeight, tarray4);
				GenericPromptController.Instance.ShowPromptByCode("SaveGalleryPathTips", Array.Empty<object>());
				goto IL_31E;
			}
		}
		string photoName = this.GetPhotoName();
		this.RelativeShotPath = this.GetRelativeShotPath(photoName);
		UKuroGameScreenshotBPLibrary.SaveScreenshot(UBlueprintPathsLibrary.ProjectUserDir() + this.RelativeShotPath, width, height, colors);
		Log instance5 = Log.Instance;
		ELogModule module5 = ELogModule.FightPhotograph;
		ELogAuthor author5 = ELogAuthor.CXJ;
		string message5 = "截图保存至游戏安装文件夹";
		ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("path", this.RelativeShotPath);
		instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
		if (!Platform.Instance.IsCloudGame())
		{
			GenericPromptController.Instance.ShowPromptByCode("SavePathTips", new object[]
			{
				this.RelativeShotPath
			});
		}
		IL_31E:
		this.ClosePhotoSaveView();
	}

	// Token: 0x06010DE1 RID: 69089 RVA: 0x004F2AD0 File Offset: 0x004F0CD0
	private unsafe void OnIOSPhotoLibraryAuthorizationCompleted(bool isGranted)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.FightPhotograph;
		ELogAuthor author = ELogAuthor.CXJ;
		string message = "允许权限后重新截图";
		<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("isGranted", isGranted);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("width", this.CurrentTakeWidth);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("height", this.CurrentTakeHeight);
		ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
		string item = "colorsSize";
		TArray<FColor> currentTakeColors = this.CurrentTakeColors;
		ptr = new ValueTuple<string, object>(item, (currentTakeColors != null) ? new int?(currentTakeColors.Num()) : null);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		if (!isGranted)
		{
			this.ClosePhotoSaveView();
			return;
		}
		if (this.CurrentTakeWidth <= 0 || this.CurrentTakeHeight <= 0 || this.CurrentTakeColors == null)
		{
			this.ClosePhotoSaveView();
			return;
		}
		UKuroGameScreenshotBPLibrary.SaveColorArrayToIosAlbum(this.CurrentTakeWidth, this.CurrentTakeHeight, this.CurrentTakeColors);
		GenericPromptController.Instance.ShowPromptByCode("SaveGalleryPathTips", Array.Empty<object>());
		this.ClosePhotoSaveView();
	}

	// Token: 0x06010DE2 RID: 69090 RVA: 0x004F2BFC File Offset: 0x004F0DFC
	private void OnPhotoPermissionDenied()
	{
		ESourcePlatformType platformType = Info.Instance.PlatformType;
		if (platformType != ESourcePlatformType.IOS)
		{
			if (platformType == ESourcePlatformType.Android)
			{
				GenericPromptController.Instance.ShowPromptByCode("Privilege_album_Android", Array.Empty<object>());
				return;
			}
		}
		else
		{
			GenericPromptController.Instance.ShowPromptByCode("Privilege_album_IOS", Array.Empty<object>());
		}
	}

	// Token: 0x06010DE3 RID: 69091 RVA: 0x004F2C48 File Offset: 0x004F0E48
	private void OnPhotoCompressed(TArray<byte> compressedBitmap)
	{
		Log.Instance.Info(ELogModule.FightPhotograph, ELogAuthor.CXJ, "PS Test OnPhotoCompressed", default(ReadOnlySpan<ValueTuple<string, object>>));
		if (Info.Instance.PlatformType == ESourcePlatformType.PS5)
		{
			string photoName = this.GetPhotoName();
			UGameplayStatics.ExportPngPhotoFromData(compressedBitmap, photoName);
		}
	}

	// Token: 0x06010DE4 RID: 69092 RVA: 0x004F2C91 File Offset: 0x004F0E91
	private void OnRequestPermissionCallback(bool isAllowed)
	{
		if (isAllowed)
		{
			this.TakeScreenshot(false, new Action<int, int, TArray<FColor>>(this.OnTakePhoto), new Action<bool>(this.OnIOSPhotoLibraryAuthorizationCompleted), null);
			return;
		}
		this.OnPhotoPermissionDenied();
	}

	// Token: 0x06010DE5 RID: 69093 RVA: 0x004F2CC0 File Offset: 0x004F0EC0
	private int GetFightSafeMultiplierScale(FVector2D viewportSize)
	{
		int num = 1;
		FightPhotoSetup? fightPhotoSetupConfigById = PhotographConfig.Instance.GetFightPhotoSetupConfigById(1);
		if (fightPhotoSetupConfigById != null)
		{
			PhotoDropDown? config = ConfigPhotoDropDownById.GetConfig(FightPhotoModel.Instance.GetFightPhotoSetupOption(EFightPhotoSetupOptionType.ImageQuality) ?? fightPhotoSetupConfigById.Value.DefaultDropDownIndex, true);
			if (config != null)
			{
				num = int.Parse(config.Value.Param()[0]);
			}
		}
		int? intConfig = ConfigCommonParamById.GetIntConfig("PhotoMaxAllowedResolution");
		if (intConfig != null)
		{
			int? num2 = intConfig;
			int num3 = 0;
			if (num2.GetValueOrDefault() > num3 & num2 != null)
			{
				float num4 = Math.Max(viewportSize.X, viewportSize.Y) * (float)num;
				num2 = intConfig;
				float? num5 = (num2 != null) ? new float?((float)num2.GetValueOrDefault()) : null;
				if (num4 > num5.GetValueOrDefault() & num5 != null)
				{
					num = 1;
				}
			}
		}
		return Math.Max(1, Math.Min(4, num));
	}

	// Token: 0x06010DE6 RID: 69094 RVA: 0x004F2DC8 File Offset: 0x004F0FC8
	[NullableContext(1)]
	private string GetPhotoName()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return TimeUtil.Instance.DateFormatString2(serverTime) + ".png";
	}

	// Token: 0x06010DE7 RID: 69095 RVA: 0x004F2DF5 File Offset: 0x004F0FF5
	[NullableContext(1)]
	private string GetRelativeShotPath(string photoName)
	{
		return PhotographModel.Instance.SavePath + photoName;
	}

	// Token: 0x06010DE8 RID: 69096 RVA: 0x004F2E07 File Offset: 0x004F1007
	private void ClosePhotoSaveView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010DE9 RID: 69097 RVA: 0x004F2E10 File Offset: 0x004F1010
	private void OnClickPersonalInfoShow(EToggleState toggleState)
	{
		LocalStorage.SetGlobal<bool>(ELocalStorageGlobalKey.PhotoAndShareShowPlayerName, toggleState == EToggleState.ETT_Checked);
		this.IsShowPlayerName = (toggleState == EToggleState.ETT_Checked);
		PhotoSaveMarkItem markItem = this.MarkItem;
		if (markItem == null)
		{
			return;
		}
		markItem.SetUiActive(toggleState == EToggleState.ETT_Checked);
	}

	// Token: 0x06010DEA RID: 69098 RVA: 0x004F2E3C File Offset: 0x004F103C
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010DEB RID: 69099 RVA: 0x004F2E48 File Offset: 0x004F1048
	private void EnterCaptureMode(bool showMark)
	{
		UUIItem rootItem = base.GetRootItem();
		if (rootItem != null)
		{
			rootItem.SetUIActive(false);
		}
		ULGUIBPLibrary.ResetGlobalBlurUIItem(GlobalData.GameInstance.GetWorld());
		EventSystem.Instance.Emit<bool, bool>(EEventName.OnPhotographViewCaptureMode, true, showMark);
		EventSystem.Instance.Emit<bool>(EEventName.OnPreparePhotoScreenShot, false);
	}

	// Token: 0x06010DEC RID: 69100 RVA: 0x004F2E99 File Offset: 0x004F1099
	private void ExitCaptureMode()
	{
		EventSystem.Instance.Emit<bool, bool>(EEventName.OnPhotographViewCaptureMode, false, false);
		EventSystem.Instance.Emit<bool>(EEventName.OnPreparePhotoScreenShot, true);
		UUIItem rootItem = base.GetRootItem();
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetUIActive(true);
	}

	// Token: 0x06010DED RID: 69101 RVA: 0x004F2ED0 File Offset: 0x004F10D0
	private UniTask waitForNextTick()
	{
		FightPhotoSaveView.<waitForNextTick>d__30 <waitForNextTick>d__;
		<waitForNextTick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<waitForNextTick>d__.<>1__state = -1;
		<waitForNextTick>d__.<>t__builder.Start<FightPhotoSaveView.<waitForNextTick>d__30>(ref <waitForNextTick>d__);
		return <waitForNextTick>d__.<>t__builder.Task;
	}

	// Token: 0x0400950C RID: 38156
	[Nullable(1)]
	private string RelativeShotPath = "";

	// Token: 0x0400950D RID: 38157
	private bool IsShowPlayerName;

	// Token: 0x0400950E RID: 38158
	private int CurrentTakeWidth;

	// Token: 0x0400950F RID: 38159
	private int CurrentTakeHeight;

	// Token: 0x04009510 RID: 38160
	private TArray<FColor> CurrentTakeColors;

	// Token: 0x04009511 RID: 38161
	private PhotoSaveMarkItem MarkItem;

	// Token: 0x02007D39 RID: 32057
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402888B RID: 166027
		BtnClose,
		// Token: 0x0402888C RID: 166028
		ToggleShowPersonalInfo,
		// Token: 0x0402888D RID: 166029
		BtnSave,
		// Token: 0x0402888E RID: 166030
		ItemPhoto,
		// Token: 0x0402888F RID: 166031
		TexturePhoto,
		// Token: 0x04028890 RID: 166032
		ItemPersonalInfo,
		// Token: 0x04028891 RID: 166033
		ItemLeftTop,
		// Token: 0x04028892 RID: 166034
		ItemRightBottom,
		// Token: 0x04028893 RID: 166035
		TextFinished,
		// Token: 0x04028894 RID: 166036
		TextureHideUi,
		// Token: 0x04028895 RID: 166037
		ItemHideUi,
		// Token: 0x04028896 RID: 166038
		ItemHideBtn
	}
}
