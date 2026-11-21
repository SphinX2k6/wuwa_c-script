using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MotorFight
{
	// Token: 0x0200539B RID: 21403
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class MotorFightTaskItem : GridProxyAbstract<MotorFightTaskData>
	{
		// Token: 0x060353F7 RID: 218103 RVA: 0x00EDF688 File Offset: 0x00EDD888
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

		// Token: 0x060353F8 RID: 218104 RVA: 0x00EDF7CD File Offset: 0x00EDD9CD
		protected override void OnStart()
		{
			this.RewardScroll = new GenericScrollViewNew<CommonItemSmallItemGrid, TItem>(base.GetScrollViewWithScrollbar(2), new Func<CommonItemSmallItemGrid>(this.CreateRewardItem), null, false, null);
		}

		// Token: 0x060353F9 RID: 218105 RVA: 0x00EDF7F0 File Offset: 0x00EDD9F0
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

		// Token: 0x060353FA RID: 218106 RVA: 0x00EDF8F5 File Offset: 0x00EDDAF5
		private CommonItemSmallItemGrid CreateRewardItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0401C153 RID: 115027
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> RewardScroll;

		// Token: 0x0401C154 RID: 115028
		[Nullable(2)]
		public Action OnRewardBtnClick;

		// Token: 0x0200B02F RID: 45103
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403672C RID: 223020
			public const int TextName = 0;

			// Token: 0x0403672D RID: 223021
			public const int TextProgress = 1;

			// Token: 0x0403672E RID: 223022
			public const int ScrollReward = 2;

			// Token: 0x0403672F RID: 223023
			public const int ItemReward = 3;

			// Token: 0x04036730 RID: 223024
			public const int BtnReward = 4;

			// Token: 0x04036731 RID: 223025
			public const int SpriteFinish = 5;

			// Token: 0x04036732 RID: 223026
			public const int TextDoing = 6;

			// Token: 0x04036733 RID: 223027
			public const int ItemRedDot = 7;
		}
	}
}
