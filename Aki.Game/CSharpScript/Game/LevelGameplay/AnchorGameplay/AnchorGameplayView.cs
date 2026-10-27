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
	// Token: 0x02006F60 RID: 28512
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AnchorGameplayView : CommonQteViewBase<CommonQteDragContext>
	{
		// Token: 0x060455B2 RID: 284082 RVA: 0x0112AB8C File Offset: 0x01128D8C
		[NullableContext(1)]
		public AnchorGameplayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060455B3 RID: 284083 RVA: 0x0112ABE0 File Offset: 0x01128DE0
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

		// Token: 0x060455B4 RID: 284084 RVA: 0x0112AC70 File Offset: 0x01128E70
		protected override UniTask OnBeforeStartAsync()
		{
			AnchorGameplayView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AnchorGameplayView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060455B5 RID: 284085 RVA: 0x0112ACB3 File Offset: 0x01128EB3
		protected override void OnAddEventListener()
		{
			this.OnInputControllerChange(EInputControllerType.None, EInputControllerType.None);
			EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
		}

		// Token: 0x060455B6 RID: 284086 RVA: 0x0112ACDC File Offset: 0x01128EDC
		private void InitDrag()
		{
			this.DraggableComponent = base.GetDraggable(0);
			this.DraggableComponent.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDrag));
			this.DraggableComponent.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDrag));
			this.DraggableComponent.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.CheckFinish));
			AActor owner = this.DraggableComponent.GetOwner();
			this.BgItem = (((owner != null) ? owner.GetComponentByClass(UUIItem.StaticClass()) : null) as UUIItem);
		}

		// Token: 0x060455B7 RID: 284087 RVA: 0x0112AD78 File Offset: 0x01128F78
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

		// Token: 0x060455B8 RID: 284088 RVA: 0x0112AE1C File Offset: 0x0112901C
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

		// Token: 0x060455B9 RID: 284089 RVA: 0x0112AEEC File Offset: 0x011290EC
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

		// Token: 0x060455BA RID: 284090 RVA: 0x0112AF0A File Offset: 0x0112910A
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

		// Token: 0x060455BB RID: 284091 RVA: 0x0112AF48 File Offset: 0x01129148
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

		// Token: 0x060455BC RID: 284092 RVA: 0x0112B21C File Offset: 0x0112941C
		private void OnPointerBeginDrag(ULGUIPointerEventData eventData)
		{
			FVector pointerPosition = eventData.pointerPosition;
			LguiUtil.Instance.ConvertPointerPositionToLguiPosition(pointerPosition, this.LastDragPos);
			Log.Instance.Info(ELogModule.Temp, ELogAuthor.CH, "[AnchorGameplayView] OnPointerBeginDrag", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060455BD RID: 284093 RVA: 0x0112B25C File Offset: 0x0112945C
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

		// Token: 0x060455BE RID: 284094 RVA: 0x0112B2E4 File Offset: 0x011294E4
		private void OnPress()
		{
			this.ClickedBtn = true;
			Log.Instance.Info(ELogModule.Temp, ELogAuthor.CH, "[AnchorGameplayView]OnPress called", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060455BF RID: 284095 RVA: 0x0112B314 File Offset: 0x01129514
		private void OnRelease()
		{
			this.ClickedBtn = false;
			Log.Instance.Info(ELogModule.Temp, ELogAuthor.CH, "[AnchorGameplayView]OnRelease called", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060455C0 RID: 284096 RVA: 0x0112B344 File Offset: 0x01129544
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

		// Token: 0x060455C1 RID: 284097 RVA: 0x0112B3D8 File Offset: 0x011295D8
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

		// Token: 0x060455C2 RID: 284098 RVA: 0x0112B49C File Offset: 0x0112969C
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

		// Token: 0x060455C3 RID: 284099 RVA: 0x0112B524 File Offset: 0x01129724
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

		// Token: 0x060455C4 RID: 284100 RVA: 0x0112B560 File Offset: 0x01129760
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

		// Token: 0x060455C5 RID: 284101 RVA: 0x0112B5E0 File Offset: 0x011297E0
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

		// Token: 0x060455C6 RID: 284102 RVA: 0x0112B62F File Offset: 0x0112982F
		protected override void OnRemoveEventListener()
		{
			if (Info.Instance.IsInGamepad())
			{
				this.UnbindGamepadInput();
			}
		}

		// Token: 0x060455C7 RID: 284103 RVA: 0x0112B643 File Offset: 0x01129843
		private void BindGamepadInput()
		{
			InputDistributeController.Instance.BindAxis("UiScroll1", new TInputHandle<float>(this.OnGamepadInput));
		}

		// Token: 0x060455C8 RID: 284104 RVA: 0x0112B660 File Offset: 0x01129860
		private void UnbindGamepadInput()
		{
			InputDistributeController.Instance.UnBindAxis("UiScroll1", new TInputHandle<float>(this.OnGamepadInput));
		}

		// Token: 0x060455C9 RID: 284105 RVA: 0x0112B680 File Offset: 0x01129880
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

		// Token: 0x060455CA RID: 284106 RVA: 0x0112B758 File Offset: 0x01129958
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

		// Token: 0x060455CB RID: 284107 RVA: 0x0112B7B6 File Offset: 0x011299B6
		protected override bool IsUseBaseAction()
		{
			return false;
		}

		// Token: 0x040242EB RID: 148203
		private UUIItem BgItem;

		// Token: 0x040242EC RID: 148204
		private UUIDraggableComponent DraggableComponent;

		// Token: 0x040242ED RID: 148205
		private UUIItem MoveItem;

		// Token: 0x040242EE RID: 148206
		private UUIButtonComponent MoveItemBtnComp;

		// Token: 0x040242EF RID: 148207
		private InputMultiKeyItem InputKeyItem;

		// Token: 0x040242F0 RID: 148208
		private bool ClickedBtn;

		// Token: 0x040242F1 RID: 148209
		[Nullable(1)]
		private readonly Vector2D LastDragPos = Vector2D.Create();

		// Token: 0x040242F2 RID: 148210
		private float CurPercentage;

		// Token: 0x040242F3 RID: 148211
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040242F4 RID: 148212
		private int MoveDistance = 560;

		// Token: 0x040242F5 RID: 148213
		private UCurveVector MoveCurve;

		// Token: 0x040242F6 RID: 148214
		private int DetachOffset = 100;

		// Token: 0x040242F7 RID: 148215
		private float GamepadMovementFactor = -0.05f;

		// Token: 0x040242F8 RID: 148216
		private int EndPerformTime = 500;

		// Token: 0x040242F9 RID: 148217
		private float EndPerformPercentagePerMs = -1f;

		// Token: 0x040242FA RID: 148218
		private bool PlayingEndPerform;

		// Token: 0x040242FB RID: 148219
		private Action OnFinishEndPerformCallback;

		// Token: 0x0200CD97 RID: 52631
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403DF24 RID: 253732
			public const int DraggableArea = 0;

			// Token: 0x0403DF25 RID: 253733
			public const int MoveItem = 1;

			// Token: 0x0403DF26 RID: 253734
			public const int KeyItem = 2;
		}
	}
}
