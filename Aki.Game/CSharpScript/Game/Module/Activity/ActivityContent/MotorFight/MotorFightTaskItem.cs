using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200641D RID: 25629
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightTaskItem : GridProxyAbstract<MotorFightTaskData>
	{
		// Token: 0x06040736 RID: 263990 RVA: 0x00F986E8 File Offset: 0x00F968E8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, this.OnRewardBtnClick);
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040737 RID: 263991 RVA: 0x00F9882D File Offset: 0x00F96A2D
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x06040738 RID: 263992 RVA: 0x00F98850 File Offset: 0x00F96A50
		public override void Refresh(MotorFightTaskData data, bool isSelected, int gridIndex)
		{
			this.RewardScroll.RefreshByData(data.RewardList, delegate
			{
				this.RewardScroll.ScrollToLeft(0);
			}, false);
			UUIItem item = base.GetItem(7);
			if (item != null)
			{
				item.SetUIActive(data.IsUnclaimed);
			}
			base.GetButton(4).RootUIComp.Get().SetUIActive(data.IsUnclaimed);
			base.GetSprite(5).SetUIActive(data.IsFinished);
			base.GetText(6).SetUIActive(data.IsDoing);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.TaskName, Array.Empty<object>());
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetUIActive(data.Target != 0);
			}
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Current);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Target);
			text2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06040739 RID: 263993 RVA: 0x00F98955 File Offset: 0x00F96B55
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x04021824 RID: 137252
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x04021825 RID: 137253
		[Nullable(2)]
		public Action OnRewardBtnClick;

		// Token: 0x0200C648 RID: 50760
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403BDCF RID: 245199
			public const int TextName = 0;

			// Token: 0x0403BDD0 RID: 245200
			public const int TextProgress = 1;

			// Token: 0x0403BDD1 RID: 245201
			public const int ScrollReward = 2;

			// Token: 0x0403BDD2 RID: 245202
			public const int ItemReward = 3;

			// Token: 0x0403BDD3 RID: 245203
			public const int BtnReward = 4;

			// Token: 0x0403BDD4 RID: 245204
			public const int SpriteFinish = 5;

			// Token: 0x0403BDD5 RID: 245205
			public const int TextDoing = 6;

			// Token: 0x0403BDD6 RID: 245206
			public const int ItemRedDot = 7;
		}
	}
}
