using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Input
{
	// Token: 0x02002FEE RID: 12270
	[NullableContext(2)]
	[Nullable(0)]
	internal sealed class TetrisGamepadInputAdapter : TetrisNativeInputAdapter
	{
		// Token: 0x0601D1DF RID: 119263 RVA: 0x008E5B0C File Offset: 0x008E3D0C
		[NullableContext(1)]
		public TetrisGamepadInputAdapter(ITetrisDragHost host, [Nullable(new byte[]
		{
			1,
			2
		})] Func<UiNavigationViewHandle> getNavigationHandle, Func<bool> canRouteInput) : base(host)
		{
		}

		// Token: 0x17002E38 RID: 11832
		// (get) Token: 0x0601D1E0 RID: 119264 RVA: 0x008E5B23 File Offset: 0x008E3D23
		public override EInputControllerMainType InputMode
		{
			get
			{
				return EInputControllerMainType.Gamepad;
			}
		}

		// Token: 0x0601D1E1 RID: 119265 RVA: 0x008E5B28 File Offset: 0x008E3D28
		public override void Start()
		{
			TetrisGamepadInputAdapter.<>c__DisplayClass14_0 CS$<>8__locals1 = new TetrisGamepadInputAdapter.<>c__DisplayClass14_0();
			CS$<>8__locals1.<>4__this = this;
			if (!base.IsStarted)
			{
				UiNavigationViewHandle uiNavigationViewHandle = this.<getNavigationHandle>P();
				if (uiNavigationViewHandle != null)
				{
					TsUiNavigationPanelConfig mainPanel = uiNavigationViewHandle.MainPanel;
					if (mainPanel != null && mainPanel.IsValid() && uiNavigationViewHandle.MainPanel.ViewHandle == uiNavigationViewHandle && UiNavigationViewManager.Instance.GetCurrentViewHandle() == uiNavigationViewHandle)
					{
						this.LockedNavigationHandle = uiNavigationViewHandle;
						uiNavigationViewHandle.SetLockUseDragState(true);
						this.OwnsNavigationLock = true;
						this.ConfirmPhase = TetrisGamepadInputAdapter.EConfirmPhase.None;
						this.ConfirmSessionId = 0L;
						this.RequiresConfirmRelease = InputDistributeModel.Instance.IsActionInPress("UI键盘F手柄A");
						this.PresentedSessionId = null;
						base.Start();
						TetrisGamepadInputAdapter.<>c__DisplayClass14_0 CS$<>8__locals2 = CS$<>8__locals1;
						long activationId = this.ActivationId + 1L;
						this.ActivationId = activationId;
						CS$<>8__locals2.activationId = activationId;
						this.ConfirmActionHandler = delegate(string actionName, InputDistributeDefine.EActionType actionType, InputIdentification identification)
						{
							CS$<>8__locals1.<>4__this.OnConfirmAction(CS$<>8__locals1.activationId, actionType);
						};
						InputDistributeController.Instance.BindActionIgnoreLimit("UI键盘F手柄A", this.ConfirmActionHandler);
						this.SyncDragPresentation();
						return;
					}
				}
			}
		}

		// Token: 0x0601D1E2 RID: 119266 RVA: 0x008E5C1C File Offset: 0x008E3E1C
		public override void Stop()
		{
			if (!base.IsStarted)
			{
				return;
			}
			base.Stop();
			this.ActivationId += 1L;
			TInputHandle<InputDistributeDefine.EActionType> confirmActionHandler = this.ConfirmActionHandler;
			if (confirmActionHandler != null)
			{
				this.ConfirmActionHandler = null;
				InputDistributeController.Instance.UnBindActionIgnoreLimit("UI键盘F手柄A", confirmActionHandler);
			}
			this.ConfirmPhase = TetrisGamepadInputAdapter.EConfirmPhase.None;
			this.ConfirmSessionId = 0L;
			this.RequiresConfirmRelease = false;
			this.PresentedSessionId = null;
			if (this.IsOwnHandleValid())
			{
				this.LockedNavigationHandle.NotifyNavigationMousePositionDragState(false);
				if (UiNavigationViewManager.Instance.GetCurrentViewHandle() == this.LockedNavigationHandle)
				{
					this.LockedNavigationHandle.SetGamepadMouseTrigger(false);
				}
				if (this.OwnsNavigationLock)
				{
					this.LockedNavigationHandle.SetLockUseDragState(false);
				}
			}
			this.OwnsNavigationLock = false;
			this.LockedNavigationHandle = null;
			base.Host.SetGamepadDragging(false);
		}

		// Token: 0x0601D1E3 RID: 119267 RVA: 0x008E5CEC File Offset: 0x008E3EEC
		public override void OnDragCancelled()
		{
			bool flag = this.ConfirmPhase > TetrisGamepadInputAdapter.EConfirmPhase.None;
			this.RequiresConfirmRelease |= (flag || InputDistributeModel.Instance.IsActionInPress("UI键盘F手柄A"));
			this.ConfirmPhase = TetrisGamepadInputAdapter.EConfirmPhase.None;
			this.ConfirmSessionId = 0L;
		}

		// Token: 0x0601D1E4 RID: 119268 RVA: 0x008E5D34 File Offset: 0x008E3F34
		public override long OnBeginDrag(in TetrisPointerSnapshot pointer, BlockInstance shape)
		{
			return 0L;
		}

		// Token: 0x0601D1E5 RID: 119269 RVA: 0x008E5D38 File Offset: 0x008E3F38
		public override bool OnDrag(long sessionId, in TetrisPointerSnapshot pointer)
		{
			return false;
		}

		// Token: 0x0601D1E6 RID: 119270 RVA: 0x008E5D3B File Offset: 0x008E3F3B
		public override bool OnEndDrag(long sessionId, in TetrisPointerSnapshot pointer)
		{
			return false;
		}

		// Token: 0x0601D1E7 RID: 119271 RVA: 0x008E5D40 File Offset: 0x008E3F40
		public override void OnTick(float delta)
		{
			if (!this.CanAcceptInput())
			{
				return;
			}
			bool flag = InputDistributeModel.Instance.IsActionInPress("UI键盘F手柄A");
			long? activeDragSessionId;
			if (this.ConfirmPhase != TetrisGamepadInputAdapter.EConfirmPhase.None)
			{
				if (flag)
				{
					if (this.ConfirmSessionId == 0L)
					{
						goto IL_59;
					}
					activeDragSessionId = base.Host.ActiveDragSessionId;
					long confirmSessionId = this.ConfirmSessionId;
					if (activeDragSessionId.GetValueOrDefault() == confirmSessionId & activeDragSessionId != null)
					{
						goto IL_59;
					}
				}
				this.OnDragCancelled();
			}
			IL_59:
			if (!flag)
			{
				this.RequiresConfirmRelease = false;
			}
			activeDragSessionId = base.Host.ActiveDragSessionId;
			if (activeDragSessionId != null)
			{
				long valueOrDefault = activeDragSessionId.GetValueOrDefault();
				FVector pointerPosition;
				ETetrisDragCancelReason reason;
				if (!TetrisGamepadInputAdapter.TryGetPointerPosition(out pointerPosition, out reason))
				{
					this.CancelSession(valueOrDefault, reason);
					return;
				}
				if (!base.Host.UpdateDrag(valueOrDefault, pointerPosition))
				{
					this.OnDragCancelled();
				}
			}
			this.SyncDragPresentation();
		}

		// Token: 0x0601D1E8 RID: 119272 RVA: 0x008E5E00 File Offset: 0x008E4000
		public override void OnPickShape(int handIndex)
		{
			TetrisPointerSnapshot tetrisPointerSnapshot;
			BlockInstance shape;
			if (!this.CanAcceptInput() || base.Host.CurrentDragHandIndex == handIndex || !base.Host.TryGetHandPointer(handIndex, out tetrisPointerSnapshot, out shape) || tetrisPointerSnapshot.InputMode != this.InputMode || tetrisPointerSnapshot.PointerInputType != ELGUIPointerInputType.Navigation)
			{
				return;
			}
			long? activeDragSessionId = base.Host.ActiveDragSessionId;
			if (activeDragSessionId != null)
			{
				long valueOrDefault = activeDragSessionId.GetValueOrDefault();
				if (base.Host.TryReplaceDragShape(valueOrDefault, handIndex))
				{
					base.Host.UpdateDrag(valueOrDefault, tetrisPointerSnapshot.PointerPosition);
				}
			}
			else
			{
				long num;
				base.Host.TryBeginDrag(tetrisPointerSnapshot, shape, out num);
			}
			this.SyncDragPresentation();
		}

		// Token: 0x0601D1E9 RID: 119273 RVA: 0x008E5EA8 File Offset: 0x008E40A8
		private void OnConfirmAction(long activationId, InputDistributeDefine.EActionType actionType)
		{
			if (activationId != this.ActivationId || !this.CanAcceptInput() || activationId != this.ActivationId)
			{
				return;
			}
			if (actionType == InputDistributeDefine.EActionType.Press)
			{
				if (this.RequiresConfirmRelease || this.ConfirmPhase != TetrisGamepadInputAdapter.EConfirmPhase.None)
				{
					return;
				}
				this.RequiresConfirmRelease = true;
				long? activeDragSessionId = base.Host.ActiveDragSessionId;
				if (activeDragSessionId != null)
				{
					long valueOrDefault = activeDragSessionId.GetValueOrDefault();
					this.ConfirmPhase = TetrisGamepadInputAdapter.EConfirmPhase.Place;
					this.ConfirmSessionId = valueOrDefault;
				}
				else
				{
					this.ConfirmPhase = TetrisGamepadInputAdapter.EConfirmPhase.Pick;
					this.ConfirmSessionId = 0L;
					TetrisPointerSnapshot tetrisPointerSnapshot;
					BlockInstance shape;
					long confirmSessionId;
					if (base.Host.TryGetHitHandPointer(out tetrisPointerSnapshot, out shape) && base.Host.TryBeginDrag(tetrisPointerSnapshot, shape, out confirmSessionId))
					{
						this.ConfirmSessionId = confirmSessionId;
					}
				}
				this.SyncDragPresentation();
				return;
			}
			else
			{
				if (actionType != InputDistributeDefine.EActionType.Release)
				{
					return;
				}
				int confirmPhase = (int)this.ConfirmPhase;
				long confirmSessionId2 = this.ConfirmSessionId;
				this.ConfirmPhase = TetrisGamepadInputAdapter.EConfirmPhase.None;
				this.ConfirmSessionId = 0L;
				this.RequiresConfirmRelease = false;
				if (confirmPhase == 2 && confirmSessionId2 != 0L)
				{
					long? activeDragSessionId = base.Host.ActiveDragSessionId;
					long num = confirmSessionId2;
					if (activeDragSessionId.GetValueOrDefault() == num & activeDragSessionId != null)
					{
						FVector pointerPosition;
						ETetrisDragCancelReason reason;
						if (TetrisGamepadInputAdapter.TryGetPointerPosition(out pointerPosition, out reason))
						{
							base.Host.CompleteDrag(confirmSessionId2, pointerPosition);
						}
						else
						{
							this.CancelSession(confirmSessionId2, reason);
						}
					}
				}
				this.SyncDragPresentation();
				return;
			}
		}

		// Token: 0x0601D1EA RID: 119274 RVA: 0x008E5FDC File Offset: 0x008E41DC
		private bool CanAcceptInput()
		{
			return base.IsStarted && this.<canRouteInput>P() && base.IsStarted && base.Host.CanHandleDragInput && Info.Instance.InputControllerMainType == this.InputMode && this.OwnsNavigationLock && this.IsOwnHandleValid() && this.<getNavigationHandle>P() == this.LockedNavigationHandle && UiNavigationViewManager.Instance.GetCurrentViewHandle() == this.LockedNavigationHandle;
		}

		// Token: 0x0601D1EB RID: 119275 RVA: 0x008E605C File Offset: 0x008E425C
		private bool IsOwnHandleValid()
		{
			UiNavigationViewHandle lockedNavigationHandle = this.LockedNavigationHandle;
			bool flag;
			if (lockedNavigationHandle == null)
			{
				flag = false;
			}
			else
			{
				TsUiNavigationPanelConfig mainPanel = lockedNavigationHandle.MainPanel;
				flag = ((mainPanel != null) ? new bool?(mainPanel.IsValid()) : null).GetValueOrDefault();
			}
			return flag && this.LockedNavigationHandle.MainPanel.ViewHandle == this.LockedNavigationHandle;
		}

		// Token: 0x0601D1EC RID: 119276 RVA: 0x008E60B8 File Offset: 0x008E42B8
		private static bool TryGetPointerPosition(out FVector pointerPosition, out ETetrisDragCancelReason reason)
		{
			pointerPosition = default(FVector);
			reason = ETetrisDragCancelReason.MissingPointerPosition;
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor != null && lguiEventSystemActor.IsValid())
			{
				ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
				if (pointerEventData != null)
				{
					if (pointerEventData.inputType != ELGUIPointerInputType.Navigation)
					{
						reason = ETetrisDragCancelReason.InputOwnershipLost;
						return false;
					}
					pointerPosition = pointerEventData.pointerPosition;
					if (!float.IsFinite(pointerPosition.X) || !float.IsFinite(pointerPosition.Y))
					{
						reason = ETetrisDragCancelReason.InvalidPointerPosition;
						return false;
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x0601D1ED RID: 119277 RVA: 0x008E6131 File Offset: 0x008E4331
		private void CancelSession(long sessionId, ETetrisDragCancelReason reason)
		{
			this.OnDragCancelled();
			base.Host.CancelDrag(reason, new long?(sessionId));
			this.SyncDragPresentation();
		}

		// Token: 0x0601D1EE RID: 119278 RVA: 0x008E6154 File Offset: 0x008E4354
		private void SyncDragPresentation()
		{
			if (!this.IsOwnHandleValid())
			{
				return;
			}
			long? activeDragSessionId = base.Host.ActiveDragSessionId;
			bool flag = activeDragSessionId != null;
			long? presentedSessionId = this.PresentedSessionId;
			long? num = activeDragSessionId;
			bool flag2 = !(presentedSessionId.GetValueOrDefault() == num.GetValueOrDefault() & presentedSessionId != null == (num != null));
			if (flag2 || this.LockedNavigationHandle.IsNavigationMousePositionDragging() != flag)
			{
				this.LockedNavigationHandle.NotifyNavigationMousePositionDragState(flag);
				if (UiNavigationViewManager.Instance.GetCurrentViewHandle() == this.LockedNavigationHandle)
				{
					this.LockedNavigationHandle.SetGamepadMouseTrigger(flag);
				}
			}
			if (flag2)
			{
				base.Host.SetGamepadDragging(flag);
			}
			this.PresentedSessionId = activeDragSessionId;
		}

		// Token: 0x0400F550 RID: 62800
		[Nullable(new byte[]
		{
			1,
			2
		})]
		[CompilerGenerated]
		private Func<UiNavigationViewHandle> <getNavigationHandle>P = getNavigationHandle;

		// Token: 0x0400F551 RID: 62801
		[Nullable(1)]
		[CompilerGenerated]
		private Func<bool> <canRouteInput>P = canRouteInput;

		// Token: 0x0400F552 RID: 62802
		private UiNavigationViewHandle LockedNavigationHandle;

		// Token: 0x0400F553 RID: 62803
		private bool OwnsNavigationLock;

		// Token: 0x0400F554 RID: 62804
		private long ActivationId;

		// Token: 0x0400F555 RID: 62805
		private TInputHandle<InputDistributeDefine.EActionType> ConfirmActionHandler;

		// Token: 0x0400F556 RID: 62806
		private TetrisGamepadInputAdapter.EConfirmPhase ConfirmPhase;

		// Token: 0x0400F557 RID: 62807
		private long ConfirmSessionId;

		// Token: 0x0400F558 RID: 62808
		private bool RequiresConfirmRelease;

		// Token: 0x0400F559 RID: 62809
		private long? PresentedSessionId;

		// Token: 0x02008C63 RID: 35939
		[NullableContext(0)]
		private enum EConfirmPhase
		{
			// Token: 0x0402C6E3 RID: 181987
			None,
			// Token: 0x0402C6E4 RID: 181988
			Pick,
			// Token: 0x0402C6E5 RID: 181989
			Place
		}
	}
}
