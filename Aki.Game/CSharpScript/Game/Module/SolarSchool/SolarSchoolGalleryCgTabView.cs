using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A1F RID: 23071
	public class SolarSchoolGalleryCgTabView : UiTabViewBase
	{
		// Token: 0x06038D1D RID: 232733 RVA: 0x00FE7C44 File Offset: 0x00FE5E44
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

		// Token: 0x06038D1E RID: 232734 RVA: 0x00FE7CD0 File Offset: 0x00FE5ED0
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolGalleryCgTabView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolGalleryCgTabView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D1F RID: 232735 RVA: 0x00FE7D0C File Offset: 0x00FE5F0C
		protected override void OnStart()
		{
			this.ScrollView = new LoopScrollView<SolarSchoolGalleryCgTabItem, SolarSchoolGalleryData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<SolarSchoolGalleryCgTabItem>(this.InitScrollItem), false);
			this.ActivityData = SolarSchoolModel.Instance.GetCurrentActivityData();
		}

		// Token: 0x06038D20 RID: 232736 RVA: 0x00FE7D5C File Offset: 0x00FE5F5C
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			this.UiViewSequence.PlayOrReplaySequenceByName("Switch", false, null);
		}

		// Token: 0x06038D21 RID: 232737 RVA: 0x00FE7D89 File Offset: 0x00FE5F89
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.SolarSchoolGalleryUpdate, new Action(this.RefreshView));
			EventSystem.Instance.Add(EEventName.SolarSchoolGalleryViewedUpdate, new Action(this.RefreshView));
		}

		// Token: 0x06038D22 RID: 232738 RVA: 0x00FE7DC3 File Offset: 0x00FE5FC3
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.SolarSchoolGalleryUpdate, new Action(this.RefreshView));
			EventSystem.Instance.Remove(EEventName.SolarSchoolGalleryViewedUpdate, new Action(this.RefreshView));
		}

		// Token: 0x06038D23 RID: 232739 RVA: 0x00FE7DFD File Offset: 0x00FE5FFD
		[NullableContext(1)]
		private SolarSchoolGalleryCgTabItem InitScrollItem()
		{
			return new SolarSchoolGalleryCgTabItem();
		}

		// Token: 0x06038D24 RID: 232740 RVA: 0x00FE7E04 File Offset: 0x00FE6004
		private void RefreshView()
		{
			List<SolarSchoolGalleryData> galleryDataList = this.ActivityData.GetGalleryDataList(SolarSchoolGalleryType.Cg);
			this.ScrollView.RefreshByData(galleryDataList, false, null, false);
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

		// Token: 0x0401DE7F RID: 122495
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<SolarSchoolGalleryCgTabItem, SolarSchoolGalleryData> ScrollView;

		// Token: 0x0401DE80 RID: 122496
		[Nullable(2)]
		private SolarSchoolActivityData ActivityData;

		// Token: 0x0200B5E6 RID: 46566
		private class EComponents
		{
			// Token: 0x04038406 RID: 230406
			public const int LoopScroll = 0;

			// Token: 0x04038407 RID: 230407
			public const int ScrollItem = 1;

			// Token: 0x04038408 RID: 230408
			public const int ConsumText = 2;

			// Token: 0x04038409 RID: 230409
			public const int ConsumValueText = 3;
		}
	}
}
