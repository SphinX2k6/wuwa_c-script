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
	// Token: 0x02004857 RID: 18519
	public class InstanceDungeonRewardView : UiViewBase
	{
		// Token: 0x0602E9AA RID: 190890 RVA: 0x00D02DBF File Offset: 0x00D00FBF
		[NullableContext(1)]
		public InstanceDungeonRewardView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E9AB RID: 190891 RVA: 0x00D02DC8 File Offset: 0x00D00FC8
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

		// Token: 0x0602E9AC RID: 190892 RVA: 0x00D02E52 File Offset: 0x00D01052
		protected override void OnStart()
		{
			this.RewardViewItemScroll = new GenericScrollViewNew<InstanceDungeonRewardItem, ValueTuple<int, int>>(base.GetScrollViewWithScrollbar(2), new Func<InstanceDungeonRewardItem>(this.InitItem), null, false, null);
		}

		// Token: 0x0602E9AD RID: 190893 RVA: 0x00D02E78 File Offset: 0x00D01078
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

		// Token: 0x0602E9AE RID: 190894 RVA: 0x00D02FD4 File Offset: 0x00D011D4
		[NullableContext(1)]
		private InstanceDungeonRewardItem InitItem()
		{
			return new InstanceDungeonRewardItem();
		}

		// Token: 0x04018CB2 RID: 101554
		[Nullable(new byte[]
		{
			2,
			1,
			0
		})]
		private GenericScrollViewNew<InstanceDungeonRewardItem, ValueTuple<int, int>> RewardViewItemScroll;

		// Token: 0x0200A4F3 RID: 42227
		private static class EChildCom
		{
			// Token: 0x0403316F RID: 209263
			public const int TitleText = 0;

			// Token: 0x04033170 RID: 209264
			public const int SubTitleText = 1;

			// Token: 0x04033171 RID: 209265
			public const int RewardLayout = 2;
		}
	}
}
