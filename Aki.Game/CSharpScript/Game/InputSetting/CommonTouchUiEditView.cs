using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Menu;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006194 RID: 24980
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonTouchUiEditView : UiTickViewBase, ITouchUiEditView
	{
		// Token: 0x0603BECB RID: 245451 RVA: 0x0110726F File Offset: 0x0110546F
		[NullableContext(1)]
		public CommonTouchUiEditView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603BECC RID: 245452 RVA: 0x01107278 File Offset: 0x01105478
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(2, typeof(UUISliderComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(10, typeof(UUIDraggableComponent)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickedResetButton)),
				new ValueTuple<int, Delegate>(8, new Action(this.OnClickedSaveButton)),
				new ValueTuple<int, Delegate>(9, new Action(this.OnClickedCloseButton))
			};
		}

		// Token: 0x0603BECD RID: 245453 RVA: 0x01107408 File Offset: 0x01105608
		protected TouchUiEditProxy GetEditProxyFromOpenParam(object openParam)
		{
			if (openParam == null)
			{
				Log.Instance.Error(ELogModule.TouchUiEdit, ELogAuthor.HYF, "打开CommonTouchUiEditView时未指定OpenParam", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			if (openParam is TouchUiEditProxy)
			{
				return openParam as TouchUiEditProxy;
			}
			object[] array = openParam as object[];
			if (array != null && array.Length != 0)
			{
				MenuData menuData = array[0] as MenuData;
				if (menuData != null)
				{
					return TouchUiEditController.Instance.CreateProxyForFunction(menuData.FunctionId);
				}
			}
			return null;
		}

		// Token: 0x0603BECE RID: 245454 RVA: 0x01107474 File Offset: 0x01105674
		protected override UniTask OnBeforeStartAsync()
		{
			CommonTouchUiEditView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonTouchUiEditView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603BECF RID: 245455 RVA: 0x011074B7 File Offset: 0x011056B7
		protected override void OnStart()
		{
			this.ResultLocation = base.GetItem(11).RelativeLocation;
			this.EditProxy.OnStart();
			base.GetItem(12).SetUIActive(false);
		}

		// Token: 0x0603BED0 RID: 245456 RVA: 0x011074E5 File Offset: 0x011056E5
		protected override void OnTick(float delta)
		{
			this.EditProxy.OnTick(delta);
		}

		// Token: 0x0603BED1 RID: 245457 RVA: 0x011074F4 File Offset: 0x011056F4
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
			TouchUiEditViewModel.AddDelegateOnSelectedItemChange(new Action<ITouchUiEditItem>(this.OnSelectedItemChange));
			ITouchUiEditItem currentSelectedItem = TouchUiEditViewModel.GetCurrentSelectedItem();
			if (currentSelectedItem != null)
			{
				TouchUiEditViewModel.NotifySelectedItemChange(currentSelectedItem);
			}
		}

		// Token: 0x0603BED2 RID: 245458 RVA: 0x011076D4 File Offset: 0x011058D4
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
			TouchUiEditViewModel.RemoveDelegateOnSelectedItemChange(new Action<ITouchUiEditItem>(this.OnSelectedItemChange));
		}

		// Token: 0x0603BED3 RID: 245459 RVA: 0x011077AC File Offset: 0x011059AC
		protected override void OnBeforeDestroy()
		{
			this.EditProxy.OnBeforeDestroy();
		}

		// Token: 0x0603BED4 RID: 245460 RVA: 0x011077B9 File Offset: 0x011059B9
		[NullableContext(1)]
		public UUIItem GetAttachRoot()
		{
			return base.GetItem(0);
		}

		// Token: 0x0603BED5 RID: 245461 RVA: 0x011077C2 File Offset: 0x011059C2
		public UUISliderComponent GetScaleSlider()
		{
			return base.GetSlider(2);
		}

		// Token: 0x0603BED6 RID: 245462 RVA: 0x011077CC File Offset: 0x011059CC
		private void ClampBound(FVector relativeLocation)
		{
			UUIItem item = base.GetItem(11);
			float num = (float)item.GetOwner().D_GetActorScale3D().X;
			FVector2D pivot = item.GetPivot();
			float y = pivot.Y;
			float x = pivot.X;
			UUIItem uiitem = (this.RootItem.GetRenderCanvas().GetOwner() as AUIBaseActor).GetUIItem();
			float width = uiitem.Width;
			float height = uiitem.Height;
			float num2 = width / 2f;
			float num3 = height / 2f;
			float num4 = item.Width * num;
			float num5 = item.Height * num;
			relativeLocation.X = MathUtils.Instance.Clamp(relativeLocation.X, -num2 + num4 * x, num2 - num4 * (1f - x));
			relativeLocation.Y = MathUtils.Instance.Clamp(relativeLocation.Y, -num3 + num5 * y, num3 - num5 * (1f - y));
		}

		// Token: 0x0603BED7 RID: 245463 RVA: 0x011078A8 File Offset: 0x01105AA8
		private void SetRelativeLocation(FVector relativeLocation)
		{
			UUIItem item = base.GetItem(11);
			this.ClampBound(relativeLocation);
			item.SetUIRelativeLocation(relativeLocation);
		}

		// Token: 0x0603BED8 RID: 245464 RVA: 0x011078C0 File Offset: 0x01105AC0
		private void OnClickedResetButton()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ButtonReset);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.EditProxy.Reset();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x0603BED9 RID: 245465 RVA: 0x011078F9 File Offset: 0x01105AF9
		private void OnClickedSaveButton()
		{
			this.EditProxy.Save(true);
		}

		// Token: 0x0603BEDA RID: 245466 RVA: 0x01107908 File Offset: 0x01105B08
		private void OnClickedCloseButton()
		{
			if (this.EditProxy.IsEdited())
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ButtonNotSave);
				confirmBoxDataNew.FunctionMap[1] = delegate()
				{
					this.EditProxy.ResetEditData();
					base.CloseMe(null);
				};
				confirmBoxDataNew.FunctionMap[2] = delegate()
				{
					this.EditProxy.Save(false);
					base.CloseMe(null);
				};
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			this.EditProxy.ResetEditData();
			base.CloseMe(null);
		}

		// Token: 0x0603BEDB RID: 245467 RVA: 0x01107979 File Offset: 0x01105B79
		private void OnSizeSliderValueChanged(float value)
		{
			this.EditProxy.SetScale(value);
		}

		// Token: 0x0603BEDC RID: 245468 RVA: 0x01107987 File Offset: 0x01105B87
		private void OnAlphaSliderValueChanged(float value)
		{
			this.EditProxy.SetAlpha(value);
		}

		// Token: 0x0603BEDD RID: 245469 RVA: 0x01107995 File Offset: 0x01105B95
		private void OnPressDownButton()
		{
			this.EditProxy.SetOffsetDeltaY(-1);
		}

		// Token: 0x0603BEDE RID: 245470 RVA: 0x011079A3 File Offset: 0x01105BA3
		private void OnReleaseDownButton()
		{
			this.EditProxy.SetOffsetDeltaY(0);
		}

		// Token: 0x0603BEDF RID: 245471 RVA: 0x011079B1 File Offset: 0x01105BB1
		private void OnPressUpButton()
		{
			this.EditProxy.SetOffsetDeltaY(1);
		}

		// Token: 0x0603BEE0 RID: 245472 RVA: 0x011079BF File Offset: 0x01105BBF
		private void OnReleaseUpButton()
		{
			this.EditProxy.SetOffsetDeltaY(0);
		}

		// Token: 0x0603BEE1 RID: 245473 RVA: 0x011079CD File Offset: 0x01105BCD
		private void OnPressLeftButton()
		{
			this.EditProxy.SetOffsetDeltaX(-1);
		}

		// Token: 0x0603BEE2 RID: 245474 RVA: 0x011079DB File Offset: 0x01105BDB
		private void OnReleaseLeftButton()
		{
			this.EditProxy.SetOffsetDeltaX(0);
		}

		// Token: 0x0603BEE3 RID: 245475 RVA: 0x011079E9 File Offset: 0x01105BE9
		private void OnPressRightButton()
		{
			this.EditProxy.SetOffsetDeltaX(1);
		}

		// Token: 0x0603BEE4 RID: 245476 RVA: 0x011079F7 File Offset: 0x01105BF7
		private void OnReleaseRightButton()
		{
			this.EditProxy.SetOffsetDeltaX(0);
		}

		// Token: 0x0603BEE5 RID: 245477 RVA: 0x01107A08 File Offset: 0x01105C08
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
				FVector fvector = fvectorDouble;
				float num = localPointInPlane.X - this.LocalOffsetVector.Value.X;
				float num2 = localPointInPlane.Y - this.LocalOffsetVector.Value.Y;
				if (num == 0f || num2 == 0f)
				{
					return;
				}
				this.ResultLocation.X = this.ResultLocation.X + num * fvector.X;
				this.ResultLocation.Y = this.ResultLocation.Y + num2 * fvector.Y;
				this.SetRelativeLocation(this.ResultLocation);
			}
			this.LocalOffsetVector = new FVector?(localPointInPlane);
		}

		// Token: 0x0603BEE6 RID: 245478 RVA: 0x01107B06 File Offset: 0x01105D06
		private void OnDragBegin()
		{
			this.OnDragBegin(null);
		}

		// Token: 0x0603BEE7 RID: 245479 RVA: 0x01107B0F File Offset: 0x01105D0F
		private void OnDragBegin(ULGUIPointerEventData eventData)
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x0603BEE8 RID: 245480 RVA: 0x01107B1D File Offset: 0x01105D1D
		private void OnDragEnded()
		{
			this.OnDragEnded(null);
		}

		// Token: 0x0603BEE9 RID: 245481 RVA: 0x01107B26 File Offset: 0x01105D26
		private void OnDragEnded(ULGUIPointerEventData eventData)
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x0603BEEA RID: 245482 RVA: 0x01107B34 File Offset: 0x01105D34
		[NullableContext(1)]
		private void OnSelectedItemChange(ITouchUiEditItem item)
		{
			base.GetSlider(2).SetValue(item.Data.Scale, true);
			base.GetSlider(1).SetValue(item.Data.Alpha, true);
			if (this.SelectedItemCache != item)
			{
				this.SelectedItemCache = item;
				UUIItem rootItem = item.RootItem;
				UUIItem item2 = base.GetItem(12);
				item2.GetOwner().K2_AttachToActor(rootItem.GetOwner(), null, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
				item2.SetAnchorAlign(UIAnchorHorizontalAlign.Stretch, UIAnchorVerticalAlign.Stretch);
				item2.SetStretchLeft(0f);
				item2.SetStretchRight(0f);
				item2.SetStretchTop(0f);
				item2.SetStretchBottom(0f);
				item2.SetUIActive(true);
			}
		}

		// Token: 0x0401FAD5 RID: 129749
		[Nullable(1)]
		private TouchUiEditProxy EditProxy;

		// Token: 0x0401FAD6 RID: 129750
		private FVector? LocalOffsetVector;

		// Token: 0x0401FAD7 RID: 129751
		private FVector ResultLocation;

		// Token: 0x0401FAD8 RID: 129752
		private ITouchUiEditItem SelectedItemCache;

		// Token: 0x0200B9FF RID: 47615
		[NullableContext(0)]
		private static class EChildType
		{
			// Token: 0x04039544 RID: 234820
			public const int BattleViewItem = 0;

			// Token: 0x04039545 RID: 234821
			public const int AlphaSlider = 1;

			// Token: 0x04039546 RID: 234822
			public const int SizeSlider = 2;

			// Token: 0x04039547 RID: 234823
			public const int DownButton = 3;

			// Token: 0x04039548 RID: 234824
			public const int UpButton = 4;

			// Token: 0x04039549 RID: 234825
			public const int RightButton = 5;

			// Token: 0x0403954A RID: 234826
			public const int LeftButton = 6;

			// Token: 0x0403954B RID: 234827
			public const int ResetButton = 7;

			// Token: 0x0403954C RID: 234828
			public const int SaveButton = 8;

			// Token: 0x0403954D RID: 234829
			public const int CloseButton = 9;

			// Token: 0x0403954E RID: 234830
			public const int DraggableComponent = 10;

			// Token: 0x0403954F RID: 234831
			public const int SettingItem = 11;

			// Token: 0x04039550 RID: 234832
			public const int SelectedItem = 12;
		}
	}
}
