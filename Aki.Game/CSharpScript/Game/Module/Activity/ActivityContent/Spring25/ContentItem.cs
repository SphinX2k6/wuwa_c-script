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
	// Token: 0x020060A0 RID: 24736
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ContentItem : GridProxyAbstract<Spring25InfoContentData>
	{
		// Token: 0x17009095 RID: 37013
		// (get) Token: 0x0603E872 RID: 256114 RVA: 0x00F1CF37 File Offset: 0x00F1B137
		// (set) Token: 0x0603E873 RID: 256115 RVA: 0x00F1CF3F File Offset: 0x00F1B13F
		private Spring25InfoContentData DataCache { get; set; }

		// Token: 0x17009096 RID: 37014
		// (get) Token: 0x0603E874 RID: 256116 RVA: 0x00F1CF48 File Offset: 0x00F1B148
		// (set) Token: 0x0603E875 RID: 256117 RVA: 0x00F1CF50 File Offset: 0x00F1B150
		private GenericScrollViewNew<CommonItemSmallItemGrid, TItem> ItemScrollView { get; set; }

		// Token: 0x17009097 RID: 37015
		// (get) Token: 0x0603E876 RID: 256118 RVA: 0x00F1CF59 File Offset: 0x00F1B159
		// (set) Token: 0x0603E877 RID: 256119 RVA: 0x00F1CF61 File Offset: 0x00F1B161
		private ButtonItem ConfirmButtonItem { get; set; }

		// Token: 0x0603E878 RID: 256120 RVA: 0x00F1CF6C File Offset: 0x00F1B16C
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

		// Token: 0x0603E879 RID: 256121 RVA: 0x00F1D07C File Offset: 0x00F1B27C
		protected override UniTask OnBeforeStartAsync()
		{
			ContentItem.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ContentItem.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603E87A RID: 256122 RVA: 0x00F1D0C0 File Offset: 0x00F1B2C0
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

		// Token: 0x0603E87B RID: 256123 RVA: 0x00F1D18B File Offset: 0x00F1B38B
		private CommonItemSmallItemGrid BuildItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0603E87C RID: 256124 RVA: 0x00F1D192 File Offset: 0x00F1B392
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

		// Token: 0x0200C2FA RID: 49914
		[NullableContext(0)]
		private class EContentComponent
		{
			// Token: 0x0403AE03 RID: 241155
			public const int ConfirmEItem = 0;

			// Token: 0x0403AE04 RID: 241156
			public const int ConfirmBItem = 1;

			// Token: 0x0403AE05 RID: 241157
			public const int RightText = 2;

			// Token: 0x0403AE06 RID: 241158
			public const int DoneItem = 3;

			// Token: 0x0403AE07 RID: 241159
			public const int NameText = 4;

			// Token: 0x0403AE08 RID: 241160
			public const int NumText = 5;

			// Token: 0x0403AE09 RID: 241161
			public const int ItemScrollView = 6;
		}
	}
}
