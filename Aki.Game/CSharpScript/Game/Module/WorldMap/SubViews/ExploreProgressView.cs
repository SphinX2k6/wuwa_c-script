using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Area;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap.SubViews
{
	// Token: 0x020047BB RID: 18363
	public class ExploreProgressView : UiViewBase
	{
		// Token: 0x060301C1 RID: 197057 RVA: 0x00B26ADD File Offset: 0x00B24CDD
		[NullableContext(1)]
		public ExploreProgressView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060301C2 RID: 197058 RVA: 0x00B26AE8 File Offset: 0x00B24CE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060301C3 RID: 197059 RVA: 0x00B26BD0 File Offset: 0x00B24DD0
		protected override void OnStart()
		{
			this.ExploreProgressItemScrollView = new GenericScrollView<ExploreProgressView.ExploreProgressItem>(base.GetScrollViewWithScrollbar(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<ExploreProgressView.ExploreProgressItem>(this.InitExploreProgressItem), null);
		}

		// Token: 0x060301C4 RID: 197060 RVA: 0x00B26BF4 File Offset: 0x00B24DF4
		[NullableContext(1)]
		private ILayoutItem<ExploreProgressView.ExploreProgressItem> InitExploreProgressItem(object rawData, UUIItem item, int index)
		{
			IOneExploreItemData oneExploreItemData = rawData as IOneExploreItemData;
			ExploreProgressView.ExploreProgressItem exploreProgressItem = new ExploreProgressView.ExploreProgressItem(item);
			exploreProgressItem.Update(new object[]
			{
				oneExploreItemData
			});
			return new LayoutItem<ExploreProgressView.ExploreProgressItem>
			{
				Key = index,
				Value = exploreProgressItem
			};
		}

		// Token: 0x060301C5 RID: 197061 RVA: 0x00B26C37 File Offset: 0x00B24E37
		protected override void OnBeforeDestroy()
		{
			GenericScrollView<ExploreProgressView.ExploreProgressItem> exploreProgressItemScrollView = this.ExploreProgressItemScrollView;
			if (exploreProgressItemScrollView != null)
			{
				exploreProgressItemScrollView.ClearChildren();
			}
			this.ExploreProgressItemScrollView = null;
		}

		// Token: 0x060301C6 RID: 197062 RVA: 0x00B26C54 File Offset: 0x00B24E54
		protected override void OnAfterShow()
		{
			IAreaExploreInfoData areaExploreInfo = WorldMapModel.Instance.GetAreaExploreInfo();
			if (areaExploreInfo == null)
			{
				return;
			}
			Area? areaInfo = AreaConfig.Instance.GetAreaInfo(areaExploreInfo.AreaId);
			if (areaInfo == null)
			{
				return;
			}
			string areaLocalName = AreaConfig.Instance.GetAreaLocalName(areaInfo.Value.Title);
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(areaLocalName, true);
			}
			LguiUtil.Instance.SetLocalText(base.GetText(2), "ExplorationDegree", new <>z__ReadOnlySingleElementList<object>(areaExploreInfo.ExplorePercent));
			IAreaExploreInfoData areaExploreInfo2 = WorldMapModel.Instance.GetAreaExploreInfo();
			if (((areaExploreInfo2 != null) ? areaExploreInfo2.ExploreProgress : null) != null)
			{
				GenericScrollView<ExploreProgressView.ExploreProgressItem> exploreProgressItemScrollView = this.ExploreProgressItemScrollView;
				if (exploreProgressItemScrollView == null)
				{
					return;
				}
				exploreProgressItemScrollView.RefreshByData<IOneExploreItemData>(areaExploreInfo2.ExploreProgress, null);
			}
		}

		// Token: 0x060301C7 RID: 197063 RVA: 0x00B26D19 File Offset: 0x00B24F19
		private void OnClose()
		{
			UiManager.Instance.CloseView(EUiViewName.ExploreProgressView, null);
		}

		// Token: 0x04019ECE RID: 106190
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<ExploreProgressView.ExploreProgressItem> ExploreProgressItemScrollView;

		// Token: 0x0200AA7D RID: 43645
		public static class EExploreProgressDefine
		{
			// Token: 0x04033E00 RID: 212480
			public const int ConfirmButton = 0;

			// Token: 0x04033E01 RID: 212481
			public const int AreaText = 1;

			// Token: 0x04033E02 RID: 212482
			public const int ProgressText = 2;

			// Token: 0x04033E03 RID: 212483
			public const int ExploreProgressScrollView = 3;
		}

		// Token: 0x0200AA7E RID: 43646
		public class ExploreProgressItem : UiPanelBase
		{
			// Token: 0x0604D931 RID: 317745 RVA: 0x014727F2 File Offset: 0x014709F2
			[NullableContext(1)]
			public ExploreProgressItem(UUIItem uiItem)
			{
				base.CreateThenShowByActor(uiItem.GetOwner(), null);
			}

			// Token: 0x0604D932 RID: 317746 RVA: 0x01472808 File Offset: 0x01470A08
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
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
				this.ComponentRegisterInfos = list;
			}

			// Token: 0x0604D933 RID: 317747 RVA: 0x01472894 File Offset: 0x01470A94
			[NullableContext(1)]
			public void Update(params object[] param)
			{
				if (param.Length != 0)
				{
					IOneExploreItemData oneExploreItemData = param[0] as IOneExploreItemData;
					if (oneExploreItemData != null)
					{
						ExploreProgress? exploreProgressInfoById = WorldMapConfig.Instance.GetExploreProgressInfoById(oneExploreItemData.ExploreProgressId);
						if (exploreProgressInfoById == null)
						{
							return;
						}
						ExploreType? exploreTypeByType = ExploreProgressConfig.Instance.GetExploreTypeByType(exploreProgressInfoById.Value.ExploreType);
						if (exploreTypeByType == null)
						{
							return;
						}
						LguiUtil.Instance.SetLocalTextNew(base.GetText(0), exploreTypeByType.Value.Name, Array.Empty<object>());
						float num = 0f;
						if (oneExploreItemData.ExplorePercent > 0f)
						{
							num = oneExploreItemData.ExplorePercent;
						}
						LguiUtil.Instance.SetLocalText(base.GetText(1), "ExplorationDegree", new <>z__ReadOnlySingleElementList<object>(num));
						double floatPointFloor = MathUtils.Instance.GetFloatPointFloor(MathUtils.Instance.SafeDivide((double)num, 100.0), 2);
						UUISprite sprite = base.GetSprite(2);
						if (sprite == null)
						{
							return;
						}
						sprite.SetFillAmount((float)floatPointFloor);
					}
				}
			}

			// Token: 0x04033E04 RID: 212484
			private const int ONEHUNDRED = 100;

			// Token: 0x0200D103 RID: 53507
			public static class EExploreProgressItemDefine
			{
				// Token: 0x0403EBE5 RID: 256997
				public const int NameText = 0;

				// Token: 0x0403EBE6 RID: 256998
				public const int PercentText = 1;

				// Token: 0x0403EBE7 RID: 256999
				public const int ExpSprite = 2;
			}
		}
	}
}
