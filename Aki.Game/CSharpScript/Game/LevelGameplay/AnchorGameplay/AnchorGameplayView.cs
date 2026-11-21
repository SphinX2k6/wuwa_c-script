using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Qte.View;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.AnchorGameplay
{
	// Token: 0x020060E1 RID: 24801
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AnchorGameplayView : CommonQteViewBase<CommonQteDragContext>
	{
		// Token: 0x0603B760 RID: 243552 RVA: 0x010D496C File Offset: 0x010D2B6C
		[NullableContext(1)]
		public AnchorGameplayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B761 RID: 243553 RVA: 0x010D49C0 File Offset: 0x010D2BC0
		protected unsafe override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B762 RID: 243554 RVA: 0x010D4A50 File Offset: 0x010D2C50
		protected override UniTask OnBeforeStartAsync()
		{
			AnchorGameplayView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AnchorGameplayView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B763 RID: 243555 RVA: 0x010D4A93 File Offset: 0x010D2C93
		protected override void OnAddEventListener()
		{
			this.OnInputControllerChange(EInputControllerType.None, EInputControllerType.None);
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x0603B764 RID: 243556 RVA: 0x010D4ABC File Offset: 0x010D2CBC
		private void InitDrag()
		{
			this.DraggableComponent = base.GetDraggable(0);
			this.DraggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
			this.DraggableComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDrag));
			this.DraggableComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.CheckFinish));
			AActor owner = this.DraggableComponent.GetOwner();
			this.BgItem = (((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem);
		}

		// Token: 0x0603B765 RID: 243557 RVA: 0x010D4B58 File Offset: 0x010D2D58
		private void InitConfig()
		{
			this.MoveDistance = ConfigCommonParamById.GetIntConfig("AnchorBtnMoveDistance").Value;
			string stringConfig = ConfigCommonParamById.GetStringConfig("AnchorMovementCurve");
			this.MoveCurve = ResourceSystem.Instance.Load<UCurveVector>(stringConfig, "js_undefined");
			this.DetachOffset = ConfigCommonParamById.GetIntConfig("AnchorBtnDetachOffset").Value;
			this.GamepadMovementFactor = ConfigCommonParamById.GetFloatConfig("AnchorGamepadBtnMovementFactor").Value;
			this.EndPerformTime = ConfigCommonParamById.GetIntConfig("AnchorEndAnimTime").Value;
			this.EndPerformPercentagePerMs = 1f / (float)this.EndPerformTime;
		}

		// Token: 0x0603B766 RID: 243558 RVA: 0x010D4BFC File Offset: 0x010D2DFC
		protected override void OnStart()
		{
			base.OnStart();
			this.InitConfig();
			this.InitDrag();
			this.MoveItemBtnComp = base.GetButton(1);
			this.MoveItemBtnComp.OnPointDownCallBack.Bind(new Action(this.OnPress));
			this.MoveItemBtnComp.OnPointUpCallBack.Bind(new Action(this.OnRelease));
			AActor owner = this.MoveItemBtnComp.GetOwner();
			this.MoveItem = (((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem);
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
			this.CurPercentage = 0f;
			this.BgItem.SetUIActive(false);
		}

		// Token: 0x0603B767 RID: 243559 RVA: 0x010D4CCC File Offset: 0x010D2ECC
		protected override void OnBeforeDestroy()
		{
			base.OnBeforeDestroy();
			this.OnRemoveEventListener();
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0603B768 RID: 243560 RVA: 0x010D4CEA File Offset: 0x010D2EEA
		protected override void OnHandleQteEnd()
		{
			if (this.CurPercentage != 1f)
			{
				LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
				if (levelSequencePlayer != null)
				{
					levelSequencePlayer.StopCurrentSequence(false, false);
				}
				this.PlayingEndPerform = true;
				this.OnFinishEndPerformCallback = delegate()
				{
					LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
					if (levelSequencePlayer2 == null)
					{
						return;
					}
					levelSequencePlayer2.PlayLevelSequenceByName("Success", false, null, false);
				};
			}
		}

		// Token: 0x0603B769 RID: 243561 RVA: 0x010D4D28 File Offset: 0x010D2F28
		private unsafe void OnPointerDrag(ULGUIPointerEventData eventData)
		{
			if (this.IsQteEnd || this.IsQtePause || this.MoveCurve == null || !this.ClickedBtn)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Temp;
				ELogAuthor author = ELogAuthor.CH;
				string message = "[AnchorGameplayView] OnPointerDrag";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("IsQteEnd", this.IsQteEnd);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("IsQtePause", this.IsQtePause);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("MoveCurve", this.MoveCurve);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ClickedBtn", this.ClickedBtn);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return;
			}
			FVector pointerPosition = eventData.pointerPosition;
			Vector2D vector2D = Vector2D.Create();
			LguiUtil.Instance.ConvertPointerPositionToLguiPosition(pointerPosition, vector2D);
			float num = (float)(vector2D.Y - this.LastDragPos.Y) / (float)this.MoveDistance;
			this.CurPercentage += num * -1f;
			this.CurPercentage = MathUtils.Instance.Clamp(this.CurPercentage, 0f, 1f);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Temp;
			ELogAuthor author2 = ELogAuthor.CH;
			string message2 = "[AnchorGameplayView] OnPointerDrag";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("deltaPercentage", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("CurPercentage", this.CurPercentage);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			FVector vectorValue = this.MoveCurve.GetVectorValue(this.CurPercentage);
			this.MoveItem.SetUIRelativeLocation(vectorValue);
			Vector2D vector2D2 = Vector2D.Create(this.MoveItem.GetLGUISpaceAbsolutePosition());
			Vector2D vector2D3 = Vector2D.Create(vector2D);
			if (Vector2D.Distance(vector2D2, vector2D3) > (double)this.DetachOffset || this.CurPercentage == 1f)
			{
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.Temp;
				ELogAuthor author3 = ELogAuthor.CH;
				string message3 = "[AnchorGameplayView] OnPointerDrag Detach";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("position", pointerPosition);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("itemPos", vector2D2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("pointerPos", vector2D3);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("Dist", Vector2D.Distance(vector2D2, vector2D3));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("DetachOffset", this.DetachOffset);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 5));
				this.ClickedBtn = false;
				this.CheckFinish(null);
				return;
			}
			this.LastDragPos.DeepCopy(vector2D);
		}

		// Token: 0x0603B76A RID: 243562 RVA: 0x010D4FFC File Offset: 0x010D31FC
		private void OnPointerBeginDrag(ULGUIPointerEventData eventData)
		{
			FVector pointerPosition = eventData.pointerPosition;
			LguiUtil.Instance.ConvertPointerPositionToLguiPosition(pointerPosition, this.LastDragPos);
			Log.Instance.Info(ELogModule.Temp, ELogAuthor.CH, "[AnchorGameplayView] OnPointerBeginDrag", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603B76B RID: 243563 RVA: 0x010D503C File Offset: 0x010D323C
		[NullableContext(1)]
		private void CheckFinish(ULGUIPointerEventData data)
		{
			CommonQteDragContext commonQteContext = this.CommonQteContext;
			if (commonQteContext != null && commonQteContext.State == EQteState.Success)
			{
				return;
			}
			if (this.CurPercentage != 1f)
			{
				FVector vectorValue = this.MoveCurve.GetVectorValue(0f);
				this.MoveItem.SetUIRelativeLocation(vectorValue);
				this.CurPercentage = 0f;
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Success", false, null, false);
			}
			this.CommonQteContext.QteSuccess();
		}

		// Token: 0x0603B76C RID: 243564 RVA: 0x010D50C4 File Offset: 0x010D32C4
		private void OnPress()
		{
			this.ClickedBtn = true;
			Log.Instance.Info(ELogModule.Temp, ELogAuthor.CH, "[AnchorGameplayView]OnPress called", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603B76D RID: 243565 RVA: 0x010D50F4 File Offset: 0x010D32F4
		private void OnRelease()
		{
			this.ClickedBtn = false;
			Log.Instance.Info(ELogModule.Temp, ELogAuthor.CH, "[AnchorGameplayView]OnRelease called", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603B76E RID: 243566 RVA: 0x010D5124 File Offset: 0x010D3324
		[NullableContext(1)]
		public override void SetQteContext(CommonQteContextBase context)
		{
			CommonQteDragContext commonQteDragContext = context as CommonQteDragContext;
			if (commonQteDragContext == null)
			{
				return;
			}
			this.QteHandle = context.HandleId;
			this.CommonQteContext = commonQteDragContext;
			InputActionOrAxisKeyItem actionOrAxisKeyItem = new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = "UiLookUp"
			};
			InputMultiKeyItem inputKeyItem = this.InputKeyItem;
			if (inputKeyItem != null)
			{
				inputKeyItem.RefreshByActionOrAxis(actionOrAxisKeyItem, false);
			}
			if (Info.Instance.IsInGamepad())
			{
				InputMultiKeyItem inputKeyItem2 = this.InputKeyItem;
				if (inputKeyItem2 != null)
				{
					inputKeyItem2.Show(null);
				}
			}
			else
			{
				InputMultiKeyItem inputKeyItem3 = this.InputKeyItem;
				if (inputKeyItem3 != null)
				{
					inputKeyItem3.Hide(null);
				}
			}
			this.RefreshUiOffset();
			base.SetQteActive(commonQteDragContext);
			this.PlayQteStart();
		}

		// Token: 0x0603B76F RID: 243567 RVA: 0x010D51B8 File Offset: 0x010D33B8
		protected override void OnTick(float delta)
		{
			if (this.PlayingEndPerform)
			{
				this.TickEndPerform(delta);
				return;
			}
			if (!this.IsQteStart || this.IsQteEnd || this.IsQtePause)
			{
				return;
			}
			if (this.CommonQteContext == null || this.CommonQteContext.IsInvalid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.CommonQte;
				ELogAuthor author = ELogAuthor.CH;
				string message = "Qte界面Context已无效, 强制关闭界面";
				string item = "State";
				CommonQteDragContext commonQteContext = this.CommonQteContext;
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, (commonQteContext != null) ? new EQteState?(commonQteContext.State) : null);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.HandleQteEnd();
				return;
			}
			this.CommonQteContext.UpdateTime(delta);
			CommonQteModel instance2 = CommonQteModel.Instance;
			if (instance2 != null && instance2.IsRefreshMode)
			{
				this.RefreshUiOffset();
			}
		}

		// Token: 0x0603B770 RID: 243568 RVA: 0x010D527C File Offset: 0x010D347C
		private void TickEndPerform(float delta)
		{
			this.CurPercentage += delta * this.EndPerformPercentagePerMs;
			this.CurPercentage = MathUtils.Instance.Clamp(this.CurPercentage, 0f, 1f);
			FVector vectorValue = this.MoveCurve.GetVectorValue(this.CurPercentage);
			this.MoveItem.SetUIRelativeLocation(vectorValue);
			if (this.CurPercentage == 1f)
			{
				this.PlayingEndPerform = false;
				if (this.OnFinishEndPerformCallback != null)
				{
					this.OnFinishEndPerformCallback();
				}
			}
		}

		// Token: 0x0603B771 RID: 243569 RVA: 0x010D5304 File Offset: 0x010D3504
		protected override void OnPlayQteStart()
		{
			this.BgItem.SetUIActive(true);
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.PlayLevelSequenceByName("Start01", false, null, false);
		}

		// Token: 0x0603B772 RID: 243570 RVA: 0x010D5340 File Offset: 0x010D3540
		[NullableContext(1)]
		private void OnSequenceEndEvent(string name)
		{
			if (!(name == "Start01"))
			{
				if (name == "Close01" || name == "Success")
				{
					UiManager.Instance.CloseView(EUiViewName.AnchorGameplayView, null);
				}
				return;
			}
			if (this.IsQteEnd)
			{
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Tips", false, null, false);
			}
			this.IsQteStart = true;
			this.IsQteInteractive = true;
		}

		// Token: 0x0603B773 RID: 243571 RVA: 0x010D53C0 File Offset: 0x010D35C0
		private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
		{
			this.CheckFinish(null);
			if (Info.Instance.IsInGamepad())
			{
				this.BindGamepadInput();
				InputMultiKeyItem inputKeyItem = this.InputKeyItem;
				if (inputKeyItem == null)
				{
					return;
				}
				inputKeyItem.Show(null);
				return;
			}
			else
			{
				this.UnbindGamepadInput();
				InputMultiKeyItem inputKeyItem2 = this.InputKeyItem;
				if (inputKeyItem2 == null)
				{
					return;
				}
				inputKeyItem2.Hide(null);
				return;
			}
		}

		// Token: 0x0603B774 RID: 243572 RVA: 0x010D540F File Offset: 0x010D360F
		protected override void OnRemoveEventListener()
		{
			if (Info.Instance.IsInGamepad())
			{
				this.UnbindGamepadInput();
			}
		}

		// Token: 0x0603B775 RID: 243573 RVA: 0x010D5423 File Offset: 0x010D3623
		private void BindGamepadInput()
		{
			InputDistributeController.Instance.BindAxis("UiScroll1", new TInputHandle<float>(this.OnGamepadInput));
		}

		// Token: 0x0603B776 RID: 243574 RVA: 0x010D5440 File Offset: 0x010D3640
		private void UnbindGamepadInput()
		{
			InputDistributeController.Instance.UnBindAxis("UiScroll1", new TInputHandle<float>(this.OnGamepadInput));
		}

		// Token: 0x0603B777 RID: 243575 RVA: 0x010D5460 File Offset: 0x010D3660
		[NullableContext(1)]
		private void OnGamepadInput(string axisName, float value, InputIdentification inputIdentification)
		{
			if (this.IsQteEnd || this.IsQtePause || this.MoveCurve == null)
			{
				return;
			}
			if (value <= 0f)
			{
				if (this.CurPercentage != 0f)
				{
					this.CheckFinish(null);
				}
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.CH;
			string message = "[AnchorGameplayView]OnGamepadInput called";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("value", value);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.CurPercentage += value * this.GamepadMovementFactor;
			this.CurPercentage = MathUtils.Instance.Clamp(this.CurPercentage, 0f, 1f);
			FVector vectorValue = this.MoveCurve.GetVectorValue(this.CurPercentage);
			this.MoveItem.SetUIRelativeLocation(vectorValue);
			if (this.CurPercentage == 1f)
			{
				this.CheckFinish(null);
			}
		}

		// Token: 0x0603B778 RID: 243576 RVA: 0x010D5538 File Offset: 0x010D3738
		protected override void RefreshUiOffset()
		{
			if (this.CommonQteContext != null)
			{
				SCommonQte_Drag scommonQte_Drag = this.CommonQteContext.GetUiConfig() as SCommonQte_Drag;
				if (scommonQte_Drag != null)
				{
					SCommonQteButton uiconfig = scommonQte_Drag.UIConfig;
					this.RootItem.SetAnchorAlign(uiconfig.AnchorHAlign, uiconfig.AnchorVAlign);
					this.RootItem.SetAnchorOffset(uiconfig.AnchorOffset);
				}
			}
		}

		// Token: 0x0603B779 RID: 243577 RVA: 0x010D5596 File Offset: 0x010D3796
		protected override bool IsUseBaseAction()
		{
			return false;
		}

		// Token: 0x0401F5A0 RID: 128416
		private UUIItem BgItem;

		// Token: 0x0401F5A1 RID: 128417
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x0401F5A2 RID: 128418
		private UUIItem MoveItem;

		// Token: 0x0401F5A3 RID: 128419
		private UUIButtonComponent MoveItemBtnComp;

		// Token: 0x0401F5A4 RID: 128420
		private InputMultiKeyItem InputKeyItem;

		// Token: 0x0401F5A5 RID: 128421
		private bool ClickedBtn;

		// Token: 0x0401F5A6 RID: 128422
		[Nullable(1)]
		private readonly Vector2D LastDragPos = Vector2D.Create();

		// Token: 0x0401F5A7 RID: 128423
		private float CurPercentage;

		// Token: 0x0401F5A8 RID: 128424
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F5A9 RID: 128425
		private int MoveDistance = 560;

		// Token: 0x0401F5AA RID: 128426
		private UCurveVector MoveCurve;

		// Token: 0x0401F5AB RID: 128427
		private int DetachOffset = 100;

		// Token: 0x0401F5AC RID: 128428
		private float GamepadMovementFactor = -0.05f;

		// Token: 0x0401F5AD RID: 128429
		private int EndPerformTime = 500;

		// Token: 0x0401F5AE RID: 128430
		private float EndPerformPercentagePerMs = -1f;

		// Token: 0x0401F5AF RID: 128431
		private bool PlayingEndPerform;

		// Token: 0x0401F5B0 RID: 128432
		private Action OnFinishEndPerformCallback;

		// Token: 0x0200B989 RID: 47497
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04039353 RID: 234323
			public const int DraggableArea = 0;

			// Token: 0x04039354 RID: 234324
			public const int MoveItem = 1;

			// Token: 0x04039355 RID: 234325
			public const int KeyItem = 2;
		}
	}
}
