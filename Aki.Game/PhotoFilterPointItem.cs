using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001A53 RID: 6739
public class PhotoFilterPointItem : UiPanelBase
{
	// Token: 0x06010A22 RID: 68130 RVA: 0x004DDD54 File Offset: 0x004DBF54
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(7, new Action(this.OnResetClick))
		};
	}

	// Token: 0x06010A23 RID: 68131 RVA: 0x004DDE55 File Offset: 0x004DC055
	[NullableContext(2)]
	public void SetViewModel(FilterSettingViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x06010A24 RID: 68132 RVA: 0x004DDE60 File Offset: 0x004DC060
	protected override void OnStart()
	{
		if (this.ViewModel != null)
		{
			FilterSettingViewModel viewModel = this.ViewModel;
			UUIItem item = base.GetItem(2);
			viewModel.UpLeftPos = ((item != null) ? new FVector?(item.K2_GetComponentLocation()) : null);
			FilterSettingViewModel viewModel2 = this.ViewModel;
			UUIItem item2 = base.GetItem(3);
			viewModel2.UpRightPos = ((item2 != null) ? new FVector?(item2.K2_GetComponentLocation()) : null);
			FilterSettingViewModel viewModel3 = this.ViewModel;
			UUIItem item3 = base.GetItem(4);
			viewModel3.DownLeftPos = ((item3 != null) ? new FVector?(item3.K2_GetComponentLocation()) : null);
		}
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			texture.SetRaycastTarget(true);
		}
		this.RefreshResetBtn();
		this.BindAxes();
	}

	// Token: 0x06010A25 RID: 68133 RVA: 0x004DDF18 File Offset: 0x004DC118
	private void BindAxes()
	{
		InputDistributeController instance = InputDistributeController.Instance;
		instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
		instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
	}

	// Token: 0x06010A26 RID: 68134 RVA: 0x004DDF4C File Offset: 0x004DC14C
	public void OnPointTick(float delta)
	{
		if (this.ViewModel == null)
		{
			return;
		}
		Action onPadChangeStop = this.ViewModel.OnPadChangeStop;
		if (onPadChangeStop != null)
		{
			onPadChangeStop();
		}
		if (LguiEventSystemManager.Instance.GetNowHitComponentName() == "TexFilter")
		{
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			if (pointerEventData != null)
			{
				EPointerEventType eventType = pointerEventData.eventType;
				if (eventType == EPointerEventType.Down || eventType - EPointerEventType.BeginDrag <= 1)
				{
					FVector worldPointInPlane = pointerEventData.GetWorldPointInPlane();
					this.ViewModel.HorizontalReal = new float?(worldPointInPlane.X);
					this.ViewModel.VerticalReal = new float?(worldPointInPlane.Z);
					Action onPadChanged = this.ViewModel.OnPadChanged;
					if (onPadChanged != null)
					{
						onPadChanged();
					}
				}
			}
		}
		if (this.ViewModel.IsDirty)
		{
			if (this.ViewModel.IsPropertyDirty(4) || this.ViewModel.IsPropertyDirty(8))
			{
				UUITexture texture = base.GetTexture(1);
				if (texture != null)
				{
					MathUtils instance = MathUtils.Instance;
					FilterSettingViewModel viewModel = this.ViewModel;
					float from = (viewModel.UpLeftPos != null) ? viewModel.UpLeftPos.GetValueOrDefault().X : 0f;
					FilterSettingViewModel viewModel2 = this.ViewModel;
					float inX = instance.Lerp(from, (viewModel2.UpRightPos != null) ? viewModel2.UpRightPos.GetValueOrDefault().X : 0f, this.ViewModel.HorizontalNormalized);
					float inY = 0f;
					MathUtils instance2 = MathUtils.Instance;
					FilterSettingViewModel viewModel3 = this.ViewModel;
					float from2 = (viewModel3.DownLeftPos != null) ? viewModel3.DownLeftPos.GetValueOrDefault().Z : 0f;
					FilterSettingViewModel viewModel4 = this.ViewModel;
					FVector fvector = new FVector(inX, inY, instance2.Lerp(from2, (viewModel4.UpLeftPos != null) ? viewModel4.UpLeftPos.GetValueOrDefault().Z : 0f, this.ViewModel.VerticalNormalized));
					texture.SetUIWorldLocation(fvector);
				}
				LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), this.ViewModel.CoordinateTextId, new <>z__ReadOnlyArray<object>(new object[]
				{
					this.ViewModel.HorizontalString,
					this.ViewModel.VerticalString
				}));
				this.RefreshResetBtn();
			}
			if (this.ViewModel.IsPropertyDirty(64) && !this.ViewModel.IsHideByPad)
			{
				AudioSystem.Instance.PostEvent("play_ui_ia_com_click_small");
			}
			if (this.ViewModel.IsPropertyDirty(32))
			{
				base.TrySetTextureByPath(this.ViewModel.FilterPadTexturePath, base.GetTexture(0), null, null);
			}
			if (this.ViewModel.IsPropertyDirty(16))
			{
				this.RefreshTitle();
			}
			this.ViewModel.CleanDirty();
		}
	}

	// Token: 0x06010A27 RID: 68135 RVA: 0x004DE1CE File Offset: 0x004DC3CE
	protected override void OnBeforeDestroy()
	{
		this.UnBindAxes();
	}

	// Token: 0x06010A28 RID: 68136 RVA: 0x004DE1D6 File Offset: 0x004DC3D6
	private void UnBindAxes()
	{
		InputDistributeController instance = InputDistributeController.Instance;
		instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
		instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
	}

	// Token: 0x06010A29 RID: 68137 RVA: 0x004DE20A File Offset: 0x004DC40A
	private bool IsFilterNavigationFocused()
	{
		if (!this.IsPointSubTab)
		{
			return false;
		}
		TsUiNavigationBehaviorListener currentNavigationFocusListener = UiNavigationNewController.Instance.GetCurrentNavigationFocusListener();
		string a;
		if (currentNavigationFocusListener == null)
		{
			a = null;
		}
		else
		{
			NavigationGroup navigationGroup = currentNavigationFocusListener.GetNavigationGroup();
			a = ((navigationGroup != null) ? navigationGroup.GroupName : null);
		}
		return a == "GroupFilter";
	}

	// Token: 0x06010A2A RID: 68138 RVA: 0x004DE242 File Offset: 0x004DC442
	[NullableContext(1)]
	private void OnInputUiMoveForward(string axisName, float value, InputIdentification _)
	{
		if (!this.IsFilterNavigationFocused())
		{
			return;
		}
		FilterSettingViewModel viewModel = this.ViewModel;
		if (viewModel == null)
		{
			return;
		}
		Action<string, float> onInputUiMoveForward = viewModel.OnInputUiMoveForward;
		if (onInputUiMoveForward == null)
		{
			return;
		}
		onInputUiMoveForward(axisName, value);
	}

	// Token: 0x06010A2B RID: 68139 RVA: 0x004DE269 File Offset: 0x004DC469
	[NullableContext(1)]
	private void OnInputUiMoveRight(string axisName, float value, InputIdentification _)
	{
		if (!this.IsFilterNavigationFocused())
		{
			return;
		}
		FilterSettingViewModel viewModel = this.ViewModel;
		if (viewModel == null)
		{
			return;
		}
		Action<string, float> onInputUiMoveRight = viewModel.OnInputUiMoveRight;
		if (onInputUiMoveRight == null)
		{
			return;
		}
		onInputUiMoveRight(axisName, value);
	}

	// Token: 0x06010A2C RID: 68140 RVA: 0x004DE290 File Offset: 0x004DC490
	public void SetPointSubTabActive(bool isPoint)
	{
		this.IsPointSubTab = isPoint;
	}

	// Token: 0x06010A2D RID: 68141 RVA: 0x004DE299 File Offset: 0x004DC499
	public void RefreshTitle()
	{
		FilterSettingViewModel viewModel = this.ViewModel;
		if (((viewModel != null) ? viewModel.FilterNameTextId : null) == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), this.ViewModel.FilterNameTextId, Array.Empty<object>());
	}

	// Token: 0x06010A2E RID: 68142 RVA: 0x004DE2D1 File Offset: 0x004DC4D1
	private void OnResetClick()
	{
		FilterSettingViewModel viewModel = this.ViewModel;
		if (viewModel != null)
		{
			Action onResetPointClick = viewModel.OnResetPointClick;
			if (onResetPointClick != null)
			{
				onResetPointClick();
			}
		}
		this.RefreshResetBtn();
	}

	// Token: 0x06010A2F RID: 68143 RVA: 0x004DE2F5 File Offset: 0x004DC4F5
	public void RefreshResetBtn()
	{
		UUIButtonComponent button = base.GetButton(7);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(FilterSettingController.Instance.IsFilterPointChanged());
	}

	// Token: 0x04009317 RID: 37655
	[Nullable(2)]
	private FilterSettingViewModel ViewModel;

	// Token: 0x04009318 RID: 37656
	private bool IsPointSubTab;

	// Token: 0x02007CD1 RID: 31953
	private enum EComponents
	{
		// Token: 0x040286A9 RID: 165545
		TextureFilter,
		// Token: 0x040286AA RID: 165546
		TexturePointSele,
		// Token: 0x040286AB RID: 165547
		ItemUpLeft,
		// Token: 0x040286AC RID: 165548
		ItemUpRight,
		// Token: 0x040286AD RID: 165549
		ItemDownLeft,
		// Token: 0x040286AE RID: 165550
		ItemDownRight,
		// Token: 0x040286AF RID: 165551
		TextNum,
		// Token: 0x040286B0 RID: 165552
		BtnReset,
		// Token: 0x040286B1 RID: 165553
		TextTitle
	}
}
