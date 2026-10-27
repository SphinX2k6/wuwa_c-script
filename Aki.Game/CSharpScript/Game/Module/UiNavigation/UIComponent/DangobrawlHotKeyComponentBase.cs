using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x020049F7 RID: 18935
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class DangobrawlHotKeyComponentBase : HotKeyComponent
	{
		// Token: 0x0603128D RID: 201357 RVA: 0x00B672AB File Offset: 0x00B654AB
		protected DangobrawlHotKeyComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x170079DE RID: 31198
		// (get) Token: 0x0603128E RID: 201358 RVA: 0x00B672B4 File Offset: 0x00B654B4
		protected static DangoBrawlTouchController Touch
		{
			get
			{
				DangoBrawlModel instance = DangoBrawlModel.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetTouchController();
			}
		}

		// Token: 0x170079DF RID: 31199
		// (get) Token: 0x0603128F RID: 201359 RVA: 0x00B672C6 File Offset: 0x00B654C6
		protected static InteractionStateMachine Fsm
		{
			get
			{
				DangoBrawlTouchController touch = DangobrawlHotKeyComponentBase.Touch;
				if (touch == null)
				{
					return null;
				}
				return touch.GetInteractionFsm();
			}
		}

		// Token: 0x170079E0 RID: 31200
		// (get) Token: 0x06031290 RID: 201360 RVA: 0x00B672D8 File Offset: 0x00B654D8
		protected static DangoBrawlOperationDispatcher Dispatcher
		{
			get
			{
				DangoBrawlModel instance = DangoBrawlModel.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetOperationDispatcher();
			}
		}

		// Token: 0x170079E1 RID: 31201
		// (get) Token: 0x06031291 RID: 201361 RVA: 0x00B672EA File Offset: 0x00B654EA
		protected static DangoBrawlItemViewRegistry Registry
		{
			get
			{
				DangoBrawlModel instance = DangoBrawlModel.Instance;
				if (instance == null)
				{
					return null;
				}
				return instance.GetViewRegistry();
			}
		}

		// Token: 0x170079E2 RID: 31202
		// (get) Token: 0x06031292 RID: 201362 RVA: 0x00B672FC File Offset: 0x00B654FC
		protected static EInputPlatform? InputPlatform
		{
			get
			{
				DangoBrawlTouchController touch = DangobrawlHotKeyComponentBase.Touch;
				if (touch == null)
				{
					return null;
				}
				return new EInputPlatform?(touch.GetInputPlatform());
			}
		}

		// Token: 0x170079E3 RID: 31203
		// (get) Token: 0x06031293 RID: 201363 RVA: 0x00B67326 File Offset: 0x00B65526
		protected static bool IsHolding
		{
			get
			{
				InteractionStateMachine fsm = DangobrawlHotKeyComponentBase.Fsm;
				return fsm != null && fsm.IsHolding();
			}
		}

		// Token: 0x170079E4 RID: 31204
		// (get) Token: 0x06031294 RID: 201364 RVA: 0x00B67338 File Offset: 0x00B65538
		protected static bool IsSticky
		{
			get
			{
				InteractionStateMachine fsm = DangobrawlHotKeyComponentBase.Fsm;
				return fsm != null && fsm.IsSticky();
			}
		}

		// Token: 0x170079E5 RID: 31205
		// (get) Token: 0x06031295 RID: 201365 RVA: 0x00B6734C File Offset: 0x00B6554C
		protected static bool IsDragging
		{
			get
			{
				DangoBrawlTouchController touch = DangobrawlHotKeyComponentBase.Touch;
				return touch != null && touch.DraggingUid != null;
			}
		}

		// Token: 0x170079E6 RID: 31206
		// (get) Token: 0x06031296 RID: 201366 RVA: 0x00B67374 File Offset: 0x00B65574
		protected static int? DraggingUid
		{
			get
			{
				DangoBrawlTouchController touch = DangobrawlHotKeyComponentBase.Touch;
				if (touch == null)
				{
					return null;
				}
				return touch.DraggingUid;
			}
		}

		// Token: 0x170079E7 RID: 31207
		// (get) Token: 0x06031297 RID: 201367 RVA: 0x00B6739C File Offset: 0x00B6559C
		protected static int? FsmSourceUid
		{
			get
			{
				DangoBrawlTouchController touch = DangobrawlHotKeyComponentBase.Touch;
				if (touch == null)
				{
					return null;
				}
				return touch.FsmSourceUid;
			}
		}

		// Token: 0x170079E8 RID: 31208
		// (get) Token: 0x06031298 RID: 201368 RVA: 0x00B673C4 File Offset: 0x00B655C4
		protected static int CurrentOperatingUid
		{
			get
			{
				int? draggingUid = DangobrawlHotKeyComponentBase.DraggingUid;
				if (draggingUid == null)
				{
					return DangobrawlHotKeyComponentBase.FsmSourceUid.GetValueOrDefault(-1);
				}
				return draggingUid.GetValueOrDefault();
			}
		}

		// Token: 0x170079E9 RID: 31209
		// (get) Token: 0x06031299 RID: 201369 RVA: 0x00B673F6 File Offset: 0x00B655F6
		protected static DangoBrawlSelection CurrentSelection
		{
			get
			{
				DangoBrawlTouchController touch = DangobrawlHotKeyComponentBase.Touch;
				if (touch == null)
				{
					return null;
				}
				return touch.GetContext().GetSelection();
			}
		}

		// Token: 0x170079EA RID: 31210
		// (get) Token: 0x0603129A RID: 201370 RVA: 0x00B6740D File Offset: 0x00B6560D
		protected static DangoBrawlSelection CurrentHovered
		{
			get
			{
				DangoBrawlTouchController touch = DangobrawlHotKeyComponentBase.Touch;
				if (touch == null)
				{
					return null;
				}
				return touch.GetContext().GetHoveredItem();
			}
		}

		// Token: 0x0603129B RID: 201371
		protected abstract bool ShouldShow();

		// Token: 0x0603129C RID: 201372 RVA: 0x00B67424 File Offset: 0x00B65624
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			this.CachedViewHandle = viewHandle;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.ShouldShow(), false);
		}

		// Token: 0x0603129D RID: 201373 RVA: 0x00B6743B File Offset: 0x00B6563B
		protected void RequestRefresh()
		{
			UiNavigationViewHandle cachedViewHandle = this.CachedViewHandle;
			if (cachedViewHandle == null)
			{
				return;
			}
			cachedViewHandle.MarkRefreshHotKeyDirty();
		}

		// Token: 0x0603129E RID: 201374 RVA: 0x00B67450 File Offset: 0x00B65650
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlDragEnd, new Action(this.OnDragEnd));
		}

		// Token: 0x0603129F RID: 201375 RVA: 0x00B674F0 File Offset: 0x00B656F0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragEnd, new Action(this.OnDragEnd));
			base.OnRemoveEventListener();
		}

		// Token: 0x060312A0 RID: 201376 RVA: 0x00B6758F File Offset: 0x00B6578F
		private void OnInteractionStateChanged(EInteractionState state)
		{
			this.RequestRefresh();
		}

		// Token: 0x060312A1 RID: 201377 RVA: 0x00B67597 File Offset: 0x00B65797
		private void OnItemHoveredChange(int uid, EDragSourceKind source)
		{
			this.RequestRefresh();
		}

		// Token: 0x060312A2 RID: 201378 RVA: 0x00B6759F File Offset: 0x00B6579F
		private void OnSelectionChanged()
		{
			this.RequestRefresh();
		}

		// Token: 0x060312A3 RID: 201379 RVA: 0x00B675A7 File Offset: 0x00B657A7
		private void OnDragBegin(EDragSourceKind source, int configId)
		{
			this.RequestRefresh();
		}

		// Token: 0x060312A4 RID: 201380 RVA: 0x00B675AF File Offset: 0x00B657AF
		private void OnDragEnd()
		{
			this.RequestRefresh();
		}

		// Token: 0x0401A4E8 RID: 107752
		private UiNavigationViewHandle CachedViewHandle;
	}
}
