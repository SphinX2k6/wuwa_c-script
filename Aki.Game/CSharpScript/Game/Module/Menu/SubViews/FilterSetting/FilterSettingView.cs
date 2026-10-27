using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AutoAttach;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.FilterSetting
{
	// Token: 0x02005445 RID: 21573
	[NullableContext(1)]
	[Nullable(0)]
	public class FilterSettingView : UiTickViewBase
	{
		// Token: 0x06037132 RID: 225586 RVA: 0x00D0D765 File Offset: 0x00D0B965
		public FilterSettingView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06037133 RID: 225587 RVA: 0x00D0D778 File Offset: 0x00D0B978
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(7, typeof(UUITexture)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(12, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(14, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(15, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(16, typeof(UUIItem)),
				new ValueTuple<int, Type>(17, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(18, typeof(UUIItem)),
				new ValueTuple<int, Type>(19, typeof(UUIItem)),
				new ValueTuple<int, Type>(21, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(22, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(23, typeof(UUIItem)),
				new ValueTuple<int, Type>(24, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(26, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(9, new Action(this.OnResetClick)),
				new ValueTuple<int, Delegate>(10, new Action(this.OnConfirmClick)),
				new ValueTuple<int, Delegate>(13, new Action(this.OnLeftArrowClick)),
				new ValueTuple<int, Delegate>(12, new Action(this.OnRightArrowClick)),
				new ValueTuple<int, Delegate>(15, new Action<EToggleState>(this.OnHideClick)),
				new ValueTuple<int, Delegate>(21, new Action<EToggleState>(this.OnColorPaletteToggleClick)),
				new ValueTuple<int, Delegate>(22, new Action<EToggleState>(this.OnSeniorParamToggleClick)),
				new ValueTuple<int, Delegate>(26, new Action(this.OnDefaultFilterClick))
			};
		}

		// Token: 0x06037134 RID: 225588 RVA: 0x00D0DA99 File Offset: 0x00D0BC99
		protected override void OnBeforeCreate()
		{
			this.VmCache = (this.OpenParam as FilterSettingViewModel);
			Action onViewBeforeCreate = this.VmCache.OnViewBeforeCreate;
			if (onViewBeforeCreate != null)
			{
				onViewBeforeCreate();
			}
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.KuroEnableScreenFilter 1", null);
		}

		// Token: 0x06037135 RID: 225589 RVA: 0x00D0DAD2 File Offset: 0x00D0BCD2
		protected override void OnStart()
		{
		}

		// Token: 0x06037136 RID: 225590 RVA: 0x00D0DAD4 File Offset: 0x00D0BCD4
		protected override void OnBeforeShow()
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action<string> onViewBeforeShow = vmCache.OnViewBeforeShow;
			if (onViewBeforeShow == null)
			{
				return;
			}
			onViewBeforeShow(this.ViewInfo.Name);
		}

		// Token: 0x06037137 RID: 225591 RVA: 0x00D0DB00 File Offset: 0x00D0BD00
		protected override void OnAfterHide()
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action<string> onViewAfterHide = vmCache.OnViewAfterHide;
			if (onViewAfterHide == null)
			{
				return;
			}
			onViewAfterHide(this.ViewInfo.Name);
		}

		// Token: 0x06037138 RID: 225592 RVA: 0x00D0DB2C File Offset: 0x00D0BD2C
		protected override void OnAfterDestroy()
		{
			UiLayer.Instance.SetLayerActive(ELayerType.HUD, true);
			FilterSettingController instance = FilterSettingController.Instance;
			if (instance != null)
			{
				FilterCameraComponent cameraComponent = instance.CameraComponent;
				if (cameraComponent != null)
				{
					cameraComponent.ClosePhotograph();
				}
			}
			FilterSettingController instance2 = FilterSettingController.Instance;
			if (instance2 != null)
			{
				instance2.SwitchFilter(true);
			}
			FilterSettingController instance3 = FilterSettingController.Instance;
			if (instance3 == null)
			{
				return;
			}
			instance3.ApplyFilterSetting();
		}

		// Token: 0x06037139 RID: 225593 RVA: 0x00D0DB80 File Offset: 0x00D0BD80
		protected override UniTask OnBeforeStartAsync()
		{
			FilterSettingView.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FilterSettingView.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603713A RID: 225594 RVA: 0x00D0DBC4 File Offset: 0x00D0BDC4
		protected override void OnBeforeDestroy()
		{
			CircleAttachView<FilterSetting, FilterSettingPixListItem> circleItem = this.CircleItem;
			if (circleItem != null)
			{
				circleItem.Clear();
			}
			this.CircleItem = null;
			GenericLayout<FilterSeniorParamSliderItem, FilterSeniorSetting> seniorParamLayout = this.SeniorParamLayout;
			if (seniorParamLayout != null)
			{
				seniorParamLayout.ClearChildren();
			}
			this.SeniorParamLayout = null;
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache != null)
			{
				Action onViewDestroy = vmCache.OnViewDestroy;
				if (onViewDestroy != null)
				{
					onViewDestroy();
				}
			}
			this.VmCache = null;
			LoadAsyncPromise<UCurveFloat> offsetHandle = this.OffsetHandle;
			if (offsetHandle != null)
			{
				offsetHandle.CancelAsyncLoad();
			}
			LoadAsyncPromise<UCurveFloat> scaleHandle = this.ScaleHandle;
			if (scaleHandle != null)
			{
				scaleHandle.CancelAsyncLoad();
			}
			LoadAsyncPromise<UCurveFloat> alphaHandle = this.AlphaHandle;
			if (alphaHandle != null)
			{
				alphaHandle.CancelAsyncLoad();
			}
			if (this.CurvesCache != null)
			{
				this.CurvesCache = new UCurveFloat[0];
				this.CurvesCache = null;
			}
		}

		// Token: 0x0603713B RID: 225595 RVA: 0x00D0DC74 File Offset: 0x00D0BE74
		protected override void OnAddEventListener()
		{
			UUIDraggableComponent draggable = base.GetDraggable(17);
			if (draggable != null)
			{
				draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragMoved));
			}
			if (draggable != null)
			{
				draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
			}
			if (draggable != null)
			{
				draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
			}
			if (draggable != null)
			{
				draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
			}
			if (draggable != null)
			{
				draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
			}
			InputDistributeController.Instance.BindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
			InputDistributeController.Instance.BindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
			InputDistributeController.Instance.BindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
			InputDistributeController.Instance.BindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
		}

		// Token: 0x0603713C RID: 225596 RVA: 0x00D0DD88 File Offset: 0x00D0BF88
		protected override void OnRemoveEventListener()
		{
			UUIDraggableComponent draggable = base.GetDraggable(17);
			if (draggable != null)
			{
				draggable.OnPointerDragCallBack.Unbind();
			}
			if (draggable != null)
			{
				draggable.OnPointerBeginDragCallBack.Unbind();
			}
			if (draggable != null)
			{
				draggable.OnPointerEndDragCallBack.Unbind();
			}
			if (draggable != null)
			{
				draggable.OnPointerDownCallBack.Unbind();
			}
			if (draggable != null)
			{
				draggable.OnPointerUpCallBack.Unbind();
			}
			if (draggable != null)
			{
				draggable.OnPointerScrollCallBack.Unbind();
			}
			InputDistributeController.Instance.UnBindAxis("UiMoveForward", new TInputHandle<float>(this.OnInputUiMoveForward));
			InputDistributeController.Instance.UnBindAxis("UiMoveRight", new TInputHandle<float>(this.OnInputUiMoveRight));
			InputDistributeController.Instance.UnBindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
			InputDistributeController.Instance.UnBindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
		}

		// Token: 0x0603713D RID: 225597 RVA: 0x00D0DE70 File Offset: 0x00D0C070
		protected override void OnTick(float delta)
		{
			if (this.VmCache == null)
			{
				return;
			}
			if (!this.VmCache.IsHideByClick)
			{
				Action onPadChangeStop = this.VmCache.OnPadChangeStop;
				if (onPadChangeStop != null)
				{
					onPadChangeStop();
				}
			}
			FilterSettingViewModel vmCache = this.VmCache;
			CircleAttachView<FilterSetting, FilterSettingPixListItem> circleItem = this.CircleItem;
			vmCache.PadLock = (circleItem != null && circleItem.MovingState());
			if (!this.VmCache.CameraRotationLock && !this.VmCache.PadLock && LguiEventSystemManager.Instance.GetNowHitComponentName() == "TexFilter")
			{
				ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
				if (pointerEventData != null)
				{
					FVector worldPointInPlane = pointerEventData.GetWorldPointInPlane();
					EPointerEventType eventType = pointerEventData.eventType;
					if (eventType != EPointerEventType.Down)
					{
						if (eventType - EPointerEventType.BeginDrag <= 1)
						{
							this.VmCache.HorizontalReal = new float?(worldPointInPlane.X);
							this.VmCache.VerticalReal = new float?(worldPointInPlane.Z);
							Action onPadChanged = this.VmCache.OnPadChanged;
							if (onPadChanged != null)
							{
								onPadChanged();
							}
						}
					}
					else
					{
						this.VmCache.HorizontalReal = new float?(worldPointInPlane.X);
						this.VmCache.VerticalReal = new float?(worldPointInPlane.Z);
						Action onPadChanged2 = this.VmCache.OnPadChanged;
						if (onPadChanged2 != null)
						{
							onPadChanged2();
						}
					}
				}
			}
			if (this.VmCache.IsDirty)
			{
				if (this.VmCache.IsPropertyDirty(4) || this.VmCache.IsPropertyDirty(8))
				{
					UUITexture texture = base.GetTexture(7);
					if (texture != null)
					{
						MathUtils instance = MathUtils.Instance;
						FilterSettingViewModel vmCache2 = this.VmCache;
						float from = (vmCache2.UpLeftPos != null) ? vmCache2.UpLeftPos.GetValueOrDefault().X : 0f;
						FilterSettingViewModel vmCache3 = this.VmCache;
						float inX = instance.Lerp(from, (vmCache3.UpRightPos != null) ? vmCache3.UpRightPos.GetValueOrDefault().X : 0f, this.VmCache.HorizontalNormalized);
						float inY = 0f;
						MathUtils instance2 = MathUtils.Instance;
						FilterSettingViewModel vmCache4 = this.VmCache;
						float from2 = (vmCache4.DownLeftPos != null) ? vmCache4.DownLeftPos.GetValueOrDefault().Z : 0f;
						FilterSettingViewModel vmCache5 = this.VmCache;
						FVector fvector = new FVector(inX, inY, instance2.Lerp(from2, (vmCache5.UpLeftPos != null) ? vmCache5.UpLeftPos.GetValueOrDefault().Z : 0f, this.VmCache.VerticalNormalized));
						texture.SetUIWorldLocation(fvector);
					}
					LguiUtil.Instance.TrySetLocalTextNew(base.GetText(5), this.VmCache.CoordinateTextId, new <>z__ReadOnlyArray<object>(new object[]
					{
						this.VmCache.HorizontalString,
						this.VmCache.VerticalString
					}));
				}
				if (this.VmCache.IsPropertyDirty(2))
				{
					FilterSettingSliderItem sliderItem = this.SliderItem;
					if (sliderItem != null)
					{
						sliderItem.SetTitleText(this.VmCache.IntensityString);
					}
					FilterSettingSliderItem sliderItem2 = this.SliderItem;
					if (sliderItem2 != null)
					{
						sliderItem2.SetSliderValue(this.VmCache.IntensityNormalized);
					}
				}
				if (this.VmCache.IsPropertyDirty(16))
				{
					LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), this.VmCache.FilterNameTextId, Array.Empty<object>());
				}
				if (this.VmCache.IsPropertyDirty(32))
				{
					base.TrySetTextureByPath(this.VmCache.FilterPadTexturePath, base.GetTexture(0), null, null);
				}
				if (this.VmCache.IsPropertyDirty(64))
				{
					if (!this.VmCache.IsHideByPad)
					{
						AudioSystem.Instance.PostEvent("play_ui_ia_com_click_small");
					}
					UUIItem item = base.GetItem(14);
					if (item != null)
					{
						item.SetUIActive(!this.VmCache.IsHideByPad);
					}
					UUIItem item2 = base.GetItem(16);
					if (item2 != null)
					{
						item2.SetUIActive(!this.VmCache.IsHideByPad);
					}
					UUIButtonComponent button = base.GetButton(26);
					if (button != null)
					{
						button.RootUIComp.Get().SetUIActive(!this.VmCache.IsHideByPad);
					}
					UUIExtendToggle extendToggle = base.GetExtendToggle(15);
					if (extendToggle != null)
					{
						UUIItem uuiitem = extendToggle.RootUIComp.Get();
						if (uuiitem != null)
						{
							uuiitem.SetUIActive(!this.VmCache.IsHideByPad);
						}
					}
				}
				if (this.VmCache.IsPropertyDirty(128))
				{
					if (this.VmCache.IsHideByClick)
					{
						UUIItem item3 = base.GetItem(18);
						if (item3 != null)
						{
							item3.SetUIActive(false);
						}
						UUIItem item4 = base.GetItem(23);
						if (item4 != null)
						{
							item4.SetUIActive(false);
						}
					}
					else
					{
						this.RefreshOption(this.IsColorPalette);
					}
					UUIItem item5 = base.GetItem(14);
					if (item5 != null)
					{
						item5.SetUIActive(!this.VmCache.IsHideByClick);
					}
					UUIItem item6 = base.GetItem(16);
					if (item6 != null)
					{
						item6.SetUIActive(!this.VmCache.IsHideByClick);
					}
					UUIButtonComponent button2 = base.GetButton(26);
					if (button2 != null)
					{
						button2.RootUIComp.Get().SetUIActive(!this.VmCache.IsHideByClick);
					}
					UUIExtendToggle extendToggle2 = base.GetExtendToggle(15);
					if (extendToggle2 != null)
					{
						extendToggle2.SetToggleStateForce(this.VmCache.IsHideByClick ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
					}
				}
				if (this.VmCache.IsPropertyDirty(256))
				{
					UUIItem item7 = base.GetItem(8);
					if (item7 != null)
					{
						item7.SetUIActive(this.VmCache.IsSliderActive);
					}
				}
				if (this.VmCache.IsPropertyDirty(512))
				{
					GenericLayout<FilterSeniorParamSliderItem, FilterSeniorSetting> seniorParamLayout = this.SeniorParamLayout;
					if (seniorParamLayout != null)
					{
						seniorParamLayout.RefreshWithoutDataSync();
					}
				}
				this.VmCache.CleanDirty();
			}
			base.GetButton(10).SetSelfInteractive(this.VmCache.IsFilterChanged && !this.VmCache.IsApplyClicked);
		}

		// Token: 0x0603713E RID: 225598 RVA: 0x00D0E3FC File Offset: 0x00D0C5FC
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private UniTask<UCurveFloat[]> LoadCurveResource()
		{
			FilterSettingView.<LoadCurveResource>d__23 <LoadCurveResource>d__;
			<LoadCurveResource>d__.<>t__builder = AsyncUniTaskMethodBuilder<UCurveFloat[]>.Create();
			<LoadCurveResource>d__.<>4__this = this;
			<LoadCurveResource>d__.<>1__state = -1;
			<LoadCurveResource>d__.<>t__builder.Start<FilterSettingView.<LoadCurveResource>d__23>(ref <LoadCurveResource>d__);
			return <LoadCurveResource>d__.<>t__builder.Task;
		}

		// Token: 0x0603713F RID: 225599 RVA: 0x00D0E43F File Offset: 0x00D0C63F
		private FilterSeniorParamSliderItem CreateFilterSeniorParamSliderItem()
		{
			return new FilterSeniorParamSliderItem
			{
				ParentViewModel = this.VmCache
			};
		}

		// Token: 0x06037140 RID: 225600 RVA: 0x00D0E452 File Offset: 0x00D0C652
		protected override void OnDestroy()
		{
		}

		// Token: 0x06037141 RID: 225601 RVA: 0x00D0E454 File Offset: 0x00D0C654
		private void OnResetClick()
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action onResetClick = vmCache.OnResetClick;
			if (onResetClick == null)
			{
				return;
			}
			onResetClick();
		}

		// Token: 0x06037142 RID: 225602 RVA: 0x00D0E470 File Offset: 0x00D0C670
		private void OnDefaultFilterClick()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.GameSettingDefaultFilter);
			confirmBoxDataNew.FunctionMap.Add(2, delegate
			{
				CircleAttachView<FilterSetting, FilterSettingPixListItem> circleItem = this.CircleItem;
				if (circleItem != null)
				{
					circleItem.AttachToIndex(0, false);
				}
				FilterSettingViewModel vmCache = this.VmCache;
				if (vmCache != null)
				{
					Action<int> onIndexChanged = vmCache.OnIndexChanged;
					if (onIndexChanged != null)
					{
						onIndexChanged(0);
					}
				}
				this.OnResetClick();
				DefaultFilterLogEvent logData = new DefaultFilterLogEvent();
				LogReportController.Instance.LogReport(logData);
			});
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06037143 RID: 225603 RVA: 0x00D0E4AC File Offset: 0x00D0C6AC
		private void OnConfirmClick()
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache != null)
			{
				Action onConfirmClick = vmCache.OnConfirmClick;
				if (onConfirmClick != null)
				{
					onConfirmClick();
				}
			}
			base.GetButton(10).SetSelfInteractive(false);
			CircleAttachView<FilterSetting, FilterSettingPixListItem> circleItem = this.CircleItem;
			if (circleItem == null)
			{
				return;
			}
			circleItem.RefreshItems();
		}

		// Token: 0x06037144 RID: 225604 RVA: 0x00D0E4E8 File Offset: 0x00D0C6E8
		private void OnLeftArrowClick()
		{
			CircleAttachView<FilterSetting, FilterSettingPixListItem> circleItem = this.CircleItem;
			if (circleItem != null)
			{
				circleItem.AttachToNextItem(-1);
			}
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action onLeftArrowClick = vmCache.OnLeftArrowClick;
			if (onLeftArrowClick == null)
			{
				return;
			}
			onLeftArrowClick();
		}

		// Token: 0x06037145 RID: 225605 RVA: 0x00D0E516 File Offset: 0x00D0C716
		private void OnRightArrowClick()
		{
			CircleAttachView<FilterSetting, FilterSettingPixListItem> circleItem = this.CircleItem;
			if (circleItem != null)
			{
				circleItem.AttachToNextItem(1);
			}
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action onRightArrowClick = vmCache.OnRightArrowClick;
			if (onRightArrowClick == null)
			{
				return;
			}
			onRightArrowClick();
		}

		// Token: 0x06037146 RID: 225606 RVA: 0x00D0E544 File Offset: 0x00D0C744
		private void OnHideClick(EToggleState state)
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action onHideClick = vmCache.OnHideClick;
			if (onHideClick == null)
			{
				return;
			}
			onHideClick();
		}

		// Token: 0x06037147 RID: 225607 RVA: 0x00D0E560 File Offset: 0x00D0C760
		private void OnCloseClick()
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action onCloseClick = vmCache.OnCloseClick;
			if (onCloseClick == null)
			{
				return;
			}
			onCloseClick();
		}

		// Token: 0x06037148 RID: 225608 RVA: 0x00D0E57C File Offset: 0x00D0C77C
		private void OpenHelpView()
		{
			HelpController.Instance.OpenHelpById(323);
		}

		// Token: 0x06037149 RID: 225609 RVA: 0x00D0E58D File Offset: 0x00D0C78D
		private void OnColorPaletteToggleClick(EToggleState state)
		{
			this.RefreshOption(true);
		}

		// Token: 0x0603714A RID: 225610 RVA: 0x00D0E596 File Offset: 0x00D0C796
		private void OnSeniorParamToggleClick(EToggleState state)
		{
			this.RefreshOption(false);
		}

		// Token: 0x0603714B RID: 225611 RVA: 0x00D0E5A0 File Offset: 0x00D0C7A0
		private void RefreshOption(bool isColorPalette)
		{
			this.IsColorPalette = isColorPalette;
			UUIItem item = base.GetItem(18);
			if (item != null)
			{
				item.SetUIActive(isColorPalette);
			}
			UUIItem item2 = base.GetItem(23);
			if (item2 != null)
			{
				item2.SetUIActive(!isColorPalette);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(21);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(isColorPalette ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
			}
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(22);
			if (extendToggle2 == null)
			{
				return;
			}
			extendToggle2.SetToggleStateForce((!isColorPalette) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603714C RID: 225612 RVA: 0x00D0E618 File Offset: 0x00D0C818
		[NullableContext(2)]
		private void OnDragMoved(ULGUIPointerEventData eventData)
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action<ULGUIPointerEventData> onDragMoved = vmCache.OnDragMoved;
			if (onDragMoved == null)
			{
				return;
			}
			onDragMoved(eventData);
		}

		// Token: 0x0603714D RID: 225613 RVA: 0x00D0E635 File Offset: 0x00D0C835
		private void OnDragBegin(ULGUIPointerEventData _)
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action onDragBegin = vmCache.OnDragBegin;
			if (onDragBegin == null)
			{
				return;
			}
			onDragBegin();
		}

		// Token: 0x0603714E RID: 225614 RVA: 0x00D0E651 File Offset: 0x00D0C851
		private void OnDragEnded(ULGUIPointerEventData _)
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action onDragEnded = vmCache.OnDragEnded;
			if (onDragEnded == null)
			{
				return;
			}
			onDragEnded();
		}

		// Token: 0x0603714F RID: 225615 RVA: 0x00D0E670 File Offset: 0x00D0C870
		private unsafe void OnInputUiMoveForward(string axisName, float value, InputIdentification _)
		{
			if (value > 0f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "OnInputUiMoveForward";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("axisName", axisName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			if (!this.IsColorPalette)
			{
				return;
			}
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action<string, float> onInputUiMoveForward = vmCache.OnInputUiMoveForward;
			if (onInputUiMoveForward == null)
			{
				return;
			}
			onInputUiMoveForward(axisName, value);
		}

		// Token: 0x06037150 RID: 225616 RVA: 0x00D0E704 File Offset: 0x00D0C904
		private unsafe void OnInputUiMoveRight(string axisName, float value, InputIdentification _)
		{
			if (value > 0f)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Audio;
				ELogAuthor author = ELogAuthor.WZ;
				string message = "OnInputUiMoveRight";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("axisName", axisName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			if (!this.IsColorPalette)
			{
				return;
			}
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action<string, float> onInputUiMoveRight = vmCache.OnInputUiMoveRight;
			if (onInputUiMoveRight == null)
			{
				return;
			}
			onInputUiMoveRight(axisName, value);
		}

		// Token: 0x06037151 RID: 225617 RVA: 0x00D0E796 File Offset: 0x00D0C996
		private void OnInputUiLookUp(string axisName, float value, InputIdentification _)
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action<string, float> onInputUiLookUp = vmCache.OnInputUiLookUp;
			if (onInputUiLookUp == null)
			{
				return;
			}
			onInputUiLookUp(axisName, value);
		}

		// Token: 0x06037152 RID: 225618 RVA: 0x00D0E7B4 File Offset: 0x00D0C9B4
		private void OnInputUiTurn(string axisName, float value, InputIdentification _)
		{
			FilterSettingViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			Action<string, float> onInputUiTurn = vmCache.OnInputUiTurn;
			if (onInputUiTurn == null)
			{
				return;
			}
			onInputUiTurn(axisName, value);
		}

		// Token: 0x06037153 RID: 225619 RVA: 0x00D0E7D4 File Offset: 0x00D0C9D4
		private FilterSettingPixListItem CreateCircleItem(AActor actor, int index, int showNum)
		{
			FilterSettingPixListItem filterSettingPixListItem = new FilterSettingPixListItem(actor);
			filterSettingPixListItem.ParentViewModel = this.VmCache;
			UCurveFloat[] curvesCache = this.CurvesCache;
			filterSettingPixListItem.OffsetCurve = ((curvesCache != null) ? curvesCache[0] : null);
			UCurveFloat[] curvesCache2 = this.CurvesCache;
			filterSettingPixListItem.ScaleCurve = ((curvesCache2 != null) ? curvesCache2[1] : null);
			UCurveFloat[] curvesCache3 = this.CurvesCache;
			filterSettingPixListItem.AlphaCurve = ((curvesCache3 != null) ? curvesCache3[2] : null);
			return filterSettingPixListItem;
		}

		// Token: 0x0401D0F3 RID: 119027
		[Nullable(2)]
		public FilterSettingViewModel VmCache;

		// Token: 0x0401D0F4 RID: 119028
		public bool IsColorPalette = true;

		// Token: 0x0401D0F5 RID: 119029
		[Nullable(2)]
		private FilterSettingSliderItem SliderItem;

		// Token: 0x0401D0F6 RID: 119030
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D0F7 RID: 119031
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private CircleAttachView<FilterSetting, FilterSettingPixListItem> CircleItem;

		// Token: 0x0401D0F8 RID: 119032
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<FilterSeniorParamSliderItem, FilterSeniorSetting> SeniorParamLayout;

		// Token: 0x0401D0F9 RID: 119033
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<UCurveFloat> OffsetHandle;

		// Token: 0x0401D0FA RID: 119034
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<UCurveFloat> ScaleHandle;

		// Token: 0x0401D0FB RID: 119035
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<UCurveFloat> AlphaHandle;

		// Token: 0x0401D0FC RID: 119036
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private UCurveFloat[] CurvesCache;

		// Token: 0x0200B6BE RID: 46782
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x040375BD RID: 226749
			public const int FilterTexture = 0;

			// Token: 0x040375BE RID: 226750
			public const int UpLeftItem = 1;

			// Token: 0x040375BF RID: 226751
			public const int UpRightItem = 2;

			// Token: 0x040375C0 RID: 226752
			public const int DownLeftItem = 3;

			// Token: 0x040375C1 RID: 226753
			public const int DownRightItem = 4;

			// Token: 0x040375C2 RID: 226754
			public const int CoordinatesText = 5;

			// Token: 0x040375C3 RID: 226755
			public const int FilterNameText = 6;

			// Token: 0x040375C4 RID: 226756
			public const int PointSelectionTexture = 7;

			// Token: 0x040375C5 RID: 226757
			public const int SliderRootItem = 8;

			// Token: 0x040375C6 RID: 226758
			public const int ResetFilterParamButton = 9;

			// Token: 0x040375C7 RID: 226759
			public const int ApplyButton = 10;

			// Token: 0x040375C8 RID: 226760
			public const int MiddleTextureItem = 11;

			// Token: 0x040375C9 RID: 226761
			public const int RightArrowButton = 12;

			// Token: 0x040375CA RID: 226762
			public const int LeftArrowButton = 13;

			// Token: 0x040375CB RID: 226763
			public const int CaptionItem = 14;

			// Token: 0x040375CC RID: 226764
			public const int HideToggle = 15;

			// Token: 0x040375CD RID: 226765
			public const int DraggingHideRootItem = 16;

			// Token: 0x040375CE RID: 226766
			public const int ScreenDrag = 17;

			// Token: 0x040375CF RID: 226767
			public const int PointRootItem = 18;

			// Token: 0x040375D0 RID: 226768
			public const int PixListRootItem = 19;

			// Token: 0x040375D1 RID: 226769
			public const int LayoutTab = 20;

			// Token: 0x040375D2 RID: 226770
			public const int ToggleColorPalette = 21;

			// Token: 0x040375D3 RID: 226771
			public const int ToggleSeniorParam = 22;

			// Token: 0x040375D4 RID: 226772
			public const int ItemSeniorParamPanel = 23;

			// Token: 0x040375D5 RID: 226773
			public const int LayoutSeniorParam = 24;

			// Token: 0x040375D6 RID: 226774
			public const int ItemSeniorParamSlider = 25;

			// Token: 0x040375D7 RID: 226775
			public const int BtnDefaultFilter = 26;
		}
	}
}
