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
	// Token: 0x020036EC RID: 14060
	public class ExploreProgressView : UiViewBase
	{
		// Token: 0x06024991 RID: 149905 RVA: 0x00A568E8 File Offset: 0x00A54AE8
		[NullableContext(1)]
		public ExploreProgressView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06024992 RID: 149906 RVA: 0x00A568F4 File Offset: 0x00A54AF4
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

		// Token: 0x06024993 RID: 149907 RVA: 0x00A569DC File Offset: 0x00A54BDC
		protected override void OnStart()
		{
			this.ExploreProgressItemScrollView = new GenericScrollView<ExploreProgressView.ExploreProgressItem>(base.GetScrollViewWithScrollbar(3), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<ExploreProgressView.ExploreProgressItem>(this.InitExploreProgressItem), null);
		}

		// Token: 0x06024994 RID: 149908 RVA: 0x00A56A00 File Offset: 0x00A54C00
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

		// Token: 0x06024995 RID: 149909 RVA: 0x00A56A43 File Offset: 0x00A54C43
		protected override void OnBeforeDestroy()
		{
			GenericScrollView<ExploreProgressView.ExploreProgressItem> exploreProgressItemScrollView = this.ExploreProgressItemScrollView;
			if (exploreProgressItemScrollView != null)
			{
				exploreProgressItemScrollView.ClearChildren();
			}
			this.ExploreProgressItemScrollView = null;
		}

		// Token: 0x06024996 RID: 149910 RVA: 0x00A56A60 File Offset: 0x00A54C60
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

		// Token: 0x06024997 RID: 149911 RVA: 0x00A56B25 File Offset: 0x00A54D25
		private void OnClose()
		{
			UiManager.Instance.CloseView(EUiViewName.ExploreProgressView, null);
		}

		// Token: 0x0401457F RID: 83327
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericScrollView<ExploreProgressView.ExploreProgressItem> ExploreProgressItemScrollView;

		// Token: 0x02009430 RID: 37936
		public static class EExploreProgressDefine
		{
			// Token: 0x0402E589 RID: 189833
			public const int ConfirmButton = 0;

			// Token: 0x0402E58A RID: 189834
			public const int AreaText = 1;

			// Token: 0x0402E58B RID: 189835
			public const int ProgressText = 2;

			// Token: 0x0402E58C RID: 189836
			public const int ExploreProgressScrollView = 3;
		}

		// Token: 0x02009431 RID: 37937
		public class ExploreProgressItem : UiPanelBase
		{
			// Token: 0x06043E3C RID: 278076 RVA: 0x01420D26 File Offset: 0x0141EF26
			[NullableContext(1)]
			public ExploreProgressItem(UUIItem uiItem)
			{
				base.CreateThenShowByActor(uiItem.GetOwner(), null);
			}

			// Token: 0x06043E3D RID: 278077 RVA: 0x01420D3C File Offset: 0x0141EF3C
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

			// Token: 0x06043E3E RID: 278078 RVA: 0x01420DC8 File Offset: 0x0141EFC8
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

			// Token: 0x0402E58D RID: 189837
			private const int ONEHUNDRED = 100;

			// Token: 0x0200BCE1 RID: 48353
			public static class EExploreProgressItemDefine
			{
				// Token: 0x0403A02D RID: 237613
				public const int NameText = 0;

				// Token: 0x0403A02E RID: 237614
				public const int PercentText = 1;

				// Token: 0x0403A02F RID: 237615
				public const int ExpSprite = 2;
			}
		}
	}
}
