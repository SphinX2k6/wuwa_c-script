using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;
using CSharpScript.Game.Ui;
using Google.Protobuf.Collections;

namespace CSharpScript.Game.Module.UiNavigation.UIComponent
{
	// Token: 0x020049FE RID: 18942
	public class DangobrawlOpenCombineTipsComponent : DangobrawlHotKeyComponentBase
	{
		// Token: 0x060312C2 RID: 201410 RVA: 0x00B67B1B File Offset: 0x00B65D1B
		public DangobrawlOpenCombineTipsComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060312C3 RID: 201411 RVA: 0x00B67B24 File Offset: 0x00B65D24
		protected override bool ShouldShow()
		{
			int hoveredConfigId = DangobrawlOpenCombineTipsComponent.GetHoveredConfigId();
			bool flag = hoveredConfigId > 0 && DangoBrawlCombineUtil.HasCombineInfo(hoveredConfigId);
			return DangobrawlHotKeyComponentBase.CurrentSelection == null && flag;
		}

		// Token: 0x060312C4 RID: 201412 RVA: 0x00B67B50 File Offset: 0x00B65D50
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

		// Token: 0x060312C5 RID: 201413 RVA: 0x00B67BD8 File Offset: 0x00B65DD8
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

		// Token: 0x060312C6 RID: 201414 RVA: 0x00B67CD0 File Offset: 0x00B65ED0
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
