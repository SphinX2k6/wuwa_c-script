using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x0200585C RID: 22620
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class BossRushRewardItem : GridProxyAbstract<RewardContentData>
	{
		// Token: 0x06037C3E RID: 228414 RVA: 0x00F97D54 File Offset: 0x00F95F54
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06037C3F RID: 228415 RVA: 0x00F97E9F File Offset: 0x00F9609F
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
		}

		// Token: 0x06037C40 RID: 228416 RVA: 0x00F97EC2 File Offset: 0x00F960C2
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06037C41 RID: 228417 RVA: 0x00F97ECC File Offset: 0x00F960CC
		public override void Refresh(RewardContentData contentData, bool isSelected, int gridIndex)
		{
			this.RewardData = contentData;
			IActivityRewardData rewardData = contentData.RewardData;
			if (rewardData.NameTextArgs != null)
			{
				base.GetText(1).SetText(rewardData.NameTextArgs[0] + "/" + rewardData.NameTextArgs[1], true);
				base.GetText(0).SetText(rewardData.NameText ?? "", true);
			}
			base.GetButton(4).RootUIComp.Get().SetUIActive(rewardData.RewardState == EActivityRewardState.Enable);
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(rewardData.RewardState == EActivityRewardState.Disabled);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(rewardData.RewardState == EActivityRewardState.Claimed);
			}
			GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.RefreshByData(new List<TItem>(rewardData.RewardList), null, false);
		}

		// Token: 0x06037C42 RID: 228418 RVA: 0x00F97FA7 File Offset: 0x00F961A7
		private void OnClickButton()
		{
			RewardContentData rewardData = this.RewardData;
			if (rewardData == null)
			{
				return;
			}
			IActivityRewardData rewardData2 = rewardData.RewardData;
			if (rewardData2 == null)
			{
				return;
			}
			Action clickFunction = rewardData2.ClickFunction;
			if (clickFunction == null)
			{
				return;
			}
			clickFunction();
		}

		// Token: 0x0401D6E2 RID: 120546
		private RewardContentData RewardData;

		// Token: 0x0401D6E3 RID: 120547
		private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

		// Token: 0x0200B483 RID: 46211
		[NullableContext(0)]
		public class EBossRushRewardItemComponent
		{
			// Token: 0x04037D2B RID: 228651
			public const int NameText = 0;

			// Token: 0x04037D2C RID: 228652
			public const int NumText = 1;

			// Token: 0x04037D2D RID: 228653
			public const int RewardLayout = 2;

			// Token: 0x04037D2E RID: 228654
			public const int RewardItem = 3;

			// Token: 0x04037D2F RID: 228655
			public const int Button = 4;

			// Token: 0x04037D30 RID: 228656
			public const int DoingItem = 5;

			// Token: 0x04037D31 RID: 228657
			public const int ClaimedItem = 6;
		}
	}
}
