using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Render;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roulette.View
{
	// Token: 0x02004CA0 RID: 19616
	[NullableContext(1)]
	[Nullable(0)]
	public class RouletteMainView : UiTickViewBase
	{
		// Token: 0x17007D0C RID: 32012
		// (get) Token: 0x06032B20 RID: 207648 RVA: 0x00BD433A File Offset: 0x00BD253A
		private RouletteComponentMain RouletteComponent
		{
			get
			{
				return this.ViewProxy.GetRouletteComponent();
			}
		}

		// Token: 0x06032B21 RID: 207649 RVA: 0x00BD4347 File Offset: 0x00BD2547
		public RouletteMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06032B22 RID: 207650 RVA: 0x00BD4350 File Offset: 0x00BD2550
		protected unsafe override void OnRegisterComponent()
		{
			if (this.OpenParam == null)
			{
				Log.Instance.Error(ELogModule.Phantom, ELogAuthor.YYZ, "[Roulette] 轮盘打开时未获取到参数", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			else
			{
				this.ViewProxy = (RouletteMainViewProxyBase)this.OpenParam;
			}
			this.ViewProxy.RegisterView(this);
			EOperationType operationType = Info.Instance.OperationType;
			if (operationType != EOperationType.Pad)
			{
				if (operationType == EOperationType.Desktop)
				{
					int num = 6;
					List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
					CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
					Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
					int num2 = 0;
					*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
					num2++;
					*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
					num2++;
					*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIExtendToggle));
					num2++;
					*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
					num2++;
					*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
					num2++;
					*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
					this.ComponentRegisterInfos = list;
					num2 = 2;
					List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
					CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
					Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
					num = 0;
					*span2[num] = new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnRouletteTypeSwitch));
					num++;
					*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnRouletteTypeSwitch));
					this.BtnBindInfo = list2;
					return;
				}
			}
			else
			{
				int num = 1;
				List<ValueTuple<int, Type>> list3 = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list3, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list3);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
				this.ComponentRegisterInfos = list3;
			}
		}

		// Token: 0x06032B23 RID: 207651 RVA: 0x00BD454C File Offset: 0x00BD274C
		protected override void OnBeforeCreate()
		{
			UiInteractLogReport.RecordRouletteOpen();
		}

		// Token: 0x06032B24 RID: 207652 RVA: 0x00BD4554 File Offset: 0x00BD2754
		protected override UniTask OnBeforeStartAsync()
		{
			RouletteMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RouletteMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06032B25 RID: 207653 RVA: 0x00BD4598 File Offset: 0x00BD2798
		protected override void OnStart()
		{
			this.ViewProxy.Start();
			this.RefreshRouletteType();
			if (Info.Instance.OperationType == EOperationType.Desktop)
			{
				bool panelSwitchOpen = this.ViewProxy.GetPanelSwitchOpen();
				base.GetItem(1).SetUIActive(panelSwitchOpen);
				this.SetTips();
			}
			this.SetRouletteParam();
			float? floatConfig = ConfigCommonParamById.GetFloatConfig("Roulette_Main_Gamepad_DeadLimit");
			Vector2D beginPos = Info.Instance.IsInKeyBoard() ? Vector2D.Create(base.GetRootItem().GetPositionInScreen(true)) : null;
			this.InputManager = RouletteInputManager.CreateInput(Info.Instance.InputControllerMainType, beginPos, null, this.ViewProxy.TouchId, floatConfig);
			this.InputManager.BindEvent();
			this.InputManager.OnInit();
			this.InputManager.RouletteViewType = ERouletteViewType.Main;
			this.InputManager.SetEndInputEvent(delegate
			{
				this.CloseSelf(true);
			});
			this.BlockOperation();
			this.InputManager.ActivateInput(true);
			this.ViewProxy.AddEventListenerByStart();
		}

		// Token: 0x06032B26 RID: 207654 RVA: 0x00BD469A File Offset: 0x00BD289A
		protected override void OnBeforeShow()
		{
			this.ViewProxy.BeforeShow();
			RenderModuleController.Instance.GlobalTimeDilation = 0.1f;
		}

		// Token: 0x06032B27 RID: 207655 RVA: 0x00BD46B6 File Offset: 0x00BD28B6
		private void BlockOperation()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.ExploreRoulette, new EBattleUiChild[]
			{
				EBattleUiChild.InteractionHint
			}, false, true, 0);
			EventSystem.Instance.Emit<bool>(EEventName.OnRouletteViewVisibleChanged, true);
		}

		// Token: 0x06032B28 RID: 207656 RVA: 0x00BD46E8 File Offset: 0x00BD28E8
		protected override void OnBeforeDestroy()
		{
			this.ViewProxy.RemoveEventListenerByStart();
			this.RouletteUiItem = null;
			this.ViewProxy.Destroy();
			if (this.InputManager != null)
			{
				this.InputManager.Destroy();
				this.InputManager = null;
			}
		}

		// Token: 0x06032B29 RID: 207657 RVA: 0x00BD4721 File Offset: 0x00BD2921
		protected override void OnAfterDestroy()
		{
			RenderModuleController.Instance.GlobalTimeDilation = 1f;
			this.FreeOperation();
			UiInteractLogReport.RecordRouletteClose();
		}

		// Token: 0x06032B2A RID: 207658 RVA: 0x00BD473D File Offset: 0x00BD293D
		private void FreeOperation()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.ExploreRoulette, new EBattleUiChild[]
			{
				EBattleUiChild.InteractionHint
			}, true, true, 0);
			EventSystem.Instance.Emit<bool>(EEventName.OnRouletteViewVisibleChanged, false);
		}

		// Token: 0x06032B2B RID: 207659 RVA: 0x00BD4770 File Offset: 0x00BD2970
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<EInputControllerMainType, EInputControllerMainType>(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.InputControllerMainTypeChange));
			EventSystem.Instance.Add<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnCheckDisableInput));
			EventSystem.Instance.Add(EEventName.OpenRouletteSetView, new Action(this.OnOpenRouletteSetView));
			EventSystem.Instance.Add(EEventName.RouletteSwitchToggleComponentEmit, new Action(this.OnRouletteSwitchToggleComponentEmit));
			string actionName = this.ViewProxy.GetActionName();
			InputDistributeController.Instance.BindAction(actionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputRouletteAction));
			this.ViewProxy.AddEventListener();
		}

		// Token: 0x06032B2C RID: 207660 RVA: 0x00BD481C File Offset: 0x00BD2A1C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.InputControllerMainTypeChange, new Action<EInputControllerMainType, EInputControllerMainType>(this.InputControllerMainTypeChange));
			EventSystem.Instance.Remove(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnCheckDisableInput));
			EventSystem.Instance.Remove(EEventName.OpenRouletteSetView, new Action(this.OnOpenRouletteSetView));
			EventSystem.Instance.Remove(EEventName.RouletteSwitchToggleComponentEmit, new Action(this.OnRouletteSwitchToggleComponentEmit));
			string actionName = this.ViewProxy.GetActionName();
			InputDistributeController.Instance.UnBindAction(actionName, new TInputHandle<InputDistributeDefine.EActionType>(this.OnInputRouletteAction));
			this.ViewProxy.RemoveEventListener();
		}

		// Token: 0x06032B2D RID: 207661 RVA: 0x00BD48C7 File Offset: 0x00BD2AC7
		public void CloseSelf(bool emitSelectOn = true)
		{
			if (emitSelectOn)
			{
				this.RouletteComponent.TryEmitCurrentGridSelectOn();
			}
			base.CloseMe(null);
		}

		// Token: 0x06032B2E RID: 207662 RVA: 0x00BD48E0 File Offset: 0x00BD2AE0
		protected override void OnTick(float delta)
		{
			base.OnTick(delta);
			if (base.IsHideOrHiding)
			{
				return;
			}
			ValueTuple<int?, int?> valueTuple = this.InputManager.Tick(delta);
			int? item = valueTuple.Item1;
			int? item2 = valueTuple.Item2;
			this.RouletteComponent.Refresh(item, item2);
		}

		// Token: 0x06032B2F RID: 207663 RVA: 0x00BD4923 File Offset: 0x00BD2B23
		private void SetRouletteParam()
		{
			this.SetRouletteInputType();
			this.SetRoulettePlatformType();
			this.SetRouletteType();
			this.RouletteComponent.SetAllGridToggleSelfInteractive(false);
		}

		// Token: 0x06032B30 RID: 207664 RVA: 0x00BD4943 File Offset: 0x00BD2B43
		private void SetRouletteType()
		{
			this.RouletteComponent.RefreshRouletteType();
		}

		// Token: 0x06032B31 RID: 207665 RVA: 0x00BD4950 File Offset: 0x00BD2B50
		private void SetRoulettePlatformType()
		{
			this.RouletteComponent.RefreshRoulettePlatformType();
		}

		// Token: 0x06032B32 RID: 207666 RVA: 0x00BD495D File Offset: 0x00BD2B5D
		private void SetRouletteInputType()
		{
			this.RouletteComponent.RefreshRouletteInputType();
		}

		// Token: 0x06032B33 RID: 207667 RVA: 0x00BD496C File Offset: 0x00BD2B6C
		private void RefreshRouletteType()
		{
			if (Info.Instance.OperationType == EOperationType.Desktop)
			{
				bool canOpenAssembly = this.ViewProxy.GetCanOpenAssembly(this.ViewProxy.RouletteType);
				base.GetItem(5).SetUIActive(canOpenAssembly);
				base.GetExtendToggle(2).SetToggleState(this.ViewProxy.GetToggle1State().GetValueOrDefault(), false, false, false);
				base.GetExtendToggle(3).SetToggleState(this.ViewProxy.GetToggle2State().GetValueOrDefault(), false, false, false);
			}
		}

		// Token: 0x06032B34 RID: 207668 RVA: 0x00BD49F0 File Offset: 0x00BD2BF0
		private void OnRouletteTypeSwitch(EToggleState toggleState)
		{
			if (!this.ViewProxy.CanSwitchType)
			{
				return;
			}
			ValueTuple<int, int> currentIndexAndAngle = this.RouletteComponent.GetCurrentIndexAndAngle();
			int item = currentIndexAndAngle.Item1;
			int item2 = currentIndexAndAngle.Item2;
			this.ViewProxy.RouletteTypeSwitch();
			this.RefreshRouletteType();
			this.SetRouletteParam();
			this.RouletteComponent.Refresh(new int?(item), new int?(item2));
		}

		// Token: 0x06032B35 RID: 207669 RVA: 0x00BD4A54 File Offset: 0x00BD2C54
		private void InputControllerMainTypeChange(EInputControllerMainType eInputControllerMainType, EInputControllerMainType inputControllerMainType)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Phantom;
			ELogAuthor author = ELogAuthor.YYZ;
			string message = "检测到轮盘输入变化,关闭自身";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("新输入类型", Info.Instance.InputControllerType);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.CloseSelf(false);
		}

		// Token: 0x06032B36 RID: 207670 RVA: 0x00BD4A9D File Offset: 0x00BD2C9D
		private void OnCheckDisableInput(IReadOnlyList<InputDistributeTag> inputDistributeTags)
		{
			if (!InputDistributeModel.Instance.IsTagMatchAnyCurrentInputTag("UiInputRoot.ShortcutKeyTag", false))
			{
				this.CloseSelf(false);
			}
		}

		// Token: 0x06032B37 RID: 207671 RVA: 0x00BD4AB8 File Offset: 0x00BD2CB8
		private void SetTips()
		{
			string actionName = this.ViewProxy.GetActionName();
			UUIText text = base.GetText(4);
			text.SetUIActive(Info.Instance.IsInGamepad());
			LguiUtil.Instance.SetLocalTextNew(text, "Text_ToolsClosePC_Text", new <>z__ReadOnlySingleElementList<object>(RouletteModel.Instance.GetRouletteKeyRichText(actionName)));
		}

		// Token: 0x06032B38 RID: 207672 RVA: 0x00BD4B09 File Offset: 0x00BD2D09
		private void OnInputRouletteAction(string name, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType == InputDistributeDefine.EActionType.Release)
			{
				this.CloseSelf(true);
			}
		}

		// Token: 0x06032B39 RID: 207673 RVA: 0x00BD4B18 File Offset: 0x00BD2D18
		private void OnOpenRouletteSetView()
		{
			RouletteController.Instance.OpenAssemblyView(this.ViewProxy.RouletteType, null, null, null, false);
			this.CloseSelf(false);
		}

		// Token: 0x06032B3A RID: 207674 RVA: 0x00BD4B5E File Offset: 0x00BD2D5E
		private void OnRouletteSwitchToggleComponentEmit()
		{
			this.OnRouletteTypeSwitch(EToggleState.ETT_UnChecked);
		}

		// Token: 0x0401AFDC RID: 110556
		[Nullable(2)]
		private RouletteInputBase InputManager;

		// Token: 0x0401AFDD RID: 110557
		[Nullable(2)]
		public UUIItem RouletteUiItem;

		// Token: 0x0401AFDE RID: 110558
		private RouletteMainViewProxyBase ViewProxy;
	}
}
