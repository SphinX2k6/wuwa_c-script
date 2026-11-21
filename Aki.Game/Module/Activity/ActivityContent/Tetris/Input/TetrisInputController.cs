using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.Input
{
	// Token: 0x02002FEF RID: 12271
	[NullableContext(1)]
	[Nullable(0)]
	internal sealed class TetrisInputController
	{
		// Token: 0x0601D1EF RID: 119279 RVA: 0x008E61FC File Offset: 0x008E43FC
		public TetrisInputController(int viewId, ITetrisDragHost host, [Nullable(new byte[]
		{
			1,
			2
		})] Func<UiNavigationViewHandle> getNavigationHandle)
		{
			this.Host = host;
			this.GetNavigationHandle = getNavigationHandle;
			this.PcAdapter = new TetrisPcInputAdapter(host);
			this.TouchAdapter = new TetrisTouchInputAdapter(host, viewId);
			this.GamepadAdapter = new TetrisGamepadInputAdapter(host, getNavigationHandle, new Func<bool>(this.CanRouteGamepadInput));
		}

		// Token: 0x17002E39 RID: 11833
		// (get) Token: 0x0601D1F0 RID: 119280 RVA: 0x008E6256 File Offset: 0x008E4456
		public bool CanRouteInput
		{
			get
			{
				return this.RefreshInputState();
			}
		}

		// Token: 0x0601D1F1 RID: 119281 RVA: 0x008E6260 File Offset: 0x008E4460
		public void Start()
		{
			if (this.IsStarted)
			{
				return;
			}
			this.IsStarted = true;
			bool? windowActivationState = Application.Instance.GetWindowActivationState();
			bool flag = false;
			this.IsApplicationActive = !(windowActivationState.GetValueOrDefault() == flag & windowActivationState != null);
			this.InputMode = Info.Instance.InputControllerMainType;
			Application.Instance.AddWindowActivationHandler(new Action<bool>(this.OnWindowActivationChanged));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillDeactivateDelegate, new Action(this.OnApplicationInactive));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillEnterBackgroundDelegate, new Action(this.OnApplicationInactive));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.OnApplicationActive));
			Application.Instance.AddApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasEnteredForegroundDelegate, new Action(this.OnApplicationActive));
			EventSystem.Instance.Add(EEventName.OnMotorMusicSortDragCancel, new Action(this.OnCancelInput));
			this.RefreshInputState();
		}

		// Token: 0x0601D1F2 RID: 119282 RVA: 0x008E634C File Offset: 0x008E454C
		public void Stop(ETetrisDragCancelReason reason)
		{
			if (!this.IsStarted)
			{
				return;
			}
			this.IsStarted = false;
			this.SuspendInput(reason);
			Application.Instance.RemoveWindowActivationHandler(new Action<bool>(this.OnWindowActivationChanged));
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillDeactivateDelegate, new Action(this.OnApplicationInactive));
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationWillEnterBackgroundDelegate, new Action(this.OnApplicationInactive));
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasReactivatedDelegate, new Action(this.OnApplicationActive));
			Application.Instance.RemoveApplicationHandler(EApplicationLifetimeDelegate.ApplicationHasEnteredForegroundDelegate, new Action(this.OnApplicationActive));
			EventSystem.Instance.Remove(EEventName.OnMotorMusicSortDragCancel, new Action(this.OnCancelInput));
			this.InputMode = EInputControllerMainType.None;
			this.NavigationHandle = null;
		}

		// Token: 0x0601D1F3 RID: 119283 RVA: 0x008E640C File Offset: 0x008E460C
		public void OnInputControllerMainTypeChange(EInputControllerMainType inputMode)
		{
			if (!this.IsStarted || this.InputMode == inputMode)
			{
				return;
			}
			this.SuspendInput(ETetrisDragCancelReason.InputModeChanged);
			this.InputMode = inputMode;
			this.NavigationHandle = null;
		}

		// Token: 0x0601D1F4 RID: 119284 RVA: 0x008E6435 File Offset: 0x008E4635
		public void OnTick(float delta)
		{
			if (this.RefreshInputState())
			{
				ITetrisInputAdapter activeAdapter = this.ActiveAdapter;
				if (activeAdapter != null)
				{
					activeAdapter.OnTick(delta);
				}
			}
			this.ClearInactiveDragRoute();
		}

		// Token: 0x0601D1F5 RID: 119285 RVA: 0x008E6458 File Offset: 0x008E4658
		[NullableContext(2)]
		public long OnBeginDrag(TetrisPointerSnapshot pointer, BlockInstance shape)
		{
			if (!this.CanRoutePointer(pointer) || this.Host.ActiveDragSessionId != null)
			{
				return 0L;
			}
			long num = this.ActiveAdapter.OnBeginDrag(pointer, shape);
			this.CaptureDragRoute(num, pointer);
			return num;
		}

		// Token: 0x0601D1F6 RID: 119286 RVA: 0x008E64A0 File Offset: 0x008E46A0
		public bool OnDrag(long sessionId, TetrisPointerSnapshot pointer)
		{
			if (!this.CanRoutePointer(pointer) || !this.MatchesDragRoute(sessionId, pointer))
			{
				return false;
			}
			bool result = this.ActiveAdapter.OnDrag(sessionId, pointer);
			this.ClearInactiveDragRoute();
			return result;
		}

		// Token: 0x0601D1F7 RID: 119287 RVA: 0x008E64CD File Offset: 0x008E46CD
		public bool OnEndDrag(long sessionId, TetrisPointerSnapshot pointer)
		{
			if (!this.CanRoutePointer(pointer) || !this.MatchesDragRoute(sessionId, pointer))
			{
				return false;
			}
			bool result = this.ActiveAdapter.OnEndDrag(sessionId, pointer);
			this.ClearInactiveDragRoute();
			return result;
		}

		// Token: 0x0601D1F8 RID: 119288 RVA: 0x008E64FC File Offset: 0x008E46FC
		public bool OnCancelDrag(long sessionId, ETetrisDragCancelReason reason)
		{
			if (this.IsStarted)
			{
				long? activeDragSessionId = this.Host.ActiveDragSessionId;
				if ((activeDragSessionId.GetValueOrDefault() == sessionId & activeDragSessionId != null) && (reason != ETetrisDragCancelReason.MissingPointerPosition || this.InputMode != EInputControllerMainType.Gamepad))
				{
					this.CancelDrag(reason);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0601D1F9 RID: 119289 RVA: 0x008E654C File Offset: 0x008E474C
		[NullableContext(2)]
		public void OnPointerDown(TetrisPointerSnapshot pointer, BlockInstance shape)
		{
			if (!this.CanRoutePointer(pointer))
			{
				return;
			}
			long? activeDragSessionId = this.Host.ActiveDragSessionId;
			if (activeDragSessionId != null)
			{
				long valueOrDefault = activeDragSessionId.GetValueOrDefault();
				if (!this.MatchesDragRoute(valueOrDefault, pointer))
				{
					return;
				}
			}
			this.ActiveAdapter.OnPointerDown(pointer, shape);
			if (activeDragSessionId == null)
			{
				long? activeDragSessionId2 = this.Host.ActiveDragSessionId;
				if (activeDragSessionId2 != null)
				{
					long valueOrDefault2 = activeDragSessionId2.GetValueOrDefault();
					this.CaptureDragRoute(valueOrDefault2, pointer);
				}
			}
			this.ClearInactiveDragRoute();
		}

		// Token: 0x0601D1FA RID: 119290 RVA: 0x008E65D0 File Offset: 0x008E47D0
		public void OnPointerUp(TetrisPointerSnapshot pointer)
		{
			if (!this.CanRoutePointer(pointer) || !this.MatchesDragRoute(this.NativeDragSessionId, pointer))
			{
				return;
			}
			this.ActiveAdapter.OnPointerUp(pointer);
			this.ClearInactiveDragRoute();
		}

		// Token: 0x0601D1FB RID: 119291 RVA: 0x008E6600 File Offset: 0x008E4800
		public void OnPickShape(int handIndex)
		{
			if (this.RefreshInputState())
			{
				ITetrisInputAdapter activeAdapter = this.ActiveAdapter;
				if (activeAdapter != null)
				{
					activeAdapter.OnPickShape(handIndex);
				}
			}
			this.ClearInactiveDragRoute();
		}

		// Token: 0x0601D1FC RID: 119292 RVA: 0x008E6624 File Offset: 0x008E4824
		public void CancelDrag(ETetrisDragCancelReason reason)
		{
			if (this.IsChangingInput)
			{
				return;
			}
			bool isRouteEnabled = this.IsRouteEnabled;
			this.IsChangingInput = true;
			try
			{
				this.IsRouteEnabled = false;
				this.NativeDragSessionId = 0L;
				this.NativeDragOrigin = default(TetrisPointerSnapshot);
				ITetrisInputAdapter activeAdapter = this.ActiveAdapter;
				if (activeAdapter != null)
				{
					activeAdapter.OnDragCancelled();
				}
				this.Host.CancelDrag(reason, null);
				this.ResetNavigationDrag();
				this.IsRouteEnabled = (isRouteEnabled && this.IsStarted && this.ActiveAdapter != null);
			}
			finally
			{
				this.IsChangingInput = false;
			}
		}

		// Token: 0x0601D1FD RID: 119293 RVA: 0x008E66CC File Offset: 0x008E48CC
		private bool RefreshInputState()
		{
			if (!this.IsStarted || this.IsChangingInput)
			{
				return false;
			}
			if (this.InputMode != Info.Instance.InputControllerMainType)
			{
				this.OnInputControllerMainTypeChange(Info.Instance.InputControllerMainType);
			}
			this.ClearInactiveDragRoute();
			bool flag2;
			if (this.IsApplicationActive)
			{
				bool? windowActivationState = Application.Instance.GetWindowActivationState();
				bool flag = false;
				flag2 = !(windowActivationState.GetValueOrDefault() == flag & windowActivationState != null);
			}
			else
			{
				flag2 = false;
			}
			bool flag3 = flag2;
			if (this.InputMode == EInputControllerMainType.None || !flag3 || !this.Host.CanHandleDragInput)
			{
				if (this.ActiveAdapter != null || this.Host.ActiveDragSessionId != null)
				{
					this.SuspendInput(flag3 ? ETetrisDragCancelReason.InputOwnershipLost : ETetrisDragCancelReason.ApplicationInactive);
				}
				return false;
			}
			UiNavigationViewHandle uiNavigationViewHandle = this.GetNavigationHandle();
			if (!this.IsInputReady(uiNavigationViewHandle))
			{
				if (this.ActiveAdapter != null || this.Host.ActiveDragSessionId != null)
				{
					this.SuspendInput(ETetrisDragCancelReason.InputOwnershipLost);
				}
				return false;
			}
			if (this.ActiveAdapter != null && (this.ActiveAdapter.InputMode != this.InputMode || this.NavigationHandle != uiNavigationViewHandle))
			{
				this.SuspendInput(ETetrisDragCancelReason.InputOwnershipLost);
			}
			if (this.ActiveAdapter == null)
			{
				this.NavigationHandle = uiNavigationViewHandle;
				ITetrisInputAdapter activeAdapter;
				switch (this.InputMode)
				{
				case EInputControllerMainType.Keyboard:
					activeAdapter = this.PcAdapter;
					break;
				case EInputControllerMainType.Gamepad:
					activeAdapter = this.GamepadAdapter;
					break;
				case EInputControllerMainType.Touch:
					activeAdapter = this.TouchAdapter;
					break;
				default:
					activeAdapter = null;
					break;
				}
				this.ActiveAdapter = activeAdapter;
				if (this.ActiveAdapter == null)
				{
					return false;
				}
				this.ActiveAdapter.Start();
				this.IsRouteEnabled = true;
			}
			return this.IsRouteEnabled;
		}

		// Token: 0x0601D1FE RID: 119294 RVA: 0x008E6868 File Offset: 0x008E4A68
		[NullableContext(2)]
		private bool IsInputReady(UiNavigationViewHandle navigationHandle)
		{
			TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
			if (lguiEventSystemActor == null || !lguiEventSystemActor.IsValid())
			{
				return false;
			}
			if (this.InputMode == EInputControllerMainType.Touch)
			{
				return true;
			}
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			if (pointerEventData == null || navigationHandle == null)
			{
				return false;
			}
			if (this.InputMode != EInputControllerMainType.Gamepad)
			{
				return pointerEventData.inputType == ELGUIPointerInputType.Pointer;
			}
			return navigationHandle.HasGamepadControlMouse() && pointerEventData.inputType == ELGUIPointerInputType.Navigation;
		}

		// Token: 0x0601D1FF RID: 119295 RVA: 0x008E68D4 File Offset: 0x008E4AD4
		private bool CanRoutePointer(in TetrisPointerSnapshot pointer)
		{
			bool flag = this.RefreshInputState() && pointer.InputMode == this.InputMode;
			if (flag)
			{
				bool flag2;
				switch (this.InputMode)
				{
				case EInputControllerMainType.Keyboard:
					flag2 = (pointer.PointerInputType == ELGUIPointerInputType.Pointer);
					break;
				case EInputControllerMainType.Gamepad:
					flag2 = (pointer.PointerInputType == ELGUIPointerInputType.Navigation);
					break;
				case EInputControllerMainType.Touch:
					flag2 = true;
					break;
				default:
					flag2 = false;
					break;
				}
				flag = flag2;
			}
			return flag;
		}

		// Token: 0x0601D200 RID: 119296 RVA: 0x008E693C File Offset: 0x008E4B3C
		private bool CanRouteGamepadInput()
		{
			return this.RefreshInputState() && this.ActiveAdapter == this.GamepadAdapter;
		}

		// Token: 0x0601D201 RID: 119297 RVA: 0x008E6958 File Offset: 0x008E4B58
		private bool MatchesDragRoute(long sessionId, in TetrisPointerSnapshot pointer)
		{
			if (sessionId != 0L && this.NativeDragSessionId == sessionId)
			{
				long? activeDragSessionId = this.Host.ActiveDragSessionId;
				if ((activeDragSessionId.GetValueOrDefault() == sessionId & activeDragSessionId != null) && this.NativeDragOrigin.InputMode == pointer.InputMode && this.NativeDragOrigin.PointerId == pointer.PointerId && this.NativeDragOrigin.SourceId == pointer.SourceId)
				{
					return this.NativeDragOrigin.SourceIndex == pointer.SourceIndex;
				}
			}
			return false;
		}

		// Token: 0x0601D202 RID: 119298 RVA: 0x008E69E4 File Offset: 0x008E4BE4
		private void CaptureDragRoute(long sessionId, in TetrisPointerSnapshot pointer)
		{
			if (sessionId != 0L)
			{
				long? activeDragSessionId = this.Host.ActiveDragSessionId;
				if (activeDragSessionId.GetValueOrDefault() == sessionId & activeDragSessionId != null)
				{
					this.NativeDragSessionId = sessionId;
					this.NativeDragOrigin = pointer;
					return;
				}
			}
		}

		// Token: 0x0601D203 RID: 119299 RVA: 0x008E6A2C File Offset: 0x008E4C2C
		private void ClearInactiveDragRoute()
		{
			if (this.NativeDragSessionId != 0L)
			{
				long? activeDragSessionId = this.Host.ActiveDragSessionId;
				long nativeDragSessionId = this.NativeDragSessionId;
				if (!(activeDragSessionId.GetValueOrDefault() == nativeDragSessionId & activeDragSessionId != null))
				{
					this.NativeDragSessionId = 0L;
					this.NativeDragOrigin = default(TetrisPointerSnapshot);
					this.ResetNavigationDrag();
				}
			}
		}

		// Token: 0x0601D204 RID: 119300 RVA: 0x008E6A84 File Offset: 0x008E4C84
		private void SuspendInput(ETetrisDragCancelReason reason)
		{
			if (this.IsChangingInput)
			{
				return;
			}
			this.IsChangingInput = true;
			try
			{
				this.IsRouteEnabled = false;
				this.NativeDragSessionId = 0L;
				this.NativeDragOrigin = default(TetrisPointerSnapshot);
				ITetrisInputAdapter activeAdapter = this.ActiveAdapter;
				if (activeAdapter != null)
				{
					activeAdapter.OnDragCancelled();
				}
				this.Host.CancelDrag(reason, null);
				ITetrisInputAdapter activeAdapter2 = this.ActiveAdapter;
				this.ActiveAdapter = null;
				if (activeAdapter2 != null)
				{
					activeAdapter2.Stop();
				}
				this.ResetNavigationDrag();
			}
			finally
			{
				this.IsChangingInput = false;
			}
		}

		// Token: 0x0601D205 RID: 119301 RVA: 0x008E6B1C File Offset: 0x008E4D1C
		private void ResetNavigationDrag()
		{
			if (this.InputMode == EInputControllerMainType.Gamepad)
			{
				UiNavigationViewHandle navigationHandle = this.NavigationHandle;
				if (navigationHandle != null)
				{
					TsUiNavigationPanelConfig mainPanel = navigationHandle.MainPanel;
					if (mainPanel != null && mainPanel.IsValid() && navigationHandle.MainPanel.ViewHandle == navigationHandle)
					{
						navigationHandle.NotifyNavigationMousePositionDragState(false);
						if (UiNavigationViewManager.Instance.GetCurrentViewHandle() == navigationHandle)
						{
							navigationHandle.SetGamepadMouseTrigger(false);
							TsLguiEventSystemActor lguiEventSystemActor = LguiEventSystemManager.Instance.LguiEventSystemActor;
							if (lguiEventSystemActor != null && lguiEventSystemActor.IsValid())
							{
								lguiEventSystemActor.SimulationPointerTrigger(0, false);
							}
						}
						return;
					}
				}
			}
		}

		// Token: 0x0601D206 RID: 119302 RVA: 0x008E6B9B File Offset: 0x008E4D9B
		private void OnCancelInput()
		{
			if (this.CanRouteInput)
			{
				this.CancelDrag(ETetrisDragCancelReason.Explicit);
			}
		}

		// Token: 0x0601D207 RID: 119303 RVA: 0x008E6BAC File Offset: 0x008E4DAC
		private void OnWindowActivationChanged(bool isActive)
		{
			this.IsApplicationActive = isActive;
			if (!isActive)
			{
				this.SuspendInput(ETetrisDragCancelReason.ApplicationInactive);
			}
		}

		// Token: 0x0601D208 RID: 119304 RVA: 0x008E6BBF File Offset: 0x008E4DBF
		private void OnApplicationInactive()
		{
			this.IsApplicationActive = false;
			this.SuspendInput(ETetrisDragCancelReason.ApplicationInactive);
		}

		// Token: 0x0601D209 RID: 119305 RVA: 0x008E6BCF File Offset: 0x008E4DCF
		private void OnApplicationActive()
		{
			this.IsApplicationActive = true;
		}

		// Token: 0x0400F55A RID: 62810
		private readonly ITetrisDragHost Host;

		// Token: 0x0400F55B RID: 62811
		[Nullable(new byte[]
		{
			1,
			2
		})]
		private readonly Func<UiNavigationViewHandle> GetNavigationHandle;

		// Token: 0x0400F55C RID: 62812
		private readonly TetrisPcInputAdapter PcAdapter;

		// Token: 0x0400F55D RID: 62813
		private readonly TetrisGamepadInputAdapter GamepadAdapter;

		// Token: 0x0400F55E RID: 62814
		private readonly TetrisTouchInputAdapter TouchAdapter;

		// Token: 0x0400F55F RID: 62815
		[Nullable(2)]
		private ITetrisInputAdapter ActiveAdapter;

		// Token: 0x0400F560 RID: 62816
		private bool IsStarted;

		// Token: 0x0400F561 RID: 62817
		private bool IsRouteEnabled;

		// Token: 0x0400F562 RID: 62818
		private bool IsChangingInput;

		// Token: 0x0400F563 RID: 62819
		private bool IsApplicationActive = true;

		// Token: 0x0400F564 RID: 62820
		private EInputControllerMainType InputMode;

		// Token: 0x0400F565 RID: 62821
		[Nullable(2)]
		private UiNavigationViewHandle NavigationHandle;

		// Token: 0x0400F566 RID: 62822
		private long NativeDragSessionId;

		// Token: 0x0400F567 RID: 62823
		private TetrisPointerSnapshot NativeDragOrigin;
	}
}
