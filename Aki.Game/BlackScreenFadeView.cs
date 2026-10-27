using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.LevelLoading;
using CSharpScript.Game.Module.MovieMode;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x0200170E RID: 5902
public class BlackScreenFadeView : UiPanelBase
{
	// Token: 0x0600A944 RID: 43332 RVA: 0x00261500 File Offset: 0x0025F700
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600A945 RID: 43333 RVA: 0x0026156C File Offset: 0x0025F76C
	protected override void OnStart()
	{
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.Show, new Action(this.ShowDelegate));
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.Hide, new Action(this.HideDelegate));
		this.TextureWidget = base.GetTexture(1);
		this.TextureWidget2 = base.GetTexture(0);
		LguiUtil.Instance.SetActorIsPermanent(this.RootActor, true, true);
		this.ViewData.TriggerCurrentStateDelegate();
		EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnUiViewPortSizeChanged));
		EventSystem.Instance.Add<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, new Action<IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetUpdate));
	}

	// Token: 0x0600A946 RID: 43334 RVA: 0x00261618 File Offset: 0x0025F818
	protected override void OnBeforeDestroy()
	{
		LevelLoadingModel.Instance.CameraFadeShowPromise = null;
		LevelLoadingModel.Instance.CameraFadeHidePromise = null;
		this.IsFadeIn = true;
		this.FadeInAlphaFloor = 0f;
		this.FullFadeTime = 0f;
		this.FadeTime = 0f;
		this.TextureWidget = null;
		this.TextureWidget2 = null;
		this.RemoveTick(this.TickIdFade);
		this.RemoveTick(this.TickIdSave);
		EventSystem.Instance.Remove(EEventName.UIViewPortSizeChanged, new Action(this.OnUiViewPortSizeChanged));
		EventSystem.Instance.Remove<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, new Action<IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetUpdate));
	}

	// Token: 0x0600A947 RID: 43335 RVA: 0x002616C0 File Offset: 0x0025F8C0
	private void OnCloseEvent()
	{
		if (this.IsFadeIn)
		{
			global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "黑幕FadeIn结束", default(ReadOnlySpan<ValueTuple<string, object>>));
			LevelLoadingModel.Instance.FinishCameraShowPromise();
			return;
		}
		global::Log.Instance.Info(ELogModule.BlackScreen, ELogAuthor.JYS, "黑幕FadeOut结束", default(ReadOnlySpan<ValueTuple<string, object>>));
		LevelLoadingModel.Instance.FinishCameraHidePromise();
		this.SetActive(false);
		BlackScreenFadeController.Instance.NeedInputDis = false;
		InputDistributeModel.Instance.RefreshInputDistributeTag();
		global::Log instance = global::Log.Instance;
		ELogModule module = ELogModule.BlackScreen;
		ELogAuthor author = ELogAuthor.JYS;
		string message = "黑幕输入恢复";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("BlackScreenFadeController.NeedInputDis", BlackScreenFadeController.Instance.NeedInputDis);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		UiManager.Instance.RemoveOpenViewCheckFunction(EUiViewName.All, new Func<EUiViewName, object, bool>(BlackScreenFadeController.Instance.CheckCanOpen));
		EventSystem.Instance.Emit(EEventName.OnBlackFadeScreenFinish);
		GameSettingsDeviceRender.Instance.CancelTemporaryDisableFrameGeneration("BlackScreen");
	}

	// Token: 0x0600A948 RID: 43336 RVA: 0x002617BA File Offset: 0x0025F9BA
	private void ShowDelegate()
	{
		EventSystem.Instance.Emit(EEventName.OnBlackFadeScreenStart);
		this.FadeInAlphaFloor = 0f;
		this.AddTick(this.TickIdFade);
		this.SetActive(true);
		this.UpdateTextureWidgetVisibility();
		this.UpdateBlackScreen();
	}

	// Token: 0x0600A949 RID: 43337 RVA: 0x002617F6 File Offset: 0x0025F9F6
	private void HideDelegate()
	{
		this.SetActive(true);
		this.AddTick(this.TickIdFade);
		this.UpdateTextureWidgetVisibility();
		PlotModel.Instance.LastPlotColor = -1;
	}

	// Token: 0x0600A94A RID: 43338 RVA: 0x0026181C File Offset: 0x0025FA1C
	private void UpdateTextureWidgetVisibility()
	{
		if (PlotModel.Instance.LastPlotColor == 1)
		{
			UUITexture textureWidget = this.TextureWidget;
			if (textureWidget == null)
			{
				return;
			}
			textureWidget.SetUIActive(false);
			return;
		}
		else
		{
			UUITexture textureWidget2 = this.TextureWidget;
			if (textureWidget2 == null)
			{
				return;
			}
			textureWidget2.SetUIActive(true);
			return;
		}
	}

	// Token: 0x0600A94B RID: 43339 RVA: 0x00261850 File Offset: 0x0025FA50
	private void AddTick(int tickId)
	{
		if (tickId != -1)
		{
			return;
		}
		if (tickId == this.TickIdFade)
		{
			InputDistributeController.Instance.RefreshInputTag();
			this.TickIdFade = TickSystem.Instance.Add(new Action<float>(this.OnFadeTick), "BlackScreenTransitionView", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
			return;
		}
		if (tickId == this.TickIdSave)
		{
			this.TickIdSave = TickSystem.Instance.Add(new Action<float>(this.OnSaveTick), "BlackScreenTransitionView", ETickingGroup.TG_PrePhysics, true, 0, true).Id;
		}
	}

	// Token: 0x0600A94C RID: 43340 RVA: 0x002618D4 File Offset: 0x0025FAD4
	private void RemoveTick(int tickId)
	{
		if (tickId != -1)
		{
			if (tickId == this.TickIdFade)
			{
				TickSystem.Instance.Remove(this.TickIdFade);
				this.TickIdFade = -1;
				if (!this.IsFadeIn)
				{
					InputDistributeController.Instance.RefreshInputTag();
					return;
				}
			}
			else if (tickId == this.TickIdSave)
			{
				TickSystem.Instance.Remove(this.TickIdSave);
				this.TickIdSave = -1;
			}
		}
	}

	// Token: 0x0600A94D RID: 43341 RVA: 0x0026193C File Offset: 0x0025FB3C
	private void OnFadeTick(float deltaTime)
	{
		if (this.LerpTime > 0f)
		{
			float rangePct = MathUtils.Instance.GetRangePct(0f, this.FullLerpTime, this.FullLerpTime - this.LerpTime);
			float blackScreenLastAspect = PlotModel.Instance.BlackScreenLastAspect;
			float blackScreenNowAspect = PlotModel.Instance.BlackScreenNowAspect;
			float aspect = blackScreenLastAspect + (blackScreenNowAspect - blackScreenLastAspect) * rangePct;
			this.SetAspect(aspect);
			this.SetFadeTime(0f);
			this.LerpTime -= deltaTime;
		}
		if (this.FadeTime > 0f)
		{
			this.FadeTime -= deltaTime;
			if (this.FadeTime <= 0f)
			{
				this.FadeTime = 0f;
			}
			this.UpdateBlackScreen();
		}
		if (this.FadeTime <= 0f)
		{
			this.FadeTime = 0f;
		}
		if (this.LerpTime <= 0f)
		{
			this.LerpTime = 0f;
		}
		if (this.FadeTime == 0f && this.LerpTime == 0f)
		{
			if (this.IsFadeIn)
			{
				Global.CharacterCameraManager.FadeAmount = 0f;
			}
			this.OnCloseEvent();
			this.RemoveTick(this.TickIdFade);
		}
	}

	// Token: 0x0600A94E RID: 43342 RVA: 0x00261A63 File Offset: 0x0025FC63
	private void OnSaveTick(float deltaTime)
	{
		this.SaveTime += deltaTime;
		if (this.SaveTime > 10000f)
		{
			this.HideItem();
		}
	}

	// Token: 0x0600A94F RID: 43343 RVA: 0x00261A86 File Offset: 0x0025FC86
	public void ShowItem()
	{
		this.ViewData.SwitchState(BlackScreenViewData.EState.Show);
	}

	// Token: 0x0600A950 RID: 43344 RVA: 0x00261A95 File Offset: 0x0025FC95
	public void HideItem()
	{
		bool flag = this.ViewData.SwitchState(BlackScreenViewData.EState.Hide);
		LevelLoadingModel.Instance.CameraFadeHidePromise = new CustomPromise();
		if (!flag)
		{
			LevelLoadingModel.Instance.FinishCameraShowPromise();
			LevelLoadingModel.Instance.FinishCameraHidePromise();
		}
	}

	// Token: 0x0600A951 RID: 43345 RVA: 0x00261AC8 File Offset: 0x0025FCC8
	public void UpdateScreenColor(EFadeInScreenShowType screenType)
	{
		if (screenType != EFadeInScreenShowType.White)
		{
			if (screenType == EFadeInScreenShowType.Black)
			{
				UUITexture textureWidget = this.TextureWidget;
				if (textureWidget != null)
				{
					textureWidget.SetColor(ColorUtils.ColorBlack);
				}
				PlotModel.Instance.LastPlotColor = 1;
			}
		}
		else
		{
			UUITexture textureWidget2 = this.TextureWidget;
			if (textureWidget2 != null)
			{
				textureWidget2.SetColor(ColorUtils.ColorWhile);
			}
			PlotModel.Instance.LastPlotColor = 0;
		}
		UUITexture textureWidget3 = this.TextureWidget2;
		if (textureWidget3 == null)
		{
			return;
		}
		textureWidget3.SetColor(ColorUtils.ColorBlack);
	}

	// Token: 0x0600A952 RID: 43346 RVA: 0x00261B38 File Offset: 0x0025FD38
	public void UpdateScreenColorAndChangeVisible(EFadeInScreenShowType screenType)
	{
		if (screenType != EFadeInScreenShowType.White)
		{
			if (screenType == EFadeInScreenShowType.Black)
			{
				UUITexture textureWidget = this.TextureWidget;
				if (textureWidget != null)
				{
					textureWidget.SetColor(ColorUtils.ColorBlack);
				}
				PlotModel.Instance.LastPlotColor = 1;
			}
		}
		else
		{
			UUITexture textureWidget2 = this.TextureWidget;
			if (textureWidget2 != null)
			{
				textureWidget2.SetColor(ColorUtils.ColorWhile);
			}
			PlotModel.Instance.LastPlotColor = 0;
		}
		UUITexture textureWidget3 = this.TextureWidget2;
		if (textureWidget3 != null)
		{
			textureWidget3.SetColor(ColorUtils.ColorBlack);
		}
		this.UpdateTextureWidgetVisibility();
	}

	// Token: 0x0600A953 RID: 43347 RVA: 0x00261BAC File Offset: 0x0025FDAC
	public bool ChangeAspect(float aspectRatio, bool? bInstantly = null)
	{
		float num = UiLayer.Instance.UiRootItem.GetWidth() / UiLayer.Instance.UiRootItem.GetHeight();
		if (num < 1f)
		{
			return false;
		}
		if (bInstantly.GetValueOrDefault())
		{
			PlotModel.Instance.BlackScreenLastAspect = PlotModel.Instance.BlackScreenNowAspect;
			PlotModel.Instance.BlackScreenNowAspect = (((double)aspectRatio > 2.3) ? aspectRatio : num);
			this.SetAspect(PlotModel.Instance.BlackScreenNowAspect);
			return false;
		}
		if ((double)PlotModel.Instance.BlackScreenNowAspect > 2.3 != (double)aspectRatio > 2.3 && PlotModel.Instance.LastPlotAspect != -1f && PlotModel.Instance.LastPlotColor == 0)
		{
			PlotModel.Instance.BlackScreenLastAspect = PlotModel.Instance.BlackScreenNowAspect;
			PlotModel.Instance.BlackScreenNowAspect = (((double)aspectRatio > 2.3) ? aspectRatio : num);
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("BlackScreenFadeLerpFullTime").GetValueOrDefault(3);
			this.LerpTime = (float)(valueOrDefault * 1000);
			this.FullLerpTime = (float)(valueOrDefault * 1000);
			UUITexture textureWidget = this.TextureWidget;
			if (textureWidget != null)
			{
				textureWidget.SetUIActive(true);
			}
			return true;
		}
		PlotModel.Instance.BlackScreenNowAspect = (((double)aspectRatio > 2.3) ? aspectRatio : num);
		this.SetAspect(PlotModel.Instance.BlackScreenNowAspect);
		return false;
	}

	// Token: 0x0600A954 RID: 43348 RVA: 0x00261D14 File Offset: 0x0025FF14
	private void SetAspect(float aspectRatio)
	{
		float height = this.RootItem.GetWidth() / aspectRatio;
		UUITexture textureWidget = this.TextureWidget;
		if (textureWidget != null)
		{
			textureWidget.SetHeight(height);
		}
		UUITexture textureWidget2 = this.TextureWidget;
		if (textureWidget2 == null)
		{
			return;
		}
		textureWidget2.SetWidth(this.RootItem.GetWidth());
	}

	// Token: 0x0600A955 RID: 43349 RVA: 0x00261D5C File Offset: 0x0025FF5C
	private void UpdateBlackScreen()
	{
		float num = this.GetNowAlpha();
		if (this.IsFadeIn)
		{
			num = Math.Max(num, this.FadeInAlphaFloor);
			this.FadeInAlphaFloor = num;
		}
		UUITexture textureWidget = this.TextureWidget2;
		if (textureWidget != null)
		{
			textureWidget.SetAlpha(num);
		}
		UUITexture textureWidget2 = this.TextureWidget;
		if (textureWidget2 == null)
		{
			return;
		}
		textureWidget2.SetAlpha(num);
	}

	// Token: 0x0600A956 RID: 43350 RVA: 0x00261DB0 File Offset: 0x0025FFB0
	private float GetNowAlpha()
	{
		if (this.IsFadeIn)
		{
			if (Global.CharacterCameraManager.FadeAmount >= 0.9f)
			{
				return 1f;
			}
			if (this.FullFadeTime == 0f)
			{
				return 1f;
			}
			return 1f - MathUtils.Instance.GetRangePct(0f, this.FullFadeTime, this.FadeTime);
		}
		else
		{
			if (this.FullFadeTime == 0f)
			{
				return 0f;
			}
			return MathUtils.Instance.GetRangePct(0f, this.FullFadeTime, this.FadeTime);
		}
	}

	// Token: 0x0600A957 RID: 43351 RVA: 0x00261E3F File Offset: 0x0026003F
	public void SetFadeTime(float num)
	{
		this.FadeTime = num;
		this.FullFadeTime = num;
	}

	// Token: 0x0600A958 RID: 43352 RVA: 0x00261E4F File Offset: 0x0026004F
	public void SetIsFadeIn(bool value)
	{
		this.IsFadeIn = value;
	}

	// Token: 0x0600A959 RID: 43353 RVA: 0x00261E58 File Offset: 0x00260058
	public EFadeInScreenShowType? GetScreenColorType()
	{
		if (this.TextureWidget == null)
		{
			return null;
		}
		return new EFadeInScreenShowType?(this.TextureWidget.GetColor().Equals(ColorUtils.ColorBlack) ? EFadeInScreenShowType.Black : EFadeInScreenShowType.White);
	}

	// Token: 0x0600A95A RID: 43354 RVA: 0x00261E9A File Offset: 0x0026009A
	private void OnUiViewPortSizeChanged()
	{
		this.SetAspect(PlotModel.Instance.BlackScreenNowAspect);
	}

	// Token: 0x0600A95B RID: 43355 RVA: 0x00261EAC File Offset: 0x002600AC
	[NullableContext(1)]
	private void OnMovieModeAspectOffsetUpdate(IMovieModeAspectOffset offset)
	{
		this.SetAspect(PlotModel.Instance.BlackScreenNowAspect);
	}

	// Token: 0x04004D30 RID: 19760
	private float SaveTime;

	// Token: 0x04004D31 RID: 19761
	private float FadeTime;

	// Token: 0x04004D32 RID: 19762
	private float FullFadeTime;

	// Token: 0x04004D33 RID: 19763
	private float LerpTime;

	// Token: 0x04004D34 RID: 19764
	private float FullLerpTime;

	// Token: 0x04004D35 RID: 19765
	private bool IsFadeIn = true;

	// Token: 0x04004D36 RID: 19766
	private float FadeInAlphaFloor;

	// Token: 0x04004D37 RID: 19767
	private int TickIdFade = -1;

	// Token: 0x04004D38 RID: 19768
	private int TickIdSave = -1;

	// Token: 0x04004D39 RID: 19769
	[Nullable(1)]
	private readonly BlackScreenViewData ViewData = new BlackScreenViewData();

	// Token: 0x04004D3A RID: 19770
	[Nullable(2)]
	private UUITexture TextureWidget;

	// Token: 0x04004D3B RID: 19771
	[Nullable(2)]
	private UUITexture TextureWidget2;

	// Token: 0x04004D3C RID: 19772
	private const float GUARANTEED_TIME = 10000f;

	// Token: 0x04004D3D RID: 19773
	private const float MAX_FADE_VALUE = 0.9f;

	// Token: 0x02007CC3 RID: 31939
	private static class ECompDefine
	{
		// Token: 0x04028ECB RID: 167627
		public const int BlackTexture = 0;

		// Token: 0x04028ECC RID: 167628
		public const int BlackTexture2 = 1;
	}
}
