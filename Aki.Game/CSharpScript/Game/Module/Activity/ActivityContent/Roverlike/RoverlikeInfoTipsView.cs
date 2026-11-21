using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020050C5 RID: 20677
	public class RoverlikeInfoTipsView : UiTickViewBase
	{
		// Token: 0x06033BFB RID: 211963 RVA: 0x00E7C072 File Offset: 0x00E7A272
		[NullableContext(1)]
		public RoverlikeInfoTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06033BFC RID: 211964 RVA: 0x00E7C07C File Offset: 0x00E7A27C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06033BFD RID: 211965 RVA: 0x00E7C0C4 File Offset: 0x00E7A2C4
		protected override void OnStart()
		{
			if (RoverlikeModel.Instance.IsFloatTextEmpty)
			{
				base.CloseMe(null);
				return;
			}
			UUIItem item = base.GetItem(1);
			item.SetUIActive(false);
			this.ListSlideControl = new ListSliderControl<FloatTipsItem>(new ListSliderControlData<FloatTipsItem>(base.GetRootItem(), new Func<FloatTipsItem>(this.CreateProxyFunction), new Func<bool>(this.CheckNext))
			{
				ChildTemplate = item,
				MaxShowCount = new int?(2),
				AddItemTime = new float?((float)200),
				ItemShowTime = new float?((float)1500),
				ItemSliderTime = new float?((float)200),
				TickMode = new ETickItemMode?(ETickItemMode.TickOnlyTop),
				FinishCallback = new Action(this.FinishCallback)
			});
			this.ListSlideControl.DisEnableParentLayout();
		}

		// Token: 0x06033BFE RID: 211966 RVA: 0x00E7C193 File Offset: 0x00E7A393
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06033BFF RID: 211967 RVA: 0x00E7C195 File Offset: 0x00E7A395
		protected override void OnTick(float delta)
		{
			ListSliderControl<FloatTipsItem> listSlideControl = this.ListSlideControl;
			if (listSlideControl == null)
			{
				return;
			}
			listSlideControl.Tick(delta);
		}

		// Token: 0x06033C00 RID: 211968 RVA: 0x00E7C1A8 File Offset: 0x00E7A3A8
		[NullableContext(1)]
		private FloatTipsItem CreateProxyFunction()
		{
			return new FloatTipsItem();
		}

		// Token: 0x06033C01 RID: 211969 RVA: 0x00E7C1AF File Offset: 0x00E7A3AF
		private bool CheckNext()
		{
			return !RoverlikeModel.Instance.IsFloatTextEmpty;
		}

		// Token: 0x06033C02 RID: 211970 RVA: 0x00E7C1BE File Offset: 0x00E7A3BE
		private void FinishCallback()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401B6DE RID: 112350
		private const int MAX_LIST_COUNT = 2;

		// Token: 0x0401B6DF RID: 112351
		private const int ITEM_INTERVAL_TIME = 200;

		// Token: 0x0401B6E0 RID: 112352
		private const int ITEM_SLIDER_TIME = 200;

		// Token: 0x0401B6E1 RID: 112353
		private const int ITEM_SHOW_TIME = 1500;

		// Token: 0x0401B6E2 RID: 112354
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ListSliderControl<FloatTipsItem> ListSlideControl;

		// Token: 0x0200AD8B RID: 44427
		private class EComponents
		{
			// Token: 0x040359F8 RID: 219640
			public const int RootItem = 0;

			// Token: 0x040359F9 RID: 219641
			public const int FloatTipsItem = 1;
		}
	}
}
