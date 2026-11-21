using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Operation;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003971 RID: 14705
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class DangobrawlHotKeyComponentBase : HotKeyComponent
	{
		// Token: 0x06025DC3 RID: 155075 RVA: 0x00AA2267 File Offset: 0x00AA0467
		protected DangobrawlHotKeyComponentBase(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x17004D46 RID: 19782
		// (get) Token: 0x06025DC4 RID: 155076 RVA: 0x00AA2270 File Offset: 0x00AA0470
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

		// Token: 0x17004D47 RID: 19783
		// (get) Token: 0x06025DC5 RID: 155077 RVA: 0x00AA2282 File Offset: 0x00AA0482
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

		// Token: 0x17004D48 RID: 19784
		// (get) Token: 0x06025DC6 RID: 155078 RVA: 0x00AA2294 File Offset: 0x00AA0494
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

		// Token: 0x17004D49 RID: 19785
		// (get) Token: 0x06025DC7 RID: 155079 RVA: 0x00AA22A6 File Offset: 0x00AA04A6
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

		// Token: 0x17004D4A RID: 19786
		// (get) Token: 0x06025DC8 RID: 155080 RVA: 0x00AA22B8 File Offset: 0x00AA04B8
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

		// Token: 0x17004D4B RID: 19787
		// (get) Token: 0x06025DC9 RID: 155081 RVA: 0x00AA22E2 File Offset: 0x00AA04E2
		protected static bool IsHolding
		{
			get
			{
				InteractionStateMachine fsm = DangobrawlHotKeyComponentBase.Fsm;
				return fsm != null && fsm.IsHolding();
			}
		}

		// Token: 0x17004D4C RID: 19788
		// (get) Token: 0x06025DCA RID: 155082 RVA: 0x00AA22F4 File Offset: 0x00AA04F4
		protected static bool IsSticky
		{
			get
			{
				InteractionStateMachine fsm = DangobrawlHotKeyComponentBase.Fsm;
				return fsm != null && fsm.IsSticky();
			}
		}

		// Token: 0x17004D4D RID: 19789
		// (get) Token: 0x06025DCB RID: 155083 RVA: 0x00AA2308 File Offset: 0x00AA0508
		protected static bool IsDragging
		{
			get
			{
				DangoBrawlTouchController touch = DangobrawlHotKeyComponentBase.Touch;
				return touch != null && touch.DraggingUid != null;
			}
		}

		// Token: 0x17004D4E RID: 19790
		// (get) Token: 0x06025DCC RID: 155084 RVA: 0x00AA2330 File Offset: 0x00AA0530
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

		// Token: 0x17004D4F RID: 19791
		// (get) Token: 0x06025DCD RID: 155085 RVA: 0x00AA2358 File Offset: 0x00AA0558
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

		// Token: 0x17004D50 RID: 19792
		// (get) Token: 0x06025DCE RID: 155086 RVA: 0x00AA2380 File Offset: 0x00AA0580
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

		// Token: 0x17004D51 RID: 19793
		// (get) Token: 0x06025DCF RID: 155087 RVA: 0x00AA23B2 File Offset: 0x00AA05B2
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

		// Token: 0x17004D52 RID: 19794
		// (get) Token: 0x06025DD0 RID: 155088 RVA: 0x00AA23C9 File Offset: 0x00AA05C9
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

		// Token: 0x06025DD1 RID: 155089
		protected abstract bool ShouldShow();

		// Token: 0x06025DD2 RID: 155090 RVA: 0x00AA23E0 File Offset: 0x00AA05E0
		[NullableContext(1)]
		protected override void OnRefreshSelfHotKeyState(UiNavigationViewHandle viewHandle)
		{
			this.CachedViewHandle = viewHandle;
			base.SetVisibleMode(HotKeyViewDefine.ELogicMode.ListenerActive, this.ShouldShow(), false);
		}

		// Token: 0x06025DD3 RID: 155091 RVA: 0x00AA23F7 File Offset: 0x00AA05F7
		protected void RequestRefresh()
		{
			UiNavigationViewHandle cachedViewHandle = this.CachedViewHandle;
			if (cachedViewHandle == null)
			{
				return;
			}
			cachedViewHandle.MarkRefreshHotKeyDirty();
		}

		// Token: 0x06025DD4 RID: 155092 RVA: 0x00AA240C File Offset: 0x00AA060C
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			EventSystem.Instance.Add(EEventName.OnDangoBrawlDragEnd, new Action(this.OnDragEnd));
		}

		// Token: 0x06025DD5 RID: 155093 RVA: 0x00AA24AC File Offset: 0x00AA06AC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlInteractionStateChanged, new Action<EInteractionState>(this.OnInteractionStateChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlItemHoveredChange, new Action<int, EDragSourceKind>(this.OnItemHoveredChange));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlSelectionChanged, new Action(this.OnSelectionChanged));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragBegin, new Action<EDragSourceKind, int>(this.OnDragBegin));
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlDragEnd, new Action(this.OnDragEnd));
			base.OnRemoveEventListener();
		}

		// Token: 0x06025DD6 RID: 155094 RVA: 0x00AA254B File Offset: 0x00AA074B
		private void OnInteractionStateChanged(EInteractionState state)
		{
			this.RequestRefresh();
		}

		// Token: 0x06025DD7 RID: 155095 RVA: 0x00AA2553 File Offset: 0x00AA0753
		private void OnItemHoveredChange(int uid, EDragSourceKind source)
		{
			this.RequestRefresh();
		}

		// Token: 0x06025DD8 RID: 155096 RVA: 0x00AA255B File Offset: 0x00AA075B
		private void OnSelectionChanged()
		{
			this.RequestRefresh();
		}

		// Token: 0x06025DD9 RID: 155097 RVA: 0x00AA2563 File Offset: 0x00AA0763
		private void OnDragBegin(EDragSourceKind source, int configId)
		{
			this.RequestRefresh();
		}

		// Token: 0x06025DDA RID: 155098 RVA: 0x00AA256B File Offset: 0x00AA076B
		private void OnDragEnd()
		{
			this.RequestRefresh();
		}

		// Token: 0x04014D5A RID: 85338
		private UiNavigationViewHandle CachedViewHandle;
	}
}
