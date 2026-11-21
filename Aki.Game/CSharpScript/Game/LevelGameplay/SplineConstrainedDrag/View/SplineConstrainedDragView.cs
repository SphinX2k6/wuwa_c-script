using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGameplay.SplineConstrainedDrag.View
{
	// Token: 0x02005AA5 RID: 23205
	[NullableContext(2)]
	[Nullable(0)]
	public class SplineConstrainedDragView : UiViewBase
	{
		// Token: 0x060392CE RID: 234190 RVA: 0x01003B86 File Offset: 0x01001D86
		[NullableContext(1)]
		public SplineConstrainedDragView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060392CF RID: 234191 RVA: 0x01003B98 File Offset: 0x01001D98
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060392D0 RID: 234192 RVA: 0x01003CEC File Offset: 0x01001EEC
		protected override void OnAddEventListener()
		{
			UUIDraggableComponent draggable = base.GetDraggable(3);
			draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragMoved));
			draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
			draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
			draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragBegin));
			draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnDragEnded));
			draggable.OnPointerScrollCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerScrollCallBack));
			InputDistributeController.Instance.BindAxis("UiScroll1", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.BindAxis("UiScroll2", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.BindAction("UI键盘Q手柄LB", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI键盘E手柄RB", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI左摇杆上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI左摇杆下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI左摇杆左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.BindAction("UI左摇杆右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			EventSystem.Instance.Add(EEventName.DragActorPlayConditionRecheck, new Action(this.OnHintPanelRecheck));
		}

		// Token: 0x060392D1 RID: 234193 RVA: 0x01003E80 File Offset: 0x01002080
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.DragActorPlayConditionRecheck, new Action(this.OnHintPanelRecheck));
			UUIDraggableComponent draggable = base.GetDraggable(3);
			draggable.OnPointerDragCallBack.Unbind();
			draggable.OnPointerBeginDragCallBack.Unbind();
			draggable.OnPointerEndDragCallBack.Unbind();
			draggable.OnPointerDownCallBack.Unbind();
			draggable.OnPointerUpCallBack.Unbind();
			draggable.OnPointerScrollCallBack.Unbind();
			InputDistributeController.Instance.UnBindAxis("UiScroll1", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.UnBindAxis("UiScroll2", new TInputHandle<float>(this.OnAxis));
			InputDistributeController.Instance.UnBindAction("UI键盘Q手柄LB", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI键盘E手柄RB", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI左摇杆上", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI左摇杆下", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI左摇杆左", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
			InputDistributeController.Instance.UnBindAction("UI左摇杆右", new TInputHandle<InputDistributeDefine.EActionType>(this.OnInput));
		}

		// Token: 0x060392D2 RID: 234194 RVA: 0x01003FCC File Offset: 0x010021CC
		protected override UniTask OnBeforeStartAsync()
		{
			SplineConstrainedDragView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SplineConstrainedDragView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060392D3 RID: 234195 RVA: 0x01004010 File Offset: 0x01002210
		private void RefreshHintPanels()
		{
			SplineConstrainedDragModel instance = SplineConstrainedDragModel.Instance;
			bool flag = Info.Instance.IsInGamepad();
			int draggableCount = SplineConstrainedDragController.Instance.GetDraggableCount();
			IKuroSplineConstrainedDrag activeSplineConstrainedDrag = instance.GetActiveSplineConstrainedDrag();
			EDragHintType? edragHintType = (activeSplineConstrainedDrag != null) ? activeSplineConstrainedDrag.GetDragHintType() : null;
			bool? lastHintIsGamepad = this.LastHintIsGamepad;
			bool flag2 = flag;
			if ((lastHintIsGamepad.GetValueOrDefault() == flag2 & lastHintIsGamepad != null) && this.LastHintDraggableCount == draggableCount)
			{
				EDragHintType? lastHintType = this.LastHintType;
				EDragHintType? edragHintType2 = edragHintType;
				if (lastHintType.GetValueOrDefault() == edragHintType2.GetValueOrDefault() & lastHintType != null == (edragHintType2 != null))
				{
					return;
				}
			}
			this.LastHintIsGamepad = new bool?(flag);
			this.LastHintDraggableCount = draggableCount;
			this.LastHintType = edragHintType;
			UUIItem item = base.GetItem(4);
			UUIItem item2 = base.GetItem(5);
			UUIItem item3 = base.GetItem(6);
			UUIItem item4 = base.GetItem(7);
			UUIText text = base.GetText(8);
			if (!flag)
			{
				if (item != null)
				{
					item.SetUIActive(false);
				}
				if (item2 != null)
				{
					item2.SetUIActive(false);
				}
				if (item3 != null)
				{
					item3.SetUIActive(false);
				}
				if (item4 != null)
				{
					item4.SetUIActive(false);
				}
				if (text != null)
				{
					text.SetUIActive(true);
				}
				return;
			}
			if (text != null)
			{
				text.SetUIActive(false);
			}
			if (item != null)
			{
				item.SetUIActive(draggableCount > 1);
			}
			if (item2 != null)
			{
				UUIItem uuiitem = item2;
				EDragHintType? edragHintType2 = edragHintType;
				EDragHintType edragHintType3 = EDragHintType.Horizontal;
				uuiitem.SetUIActive(edragHintType2.GetValueOrDefault() == edragHintType3 & edragHintType2 != null);
			}
			if (item3 != null)
			{
				item3.SetUIActive(edragHintType.GetValueOrDefault() == EDragHintType.Vertical);
			}
			if (item4 != null)
			{
				item4.SetUIActive(edragHintType.GetValueOrDefault() == EDragHintType.FourWay);
			}
		}

		// Token: 0x060392D4 RID: 234196 RVA: 0x01004196 File Offset: 0x01002396
		private void OnHintPanelRecheck()
		{
			this.RefreshHintPanels();
		}

		// Token: 0x060392D5 RID: 234197 RVA: 0x010041A0 File Offset: 0x010023A0
		private void OnHelpButtonClick()
		{
			int? intConfig = ConfigCommonParamById.GetIntConfig("DragActorPlayGuideGroupId");
			int num3;
			if (intConfig != null)
			{
				int? num = intConfig;
				int num2 = 0;
				if (num.GetValueOrDefault() > num2 & num != null)
				{
					num3 = intConfig.Value;
					goto IL_3A;
				}
			}
			num3 = 10001;
			IL_3A:
			int helpGroupId = num3;
			HelpController.Instance.OpenHelpById(helpGroupId);
		}

		// Token: 0x060392D6 RID: 234198 RVA: 0x010041F3 File Offset: 0x010023F3
		private void OnCloseButtonClick()
		{
			SplineConstrainedDragController.Instance.DisableDragActorPlay();
		}

		// Token: 0x060392D7 RID: 234199 RVA: 0x01004200 File Offset: 0x01002400
		private void OnDragBegin(ULGUIPointerEventData eventData)
		{
			if (eventData == null)
			{
				return;
			}
			if (SundryModel.Instance.GetModuleDebugLevel("SplineConstrainedDrag") >= 5)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[SplineConstrainedDragView] OnDragBegin";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("eventData", eventData);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			SplineConstrainedDragController.Instance.OnPointerBegin(eventData.pointerPosition);
		}

		// Token: 0x060392D8 RID: 234200 RVA: 0x01004260 File Offset: 0x01002460
		private void OnDragMoved(ULGUIPointerEventData eventData)
		{
			if (eventData == null || !eventData.isDragging)
			{
				return;
			}
			if (SundryModel.Instance.GetModuleDebugLevel("SplineConstrainedDrag") >= 5)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[SplineConstrainedDragView] OnDragMoved";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("eventData", eventData);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			SplineConstrainedDragController.Instance.OnPointerMove(eventData.pointerPosition);
		}

		// Token: 0x060392D9 RID: 234201 RVA: 0x010042C8 File Offset: 0x010024C8
		private void OnDragEnded(ULGUIPointerEventData eventData)
		{
			if (SundryModel.Instance.GetModuleDebugLevel("SplineConstrainedDrag") >= 5)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[SplineConstrainedDragView] OnDragEnded";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("eventData", eventData);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			SplineConstrainedDragController.Instance.OnPointerEnd();
		}

		// Token: 0x060392DA RID: 234202 RVA: 0x01004318 File Offset: 0x01002518
		private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x060392DB RID: 234203 RVA: 0x0100431C File Offset: 0x0100251C
		[NullableContext(1)]
		private unsafe void OnAxis(string axisName, float value, InputIdentification identification)
		{
			if (SundryModel.Instance.GetModuleDebugLevel("SplineConstrainedDrag") >= 7)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[SplineConstrainedDragView] OnAxis";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("axisName", axisName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("value", value);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			SplineConstrainedDragController.Instance.OnGamepadAxis(axisName, value);
		}

		// Token: 0x060392DC RID: 234204 RVA: 0x010043A0 File Offset: 0x010025A0
		[NullableContext(1)]
		private unsafe void OnInput(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
		{
			if (SundryModel.Instance.GetModuleDebugLevel("SplineConstrainedDrag") >= 7)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[SplineConstrainedDragView] OnInput";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("actionName", actionName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("actionType", actionType);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			if (actionType != InputDistributeDefine.EActionType.Press)
			{
				return;
			}
			if (actionName == "UI键盘Q手柄LB")
			{
				SplineConstrainedDragController.Instance.SwitchActiveDragByStep(EGamepadSwitchStep.Previous);
				return;
			}
			if (actionName == "UI键盘E手柄RB")
			{
				SplineConstrainedDragController.Instance.SwitchActiveDragByStep(EGamepadSwitchStep.Next);
				return;
			}
			if (actionName == "UI左摇杆上")
			{
				SplineConstrainedDragController.Instance.SwitchActiveDragByDirection(EGamepadSwitchDirection.Up);
				return;
			}
			if (actionName == "UI左摇杆左")
			{
				SplineConstrainedDragController.Instance.SwitchActiveDragByDirection(EGamepadSwitchDirection.Left);
				return;
			}
			if (actionName == "UI左摇杆右")
			{
				SplineConstrainedDragController.Instance.SwitchActiveDragByDirection(EGamepadSwitchDirection.Right);
				return;
			}
			if (!(actionName == "UI左摇杆下"))
			{
				return;
			}
			SplineConstrainedDragController.Instance.SwitchActiveDragByDirection(EGamepadSwitchDirection.Down);
		}

		// Token: 0x0401E18B RID: 123275
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401E18C RID: 123276
		private bool? LastHintIsGamepad;

		// Token: 0x0401E18D RID: 123277
		private int LastHintDraggableCount = -1;

		// Token: 0x0401E18E RID: 123278
		private EDragHintType? LastHintType;

		// Token: 0x0200B6B9 RID: 46777
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x040388C0 RID: 231616
			Caption,
			// Token: 0x040388C1 RID: 231617
			Title,
			// Token: 0x040388C2 RID: 231618
			Desc,
			// Token: 0x040388C3 RID: 231619
			Draggable,
			// Token: 0x040388C4 RID: 231620
			PanelHotKeyA,
			// Token: 0x040388C5 RID: 231621
			PanelHotKeyB,
			// Token: 0x040388C6 RID: 231622
			PanelHotKeyC,
			// Token: 0x040388C7 RID: 231623
			PanelHotKeyD,
			// Token: 0x040388C8 RID: 231624
			TxtTips
		}
	}
}
