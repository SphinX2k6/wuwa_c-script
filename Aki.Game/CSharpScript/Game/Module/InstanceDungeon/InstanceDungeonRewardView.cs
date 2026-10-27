using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200587F RID: 22655
	public class InstanceDungeonRewardView : UiViewBase
	{
		// Token: 0x06039A87 RID: 236167 RVA: 0x00DB3EAB File Offset: 0x00DB20AB
		[NullableContext(1)]
		public InstanceDungeonRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039A88 RID: 236168 RVA: 0x00DB3EB4 File Offset: 0x00DB20B4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039A89 RID: 236169 RVA: 0x00DB3F3E File Offset: 0x00DB213E
		protected override void OnStart()
		{
			this.RewardViewItemScroll = new GenericScrollViewNew<InstanceDungeonRewardItem, ValueTuple<int, int>>(base.GetScrollViewWithScrollbar(2), new Func<InstanceDungeonRewardItem>(this.InitItem), null, false, null);
		}

		// Token: 0x06039A8A RID: 236170 RVA: 0x00DB3F64 File Offset: 0x00DB2164
		protected override void OnBeforeShow()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), "InstanceRewardTitle", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "InstanceRewardSubTitle", Array.Empty<object>());
			int rewardId = InstanceDungeonConfig.Instance.GetConfig(InstanceDungeonEntranceModel.Instance.SelectInstanceId).Value.RewardId;
			Dictionary<int, int> dictionary = ExchangeRewardConfig.Instance.GetExchangeRewardConfig(new int?(rewardId)).Value.RewardId();
			List<ValueTuple<int, int>> list = new List<ValueTuple<int, int>>();
			int curWorldLevel = WorldLevelModel.Instance.CurWorldLevel;
			int recommendLevel = 0;
			int selectIndex = 0;
			foreach (KeyValuePair<int, int> keyValuePair in dictionary)
			{
				list.Add(new ValueTuple<int, int>(keyValuePair.Key, keyValuePair.Value));
				if (recommendLevel < keyValuePair.Key && curWorldLevel >= keyValuePair.Key)
				{
					recommendLevel = keyValuePair.Key;
					selectIndex = list.Count - 1;
				}
			}
			TTimerAction <>9__1;
			this.RewardViewItemScroll.RefreshByData(list, delegate
			{
				foreach (InstanceDungeonRewardItem instanceDungeonRewardItem in this.RewardViewItemScroll.GetScrollItemList())
				{
					instanceDungeonRewardItem.SetCurrentItem(recommendLevel);
				}
				TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
				TTimerAction action;
				if ((action = <>9__1) == null)
				{
					action = (<>9__1 = delegate(float _)
					{
						this.RewardViewItemScroll.ScrollToTop(selectIndex);
					});
				}
				gameplayTimeInstance.Next(action, null, null);
			}, false);
		}

		// Token: 0x06039A8B RID: 236171 RVA: 0x00DB40C0 File Offset: 0x00DB22C0
		[NullableContext(1)]
		private InstanceDungeonRewardItem InitItem()
		{
			return new InstanceDungeonRewardItem();
		}

		// Token: 0x0401E215 RID: 123413
		[Nullable(new byte[]
		{
			2,
			1,
			0
		})]
		private GenericScrollViewNew<InstanceDungeonRewardItem, ValueTuple<int, int>> RewardViewItemScroll;

		// Token: 0x0200BADA RID: 47834
		private static class EChildCom
		{
			// Token: 0x0403876E RID: 231278
			public const int TitleText = 0;

			// Token: 0x0403876F RID: 231279
			public const int SubTitleText = 1;

			// Token: 0x04038770 RID: 231280
			public const int RewardLayout = 2;
		}
	}
}
