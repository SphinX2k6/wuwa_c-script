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
	// Token: 0x02007013 RID: 28691
	[NullableContext(2)]
	[Nullable(0)]
	public class CommonTouchUiEditView : UiTickViewBase, ITouchUiEditView
	{
		// Token: 0x06045D15 RID: 285973 RVA: 0x0115CE63 File Offset: 0x0115B063
		[NullableContext(1)]
		public CommonTouchUiEditView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06045D16 RID: 285974 RVA: 0x0115CE6C File Offset: 0x0115B06C
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

		// Token: 0x06045D17 RID: 285975 RVA: 0x0115CFFC File Offset: 0x0115B1FC
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

		// Token: 0x06045D18 RID: 285976 RVA: 0x0115D068 File Offset: 0x0115B268
		protected override UniTask OnBeforeStartAsync()
		{
			CommonTouchUiEditView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CommonTouchUiEditView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06045D19 RID: 285977 RVA: 0x0115D0AB File Offset: 0x0115B2AB
		protected override void OnStart()
		{
			this.ResultLocation = new FVector?(base.GetItem(11).RelativeLocation);
			this.EditProxy.OnStart();
			base.GetItem(12).SetUIActive(false);
		}

		// Token: 0x06045D1A RID: 285978 RVA: 0x0115D0DE File Offset: 0x0115B2DE
		protected override void OnTick(float delta)
		{
			this.EditProxy.OnTick(delta);
		}

		// Token: 0x06045D1B RID: 285979 RVA: 0x0115D0EC File Offset: 0x0115B2EC
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

		// Token: 0x06045D1C RID: 285980 RVA: 0x0115D2CC File Offset: 0x0115B4CC
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

		// Token: 0x06045D1D RID: 285981 RVA: 0x0115D3A4 File Offset: 0x0115B5A4
		protected override void OnBeforeDestroy()
		{
			this.EditProxy.OnBeforeDestroy();
		}

		// Token: 0x06045D1E RID: 285982 RVA: 0x0115D3B1 File Offset: 0x0115B5B1
		[NullableContext(1)]
		public UUIItem GetAttachRoot()
		{
			return base.GetItem(0);
		}

		// Token: 0x06045D1F RID: 285983 RVA: 0x0115D3BA File Offset: 0x0115B5BA
		public UUISliderComponent GetScaleSlider()
		{
			return base.GetSlider(2);
		}

		// Token: 0x06045D20 RID: 285984 RVA: 0x0115D3C4 File Offset: 0x0115B5C4
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

		// Token: 0x06045D21 RID: 285985 RVA: 0x0115D4A0 File Offset: 0x0115B6A0
		private void SetRelativeLocation(FVector relativeLocation)
		{
			UUIItem item = base.GetItem(11);
			this.ClampBound(relativeLocation);
			item.SetUIRelativeLocation(relativeLocation);
		}

		// Token: 0x06045D22 RID: 285986 RVA: 0x0115D4B8 File Offset: 0x0115B6B8
		private void OnClickedResetButton()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.ButtonReset);
			confirmBoxDataNew.FunctionMap[2] = delegate()
			{
				this.EditProxy.Reset();
			};
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06045D23 RID: 285987 RVA: 0x0115D4F1 File Offset: 0x0115B6F1
		private void OnClickedSaveButton()
		{
			this.EditProxy.Save(true);
		}

		// Token: 0x06045D24 RID: 285988 RVA: 0x0115D500 File Offset: 0x0115B700
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

		// Token: 0x06045D25 RID: 285989 RVA: 0x0115D571 File Offset: 0x0115B771
		private void OnSizeSliderValueChanged(float value)
		{
			this.EditProxy.SetScale(value);
		}

		// Token: 0x06045D26 RID: 285990 RVA: 0x0115D57F File Offset: 0x0115B77F
		private void OnAlphaSliderValueChanged(float value)
		{
			this.EditProxy.SetAlpha(value);
		}

		// Token: 0x06045D27 RID: 285991 RVA: 0x0115D58D File Offset: 0x0115B78D
		private void OnPressDownButton()
		{
			this.EditProxy.SetOffsetDeltaY(-1);
		}

		// Token: 0x06045D28 RID: 285992 RVA: 0x0115D59B File Offset: 0x0115B79B
		private void OnReleaseDownButton()
		{
			this.EditProxy.SetOffsetDeltaY(0);
		}

		// Token: 0x06045D29 RID: 285993 RVA: 0x0115D5A9 File Offset: 0x0115B7A9
		private void OnPressUpButton()
		{
			this.EditProxy.SetOffsetDeltaY(1);
		}

		// Token: 0x06045D2A RID: 285994 RVA: 0x0115D5B7 File Offset: 0x0115B7B7
		private void OnReleaseUpButton()
		{
			this.EditProxy.SetOffsetDeltaY(0);
		}

		// Token: 0x06045D2B RID: 285995 RVA: 0x0115D5C5 File Offset: 0x0115B7C5
		private void OnPressLeftButton()
		{
			this.EditProxy.SetOffsetDeltaX(-1);
		}

		// Token: 0x06045D2C RID: 285996 RVA: 0x0115D5D3 File Offset: 0x0115B7D3
		private void OnReleaseLeftButton()
		{
			this.EditProxy.SetOffsetDeltaX(0);
		}

		// Token: 0x06045D2D RID: 285997 RVA: 0x0115D5E1 File Offset: 0x0115B7E1
		private void OnPressRightButton()
		{
			this.EditProxy.SetOffsetDeltaX(1);
		}

		// Token: 0x06045D2E RID: 285998 RVA: 0x0115D5EF File Offset: 0x0115B7EF
		private void OnReleaseRightButton()
		{
			this.EditProxy.SetOffsetDeltaX(0);
		}

		// Token: 0x06045D2F RID: 285999 RVA: 0x0115D600 File Offset: 0x0115B800
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
				CommonTouchUiEditView.<>c__DisplayClass31_0 CS$<>8__locals1 = new CommonTouchUiEditView.<>c__DisplayClass31_0();
				AUIBaseActor auibaseActor = eventData.dragComponent.GetOwner() as AUIBaseActor;
				CommonTouchUiEditView.<>c__DisplayClass31_0 CS$<>8__locals2 = CS$<>8__locals1;
				FVectorDouble fvectorDouble = auibaseActor.D_GetActorScale3D();
				CS$<>8__locals2.scale = fvectorDouble;
				CS$<>8__locals1.offsetIntervalX = localPointInPlane.X - this.LocalOffsetVector.Value.X;
				CS$<>8__locals1.offsetIntervalY = localPointInPlane.Y - this.LocalOffsetVector.Value.Y;
				if (CS$<>8__locals1.offsetIntervalX == 0f || CS$<>8__locals1.offsetIntervalY == 0f)
				{
					return;
				}
				GameUtils.SetNullableValue<FVector>(ref this.ResultLocation, delegate(ref FVector Value)
				{
					Value.X += CS$<>8__locals1.offsetIntervalX * CS$<>8__locals1.scale.X;
					Value.Y += CS$<>8__locals1.offsetIntervalY * CS$<>8__locals1.scale.Y;
				});
				this.SetRelativeLocation(this.ResultLocation.Value);
			}
			this.LocalOffsetVector = new FVector?(localPointInPlane);
		}

		// Token: 0x06045D30 RID: 286000 RVA: 0x0115D70A File Offset: 0x0115B90A
		private void OnDragBegin()
		{
			this.OnDragBegin(null);
		}

		// Token: 0x06045D31 RID: 286001 RVA: 0x0115D713 File Offset: 0x0115B913
		private void OnDragBegin(ULGUIPointerEventData eventData)
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x06045D32 RID: 286002 RVA: 0x0115D721 File Offset: 0x0115B921
		private void OnDragEnded()
		{
			this.OnDragEnded(null);
		}

		// Token: 0x06045D33 RID: 286003 RVA: 0x0115D72A File Offset: 0x0115B92A
		private void OnDragEnded(ULGUIPointerEventData eventData)
		{
			this.LocalOffsetVector = null;
		}

		// Token: 0x06045D34 RID: 286004 RVA: 0x0115D738 File Offset: 0x0115B938
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

		// Token: 0x0402481F RID: 149535
		[Nullable(1)]
		private TouchUiEditProxy EditProxy;

		// Token: 0x04024820 RID: 149536
		private FVector? LocalOffsetVector;

		// Token: 0x04024821 RID: 149537
		private FVector? ResultLocation;

		// Token: 0x04024822 RID: 149538
		private ITouchUiEditItem SelectedItemCache;

		// Token: 0x0200CE0D RID: 52749
		[NullableContext(0)]
		private static class EChildType
		{
			// Token: 0x0403E116 RID: 254230
			public const int BattleViewItem = 0;

			// Token: 0x0403E117 RID: 254231
			public const int AlphaSlider = 1;

			// Token: 0x0403E118 RID: 254232
			public const int SizeSlider = 2;

			// Token: 0x0403E119 RID: 254233
			public const int DownButton = 3;

			// Token: 0x0403E11A RID: 254234
			public const int UpButton = 4;

			// Token: 0x0403E11B RID: 254235
			public const int RightButton = 5;

			// Token: 0x0403E11C RID: 254236
			public const int LeftButton = 6;

			// Token: 0x0403E11D RID: 254237
			public const int ResetButton = 7;

			// Token: 0x0403E11E RID: 254238
			public const int SaveButton = 8;

			// Token: 0x0403E11F RID: 254239
			public const int CloseButton = 9;

			// Token: 0x0403E120 RID: 254240
			public const int DraggableComponent = 10;

			// Token: 0x0403E121 RID: 254241
			public const int SettingItem = 11;

			// Token: 0x0403E122 RID: 254242
			public const int SelectedItem = 12;
		}
	}
}
