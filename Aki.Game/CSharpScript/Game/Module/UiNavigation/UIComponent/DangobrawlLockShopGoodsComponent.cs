using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x020049FC RID: 18940
	public class DangobrawlLockShopGoodsComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x060312B7 RID: 201399 RVA: 0x00B67882 File Offset: 0x00B65A82
		public DangobrawlLockShopGoodsComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312B8 RID: 201400 RVA: 0x00B6788C File Offset: 0x00B65A8C
		protected override bool ShouldShow()
		{
			DangoBrawlSelection currentHovered = DangobrawlHotKeyComponentBase.CurrentHovered;
			bool flag = currentHovered != null && currentHovered.Source == EDragSourceKind.Shop && DangobrawlHotKeyComponentBase.CurrentHovered.Id > 0;
			bool flag2 = !DangobrawlHotKeyComponentBase.IsDragging;
			InteractionStateMachine fsm = DangobrawlHotKeyComponentBase.Fsm;
			bool flag3 = fsm != null && !fsm.IsHolding();
			return flag2 && flag3 && flag;
		}

		// Token: 0x060312B9 RID: 201401 RVA: 0x00B678DC File Offset: 0x00B65ADC
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add(EEventName.OnDangoBrawlShopLockChangedNotify, new Action<int, bool>(this.OnShopLockChanged));
		}

		// Token: 0x060312BA RID: 201402 RVA: 0x00B67900 File Offset: 0x00B65B00
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnDangoBrawlShopLockChangedNotify, new Action<int, bool>(this.OnShopLockChanged));
			base.OnRemoveEventListener();
		}

		// Token: 0x060312BB RID: 201403 RVA: 0x00B67924 File Offset: 0x00B65B24
		[NullableContext(1)]
		protected override void OnRefreshHotKeyTextId(UiNavigationViewHandle _)
		{
			base.SetHotKeyTextId(this.IsHoveredGoodsLocked() ? "UnlockTips" : "LockTips2");
			base.RefreshHotKeyNameText();
		}

		// Token: 0x060312BC RID: 201404 RVA: 0x00B67948 File Offset: 0x00B65B48
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

		// Token: 0x060312BD RID: 201405 RVA: 0x00B679D2 File Offset: 0x00B65BD2
		private void OnShopLockChanged(int uid, bool locked)
		{
			base.RequestRefresh();
		}

		// Token: 0x060312BE RID: 201406 RVA: 0x00B679DC File Offset: 0x00B65BDC
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
