using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FB6 RID: 24502
	public class FishingQteSuccessView : UiViewBase
	{
		// Token: 0x0603ADFC RID: 241148 RVA: 0x010A2D08 File Offset: 0x010A0F08
		[NullableContext(1)]
		public FishingQteSuccessView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603ADFD RID: 241149 RVA: 0x010A2D14 File Offset: 0x010A0F14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnButtonClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ADFE RID: 241150 RVA: 0x010A2E1F File Offset: 0x010A101F
		protected override void OnStart()
		{
			this.GenericScrollView = new GenericScrollViewNew<DockyardItemListItem, DockyardItemBlockOriginalData>(base.GetScrollViewWithScrollbar(2), new Func<DockyardItemListItem>(this.InitGridItem), null, false, null);
		}

		// Token: 0x0603ADFF RID: 241151 RVA: 0x010A2E44 File Offset: 0x010A1044
		protected override void OnBeforeShow()
		{
			List<DockyardItemBlockOriginalData> data = this.OpenParam as List<DockyardItemBlockOriginalData>;
			this.GenericScrollView.RefreshByData(data, null, true);
		}

		// Token: 0x0603AE00 RID: 241152 RVA: 0x010A2E6B File Offset: 0x010A106B
		[NullableContext(1)]
		private DockyardItemListItem InitGridItem()
		{
			return new DockyardItemListItem
			{
				NeedInteract = false
			};
		}

		// Token: 0x0603AE01 RID: 241153 RVA: 0x010A2E79 File Offset: 0x010A1079
		private void OnButtonClicked()
		{
			FishingController.Instance.OpenDockyardWareHouseView(false);
			base.CloseMe(null);
		}

		// Token: 0x0401EF2D RID: 126765
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DockyardItemListItem, DockyardItemBlockOriginalData> GenericScrollView;

		// Token: 0x0200B8D0 RID: 47312
		private class EComponents
		{
			// Token: 0x040390B0 RID: 233648
			public const int ButtonMask = 0;

			// Token: 0x040390B1 RID: 233649
			public const int ButtonBack = 1;

			// Token: 0x040390B2 RID: 233650
			public const int ScrollView = 2;

			// Token: 0x040390B3 RID: 233651
			public const int GridItem = 3;
		}
	}
}
