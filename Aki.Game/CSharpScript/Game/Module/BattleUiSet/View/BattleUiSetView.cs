using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUiSet.View
{
	// Token: 0x02004E49 RID: 20041
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleUiSetView : UiTickViewBase
	{
		// Token: 0x06032669 RID: 206441 RVA: 0x00E228AB File Offset: 0x00E20AAB
		public BattleUiSetView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603266A RID: 206442 RVA: 0x00E228C0 File Offset: 0x00E20AC0
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

		// Token: 0x0603266B RID: 206443 RVA: 0x00E22B1D File Offset: 0x00E20D1D
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

		// Token: 0x0603266C RID: 206444 RVA: 0x00E22B4C File Offset: 0x00E20D4C
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

		// Token: 0x0603266D RID: 206445 RVA: 0x00E22D50 File Offset: 0x00E20F50
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

		// Token: 0x0603266E RID: 206446 RVA: 0x00E22E60 File Offset: 0x00E21060
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

		// Token: 0x0603266F RID: 206447 RVA: 0x00E22EA8 File Offset: 0x00E210A8
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

		// Token: 0x06032670 RID: 206448 RVA: 0x00E22EE0 File Offset: 0x00E210E0
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

		// Token: 0x06032671 RID: 206449 RVA: 0x00E22FA0 File Offset: 0x00E211A0
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

		// Token: 0x06032672 RID: 206450 RVA: 0x00E23080 File Offset: 0x00E21280
		private void OnPressDownButton()
		{
			this.Direction = BattleUiSetView.EDirection.Down;
		}

		// Token: 0x06032673 RID: 206451 RVA: 0x00E23089 File Offset: 0x00E21289
		private void OnReleaseDownButton()
		{
			this.Direction = BattleUiSetView.EDirection.None;
		}

		// Token: 0x06032674 RID: 206452 RVA: 0x00E23092 File Offset: 0x00E21292
		private void OnPressUpButton()
		{
			this.Direction = BattleUiSetView.EDirection.Up;
		}

		// Token: 0x06032675 RID: 206453 RVA: 0x00E2309B File Offset: 0x00E2129B
		private void OnReleaseUpButton()
		{
			this.Direction = BattleUiSetView.EDirection.None;
		}

		// Token: 0x06032676 RID: 206454 RVA: 0x00E230A4 File Offset: 0x00E212A4
		private void OnPressLeftButton()
		{
			this.Direction = BattleUiSetView.EDirection.Left;
		}

		// Token: 0x06032677 RID: 206455 RVA: 0x00E230AD File Offset: 0x00E212AD
		private void OnReleaseLeftButton()
		{
			this.Direction = BattleUiSetView.EDirection.None;
		}

		// Token: 0x06032678 RID: 206456 RVA: 0x00E230B6 File Offset: 0x00E212B6
		private void OnPressRightButton()
		{
			this.Direction = BattleUiSetView.EDirection.Right;
		}

		// Token: 0x06032679 RID: 206457 RVA: 0x00E230BF File Offset: 0x00E212BF
		private void OnReleaseRightButton()
		{
			this.Direction = BattleUiSetView.EDirection.None;
		}

		// Token: 0x0603267A RID: 206458 RVA: 0x00E230C8 File Offset: 0x00E212C8
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

		// Token: 0x0603267B RID: 206459 RVA: 0x00E23198 File Offset: 0x00E21398
		public void SetRelativeLocation(FVector relativeLocation)
		{
			UUIItem item = base.GetItem(11);
			this.ClampBound(ref relativeLocation);
			item.SetUIRelativeLocation(relativeLocation);
		}

		// Token: 0x0603267C RID: 206460 RVA: 0x00E231B0 File Offset: 0x00E213B0
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

		// Token: 0x0603267D RID: 206461 RVA: 0x00E232A7 File Offset: 0x00E214A7
		[NullableContext(2)]
		private void OnDragBegin(ULGUIPointerEventData ulguiPointerEventData)
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x0603267E RID: 206462 RVA: 0x00E232B5 File Offset: 0x00E214B5
		[NullableContext(2)]
		private void OnDragEnded(ULGUIPointerEventData ulguiPointerEventData)
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x0603267F RID: 206463 RVA: 0x00E232C4 File Offset: 0x00E214C4
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

		// Token: 0x06032680 RID: 206464 RVA: 0x00E23378 File Offset: 0x00E21578
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

		// Token: 0x06032681 RID: 206465 RVA: 0x00E233EA File Offset: 0x00E215EA
		private void OnSizeSliderValueChanged(float value)
		{
			this.RefreshSelectedPanelItemScale(value);
		}

		// Token: 0x06032682 RID: 206466 RVA: 0x00E233F4 File Offset: 0x00E215F4
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

		// Token: 0x06032683 RID: 206467 RVA: 0x00E2344C File Offset: 0x00E2164C
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

		// Token: 0x06032684 RID: 206468 RVA: 0x00E23491 File Offset: 0x00E21691
		protected override void OnStart()
		{
			this.ResultLocation = base.GetItem(11).RelativeLocation;
			this.EditMobileBattleView = new EditMobileBattleView(base.GetItem(0));
		}

		// Token: 0x06032685 RID: 206469 RVA: 0x00E234B8 File Offset: 0x00E216B8
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

		// Token: 0x06032686 RID: 206470 RVA: 0x00E234F4 File Offset: 0x00E216F4
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

		// Token: 0x06032687 RID: 206471 RVA: 0x00E235C0 File Offset: 0x00E217C0
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

		// Token: 0x06032688 RID: 206472 RVA: 0x00E2365C File Offset: 0x00E2185C
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

		// Token: 0x06032689 RID: 206473 RVA: 0x00E236B8 File Offset: 0x00E218B8
		private void RefreshSetting(BattleUiSetPanelItemData panelItemData)
		{
			UUISliderComponent slider = base.GetSlider(2);
			UUISliderComponent slider2 = base.GetSlider(1);
			slider.SetValue(panelItemData.EditSize, true);
			slider2.SetValue(panelItemData.EditAlpha, true);
		}

		// Token: 0x0603268A RID: 206474 RVA: 0x00E236F0 File Offset: 0x00E218F0
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

		// Token: 0x0401ABBA RID: 109498
		[Nullable(2)]
		private EditMobileBattleView EditMobileBattleView;

		// Token: 0x0401ABBB RID: 109499
		[Nullable(2)]
		public EditMobileBattleViewPanelItem SelectedPanelItem;

		// Token: 0x0401ABBC RID: 109500
		private readonly HashSet<EditMobileBattleViewPanelItem> SelectedPanelItemSet = new HashSet<EditMobileBattleViewPanelItem>();

		// Token: 0x0401ABBD RID: 109501
		private BattleUiSetView.EDirection Direction;

		// Token: 0x0401ABBE RID: 109502
		private FVector? LocalOffsetVector;

		// Token: 0x0401ABBF RID: 109503
		private FVector ResultLocation;

		// Token: 0x0200ABE3 RID: 44003
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403532B RID: 217899
			BattleViewItem,
			// Token: 0x0403532C RID: 217900
			AlphaSlider,
			// Token: 0x0403532D RID: 217901
			SizeSlider,
			// Token: 0x0403532E RID: 217902
			DownButton,
			// Token: 0x0403532F RID: 217903
			UpButton,
			// Token: 0x04035330 RID: 217904
			RightButton,
			// Token: 0x04035331 RID: 217905
			LeftButton,
			// Token: 0x04035332 RID: 217906
			ResetButton,
			// Token: 0x04035333 RID: 217907
			SaveButton,
			// Token: 0x04035334 RID: 217908
			CloseButton,
			// Token: 0x04035335 RID: 217909
			DraggableComponent,
			// Token: 0x04035336 RID: 217910
			SettingItem,
			// Token: 0x04035337 RID: 217911
			SelectedItem
		}

		// Token: 0x0200ABE4 RID: 44004
		[NullableContext(0)]
		private enum EDirection
		{
			// Token: 0x04035339 RID: 217913
			None,
			// Token: 0x0403533A RID: 217914
			Up,
			// Token: 0x0403533B RID: 217915
			Down,
			// Token: 0x0403533C RID: 217916
			Left,
			// Token: 0x0403533D RID: 217917
			Right
		}
	}
}
