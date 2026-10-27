using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.BossRush
{
	// Token: 0x0200690C RID: 26892
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class BossRushRewardItem : GridProxyAbstract<RewardContentData>
	{
		// Token: 0x060430E6 RID: 274662 RVA: 0x01056720 File Offset: 0x01054920
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

		// Token: 0x060430E7 RID: 274663 RVA: 0x0105686B File Offset: 0x01054A6B
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
		}

		// Token: 0x060430E8 RID: 274664 RVA: 0x0105688E File Offset: 0x01054A8E
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x060430E9 RID: 274665 RVA: 0x01056898 File Offset: 0x01054A98
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
			itemLayout.RefreshByData(rewardData.RewardList.ToList<TItem>() ?? new List<TItem>(), null, false);
		}

		// Token: 0x060430EA RID: 274666 RVA: 0x0105697C File Offset: 0x01054B7C
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

		// Token: 0x04022E86 RID: 142982
		private RewardContentData RewardData;

		// Token: 0x04022E87 RID: 142983
		private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

		// Token: 0x0200CABB RID: 51899
		[NullableContext(0)]
		public class EBossRushRewardItemComponent
		{
			// Token: 0x0403D451 RID: 250961
			public const int NameText = 0;

			// Token: 0x0403D452 RID: 250962
			public const int NumText = 1;

			// Token: 0x0403D453 RID: 250963
			public const int RewardLayout = 2;

			// Token: 0x0403D454 RID: 250964
			public const int RewardItem = 3;

			// Token: 0x0403D455 RID: 250965
			public const int Button = 4;

			// Token: 0x0403D456 RID: 250966
			public const int DoingItem = 5;

			// Token: 0x0403D457 RID: 250967
			public const int ClaimedItem = 6;
		}
	}
}
