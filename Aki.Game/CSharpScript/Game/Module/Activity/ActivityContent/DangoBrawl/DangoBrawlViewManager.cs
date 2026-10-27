using System;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Touch;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067C6 RID: 26566
	public class DangoBrawlViewManager
	{
		// Token: 0x0604228E RID: 270990 RVA: 0x0100B0CC File Offset: 0x010092CC
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

		// Token: 0x0604228F RID: 270991 RVA: 0x0100B139 File Offset: 0x01009339
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

		// Token: 0x06042290 RID: 270992 RVA: 0x0100B164 File Offset: 0x01009364
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

		// Token: 0x06042291 RID: 270993 RVA: 0x0100B1A4 File Offset: 0x010093A4
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

		// Token: 0x06042292 RID: 270994 RVA: 0x0100B1E4 File Offset: 0x010093E4
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

		// Token: 0x06042293 RID: 270995 RVA: 0x0100B24C File Offset: 0x0100944C
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

		// Token: 0x06042294 RID: 270996 RVA: 0x0100B28F File Offset: 0x0100948F
		public static bool TryBlockHoverEffect()
		{
			DangoBrawlTouchController touchController = DangoBrawlModel.Instance.GetTouchController();
			return touchController != null && touchController.IsDragging;
		}
	}
}
