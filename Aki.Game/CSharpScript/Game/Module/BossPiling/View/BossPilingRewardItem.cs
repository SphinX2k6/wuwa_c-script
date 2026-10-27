using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View
{
	// Token: 0x02005C1B RID: 23579
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class BossPilingRewardItem : GridProxyAbstract<ActivityRewardData>
	{
		// Token: 0x0603B945 RID: 244037 RVA: 0x00E35944 File Offset: 0x00E33B44
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

		// Token: 0x0603B946 RID: 244038 RVA: 0x00E35A8F File Offset: 0x00E33C8F
		protected override void OnStart()
		{
			this.ItemLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetHorizontalLayout(2), new Func<CommonItemSmallItemGrid>(this.InitGridItem), null, false, true);
		}

		// Token: 0x0603B947 RID: 244039 RVA: 0x00E35AB2 File Offset: 0x00E33CB2
		private CommonItemSmallItemGrid InitGridItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603B948 RID: 244040 RVA: 0x00E35ABC File Offset: 0x00E33CBC
		public override void Refresh(ActivityRewardData data, bool isSelected, int gridIndex)
		{
			this.RewardData = data;
			base.GetText(1).SetText(data.NameTextArgs[0] + "/" + data.NameTextArgs[1], true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "BossPilingActivity_Reward08", new <>z__ReadOnlySingleElementList<object>(data.NameTextArgs[1]));
			base.GetButton(4).RootUIComp.Get().SetUIActive(data.RewardState == EActivityRewardState.Enable);
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(data.RewardState == EActivityRewardState.Disabled);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(data.RewardState == EActivityRewardState.Claimed);
			}
			GenericLayout<CommonItemSmallItemGrid, TItem> itemLayout = this.ItemLayout;
			if (itemLayout == null)
			{
				return;
			}
			itemLayout.RefreshByData(data.RewardList ?? Array.Empty<TItem>(), null, false);
		}

		// Token: 0x0603B949 RID: 244041 RVA: 0x00E35B93 File Offset: 0x00E33D93
		private void OnClickButton()
		{
			ActivityRewardData rewardData = this.RewardData;
			if (rewardData == null)
			{
				return;
			}
			Action clickFunction = rewardData.ClickFunction;
			if (clickFunction == null)
			{
				return;
			}
			clickFunction();
		}

		// Token: 0x0401F056 RID: 127062
		[Nullable(2)]
		private ActivityRewardData RewardData;

		// Token: 0x0401F057 RID: 127063
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<CommonItemSmallItemGrid, TItem> ItemLayout;

		// Token: 0x0200BE07 RID: 48647
		[NullableContext(0)]
		private enum EReward
		{
			// Token: 0x040394C6 RID: 234694
			NameText,
			// Token: 0x040394C7 RID: 234695
			NumText,
			// Token: 0x040394C8 RID: 234696
			RewardLayout,
			// Token: 0x040394C9 RID: 234697
			RewardItem,
			// Token: 0x040394CA RID: 234698
			Button,
			// Token: 0x040394CB RID: 234699
			DoingItem,
			// Token: 0x040394CC RID: 234700
			ClaimedItem
		}
	}
}
