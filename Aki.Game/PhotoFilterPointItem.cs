using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002568 RID: 9576
public class PhotoFilterPointItem : UiPanelBase
{
	// Token: 0x06013540 RID: 79168 RVA: 0x004CF11C File Offset: 0x004CD31C
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

	// Token: 0x06013541 RID: 79169 RVA: 0x004CF21D File Offset: 0x004CD41D
	[NullableContext(2)]
	public void SetViewModel(FilterSettingViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x06013542 RID: 79170 RVA: 0x004CF228 File Offset: 0x004CD428
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

	// Token: 0x06013543 RID: 79171 RVA: 0x004CF2E0 File Offset: 0x004CD4E0
	private void BindAxes()
	{
		InputDistributeController instance = InputDistributeController.Instance;
		instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
		instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
	}

	// Token: 0x06013544 RID: 79172 RVA: 0x004CF314 File Offset: 0x004CD514
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

	// Token: 0x06013545 RID: 79173 RVA: 0x004CF596 File Offset: 0x004CD796
	protected override void OnBeforeDestroy()
	{
		this.UnBindAxes();
	}

	// Token: 0x06013546 RID: 79174 RVA: 0x004CF59E File Offset: 0x004CD79E
	private void UnBindAxes()
	{
		InputDistributeController instance = InputDistributeController.Instance;
		instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
		instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
	}

	// Token: 0x06013547 RID: 79175 RVA: 0x004CF5D2 File Offset: 0x004CD7D2
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

	// Token: 0x06013548 RID: 79176 RVA: 0x004CF60A File Offset: 0x004CD80A
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

	// Token: 0x06013549 RID: 79177 RVA: 0x004CF631 File Offset: 0x004CD831
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

	// Token: 0x0601354A RID: 79178 RVA: 0x004CF658 File Offset: 0x004CD858
	public void SetPointSubTabActive(bool isPoint)
	{
		this.IsPointSubTab = isPoint;
	}

	// Token: 0x0601354B RID: 79179 RVA: 0x004CF661 File Offset: 0x004CD861
	public void RefreshTitle()
	{
		FilterSettingViewModel viewModel = this.ViewModel;
		if (((viewModel != null) ? viewModel.FilterNameTextId : null) == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), this.ViewModel.FilterNameTextId, Array.Empty<object>());
	}

	// Token: 0x0601354C RID: 79180 RVA: 0x004CF699 File Offset: 0x004CD899
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

	// Token: 0x0601354D RID: 79181 RVA: 0x004CF6BD File Offset: 0x004CD8BD
	public void RefreshResetBtn()
	{
		UUIButtonComponent button = base.GetButton(7);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(FilterSettingController.Instance.IsFilterPointChanged());
	}

	// Token: 0x040091BE RID: 37310
	[Nullable(2)]
	private FilterSettingViewModel ViewModel;

	// Token: 0x040091BF RID: 37311
	private bool IsPointSubTab;

	// Token: 0x02008B4B RID: 35659
	private enum EComponents
	{
		// Token: 0x0402D39C RID: 185244
		TextureFilter,
		// Token: 0x0402D39D RID: 185245
		TexturePointSele,
		// Token: 0x0402D39E RID: 185246
		ItemUpLeft,
		// Token: 0x0402D39F RID: 185247
		ItemUpRight,
		// Token: 0x0402D3A0 RID: 185248
		ItemDownLeft,
		// Token: 0x0402D3A1 RID: 185249
		ItemDownRight,
		// Token: 0x0402D3A2 RID: 185250
		TextNum,
		// Token: 0x0402D3A3 RID: 185251
		BtnReset,
		// Token: 0x0402D3A4 RID: 185252
		TextTitle
	}
}
