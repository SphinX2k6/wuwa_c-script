using System;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x02005716 RID: 22294
	public class DangoBrawlViewManager
	{
		// Token: 0x06036DE4 RID: 224740 RVA: 0x00F4C4B0 File Offset: 0x00F4A6B0
		public static bool TryBlockIfHolding(int? uid = null)
		{
			DangoBrawlTouchController touchController = DangoBrawlModel.Instance.GetTouchController();
			if (touchController == null)
			{
				return false;
			}
			if (!touchController.GetInteractionFsm().IsBlocking())
			{
				return false;
			}
			if (uid != null)
			{
				int value = uid.Value;
				int? fsmSourceUid = touchController.FsmSourceUid;
				if (value == fsmSourceUid.GetValueOrDefault() & fsmSourceUid != null)
				{
					return false;
				}
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips006", Array.Empty<object>());
			return true;
		}

		// Token: 0x06036DE5 RID: 224741 RVA: 0x00F4C51D File Offset: 0x00F4A71D
		public static bool TryBlockIfThreeChoose(bool showTips = true)
		{
			if (!ActivityDangoBrawlController.Instance.IsThreeChooseBlocking())
			{
				return false;
			}
			if (showTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips001", Array.Empty<object>());
			}
			return true;
		}

		// Token: 0x06036DE6 RID: 224742 RVA: 0x00F4C548 File Offset: 0x00F4A748
		public static bool TryBlockIfLayerMode(bool showTips = true)
		{
			DangoBrawlTouchController touchController = DangoBrawlModel.Instance.GetTouchController();
			if (touchController == null)
			{
				return false;
			}
			if (!touchController.IsLayerMode)
			{
				return false;
			}
			if (showTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips007", Array.Empty<object>());
			}
			return true;
		}

		// Token: 0x06036DE7 RID: 224743 RVA: 0x00F4C588 File Offset: 0x00F4A788
		public static bool TryBlockIfCombineUniqueWeapon(DangoBrawlCombineRowData data, bool showTips = true)
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			if (myActivityData == null)
			{
				return false;
			}
			bool flag = DangoBrawlCombineUtil.IsBlockedByUniqueWeapon(myActivityData, data);
			if (flag && showTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips008", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x06036DE8 RID: 224744 RVA: 0x00F4C5C8 File Offset: 0x00F4A7C8
		public static bool TryBlockIfOverWeight(bool showTips = true)
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			if (myActivityData == null)
			{
				return false;
			}
			DangoBrawlDataController dataController = DangoBrawlModel.Instance.GetDataController();
			int num = (dataController != null) ? dataController.GetViewCost() : 0;
			DangoBrawlFighterServerData selfFighter = myActivityData.FightersServerData.GetSelfFighter();
			int num2 = (selfFighter != null) ? selfFighter.Cost : 0;
			bool flag = num > num2;
			if (flag && showTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips002", Array.Empty<object>());
			}
			return flag;
		}

		// Token: 0x06036DE9 RID: 224745 RVA: 0x00F4C630 File Offset: 0x00F4A830
		public static bool TryBlockIfNoEnoughtCoin(int price, bool showTips = true)
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			if (myActivityData == null)
			{
				return false;
			}
			bool flag = price > myActivityData.ShopCoin;
			if (flag && showTips)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("DangoBrawlTips003", Array.Empty<object>());
				return true;
			}
			return flag;
		}

		// Token: 0x06036DEA RID: 224746 RVA: 0x00F4C673 File Offset: 0x00F4A873
		public static bool TryBlockHoverEffect()
		{
			DangoBrawlTouchController touchController = DangoBrawlModel.Instance.GetTouchController();
			return touchController != null && touchController.IsDragging;
		}
	}
}
