using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003976 RID: 14710
	public class DangobrawlLockShopGoodsComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x06025DED RID: 155117 RVA: 0x00AA283E File Offset: 0x00AA0A3E
		public DangobrawlLockShopGoodsComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025DEE RID: 155118 RVA: 0x00AA2848 File Offset: 0x00AA0A48
		protected override bool ShouldShow()
		{
			DangoBrawlSelection currentHovered = DangobrawlHotKeyComponentBase.CurrentHovered;
			bool flag = currentHovered != null && currentHovered.Source == EDragSourceKind.Shop && DangobrawlHotKeyComponentBase.CurrentHovered.Id > 0;
			bool flag2 = !DangobrawlHotKeyComponentBase.IsDragging;
			InteractionStateMachine fsm = DangobrawlHotKeyComponentBase.Fsm;
			bool flag3 = fsm != null && !fsm.IsHolding();
			return flag2 && flag3 && flag;
		}

		// Token: 0x06025DEF RID: 155119 RVA: 0x00AA2898 File Offset: 0x00AA0A98
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopLockChangedNotify, new Action<int, bool>(this.OnShopLockChanged));
		}

		// Token: 0x06025DF0 RID: 155120 RVA: 0x00AA28BC File Offset: 0x00AA0ABC
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopLockChangedNotify, new Action<int, bool>(this.OnShopLockChanged));
			base.OnRemoveEventListener();
		}

		// Token: 0x06025DF1 RID: 155121 RVA: 0x00AA28E0 File Offset: 0x00AA0AE0
		[NullableContext(1)]
		protected override void OnRefreshHotKeyTextId(UiNavigationViewHandle _)
		{
			base.SetHotKeyTextId(this.IsHoveredGoodsLocked() ? "UnlockTips" : "LockTips2");
			base.RefreshHotKeyNameText();
		}

		// Token: 0x06025DF2 RID: 155122 RVA: 0x00AA2904 File Offset: 0x00AA0B04
		private bool IsHoveredGoodsLocked()
		{
			DangoBrawlSelection currentHovered = DangobrawlHotKeyComponentBase.CurrentHovered;
			if (currentHovered == null || currentHovered.Source != EDragSourceKind.Shop || DangobrawlHotKeyComponentBase.CurrentHovered.Id <= 0)
			{
				return false;
			}
			ActivityDangoBrawlController instance = ActivityDangoBrawlController.Instance;
			bool? flag;
			if (instance == null)
			{
				flag = null;
			}
			else
			{
				ActivityDangoBrawlData myActivityData = instance.MyActivityData;
				if (myActivityData == null)
				{
					flag = null;
				}
				else
				{
					DangoBrawlShopSlotInfo slotInfo = myActivityData.ShopServerData.GetSlotInfo(DangobrawlHotKeyComponentBase.CurrentHovered.Id);
					flag = ((slotInfo != null) ? new bool?(slotInfo.Locked) : null);
				}
			}
			bool? flag2 = flag;
			return flag2.GetValueOrDefault();
		}

		// Token: 0x06025DF3 RID: 155123 RVA: 0x00AA298E File Offset: 0x00AA0B8E
		private void OnShopLockChanged(int uid, bool locked)
		{
			base.RequestRefresh();
		}

		// Token: 0x06025DF4 RID: 155124 RVA: 0x00AA2998 File Offset: 0x00AA0B98
		protected override void OnRelease(HotKeyMap config)
		{
			DangoBrawlSelection currentHovered = DangobrawlHotKeyComponentBase.CurrentHovered;
			if (currentHovered == null || currentHovered.Source != EDragSourceKind.Shop || DangobrawlHotKeyComponentBase.CurrentHovered.Id <= 0)
			{
				return;
			}
			AudioSystem.Instance.PostEvent("play_ui_tuanzi37_button_unlock");
			EventSystem.Instance.Emit<int>(EEventName.OnDangoBrawlShopToggleLock, DangobrawlHotKeyComponentBase.CurrentHovered.Id);
			EventSystem.Instance.Emit(EEventName.OnDangobrawlLockShopGoodsHotKeyNotify);
		}
	}
}
