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
	// Token: 0x02006E35 RID: 28213
	public class FishingQteSuccessView : UiViewBase
	{
		// Token: 0x06044C6F RID: 281711 RVA: 0x010F8798 File Offset: 0x010F6998
		[NullableContext(1)]
		public FishingQteSuccessView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06044C70 RID: 281712 RVA: 0x010F87A4 File Offset: 0x010F69A4
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

		// Token: 0x06044C71 RID: 281713 RVA: 0x010F88AF File Offset: 0x010F6AAF
		protected override void OnStart()
		{
			this.GenericScrollView = new GenericScrollViewNew<DockyardItemListItem, DockyardItemBlockOriginalData>(base.GetScrollViewWithScrollbar(2), new Func<DockyardItemListItem>(this.InitGridItem), null, false, null);
		}

		// Token: 0x06044C72 RID: 281714 RVA: 0x010F88D4 File Offset: 0x010F6AD4
		protected override void OnBeforeShow()
		{
			List<DockyardItemBlockOriginalData> data = this.OpenParam as List<DockyardItemBlockOriginalData>;
			this.GenericScrollView.RefreshByData(data, null, true);
		}

		// Token: 0x06044C73 RID: 281715 RVA: 0x010F88FB File Offset: 0x010F6AFB
		[NullableContext(1)]
		private DockyardItemListItem InitGridItem()
		{
			return new DockyardItemListItem
			{
				NeedInteract = false
			};
		}

		// Token: 0x06044C74 RID: 281716 RVA: 0x010F8909 File Offset: 0x010F6B09
		private void OnButtonClicked()
		{
			FishingController.Instance.OpenDockyardWareHouseView(false);
			base.CloseMe(null);
		}

		// Token: 0x04023C78 RID: 146552
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<DockyardItemListItem, DockyardItemBlockOriginalData> GenericScrollView;

		// Token: 0x0200CCE0 RID: 52448
		private class EComponents
		{
			// Token: 0x0403DC8E RID: 253070
			public const int ButtonMask = 0;

			// Token: 0x0403DC8F RID: 253071
			public const int ButtonBack = 1;

			// Token: 0x0403DC90 RID: 253072
			public const int ScrollView = 2;

			// Token: 0x0403DC91 RID: 253073
			public const int GridItem = 3;
		}
	}
}
