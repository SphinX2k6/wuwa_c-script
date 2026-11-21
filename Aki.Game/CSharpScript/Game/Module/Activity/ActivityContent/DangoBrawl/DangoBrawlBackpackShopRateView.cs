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
	// Token: 0x02005734 RID: 22324
	public class DangoBrawlBackpackShopRateView : UiViewBase
	{
		// Token: 0x06036F17 RID: 225047 RVA: 0x00F537D8 File Offset: 0x00F519D8
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

		// Token: 0x06036F18 RID: 225048 RVA: 0x00F53880 File Offset: 0x00F51A80
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

		// Token: 0x06036F19 RID: 225049 RVA: 0x00F539D4 File Offset: 0x00F51BD4
		protected override UniTask OnBeforeStartAsync()
		{
			DangoBrawlBackpackShopRateView.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoBrawlBackpackShopRateView.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036F1A RID: 225050 RVA: 0x00F53A17 File Offset: 0x00F51C17
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			childPopView.SetTitleByTextIdAndArg("DangoBrawlBattleUIText_037", Array.Empty<object>());
		}

		// Token: 0x06036F1B RID: 225051 RVA: 0x00F53A34 File Offset: 0x00F51C34
		private UniTask CreateRateItems()
		{
			DangoBrawlBackpackShopRateView.<CreateRateItems>d__9 <CreateRateItems>d__;
			<CreateRateItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateRateItems>d__.<>4__this = this;
			<CreateRateItems>d__.<>1__state = -1;
			<CreateRateItems>d__.<>t__builder.Start<DangoBrawlBackpackShopRateView.<CreateRateItems>d__9>(ref <CreateRateItems>d__);
			return <CreateRateItems>d__.<>t__builder.Task;
		}

		// Token: 0x06036F1C RID: 225052 RVA: 0x00F53A78 File Offset: 0x00F51C78
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

		// Token: 0x0401D167 RID: 119143
		[Nullable(1)]
		private List<DangoBrawlBackpackShopRateItem> RateItemList = new List<DangoBrawlBackpackShopRateItem>();

		// Token: 0x0401D168 RID: 119144
		[Nullable(1)]
		private List<string> RateTitleList;

		// Token: 0x0401D169 RID: 119145
		private int Round;

		// Token: 0x0200B2CB RID: 45771
		private enum EShopRateType
		{
			// Token: 0x040373BF RID: 226239
			White,
			// Token: 0x040373C0 RID: 226240
			Green,
			// Token: 0x040373C1 RID: 226241
			Blue,
			// Token: 0x040373C2 RID: 226242
			Purple,
			// Token: 0x040373C3 RID: 226243
			Gold,
			// Token: 0x040373C4 RID: 226244
			ShopRate
		}

		// Token: 0x0200B2CC RID: 45772
		private enum EComponents
		{
			// Token: 0x040373C6 RID: 226246
			PnlRateItemWhite,
			// Token: 0x040373C7 RID: 226247
			PnlRateItemGreen,
			// Token: 0x040373C8 RID: 226248
			PnlRateItemBlue,
			// Token: 0x040373C9 RID: 226249
			PnlRateItemPurple,
			// Token: 0x040373CA RID: 226250
			PnlRateItemGold,
			// Token: 0x040373CB RID: 226251
			PnlRateItemDiscountRate,
			// Token: 0x040373CC RID: 226252
			TxtRuleTitle,
			// Token: 0x040373CD RID: 226253
			TxtRuleDesc,
			// Token: 0x040373CE RID: 226254
			TxtDiscountRateTitle
		}
	}
}
