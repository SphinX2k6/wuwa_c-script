using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02006147 RID: 24903
	public class RoverlikeInfoTipsView : UiTickViewBase
	{
		// Token: 0x0603EF3B RID: 257851 RVA: 0x00F35192 File Offset: 0x00F33392
		[NullableContext(1)]
		public RoverlikeInfoTipsView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603EF3C RID: 257852 RVA: 0x00F3519C File Offset: 0x00F3339C
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

		// Token: 0x0603EF3D RID: 257853 RVA: 0x00F351E4 File Offset: 0x00F333E4
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

		// Token: 0x0603EF3E RID: 257854 RVA: 0x00F352B3 File Offset: 0x00F334B3
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603EF3F RID: 257855 RVA: 0x00F352B5 File Offset: 0x00F334B5
		protected override void OnTick(float delta)
		{
			ListSliderControl<FloatTipsItem> listSlideControl = this.ListSlideControl;
			if (listSlideControl == null)
			{
				return;
			}
			listSlideControl.Tick(delta);
		}

		// Token: 0x0603EF40 RID: 257856 RVA: 0x00F352C8 File Offset: 0x00F334C8
		[NullableContext(1)]
		private FloatTipsItem CreateProxyFunction()
		{
			return new FloatTipsItem();
		}

		// Token: 0x0603EF41 RID: 257857 RVA: 0x00F352CF File Offset: 0x00F334CF
		private bool CheckNext()
		{
			return !RoverlikeModel.Instance.IsFloatTextEmpty;
		}

		// Token: 0x0603EF42 RID: 257858 RVA: 0x00F352DE File Offset: 0x00F334DE
		private void FinishCallback()
		{
			base.CloseMe(null);
		}

		// Token: 0x04020DB1 RID: 134577
		private const int MAX_LIST_COUNT = 2;

		// Token: 0x04020DB2 RID: 134578
		private const int ITEM_INTERVAL_TIME = 200;

		// Token: 0x04020DB3 RID: 134579
		private const int ITEM_SLIDER_TIME = 200;

		// Token: 0x04020DB4 RID: 134580
		private const int ITEM_SHOW_TIME = 1500;

		// Token: 0x04020DB5 RID: 134581
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private ListSliderControl<FloatTipsItem> ListSlideControl;

		// Token: 0x0200C3A4 RID: 50084
		private class EComponents
		{
			// Token: 0x0403B097 RID: 241815
			public const int RootItem = 0;

			// Token: 0x0403B098 RID: 241816
			public const int FloatTipsItem = 1;
		}
	}
}
