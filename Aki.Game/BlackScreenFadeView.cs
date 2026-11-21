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

// Token: 0x02000BC6 RID: 3014
public class BlackScreenFadeView : UiPanelBase
{
	// Token: 0x06007D24 RID: 32036 RVA: 0x0026B91C File Offset: 0x00269B1C
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

	// Token: 0x06007D25 RID: 32037 RVA: 0x0026B988 File Offset: 0x00269B88
	protected override void OnStart()
	{
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.Show, new Action(this.ShowDelegate));
		this.ViewData.RegisterStateDelegate(BlackScreenViewData.EState.Hide, new Action(this.HideDelegate));
		this.TextureWidget = base.GetTexture(1);
		this.TextureWidget2 = base.GetTexture(0);
		this.ExpandBackTexture();
		UUITexture textureWidget = this.TextureWidget;
		if (textureWidget != null)
		{
			textureWidget.SetWidth(this.RootItem.GetWidth() * 3f);
		}
		LguiUtil.Instance.SetActorIsPermanent(this.RootActor, true, true);
		this.ViewData.TriggerCurrentStateDelegate();
		EventSystem.Instance.Add(EEventName.UIViewPortSizeChanged, new Action(this.OnUiViewPortSizeChanged));
		EventSystem.Instance.Add<IMovieModeAspectOffset>(EEventName.MovieModeAspectOffsetUpdate, new Action<IMovieModeAspectOffset>(this.OnMovieModeAspectOffsetUpdate));
	}

	// Token: 0x06007D26 RID: 32038 RVA: 0x0026BA5C File Offset: 0x00269C5C
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

	// Token: 0x06007D27 RID: 32039 RVA: 0x0026BB04 File Offset: 0x00269D04
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

	// Token: 0x06007D28 RID: 32040 RVA: 0x0026BBFE File Offset: 0x00269DFE
	private void ShowDelegate()
	{
		EventSystem.Instance.Emit(EEventName.OnBlackFadeScreenStart);
		this.FadeInAlphaFloor = 0f;
		this.AddTick(this.TickIdFade);
		this.SetActive(true);
		this.UpdateTextureWidgetVisibility();
		this.UpdateBlackScreen();
	}

	// Token: 0x06007D29 RID: 32041 RVA: 0x0026BC3A File Offset: 0x00269E3A
	private void HideDelegate()
	{
		this.SetActive(true);
		this.AddTick(this.TickIdFade);
		this.UpdateTextureWidgetVisibility();
		PlotModel.Instance.LastPlotColor = -1;
	}

	// Token: 0x06007D2A RID: 32042 RVA: 0x0026BC60 File Offset: 0x00269E60
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

	// Token: 0x06007D2B RID: 32043 RVA: 0x0026BC94 File Offset: 0x00269E94
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

	// Token: 0x06007D2C RID: 32044 RVA: 0x0026BD18 File Offset: 0x00269F18
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

	// Token: 0x06007D2D RID: 32045 RVA: 0x0026BD80 File Offset: 0x00269F80
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

	// Token: 0x06007D2E RID: 32046 RVA: 0x0026BEA7 File Offset: 0x0026A0A7
	private void OnSaveTick(float deltaTime)
	{
		this.SaveTime += deltaTime;
		if (this.SaveTime > 10000f)
		{
			this.HideItem();
		}
	}

	// Token: 0x06007D2F RID: 32047 RVA: 0x0026BECA File Offset: 0x0026A0CA
	public void ShowItem()
	{
		this.ViewData.SwitchState(BlackScreenViewData.EState.Show);
	}

	// Token: 0x06007D30 RID: 32048 RVA: 0x0026BED9 File Offset: 0x0026A0D9
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

	// Token: 0x06007D31 RID: 32049 RVA: 0x0026BF0C File Offset: 0x0026A10C
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

	// Token: 0x06007D32 RID: 32050 RVA: 0x0026BF7C File Offset: 0x0026A17C
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

	// Token: 0x06007D33 RID: 32051 RVA: 0x0026BFF0 File Offset: 0x0026A1F0
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

	// Token: 0x06007D34 RID: 32052 RVA: 0x0026C158 File Offset: 0x0026A358
	private void SetAspect(float aspectRatio)
	{
		if (this.TextureWidget == null)
		{
			return;
		}
		UUIItem uiRootItem = UiLayer.Instance.UiRootItem;
		float height = uiRootItem.GetWidth() * uiRootItem.K2_GetComponentScale().X / aspectRatio / this.TextureWidget.K2_GetComponentScale().Y;
		this.TextureWidget.SetHeight(height);
		UUITexture textureWidget = this.TextureWidget;
		if (textureWidget == null)
		{
			return;
		}
		textureWidget.SetWidth(this.RootItem.GetWidth() * 3f);
	}

	// Token: 0x06007D35 RID: 32053 RVA: 0x0026C1CC File Offset: 0x0026A3CC
	private void ExpandBackTexture()
	{
		UUITexture textureWidget = this.TextureWidget2;
		if (textureWidget != null)
		{
			textureWidget.SetWidth(this.RootItem.GetWidth() * 3f);
		}
		UUITexture textureWidget2 = this.TextureWidget2;
		if (textureWidget2 == null)
		{
			return;
		}
		textureWidget2.SetHeight(this.RootItem.GetHeight() * 3f);
	}

	// Token: 0x06007D36 RID: 32054 RVA: 0x0026C21C File Offset: 0x0026A41C
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

	// Token: 0x06007D37 RID: 32055 RVA: 0x0026C270 File Offset: 0x0026A470
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

	// Token: 0x06007D38 RID: 32056 RVA: 0x0026C2FF File Offset: 0x0026A4FF
	public void SetFadeTime(float num)
	{
		this.FadeTime = num;
		this.FullFadeTime = num;
	}

	// Token: 0x06007D39 RID: 32057 RVA: 0x0026C30F File Offset: 0x0026A50F
	public void SetIsFadeIn(bool value)
	{
		this.IsFadeIn = value;
	}

	// Token: 0x06007D3A RID: 32058 RVA: 0x0026C318 File Offset: 0x0026A518
	public EFadeInScreenShowType? GetScreenColorType()
	{
		if (this.TextureWidget == null)
		{
			return null;
		}
		return new EFadeInScreenShowType?(this.TextureWidget.GetColor().Equals(ColorUtils.ColorBlack) ? EFadeInScreenShowType.Black : EFadeInScreenShowType.White);
	}

	// Token: 0x06007D3B RID: 32059 RVA: 0x0026C35A File Offset: 0x0026A55A
	private void OnUiViewPortSizeChanged()
	{
		this.ExpandBackTexture();
		this.SetAspect(PlotModel.Instance.BlackScreenNowAspect);
	}

	// Token: 0x06007D3C RID: 32060 RVA: 0x0026C372 File Offset: 0x0026A572
	[NullableContext(1)]
	private void OnMovieModeAspectOffsetUpdate(IMovieModeAspectOffset offset)
	{
		this.SetAspect(PlotModel.Instance.BlackScreenNowAspect);
	}

	// Token: 0x04004DD7 RID: 19927
	private float SaveTime;

	// Token: 0x04004DD8 RID: 19928
	private float FadeTime;

	// Token: 0x04004DD9 RID: 19929
	private float FullFadeTime;

	// Token: 0x04004DDA RID: 19930
	private float LerpTime;

	// Token: 0x04004DDB RID: 19931
	private float FullLerpTime;

	// Token: 0x04004DDC RID: 19932
	private bool IsFadeIn = true;

	// Token: 0x04004DDD RID: 19933
	private float FadeInAlphaFloor;

	// Token: 0x04004DDE RID: 19934
	private int TickIdFade = -1;

	// Token: 0x04004DDF RID: 19935
	private int TickIdSave = -1;

	// Token: 0x04004DE0 RID: 19936
	[Nullable(1)]
	private readonly BlackScreenViewData ViewData = new BlackScreenViewData();

	// Token: 0x04004DE1 RID: 19937
	[Nullable(2)]
	private UUITexture TextureWidget;

	// Token: 0x04004DE2 RID: 19938
	[Nullable(2)]
	private UUITexture TextureWidget2;

	// Token: 0x04004DE3 RID: 19939
	private const float GUARANTEED_TIME = 10000f;

	// Token: 0x04004DE4 RID: 19940
	private const float MAX_FADE_VALUE = 0.9f;

	// Token: 0x04004DE5 RID: 19941
	private const float EXPAND_SCALE = 3f;

	// Token: 0x02006E48 RID: 28232
	private static class ECompDefine
	{
		// Token: 0x040241F4 RID: 147956
		public const int BlackTexture = 0;

		// Token: 0x040241F5 RID: 147957
		public const int BlackTexture2 = 1;
	}
}
