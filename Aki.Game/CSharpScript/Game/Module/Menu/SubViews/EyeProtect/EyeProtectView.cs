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
	// Token: 0x02004431 RID: 17457
	[NullableContext(1)]
	[Nullable(0)]
	public class EyeProtectView : UiViewBase
	{
		// Token: 0x0602C0E4 RID: 180452 RVA: 0x00C5EA8C File Offset: 0x00C5CC8C
		public EyeProtectView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602C0E5 RID: 180453 RVA: 0x00C5EAA0 File Offset: 0x00C5CCA0
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

		// Token: 0x0602C0E6 RID: 180454 RVA: 0x00C5EB7E File Offset: 0x00C5CD7E
		protected override void OnBeforeCreate()
		{
			this.VmCache = (this.OpenParam as EyeProtectViewModel);
			this.VmCache.OnSliderValueChange = new Action(this.RefreshApplyBtn);
		}

		// Token: 0x0602C0E7 RID: 180455 RVA: 0x00C5EBA8 File Offset: 0x00C5CDA8
		protected override UniTask OnBeforeStartAsync()
		{
			EyeProtectView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<EyeProtectView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602C0E8 RID: 180456 RVA: 0x00C5EBEB File Offset: 0x00C5CDEB
		protected override void OnBeforeShow()
		{
			UiTimeDilation.Instance.AddWaitSetTimeDilationTag(this.ViewInfo.Name);
		}

		// Token: 0x0602C0E9 RID: 180457 RVA: 0x00C5EC07 File Offset: 0x00C5CE07
		protected override void OnBeforeHide()
		{
			UiTimeDilation.Instance.DeleteWaitSetTimeDilationTag(this.ViewInfo.Name);
		}

		// Token: 0x0602C0EA RID: 180458 RVA: 0x00C5EC24 File Offset: 0x00C5CE24
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

		// Token: 0x0602C0EB RID: 180459 RVA: 0x00C5EC8C File Offset: 0x00C5CE8C
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

		// Token: 0x0602C0EC RID: 180460 RVA: 0x00C5ED00 File Offset: 0x00C5CF00
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

		// Token: 0x0602C0ED RID: 180461 RVA: 0x00C5EDDC File Offset: 0x00C5CFDC
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

		// Token: 0x0602C0EE RID: 180462 RVA: 0x00C5EE8B File Offset: 0x00C5D08B
		private EyeProtectItem CreateEyeProtectItem()
		{
			return new EyeProtectItem
			{
				SelectCallback = new Action<int>(this.SelectTagByIndex),
				CanExecuteChange = new Func<int, bool>(this.CanToggleChange)
			};
		}

		// Token: 0x0602C0EF RID: 180463 RVA: 0x00C5EEB8 File Offset: 0x00C5D0B8
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

		// Token: 0x0602C0F0 RID: 180464 RVA: 0x00C5EF2C File Offset: 0x00C5D12C
		private bool CanToggleChange(int gridIndex)
		{
			GenericLayout<EyeProtectItem, EyeProtectItemData> layoutItems = this.LayoutItems;
			int? num = (layoutItems != null) ? new int?(layoutItems.GetSelectedGridIndex()) : null;
			return !(gridIndex == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x0602C0F1 RID: 180465 RVA: 0x00C5EF6E File Offset: 0x00C5D16E
		private void OnResetClick(int _)
		{
			this.HandleResetClick();
		}

		// Token: 0x0602C0F2 RID: 180466 RVA: 0x00C5EF78 File Offset: 0x00C5D178
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

		// Token: 0x0602C0F3 RID: 180467 RVA: 0x00C5F0AC File Offset: 0x00C5D2AC
		private void OnConfirmClick(int _)
		{
			this.HandleConfirmClick();
		}

		// Token: 0x0602C0F4 RID: 180468 RVA: 0x00C5F0B4 File Offset: 0x00C5D2B4
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

		// Token: 0x0602C0F5 RID: 180469 RVA: 0x00C5F1CC File Offset: 0x00C5D3CC
		private void OnEyeToggleStateChange(EToggleState state)
		{
			base.GetItem(6).SetUIActive(state == EToggleState.ETT_Checked);
			base.GetItem(8).SetUIActive(state == EToggleState.ETT_Checked);
		}

		// Token: 0x0602C0F6 RID: 180470 RVA: 0x00C5F1F0 File Offset: 0x00C5D3F0
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

		// Token: 0x0602C0F7 RID: 180471 RVA: 0x00C5F247 File Offset: 0x00C5D447
		public void CloseMySelf()
		{
			FilterSettingController.Instance.CloseViewAndReturnWorld();
		}

		// Token: 0x0602C0F8 RID: 180472 RVA: 0x00C5F254 File Offset: 0x00C5D454
		private void OpenHelpView()
		{
			HelpController.Instance.OpenHelpById(390);
		}

		// Token: 0x0602C0F9 RID: 180473 RVA: 0x00C5F268 File Offset: 0x00C5D468
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

		// Token: 0x0602C0FA RID: 180474 RVA: 0x00C5F2AC File Offset: 0x00C5D4AC
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

		// Token: 0x0602C0FB RID: 180475 RVA: 0x00C5F2BF File Offset: 0x00C5D4BF
		private void OnDragBegin(ULGUIPointerEventData _)
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			vmCache.OnDragBegin();
		}

		// Token: 0x0602C0FC RID: 180476 RVA: 0x00C5F2D1 File Offset: 0x00C5D4D1
		private void OnDragEnded(ULGUIPointerEventData _)
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			vmCache.OnDragEnded();
		}

		// Token: 0x0602C0FD RID: 180477 RVA: 0x00C5F2E3 File Offset: 0x00C5D4E3
		private void OnInputUiLookUp(string axisName, float value, InputIdentification _)
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			vmCache.OnInputUiLookUp(axisName, value);
		}

		// Token: 0x0602C0FE RID: 180478 RVA: 0x00C5F2F7 File Offset: 0x00C5D4F7
		private void OnInputUiTurn(string axisName, float value, InputIdentification _)
		{
			EyeProtectViewModel vmCache = this.VmCache;
			if (vmCache == null)
			{
				return;
			}
			vmCache.OnInputUiTurn(axisName, value);
		}

		// Token: 0x04017BB7 RID: 97207
		[Nullable(2)]
		public EyeProtectViewModel VmCache;

		// Token: 0x04017BB8 RID: 97208
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04017BB9 RID: 97209
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<EyeProtectItem, EyeProtectItemData> LayoutItems;

		// Token: 0x04017BBA RID: 97210
		private List<EyeProtectItemData> ItemDataList = new List<EyeProtectItemData>();

		// Token: 0x04017BBB RID: 97211
		[Nullable(2)]
		private ButtonItem ResetBtnItem;

		// Token: 0x04017BBC RID: 97212
		[Nullable(2)]
		private ButtonItem ConfirmBtnItem;

		// Token: 0x0200A100 RID: 41216
		[NullableContext(0)]
		public class EComponent
		{
			// Token: 0x04032055 RID: 204885
			public const int CaptionItem = 0;

			// Token: 0x04032056 RID: 204886
			public const int Layout = 1;

			// Token: 0x04032057 RID: 204887
			public const int Item = 2;

			// Token: 0x04032058 RID: 204888
			public const int BtnReset = 3;

			// Token: 0x04032059 RID: 204889
			public const int BtnConfirm = 4;

			// Token: 0x0403205A RID: 204890
			public const int TogEye = 5;

			// Token: 0x0403205B RID: 204891
			public const int Parent = 6;

			// Token: 0x0403205C RID: 204892
			public const int ScreenDrag = 7;

			// Token: 0x0403205D RID: 204893
			public const int TexMask = 8;
		}
	}
}
