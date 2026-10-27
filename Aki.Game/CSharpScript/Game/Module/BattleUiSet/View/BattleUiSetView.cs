using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUiSet.View
{
	// Token: 0x02005E64 RID: 24164
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiSetView : UiTickViewBase
	{
		// Token: 0x0603D6D9 RID: 251609 RVA: 0x00ED133B File Offset: 0x00ECF53B
		public BattleUiSetView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603D6DA RID: 251610 RVA: 0x00ED1350 File Offset: 0x00ECF550
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISliderComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickedResetButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickedSaveButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickedCloseButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603D6DB RID: 251611 RVA: 0x00ED15AD File Offset: 0x00ECF7AD
		protected override void OnBeforeDestroy()
		{
			this.SelectedPanelItem = null;
			this.SelectedPanelItemSet.Clear();
			EditMobileBattleView editMobileBattleView = this.EditMobileBattleView;
			if (editMobileBattleView != null)
			{
				editMobileBattleView.Destroy(null);
			}
			this.EditMobileBattleView = null;
		}

		// Token: 0x0603D6DC RID: 251612 RVA: 0x00ED15DC File Offset: 0x00ECF7DC
		protected override void OnAddEventListener()
		{
			base.GetSlider(2).OnValueChangeCb.Bind(new Action<float>(this.OnSizeSliderValueChanged));
			base.GetSlider(1).OnValueChangeCb.Bind(new Action<float>(this.OnAlphaSliderValueChanged));
			UUIButtonComponent button = base.GetButton(3);
			button.OnPointDownCallBack.Bind(new Action(this.OnPressDownButton));
			button.OnPointCancelCallBack.Bind(new Action(this.OnReleaseDownButton));
			button.OnPointUpCallBack.Bind(new Action(this.OnReleaseDownButton));
			UUIButtonComponent button2 = base.GetButton(4);
			button2.OnPointDownCallBack.Bind(new Action(this.OnPressUpButton));
			button2.OnPointCancelCallBack.Bind(new Action(this.OnReleaseUpButton));
			button2.OnPointUpCallBack.Bind(new Action(this.OnReleaseUpButton));
			UUIButtonComponent button3 = base.GetButton(6);
			button3.OnPointDownCallBack.Bind(new Action(this.OnPressLeftButton));
			button3.OnPointCancelCallBack.Bind(new Action(this.OnReleaseLeftButton));
			button3.OnPointUpCallBack.Bind(new Action(this.OnReleaseLeftButton));
			UUIButtonComponent button4 = base.GetButton(5);
			button4.OnPointDownCallBack.Bind(new Action(this.OnPressRightButton));
			button4.OnPointCancelCallBack.Bind(new Action(this.OnReleaseRightButton));
			button4.OnPointUpCallBack.Bind(new Action(this.OnReleaseRightButton));
			UUIDraggableComponent draggable = base.GetDraggable(10);
			draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
			draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDrag));
			draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
			InputDistributeController.Instance.BindTouches(new int[]
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9
			}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
			EventSystem.Instance.Add(EEventName.OnSelectedEditPanelItem, new Action<BattleUiSetPanelItemData>(this.OnSelectedEditPanelItem));
		}

		// Token: 0x0603D6DD RID: 251613 RVA: 0x00ED17E0 File Offset: 0x00ECF9E0
		protected override void OnRemoveEventListener()
		{
			base.GetSlider(2).OnValueChangeCb.Unbind();
			base.GetSlider(1).OnValueChangeCb.Unbind();
			UUIButtonComponent button = base.GetButton(3);
			button.OnPointDownCallBack.Unbind();
			button.OnPointUpCallBack.Unbind();
			UUIButtonComponent button2 = base.GetButton(4);
			button2.OnPointDownCallBack.Unbind();
			button2.OnPointUpCallBack.Unbind();
			UUIButtonComponent button3 = base.GetButton(6);
			button3.OnPointDownCallBack.Unbind();
			button3.OnPointUpCallBack.Unbind();
			UUIButtonComponent button4 = base.GetButton(5);
			button4.OnPointDownCallBack.Unbind();
			button4.OnPointUpCallBack.Unbind();
			UUIDraggableComponent draggable = base.GetDraggable(10);
			draggable.OnPointerBeginDragCallBack.Unbind();
			draggable.OnPointerDragCallBack.Unbind();
			draggable.OnPointerEndDragCallBack.Unbind();
			InputDistributeController.Instance.UnBindTouches(new <>z__ReadOnlyArray<int>(new int[]
			{
				0,
				1,
				2,
				3,
				4,
				5,
				6,
				7,
				8,
				9
			}), new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
			EventSystem.Instance.Remove(EEventName.OnSelectedEditPanelItem, new Action<BattleUiSetPanelItemData>(this.OnSelectedEditPanelItem));
		}

		// Token: 0x0603D6DE RID: 251614 RVA: 0x00ED18F0 File Offset: 0x00ECFAF0
		public void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification inputIdentification)
		{
			InputDistributeDefine.ETouchType touchType = touchData.TouchType;
			int touchId = int.Parse(touchIdName);
			switch (touchType)
			{
			case InputDistributeDefine.ETouchType.TouchBegin:
				this.TouchTrigger(true, touchId);
				return;
			case InputDistributeDefine.ETouchType.TouchEnd:
				this.TouchTrigger(false, touchId);
				return;
			case InputDistributeDefine.ETouchType.TouchMove:
				this.TouchMoved(touchId);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603D6DF RID: 251615 RVA: 0x00ED1938 File Offset: 0x00ECFB38
		private void TouchTrigger(bool bTouchPress, int touchId)
		{
			TouchFingerData touchFingerData = TouchFingerManager.Instance.GetTouchFingerData((EFingerIndex)touchId);
			if (touchFingerData == null)
			{
				return;
			}
			if (bTouchPress)
			{
				BattleUiSetModel.Instance.AddTouchFingerData(touchFingerData);
				return;
			}
			BattleUiSetModel.Instance.RemoveTouchFingerData(touchFingerData);
		}

		// Token: 0x0603D6E0 RID: 251616 RVA: 0x00ED1970 File Offset: 0x00ECFB70
		private void TouchMoved(int touchId)
		{
			BattleUiSetModel instance = BattleUiSetModel.Instance;
			BattleUiSetPanelItemData selectedPanelItemData = instance.SelectedPanelItemData;
			if (selectedPanelItemData == null)
			{
				return;
			}
			if (instance.GetTouchFingerDataCount() < 2)
			{
				return;
			}
			TouchFingerData touchFingerData = instance.GetTouchFingerData(EFingerIndex.One);
			TouchFingerData touchFingerData2 = instance.GetTouchFingerData(EFingerIndex.Two);
			EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
			EFingerIndex fingerIndex2 = touchFingerData2.GetFingerIndex();
			float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(fingerIndex, fingerIndex2);
			float num = MathUtils.Instance.RangeClamp(fingerExpandCloseValue, instance.MinTouchMoveDifference, instance.MaxTouchMoveDifference, instance.MinTouchMoveValue, instance.MaxTouchMoveValue);
			float x = selectedPanelItemData.EditSize + num * instance.ControlScaleRate;
			UUISliderComponent slider = base.GetSlider(2);
			float minValue = slider.MinValue;
			float maxValue = slider.MaxValue;
			float num2 = MathCommon.Clamp(x, minValue, maxValue);
			this.RefreshSelectedPanelItemScale(num2);
			slider.SetValue(num2, true);
		}

		// Token: 0x0603D6E1 RID: 251617 RVA: 0x00ED1A30 File Offset: 0x00ECFC30
		protected override void OnTick(float delta)
		{
			base.OnTick(delta);
			if (this.Direction == BattleUiSetView.EDirection.None)
			{
				return;
			}
			BattleUiSetPanelItemData selectedPanelItemData = BattleUiSetModel.Instance.SelectedPanelItemData;
			if (selectedPanelItemData == null)
			{
				return;
			}
			if (!selectedPanelItemData.CanEdit)
			{
				return;
			}
			EditMobileBattleViewPanelItem panelItem = this.EditMobileBattleView.GetPanelItem(selectedPanelItemData);
			if (panelItem == null)
			{
				return;
			}
			FVectorDouble relativeLocation = panelItem.GetRelativeLocation();
			switch (this.Direction)
			{
			case BattleUiSetView.EDirection.Up:
				relativeLocation.Y += 1.0;
				panelItem.SetRelativeLocation(relativeLocation);
				return;
			case BattleUiSetView.EDirection.Down:
				relativeLocation.Y -= 1.0;
				panelItem.SetRelativeLocation(relativeLocation);
				return;
			case BattleUiSetView.EDirection.Left:
				relativeLocation.X -= 1.0;
				panelItem.SetRelativeLocation(relativeLocation);
				return;
			case BattleUiSetView.EDirection.Right:
				relativeLocation.X += 1.0;
				panelItem.SetRelativeLocation(relativeLocation);
				return;
			default:
				return;
			}
		}

		// Token: 0x0603D6E2 RID: 251618 RVA: 0x00ED1B10 File Offset: 0x00ECFD10
		private void OnPressDownButton()
		{
			this.Direction = BattleUiSetView.EDirection.Down;
		}

		// Token: 0x0603D6E3 RID: 251619 RVA: 0x00ED1B19 File Offset: 0x00ECFD19
		private void OnReleaseDownButton()
		{
			this.Direction = BattleUiSetView.EDirection.None;
		}

		// Token: 0x0603D6E4 RID: 251620 RVA: 0x00ED1B22 File Offset: 0x00ECFD22
		private void OnPressUpButton()
		{
			this.Direction = BattleUiSetView.EDirection.Up;
		}

		// Token: 0x0603D6E5 RID: 251621 RVA: 0x00ED1B2B File Offset: 0x00ECFD2B
		private void OnReleaseUpButton()
		{
			this.Direction = BattleUiSetView.EDirection.None;
		}

		// Token: 0x0603D6E6 RID: 251622 RVA: 0x00ED1B34 File Offset: 0x00ECFD34
		private void OnPressLeftButton()
		{
			this.Direction = BattleUiSetView.EDirection.Left;
		}

		// Token: 0x0603D6E7 RID: 251623 RVA: 0x00ED1B3D File Offset: 0x00ECFD3D
		private void OnReleaseLeftButton()
		{
			this.Direction = BattleUiSetView.EDirection.None;
		}

		// Token: 0x0603D6E8 RID: 251624 RVA: 0x00ED1B46 File Offset: 0x00ECFD46
		private void OnPressRightButton()
		{
			this.Direction = BattleUiSetView.EDirection.Right;
		}

		// Token: 0x0603D6E9 RID: 251625 RVA: 0x00ED1B4F File Offset: 0x00ECFD4F
		private void OnReleaseRightButton()
		{
			this.Direction = BattleUiSetView.EDirection.None;
		}

		// Token: 0x0603D6EA RID: 251626 RVA: 0x00ED1B58 File Offset: 0x00ECFD58
		public void ClampBound(ref FVector relativeLocation)
		{
			UUIItem item = base.GetItem(11);
			float num = (float)item.GetOwner().D_GetActorScale3D().X;
			FVector2D pivot = item.GetPivot();
			float y = pivot.Y;
			float x = pivot.X;
			UUIItem uiitem = (this.RootItem.GetRenderCanvas().GetOwner() as AUIBaseActor).GetUIItem();
			float width = uiitem.Width;
			float height = uiitem.Height;
			float num2 = width * 0.5f;
			float num3 = height * 0.5f;
			float num4 = item.Width * num;
			float num5 = item.Height * num;
			relativeLocation.X = MathCommon.Clamp(relativeLocation.X, -num2 + num4 * x, num2 - num4 * (1f - x));
			relativeLocation.Y = MathCommon.Clamp(relativeLocation.Y, -num3 + num5 * y, num3 - num5 * (1f - y));
		}

		// Token: 0x0603D6EB RID: 251627 RVA: 0x00ED1C28 File Offset: 0x00ECFE28
		public void SetRelativeLocation(FVector relativeLocation)
		{
			UUIItem item = base.GetItem(11);
			this.ClampBound(ref relativeLocation);
			item.SetUIRelativeLocation(relativeLocation);
		}

		// Token: 0x0603D6EC RID: 251628 RVA: 0x00ED1C40 File Offset: 0x00ECFE40
		[NullableContext(2)]
		private void OnDrag(ULGUIPointerEventData eventData)
		{
			FVector localPointInPlane = eventData.GetLocalPointInPlane();
			string displayName = (eventData.dragComponent.GetOwner() as AUIBaseActor).GetUIItem().GetDisplayName();
			UUIItem item = base.GetItem(11);
			if (displayName != item.GetDisplayName())
			{
				return;
			}
			if (this.LocalOffsetVector != null)
			{
				FVectorDouble fvectorDouble = (eventData.dragComponent.GetOwner() as AUIBaseActor).D_GetActorScale3D();
				float num = localPointInPlane.X - this.LocalOffsetVector.Value.X;
				float num2 = localPointInPlane.Y - this.LocalOffsetVector.Value.Y;
				if (num == 0f || num2 == 0f)
				{
					return;
				}
				this.ResultLocation.X = this.ResultLocation.X + num * (float)fvectorDouble.X;
				this.ResultLocation.Y = this.ResultLocation.Y + num2 * (float)fvectorDouble.Y;
				this.SetRelativeLocation(this.ResultLocation);
			}
			this.LocalOffsetVector = new FVector?(localPointInPlane);
		}

		// Token: 0x0603D6ED RID: 251629 RVA: 0x00ED1D37 File Offset: 0x00ECFF37
		[NullableContext(2)]
		private void OnDragBegin(ULGUIPointerEventData ulguiPointerEventData)
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x0603D6EE RID: 251630 RVA: 0x00ED1D45 File Offset: 0x00ECFF45
		[NullableContext(2)]
		private void OnDragEnded(ULGUIPointerEventData ulguiPointerEventData)
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x0603D6EF RID: 251631 RVA: 0x00ED1D54 File Offset: 0x00ECFF54
		private void OnSelectedEditPanelItem(BattleUiSetPanelItemData panelItemData)
		{
			EditMobileBattleViewPanelItem selectedPanelItem = this.SelectedPanelItem;
			if (selectedPanelItem != null)
			{
				selectedPanelItem.SetSelected(false);
			}
			EditMobileBattleViewPanel panel = this.EditMobileBattleView.GetPanel(panelItemData.PanelIndex);
			EditMobileBattleViewPanelItem editMobileBattleViewPanelItem = (panel != null) ? panel.GetPanelItem(panelItemData.PanelItemIndex) : null;
			this.SelectedPanelItem = editMobileBattleViewPanelItem;
			if (editMobileBattleViewPanelItem != null)
			{
				editMobileBattleViewPanelItem.SetSelected(true);
				this.RefreshSetting(panelItemData);
				this.SetSelectedPanelItem(editMobileBattleViewPanelItem);
				this.SelectedPanelItemSet.Add(editMobileBattleViewPanelItem);
				bool flag;
				if (panel == null)
				{
					flag = true;
				}
				else
				{
					BattleUiSetPanelData panelData = panel.PanelData;
					flag = !((panelData != null) ? new bool?(panelData.IsOnlyPanelEdit) : null).GetValueOrDefault();
				}
				if (flag)
				{
					editMobileBattleViewPanelItem.ApplyTopIndex();
				}
			}
			this.EditMobileBattleView.RefreshHierarchyIndex();
		}

		// Token: 0x0603D6F0 RID: 251632 RVA: 0x00ED1E08 File Offset: 0x00ED0008
		private void SetSelectedPanelItem(EditMobileBattleViewPanelItem panelItem)
		{
			UUIItem rootItem = panelItem.GetRootItem();
			UUIItem item = base.GetItem(12);
			item.GetOwner().K2_AttachToActor(rootItem.GetOwner(), null, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
			item.SetAnchorAlign(UIAnchorHorizontalAlign.Stretch, UIAnchorVerticalAlign.Stretch);
			item.SetStretchLeft(0f);
			item.SetStretchRight(0f);
			item.SetStretchTop(0f);
			item.SetStretchBottom(0f);
			item.SetUIActive(true);
		}

		// Token: 0x0603D6F1 RID: 251633 RVA: 0x00ED1E7A File Offset: 0x00ED007A
		private void OnSizeSliderValueChanged(float value)
		{
			this.RefreshSelectedPanelItemScale(value);
		}

		// Token: 0x0603D6F2 RID: 251634 RVA: 0x00ED1E84 File Offset: 0x00ED0084
		private void RefreshSelectedPanelItemScale(float value)
		{
			BattleUiSetPanelItemData selectedPanelItemData = BattleUiSetModel.Instance.SelectedPanelItemData;
			if (this.SelectedPanelItem == null || selectedPanelItemData == null)
			{
				return;
			}
			if (!selectedPanelItemData.CanEdit)
			{
				return;
			}
			selectedPanelItemData.EditSize = value;
			this.SelectedPanelItem.GetRootItem().SetUIItemScale(new FVector(value));
			this.SelectedPanelItem.RefreshRelativeLocation();
		}

		// Token: 0x0603D6F3 RID: 251635 RVA: 0x00ED1EDC File Offset: 0x00ED00DC
		private void OnAlphaSliderValueChanged(float value)
		{
			BattleUiSetPanelItemData selectedPanelItemData = BattleUiSetModel.Instance.SelectedPanelItemData;
			if (this.SelectedPanelItem == null || selectedPanelItemData == null)
			{
				return;
			}
			if (!selectedPanelItemData.CanEdit)
			{
				return;
			}
			selectedPanelItemData.EditAlpha = value;
			this.SelectedPanelItem.GetRootItem().SetUIItemAlpha(value);
		}

		// Token: 0x0603D6F4 RID: 251636 RVA: 0x00ED1F21 File Offset: 0x00ED0121
		protected override void OnStart()
		{
			this.ResultLocation = base.GetItem(11).RelativeLocation;
			this.EditMobileBattleView = new EditMobileBattleView(base.GetItem(0));
		}

		// Token: 0x0603D6F5 RID: 251637 RVA: 0x00ED1F48 File Offset: 0x00ED0148
		private void OnClickedResetButton()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ButtonReset);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.EditMobileBattleView.ResetAllPanelItem();
				BattleUiSetModel instance = BattleUiSetModel.Instance;
				this.ResetSetting(instance.SelectedPanelItemData);
				instance.ResetSettings();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603D6F6 RID: 251638 RVA: 0x00ED1F84 File Offset: 0x00ED0184
		private void OnClickedSaveButton()
		{
			foreach (EditMobileBattleViewPanelItem editMobileBattleViewPanelItem in this.SelectedPanelItemSet)
			{
				BattleUiSetPanelItemData panelItemData = editMobileBattleViewPanelItem.PanelItemData;
				if (panelItemData == null || panelItemData.IsCheckOverlap)
				{
					UUIItem rootItem = editMobileBattleViewPanelItem.GetRootItem();
					if (this.EditMobileBattleView.IsAnyItemOverlap(rootItem))
					{
						ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.CheckOverlap);
						confirmBoxDataNew.FunctionMap[2] = delegate()
						{
							this.EditMobileBattleView.SavePanelItem();
							BattleUiSetModel.Instance.SaveSettings();
							UiManager.Instance.CloseView(EUiViewName.BattleUiSetView, null);
						};
						ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
						return;
					}
				}
			}
			this.EditMobileBattleView.SavePanelItem();
			BattleUiSetModel.Instance.SaveSettings();
			UiManager.Instance.CloseView(EUiViewName.BattleUiSetView, null);
		}

		// Token: 0x0603D6F7 RID: 251639 RVA: 0x00ED2050 File Offset: 0x00ED0250
		private void OnClickedCloseButton()
		{
			if (this.IsEdited())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ButtonNotSave);
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					BattleUiSetModel.Instance.ReInitSettings();
					UiManager.Instance.CloseView(EUiViewName.BattleUiSetView, null);
				};
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					BattleUiSetModel.Instance.SaveSettings();
					UiManager.Instance.CloseView(EUiViewName.BattleUiSetView, null);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			BattleUiSetModel.Instance.ReInitSettings();
			UiManager.Instance.CloseView(EUiViewName.BattleUiSetView, null);
		}

		// Token: 0x0603D6F8 RID: 251640 RVA: 0x00ED20EC File Offset: 0x00ED02EC
		private bool IsEdited()
		{
			using (IEnumerator<BattleUiSetPanelItemData> enumerator = BattleUiSetModel.Instance.GetPanelItemDataMap().Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsEdited())
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0603D6F9 RID: 251641 RVA: 0x00ED2148 File Offset: 0x00ED0348
		private void RefreshSetting(BattleUiSetPanelItemData panelItemData)
		{
			UUISliderComponent slider = base.GetSlider(2);
			UUISliderComponent slider2 = base.GetSlider(1);
			slider.SetValue(panelItemData.EditSize, true);
			slider2.SetValue(panelItemData.EditAlpha, true);
		}

		// Token: 0x0603D6FA RID: 251642 RVA: 0x00ED2180 File Offset: 0x00ED0380
		[NullableContext(2)]
		private void ResetSetting(BattleUiSetPanelItemData panelItemData)
		{
			if (panelItemData == null)
			{
				return;
			}
			UUISliderComponent slider = base.GetSlider(2);
			UUISliderComponent slider2 = base.GetSlider(1);
			slider.SetValue(panelItemData.SourceSize, true);
			slider2.SetValue(panelItemData.SourceAlpha, true);
		}

		// Token: 0x040200F3 RID: 131315
		[Nullable(2)]
		private EditMobileBattleView EditMobileBattleView;

		// Token: 0x040200F4 RID: 131316
		[Nullable(2)]
		public EditMobileBattleViewPanelItem SelectedPanelItem;

		// Token: 0x040200F5 RID: 131317
		private readonly HashSet<EditMobileBattleViewPanelItem> SelectedPanelItemSet = new HashSet<EditMobileBattleViewPanelItem>();

		// Token: 0x040200F6 RID: 131318
		private BattleUiSetView.EDirection Direction;

		// Token: 0x040200F7 RID: 131319
		private FVector? LocalOffsetVector;

		// Token: 0x040200F8 RID: 131320
		private FVector ResultLocation;

		// Token: 0x0200C1D4 RID: 49620
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403A939 RID: 239929
			BattleViewItem,
			// Token: 0x0403A93A RID: 239930
			AlphaSlider,
			// Token: 0x0403A93B RID: 239931
			SizeSlider,
			// Token: 0x0403A93C RID: 239932
			DownButton,
			// Token: 0x0403A93D RID: 239933
			UpButton,
			// Token: 0x0403A93E RID: 239934
			RightButton,
			// Token: 0x0403A93F RID: 239935
			LeftButton,
			// Token: 0x0403A940 RID: 239936
			ResetButton,
			// Token: 0x0403A941 RID: 239937
			SaveButton,
			// Token: 0x0403A942 RID: 239938
			CloseButton,
			// Token: 0x0403A943 RID: 239939
			DraggableComponent,
			// Token: 0x0403A944 RID: 239940
			SettingItem,
			// Token: 0x0403A945 RID: 239941
			SelectedItem
		}

		// Token: 0x0200C1D5 RID: 49621
		[NullableContext(0)]
		private enum EDirection
		{
			// Token: 0x0403A947 RID: 239943
			None,
			// Token: 0x0403A948 RID: 239944
			Up,
			// Token: 0x0403A949 RID: 239945
			Down,
			// Token: 0x0403A94A RID: 239946
			Left,
			// Token: 0x0403A94B RID: 239947
			Right
		}
	}
}
