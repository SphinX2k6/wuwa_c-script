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
	// Token: 0x0200694A RID: 26954
	[NullableContext(2)]
	[Nullable(0)]
	public class SplineConstrainedDragView : UiViewBase
	{
		// Token: 0x06043297 RID: 275095 RVA: 0x0105F925 File Offset: 0x0105DB25
		[NullableContext(1)]
		public SplineConstrainedDragView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06043298 RID: 275096 RVA: 0x0105F938 File Offset: 0x0105DB38
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

		// Token: 0x06043299 RID: 275097 RVA: 0x0105FA8C File Offset: 0x0105DC8C
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

		// Token: 0x0604329A RID: 275098 RVA: 0x0105FC20 File Offset: 0x0105DE20
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

		// Token: 0x0604329B RID: 275099 RVA: 0x0105FD6C File Offset: 0x0105DF6C
		protected override UniTask OnBeforeStartAsync()
		{
			SplineConstrainedDragView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SplineConstrainedDragView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604329C RID: 275100 RVA: 0x0105FDB0 File Offset: 0x0105DFB0
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

		// Token: 0x0604329D RID: 275101 RVA: 0x0105FF36 File Offset: 0x0105E136
		private void OnHintPanelRecheck()
		{
			this.RefreshHintPanels();
		}

		// Token: 0x0604329E RID: 275102 RVA: 0x0105FF40 File Offset: 0x0105E140
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

		// Token: 0x0604329F RID: 275103 RVA: 0x0105FF93 File Offset: 0x0105E193
		private void OnCloseButtonClick()
		{
			SplineConstrainedDragController.Instance.DisableDragActorPlay();
		}

		// Token: 0x060432A0 RID: 275104 RVA: 0x0105FFA0 File Offset: 0x0105E1A0
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

		// Token: 0x060432A1 RID: 275105 RVA: 0x01060000 File Offset: 0x0105E200
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

		// Token: 0x060432A2 RID: 275106 RVA: 0x01060068 File Offset: 0x0105E268
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

		// Token: 0x060432A3 RID: 275107 RVA: 0x010600B8 File Offset: 0x0105E2B8
		private void OnPointerScrollCallBack(ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x060432A4 RID: 275108 RVA: 0x010600BC File Offset: 0x0105E2BC
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

		// Token: 0x060432A5 RID: 275109 RVA: 0x01060140 File Offset: 0x0105E340
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

		// Token: 0x04022FA1 RID: 143265
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022FA2 RID: 143266
		private bool? LastHintIsGamepad;

		// Token: 0x04022FA3 RID: 143267
		private int LastHintDraggableCount = -1;

		// Token: 0x04022FA4 RID: 143268
		private EDragHintType? LastHintType;

		// Token: 0x0200CADA RID: 51930
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0403D4DE RID: 251102
			Caption,
			// Token: 0x0403D4DF RID: 251103
			Title,
			// Token: 0x0403D4E0 RID: 251104
			Desc,
			// Token: 0x0403D4E1 RID: 251105
			Draggable,
			// Token: 0x0403D4E2 RID: 251106
			PanelHotKeyA,
			// Token: 0x0403D4E3 RID: 251107
			PanelHotKeyB,
			// Token: 0x0403D4E4 RID: 251108
			PanelHotKeyC,
			// Token: 0x0403D4E5 RID: 251109
			PanelHotKeyD,
			// Token: 0x0403D4E6 RID: 251110
			TxtTips
		}
	}
}
