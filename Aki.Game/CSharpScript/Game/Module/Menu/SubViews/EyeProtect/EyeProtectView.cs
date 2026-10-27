using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.SubViews.EyeProtect
{
	// Token: 0x0200544E RID: 21582
	[NullableContext(1)]
	[Nullable(0)]
	public class EyeProtectView : UiViewBase
	{
		// Token: 0x0603719B RID: 225691 RVA: 0x00D0F674 File Offset: 0x00D0D874
		public EyeProtectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603719C RID: 225692 RVA: 0x00D0F688 File Offset: 0x00D0D888
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIItem))
			};
		}

		// Token: 0x0603719D RID: 225693 RVA: 0x00D0F766 File Offset: 0x00D0D966
		protected override void OnBeforeCreate()
		{
			this.VmCache = (this.OpenParam as EyeProtectViewModel);
			this.VmCache.OnSliderValueChange = new Action(this.RefreshApplyBtn);
		}

		// Token: 0x0603719E RID: 225694 RVA: 0x00D0F790 File Offset: 0x00D0D990
		protected override UniTask OnBeforeStartAsync()
		{
			EyeProtectView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EyeProtectView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603719F RID: 225695 RVA: 0x00D0F7D3 File Offset: 0x00D0D9D3
		protected override void OnBeforeShow()
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag(this.ViewInfo.Name);
		}

		// Token: 0x060371A0 RID: 225696 RVA: 0x00D0F7EF File Offset: 0x00D0D9EF
		protected override void OnBeforeHide()
		{
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag(this.ViewInfo.Name);
		}

		// Token: 0x060371A1 RID: 225697 RVA: 0x00D0F80C File Offset: 0x00D0DA0C
		protected override void OnBeforeDestroy()
		{
			UiLayer.Instance.SetLayerActive(ELayerType.HUD, true);
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache != null)
			{
				FilterCameraComponent filterCameraComponent = vmCache.FilterCameraComponent;
				if (filterCameraComponent != null)
				{
					filterCameraComponent.ClosePhotograph();
				}
			}
			base.GetExtendToggle(5).OnStateChange.Remove(new Action<EToggleState>(this.OnEyeToggleStateChange));
			EyeProtectController.Instance.SwitchFilter(true);
			EyeProtectController.Instance.ApplyEyeProtectSetting();
		}

		// Token: 0x060371A2 RID: 225698 RVA: 0x00D0F874 File Offset: 0x00D0DA74
		protected override void OnStart()
		{
			if (this.VmCache == null)
			{
				return;
			}
			this.LayoutItems = new GenericLayout<EyeProtectItem, EyeProtectItemData>(base.GetVerticalLayout(1), new Func<EyeProtectItem>(this.CreateEyeProtectItem), null, false, true);
			this.ItemDataList = this.VmCache.GetModeDataList();
			this.LayoutItems.RefreshByData(this.ItemDataList, null, false);
			this.SelectTagByIndex(this.VmCache.ModeCurValue.GetValueOrDefault());
		}

		// Token: 0x060371A3 RID: 225699 RVA: 0x00D0F8E8 File Offset: 0x00D0DAE8
		protected override void OnAddEventListener()
		{
			UUIDraggableComponent draggable = base.GetDraggable(7);
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
			InputDistributeController.Instance.BindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
			InputDistributeController.Instance.BindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
		}

		// Token: 0x060371A4 RID: 225700 RVA: 0x00D0F9C4 File Offset: 0x00D0DBC4
		protected override void OnRemoveEventListener()
		{
			UUIDraggableComponent draggable = base.GetDraggable(7);
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
			InputDistributeController.Instance.UnBindAxis("UiLookUp", new TInputHandle<float>(this.OnInputUiLookUp));
			InputDistributeController.Instance.UnBindAxis("UiTurn", new TInputHandle<float>(this.OnInputUiTurn));
		}

		// Token: 0x060371A5 RID: 225701 RVA: 0x00D0FA73 File Offset: 0x00D0DC73
		private EyeProtectItem CreateEyeProtectItem()
		{
			return new EyeProtectItem
			{
				SelectCallback = new Action<int>(this.SelectTagByIndex),
				CanExecuteChange = new Func<int, bool>(this.CanToggleChange)
			};
		}

		// Token: 0x060371A6 RID: 225702 RVA: 0x00D0FAA0 File Offset: 0x00D0DCA0
		private void SelectTagByIndex(int gridIndex)
		{
			EyeProtectItemData eyeProtectItemData = this.ItemDataList[gridIndex];
			if (eyeProtectItemData == null)
			{
				return;
			}
			GenericLayout<EyeProtectItem, EyeProtectItemData> layoutItems = this.LayoutItems;
			if (layoutItems != null)
			{
				layoutItems.SelectGridProxy(gridIndex, false);
			}
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache != null)
			{
				vmCache.OnModeValueChange(eyeProtectItemData.GetModeValue());
			}
			this.RefreshApplyBtn();
			if (eyeProtectItemData.GetModeValue() == 2)
			{
				base.GetItem(3).SetUIActive(true);
				return;
			}
			base.GetItem(3).SetUIActive(false);
		}

		// Token: 0x060371A7 RID: 225703 RVA: 0x00D0FB14 File Offset: 0x00D0DD14
		private bool CanToggleChange(int gridIndex)
		{
			GenericLayout<EyeProtectItem, EyeProtectItemData> layoutItems = this.LayoutItems;
			int? num = (layoutItems != null) ? new int?(layoutItems.GetSelectedGridIndex()) : null;
			return !(gridIndex == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x060371A8 RID: 225704 RVA: 0x00D0FB56 File Offset: 0x00D0DD56
		private void OnResetClick(int _)
		{
			this.HandleResetClick();
		}

		// Token: 0x060371A9 RID: 225705 RVA: 0x00D0FB60 File Offset: 0x00D0DD60
		private void HandleResetClick()
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache == null || vmCache.ModeCurValue.GetValueOrDefault() != 2)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("EyeProtectMode_Tips_ResetFail", Array.Empty<object>());
				return;
			}
			EyeProtectItem eyeProtectItem = null;
			List<EyeProtectSliderData> sliderDataList = this.VmCache.GetSliderDataList(EModeValue.Custom);
			if (sliderDataList != null)
			{
				foreach (EyeProtectSliderData eyeProtectSliderData in sliderDataList)
				{
					eyeProtectSliderData.OnChangeValue(eyeProtectSliderData.DefaultCurValue);
				}
				if (this.LayoutItems != null)
				{
					foreach (EyeProtectItem eyeProtectItem2 in this.LayoutItems.GetLayoutItemList())
					{
						EyeProtectItemData data = eyeProtectItem2.Data;
						if (data != null && data.GetModeValue() == 2)
						{
							eyeProtectItem = eyeProtectItem2;
							break;
						}
					}
					if (eyeProtectItem != null)
					{
						GenericScrollViewNew<EyeProtectSliderItem, EyeProtectSliderData> scrollView = eyeProtectItem.ScrollView;
						if (scrollView != null)
						{
							scrollView.RefreshByData(sliderDataList, null, false);
						}
						ScrollingTipsController.Instance.ShowTipsByTextId("EyeProtectMode_Tips_ResetSuccess", Array.Empty<object>());
					}
				}
			}
		}

		// Token: 0x060371AA RID: 225706 RVA: 0x00D0FC94 File Offset: 0x00D0DE94
		private void OnConfirmClick(int _)
		{
			this.HandleConfirmClick();
		}

		// Token: 0x060371AB RID: 225707 RVA: 0x00D0FC9C File Offset: 0x00D0DE9C
		private void HandleConfirmClick()
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache != null && vmCache.IsDirty)
			{
				EyeProtectViewModel vmCache2 = this.VmCache;
				if (vmCache2 != null)
				{
					vmCache2.OnModeValueApply();
				}
				if (this.LayoutItems != null)
				{
					foreach (EyeProtectItem eyeProtectItem in this.LayoutItems.GetLayoutItemList())
					{
						eyeProtectItem.OnApply(this.VmCache.ModeCurValue.Value);
					}
				}
				List<EyeProtectSliderData> sliderDataList = this.VmCache.GetSliderDataList(EModeValue.Custom);
				if (sliderDataList != null)
				{
					foreach (EyeProtectSliderData eyeProtectSliderData in sliderDataList)
					{
						eyeProtectSliderData.OnApplyValue();
					}
					this.VmCache.IsSliderDirty = false;
				}
				MenuModel.Instance.IsEdited = true;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("EyeProtectMode_Tips_ApplySuccess", Array.Empty<object>());
			this.RefreshApplyBtn();
		}

		// Token: 0x060371AC RID: 225708 RVA: 0x00D0FDB4 File Offset: 0x00D0DFB4
		private void OnEyeToggleStateChange(EToggleState state)
		{
			base.GetItem(6).SetUIActive(state == EToggleState.ETT_Checked);
			base.GetItem(8).SetUIActive(state == EToggleState.ETT_Checked);
		}

		// Token: 0x060371AD RID: 225709 RVA: 0x00D0FDD8 File Offset: 0x00D0DFD8
		private void OnCloseClick()
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache != null && vmCache.IsDirty)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.EyeProtectModeExit);
				confirmBoxDataNew.FunctionMap.Add(2, new Action(this.CloseMySelf));
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.CloseMySelf();
		}

		// Token: 0x060371AE RID: 225710 RVA: 0x00D0FE2F File Offset: 0x00D0E02F
		public void CloseMySelf()
		{
			FilterSettingController.Instance.CloseViewAndReturnWorld();
		}

		// Token: 0x060371AF RID: 225711 RVA: 0x00D0FE3C File Offset: 0x00D0E03C
		private void OpenHelpView()
		{
			HelpController.Instance.OpenHelpById(390);
		}

		// Token: 0x060371B0 RID: 225712 RVA: 0x00D0FE50 File Offset: 0x00D0E050
		private void RefreshApplyBtn()
		{
			EyeProtectViewModel vmCache = this.VmCache;
			bool? flag = (vmCache != null) ? new bool?(vmCache.IsDirty) : null;
			ButtonItem confirmBtnItem = this.ConfirmBtnItem;
			if (confirmBtnItem == null)
			{
				return;
			}
			confirmBtnItem.SetEnableClick(flag.GetValueOrDefault());
		}

		// Token: 0x060371B1 RID: 225713 RVA: 0x00D0FE94 File Offset: 0x00D0E094
		[NullableContext(2)]
		private void OnDragMoved(ULGUIPointerEventData eventData)
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			vmCache.OnDragMoved(eventData);
		}

		// Token: 0x060371B2 RID: 225714 RVA: 0x00D0FEA7 File Offset: 0x00D0E0A7
		private void OnDragBegin(ULGUIPointerEventData _)
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			vmCache.OnDragBegin();
		}

		// Token: 0x060371B3 RID: 225715 RVA: 0x00D0FEB9 File Offset: 0x00D0E0B9
		private void OnDragEnded(ULGUIPointerEventData _)
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			vmCache.OnDragEnded();
		}

		// Token: 0x060371B4 RID: 225716 RVA: 0x00D0FECB File Offset: 0x00D0E0CB
		private void OnInputUiLookUp(string axisName, float value, InputIdentification _)
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			vmCache.OnInputUiLookUp(axisName, value);
		}

		// Token: 0x060371B5 RID: 225717 RVA: 0x00D0FEDF File Offset: 0x00D0E0DF
		private void OnInputUiTurn(string axisName, float value, InputIdentification _)
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			vmCache.OnInputUiTurn(axisName, value);
		}

		// Token: 0x0401D11E RID: 119070
		[Nullable(2)]
		public EyeProtectViewModel VmCache;

		// Token: 0x0401D11F RID: 119071
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401D120 RID: 119072
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<EyeProtectItem, EyeProtectItemData> LayoutItems;

		// Token: 0x0401D121 RID: 119073
		private List<EyeProtectItemData> ItemDataList = new List<EyeProtectItemData>();

		// Token: 0x0401D122 RID: 119074
		[Nullable(2)]
		private ButtonItem ResetBtnItem;

		// Token: 0x0401D123 RID: 119075
		[Nullable(2)]
		private ButtonItem ConfirmBtnItem;

		// Token: 0x0200B6C8 RID: 46792
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x04037600 RID: 226816
			public const int CaptionItem = 0;

			// Token: 0x04037601 RID: 226817
			public const int Layout = 1;

			// Token: 0x04037602 RID: 226818
			public const int Item = 2;

			// Token: 0x04037603 RID: 226819
			public const int BtnReset = 3;

			// Token: 0x04037604 RID: 226820
			public const int BtnConfirm = 4;

			// Token: 0x04037605 RID: 226821
			public const int TogEye = 5;

			// Token: 0x04037606 RID: 226822
			public const int Parent = 6;

			// Token: 0x04037607 RID: 226823
			public const int ScreenDrag = 7;

			// Token: 0x04037608 RID: 226824
			public const int TexMask = 8;
		}
	}
}
