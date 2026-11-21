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
	// Token: 0x02003C51 RID: 15441
	[NullableContext(1)]
	[Nullable(0)]
	public class RouletteMainView : UiTickViewBase
	{
		// Token: 0x170050B6 RID: 20662
		// (get) Token: 0x060278D4 RID: 162004 RVA: 0x00B190D2 File Offset: 0x00B172D2
		private RouletteComponentMain RouletteComponent
		{
			get
			{
				return this.ViewProxy.GetRouletteComponent();
			}
		}

		// Token: 0x060278D5 RID: 162005 RVA: 0x00B190DF File Offset: 0x00B172DF
		public RouletteMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060278D6 RID: 162006 RVA: 0x00B190E8 File Offset: 0x00B172E8
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

		// Token: 0x060278D7 RID: 162007 RVA: 0x00B192E4 File Offset: 0x00B174E4
		protected override void OnBeforeCreate()
		{
			UiInteractLogReport.RecordRouletteOpen();
		}

		// Token: 0x060278D8 RID: 162008 RVA: 0x00B192EC File Offset: 0x00B174EC
		protected override UniTask OnBeforeStartAsync()
		{
			RouletteMainView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RouletteMainView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060278D9 RID: 162009 RVA: 0x00B19330 File Offset: 0x00B17530
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

		// Token: 0x060278DA RID: 162010 RVA: 0x00B19432 File Offset: 0x00B17632
		protected override void OnBeforeShow()
		{
			this.ViewProxy.BeforeShow();
			RenderModuleController.Instance.GlobalTimeDilation = 0.1f;
		}

		// Token: 0x060278DB RID: 162011 RVA: 0x00B1944E File Offset: 0x00B1764E
		private void BlockOperation()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.ExploreRoulette, new EBattleUiChild[]
			{
				EBattleUiChild.InteractionHint
			}, false, true, 0);
			EventSystem.Instance.Emit<bool>(EEventName.OnRouletteViewVisibleChanged, true);
		}

		// Token: 0x060278DC RID: 162012 RVA: 0x00B19480 File Offset: 0x00B17680
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

		// Token: 0x060278DD RID: 162013 RVA: 0x00B194B9 File Offset: 0x00B176B9
		protected override void OnAfterDestroy()
		{
			RenderModuleController.Instance.GlobalTimeDilation = 1f;
			this.FreeOperation();
			UiInteractLogReport.RecordRouletteClose();
		}

		// Token: 0x060278DE RID: 162014 RVA: 0x00B194D5 File Offset: 0x00B176D5
		private void FreeOperation()
		{
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.ExploreRoulette, new EBattleUiChild[]
			{
				EBattleUiChild.InteractionHint
			}, true, true, 0);
			EventSystem.Instance.Emit<bool>(EEventName.OnRouletteViewVisibleChanged, false);
		}

		// Token: 0x060278DF RID: 162015 RVA: 0x00B19508 File Offset: 0x00B17708
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

		// Token: 0x060278E0 RID: 162016 RVA: 0x00B195B4 File Offset: 0x00B177B4
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

		// Token: 0x060278E1 RID: 162017 RVA: 0x00B1965F File Offset: 0x00B1785F
		public void CloseSelf(bool emitSelectOn = true)
		{
			if (emitSelectOn)
			{
				this.RouletteComponent.TryEmitCurrentGridSelectOn();
			}
			base.CloseMe(null);
		}

		// Token: 0x060278E2 RID: 162018 RVA: 0x00B19678 File Offset: 0x00B17878
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

		// Token: 0x060278E3 RID: 162019 RVA: 0x00B196BB File Offset: 0x00B178BB
		private void SetRouletteParam()
		{
			this.SetRouletteInputType();
			this.SetRoulettePlatformType();
			this.SetRouletteType();
			this.RouletteComponent.SetAllGridToggleSelfInteractive(false);
		}

		// Token: 0x060278E4 RID: 162020 RVA: 0x00B196DB File Offset: 0x00B178DB
		private void SetRouletteType()
		{
			this.RouletteComponent.RefreshRouletteType();
		}

		// Token: 0x060278E5 RID: 162021 RVA: 0x00B196E8 File Offset: 0x00B178E8
		private void SetRoulettePlatformType()
		{
			this.RouletteComponent.RefreshRoulettePlatformType();
		}

		// Token: 0x060278E6 RID: 162022 RVA: 0x00B196F5 File Offset: 0x00B178F5
		private void SetRouletteInputType()
		{
			this.RouletteComponent.RefreshRouletteInputType();
		}

		// Token: 0x060278E7 RID: 162023 RVA: 0x00B19704 File Offset: 0x00B17904
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

		// Token: 0x060278E8 RID: 162024 RVA: 0x00B19788 File Offset: 0x00B17988
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

		// Token: 0x060278E9 RID: 162025 RVA: 0x00B197EC File Offset: 0x00B179EC
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

		// Token: 0x060278EA RID: 162026 RVA: 0x00B19835 File Offset: 0x00B17A35
		private void OnCheckDisableInput(IReadOnlyList<InputDistributeTag> inputDistributeTags)
		{
			if (!InputDistributeModel.Instance.IsTagMatchAnyCurrentInputTag("UiInputRoot.ShortcutKeyTag", false))
			{
				this.CloseSelf(false);
			}
		}

		// Token: 0x060278EB RID: 162027 RVA: 0x00B19850 File Offset: 0x00B17A50
		private void SetTips()
		{
			string actionName = this.ViewProxy.GetActionName();
			UUIText text = base.GetText(4);
			text.SetUIActive(Info.Instance.IsInGamepad());
			LguiUtil.Instance.SetLocalTextNew(text, "Text_ToolsClosePC_Text", new <>z__ReadOnlySingleElementList<object>(RouletteModel.Instance.GetRouletteKeyRichText(actionName)));
		}

		// Token: 0x060278EC RID: 162028 RVA: 0x00B198A1 File Offset: 0x00B17AA1
		private void OnInputRouletteAction(string name, InputDistributeDefine.EActionType actionType, InputIdentification inputIdentification)
		{
			if (actionType == InputDistributeDefine.EActionType.Release)
			{
				this.CloseSelf(true);
			}
		}

		// Token: 0x060278ED RID: 162029 RVA: 0x00B198B0 File Offset: 0x00B17AB0
		private void OnOpenRouletteSetView()
		{
			RouletteController.Instance.OpenAssemblyView(this.ViewProxy.RouletteType, null, null, null, false);
			this.CloseSelf(false);
		}

		// Token: 0x060278EE RID: 162030 RVA: 0x00B198F6 File Offset: 0x00B17AF6
		private void OnRouletteSwitchToggleComponentEmit()
		{
			this.OnRouletteTypeSwitch(EToggleState.ETT_UnChecked);
		}

		// Token: 0x0401593D RID: 88381
		[Nullable(2)]
		private RouletteInputBase InputManager;

		// Token: 0x0401593E RID: 88382
		[Nullable(2)]
		public UUIItem RouletteUiItem;

		// Token: 0x0401593F RID: 88383
		private RouletteMainViewProxyBase ViewProxy;
	}
}
