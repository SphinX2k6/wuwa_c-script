using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A23 RID: 23075
	public class SolarSchoolGalleryEndingTabView : UiTabViewBase
	{
		// Token: 0x06038D3F RID: 232767 RVA: 0x00FE8C90 File Offset: 0x00FE6E90
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D40 RID: 232768 RVA: 0x00FE8D1C File Offset: 0x00FE6F1C
		protected override void OnStart()
		{
			this.ScrollView = new LoopScrollView<SolarSchoolGalleryEndingTabItem, SolarSchoolGalleryData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<SolarSchoolGalleryEndingTabItem>(this.InitScrollItem), false);
			this.ActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
		}

		// Token: 0x06038D41 RID: 232769 RVA: 0x00FE8D6C File Offset: 0x00FE6F6C
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			if (this.ShowStartSequence)
			{
				LoopScrollView<SolarSchoolGalleryEndingTabItem, SolarSchoolGalleryData> scrollView = this.ScrollView;
				if (scrollView != null)
				{
					scrollView.GetUiAnimController().Play("", -1, false);
				}
				this.ShowStartSequence = false;
			}
			this.UiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06038D42 RID: 232770 RVA: 0x00FE8DC5 File Offset: 0x00FE6FC5
		[NullableContext(1)]
		private SolarSchoolGalleryEndingTabItem InitScrollItem()
		{
			return new SolarSchoolGalleryEndingTabItem();
		}

		// Token: 0x06038D43 RID: 232771 RVA: 0x00FE8DCC File Offset: 0x00FE6FCC
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			int num;
			if (configParams.Length < 2 || configParams[0] != "GalleryEnding" || !int.TryParse(configParams[1], out num) || num <= 0)
			{
				return null;
			}
			int gridIndex = num - 1;
			LoopScrollView<SolarSchoolGalleryEndingTabItem, SolarSchoolGalleryData> scrollView = this.ScrollView;
			if (((scrollView != null) ? scrollView.TryGetCachedData(gridIndex) : null) == null)
			{
				return null;
			}
			this.ScrollView.ScrollToGridIndex(gridIndex, false);
			SolarSchoolGalleryEndingTabItem solarSchoolGalleryEndingTabItem = this.ScrollView.UnsafeGetGridProxy(gridIndex, false);
			UUIItem uuiitem = (solarSchoolGalleryEndingTabItem != null) ? solarSchoolGalleryEndingTabItem.GetGuideEndingItem() : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}

		// Token: 0x06038D44 RID: 232772 RVA: 0x00FE8E55 File Offset: 0x00FE7055
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolGalleryUpdate, new Action(this.RefreshView));
		}

		// Token: 0x06038D45 RID: 232773 RVA: 0x00FE8E73 File Offset: 0x00FE7073
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolGalleryUpdate, new Action(this.RefreshView));
		}

		// Token: 0x06038D46 RID: 232774 RVA: 0x00FE8E94 File Offset: 0x00FE7094
		private void RefreshView()
		{
			List<SolarSchoolGalleryData> galleryDataList = this.ActivityData.GetGalleryDataList(SolarSchoolGalleryType.Ending);
			this.ScrollView.RefreshByData(galleryDataList, true, null, false);
			int num = 0;
			using (List<SolarSchoolGalleryData>.Enumerator enumerator = galleryDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsUnlock)
					{
						num++;
					}
				}
			}
			UUIText text = base.GetText(3);
			LguiUtil.Instance.TrySetLocalTextNew(text, "SolarSchoolRewardCounting", new <>z__ReadOnlyArray<object>(new object[]
			{
				num,
				galleryDataList.Count
			}));
		}

		// Token: 0x0401DE8D RID: 122509
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SolarSchoolGalleryEndingTabItem, SolarSchoolGalleryData> ScrollView;

		// Token: 0x0401DE8E RID: 122510
		[Nullable(2)]
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0401DE8F RID: 122511
		private bool ShowStartSequence = true;

		// Token: 0x0200B5EE RID: 46574
		private class EComponents
		{
			// Token: 0x04038430 RID: 230448
			public const int LoopScroll = 0;

			// Token: 0x04038431 RID: 230449
			public const int ScrollItem = 1;

			// Token: 0x04038432 RID: 230450
			public const int ConsumText = 2;

			// Token: 0x04038433 RID: 230451
			public const int ConsumValueText = 3;
		}
	}
}
