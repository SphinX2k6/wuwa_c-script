using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067E4 RID: 26596
	public class DangoBrawlBackpackShopRateView : UiViewBase
	{
		// Token: 0x060423C1 RID: 271297 RVA: 0x01012340 File Offset: 0x01010540
		[NullableContext(1)]
		public unsafe DangoBrawlBackpackShopRateView(UiViewInfo viewInfo)
		{
			int num = 6;
			List<string> list = new List<string>(num);
			CollectionsMarshal.SetCount<string>(list, num);
			Span<string> span = CollectionsMarshal.AsSpan<string>(list);
			int num2 = 0;
			*span[num2] = "DangoBrawlBattleUIText_044";
			num2++;
			*span[num2] = "DangoBrawlBattleUIText_045";
			num2++;
			*span[num2] = "DangoBrawlBattleUIText_046";
			num2++;
			*span[num2] = "DangoBrawlBattleUIText_047";
			num2++;
			*span[num2] = "DangoBrawlBattleUIText_048";
			num2++;
			*span[num2] = "DangoBrawlBattleUIText_043";
			this.RateTitleList = list;
			base..ctor(viewInfo);
		}

		// Token: 0x060423C2 RID: 271298 RVA: 0x010123E8 File Offset: 0x010105E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060423C3 RID: 271299 RVA: 0x0101253C File Offset: 0x0101073C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlBackpackShopRateView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlBackpackShopRateView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060423C4 RID: 271300 RVA: 0x0101257F File Offset: 0x0101077F
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			childPopView.SetTitleByTextIdAndArg("DangoBrawlBattleUIText_037", Array.Empty<object>());
		}

		// Token: 0x060423C5 RID: 271301 RVA: 0x0101259C File Offset: 0x0101079C
		private UniTask CreateRateItems()
		{
			DangoBrawlBackpackShopRateView.<CreateRateItems>d__9 <CreateRateItems>d__;
			<CreateRateItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRateItems>d__.<>4__this = this;
			<CreateRateItems>d__.<>1__state = -1;
			<CreateRateItems>d__.<>t__builder.Start<DangoBrawlBackpackShopRateView.<CreateRateItems>d__9>(ref <CreateRateItems>d__);
			return <CreateRateItems>d__.<>t__builder.Task;
		}

		// Token: 0x060423C6 RID: 271302 RVA: 0x010125E0 File Offset: 0x010107E0
		private void RefreshView()
		{
			DangoBrawlRound? roundConfigById = DangoBrawlConfig.Instance.GetRoundConfigById(this.Round);
			if (roundConfigById == null)
			{
				return;
			}
			float[] shopRateListArray = roundConfigById.Value.GetShopRateListArray();
			for (int i = 0; i < shopRateListArray.Length; i++)
			{
				DangoBrawlBackpackShopRateItem dangoBrawlBackpackShopRateItem = this.RateItemList[i];
				if (i == 0 || i == shopRateListArray.Length - 1)
				{
					dangoBrawlBackpackShopRateItem.SetUiActive(false);
				}
				else
				{
					float rate = shopRateListArray[i];
					string title = this.RateTitleList[i];
					dangoBrawlBackpackShopRateItem.Refresh(rate, title);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), "DangoBrawlBattleUIText_050", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "DangoBrawlBattleUIText_039", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "DangoBrawlBattleUIText_043", Array.Empty<object>());
		}

		// Token: 0x0402290A RID: 141578
		[Nullable(1)]
		private List<DangoBrawlBackpackShopRateItem> RateItemList = new List<DangoBrawlBackpackShopRateItem>();

		// Token: 0x0402290B RID: 141579
		[Nullable(1)]
		private List<string> RateTitleList;

		// Token: 0x0402290C RID: 141580
		private int Round;

		// Token: 0x0200C8FB RID: 51451
		private enum EShopRateType
		{
			// Token: 0x0403CACA RID: 248522
			White,
			// Token: 0x0403CACB RID: 248523
			Green,
			// Token: 0x0403CACC RID: 248524
			Blue,
			// Token: 0x0403CACD RID: 248525
			Purple,
			// Token: 0x0403CACE RID: 248526
			Gold,
			// Token: 0x0403CACF RID: 248527
			ShopRate
		}

		// Token: 0x0200C8FC RID: 51452
		private enum EComponents
		{
			// Token: 0x0403CAD1 RID: 248529
			PnlRateItemWhite,
			// Token: 0x0403CAD2 RID: 248530
			PnlRateItemGreen,
			// Token: 0x0403CAD3 RID: 248531
			PnlRateItemBlue,
			// Token: 0x0403CAD4 RID: 248532
			PnlRateItemPurple,
			// Token: 0x0403CAD5 RID: 248533
			PnlRateItemGold,
			// Token: 0x0403CAD6 RID: 248534
			PnlRateItemDiscountRate,
			// Token: 0x0403CAD7 RID: 248535
			TxtRuleTitle,
			// Token: 0x0403CAD8 RID: 248536
			TxtRuleDesc,
			// Token: 0x0403CAD9 RID: 248537
			TxtDiscountRateTitle
		}
	}
}
