using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x02003978 RID: 14712
	public class DangobrawlOpenCombineTipsComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x06025DF8 RID: 155128 RVA: 0x00AA2AD7 File Offset: 0x00AA0CD7
		public DangobrawlOpenCombineTipsComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025DF9 RID: 155129 RVA: 0x00AA2AE0 File Offset: 0x00AA0CE0
		protected override bool ShouldShow()
		{
			int hoveredConfigId = DangobrawlOpenCombineTipsComponent.GetHoveredConfigId();
			bool flag = hoveredConfigId > 0 && DangoBrawlCombineUtil.HasCombineInfo(hoveredConfigId);
			return DangobrawlHotKeyComponentBase.CurrentSelection == null && flag;
		}

		// Token: 0x06025DFA RID: 155130 RVA: 0x00AA2B0C File Offset: 0x00AA0D0C
		protected override void OnRelease(HotKeyMap config)
		{
			DangoBrawlSelection currentHovered = DangobrawlHotKeyComponentBase.CurrentHovered;
			if (currentHovered == null || currentHovered.Id <= 0)
			{
				return;
			}
			int hoveredConfigId = DangobrawlOpenCombineTipsComponent.GetHoveredConfigId();
			if (hoveredConfigId <= 0 || !DangoBrawlCombineUtil.HasCombineInfo(hoveredConfigId))
			{
				return;
			}
			bool flag = currentHovered.Source > EDragSourceKind.Shop;
			UiManager.Instance.OpenView(EUiViewName.DangoBrawlCombineView, new DangoBrawlCombineViewOpenData
			{
				FocusConfigId = hoveredConfigId,
				AllowCombine = flag,
				FocusUid = (flag ? currentHovered.Id : 0),
				UseActData = true,
				ShowIntoSelf = true,
				ShowSelfIntoOther = true
			}, null);
		}

		// Token: 0x06025DFB RID: 155131 RVA: 0x00AA2B94 File Offset: 0x00AA0D94
		private static int GetHoveredConfigId()
		{
			DangoBrawlSelection currentHovered = DangobrawlHotKeyComponentBase.CurrentHovered;
			if (currentHovered == null || currentHovered.Id <= 0)
			{
				return -1;
			}
			ActivityDangoBrawlController instance = ActivityDangoBrawlController.Instance;
			ActivityDangoBrawlData activityDangoBrawlData = (instance != null) ? instance.MyActivityData : null;
			if (activityDangoBrawlData == null)
			{
				return -1;
			}
			int result;
			switch (currentHovered.Source)
			{
			case EDragSourceKind.Shop:
				result = DangobrawlOpenCombineTipsComponent.GetShopHoveredConfigId(activityDangoBrawlData, currentHovered.Id);
				break;
			case EDragSourceKind.Bag:
			{
				DangoBrawlBackpackData bagpackData = activityDangoBrawlData.BagpackData;
				int? num;
				if (bagpackData == null)
				{
					num = null;
				}
				else
				{
					DangoBrawlBackpackItemData item = bagpackData.GetItem(currentHovered.Id);
					num = ((item != null) ? new int?(item.MyConfigId) : null);
				}
				int? num2 = num;
				result = num2.GetValueOrDefault(-1);
				break;
			}
			case EDragSourceKind.Bench:
			{
				DangoBrawlBenchData benchData = activityDangoBrawlData.BenchData;
				int? num3;
				if (benchData == null)
				{
					num3 = null;
				}
				else
				{
					DangoBrawlBenchItemData item2 = benchData.GetItem(currentHovered.Id);
					num3 = ((item2 != null) ? new int?(item2.MyConfigId) : null);
				}
				int? num2 = num3;
				result = num2.GetValueOrDefault(-1);
				break;
			}
			default:
				result = -1;
				break;
			}
			return result;
		}

		// Token: 0x06025DFC RID: 155132 RVA: 0x00AA2C8C File Offset: 0x00AA0E8C
		[NullableContext(1)]
		private static int GetShopHoveredConfigId(ActivityDangoBrawlData actData, int uid)
		{
			int shopGoodsSlotIndex = actData.GetShopGoodsSlotIndex(uid);
			RepeatedField<DangoBrawlShopSlotInfo> shopSlots = actData.ShopSlots;
			if (shopGoodsSlotIndex < 0 || shopGoodsSlotIndex >= shopSlots.Count)
			{
				return -1;
			}
			DangoBrawlBaseItemInfo item = shopSlots[shopGoodsSlotIndex].Item;
			if (item == null)
			{
				return -1;
			}
			return item.ConfigId;
		}
	}
}
