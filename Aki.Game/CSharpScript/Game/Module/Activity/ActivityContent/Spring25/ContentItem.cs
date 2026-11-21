using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Spring25
{
	// Token: 0x0200501E RID: 20510
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ContentItem : GridProxyAbstract<Spring25InfoContentData>
	{
		// Token: 0x170063F7 RID: 25591
		// (get) Token: 0x06033536 RID: 210230 RVA: 0x00E63CFB File Offset: 0x00E61EFB
		// (set) Token: 0x06033537 RID: 210231 RVA: 0x00E63D03 File Offset: 0x00E61F03
		private Spring25InfoContentData DataCache { get; set; }

		// Token: 0x170063F8 RID: 25592
		// (get) Token: 0x06033538 RID: 210232 RVA: 0x00E63D0C File Offset: 0x00E61F0C
		// (set) Token: 0x06033539 RID: 210233 RVA: 0x00E63D14 File Offset: 0x00E61F14
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ItemScrollView { get; set; }

		// Token: 0x170063F9 RID: 25593
		// (get) Token: 0x0603353A RID: 210234 RVA: 0x00E63D1D File Offset: 0x00E61F1D
		// (set) Token: 0x0603353B RID: 210235 RVA: 0x00E63D25 File Offset: 0x00E61F25
		private ButtonItem ConfirmButtonItem { get; set; }

		// Token: 0x0603353C RID: 210236 RVA: 0x00E63D30 File Offset: 0x00E61F30
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603353D RID: 210237 RVA: 0x00E63E40 File Offset: 0x00E62040
		protected override UniTask OnBeforeStartAsync()
		{
			ContentItem.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ContentItem.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603353E RID: 210238 RVA: 0x00E63E84 File Offset: 0x00E62084
		public override void Refresh(Spring25InfoContentData data, bool isSelected, int gridIndex)
		{
			this.DataCache = data;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), data.NameTextId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), data.SubtitleTextId, data.SubtitleTextArgs);
			this.ItemScrollView.RefreshByData(data.ItemList, null, false);
			UUIText text = base.GetText(2);
			if (data.RightTextId == null)
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
			}
			else
			{
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(text, data.RightTextId, Array.Empty<object>());
			}
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(data.IsDone);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(data.CanReward);
		}

		// Token: 0x0603353F RID: 210239 RVA: 0x00E63F4F File Offset: 0x00E6214F
		private CommonItemSmallItemGrid BuildItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x06033540 RID: 210240 RVA: 0x00E63F56 File Offset: 0x00E62156
		private void HandleOnClick(int index)
		{
			Spring25InfoContentData dataCache = this.DataCache;
			bool flag;
			if (dataCache == null)
			{
				flag = false;
			}
			else
			{
				int taskId = dataCache.TaskId;
				flag = true;
			}
			if (flag)
			{
				ActivitySpring25Controller.Instance.RequestSpringSignDrawRewardRequest(this.DataCache.TaskId);
			}
		}

		// Token: 0x0200ACE5 RID: 44261
		[NullableContext(0)]
		private class EContentComponent
		{
			// Token: 0x0403576B RID: 218987
			public const int ConfirmEItem = 0;

			// Token: 0x0403576C RID: 218988
			public const int ConfirmBItem = 1;

			// Token: 0x0403576D RID: 218989
			public const int RightText = 2;

			// Token: 0x0403576E RID: 218990
			public const int DoneItem = 3;

			// Token: 0x0403576F RID: 218991
			public const int NameText = 4;

			// Token: 0x04035770 RID: 218992
			public const int NumText = 5;

			// Token: 0x04035771 RID: 218993
			public const int ItemScrollView = 6;
		}
	}
}
